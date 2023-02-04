namespace WindowsFormsApp1
{
    partial class Muayenefrm
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
            this.hastaSikayet = new System.Windows.Forms.TextBox();
            this.Mtarihtxt = new System.Windows.Forms.TextBox();
            this.hastatctxt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tedavitx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MuayeneEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hastaSikayet
            // 
            this.hastaSikayet.Location = new System.Drawing.Point(239, 93);
            this.hastaSikayet.Name = "hastaSikayet";
            this.hastaSikayet.Size = new System.Drawing.Size(100, 22);
            this.hastaSikayet.TabIndex = 27;
            // 
            // Mtarihtxt
            // 
            this.Mtarihtxt.Location = new System.Drawing.Point(239, 194);
            this.Mtarihtxt.Name = "Mtarihtxt";
            this.Mtarihtxt.Size = new System.Drawing.Size(100, 22);
            this.Mtarihtxt.TabIndex = 26;
            this.Mtarihtxt.TextChanged += new System.EventHandler(this.Mtarihtxt_TextChanged);
            // 
            // hastatctxt2
            // 
            this.hastatctxt2.Location = new System.Drawing.Point(239, 40);
            this.hastatctxt2.Name = "hastatctxt2";
            this.hastatctxt2.Size = new System.Drawing.Size(100, 22);
            this.hastatctxt2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Muayene Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hasta Şikayeti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hasta TC:";
            // 
            // tedavitx
            // 
            this.tedavitx.Location = new System.Drawing.Point(239, 143);
            this.tedavitx.Name = "tedavitx";
            this.tedavitx.Size = new System.Drawing.Size(100, 22);
            this.tedavitx.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(109, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Önerilen Tedavi:";
            // 
            // MuayeneEkle
            // 
            this.MuayeneEkle.Location = new System.Drawing.Point(163, 257);
            this.MuayeneEkle.Name = "MuayeneEkle";
            this.MuayeneEkle.Size = new System.Drawing.Size(147, 66);
            this.MuayeneEkle.TabIndex = 32;
            this.MuayeneEkle.Text = "Muayene Ekle";
            this.MuayeneEkle.UseVisualStyleBackColor = true;
            this.MuayeneEkle.Click += new System.EventHandler(this.MuayeneEklebtn);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MuayeneEkle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tedavitx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hastatctxt2);
            this.groupBox1.Controls.Add(this.hastaSikayet);
            this.groupBox1.Controls.Add(this.Mtarihtxt);
            this.groupBox1.Location = new System.Drawing.Point(137, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 360);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muayene Ekle";
            // 
            // Muayenefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 388);
            this.Controls.Add(this.groupBox1);
            this.Name = "Muayenefrm";
            this.Text = "Muayenefrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox hastaSikayet;
        private System.Windows.Forms.TextBox Mtarihtxt;
        private System.Windows.Forms.TextBox hastatctxt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tedavitx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MuayeneEkle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}