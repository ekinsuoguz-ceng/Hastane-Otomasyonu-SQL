namespace WindowsFormsApp1
{
    partial class Recete
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
            this.hastatctxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receteOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ilacbarkodtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.receteıdtxt = new System.Windows.Forms.TextBox();
            this.HastaİlacList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.HastaİlacList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hastatctxt
            // 
            this.hastatctxt.Location = new System.Drawing.Point(171, 38);
            this.hastatctxt.Name = "hastatctxt";
            this.hastatctxt.Size = new System.Drawing.Size(100, 22);
            this.hastatctxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta TC:";
            // 
            // receteOlustur
            // 
            this.receteOlustur.Location = new System.Drawing.Point(335, 56);
            this.receteOlustur.Name = "receteOlustur";
            this.receteOlustur.Size = new System.Drawing.Size(179, 72);
            this.receteOlustur.TabIndex = 19;
            this.receteOlustur.Text = "Reçete Oluştur";
            this.receteOlustur.UseVisualStyleBackColor = true;
            this.receteOlustur.Click += new System.EventHandler(this.ReceteOlustur);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "İlaç Barkod No:";
            // 
            // ilacbarkodtxt
            // 
            this.ilacbarkodtxt.Location = new System.Drawing.Point(171, 129);
            this.ilacbarkodtxt.Name = "ilacbarkodtxt";
            this.ilacbarkodtxt.Size = new System.Drawing.Size(100, 22);
            this.ilacbarkodtxt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Recete ID:";
            // 
            // receteıdtxt
            // 
            this.receteıdtxt.Location = new System.Drawing.Point(171, 81);
            this.receteıdtxt.Name = "receteıdtxt";
            this.receteıdtxt.Size = new System.Drawing.Size(100, 22);
            this.receteıdtxt.TabIndex = 21;
            // 
            // HastaİlacList
            // 
            this.HastaİlacList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaİlacList.Location = new System.Drawing.Point(82, 226);
            this.HastaİlacList.Name = "HastaİlacList";
            this.HastaİlacList.RowHeadersWidth = 51;
            this.HastaİlacList.RowTemplate.Height = 24;
            this.HastaİlacList.Size = new System.Drawing.Size(620, 224);
            this.HastaİlacList.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.receteıdtxt);
            this.groupBox1.Controls.Add(this.hastatctxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ilacbarkodtxt);
            this.groupBox1.Controls.Add(this.receteOlustur);
            this.groupBox1.Location = new System.Drawing.Point(109, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 182);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete Oluştur";
            // 
            // Recete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HastaİlacList);
            this.Name = "Recete";
            this.Text = "Recete";
            this.Load += new System.EventHandler(this.Recete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HastaİlacList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox hastatctxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button receteOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ilacbarkodtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox receteıdtxt;
        private System.Windows.Forms.DataGridView HastaİlacList;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}