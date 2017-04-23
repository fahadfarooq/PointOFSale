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
using System.Runtime.InteropServices;
namespace WindowsFormsApplication4{
    public partial class Inventory : Form
    {
        SqlConnection conn;
          

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect, // x-coordinate of upper-left corner
      int nTopRect, // y-coordinate of upper-left corner
      int nRightRect, // x-coordinate of lower-right corner
      int nBottomRect, // y-coordinate of lower-right corner
      int nWidthEllipse, // height of ellipse
      int nHeightEllipse // width of ellipse
  );
        

public Inventory()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            int j = 0;
            

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // DataSet ds = new DataSet();
            DataTable ds = new DataTable("allPrograms");
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
            try
            {
                string query = "select * from Product";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                
                da.Fill(ds);
              
                foreach (DataRow row in ds.Rows)
                {
                    string name = row["Name"].ToString();
                    string proId = row["id"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show(ex.ToString());
            }
            try
            {
                
                int pointXName = 0;
                int pointXQty = 180;
                int pointXPrice = 300;
                int pointXWPrice = 420;
                int pointY = 0;
                panel3.Controls.Clear();
                foreach (DataRow row in ds.Rows)
                {

                    TextBox name = new TextBox();
                    TextBox qty = new TextBox();
                    TextBox Price = new TextBox();
                    TextBox WPrice = new TextBox();
                    //a.Text = ds.Tables["Name"].ToString();
                    name.Location = new Point(pointXName, pointY);
                   Price.Location = new Point(pointXPrice, pointY);
                    WPrice.Location = new Point(pointXWPrice, pointY);
                    qty.Location = new Point(pointXQty, pointY);
                    Price.Enabled = false;
                    WPrice.Enabled = false;
                    name.Enabled = false;
                    qty.Enabled = false;
                    
                   
                    Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    WPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    name.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    qty.BorderStyle = System.Windows.Forms.BorderStyle.None;

                    name.MinimumSize = new Size(170, 18);
                    qty.MinimumSize = new Size(70, 18);
                    Price.MinimumSize = new Size(80, 18);
                    WPrice.MinimumSize = new Size(80, 18);
                    // a.MaximumSize= new Size(30, 18);

                    
                    qty.Text = row["Qty"].ToString(); ;
                    name.Text = row["Name"].ToString();
                    Price.Text = row["RetailPrice"].ToString();
                    WPrice.Text = row["WholeSalePrice"].ToString();
                    panel3.Controls.Add(name);
                    panel3.Controls.Add(qty);
                    panel3.Controls.Add(Price);
                    panel3.Controls.Add(WPrice);
                    panel3.Show();
                    pointY += 20;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<TextBox> textBoxList = new List<TextBox>();

            for (int index = 0; index < 4; index++)
            {
                var textBox = new TextBox();
                textBoxList.Add(textBox);
                MessageBox.Show("s " +index);
                // do the rest of work.
            }
            foreach (var textBoxex in textBoxList)
            {
                int count = 4;
                for (int i = 0; i < 3; i++)
                { 
                TextBox textbox = new TextBox();
                count = this.Controls.OfType<TextBox>().ToList().Count;
                textbox.Location = new System.Drawing.Point(60, 25 * count);
                textbox.Size = new System.Drawing.Size(80, 20);
                textbox.Name = "textbox_" + (count + 1);
                //textbox.TextChanged += new System.EventHandler(this.TextBox_Changed);
                this.Controls.Add(textbox);
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewCategory newcat = new NewCategory();
            // newcat.Show();
            newcat.ShowDialog();
            //  this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            AddNewEmp addEmp = new AddNewEmp();
            //this.Visible = false;
            addEmp.ShowDialog();
        }
    }
}
