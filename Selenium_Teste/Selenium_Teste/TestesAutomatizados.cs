using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Selenium_Teste
{
    public class TestesAutomatizados
    {
        public void Busca()
        {
            BuscaIE();
            //BuscaChrome();
            //BuscaFirefox();
        }

        private void BuscaFirefox()
        {
            try
            {
                //var fo = new FirefoxOptions();
                //var proxy = new Proxy();
                //proxy.Kind = ProxyKind.Manual;
                //proxy.HttpProxy = "172.17.1.3:3128";


                //FirefoxProfile fp = new FirefoxProfile();
                //fp.SetProxyPreferences(proxy);

                //fo.Profile = fp;

                IWebDriver driver = new FirefoxDriver();

                driver.Navigate().GoToUrl("www.google.com");

                IWebElement campoTexto = driver.FindElement(By.Name("q"));

                campoTexto.SendKeys("Globo");

                campoTexto.Submit();

                //driver.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BuscaChrome()
        {
            try
            {
                //var co = new ChromeOptions();
                //var proxy = new Proxy();
                //proxy.Kind = ProxyKind.Manual;
                //proxy.HttpProxy = "172.17.1.3:3128";
                //co.Proxy = proxy;

                var driver = new ChromeDriver();

                driver.Navigate().GoToUrl("www.google.com.br");

                IWebElement campo = driver.FindElement(By.Name("q"));

                campo.SendKeys("Globo");

                campo.Submit();

                //driver.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BuscaIE()
        {
            try
            {
                var driver = new InternetExplorerDriver();

                driver.Navigate().GoToUrl("www.google.com.br");

                IWebElement campo = driver.FindElement(By.Name("q"));

                campo.SendKeys("Globo");

                campo.Submit();

                //driver.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
