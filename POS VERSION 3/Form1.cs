using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

       

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
        public Form1()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.BackColor= System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

      
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#333645");
        }
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor= System.Drawing.ColorTranslator.FromHtml("#ff575c");
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#333645");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inventory Inven = new Inventory();
            Inven.Show();
            this.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewCategory newcat = new NewCategory();
            newcat.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewCategory newcat = new NewCategory();
          newcat.Show();
           // newcat.ShowDialog();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddInventory addinvetory = new AddInventory();
            addinvetory.Show();
            this.Visible = false;
        }
    }
}
