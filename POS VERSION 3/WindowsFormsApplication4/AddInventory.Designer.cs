namespace WindowsFormsApplication4
{
    partial class AddInventory
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RPrice = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication4.DataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new WindowsFormsApplication4.DataSet1TableAdapters.CategoryTableAdapter();
            this.kBDBDataSet = new WindowsFormsApplication4.KBDBDataSet();
            this.kBDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.AvailableQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Reminder = new System.Windows.Forms.TextBox();
            this.Discription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(245, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 55);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication4.Properties.Resources.cross;
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.cross;
            this.pictureBox1.InitialImage = global::WindowsFormsApplication4.Properties.Resources.cross;
            this.pictureBox1.Location = new System.Drawing.Point(529, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "KB-POS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 54);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel3.Location = new System.Drawing.Point(242, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 53);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 549);
            this.panel1.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.inventory;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(92)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(245, 65);
            this.button8.TabIndex = 2;
            this.button8.Text = "Add New Category";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.inventory;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(92)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(245, 65);
            this.button6.TabIndex = 1;
            this.button6.Text = "Inventory";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.saleside3;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(92)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(245, 65);
            this.button5.TabIndex = 0;
            this.button5.Text = "Make  A Sale";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(291, 126);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(227, 20);
            this.ItemName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 9F);
            this.label2.Location = new System.Drawing.Point(288, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name of Item ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 9F);
            this.label3.Location = new System.Drawing.Point(288, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "WholeSale Price";
            // 
            // WPrice
            // 
            this.WPrice.Location = new System.Drawing.Point(291, 191);
            this.WPrice.Name = "WPrice";
            this.WPrice.Size = new System.Drawing.Size(83, 20);
            this.WPrice.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 9F);
            this.label4.Location = new System.Drawing.Point(432, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Retail Price ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RPrice
            // 
            this.RPrice.Location = new System.Drawing.Point(435, 191);
            this.RPrice.Name = "RPrice";
            this.RPrice.Size = new System.Drawing.Size(83, 20);
            this.RPrice.TabIndex = 14;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(291, 241);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 21);
            this.Category.TabIndex = 17;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 9F);
            this.label5.Location = new System.Drawing.Point(288, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Category";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // kBDBDataSet
            // 
            this.kBDBDataSet.DataSetName = "KBDBDataSet";
            this.kBDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kBDBDataSetBindingSource
            // 
            this.kBDBDataSetBindingSource.DataSource = this.kBDBDataSet;
            this.kBDBDataSetBindingSource.Position = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Raleway", 9F);
            this.label6.Location = new System.Drawing.Point(288, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Available Qty";
            // 
            // AvailableQty
            // 
            this.AvailableQty.Location = new System.Drawing.Point(291, 296);
            this.AvailableQty.Name = "AvailableQty";
            this.AvailableQty.Size = new System.Drawing.Size(83, 20);
            this.AvailableQty.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Raleway", 9F);
            this.label7.Location = new System.Drawing.Point(432, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Reminder On ";
            // 
            // Reminder
            // 
            this.Reminder.Location = new System.Drawing.Point(435, 296);
            this.Reminder.Name = "Reminder";
            this.Reminder.Size = new System.Drawing.Size(83, 20);
            this.Reminder.TabIndex = 21;
            this.Reminder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Reminder.Enter += new System.EventHandler(this.Reminer_Reminder);
            // 
            // Discription
            // 
            this.Discription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Discription.Location = new System.Drawing.Point(291, 355);
            this.Discription.Name = "Discription";
            this.Discription.Size = new System.Drawing.Size(267, 96);
            this.Discription.TabIndex = 24;
            this.Discription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Raleway", 9F);
            this.label8.Location = new System.Drawing.Point(292, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Product Discription";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Raleway", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(295, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 65);
            this.button1.TabIndex = 26;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Discription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Reminder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AvailableQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddInventory";
            this.Text = "AddInventory";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RPrice;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label label5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource kBDBDataSetBindingSource;
        private KBDBDataSet kBDBDataSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AvailableQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Reminder;
        private System.Windows.Forms.RichTextBox Discription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}