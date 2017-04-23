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
    public partial class AddNewEmp : Form
    {
        SqlConnection conn;
        public AddNewEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
            try
            {
                string name = textBox1.Text;
                string cnic= textBox2.Text;
                int salary = int.Parse(textBox3.Text);
                string query = "insert into EMP (Name,Cnic,Salary)values('" + name + "','"+cnic+"',"+salary + ")";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show("New Employee "+ textBox1.Text+ " is added ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
