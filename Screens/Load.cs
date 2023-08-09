using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaTran.Screens
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            // Set loading time
            LoadTimer.Interval = 5000; // 5000 = 5 seconds
        }
        private void Load_Load(object sender, EventArgs e)
        {
            // Start timer
            LoadTimer.Start();
            // Show system version in label
            Version.Text = "Versão:  " + Application.ProductVersion;
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            // stop timer
            LoadTimer.Stop();
            this.Hide();
            // Call menu screen
            new Menu().ShowDialog();
        }
    }
}
