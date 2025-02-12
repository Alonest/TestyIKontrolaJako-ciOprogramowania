﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpDS.BaseClasss;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpDS.Utilities;

namespace SeleniumCSharpDS
{
    [TestFixture]
    public class ParallelTesting 
    {
        IWebDriver driver;
        [Test,Category("UAT Testing"),Category("Module1")]
        public void TestMethod1()
        {
            var Driver =new BrowserUtility().Init(driver);
            IWebElement emailTextField=Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }


        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }


        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");

            Driver.Close();
        }
    }
}
