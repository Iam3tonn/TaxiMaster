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
using System.Xml.Linq;

namespace ТаксиМастер
{
    public partial class DriverForm : Form
    {
        private int? driverId = null;
        public DriverForm()
        {
            InitializeComponent();
        }
        public DriverForm(int id) : this()
        {
            driverId = id;
            LoadDriverData(); // Загружаем данные водителя
        }

        private void LoadDriverData()
        {
            string query = "SELECT * FROM Drivers$ WHERE DriverID = @id";

            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", driverId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["NameDriver"].ToString();
                    dtpBirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                    txtLicense.Text = reader["LicenseNumber"].ToString();
                    dtpExpiry.Value = Convert.ToDateTime(reader["LicenseExpiryDate"]);
                    txtAddress.Text = reader["Address"].ToString();
                    txtPhone.Text = reader["PhoneNumber"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    numRating.Value = Convert.ToDecimal(reader["Rating"]);
                }
                else
                {
                    MessageBox.Show("Данные водителя не найдены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close(); // Закрываем форму если данных нет
                }
            }
        }
        private void ValidateForm(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(txtName.Text)
                          && !string.IsNullOrWhiteSpace(txtLicense.Text)
                          && !string.IsNullOrWhiteSpace(txtAddress.Text)
                          && !string.IsNullOrWhiteSpace(txtPhone.Text)
                          && !string.IsNullOrWhiteSpace(txtEmail.Text)
                          && numRating.Value >= 0;

            btnSave.Enabled = allFilled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string query = driverId.HasValue ?
                @"UPDATE Drivers$
                  SET NameDriver = @name, DateOfBirth = @dob, LicenseNumber = @license, LicenseExpiryDate = @expiry,
                      Address = @address, PhoneNumber = @phone, Email = @email, Rating = @rating
                  WHERE DriverID = @id"
                :
                @"INSERT INTO Drivers$ (NameDriver, DateOfBirth, LicenseNumber, LicenseExpiryDate, Address, PhoneNumber, Email, Rating)
                  VALUES (@name, @dob, @license, @expiry, @address, @phone, @email, @rating)";

            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpBirth.Value.Date);
                cmd.Parameters.AddWithValue("@license", txtLicense.Text);
                cmd.Parameters.AddWithValue("@expiry", dtpExpiry.Value.Date);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@rating", (int)numRating.Value);
                if (driverId.HasValue)
                    cmd.Parameters.AddWithValue("@id", driverId.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Данные успешно сохранены!", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLicense.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Введите корректный Email.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            this.Text = "Добавление / редактирование водителя";
            this.BackColor = Color.White;
            this.Font = new Font("Sitka Text", 9);
            this.StartPosition = FormStartPosition.CenterParent;

            // Подсказки
            toolTip1.SetToolTip(txtName, "Введите ФИО водителя (например, Иванов Иван Иванович)");
            toolTip1.SetToolTip(dtpBirth, "Укажите дату рождения водителя");
            toolTip1.SetToolTip(txtLicense, "Введите номер ВУ");
            toolTip1.SetToolTip(dtpExpiry, "Укажите срок действия ВУ");
            toolTip1.SetToolTip(txtAddress, "Введите адрес проживания");
            toolTip1.SetToolTip(txtPhone, "Введите номер телефона (+7...)");
            toolTip1.SetToolTip(txtEmail, "Введите email");
            toolTip1.SetToolTip(numRating, "Укажите рейтинг от 0 до 5");
            toolTip1.SetToolTip(btnSave, "Сохранить водителя");

            // Текст label'ов
            lbName.Text = "ФИО:";
            lbBirth.Text = "Дата рождения:";
            lbLicense.Text = "Номер ВУ:";
            lbExpiry.Text = "Срок действия ВУ:";
            lbAddress.Text = "Адрес:";
            lbPhone.Text = "Телефон:";
            lbEmail.Text = "Email:";
            lbRating.Text = "Рейтинг:";

            // Стиль label'ов
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.Font = new Font("Sitka Text", 9);
                    lbl.ForeColor = Color.Black;
                    lbl.AutoSize = true;
                }
            }

            btnSave.BackColor = ColorTranslator.FromHtml("#CCCCFF");
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Enabled = false;

            // Подключение к изменению текстов
            txtName.TextChanged += ValidateForm;
            txtLicense.TextChanged += ValidateForm;
            txtAddress.TextChanged += ValidateForm;
            txtPhone.TextChanged += ValidateForm;
            txtEmail.TextChanged += ValidateForm;
            numRating.ValueChanged += ValidateForm;

            ValidateForm(null, null); // начальная проверка
        }
    }
}
