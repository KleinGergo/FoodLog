using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace FoodLog
{
    public partial class LoginPanel : Form
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
        public LoginPanel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            LogBase login = new LogBase();
            login.OpenConnection();
            login.CloseConnection();
        }

        private void login_Click(object sender, EventArgs e)
        {
            LogBase data = new LogBase();
            
            if(String.IsNullOrEmpty(userName.Text))
            {
                MessageBox.Show("Nem adott meg felhasználónevet!", "Hiányos adat!");
            }
            else if(string.IsNullOrEmpty(pw.Text))
            {
                MessageBox.Show("Nem adott meg jelszót!", "Hiányos adat!");
            }
            else 
            {
                data.OpenConnection();
                SQLiteCommand search = new SQLiteCommand("SELECT * FROM USER WHERE USERNAME='" + userName.Text.ToString() + "'", data.myConnection);
                SQLiteDataReader result = search.ExecuteReader();
                if (result.HasRows)
                {
                    string jelszo = "";
                    while (result.Read())
                    {
                        jelszo = result["Password"].ToString();
                    }
                    if (BCrypt.Net.BCrypt.Verify(pw.Text.ToString(), jelszo))
                    {
                        Food log = new Food(userName.Text.ToString());
                        log.Show();
                        this.Hide();

                    }
                    else
                        MessageBox.Show("A felhasználónév vagy jelszó hibás!","Hibás adat");
                }
                else
                            MessageBox.Show("A felhasználónév nem létezik!");
            }
        }

        private void ex_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                LogBase data = new LogBase();

                if (String.IsNullOrEmpty(userName.Text))
                {
                    MessageBox.Show("Nem adott meg felhasználónevet!", "Hiányos adat!");
                }
                else if (string.IsNullOrEmpty(pw.Text))
                {
                    MessageBox.Show("Nem adott meg jelszót!", "Hiányos adat!");
                }
                else
                {
                    data.OpenConnection();
                    SQLiteCommand search = new SQLiteCommand("SELECT * FROM USER WHERE USERNAME='" + userName.Text.ToString() + "'", data.myConnection);
                    SQLiteDataReader result = search.ExecuteReader();
                    if (result.HasRows)
                    {
                        string jelszo = "";
                        while (result.Read())
                        {
                            jelszo = result["Password"].ToString();
                        }
                        if (BCrypt.Net.BCrypt.Verify(pw.Text.ToString(), jelszo))
                        {
                            Food log = new Food(userName.Text.ToString());
                            log.Show();
                            this.Hide();

                        }
                        else
                            MessageBox.Show("A felhasználónév vagy jelszó hibás!", "Hibás adat");
                    }
                    else
                        MessageBox.Show("A felhasználónév nem létezik!");
                }
            }
        }

    }
}

