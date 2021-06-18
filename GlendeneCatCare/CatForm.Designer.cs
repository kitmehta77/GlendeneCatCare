namespace GlendeneCatCare
{
    partial class CatForm
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
            this.lstCats = new System.Windows.Forms.ListBox();
            this.lblCatNo = new System.Windows.Forms.Label();
            this.lblCatID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblNeutered = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtNeutered = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCats
            // 
            this.lstCats.FormattingEnabled = true;
            this.lstCats.Location = new System.Drawing.Point(50, 46);
            this.lstCats.Name = "lstCats";
            this.lstCats.Size = new System.Drawing.Size(169, 277);
            this.lstCats.TabIndex = 0;
            // 
            // lblCatNo
            // 
            this.lblCatNo.AutoSize = true;
            this.lblCatNo.Location = new System.Drawing.Point(289, 52);
            this.lblCatNo.Name = "lblCatNo";
            this.lblCatNo.Size = new System.Drawing.Size(40, 13);
            this.lblCatNo.TabIndex = 1;
            this.lblCatNo.Text = "Cat ID:";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(361, 52);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(23, 13);
            this.lblCatID.TabIndex = 2;
            this.lblCatID.Text = "null";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(272, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Cat Name:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(291, 138);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(38, 13);
            this.lblBreed.TabIndex = 4;
            this.lblBreed.Text = "Breed:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(284, 181);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(260, 224);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblNeutered
            // 
            this.lblNeutered.AutoSize = true;
            this.lblNeutered.Location = new System.Drawing.Point(275, 267);
            this.lblNeutered.Name = "lblNeutered";
            this.lblNeutered.Size = new System.Drawing.Size(54, 13);
            this.lblNeutered.TabIndex = 7;
            this.lblNeutered.Text = "Neutered:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(274, 310);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(55, 13);
            this.lblOwnerID.TabIndex = 8;
            this.lblOwnerID.Text = "Owner ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(362, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(362, 138);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(63, 20);
            this.txtBreed.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(362, 181);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(63, 20);
            this.txtGender.TabIndex = 11;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(362, 224);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(63, 20);
            this.txtDateOfBirth.TabIndex = 12;
            // 
            // txtNeutered
            // 
            this.txtNeutered.Location = new System.Drawing.Point(362, 267);
            this.txtNeutered.Name = "txtNeutered";
            this.txtNeutered.Size = new System.Drawing.Size(32, 20);
            this.txtNeutered.TabIndex = 13;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(364, 307);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(32, 20);
            this.txtOwnerID.TabIndex = 14;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(50, 339);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 28);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(144, 339);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 28);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(254, 339);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(94, 28);
            this.btnAddCat.TabIndex = 17;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Location = new System.Drawing.Point(359, 339);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(94, 28);
            this.btnUpdateCat.TabIndex = 18;
            this.btnUpdateCat.Text = "Update Cat";
            this.btnUpdateCat.UseVisualStyleBackColor = true;
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(464, 339);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(94, 28);
            this.btnDeleteCat.TabIndex = 19;
            this.btnDeleteCat.Text = "Delete Cat";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(464, 374);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 28);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // CatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 414);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtNeutered);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblNeutered);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.lblCatNo);
            this.Controls.Add(this.lstCats);
            this.Name = "CatForm";
            this.Text = "Cat Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCats;
        private System.Windows.Forms.Label lblCatNo;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblNeutered;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtNeutered;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnReturn;
    }
}