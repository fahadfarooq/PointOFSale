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

namespace WindowsFormsApplication4
{
    public partial class Reminders : Form
    {
        SqlConnection conn;
        public Reminders()
        {
            InitializeComponent();
        }

        private void Reminders_Load(object sender, EventArgs e)
        {
            DataTable ds = new DataTable("allPrograms");
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
            try
            {
                string query = "Select Name,Qty from Product where id=any (select productID from Reminder)";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();

                da.Fill(ds);

            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show(ex.ToString());
            }
            int pointY = 10;

            foreach (DataRow row in ds.Rows)
            {
           



                TextBox Reminder = new TextBox();

                //a.Text = ds.Tables["Name"].ToString();
                Reminder.Location = new Point(0, pointY);




                Reminder.BorderStyle = System.Windows.Forms.BorderStyle.None;


                Reminder.MinimumSize = new Size(600, 18);

                // a.MaximumSize= new Size(30, 18);
                Reminder.Enabled = false;

                Reminder.Text = "Your Item \"" + row["Name"] + "\" Have Reached to Critial Level, Only " + row["Qty"] + " pieces are left";

                panel1.Controls.Add(Reminder);

                panel1.Show();
                pointY += 20;

            }
            
        }
    }
}
