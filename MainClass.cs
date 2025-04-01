using rm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Security;
using System.Windows.Forms;

namespace rm
{
    internal class MainClass
    {
        private static readonly string con_string = "Data Source=LAPTOP-EV057OHO;Initial Catalog=RM;Persist Security Info=True;User ID=sa;Password=12345;";
        private static readonly SqlConnection sqlConnection = new SqlConnection(con_string);
        private static SqlConnection con = sqlConnection;


        
        
        public static bool IsValidUser(string username, string upass)
        {
            bool isValid = false;
            string qry = "SELECT * FROM userss WHERE usename = @username AND upass = @upass ";

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, Con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@upass", upass);
                   
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    Con.Open();
                    da.Fill(dt);
                    Con.Close();

                    if (dt.Rows.Count > 0)
                    {
                        isValid = true;
                        USER = dt.Rows[0]["usernum"].ToString();
                        ROLE = dt.Rows[0]["Role"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                if (Con.State == ConnectionState.Open) Con.Close();
            }

            return isValid;
        }
        public static string ROLE { get; private set; }
        public static string USER { get; private set; }
        public static SqlConnection Con { get => con; set => con = value; }

        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }

                    if (Con.State == ConnectionState.Closed) Con.Open();
                    res = cmd.ExecuteNonQuery();
                    if (Con.State == ConnectionState.Open) Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (Con.State == ConnectionState.Open) Con.Close();
            }

            return res;
        }

        public static void LoadData(string qry, DataGridView gv, List<string> columns)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // التأكد من أن عدد الأعمدة في dt يكفي
                    for (int i = 0; i < columns.Count && i < dt.Columns.Count; i++)
                    {
                        // إذا لم يكن العمود موجودًا في DataGridView، نقوم بإنشائه وإضافته
                        if (!gv.Columns.Contains(columns[i]))
                        {
                            DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
                            newCol.Name = columns[i];
                            newCol.HeaderText = columns[i];
                            newCol.DataPropertyName = dt.Columns[i].ColumnName;
                            gv.Columns.Add(newCol);
                        }
                        else
                        {
                            // إذا كان العمود موجودًا، قم بتعيين DataPropertyName مباشرة
                            gv.Columns[columns[i]].DataPropertyName = dt.Columns[i].ColumnName;
                        }
                    }

                    gv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }



        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "Name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;

        }

        internal static void BlurBackground(Form Model)

        {
            Form Background = new Form();

            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = new Size(2000, 2000);
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }





        }


       
        


    }
}