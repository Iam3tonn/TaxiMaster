using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТаксиМастер
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDrivers();
        }
        private void LoadDrivers(string search = "")
        {
            panelDrivers.Controls.Clear();

            string query = @"SELECT DriverID, NameDriver, DateOfBirth, LicenseNumber, LicenseExpiryDate, 
                            Address, PhoneNumber, Email, Rating, AvgRating, IsPremium
                     FROM Drivers$
                     WHERE NameDriver LIKE @search";

            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int driverId = Convert.ToInt32(reader["DriverID"]);
                    double avgRating = Convert.ToDouble(reader["AvgRating"]); // S
                    int isPremium = Convert.ToBoolean(reader["IsPremium"]) ? 1 : 0; // P

                    int totalTrips = GetCountFromQuery($"SELECT COUNT(*) FROM Trips$ WHERE DriverID = {driverId}");
                    int completedTrips = GetCountFromQuery($"SELECT COUNT(*) FROM Trips$ WHERE DriverID = {driverId} AND Status = 'Завершена'");
                    int totalViolations = GetCountFromQuery($"SELECT COUNT(*) FROM Violations$ WHERE DriverID = {driverId}");

                    double violationCoef = DriverCalculator.CalculateViolationCoefficient(totalViolations, totalTrips);

                    int C = totalTrips == 0 ? 0 : (int)Math.Round((double)completedTrips / totalTrips * 5); // К = от 0 до 5
                    double A = 1.0 - violationCoef / 2.0; // Аккуратность
                    int rating = DriverCalculator.CalculateRating(avgRating, C, A, isPremium);
                    UpdateDriverRating(driverId, rating);


                    // --- Создание карточки водителя ---
                    var card = new Panel
                    {
                        Width = panelDrivers.Width - 30,
                        Height = 160,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5),
                        BackColor = ColorTranslator.FromHtml("#CCFFFF"),
                        Tag = driverId
                    };

                    var label = new Label
                    {
                        Text = $"ФИО: {reader["NameDriver"]}\n" +
                               $"Дата рождения: {Convert.ToDateTime(reader["DateOfBirth"]).ToShortDateString()}\n" +
                               $"ВУ: {reader["LicenseNumber"]} / {Convert.ToDateTime(reader["LicenseExpiryDate"]).ToShortDateString()}\n" +
                               $"Телефон: {reader["PhoneNumber"]}\n" +
                               $"Email: {reader["Email"]}\n" +
                               $"Коэф. нарушений: {violationCoef}\n" +
                               $"Рейтинг: {rating}",
                        AutoSize = true,
                        Location = new Point(10, 10),
                        Font = new Font("Sitka Text", 9)
                    };

                    // --- Кнопка "Редактировать" ---
                    var btnEdit = new Button
                    {
                        Text = "Редактировать",
                        Size = new Size(110, 25),
                        Location = new Point(card.Width - 250, 10),
                        BackColor = Color.LightGray
                    };
                    btnEdit.Click += (s, e) =>
                    {
                        var form = new DriverForm(driverId);
                        if (form.ShowDialog() == DialogResult.OK)
                            LoadDrivers();
                    };

                    // --- Кнопка "История поездок" ---
                    var btnTrips = new Button
                    {
                        Text = "История поездок",
                        Size = new Size(120, 25),
                        Location = new Point(card.Width - 120, 10),
                        BackColor = Color.LightGray
                    };
                    btnTrips.Click += (s, e) =>
                    {
                        var form = new TripsForm(driverId);
                        form.ShowDialog();
                    };

                    card.Controls.Add(label);
                    card.Controls.Add(btnEdit);
                    card.Controls.Add(btnTrips);
                    panelDrivers.Controls.Add(card);
                }
            }
        }

        private void UpdateDriverRating(int driverId, int rating)
        {
            string query = "UPDATE Drivers$ SET Rating = @rating WHERE DriverID = @id";

            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@id", driverId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            var form = new DriverForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadDrivers();
        }

        private void btnEditDriver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для редактирования выбери карточку водителя кликом по ней.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnTrips_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelDrivers.Controls.Count == 0)
                    return;

                Panel selected = null;

                // Пример: можно использовать текущую выделенную или кликать по одной
                foreach (Control ctrl in panelDrivers.Controls)
                {
                    if (ctrl.Focused) selected = ctrl as Panel;
                }

                if (selected != null && selected.Tag != null)
                {
                    int driverId = Convert.ToInt32(selected.Tag);
                    var form = new TripsForm(driverId);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выбери водителя (клик по карточке), чтобы посмотреть его поездки.",
                                    "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии истории поездок:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadDrivers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDrivers(txtSearch.Text.Trim());
        }
        private int GetCountFromQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Настройки формы
            this.Text = "Список водителей";
            this.BackColor = Color.White;

            // Поле поиска (txtSearch)
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Sitka Text", 9);

            // Кнопка поиска (btnSearch)
            btnSearch.Text = "Найти";
            btnSearch.BackColor = ColorTranslator.FromHtml("#CCCCFF");
            btnSearch.Font = new Font("Sitka Text", 9);
            btnSearch.Click += (s, e2) => LoadDrivers(txtSearch.Text);

            // FlowLayoutPanel (panelDrivers)
            panelDrivers.BackColor = Color.WhiteSmoke;
            panelDrivers.AutoScroll = true;
            panelDrivers.WrapContents = true;

            // Кнопки снизу
            SetupButtonStyle(btnAddDriver, "Добавить водителя");
            SetupButtonStyle(btnEditDriver, "Редактировать водителя");
            SetupButtonStyle(btnTrips, "История поездок");
            SetupButtonStyle(btnRefresh, "Обновить список");

            btnAddDriver.Click += btnAddDriver_Click;
            btnEditDriver.Click += btnEditDriver_Click;
            btnTrips.Click += btnTrips_Click;
            btnRefresh.Click += (s, e2) => LoadDrivers();

            toolTip1.SetToolTip(txtSearch, "Введите ФИО для поиска водителя");
            toolTip1.SetToolTip(btnSearch, "Найти водителя по ФИО");

            toolTip1.SetToolTip(btnAddDriver, "Добавить нового водителя в систему");
            toolTip1.SetToolTip(btnEditDriver, "Редактировать выбранного водителя");
            toolTip1.SetToolTip(btnTrips, "Просмотреть историю поездок выбранного водителя");
            toolTip1.SetToolTip(btnRefresh, "Обновить список водителей");
            toolTip1.SetToolTip(panelDrivers, "Здесь отображаются все зарегистрированные водители");

        }
        private void SetupButtonStyle(Button btn, string text)
        {
            btn.Text = text;
            btn.BackColor = ColorTranslator.FromHtml("#CCFFFF");
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Sitka Text", 9);
        }

    }
}
