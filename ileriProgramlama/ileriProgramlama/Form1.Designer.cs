namespace ileriProgramlama
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gozatButton = new System.Windows.Forms.Button();
            this.secilenDizinTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dizinIcerigiListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gozatButton);
            this.groupBox1.Controls.Add(this.secilenDizinTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dizin Seçimi";
            // 
            // gozatButton
            // 
            this.gozatButton.Location = new System.Drawing.Point(499, 15);
            this.gozatButton.Name = "gozatButton";
            this.gozatButton.Size = new System.Drawing.Size(75, 23);
            this.gozatButton.TabIndex = 1;
            this.gozatButton.Text = "Gözat";
            this.gozatButton.UseVisualStyleBackColor = true;
            this.gozatButton.Click += new System.EventHandler(this.gozatButton_Click);
            // 
            // secilenDizinTextBox
            // 
            this.secilenDizinTextBox.Enabled = false;
            this.secilenDizinTextBox.Location = new System.Drawing.Point(15, 19);
            this.secilenDizinTextBox.Name = "secilenDizinTextBox";
            this.secilenDizinTextBox.Size = new System.Drawing.Size(465, 20);
            this.secilenDizinTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dizinIcerigiListView);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 307);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dizindeki Dosya ve Klasörler";
            // 
            // dizinIcerigiListView
            // 
            this.dizinIcerigiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.dizinIcerigiListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dizinIcerigiListView.Location = new System.Drawing.Point(3, 16);
            this.dizinIcerigiListView.Name = "dizinIcerigiListView";
            this.dizinIcerigiListView.Size = new System.Drawing.Size(583, 288);
            this.dizinIcerigiListView.TabIndex = 0;
            this.dizinIcerigiListView.UseCompatibleStateImageBehavior = false;
            this.dizinIcerigiListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 252;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tür";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boyut(byte)";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oluşturma Tarihi";
            this.columnHeader3.Width = 123;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button gozatButton;
        private System.Windows.Forms.TextBox secilenDizinTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView dizinIcerigiListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

