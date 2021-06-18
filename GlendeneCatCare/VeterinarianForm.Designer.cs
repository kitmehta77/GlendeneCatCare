namespace GlendeneCatCare
{
    partial class VeterinarianForm
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
            this.lstVeterinarians = new System.Windows.Forms.ListBox();
            this.lblVeterinarianNo = new System.Windows.Forms.Label();
            this.lblVeterinarianID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVeterinarian = new System.Windows.Forms.Button();
            this.btnUpdateVeterinarian = new System.Windows.Forms.Button();
            this.btnDeleteVeterinarian = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVeterinarians
            // 
            this.lstVeterinarians.FormattingEnabled = true;
            this.lstVeterinarians.Location = new System.Drawing.Point(39, 43);
            this.lstVeterinarians.Name = "lstVeterinarians";
            this.lstVeterinarians.Size = new System.Drawing.Size(157, 251);
            this.lstVeterinarians.TabIndex = 0;
            // 
            // lblVeterinarianNo
            // 
            this.lblVeterinarianNo.AutoSize = true;
            this.lblVeterinarianNo.Location = new System.Drawing.Point(224, 58);
            this.lblVeterinarianNo.Name = "lblVeterinarianNo";
            this.lblVeterinarianNo.Size = new System.Drawing.Size(80, 13);
            this.lblVeterinarianNo.TabIndex = 1;
            this.lblVeterinarianNo.Text = "Veterinarian ID:";
            this.lblVeterinarianNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVeterinarianID
            // 
            this.lblVeterinarianID.AutoSize = true;
            this.lblVeterinarianID.Location = new System.Drawing.Point(328, 58);
            this.lblVeterinarianID.Name = "lblVeterinarianID";
            this.lblVeterinarianID.Size = new System.Drawing.Size(23, 13);
            this.lblVeterinarianID.TabIndex = 2;
            this.lblVeterinarianID.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(243, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(243, 142);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(270, 188);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(33, 13);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "Rate:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(331, 97);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(331, 139);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(331, 185);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(47, 20);
            this.txtRate.TabIndex = 8;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(39, 312);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(68, 27);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(128, 312);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 27);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVeterinarian
            // 
            this.btnAddVeterinarian.Location = new System.Drawing.Point(227, 312);
            this.btnAddVeterinarian.Name = "btnAddVeterinarian";
            this.btnAddVeterinarian.Size = new System.Drawing.Size(111, 27);
            this.btnAddVeterinarian.TabIndex = 11;
            this.btnAddVeterinarian.Text = "Add Veterinarian";
            this.btnAddVeterinarian.UseVisualStyleBackColor = true;
            this.btnAddVeterinarian.Click += new System.EventHandler(this.btnAddVeterinarian_Click);
            // 
            // btnUpdateVeterinarian
            // 
            this.btnUpdateVeterinarian.Location = new System.Drawing.Point(353, 312);
            this.btnUpdateVeterinarian.Name = "btnUpdateVeterinarian";
            this.btnUpdateVeterinarian.Size = new System.Drawing.Size(111, 27);
            this.btnUpdateVeterinarian.TabIndex = 12;
            this.btnUpdateVeterinarian.Text = "Update Veterinarian";
            this.btnUpdateVeterinarian.UseVisualStyleBackColor = true;
            this.btnUpdateVeterinarian.Click += new System.EventHandler(this.btnUpdateVeterinarian_Click);
            // 
            // btnDeleteVeterinarian
            // 
            this.btnDeleteVeterinarian.Location = new System.Drawing.Point(479, 312);
            this.btnDeleteVeterinarian.Name = "btnDeleteVeterinarian";
            this.btnDeleteVeterinarian.Size = new System.Drawing.Size(111, 27);
            this.btnDeleteVeterinarian.TabIndex = 13;
            this.btnDeleteVeterinarian.Text = "Delete Veterinarian";
            this.btnDeleteVeterinarian.UseVisualStyleBackColor = true;
            this.btnDeleteVeterinarian.Click += new System.EventHandler(this.btnDeleteVeterinarian_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(479, 361);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 27);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // VeterinarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 406);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVeterinarian);
            this.Controls.Add(this.btnUpdateVeterinarian);
            this.Controls.Add(this.btnAddVeterinarian);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblVeterinarianID);
            this.Controls.Add(this.lblVeterinarianNo);
            this.Controls.Add(this.lstVeterinarians);
            this.Name = "VeterinarianForm";
            this.Text = "Veterinarian  Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVeterinarians;
        private System.Windows.Forms.Label lblVeterinarianNo;
        private System.Windows.Forms.Label lblVeterinarianID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVeterinarian;
        private System.Windows.Forms.Button btnUpdateVeterinarian;
        private System.Windows.Forms.Button btnDeleteVeterinarian;
        private System.Windows.Forms.Button btnReturn;
    }
}