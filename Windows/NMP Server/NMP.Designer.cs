namespace NMP_Server
{
    partial class NMP
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NMP));
            this.www = new System.Windows.Forms.PictureBox();
            this.browser = new System.Windows.Forms.PictureBox();
            this.webServer = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.phpMyAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.www)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phpMyAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // www
            // 
            this.www.Image = ((System.Drawing.Image)(resources.GetObject("www.Image")));
            this.www.Location = new System.Drawing.Point(12, 176);
            this.www.Name = "www";
            this.www.Size = new System.Drawing.Size(64, 64);
            this.www.TabIndex = 0;
            this.www.TabStop = false;
            this.www.Click += new System.EventHandler(this.www_Click);
            // 
            // browser
            // 
            this.browser.Image = ((System.Drawing.Image)(resources.GetObject("browser.Image")));
            this.browser.Location = new System.Drawing.Point(120, 176);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(64, 64);
            this.browser.TabIndex = 1;
            this.browser.TabStop = false;
            this.browser.Click += new System.EventHandler(this.browser_Click);
            // 
            // webServer
            // 
            this.webServer.Image = ((System.Drawing.Image)(resources.GetObject("webServer.Image")));
            this.webServer.Location = new System.Drawing.Point(376, 176);
            this.webServer.Name = "webServer";
            this.webServer.Size = new System.Drawing.Size(64, 64);
            this.webServer.TabIndex = 2;
            this.webServer.TabStop = false;
            this.webServer.Click += new System.EventHandler(this.webServer_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(33, 39);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(375, 86);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // phpMyAdmin
            // 
            this.phpMyAdmin.Image = ((System.Drawing.Image)(resources.GetObject("phpMyAdmin.Image")));
            this.phpMyAdmin.Location = new System.Drawing.Point(245, 176);
            this.phpMyAdmin.Name = "phpMyAdmin";
            this.phpMyAdmin.Size = new System.Drawing.Size(85, 64);
            this.phpMyAdmin.TabIndex = 4;
            this.phpMyAdmin.TabStop = false;
            this.phpMyAdmin.Click += new System.EventHandler(this.phpMyAdmin_Click);
            // 
            // NMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 255);
            this.Controls.Add(this.phpMyAdmin);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.webServer);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.www);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NMP";
            this.Text = "NMP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NMP_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.www)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phpMyAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox www;
        private System.Windows.Forms.PictureBox browser;
        private System.Windows.Forms.PictureBox webServer;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox phpMyAdmin;
    }
}

