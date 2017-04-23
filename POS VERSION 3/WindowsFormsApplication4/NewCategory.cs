using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication4
{
    public partial class NewCategory : Form
    {
        public NewCategory()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {

           // string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
            try
            {
                string name = textBox2.Text;
                

                string query = "insert into Category (Name)values('"+ name +"'"+")";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
              int i=  cmd.ExecuteNonQuery();
                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show( textBox2.Text+ " is added to category ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewCategory_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All unsave Changes will be lost \n are you sure you want to go back? ", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                this.Visible = false;
                home.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
    }


