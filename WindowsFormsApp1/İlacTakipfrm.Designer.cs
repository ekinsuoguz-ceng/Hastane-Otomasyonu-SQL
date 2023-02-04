namespace WindowsFormsApp1
{
    partial class İlacTakipfrm
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
            this.HastaList = new System.Windows.Forms.Button();
            this.HastaİlacList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barkodtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HastaİlacList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HastaList
            // 
            this.HastaList.Location = new System.Drawing.Point(232, 182);
            this.HastaList.Name = "HastaList";
            this.HastaList.Size = new System.Drawing.Size(171, 46);
            this.HastaList.TabIndex = 29;
            this.HastaList.Text = "Hastaları Listele";
            this.HastaList.UseVisualStyleBackColor = true;
            this.HastaList.Click += new System.EventHandler(this.HastaListbtn);
            // 
            // HastaİlacList
            // 
            this.HastaİlacList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaİlacList.Location = new System.Drawing.Point(63, 234);
            this.HastaİlacList.Name = "HastaİlacList";
            this.HastaİlacList.RowHeadersWidth = 51;
            this.HastaİlacList.RowTemplate.Height = 24;
            this.HastaİlacList.Size = new System.Drawing.Size(545, 273);
            this.HastaİlacList.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.barkodtxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(148, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 143);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Bilgileri";
            // 
            // barkodtxt
            // 
            this.barkodtxt.Location = new System.Drawing.Point(151, 62);
            this.barkodtxt.Name = "barkodtxt";
            this.barkodtxt.Size = new System.Drawing.Size(157, 24);
            this.barkodtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlaç Barkod No:";
            // 
            // İlacTakipfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.HastaList);
            this.Controls.Add(this.HastaİlacList);
            this.Controls.Add(this.groupBox1);
            this.Name = "İlacTakipfrm";
            this.Text = "İlacTakipfrm";
            ((System.ComponentModel.ISupportInitialize)(this.HastaİlacList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HastaList;
        private System.Windows.Forms.DataGridView HastaİlacList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox barkodtxt;
        private System.Windows.Forms.Label label1;
    }
}