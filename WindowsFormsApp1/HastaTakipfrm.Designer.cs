namespace WindowsFormsApp1
{
    partial class HastaTakipfrm
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
            this.tctxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HastaİlacList = new System.Windows.Forms.DataGridView();
            this.HastailacList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaİlacList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.tctxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(129, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 107);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vatandaş Bilgileri";
            // 
            // tctxt
            // 
            this.tctxt.Location = new System.Drawing.Point(153, 45);
            this.tctxt.Name = "tctxt";
            this.tctxt.Size = new System.Drawing.Size(157, 24);
            this.tctxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC :";
            // 
            // HastaİlacList
            // 
            this.HastaİlacList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaİlacList.Location = new System.Drawing.Point(64, 201);
            this.HastaİlacList.Name = "HastaİlacList";
            this.HastaİlacList.RowHeadersWidth = 51;
            this.HastaİlacList.RowTemplate.Height = 24;
            this.HastaİlacList.Size = new System.Drawing.Size(545, 273);
            this.HastaİlacList.TabIndex = 24;
            // 
            // HastailacList
            // 
            this.HastailacList.Location = new System.Drawing.Point(233, 134);
            this.HastailacList.Name = "HastailacList";
            this.HastailacList.Size = new System.Drawing.Size(171, 46);
            this.HastailacList.TabIndex = 26;
            this.HastailacList.Text = "Aldığı İlaçları Listele";
            this.HastailacList.UseVisualStyleBackColor = true;
            this.HastailacList.Click += new System.EventHandler(this.HastailacListe);
            // 
            // HastaTakipfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 505);
            this.Controls.Add(this.HastailacList);
            this.Controls.Add(this.HastaİlacList);
            this.Controls.Add(this.groupBox1);
            this.Name = "HastaTakipfrm";
            this.Text = "HastaTakipfrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaİlacList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tctxt;
        private System.Windows.Forms.DataGridView HastaİlacList;
        private System.Windows.Forms.Button HastailacList;
    }
}