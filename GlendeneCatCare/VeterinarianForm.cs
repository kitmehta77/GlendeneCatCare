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
    public partial class VeterinarianForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public VeterinarianForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            lblVeterinarianID.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.VeterinarianID");
            txtLastName.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.LastName");
            txtFirstName.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.FirstName");
            txtRate.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.Rate");
            lstVeterinarians.DataSource = DM.DSGlendene;
            lstVeterinarians.DisplayMember = "Veterinarian.LastName";
            lstVeterinarians.ValueMember = "Veterinarian.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VETERINARIAN"];
        }


        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnAddVeterinarian_Click(object sender, EventArgs e)
        {
            //Create a new row that the variables will be added into
            DataRow newVeterinarianRow = DM.dtVeterinarian.NewRow();

            //If any of the text areas are empty then do not write data and return
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
               (txtRate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                newVeterinarianRow["LastName"] = txtLastName.Text;
                newVeterinarianRow["FirstName"] = txtFirstName.Text;
                newVeterinarianRow["Rate"] = Convert.ToDouble(txtRate.Text);
                //Add the new row to the Table
                DM.dtVeterinarian.Rows.Add(newVeterinarianRow);
                DM.UpdateVeterinarian();
                //Give the user a success message
                MessageBox.Show("Veterinarian added successfully", "Success");
            }
            return;
        }

        private void btnDeleteVeterinarian_Click(object sender, EventArgs e)
        {
            DataRow deleteVeterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];
            DataRow[] VisitRow = DM.dtVisit.Select("VeterinarianID = " + lblVeterinarianID.Text);
            if (VisitRow.Length != 0)
            {
                MessageBox.Show("You may only delete Veterinarians who do not have visits", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVeterinarianRow.Delete();
                    DM.UpdateVeterinarian();
                }
            }
            return;
        }

        private void btnUpdateVeterinarian_Click(object sender, EventArgs e)
        {
            DataRow updateVeterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
               (txtRate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
                return;
            }
            else
            {
                //Add the text areas
                updateVeterinarianRow["LastName"] = txtLastName.Text;
                updateVeterinarianRow["FirstName"] = txtFirstName.Text;
                updateVeterinarianRow["Rate"] = Convert.ToDouble(txtRate.Text);
                //Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateVeterinarian();
                //Give the user a success message
                MessageBox.Show("Veterinarian updated successfully", "Success");
            }
            return;
        }
    }
}
