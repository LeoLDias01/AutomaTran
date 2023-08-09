using AutomaTran.Controllers;
using AutomaTran.Models;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaTran.Screens
{
    public partial class GroupSearch : Form
    {
        #region ..:: Instances::..
        List<WorksheetRows> worksheetRows = new List<WorksheetRows>();
        GeneralService generalService = new GeneralService();
        #endregion

        #region ..:: Constructor ::..
        public GroupSearch()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::..
        private void btnImportData_Click(object sender, EventArgs e)
        {
            // Searching data archive
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Archive location
                txtFileLocation.Text = ofd.FileName;
                ImportData(location: ofd.FileName);
            }
            else
                MessageBox.Show("Não foi possível localizar arquivo!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnCallSupport_Click(object sender, EventArgs e)
        {
            new Support().ShowDialog();
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            // Processing data
            foreach (var item in worksheetRows)
            {
                generalService.StartProcessByUf(item.Uf, item.Renavam, item.LicensePlate, item.Chassi);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Cleaning Fields
            dgvImport.DataSource = null;
            txtFileLocation.Clear();
            worksheetRows = null;
        }
        #endregion

        #region ..:: General Methods ::..
        // Importing 
        private void ImportData(string location)
        {
            // Opening the Excel in the path
            var xls = new XLWorkbook(location);
            // Selecting tab
            var worksheet = xls.Worksheets.First(w => w.Name == "Planilha1");
        
            var totalRows = worksheet.Rows().Count();

            // We use the second line, because the first line is used to header
            for (int line = 2; line <= totalRows; line++)
            {
                try
                {
                    // Setting values 
                    var renavam = worksheet.Cell($"A{line}").Value.ToString();
                    var licensePlate = worksheet.Cell($"B{line}").Value.ToString();
                    var chassi = worksheet.Cell($"C{line}").Value.ToString();
                    var uf = worksheet.Cell($"D{line}").Value.ToString();

                    // Add values to List
                    worksheetRows.Add(new WorksheetRows()
                    {
                        Renavam = renavam.Trim(),
                        LicensePlate = licensePlate.Trim(),
                        Chassi = chassi.Trim(),
                        Uf = uf.Trim()
                    });
                }
                catch
                {
                    MessageBox.Show("Erro no formato do arquivo", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Fill Grid
            DatagridData();
            //Activate start button 
            StartButtonSettings();
        }
        private void DatagridData() 
        {
            dgvImport.DataSource = null;
            dgvImport.AutoGenerateColumns = false;
            // using list to show data on datagrid
            dgvImport.DataSource = worksheetRows;
        }
        private void StartButtonSettings()
        {
            // if datagrid is empty, we lock the start button 
            if (dgvImport.Rows.Count < 1)
                btnStartProcess.Enabled = false;
            else
                btnStartProcess.Enabled = true;
        }
        #endregion
    }
}
