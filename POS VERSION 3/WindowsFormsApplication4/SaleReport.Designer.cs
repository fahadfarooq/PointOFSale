namespace WindowsFormsApplication4
{
    partial class SaleReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KBDBDataSet1 = new WindowsFormsApplication4.KBDBDataSet1();
            this.SaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleTableAdapter = new WindowsFormsApplication4.KBDBDataSet1TableAdapters.SaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KBDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SaleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication4.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(774, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // KBDBDataSet1
            // 
            this.KBDBDataSet1.DataSetName = "KBDBDataSet1";
            this.KBDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaleBindingSource
            // 
            this.SaleBindingSource.DataMember = "Sale";
            this.SaleBindingSource.DataSource = this.KBDBDataSet1;
            // 
            // SaleTableAdapter
            // 
            this.SaleTableAdapter.ClearBeforeFill = true;
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaleReport";
            this.Text = "SaleReport";
            this.Load += new System.EventHandler(this.SaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KBDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaleBindingSource;
        private KBDBDataSet1 KBDBDataSet1;
        private KBDBDataSet1TableAdapters.SaleTableAdapter SaleTableAdapter;
    }
}