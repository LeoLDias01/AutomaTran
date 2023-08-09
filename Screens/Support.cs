using AutomaTran.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaTran.Screens
{
    public partial class Support : Form
    {
        #region ..:: Instances ::..
        GeneralService generalService = new GeneralService();
        #endregion

        #region ..:: Constructor ::..
        public Support()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::..
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Set wait cursor
            Cursor = Cursors.WaitCursor;
            // Disabling form
            this.Enabled = false;
            // Taking Ip based on Hostname
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());

            // Email valuex is correct, we send a e-mail
            if (Validation())
                generalService.SendEmail(emailToSend: txtEmail.Text.Trim(), summary: txtDesc.Text, description: txtDetail.Text, ip: ip[1].ToString(), hostname: Dns.GetHostName().ToString());

            // Set Default cursor
            Cursor = Cursors.Default;
            //Enable form
            this.Enabled = true;
            // Cleaning fields
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtDesc.Clear();
            txtDetail.Clear();
        }
        #endregion

        #region ..:: General Methods ::..

        /// <summary>
        /// Validating email, if corresponds the regex
        /// </summary>
        /// <returns></returns>
        private bool Validation()
        {
            Regex regexEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (regexEmail.IsMatch(txtEmail.Text))
            {
                if (txtDesc.TextLength > 3 && txtDetail.TextLength > 5)
                    return true;
                else
                {
                    MessageBox.Show("Campos Inválidos, texto não correspopnde ao mínimo de caracteres aceito", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("E-mail inválido", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}
