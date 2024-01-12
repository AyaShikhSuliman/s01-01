
namespace StudentHousingApp.Forms
{
    partial class FormComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComplaints));
            this.panelABarTwo = new System.Windows.Forms.Panel();
            this.lblAWelcomeMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnReply = new System.Windows.Forms.Button();
            this.btnDeleteNotification = new System.Windows.Forms.Button();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbxMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelABarTwo
            // 
            this.panelABarTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelABarTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.panelABarTwo.Location = new System.Drawing.Point(-21, 122);
            this.panelABarTwo.Name = "panelABarTwo";
            this.panelABarTwo.Size = new System.Drawing.Size(1402, 38);
            this.panelABarTwo.TabIndex = 24;
            // 
            // lblAWelcomeMessage
            // 
            this.lblAWelcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAWelcomeMessage.AutoSize = true;
            this.lblAWelcomeMessage.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAWelcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.lblAWelcomeMessage.Location = new System.Drawing.Point(943, 49);
            this.lblAWelcomeMessage.Name = "lblAWelcomeMessage";
            this.lblAWelcomeMessage.Size = new System.Drawing.Size(145, 28);
            this.lblAWelcomeMessage.TabIndex = 23;
            this.lblAWelcomeMessage.Text = "Complaints";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(166, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 33);
            this.lblTitle.TabIndex = 21;
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
            this.pbxLogo.TabIndex = 22;
            this.pbxLogo.TabStop = false;
            // 
            // btnReply
            // 
            this.btnReply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReply.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReply.ForeColor = System.Drawing.Color.White;
            this.btnReply.Location = new System.Drawing.Point(499, 690);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(153, 37);
            this.btnReply.TabIndex = 28;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // btnDeleteNotification
            // 
            this.btnDeleteNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnDeleteNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotification.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeleteNotification.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNotification.Location = new System.Drawing.Point(99, 690);
            this.btnDeleteNotification.Name = "btnDeleteNotification";
            this.btnDeleteNotification.Size = new System.Drawing.Size(153, 37);
            this.btnDeleteNotification.TabIndex = 27;
            this.btnDeleteNotification.Text = "Delete";
            this.btnDeleteNotification.UseVisualStyleBackColor = false;
            this.btnDeleteNotification.Click += new System.EventHandler(this.btnDeleteNotification_Click);
            // 
            // lbComplaints
            // 
            this.lbComplaints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.ItemHeight = 16;
            this.lbComplaints.Location = new System.Drawing.Point(100, 210);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(988, 324);
            this.lbComplaints.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(933, 690);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 37);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbxMessage
            // 
            this.txbxMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbxMessage.Location = new System.Drawing.Point(98, 563);
            this.txbxMessage.Multiline = true;
            this.txbxMessage.Name = "txbxMessage";
            this.txbxMessage.Size = new System.Drawing.Size(988, 101);
            this.txbxMessage.TabIndex = 30;
            // 
            // FormComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 792);
            this.Controls.Add(this.txbxMessage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.btnDeleteNotification);
            this.Controls.Add(this.lbComplaints);
            this.Controls.Add(this.panelABarTwo);
            this.Controls.Add(this.lblAWelcomeMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxLogo);
            this.Name = "FormComplaints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complaints";
            this.Load += new System.EventHandler(this.FormComplaints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelABarTwo;
        private System.Windows.Forms.Label lblAWelcomeMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Button btnDeleteNotification;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbxMessage;
    }
}