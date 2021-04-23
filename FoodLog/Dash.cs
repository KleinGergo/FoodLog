using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;
using System.Globalization;

namespace FoodLog
{
    public partial class Food : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );
        public string username;
        public int goal;
        DataGridView all = new DataGridView();
        PictureBox delete = new PictureBox();
        DateTimePicker calendar = new DateTimePicker();
        Label infoLabel = new Label();

        public Food(string name)
        {
            this.calendar.ValueChanged += new System.EventHandler(this.calendar_ValueChanged);
            this.delete.Click += new System.EventHandler(this.delete_Click);
            username = name;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            userName.Text = name;
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            calendar.Location = new Point(statusLabel.Left, 55);
            this.Controls.Add(calendar);
            calendar.Hide();
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            LogBase userData = new LogBase();
            string query = "SELECT * FROM USER WHERE USERNAME='" + username + "'";
            userData.OpenConnection();
            SQLiteCommand getUser = new SQLiteCommand(query, userData.myConnection);
            SQLiteDataReader result = getUser.ExecuteReader();
            double calFull = 0;
            double calBevitt = 0;

            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (Convert.ToInt32(result["Sex"]) == 1)
                    {
                        calFull = 66.46 + (13.7 * Convert.ToInt32(result["Weight"])) + (5 * Convert.ToInt32(result["Height"])) - (6.8 * Convert.ToInt32(result["Age"]));
                    }
                    if (Convert.ToInt32(result["Sex"]) == 0)
                    {
                        calFull = 655.1 + (9.6 * Convert.ToInt32(result["Weight"])) + (1.8 * Convert.ToInt32(result["Height"])) - (4.7 * Convert.ToInt32(result["Age"]));
                    }
                    goal = Convert.ToInt32(result["Goal"]);
                }
            }

            query = "SELECT * FROM DATAS WHERE USERNAME='" + username + "'";
            SQLiteCommand getData = new SQLiteCommand(query, userData.myConnection);
            result = getData.ExecuteReader();
            double carbBevitt = 0;
            double protBevitt = 0;
            double fatBevitt = 0;
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (DateTime.Now.ToString("yyyyMMdd") == result["Date"].ToString())
                    {
                        string[] temp = Convert.ToString(result["Cal"]).Split('/');
                        calBevitt = Convert.ToDouble(temp[1]) + calBevitt;
                        carbBevitt = carbBevitt + Convert.ToDouble(result["Carb"]);
                        protBevitt = protBevitt + Convert.ToDouble(result["Prot"]);
                        fatBevitt = fatBevitt + Convert.ToDouble(result["Fat"]);
                    }

                }
            }

            userData.CloseConnection();
            if (goal == 0)
                calFull -= 200;
            if (goal == 1)
                calFull += 500;

            double carbFull = (calFull * 0.45) / 4;
            double protFull = (calFull * 0.35) / 4;
            double fatFull = (calFull * 0.20) / 8;


            double percent = Math.Round((calBevitt / calFull) * 100, MidpointRounding.AwayFromZero);
            if (percent < 100)
            {
                statPercent.Text = percent.ToString() + "%";
                statPercent.Value = Convert.ToInt32(percent);
            }
            else
            {
                statPercent.Text = percent.ToString() + "%";
                statPercent.Value = 100;
            }

            fatLabel.Text = Math.Round(fatBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(fatFull, MidpointRounding.AwayFromZero) + " g";
            protLabel.Text = Math.Round(protBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(protFull, MidpointRounding.AwayFromZero) + " g";
            carbLabel.Text = Math.Round(carbBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(carbFull, MidpointRounding.AwayFromZero) + " g";
            cal.Text = calBevitt + "/" + Math.Ceiling(calFull) + " kcal";


        }
        private void delete_Click(object sender, System.EventArgs e)
        {
            
            Table();
            Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
            if (all.SelectedRows.Count < 1)
                MessageBox.Show("Nem választott ki értéket!");
            else
            {
                Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
                int ID = Convert.ToInt32(all.SelectedCells[0].Value);
                LogBase userData = new LogBase();
                userData.OpenConnection();
                string query = "DELETE FROM DATAS WHERE ROWID='" + ID + "'";
                SQLiteCommand delete = new SQLiteCommand(query, userData.myConnection);
                delete.ExecuteNonQuery();
                userData.CloseConnection();
                Table();
            }
           
           
        }
        private void calendar_ValueChanged(object sender, System.EventArgs e)
        {
            setCalendar();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            btnCal.BackColor = Color.FromArgb(24, 30, 54);
            Info.BackColor = Color.FromArgb(24, 30, 54);
            infoLabel.Hide();
            statPanel.Show();
            carbPanel.Show();
            fatPanel.Show();
            protPanel.Show();
            calPanel.Show();
            add.Show();
            calendar.Hide();
            all.Hide();
            delete.Hide();
            dailyCal.Text = "Összesen elfogyasztott kalória";
            dailyFat.Text = "Összesen elfogyasztott zsír";
            dailyProt.Text = "Összesen elfogyasztott fehérje";
            dailyCarb.Text = "Összesen elfogyasztott szénhidrát";
            dailyPercent.Text = "Összesen elfogyasztott kalória %";
            sum.BackColor = Color.FromArgb(24, 30, 54);

            LogBase userData = new LogBase();
            string query = "SELECT * FROM USER WHERE USERNAME='" + username + "'";
            userData.OpenConnection();
            SQLiteCommand getUser = new SQLiteCommand(query, userData.myConnection);
            SQLiteDataReader result = getUser.ExecuteReader();
            double calFull = 0;
            double calBevitt = 0;

            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (Convert.ToInt32(result["Sex"]) == 1)
                    {
                        calFull = 66.46 + (13.7 * Convert.ToInt32(result["Weight"])) + (5 * Convert.ToInt32(result["Height"])) - (6.8 * Convert.ToInt32(result["Age"]));
                    }
                    if (Convert.ToInt32(result["Sex"]) == 0)
                    {
                        calFull = 655.1 + (9.6 * Convert.ToInt32(result["Weight"])) + (1.8 * Convert.ToInt32(result["Height"])) - (4.7 * Convert.ToInt32(result["Age"]));
                    }
                    goal = Convert.ToInt32(result["Goal"]);
                }
            }

            query = "SELECT * FROM DATAS WHERE USERNAME='" + username + "'";
            SQLiteCommand getData = new SQLiteCommand(query, userData.myConnection);
            result = getData.ExecuteReader();
            double carbBevitt = 0;
            double protBevitt = 0;
            double fatBevitt = 0;
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (DateTime.Now.ToString("yyyyMMdd") == result["Date"].ToString())
                    {
                        string[] temp = Convert.ToString(result["Cal"]).Split('/');
                        calBevitt = Convert.ToDouble(temp[1]) + calBevitt;
                        carbBevitt = carbBevitt + Convert.ToDouble(result["Carb"]);
                        protBevitt = protBevitt + Convert.ToDouble(result["Prot"]);
                        fatBevitt = fatBevitt + Convert.ToDouble(result["Fat"]);
                    }

                }
            }
           

            userData.CloseConnection();
            if (goal == 0)
                calFull -= 200;
            if (goal == 1)
                calFull += 500;

            double carbFull = (calFull * 0.45) / 4;
            double protFull = (calFull * 0.35) / 4;
            double fatFull = (calFull * 0.20) / 8;


            double percent = Math.Round((calBevitt / calFull) * 100, MidpointRounding.AwayFromZero);
            if (percent < 100)
            {
                statPercent.Text = percent.ToString() + "%";    
                statPercent.Value = Convert.ToInt32(percent);
            }
            else
            {
                statPercent.Text = percent.ToString() + "%";
                statPercent.Value = 100;
            }

            fatLabel.Text = Math.Round(fatBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(fatFull, MidpointRounding.AwayFromZero) + " g";
            protLabel.Text = Math.Round(protBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(protFull, MidpointRounding.AwayFromZero) + " g";
            carbLabel.Text = Math.Round(carbBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(carbFull, MidpointRounding.AwayFromZero) + " g";
            cal.Text = calBevitt + "/" + Math.Ceiling(calFull) + " kcal";
            statusLabel.Text = "Főoldal";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            calendar.Value = DateTime.Now;
           
            Application.VisualStyleState = VisualStyleState.ClientAreaEnabled;
            pnlNav.Height = btnCal.Height;
            pnlNav.Top = btnCal.Top;
            pnlNav.Left = btnCal.Left;
            btnCal.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            Info.BackColor = Color.FromArgb(24, 30, 54);
            sum.BackColor = Color.FromArgb(24, 30, 54);
            add.Hide();
            calendar.Show();
            all.Hide();
            setCalendar();
            infoLabel.Hide();
            delete.Hide();
            statusLabel.Text = "Naptár";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories(userName.Text);
            cat.Show();
        }
        private void setCalendar()
        {
            if (Convert.ToDateTime(calendar.Value) > DateTime.Now)
            {
                Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
                MessageBox.Show("A kiválasztott dátum nem lehet későbbi mint a mai dátum!");

            }
            else
            {
                LogBase userData = new LogBase();
                statPanel.Show();
                carbPanel.Show();
                fatPanel.Show();
                protPanel.Show();
                calPanel.Show();
                string query = "SELECT * FROM USER WHERE USERNAME='" + username + "'";
                userData.OpenConnection();
                SQLiteCommand getUser = new SQLiteCommand(query, userData.myConnection);
                SQLiteDataReader result = getUser.ExecuteReader();
                double calFull = 0;
                double calBevitt = 0;

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        if (Convert.ToInt32(result["Sex"]) == 1)
                        {
                            calFull = 66.46 + (13.7 * Convert.ToInt32(result["Weight"])) + (5 * Convert.ToInt32(result["Height"])) - (6.8 * Convert.ToInt32(result["Age"]));
                        }
                        if (Convert.ToInt32(result["Sex"]) == 0)
                        {
                            calFull = 655.1 + (9.6 * Convert.ToInt32(result["Weight"])) + (1.8 * Convert.ToInt32(result["Height"])) - (4.7 * Convert.ToInt32(result["Age"]));
                        }
                        goal = Convert.ToInt32(result["Goal"]);
                    }
                }
                query = "SELECT * FROM DATAS WHERE USERNAME='" + username + "' AND DATE='" + Convert.ToDateTime(calendar.Value).ToString("yyyyMMdd") + "'";
                SQLiteCommand keres = new SQLiteCommand(query, userData.myConnection);
                result = keres.ExecuteReader();
                double carbBevitt = 0;
                double protBevitt = 0;
                double fatBevitt = 0;

                if (result.HasRows)
                {
                    while (result.Read())
                    {

                        string[] temp = Convert.ToString(result["Cal"]).Split('/');
                        calBevitt = Convert.ToDouble(temp[1]) + calBevitt;
                        carbBevitt = carbBevitt + Convert.ToDouble(result["Carb"]);
                        protBevitt = protBevitt + Convert.ToDouble(result["Prot"]);
                        fatBevitt = fatBevitt + Convert.ToDouble(result["Fat"]);


                    }
                }

                userData.CloseConnection();
                if (goal == 0)
                    calFull -= 200;
                if (goal == 1)
                    calFull += 500;

                double carbFull = (calFull * 0.45) / 4;
                double protFull = (calFull * 0.35) / 4;
                double fatFull = (calFull * 0.20) / 8;


                double percent = Math.Round((calBevitt / calFull) * 100, MidpointRounding.AwayFromZero);
                if (percent < 100)
                {
                    statPercent.Text = percent.ToString() + "%";
                    statPercent.Value = Convert.ToInt32(percent);
                }
                else
                {
                    statPercent.Text = percent.ToString() + "%";
                    statPercent.Value = 100;
                }

                fatLabel.Text = Math.Round(fatBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(fatFull, MidpointRounding.AwayFromZero) + " g";
                protLabel.Text = Math.Round(protBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(protFull, MidpointRounding.AwayFromZero) + " g";
                carbLabel.Text = Math.Round(carbBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(carbFull, MidpointRounding.AwayFromZero) + " g";
                cal.Text = calBevitt + "/" + Math.Ceiling(calFull) + " kcal";
                dailyCal.Text = "Összesen elfogyasztott kalória\n" + Convert.ToDateTime(calendar.Value).ToString("yyyy. MM. dd.");
                dailyFat.Text = "Összesen elfogyasztott zsír\n" + Convert.ToDateTime(calendar.Value).ToString("yyyy. MM. dd.");
                dailyProt.Text = "Összesen elfogyasztott fehérje\n" + Convert.ToDateTime(calendar.Value).ToString("yyyy. MM. dd.");
                dailyCarb.Text = "Összesen elfogyasztott szénhidrát\n" + Convert.ToDateTime(calendar.Value).ToString("yyyy. MM. dd.");
                dailyPercent.Text = "Összesen elfogyasztott kalória %\n" + Convert.ToDateTime(calendar.Value).ToString("yyyy. MM. dd.");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Food_Activated(object sender, EventArgs e)
        {
            LogBase userData = new LogBase();
            string query = "SELECT * FROM USER WHERE USERNAME='" + username + "'";
            userData.OpenConnection();
            SQLiteCommand getUser = new SQLiteCommand(query, userData.myConnection);
            SQLiteDataReader result = getUser.ExecuteReader();
            double calFull = 0;
            double calBevitt = 0;

            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (Convert.ToInt32(result["Sex"]) == 1)
                    {
                        calFull = 66.46 + (13.7 * Convert.ToInt32(result["Weight"])) + (5 * Convert.ToInt32(result["Height"])) - (6.8 * Convert.ToInt32(result["Age"]));
                    }
                    if (Convert.ToInt32(result["Sex"]) == 0)
                    {
                        calFull = 655.1 + (9.6 * Convert.ToInt32(result["Weight"])) + (1.8 * Convert.ToInt32(result["Height"])) - (4.7 * Convert.ToInt32(result["Age"]));
                    }
                    goal = Convert.ToInt32(result["Goal"]);
                }
            }

            query = "SELECT * FROM DATAS WHERE USERNAME='" + username + "'";
            SQLiteCommand getData = new SQLiteCommand(query, userData.myConnection);
            result = getData.ExecuteReader();
            double carbBevitt = 0;
            double protBevitt = 0;
            double fatBevitt = 0;
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (DateTime.Now.ToString("yyyyMMdd") == result["Date"].ToString())
                    {
                        string[] temp = Convert.ToString(result["Cal"]).Split('/');
                        calBevitt = Convert.ToDouble(temp[1]) + calBevitt;
                        carbBevitt = carbBevitt + Convert.ToDouble(result["Carb"]);
                        protBevitt = protBevitt + Convert.ToDouble(result["Prot"]);
                        fatBevitt = fatBevitt + Convert.ToDouble(result["Fat"]);
                    }

                }
            }

            userData.CloseConnection();
            if (goal == 0)
                calFull -= 200;
            if (goal == 1)
                calFull += 500;

            double carbFull = (calFull * 0.45) / 4;
            double protFull = (calFull * 0.35) / 4;
            double fatFull = (calFull * 0.20) / 8;


            double percent = Math.Round((calBevitt / calFull) * 100, MidpointRounding.AwayFromZero);
            if (percent < 100)
            {
                statPercent.Text = percent.ToString() + "%";
                statPercent.Value = Convert.ToInt32(percent);
            }
            else
            {
                statPercent.Text = percent.ToString() + "%";
                statPercent.Value = 100;
            }

            fatLabel.Text = Math.Round(fatBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(fatFull, MidpointRounding.AwayFromZero) + " g";
            protLabel.Text = Math.Round(protBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(protFull, MidpointRounding.AwayFromZero) + " g";
            carbLabel.Text = Math.Round(carbBevitt, MidpointRounding.AwayFromZero) + "/" + Math.Round(carbFull, MidpointRounding.AwayFromZero) + " g";
            cal.Text = calBevitt + "/" + Math.Ceiling(calFull) + " kcal";

        }

        private void sum_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Összegzés";
            Table();
            
            all.Show();
        }
        private void Table()
        {
            Application.VisualStyleState = VisualStyleState.NoneEnabled;
            
            pnlNav.Height = sum.Height;
            pnlNav.Top = sum.Top;
            pnlNav.Left = sum.Left;
            Info.BackColor = Color.FromArgb(24, 30, 54);
            sum.BackColor = Color.FromArgb(46, 51, 73);
            btnCal.BackColor = Color.FromArgb(24, 30, 54);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            statPanel.Hide();
            carbPanel.Hide();
            fatPanel.Hide();
            protPanel.Hide();
            infoLabel.Hide();
            calPanel.Hide();
            add.Hide();
            calendar.Hide();
            all.Columns.Clear();
            all.Columns.Add("ID", "ID");
            all.Columns.Add("Username", "Felhasználónév");
            all.Columns.Add("Food", "Étel/Ital");
            all.Columns.Add("cal", "Kalória");
            all.Columns.Add("prot", "Fehérje");
            all.Columns.Add("fat", "Zsír");
            all.Columns.Add("carb", "Szénhidrát");
            all.Columns.Add("date", "Dátum");
            all.Columns["ID"].Visible = false;
            all.Size = new Size(625, 400);
            all.Location = new Point(statusLabel.Left, 75);
            all.AllowUserToAddRows = false;
            all.AllowUserToDeleteRows = false;
            all.ForeColor = Color.White;
            all.GridColor = Color.FromArgb(158, 161, 176);
            all.BorderStyle = BorderStyle.None;
            all.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            all.ScrollBars = ScrollBars.Vertical;
            all.EnableHeadersVisualStyles = false;
            all.MultiSelect = false;
            all.RowHeadersVisible = false;
            all.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            all.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            all.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            all.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 51, 73);
            all.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            all.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            all.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            all.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            all.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            all.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            all.Columns["Food"].ValueType = typeof(String);
            all.BackgroundColor = Color.FromArgb(46, 51, 73);
            all.BackColor = Color.FromArgb(46, 51, 73);
            this.Controls.Add(all);

            LogBase userData = new LogBase();
            userData.OpenConnection();
            string query = "SELECT ROWID, * FROM DATAS WHERE USERNAME='" + username +"' AND DATE='"+DateTime.Now.ToString("yyyyMMdd")+"'";
            SQLiteCommand ossz = new SQLiteCommand(query, userData.myConnection);
            SQLiteDataReader result = ossz.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    string[] temp = Convert.ToString(result["Cal"]).Split('/');
                    var tempDate = DateTime.ParseExact(result["Date"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy. MM. dd.");
                    all.Rows.Add(result["ROWID"], result["Username"], result["Food"], temp[1] + " kcal", result["Prot"] + " g", result["Fat"] + " g", result["carb"] + " g", tempDate.ToString());
                    this.Controls.Add(all);
                }
            }

            delete.Location = new Point(862, 515);
            delete.Size = new Size(100, 50);
            delete.Image = Image.FromFile("delete.png");
            delete.SizeMode = PictureBoxSizeMode.Zoom;
            delete.Cursor = Cursors.Hand;
            this.Controls.Add(delete);
            delete.Show();

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Info.Height;
            pnlNav.Top = Info.Top;
            pnlNav.Left = Info.Left;
            Info.BackColor = Color.FromArgb(46, 51, 73);
            sum.BackColor = Color.FromArgb(24, 30, 54);
            btnCal.BackColor = Color.FromArgb(24, 30, 54);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            statusLabel.Text = "Info";
            statPanel.Hide();
            carbPanel.Hide();
            fatPanel.Hide();
            protPanel.Hide();
            calPanel.Hide();
            add.Hide();
            calendar.Hide();
            all.Hide();
            delete.Hide();
            infoLabel.Show();
            infoLabel.Location = new Point(statusLabel.Left, statusLabel.Top+55);
            infoLabel.ForeColor = Color.FromArgb(158, 161, 176);
            infoLabel.Font = new Font("Microsoft Sans Serif", 11);
            infoLabel.Size = new Size(600, 32);
            infoLabel.BackColor = Color.Transparent;
            infoLabel.Text = "Az alkalmazásban látható ikonok forrása: https://www.flaticon.com/";
            
            this.Controls.Add(infoLabel);


        }
    }
}
