
namespace StudentHousingApp
{
    partial class FormTenantsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTenantsManagement));
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.lbStudentInfo = new System.Windows.Forms.ListBox();
            this.btnShowStudentInfo = new System.Windows.Forms.Button();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.lblAWelcomeMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panelABarTwo = new System.Windows.Forms.Panel();
            this.lblAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStudentID
            // 
            this.cbStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(314, 278);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(222, 24);
            this.cbStudentID.TabIndex = 0;
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(161, 274);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(124, 23);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(161, 322);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 23);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(161, 370);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 23);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.Location = new System.Drawing.Point(314, 328);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(222, 22);
            this.tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(314, 376);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(222, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(165, 475);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(371, 37);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.Location = new System.Drawing.Point(165, 538);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(371, 37);
            this.btnRemoveUser.TabIndex = 7;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // lbStudentInfo
            // 
            this.lbStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentInfo.FormattingEnabled = true;
            this.lbStudentInfo.ItemHeight = 16;
            this.lbStudentInfo.Location = new System.Drawing.Point(640, 278);
            this.lbStudentInfo.Name = "lbStudentInfo";
            this.lbStudentInfo.Size = new System.Drawing.Size(382, 340);
            this.lbStudentInfo.TabIndex = 10;
            // 
            // btnShowStudentInfo
            // 
            this.btnShowStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowStudentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnShowStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStudentInfo.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShowStudentInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowStudentInfo.Location = new System.Drawing.Point(640, 648);
            this.btnShowStudentInfo.Name = "btnShowStudentInfo";
            this.btnShowStudentInfo.Size = new System.Drawing.Size(382, 42);
            this.btnShowStudentInfo.TabIndex = 11;
            this.btnShowStudentInfo.Text = "Show Students";
            this.btnShowStudentInfo.UseVisualStyleBackColor = false;
            this.btnShowStudentInfo.Click += new System.EventHandler(this.btnShowStudentInfo_Click);
            // 
            // btnLogClear
            // 
            this.btnLogClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnLogClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogClear.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogClear.ForeColor = System.Drawing.Color.White;
            this.btnLogClear.Location = new System.Drawing.Point(640, 716);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(382, 34);
            this.btnLogClear.TabIndex = 12;
            this.btnLogClear.Text = "Clear Log";
            this.btnLogClear.UseVisualStyleBackColor = false;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // lblAWelcomeMessage
            // 
            this.lblAWelcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAWelcomeMessage.AutoSize = true;
            this.lblAWelcomeMessage.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAWelcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.lblAWelcomeMessage.Location = new System.Drawing.Point(832, 44);
            this.lblAWelcomeMessage.Name = "lblAWelcomeMessage";
            this.lblAWelcomeMessage.Size = new System.Drawing.Size(253, 28);
            this.lblAWelcomeMessage.TabIndex = 15;
            this.lblAWelcomeMessage.Text = "Tenant Management";
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
            this.lblTitle.TabIndex = 13;
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
            this.pbxLogo.TabIndex = 14;
            this.pbxLogo.TabStop = false;
            // 
            // panelABarTwo
            // 
            this.panelABarTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelABarTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.panelABarTwo.Location = new System.Drawing.Point(-21, 122);
            this.panelABarTwo.Name = "panelABarTwo";
            this.panelABarTwo.Size = new System.Drawing.Size(1284, 38);
            this.panelABarTwo.TabIndex = 16;
            // 
            // lblAdd
            // 
            this.lblAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Black;
            this.lblAdd.Location = new System.Drawing.Point(158, 201);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(236, 28);
            this.lblAdd.TabIndex = 17;
            this.lblAdd.Text = "Add a new student:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(635, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Student information:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorMessage.Location = new System.Drawing.Point(165, 427);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(371, 21);
            this.lblErrorMessage.TabIndex = 19;
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTenantsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 792);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.panelABarTwo);
            this.Controls.Add(this.lblAWelcomeMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnLogClear);
            this.Controls.Add(this.btnShowStudentInfo);
            this.Controls.Add(this.lbStudentInfo);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.cbStudentID);
            this.Location = new System.Drawing.Point(1017, 839);
            this.Name = "FormTenantsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenants Management";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.ListBox lbStudentInfo;
        private System.Windows.Forms.Button btnShowStudentInfo;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.Label lblAWelcomeMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panelABarTwo;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}