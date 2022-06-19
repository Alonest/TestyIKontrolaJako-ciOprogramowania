// NUnit 3 tests
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

namespace SeleniumCSharpDS
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Category("Smoke testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField=driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");
            IWebElement monthDropdownList=driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("Mar");
            element.SelectByValue("6");

        }


        [Test,Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");
        }

        [Test,Category("Smoke testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenum C#");
            Thread.Sleep(5000);
        }
    }
}
