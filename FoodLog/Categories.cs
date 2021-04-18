using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace FoodLog
{
    public partial class Categories : Form
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
        ComboBox foods = new ComboBox();
        public string username;
        public Categories(string username)
        {
            this.username = username;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Database data = new Database();
            string query = "SELECT name FROM sqlite_master " + "WHERE type = 'table'" + "ORDER BY 1";
            data.OpenConnection();
            SQLiteCommand listaz = new SQLiteCommand(query, data.myConnection);
            SQLiteDataReader result = listaz.ExecuteReader();
            if(result.HasRows)
            {
                while(result.Read())
                {
                    int i = 0;
                    comboCat.Items.Add(result[i]);
                    i++;
                }
            }
            data.CloseConnection();
            
            comboCat.SelectedIndexChanged += new System.EventHandler(ComboBox_SelectedIndexChanged);
            void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                
                foods.Items.Clear();
                foods.SelectedIndex = -1;
                foods.Location = new Point(comboCat.Left, comboCat.Top + 50);
                foods.Size = new Size(comboCat.Width, comboCat.Height);
                Label type = new Label();
                type.Location = new Point(label1.Left, label1.Top + 50);
                type.Text = "Étel/Ital";
                type.Font = new Font("Segoe UI",11);
                type.ForeColor = Color.FromArgb(158, 161, 176);
                type.TextAlign = ContentAlignment.MiddleLeft;
                this.Controls.Add(type);
                this.Controls.Add(foods);
                string query = "SELECT NAME FROM '" + comboCat.GetItemText(comboCat.SelectedItem) + "'";
                data.OpenConnection();
                SQLiteCommand listaz = new SQLiteCommand(query, data.myConnection);
                SQLiteDataReader result = listaz.ExecuteReader();
                if (result.HasRows)
                {
                        
                        while (result.Read())
                        {
                            int i = 0;
                            foods.Items.Add(result[i]);
                            this.Controls.Add(foods);
                            i++;
                        }
                }
                data.CloseConnection();
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void add_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(comboCat.GetItemText(comboCat.SelectedItem))==true)
            {
                MessageBox.Show("Nem választott kategóriát!","");
            }
            if (String.IsNullOrEmpty(foods.GetItemText(foods.SelectedItem)) == true)
                MessageBox.Show("Nem választott ételt/italt!", "");
            else
            {
                LogBase userData = new LogBase();
                Database foodData = new Database();

                string query = "SELECT * FROM '" + comboCat.GetItemText(comboCat.SelectedItem) + "' WHERE NAME='" + foods.GetItemText(foods.SelectedItem) + "'";
                foodData.OpenConnection();
                SQLiteCommand leker = new SQLiteCommand(query, foodData.myConnection);
                SQLiteDataReader result = leker.ExecuteReader();
                if (result.HasRows)
                {
                    query = "SELECT * FROM USER WHERE USERNAME='" + username + "'";
                    userData.OpenConnection();
                    SQLiteCommand getDatas = new SQLiteCommand(query, userData.myConnection);
                    SQLiteDataReader dataRes = getDatas.ExecuteReader();
                    if (dataRes.HasRows)
                    {
                        while (dataRes.Read())
                        {
                            while (result.Read())
                            {
                                
                                query = "INSERT INTO DATAS ('Username', 'Food', 'Prot', 'Carb', 'Cal', 'Fat', 'Date', 'Weight', 'Height', 'Age', 'Sex', 'Goal') VALUES (@Username, @Food, @Prot, @Carb, @Cal, @Fat, @Date, @Weight, @Height, @Age, @Sex, @Goal)";
                                userData.OpenConnection();
                                SQLiteCommand insert = new SQLiteCommand(query, userData.myConnection);
                                insert.Parameters.AddWithValue("@Username", this.username);
                                insert.Parameters.AddWithValue("@Food", result["Name"].ToString());
                                insert.Parameters.AddWithValue("@Cal", result["Cal"].ToString());
                                insert.Parameters.AddWithValue("@Prot", Convert.ToDouble(result["Prot"]));
                                insert.Parameters.AddWithValue("@Carb", Convert.ToDouble(result["Carb"]));
                                insert.Parameters.AddWithValue("@Fat", Convert.ToDouble(result["Fat"]));
                                insert.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyyMMdd"));
                                insert.Parameters.AddWithValue("@Weight", dataRes["Weight"].ToString());
                                insert.Parameters.AddWithValue("@Height", dataRes["Height"].ToString());
                                insert.Parameters.AddWithValue("@Age", dataRes["Age"].ToString());
                                insert.Parameters.AddWithValue("@Sex", dataRes["Sex"].ToString());
                                insert.Parameters.AddWithValue("@Goal", dataRes["Goal"].ToString());
                                var inResult = insert.ExecuteNonQuery();
                                if (inResult > 0)
                                {

                                    this.Hide();
                                    MessageBox.Show("A hozzáadás sikeres!");

                                }
                            }
                        }



                        userData.CloseConnection();
                    }
                    userData.CloseConnection();
                }
                foodData.CloseConnection();
            }
            
            


        }


       
    }
}
