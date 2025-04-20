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
    public partial class TripsForm : Form
    {
        private int driverId;
        public TripsForm(int id)
        {
            InitializeComponent();
            driverId = id;
            LoadTrips();
        }

        private void LoadTrips()
        {
            panelTrips.Controls.Clear();

            string query = @"SELECT StartTime, EndTime, StartLocation, EndLocation
                             FROM Trips$
                             WHERE DriverID = @id
                             ORDER BY StartTime DESC";

            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", driverId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var card = new Panel
                    {
                        Width = panelTrips.Width - 30,
                        Height = 80,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5),
                        BackColor = ColorTranslator.FromHtml("#CCCCFF")
                    };

                    var label = new Label
                    {
                        Text = $"Начало: {Convert.ToDateTime(reader["StartTime"])}\n" +
                               $"Конец: {Convert.ToDateTime(reader["EndTime"])}\n" +
                               $"Откуда: {reader["StartLocation"]}\n" +
                               $"Куда: {reader["EndLocation"]}",
                        AutoSize = true,
                        Location = new Point(10, 10),
                        Font = new Font("Sitka Text", 9)
                    };

                    card.Controls.Add(label);
                    panelTrips.Controls.Add(card);
                }
            }
        }

        private void TripsForm_Load(object sender, EventArgs e)
        {
            this.Text = "История поездок водителя";
            this.BackColor = Color.White;
            this.Font = new Font("Sitka Text", 9);
            this.StartPosition = FormStartPosition.CenterParent;

            panelTrips.BackColor = Color.WhiteSmoke;
            panelTrips.BorderStyle = BorderStyle.FixedSingle;
            panelTrips.AutoScroll = true;

            // Подсказка
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(panelTrips, "Здесь отображаются все поездки водителя");
        }
    }
}
