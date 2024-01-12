
namespace StudentHousingApp.Forms
{
    partial class FormAnnouncements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnnouncements));
            this.panelABarTwo = new System.Windows.Forms.Panel();
            this.lblAWelcomeMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnDeleteNotification = new System.Windows.Forms.Button();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.txbxAnnouncement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelABarTwo
            // 
            this.panelABarTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelABarTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.panelABarTwo.Location = new System.Drawing.Point(-21, 122);
            this.panelABarTwo.Name = "panelABarTwo";
            this.panelABarTwo.Size = new System.Drawing.Size(1281, 38);
            this.panelABarTwo.TabIndex = 20;
            // 
            // lblAWelcomeMessage
            // 
            this.lblAWelcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAWelcomeMessage.AutoSize = true;
            this.lblAWelcomeMessage.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAWelcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.lblAWelcomeMessage.Location = new System.Drawing.Point(943, 49);
            this.lblAWelcomeMessage.Name = "lblAWelcomeMessage";
            this.lblAWelcomeMessage.Size = new System.Drawing.Size(198, 28);
            this.lblAWelcomeMessage.TabIndex = 19;
            this.lblAWelcomeMessage.Text = "Announcements";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(137, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 33);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Student Housing";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(70, 15);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(107, 93);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 18;
            this.pbxLogo.TabStop = false;
            // 
            // btnDeleteNotification
            // 
            this.btnDeleteNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnDeleteNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotification.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeleteNotification.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNotification.Location = new System.Drawing.Point(100, 639);
            this.btnDeleteNotification.Name = "btnDeleteNotification";
            this.btnDeleteNotification.Size = new System.Drawing.Size(698, 37);
            this.btnDeleteNotification.TabIndex = 20;
            this.btnDeleteNotification.Text = "Delete";
            this.btnDeleteNotification.UseVisualStyleBackColor = false;
            this.btnDeleteNotification.Click += new System.EventHandler(this.btnDeleteNotification_Click);
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 16;
            this.lbAnnouncements.Location = new System.Drawing.Point(100, 210);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(698, 404);
            this.lbAnnouncements.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(831, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar.Location = new System.Drawing.Point(831, 210);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 22;
            // 
            // txbxAnnouncement
            // 
            this.txbxAnnouncement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbxAnnouncement.Location = new System.Drawing.Point(831, 429);
            this.txbxAnnouncement.Multiline = true;
            this.txbxAnnouncement.Name = "txbxAnnouncement";
            this.txbxAnnouncement.Size = new System.Drawing.Size(300, 185);
            this.txbxAnnouncement.TabIndex = 23;
            // 
            // FormAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 792);
            this.Controls.Add(this.txbxAnnouncement);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteNotification);
            this.Controls.Add(this.panelABarTwo);
            this.Controls.Add(this.lbAnnouncements);
            this.Controls.Add(this.lblAWelcomeMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxLogo);
            this.Name = "FormAnnouncements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Announcements";
            this.Load += new System.EventHandler(this.FormAnnouncements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelABarTwo;
        private System.Windows.Forms.Label lblAWelcomeMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnDeleteNotification;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox txbxAnnouncement;
    }
}