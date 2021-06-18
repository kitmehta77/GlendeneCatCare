namespace GlendeneCatCare
{
    partial class InvoiceForm
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
            this.txtInvoices = new System.Windows.Forms.TextBox();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInvoices
            // 
            this.txtInvoices.Location = new System.Drawing.Point(46, 25);
            this.txtInvoices.MaximumSize = new System.Drawing.Size(990, 600);
            this.txtInvoices.MinimumSize = new System.Drawing.Size(990, 400);
            this.txtInvoices.Multiline = true;
            this.txtInvoices.Name = "txtInvoices";
            this.txtInvoices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvoices.Size = new System.Drawing.Size(990, 489);
            this.txtInvoices.TabIndex = 0;
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(918, 532);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(105, 23);
            this.btnDisplayReport.TabIndex = 1;
            this.btnDisplayReport.Text = "Display Report";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(783, 532);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(105, 23);
            this.btnPrintReport.TabIndex = 2;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(918, 569);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 604);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.txtInvoices);
            this.Name = "InvoiceForm";
            this.Text = "Invoices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoices;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnReturn;
    }
}