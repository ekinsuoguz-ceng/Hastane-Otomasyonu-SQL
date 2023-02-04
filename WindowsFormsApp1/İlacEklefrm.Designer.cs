namespace WindowsFormsApp1
{
    partial class İlacEklefrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barkodtxt = new System.Windows.Forms.TextBox();
            this.ilactiptxt = new System.Windows.Forms.TextBox();
            this.ilacadtxt = new System.Windows.Forms.TextBox();
            this.ilaceklelist = new System.Windows.Forms.DataGridView();
            this.İlaceklebtn = new System.Windows.Forms.Button();
            this.ilaclistele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ilaceklelist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlaç Tipi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlaç Adı:";
            // 
            // barkodtxt
            // 
            this.barkodtxt.Location = new System.Drawing.Point(128, 25);
            this.barkodtxt.Name = "barkodtxt";
            this.barkodtxt.Size = new System.Drawing.Size(100, 22);
            this.barkodtxt.TabIndex = 3;
            // 
            // ilactiptxt
            // 
            this.ilactiptxt.Location = new System.Drawing.Point(128, 131);
            this.ilactiptxt.Name = "ilactiptxt";
            this.ilactiptxt.Size = new System.Drawing.Size(100, 22);
            this.ilactiptxt.TabIndex = 4;
            // 
            // ilacadtxt
            // 
            this.ilacadtxt.Location = new System.Drawing.Point(128, 79);
            this.ilacadtxt.Name = "ilacadtxt";
            this.ilacadtxt.Size = new System.Drawing.Size(100, 22);
            this.ilacadtxt.TabIndex = 5;
            // 
            // ilaceklelist
            // 
            this.ilaceklelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilaceklelist.Location = new System.Drawing.Point(63, 240);
            this.ilaceklelist.Name = "ilaceklelist";
            this.ilaceklelist.RowHeadersWidth = 51;
            this.ilaceklelist.RowTemplate.Height = 24;
            this.ilaceklelist.Size = new System.Drawing.Size(544, 198);
            this.ilaceklelist.TabIndex = 6;
            // 
            // İlaceklebtn
            // 
            this.İlaceklebtn.Location = new System.Drawing.Point(315, 41);
            this.İlaceklebtn.Name = "İlaceklebtn";
            this.İlaceklebtn.Size = new System.Drawing.Size(157, 46);
            this.İlaceklebtn.TabIndex = 7;
            this.İlaceklebtn.Text = "İlaç Ekle";
            this.İlaceklebtn.UseVisualStyleBackColor = true;
            this.İlaceklebtn.Click += new System.EventHandler(this.İlaceklebtn_Click);
            // 
            // ilaclistele
            // 
            this.ilaclistele.Location = new System.Drawing.Point(315, 104);
            this.ilaclistele.Name = "ilaclistele";
            this.ilaclistele.Size = new System.Drawing.Size(157, 46);
            this.ilaclistele.TabIndex = 8;
            this.ilaclistele.Text = "İlaç Listele";
            this.ilaclistele.UseVisualStyleBackColor = true;
            this.ilaclistele.Click += new System.EventHandler(this.ilaclistelebtn);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ilaclistele);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.İlaceklebtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ilacadtxt);
            this.groupBox1.Controls.Add(this.barkodtxt);
            this.groupBox1.Controls.Add(this.ilactiptxt);
            this.groupBox1.Location = new System.Drawing.Point(88, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Ekle";
            // 
            // İlacEklefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ilaceklelist);
            this.Name = "İlacEklefrm";
            this.Text = "İlacEklefrm";
            ((System.ComponentModel.ISupportInitialize)(this.ilaceklelist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barkodtxt;
        private System.Windows.Forms.TextBox ilactiptxt;
        private System.Windows.Forms.TextBox ilacadtxt;
        private System.Windows.Forms.DataGridView ilaceklelist;
        private System.Windows.Forms.Button İlaceklebtn;
        private System.Windows.Forms.Button ilaclistele;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}