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
    public partial class Checkout : Form
    {
        SqlConnection conn;
        int saleid;
       DataTable ds = new DataTable("allPrograms");
        int cash, total,change, dis,netTotal,empid;
        List<int> Proid = new List<int>();
        List<int> ProQty = new List<int>();


        private void Confirm_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\KBDB.mdf;Integrated Security=True");
          
           try
            {


                SqlDataAdapter da;
             

             
              
                DateTime Mydate = DateTime.Now;

                string query = "insert into Sale (salesman,total,saledate)values("+ empid + "," + netTotal + ",'" + Mydate + "')";

               
               

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                int i = cmd.ExecuteNonQuery();
                ds.Clear();
                query = "select max(Id) from Sale";
               da = new SqlDataAdapter(query, conn);
                da.Fill(ds);
                MessageBox.Show("Inserted sale");
                foreach (DataRow row in ds.Rows)
                {

                    saleid =(int) row[0];
                   

                }
            }

            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("\n"+ex.ToString());
            }


            SqlDataAdapter da1;
            for (int i = 0; i < Proid.Count(); i++)
            {

                ds.Clear();
                string GetProQtyTotal = "Select Qty,MinQty from Product where id="+ Proid[i] +"";
                da1 = new SqlDataAdapter(GetProQtyTotal, conn);
                da1.Fill(ds);
                
                int ProductTotalQTy=0;
                foreach (DataRow row in ds.Rows)
                {

                    string s = row["Qty"].ToString();
                    string MinQt = row["MinQty"].ToString();
                    if (s != "")
                    {
                        ProductTotalQTy =int.Parse(s);
                        MessageBox.Show(""+ ProductTotalQTy);
                        ProductTotalQTy--;

                                           string updateQuery = "update Product set qty="+ ProductTotalQTy+"where id="+ Proid[i]+"";
                       
                                        SqlCommand cmd1 = new SqlCommand(updateQuery, conn);
                                      cmd1.ExecuteNonQuery();

                    }
                    if (ProductTotalQTy <= int.Parse(MinQt))
                    {
                        DateTime NoWdate = DateTime.Now;
                       
                        string updateQuery = "insert into Reminder (ProductID,RDateTime) values ("+Proid[i] +",'"+NoWdate+"')";

                        SqlCommand cmd1 = new SqlCommand(updateQuery, conn);
         
                        cmd1.ExecuteNonQuery();
                    }


                }


                string query = "insert into Myorder (sale,product,qty)values(" + saleid + "," + Proid[i] + "," + ProQty[i] + ")";
                
                SqlCommand cmd = new SqlCommand(query, conn);

                
               
                int j = cmd.ExecuteNonQuery();
               
            }


            this.Visible = false;
            Form1 home = new Form1();
            home.Show();

        }

        string emp;
        public Checkout(int cash,int change,int total,int dis,int netTotal,string emp,int empid,List<int>Proid,List<int>ProQty)
        {
            InitializeComponent();
            this.Proid = Proid;
            this.ProQty = ProQty;
            this.cash = cash;
            this.total = total;
            this.netTotal = netTotal;
            this.emp = emp;
            this.dis = dis;
            this.change = change;
            this.empid = empid;
            
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            Salesman.Text = emp;
            CashGiven.Text = ""+cash;
            TotalBill.Text = "" + total;
            Discount.Text = "" + dis;
            NetTotal.Text = "" + netTotal;
            ChangeRetunred.Text = "" + change;


        }
    }
}
