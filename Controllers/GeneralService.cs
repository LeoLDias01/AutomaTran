using AutomaTran.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaTran.Controllers
{
    public class GeneralService
    {
        #region ..:: Instances ::..
        SPservice spService = new SPservice();
        #endregion

        #region ..:: Variables ::..
        public string usuario = Environment.UserName.ToString();
        public string downloadPath;
        #endregion

        #region ..:: API Call ::..
        public string GetAddress(string cep)
        {
            // Get data from Viacep
            RestClient client = new RestClient($"https://viacep.com.br/ws/" + cep.Trim() + "/json/");
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            // Saving API response into the object
            Address address = new JsonDeserializer().Deserialize<Address>(response);
            return address.Uf;
        }
        #endregion

        #region ..:: Automation Methods ::..
        public void StartProcessByUf(string uf, string renavam, string licensePlate, string chassi)
        {
            // Creating donwload directory
            DownloadDirectoryCreation();

            // Separate Uf Process
            switch (uf)
            {
                case "SP":
                    spService.OpenBrowser("https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx", downloadPath);
                    spService.InsertCarData(renavam, licensePlate);
                    spService.DownloadDocument();
                    break;
            }

        }
        public void DownloadDirectoryCreation()
        {
            //Set download path
            downloadPath = $@"C:\Users\{usuario}\Downloads\Detran";
            if (!Directory.Exists(downloadPath))
                Directory.CreateDirectory(downloadPath);
        }
        #endregion

        #region ..:: Mailer ::..

        /// <summary>
        /// Sending mail
        /// </summary>
        /// <param name="emailToSend"></param>
        /// <param name="summary"></param>
        /// <param name="description"></param>
        /// <param name="ip"></param>
        /// <param name="hostname"></param>
        public void SendEmail(string emailToSend, string summary, string description, string ip, string hostname)
        {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("zpayautoma.disparos2023@outlook.com", "PayAuto@2023");
            client.EnableSsl = true;
            client.Credentials = credentials;
            try
            {
                var mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress("zpayautoma.disparos2023@outlook.com");
                mail.To.Add(new System.Net.Mail.MailAddress(emailToSend));

                mail.Subject = "PAYAUTO - USER REPORT";
                mail.IsBodyHtml = true;
                mail.Body = $"Olá, <br>O usuário {hostname}<br>Sob o ip: {ip} <br>Reportou algo. <br>Resumo: {summary} <br>Descrição: {description}";

                client.Send(mail);
                MessageBox.Show("E-mail enviado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        #endregion
    }
}
