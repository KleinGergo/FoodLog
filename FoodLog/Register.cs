using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace FoodLog
{
    public partial class Register : Form
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

        public Register()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, base.Height, 25, 25));
                this.Age.KeyPress += new KeyPressEventHandler(Age_KeyPress);
                this.Weight.KeyPress += new KeyPressEventHandler(Weight_KeyPress);
                this.Height.KeyPress += new KeyPressEventHandler(Height_KeyPress);
        }
        private void Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void reg_Click(object sender, EventArgs e)
        {

            LogBase log = new LogBase();
            string query = "SELECT * FROM  USER WHERE USERNAME='" + userName.Text.ToString() + "'";
            SQLiteCommand check = new SQLiteCommand(query, log.myConnection);
            if (String.IsNullOrEmpty(userName.Text) || String.IsNullOrEmpty(pw.Text) || (Male.Checked == false && Female.Checked == false) ||
                String.IsNullOrEmpty(Weight.Text) || String.IsNullOrEmpty(Height.Text) || String.IsNullOrEmpty(Age.Text) || (Stay.Checked == false && Reduce.Checked == false && Grow.Checked == false))
            {
                MessageBox.Show("Hiányosan töltötte ki az adatokat!", "Hiányos adat!");

            }
          
            else
            {
                log.OpenConnection();
                SQLiteDataReader result = check.ExecuteReader();
                if (result.HasRows)
                {

                    MessageBox.Show("A felhasználónév már foglalt!", "Regisztráció");
                    userName.Clear();
                    pw.Clear();
                    log.CloseConnection();
                }
                else
                {
                    query = "INSERT INTO USER ('Username', 'Password', 'Weight', 'Height', 'Age', 'Sex', 'Goal') VALUES (@Username, @Password, @Weight, @Height, @Age, @Sex, @Goal)";
                    SQLiteCommand register = new SQLiteCommand(query, log.myConnection);
                    register.Parameters.AddWithValue("@Username", userName.Text.ToString());
                    register.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.HashPassword(pw.Text.ToString()));
                    register.Parameters.AddWithValue("@Weight", int.Parse(Weight.Text));
                    register.Parameters.AddWithValue("@Height", int.Parse(Height.Text));
                    register.Parameters.AddWithValue("@Age", int.Parse(Age.Text));
                    if (Male.Checked== true)
                        register.Parameters.AddWithValue("@Sex", 1);
                    if (Female.Checked==true)
                        register.Parameters.AddWithValue("@Sex", 0);
                    if (Reduce.Checked == true)
                        register.Parameters.AddWithValue("@Goal", 0);
                    if (Grow.Checked == true)
                        register.Parameters.AddWithValue("@Goal", 1);
                    if (Stay.Checked == true)
                        register.Parameters.AddWithValue("@Goal", 2);
                    var res = register.ExecuteNonQuery();
                    log.CloseConnection();
                    if (res > 0)
                        MessageBox.Show("A regisztráció sikeres volt!", "Regisztráció");


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPanel log = new LoginPanel();
            log.Show();
            this.Close();
        }

        private void ex_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                LogBase log = new LogBase();
                string query = "SELECT * FROM  USER WHERE USERNAME='" + userName.Text.ToString() + "'";
                SQLiteCommand check = new SQLiteCommand(query, log.myConnection);
                if (String.IsNullOrEmpty(userName.Text))
                {
                    MessageBox.Show("Nem adott meg felhasználónevet!", "Hiányos adat!");

                }
                if (String.IsNullOrEmpty(pw.Text))
                    MessageBox.Show("Nem adott meg jelszót!", "Hiányos adat!");
                if (Male.Checked == false && Female.Checked == false)
                    MessageBox.Show("Nem választott nemet!", "Hiányos adat!");
                if (String.IsNullOrEmpty(Weight.Text))
                    MessageBox.Show("Nem adta meg a súlyát!", "Hiányos adat!");
                if (String.IsNullOrEmpty(Height.Text))
                    MessageBox.Show("Nem adta meg a magasságát!", "Hiányos adat!");
                if (String.IsNullOrEmpty(Age.Text))
                    MessageBox.Show("Nem adta meg a korát!", "Hiányos adat!");
                if (Stay.Checked == false && Reduce.Checked == false && Grow.Checked == false)
                    MessageBox.Show("Nem adta meg a célját!", "Hiányos adat!");

                else
                {
                    log.OpenConnection();
                    SQLiteDataReader result = check.ExecuteReader();
                    if (result.HasRows)
                    {

                        MessageBox.Show("A felhasználónév már foglalt!", "Regisztráció");
                        userName.Clear();
                        pw.Clear();
                        log.CloseConnection();
                    }
                    else
                    {
                        query = "INSERT INTO USER ('Username', 'Password', 'Weight', 'Height', 'Age', 'Sex', 'Goal') VALUES (@Username, @Password, @Weight, @Height, @Age, @Sex, @Goal)";
                        SQLiteCommand register = new SQLiteCommand(query, log.myConnection);
                        register.Parameters.AddWithValue("@Username", userName.Text.ToString());
                        register.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.HashPassword(pw.Text.ToString()));
                        register.Parameters.AddWithValue("@Weight", int.Parse(Weight.Text));
                        register.Parameters.AddWithValue("@Height", int.Parse(Height.Text));
                        register.Parameters.AddWithValue("@Age", int.Parse(Age.Text));
                        if (Male.Checked == true)
                            register.Parameters.AddWithValue("@Sex", 1);
                        if (Female.Checked == true)
                            register.Parameters.AddWithValue("@Sex", 0);
                        if (Grow.Checked == true)
                            register.Parameters.AddWithValue("@Goal", 0);
                        if (Reduce.Checked == true)
                            register.Parameters.AddWithValue("@Goal", 1);
                        if (Stay.Checked == true)
                            register.Parameters.AddWithValue("@Goal", 2);
                        var res = register.ExecuteNonQuery();
                        log.CloseConnection();
                        if (res > 0)
                            MessageBox.Show("A regisztráció sikeres volt!", "Regisztráció");



                    }
                }
            }
                
        }

    }

        
}

