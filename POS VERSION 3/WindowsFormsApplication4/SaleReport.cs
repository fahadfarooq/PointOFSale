using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class SaleReport : Form
    {
        public SaleReport()
        {
            InitializeComponent();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KBDBDataSet1.Sale' table. You can move, or remove it, as needed.
            this.SaleTableAdapter.Fill(this.KBDBDataSet1.Sale);

            this.reportViewer1.RefreshReport();
        }
    }
}
