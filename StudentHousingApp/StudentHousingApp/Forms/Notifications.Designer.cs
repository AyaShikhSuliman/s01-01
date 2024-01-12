
namespace StudentHousingApp
{
    partial class FormNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotifications));
            this.lbNotifications = new System.Windows.Forms.ListBox();
            this.btnDeleteNotification = new System.Windows.Forms.Button();
            this.lblAWelcomeMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panelABarTwo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNotifications
            // 
            resources.ApplyResources(this.lbNotifications, "lbNotifications");
            this.lbNotifications.FormattingEnabled = true;
            this.lbNotifications.Name = "lbNotifications";
            // 
            // btnDeleteNotification
            // 
            resources.ApplyResources(this.btnDeleteNotification, "btnDeleteNotification");
            this.btnDeleteNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnDeleteNotification.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNotification.Name = "btnDeleteNotification";
            this.btnDeleteNotification.UseVisualStyleBackColor = false;
            this.btnDeleteNotification.Click += new System.EventHandler(this.btnDeleteNotification_Click);
            // 
            // lblAWelcomeMessage
            // 
            resources.ApplyResources(this.lblAWelcomeMessage, "lblAWelcomeMessage");
            this.lblAWelcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.lblAWelcomeMessage.Name = "lblAWelcomeMessage";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.lblTitle.Name = "lblTitle";
            // 
            // pbxLogo
            // 
            resources.ApplyResources(this.pbxLogo, "pbxLogo");
            this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.TabStop = false;
            // 
            // panelABarTwo
            // 
            resources.ApplyResources(this.panelABarTwo, "panelABarTwo");
            this.panelABarTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.panelABarTwo.Name = "panelABarTwo";
            // 
            // FormNotifications
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelABarTwo);
            this.Controls.Add(this.lblAWelcomeMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnDeleteNotification);
            this.Controls.Add(this.lbNotifications);
            this.Name = "FormNotifications";
            this.Load += new System.EventHandler(this.FormNotifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbNotifications;
        private System.Windows.Forms.Button btnDeleteNotification;
        private System.Windows.Forms.Label lblAWelcomeMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panelABarTwo;
    }
}