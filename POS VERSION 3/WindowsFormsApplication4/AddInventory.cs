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
    public partial class AddInventory : Form
    {
        SqlConnection conn;
        public AddInventory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
            DataConnection db = new DataConnection();

             conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
            try
            {
                string query = "select id, Name from Category";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Name");
                Category.DisplayMember = "Name";
                Category.ValueMember = "ID";
                Category.DataSource = ds.Tables["Name"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reminer_Reminder(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 4000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("System will generate Reminder when product reach this limit", TB, 20, 10, VisibleTime);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

             String Itemname = ItemName.Text;
                String Detail = Discription.Text;

                int Wprice, Rprice, Qty, MinQty;
                Wprice= Rprice= Qty= MinQty=0;
                int CetselectedValue = (int)Category.SelectedValue;
            bool err = validateFields();
            if(err)
            {
               
                MessageBox.Show("Can not Save \n Some Required Fileds are Left Blank");
            }
            else
            {
                
                
               
               
                try {
                   
                    Wprice = int.Parse(WPrice.Text);
                    Rprice = int.Parse(RPrice.Text);
                    Qty = int.Parse(AvailableQty.Text);
                    MinQty = int.Parse(Reminder.Text);
                    conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
                     string query = "insert into Product (Name,Detail,WholeSalePrice,RetailPrice,Category,Qty,MinQty)values('" + Itemname + "','" + Detail + "'," + Wprice + "," + Rprice + "," + CetselectedValue + "," + Qty + "," + MinQty + ")";

                  
       
                     SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Saved");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString()+"Price Or Quantity is Invalid");

                }


                


            }
            
        }
    public bool validateFields()
    {
            label2.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = label6.ForeColor = label7.ForeColor = label8.ForeColor = Color.Black;
        bool err = false;

        if (ItemName.Text == "")
        {
            err = true;
            label2.ForeColor = Color.Red;

        }
        if (WPrice.Text == "")
        {
            err = true;
            label3.ForeColor = Color.Red;
        }

            if (RPrice.Text == "")
            {
              
                err = true;
                label4.ForeColor = Color.Red;
            }

            if (Category.Text == "")
            {
                err = true;
                label5.ForeColor = Color.Red;
            }
            if (AvailableQty.Text == "")
            {
                err = true;
                label6.ForeColor = Color.Red;
            }
            if (Reminder.Text == "")
            {
                err = true;
                label7.ForeColor = Color.Red;
            }
            if (Discription.Text == "")
            {
                err = true;
                label8.ForeColor = Color.Red;
            }


            return err;
    }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }
    }//end here

  
}
