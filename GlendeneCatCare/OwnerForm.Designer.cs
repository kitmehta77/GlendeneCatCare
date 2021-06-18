namespace GlendeneCatCare
{
    partial class OwnerForm
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
            this.lstOwners = new System.Windows.Forms.ListBox();
            this.lblOwnerNo = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOwners
            // 
            this.lstOwners.FormattingEnabled = true;
            this.lstOwners.Location = new System.Drawing.Point(38, 44);
            this.lstOwners.Name = "lstOwners";
            this.lstOwners.Size = new System.Drawing.Size(146, 264);
            this.lstOwners.TabIndex = 0;
            // 
            // lblOwnerNo
            // 
            this.lblOwnerNo.AutoSize = true;
            this.lblOwnerNo.Location = new System.Drawing.Point(256, 53);
            this.lblOwnerNo.Name = "lblOwnerNo";
            this.lblOwnerNo.Size = new System.Drawing.Size(55, 13);
            this.lblOwnerNo.TabIndex = 1;
            this.lblOwnerNo.Text = "Owner ID:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(318, 53);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(23, 13);
            this.lblOwnerID.TabIndex = 2;
            this.lblOwnerID.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(250, 94);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(251, 135);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(232, 176);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(79, 13);
            this.lblStreetAddress.TabIndex = 5;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(267, 217);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblSuburb.TabIndex = 6;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(230, 258);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(318, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(105, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(318, 135);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(105, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(318, 176);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(295, 20);
            this.txtStreetAddress.TabIndex = 10;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(318, 217);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(105, 20);
            this.txtSuburb.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(318, 258);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(66, 20);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(38, 322);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(64, 23);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(120, 322);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(253, 322);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(97, 23);
            this.btnAddOwner.TabIndex = 15;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(384, 322);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(97, 23);
            this.btnUpdateOwner.TabIndex = 16;
            this.btnUpdateOwner.Text = "Update Owner";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(515, 322);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteOwner.TabIndex = 17;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(516, 371);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(97, 23);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 492);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnUpdateOwner);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblOwnerNo);
            this.Controls.Add(this.lstOwners);
            this.Name = "OwnerForm";
            this.Text = "Owner  Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOwners;
        private System.Windows.Forms.Label lblOwnerNo;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnReturn;
    }
}