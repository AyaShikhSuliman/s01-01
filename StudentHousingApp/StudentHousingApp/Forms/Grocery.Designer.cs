
namespace StudentHousingApp
{
    partial class FormGrocery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrocery));
            this.lblProduct = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btnAddToListBox = new System.Windows.Forms.Button();
            this.btnRequestMoney = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panelABarTwo = new System.Windows.Forms.Panel();
            this.lblAWelcomeMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPricePerTenant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblProduct.Location = new System.Drawing.Point(156, 245);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(169, 23);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product Name: ";
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductName.Location = new System.Drawing.Point(331, 245);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(194, 22);
            this.tbProductName.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(157, 287);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrice.Location = new System.Drawing.Point(303, 290);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(222, 22);
            this.tbPrice.TabIndex = 3;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 16;
            this.lbInfo.Location = new System.Drawing.Point(161, 390);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(392, 340);
            this.lbInfo.TabIndex = 4;
            // 
            // btnAddToListBox
            // 
            this.btnAddToListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddToListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnAddToListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToListBox.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddToListBox.ForeColor = System.Drawing.Color.White;
            this.btnAddToListBox.Location = new System.Drawing.Point(160, 333);
            this.btnAddToListBox.Name = "btnAddToListBox";
            this.btnAddToListBox.Size = new System.Drawing.Size(393, 37);
            this.btnAddToListBox.TabIndex = 5;
            this.btnAddToListBox.Text = "Add product";
            this.btnAddToListBox.UseVisualStyleBackColor = false;
            this.btnAddToListBox.Click += new System.EventHandler(this.btnAddToListBox_Click);
            // 
            // btnRequestMoney
            // 
            this.btnRequestMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRequestMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.btnRequestMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestMoney.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRequestMoney.ForeColor = System.Drawing.Color.White;
            this.btnRequestMoney.Location = new System.Drawing.Point(593, 693);
            this.btnRequestMoney.Name = "btnRequestMoney";
            this.btnRequestMoney.Size = new System.Drawing.Size(412, 37);
            this.btnRequestMoney.TabIndex = 10;
            this.btnRequestMoney.Text = "Send money request";
            this.btnRequestMoney.UseVisualStyleBackColor = false;
            this.btnRequestMoney.Click += new System.EventHandler(this.btnRequestMoney_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescription.Location = new System.Drawing.Point(593, 430);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(412, 239);
            this.tbDescription.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(588, 379);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(206, 28);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Add Description:";
            // 
            // panelABarTwo
            // 
            this.panelABarTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelABarTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            this.panelABarTwo.Location = new System.Drawing.Point(-21, 122);
            this.panelABarTwo.Name = "panelABarTwo";
            this.panelABarTwo.Size = new System.Drawing.Size(1415, 38);
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
            this.lblAWelcomeMessage.Size = new System.Drawing.Size(103, 28);
            this.lblAWelcomeMessage.TabIndex = 23;
            this.lblAWelcomeMessage.Text = "Grocery";
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
            // lblEuro
            // 
            this.lblEuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblEuro.Location = new System.Drawing.Point(531, 287);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(22, 23);
            this.lblEuro.TabIndex = 25;
            this.lblEuro.Text = "€";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(992, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(992, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "€";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(589, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total Price:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(587, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price per tenant: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.Location = new System.Drawing.Point(811, 259);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(175, 23);
            this.lblTotalPrice.TabIndex = 30;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPricePerTenant
            // 
            this.lblPricePerTenant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPricePerTenant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPricePerTenant.Location = new System.Drawing.Point(811, 317);
            this.lblPricePerTenant.Name = "lblPricePerTenant";
            this.lblPricePerTenant.Size = new System.Drawing.Size(175, 23);
            this.lblPricePerTenant.TabIndex = 31;
            this.lblPricePerTenant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGrocery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 792);
            this.Controls.Add(this.lblPricePerTenant);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.panelABarTwo);
            this.Controls.Add(this.lblAWelcomeMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnRequestMoney);
            this.Controls.Add(this.btnAddToListBox);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lblProduct);
            this.Name = "FormGrocery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grocery";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Button btnAddToListBox;
        private System.Windows.Forms.Button btnRequestMoney;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelABarTwo;
        private System.Windows.Forms.Label lblAWelcomeMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPricePerTenant;
    }
}