namespace WindowsFormsApplication4
{
    partial class Checkout
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
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBill = new System.Windows.Forms.TextBox();
            this.CashGiven = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeRetunred = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Salesman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NetTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Bill";
            // 
            // TotalBill
            // 
            this.TotalBill.Enabled = false;
            this.TotalBill.Location = new System.Drawing.Point(141, 37);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(100, 20);
            this.TotalBill.TabIndex = 1;
            // 
            // CashGiven
            // 
            this.CashGiven.Enabled = false;
            this.CashGiven.Location = new System.Drawing.Point(509, 64);
            this.CashGiven.Name = "CashGiven";
            this.CashGiven.Size = new System.Drawing.Size(100, 20);
            this.CashGiven.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cash Given";
            // 
            // ChangeRetunred
            // 
            this.ChangeRetunred.Enabled = false;
            this.ChangeRetunred.Location = new System.Drawing.Point(509, 90);
            this.ChangeRetunred.Name = "ChangeRetunred";
            this.ChangeRetunred.Size = new System.Drawing.Size(100, 20);
            this.ChangeRetunred.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change Returned ";
            // 
            // Salesman
            // 
            this.Salesman.Enabled = false;
            this.Salesman.Location = new System.Drawing.Point(509, 34);
            this.Salesman.Name = "Salesman";
            this.Salesman.Size = new System.Drawing.Size(100, 20);
            this.Salesman.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SalesMan";
            // 
            // Discount
            // 
            this.Discount.Enabled = false;
            this.Discount.Location = new System.Drawing.Point(141, 64);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(100, 20);
            this.Discount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Discount";
            // 
            // NetTotal
            // 
            this.NetTotal.Enabled = false;
            this.NetTotal.Location = new System.Drawing.Point(141, 90);
            this.NetTotal.Name = "NetTotal";
            this.NetTotal.Size = new System.Drawing.Size(100, 20);
            this.NetTotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Net Total";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(91, 165);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(173, 62);
            this.Confirm.TabIndex = 12;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(388, 165);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(173, 62);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 239);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.NetTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Salesman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeRetunred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CashGiven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBill);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalBill;
        private System.Windows.Forms.TextBox CashGiven;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ChangeRetunred;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Salesman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NetTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
    }
}