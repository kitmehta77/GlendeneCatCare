namespace GlendeneCatCare
{
    partial class TreatmentForm
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
            this.lstTreatments = new System.Windows.Forms.ListBox();
            this.lblTreatmentNo = new System.Windows.Forms.Label();
            this.lblTreatmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.btnUpdateTreatment = new System.Windows.Forms.Button();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddTreatment = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.pnlAddTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTreatments
            // 
            this.lstTreatments.FormattingEnabled = true;
            this.lstTreatments.Location = new System.Drawing.Point(45, 41);
            this.lstTreatments.Name = "lstTreatments";
            this.lstTreatments.Size = new System.Drawing.Size(165, 225);
            this.lstTreatments.TabIndex = 0;
            // 
            // lblTreatmentNo
            // 
            this.lblTreatmentNo.AutoSize = true;
            this.lblTreatmentNo.Location = new System.Drawing.Point(221, 41);
            this.lblTreatmentNo.Name = "lblTreatmentNo";
            this.lblTreatmentNo.Size = new System.Drawing.Size(72, 13);
            this.lblTreatmentNo.TabIndex = 1;
            this.lblTreatmentNo.Text = "Treatment ID:";
            // 
            // lblTreatmentID
            // 
            this.lblTreatmentID.AutoSize = true;
            this.lblTreatmentID.Location = new System.Drawing.Point(300, 41);
            this.lblTreatmentID.Name = "lblTreatmentID";
            this.lblTreatmentID.Size = new System.Drawing.Size(55, 13);
            this.lblTreatmentID.TabIndex = 2;
            this.lblTreatmentID.Text = "Treatment";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(230, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(258, 121);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(303, 80);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(174, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(303, 121);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(52, 20);
            this.txtCost.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(45, 293);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(135, 293);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(233, 293);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(94, 23);
            this.btnAddTreatment.TabIndex = 9;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.Location = new System.Drawing.Point(344, 293);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(104, 23);
            this.btnUpdateTreatment.TabIndex = 10;
            this.btnUpdateTreatment.Text = "Update Treatment";
            this.btnUpdateTreatment.UseVisualStyleBackColor = true;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.Location = new System.Drawing.Point(467, 293);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteTreatment.TabIndex = 11;
            this.btnDeleteTreatment.Text = "Delete Treatment";
            this.btnDeleteTreatment.UseVisualStyleBackColor = true;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(467, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(104, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddTreatment
            // 
            this.pnlAddTreatment.Controls.Add(this.btnCancel);
            this.pnlAddTreatment.Controls.Add(this.btnSaveTreatment);
            this.pnlAddTreatment.Controls.Add(this.txtAddCost);
            this.pnlAddTreatment.Controls.Add(this.txtAddDescription);
            this.pnlAddTreatment.Controls.Add(this.lblAddCost);
            this.pnlAddTreatment.Controls.Add(this.lblAddDescription);
            this.pnlAddTreatment.Location = new System.Drawing.Point(233, 159);
            this.pnlAddTreatment.Name = "pnlAddTreatment";
            this.pnlAddTreatment.Size = new System.Drawing.Size(300, 118);
            this.pnlAddTreatment.TabIndex = 13;
            this.pnlAddTreatment.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(35, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.Location = new System.Drawing.Point(185, 86);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(94, 23);
            this.btnSaveTreatment.TabIndex = 14;
            this.btnSaveTreatment.Text = "Save Treatment";
            this.btnSaveTreatment.UseVisualStyleBackColor = true;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSaveTreatment_Click);
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(102, 46);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(52, 20);
            this.txtAddCost.TabIndex = 3;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(102, 17);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(162, 20);
            this.txtAddDescription.TabIndex = 2;
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(57, 46);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(31, 13);
            this.lblAddCost.TabIndex = 1;
            this.lblAddCost.Text = "Cost:";
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(25, 17);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(63, 13);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description:";
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 401);
            this.Controls.Add(this.pnlAddTreatment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteTreatment);
            this.Controls.Add(this.btnUpdateTreatment);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTreatmentID);
            this.Controls.Add(this.lblTreatmentNo);
            this.Controls.Add(this.lstTreatments);
            this.Name = "TreatmentForm";
            this.Text = "Treatment Maintenance";
            this.pnlAddTreatment.ResumeLayout(false);
            this.pnlAddTreatment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTreatments;
        private System.Windows.Forms.Label lblTreatmentNo;
        private System.Windows.Forms.Label lblTreatmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.Button btnUpdateTreatment;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddTreatment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveTreatment;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Label lblAddDescription;
    }
}