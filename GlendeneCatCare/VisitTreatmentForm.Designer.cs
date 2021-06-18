﻿namespace GlendeneCatCare
{
    partial class VisitTreatmentForm
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
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.dgvVisitTreatments = new System.Windows.Forms.DataGridView();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.btnRmove = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisits
            // 
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Location = new System.Drawing.Point(46, 44);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.Size = new System.Drawing.Size(565, 209);
            this.dgvVisits.TabIndex = 0;
            // 
            // dgvVisitTreatments
            // 
            this.dgvVisitTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitTreatments.Location = new System.Drawing.Point(46, 296);
            this.dgvVisitTreatments.Name = "dgvVisitTreatments";
            this.dgvVisitTreatments.Size = new System.Drawing.Size(240, 150);
            this.dgvVisitTreatments.TabIndex = 1;
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatments.Location = new System.Drawing.Point(482, 296);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.Size = new System.Drawing.Size(311, 150);
            this.dgvTreatments.TabIndex = 2;
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(342, 296);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(75, 40);
            this.btnAllocate.TabIndex = 3;
            this.btnAllocate.Text = "Allocate Treatment";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // btnRmove
            // 
            this.btnRmove.Location = new System.Drawing.Point(342, 406);
            this.btnRmove.Name = "btnRmove";
            this.btnRmove.Size = new System.Drawing.Size(75, 40);
            this.btnRmove.TabIndex = 4;
            this.btnRmove.Text = "Remove Treatment";
            this.btnRmove.UseVisualStyleBackColor = true;
            this.btnRmove.Click += new System.EventHandler(this.btnRmove_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(718, 481);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 40);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(313, 361);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(368, 361);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(39, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // VisitTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 547);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRmove);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.dgvTreatments);
            this.Controls.Add(this.dgvVisitTreatments);
            this.Controls.Add(this.dgvVisits);
            this.Name = "VisitTreatmentForm";
            this.Text = "Allocate Treatment to Visit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.DataGridView dgvVisitTreatments;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Button btnRmove;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}