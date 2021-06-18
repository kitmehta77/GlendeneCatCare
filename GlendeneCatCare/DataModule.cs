using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlendeneCatCare
{
    public partial class DataModule : Form
    {
        public DataTable dtCat;
        public DataTable dtOwner;
        public DataTable dtVeterinarian;
        public DataTable dtTreatment;
        public DataTable dtVisit;
        public DataTable dtVisitTreatment;
        public DataView catView;
        public DataView treatmentView;
        public DataView ownerView;
        public DataView veterinarianView;
        public DataView visitView;
        public DataView visitTreatmentView;

        public DataModule()
        {
            InitializeComponent();
            DSGlendene.EnforceConstraints = false;
            daCat.Fill(DSGlendene);
            daTreatment.Fill(DSGlendene);
            daOwner.Fill(DSGlendene);
            daVisit.Fill(DSGlendene);
            daVeterinarian.Fill(DSGlendene);
            daVisitTreatment.Fill(DSGlendene);
            dtCat = DSGlendene.Tables["Cat"];
            dtTreatment = DSGlendene.Tables["Treatment"];
            dtOwner = DSGlendene.Tables["Owner"];
            dtVeterinarian = DSGlendene.Tables["Veterinarian"];
            dtVisit = DSGlendene.Tables["Visit"];
            dtVisitTreatment  = DSGlendene.Tables["VisitTreatment"];
            catView = new DataView(dtCat);
            catView.Sort = "CatID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            treatmentView = new DataView(dtTreatment);
            treatmentView.Sort = "TreatmentID";
            veterinarianView = new DataView(dtVeterinarian);
            veterinarianView.Sort = "VeterinarianID";
            DSGlendene.EnforceConstraints = true;
        }

        public void UpdateTreatment()
        {
            daTreatment.Update(dtTreatment);
        }

        public void UpdateOwner()
        {
            daOwner.Update(dtOwner);
        }

        public void UpdateVeterinarian()
        {
            daVeterinarian.Update(dtVeterinarian);
        }


        public void UpdateVisitTreatment()
        {
            daVisitTreatment.Update(dtVisitTreatment);
        }


        public void UpdateCat()
        {
            daCat.Update(dtCat);
        }

        public void UpdateVisit()
        {
            daVisit.Update(dtVisit);
        }


        private void oleDbDataAdapter1_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void daTreatment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["TreatmentID"] = newID;
            }
        }
    }
}
