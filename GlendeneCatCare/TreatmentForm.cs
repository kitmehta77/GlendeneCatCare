using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlendeneCatCare
{
    public partial class TreatmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public TreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddTreatment.Left = 220;
            pnlAddTreatment.Top = 40;
        }

        public void BindControls()
        {
            lblTreatmentID.DataBindings.Add("Text", DM.DSGlendene, "Treatment.TreatmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Description");
            txtCost.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Cost");
            txtDescription.Enabled = false;
            txtCost.Enabled = false;
            lstTreatments.DataSource = DM.DSGlendene;
            lstTreatments.DisplayMember = "Treatment.Description";
            lstTreatments.ValueMember = "Treatment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "TREATMENT"];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            lstTreatments.Visible = false;       // Note that if you use this line of code
            lstTreatments.Enabled = false;       // … you do not need this line
            lstTreatments.SelectedItem = null;   // … or this line
            btnDeleteTreatment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateTreatment.Enabled = false;
            btnAddTreatment.Enabled = false;
            pnlAddTreatment.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];
            DataRow[] VisitTreatmentRow = DM.dtVisitTreatment.Select("TreatmentID = " + lblTreatmentID.Text);
            if (VisitTreatmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteTreatmentRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Treatments that are not allocated to visits", "Error");
                return;
            }
            //Update
            DM.UpdateTreatment();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];

            if ((txtDescription.Text == "") || (txtCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");

            }
            else
            {
                updateTreatmentRow["Description"] = txtDescription.Text;
                updateTreatmentRow["Cost"] = Convert.ToDouble(txtCost.Text);
                currencyManager.EndCurrentEdit();
                DM.UpdateTreatment();
                MessageBox.Show("Treatment updated successfully", "Success");
            }
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddTreatment.Hide();
            lstTreatments.Enabled = true;
            lstTreatments.Visible = true;
            btnDeleteTreatment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateTreatment.Enabled = true;
            btnAddTreatment.Enabled = true;
        }

        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {
            lblTreatmentID.Text = null;
            DataRow newTreatmentRow = DM.dtTreatment.NewRow();

            if ((txtAddDescription.Text == "") || (txtAddCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");

            }
            else
            {
                try
                {
                    newTreatmentRow["Description"] = txtAddDescription.Text;
                    newTreatmentRow["Cost"] = Convert.ToDouble(txtAddCost.Text);
                    DM.dtTreatment.Rows.Add(newTreatmentRow);
                    MessageBox.Show("Treatment added successfully", "Success");
                    DM.UpdateTreatment();
                }
                catch (FormatException ex)
                {
	                MessageBox.Show("Please enter a number for cost", "Error");
                }
            }
            return;
        }
    }
}
