namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.poliklinikDefterineGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikDefteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliklinikDefterineGitToolStripMenuItem,
            this.hastaİşlemleriToolStripMenuItem,
            this.ilaçİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // poliklinikDefterineGitToolStripMenuItem
            // 
            this.poliklinikDefterineGitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliklinikDefteriToolStripMenuItem});
            this.poliklinikDefterineGitToolStripMenuItem.Name = "poliklinikDefterineGitToolStripMenuItem";
            this.poliklinikDefterineGitToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.poliklinikDefterineGitToolStripMenuItem.Text = "Genel";
            // 
            // poliklinikDefteriToolStripMenuItem
            // 
            this.poliklinikDefteriToolStripMenuItem.Name = "poliklinikDefteriToolStripMenuItem";
            this.poliklinikDefteriToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.poliklinikDefteriToolStripMenuItem.Text = "Poliklinik Defteri";
            this.poliklinikDefteriToolStripMenuItem.Click += new System.EventHandler(this.poliklinikDefteriToolStripMenuItem_Click);
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEkleToolStripMenuItem,
            this.hastaListeleToolStripMenuItem,
            this.muayeneEkleToolStripMenuItem,
            this.hastaTakipToolStripMenuItem});
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            // 
            // hastaEkleToolStripMenuItem
            // 
            this.hastaEkleToolStripMenuItem.Name = "hastaEkleToolStripMenuItem";
            this.hastaEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hastaEkleToolStripMenuItem.Text = "Hasta Ekle";
            this.hastaEkleToolStripMenuItem.Click += new System.EventHandler(this.hastaEkleToolStripMenuItem_Click);
            // 
            // hastaListeleToolStripMenuItem
            // 
            this.hastaListeleToolStripMenuItem.Name = "hastaListeleToolStripMenuItem";
            this.hastaListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hastaListeleToolStripMenuItem.Text = "Hasta Listele";
            this.hastaListeleToolStripMenuItem.Click += new System.EventHandler(this.hastaListeleToolStripMenuItem_Click);
            // 
            // hastaTakipToolStripMenuItem
            // 
            this.hastaTakipToolStripMenuItem.Name = "hastaTakipToolStripMenuItem";
            this.hastaTakipToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hastaTakipToolStripMenuItem.Text = "Hasta Takip";
            this.hastaTakipToolStripMenuItem.Click += new System.EventHandler(this.hastaTakipToolStripMenuItem_Click);
            // 
            // muayeneEkleToolStripMenuItem
            // 
            this.muayeneEkleToolStripMenuItem.Name = "muayeneEkleToolStripMenuItem";
            this.muayeneEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.muayeneEkleToolStripMenuItem.Text = "Muayene Ekle";
            this.muayeneEkleToolStripMenuItem.Click += new System.EventHandler(this.muayeneEkleToolStripMenuItem_Click);
            // 
            // ilaçİşlemleriToolStripMenuItem
            // 
            this.ilaçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçEkleToolStripMenuItem,
            this.ilaçListeleToolStripMenuItem,
            this.ilaçTakipToolStripMenuItem,
            this.reçeteEkleToolStripMenuItem});
            this.ilaçİşlemleriToolStripMenuItem.Name = "ilaçİşlemleriToolStripMenuItem";
            this.ilaçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.ilaçİşlemleriToolStripMenuItem.Text = "İlaç-Reçete";
            // 
            // ilaçEkleToolStripMenuItem
            // 
            this.ilaçEkleToolStripMenuItem.Name = "ilaçEkleToolStripMenuItem";
            this.ilaçEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilaçEkleToolStripMenuItem.Text = "İlaç Ekle";
            this.ilaçEkleToolStripMenuItem.Click += new System.EventHandler(this.ilaçEkleToolStripMenuItem_Click);
            // 
            // reçeteEkleToolStripMenuItem
            // 
            this.reçeteEkleToolStripMenuItem.Name = "reçeteEkleToolStripMenuItem";
            this.reçeteEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reçeteEkleToolStripMenuItem.Text = "Reçete Yaz";
            this.reçeteEkleToolStripMenuItem.Click += new System.EventHandler(this.reçeteEkleToolStripMenuItem_Click);
            // 
            // ilaçTakipToolStripMenuItem
            // 
            this.ilaçTakipToolStripMenuItem.Name = "ilaçTakipToolStripMenuItem";
            this.ilaçTakipToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilaçTakipToolStripMenuItem.Text = "İlaç Takip";
            this.ilaçTakipToolStripMenuItem.Click += new System.EventHandler(this.ilaçTakipToolStripMenuItem_Click);
            // 
            // ilaçListeleToolStripMenuItem
            // 
            this.ilaçListeleToolStripMenuItem.Name = "ilaçListeleToolStripMenuItem";
            this.ilaçListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilaçListeleToolStripMenuItem.Text = "İlaç Listele";
            this.ilaçListeleToolStripMenuItem.Click += new System.EventHandler(this.ilaçListeleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 415);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem poliklinikDefterineGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikDefteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçListeleToolStripMenuItem;
    }
}

