using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaTran.Models.Selenium
{
    public class Firefox : WebBrowserBase
    {
        public Firefox(InterfaceType @InterfaceType, bool isAdministrator = true, string downloadPath = "")
        {
                if (isAdministrator)
                    foreach (var process in Process.GetProcessesByName("Firefox").Union(Process.GetProcessesByName("geckodriver")).ToList())
                        if (process.HasExited == false)
                            process.Kill();

                var optionsFF = new FirefoxOptions();
                optionsFF.Profile = new FirefoxProfile();
                var driverService = FirefoxDriverService.CreateDefaultService();

                if (@InterfaceType == InterfaceType.NoUserInterface)
                {
                    optionsFF.AddArgument("--headless");
                    driverService.HideCommandPromptWindow = true;
                }

                if (@InterfaceType == InterfaceType.OnlyBrowser)
                    driverService.HideCommandPromptWindow = true;

                if (!string.IsNullOrEmpty(downloadPath))
                {
                    DownloadPath = downloadPath;

                    // Permitir download sem pop-up de confirmação
                    optionsFF.Profile.SetPreference("browser.helperApps.alwaysAsk.force", false);
                    optionsFF.Profile.SetPreference("browser.helperApps.neverAsk.openFile", "application/download");
                    optionsFF.Profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/download");

                    // Configurar caminho de destino de download
                    optionsFF.Profile.SetPreference("browser.download.folderList", 2);
                    optionsFF.Profile.SetPreference("browser.download.dir", downloadPath);
                }

                optionsFF.Profile.SetPreference("general.useragent.override", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.104 Safari/537.36");
                Driver = new FirefoxDriver(driverService, optionsFF, TimeSpan.FromSeconds(200));
        }

        public void CopiaArquivos(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
                CopiaArquivos(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles())
                file.CopyTo(Path.Combine(target.FullName, file.Name));
        }
    }
}
