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
    public partial class MakeSale : Form
    {
        int GrandTotal =0;
         SqlConnection conn;
        TextBox TotalRefrence;
        int pointXName = 50;
        int pointXQty = 180;
        int pointXPrice = 300;
        int pointXSubtotal = 420;
        int pointY = 0;
        String[] ItemName;
        int[] ItemPrice,ItemQty,SubTotal;
        List<int> intArrPrice = new List<int>();
        List<int> ArrQty = new List<int>();
        List<int> ArrTotal = new List<int>();
        List<int> ArrProId = new List<int>();
        List<string> ArrName = new List<string>();
      
        
        int itemIndex = 0;
        TextBox qty;
        int oldSubtotal;
        DataTable ds = new DataTable("allPrograms");
        public MakeSale()
        {
          
           
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
            conn.Open();
            InitializeComponent();
           
            textBox1.MaximumSize = new Size(400, 40);

            treeView1.Hide();

            //a.Text = ds.Tables["Name"].ToString();
           
        }

      
        private void InvokeSearch(object sender, EventArgs e)
        {
            
            // listView1.Clear();
            ds.Clear();
       
            treeView1.Nodes.Clear();
            
            String search = textBox1.Text;
                try
            {
                 string query = "select * from Product where Name like '%"+search+"%'";
               // string query = "select * from Product";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                

                da.Fill(ds);
              
              
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show(ex.ToString());
            }

            int i = 0;
           // listView1.Clear();
            foreach (DataRow row in ds.Rows)
            {

                if (row["Name"] != null)
                {
                    ItemName = new string[20];
                    ItemPrice = new int[20];
                    ItemName[i] = row["Name"].ToString();
             
             
                ItemPrice[i] =int.Parse( row["RetailPrice"].ToString());
                    //   listView1.Items.Add(ItemName[i]);

                    ; ;   TreeNode node = new TreeNode(ItemName[i]);
                   

                    node.Tag = (int)row["id"];
                    
                    treeView1.Nodes.Add(row["id"].ToString(), ItemName[i]);
                }

            }
            treeView1.Show();
        }

        private void MakeSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kBDBDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.kBDBDataSet2.Product);

            DataConnection db = new DataConnection();

            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
            try
            {
                string query = "select id, Name from EMP";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Name");
                Salesman.DisplayMember = "Name";
                Salesman.ValueMember = "Id";
                Salesman.DataSource = ds.Tables["Name"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }

        }

        private void HideList(object sender, EventArgs e)
        {
          //  treeView1.Hide();
        }

        private void SelectItem(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.Hide();

            TextBox id = new TextBox();
            TextBox name = new TextBox();
            TreeNode node = e.Node;
            ArrProId.Add(int.Parse(node.Name));
            ArrQty.Add(1);
           
            qty = new TextBox();
            TextBox Price = new TextBox();
            TextBox Subtotal = new TextBox();
            id.Location = new Point(0, pointY);
            name.Location = new Point(pointXName, pointY);
            Price.Location = new Point(pointXPrice, pointY);
            Subtotal.Location = new Point(pointXSubtotal, pointY);
            qty.Location = new Point(pointXQty, pointY);
            id.Enabled = false;
            Price.Enabled = false;
            Subtotal.Enabled = false;
            name.Enabled = false;

       //    id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
        //    name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //qty.BorderStyle = System.Windows.Forms.BorderStyle.None;

            id.MinimumSize = new Size(10, 18);
            id.Size = new Size(20, 18);
            name.Size = new Size(90, 18);
            qty.MinimumSize = new Size(70, 18);
            Price.MinimumSize = new Size(80, 18);
            Subtotal.MinimumSize = new Size(80, 18);

            //   var indices = listView1.SelectedIndices;
            int index = 0;


            name.Text = ItemName[index];
            id.Text = "" + (itemIndex+1);
           
 
            qty.Text = "" + 1;
       
            Price.Text = ItemPrice[index].ToString();
            int temp = int.Parse(qty.Text) * ItemPrice[index];
            GrandTotal = GrandTotal + temp;
            GrandTotalBox.Text = GrandTotal.ToString();
            Subtotal.Text = "" + temp;
            panel3.Controls.Add(id);
            panel3.Controls.Add(name);
           panel3.Controls.Add(qty);
           panel3.Controls.Add(Price);
            panel3.Controls.Add(Subtotal);
            itemIndex++;
            // qty.TextChanged += new System.EventHandler(this.QtyUpdate);
            TextBox invoker = qty;
             //qty.GotFocus += new System.EventHandler(this.QtyGetFocus);
            qty.GotFocus += new EventHandler((qty, EventHandler) => QtyGetFocus(sender, e, Subtotal,ItemPrice[index]));
            qty.TextChanged += new EventHandler((qty, EventHandler) => QtyUpdate(sender, e, Subtotal,ItemPrice[index],invoker,int.Parse(id.Text)));
            
            panel3.Show();
            pointY += 20;
            TotalRefrence = Subtotal;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cash, total, dis=0,nettotal,change=0;
            total = int.Parse(GrandTotalBox.Text);
            if (Discount.Text == "")
            {
               
            }
            else
            {
              
                dis = int.Parse(Discount.Text);
            }

            if (CashGiven.Text == "")
            {
                CashGiven.Text = GrandTotalBox.Text;
                cash = int.Parse(CashGiven.Text);
            }
            else { 
            cash = int.Parse(CashGiven.Text);
            }
            if (cash - total < 0)
            {
                MessageBox.Show("Cash Is not enough to procede this sale");
            }
            else
            {
                change = cash - total;
                nettotal = total - (total * (dis / 100));
                string emp = Salesman.Text;
                int empid = (int)Salesman.SelectedValue;
                Checkout Ck = new Checkout(cash,change,total,dis,nettotal, emp,empid,ArrProId,ArrQty);
                Ck.ShowDialog();
                this.Visible = false;
            }
        }

        private void ItemSelected(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void QtyGetFocus(object sender, EventArgs e, TextBox Temp,int price)
        {
           oldSubtotal = int.Parse(Temp.Text);
        }
        private void QtyUpdate(object sender, EventArgs e,TextBox Temp,int price,TextBox invoker,int id)
        {
            int newPrice=0;
         
    
       
            try {
                newPrice = int.Parse(invoker.Text) * price;
                ArrQty[id] = int.Parse(invoker.Text);
            }
            catch (Exception ex)
            {

            }

            // int newprice = int.Parse(qty) * price;

           
            Temp.Text = "" + newPrice;
            int Gtotal;
           
           
            Gtotal = int.Parse(GrandTotalBox.Text);
        
            Gtotal = Gtotal - oldSubtotal;
            Gtotal = Gtotal + newPrice;
            MessageBox.Show("" + oldSubtotal);
             GrandTotalBox.Text = "" + Gtotal;

           
            }


    }
}
