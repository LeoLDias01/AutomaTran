using AutomaTran.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaTran.Screens
{
    public partial class SingleSearch : Form
    {
        #region ..:: Instances ::..
        GeneralService generalService = new GeneralService();
        #endregion

        #region ..:: Constructor ::..
        public SingleSearch()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::..
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Cleaning all fields
            txtCep.Clear();
            txtUf.Clear();
            txtRenavam.Clear();
            txtLicensePlate.Clear();
            txtChassi.Clear();
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            //Search cep to get Uf
            txtUf.Text = generalService.GetAddress(txtCep.Text);
            // If UF is São Paulo, set Renavam and License Plate with true
            if (txtUf.Text == "SP")
                SetComponentsActive(renavam: true, licensePlate: true, chassi: false, erase: true, process: true);
            else // If Uf is not recognized set all fields with false
                SetComponentsActive(renavam: false, licensePlate: false, chassi: false, erase: false, process: false); 
        }
        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            if (FieldsValidation())
                StartProcess();
        }
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbersField(e);
        }

        private void txtRenavam_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbersField(e);
        }
        private void btnCallSupport_Click(object sender, EventArgs e)
        {
            // Call a support screen
            new Support().ShowDialog();
        }
        #endregion

        #region ..:: General Methods ::..
        private void SetComponentsActive(bool renavam, bool licensePlate, bool chassi, bool erase, bool process)
        {
            pnlRenavam.Visible = renavam;
            pnlPlaca.Visible = licensePlate;
            pnlChassi.Visible = chassi;
            btnClear.Visible = erase;
            btnStartProcess.Enabled = process;
        }
        private bool FieldsValidation()
        {
            // Verifying fields lenght
            if (txtRenavam.TextLength > 9 && txtLicensePlate.TextLength > 5)
                return true;
            else
            {
                MessageBox.Show("Campos Inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private void OnlyNumbersField(KeyPressEventArgs eventArgs)
        {
            // Setting only numbers on this TextBox
            if (!char.IsControl(eventArgs.KeyChar) && !char.IsDigit(eventArgs.KeyChar) && (eventArgs.KeyChar != '.'))
                eventArgs.Handled = true;
        }
        private void StartProcess()
        {
            // Initiate automation
            generalService.StartProcessByUf(txtUf.Text, txtRenavam.Text, txtLicensePlate.Text, txtChassi.Text);
        }
        #endregion
    }
}
