using AutomaTran.Models.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaTran.Controllers
{
    public class SPservice
    {
        Firefox firefox;
        /// <summary>
        /// Open browser to initialize automation
        /// </summary>
        /// <param name="link"></param>
        /// <param name="downloadDirectory"></param>
        public void OpenBrowser(string link, string downloadDirectory)
        {
            // Set configuration to Firefox
            firefox = new Firefox(InterfaceType.OnlyBrowser, isAdministrator: false, downloadPath: downloadDirectory);
            try
            {
                // Open a Window
                firefox.Driver.Manage().Window.Maximize();
                // Go to link
                firefox.Navigate(link);
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar, sistema com erro no método 'OpenBrowser', \nErro:\n" + ex);
            }
        }
        /// <summary>
        /// Insert Car values into the fields
        /// </summary>
        /// <param name="renavam"></param>
        /// <param name="licensePlate"></param>
        public void InsertCarData(string renavam, string licensePlate)
        {
            try
            {
                // Wait fields loading
                firefox.WaitUntil(x => x.CustomFindElementXPath(@"//*[@id='conteudoPaginaPlaceHolder_btn_Consultar']") != null);
                // Set renavam
                firefox.SetValue(@"//*[@id='conteudoPaginaPlaceHolder_txtRenavam']", renavam);
                Thread.Sleep(500);
                // set License Plate
                firefox.SetValue(@"//*[@id='conteudoPaginaPlaceHolder_txtPlaca']", licensePlate);
                Thread.Sleep(500);
                // Wait captcha loading
                var captcha = firefox.CustomFindElementXPath(@"//*[@title='reCAPTCHA']");
                string verify = captcha.GetAttribute("name");
                // Get a mark 
                firefox.SwitchToFrame(verify);
                // Waiting until captcha is checked 
                firefox.WaitUntil(
                    nav => nav.CustomFindElementXPath(@"//*[contains(@class,'recaptcha-checkbox-checked')]") != null,
                    timeout: 120);
                firefox.Driver.SwitchTo().DefaultContent();
                // Consulting
                firefox.Click(@"//*[@id='conteudoPaginaPlaceHolder_btn_Consultar']");
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar, sistema com erro no método 'InsertCarData', \nErro:\n" + ex);
            }
        }
        /// <summary>
        /// Donwload document
        /// </summary>
        public void DownloadDocument()
        {
            try
            {
                // Wait button load
                firefox.WaitUntil(x => x.CustomFindElementXPath(@"//*[@id='conteudoPaginaPlaceHolder_btn_Imprimir']") != null);
                // Click 
                firefox.Click(@"//*[@id='conteudoPaginaPlaceHolder_btn_Imprimir']");
                firefox.WaitUntilLoaded();
                // Close browser
                firefox.Dispose();
                MessageBox.Show("Processo finalizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar, sistema com erro no método 'DownloadDocument', \nErro:\n" + ex);
            }
        }
    }
}
