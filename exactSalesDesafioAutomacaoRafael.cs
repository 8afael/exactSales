using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI; 

namespace TesteExactSales
{
    [TestClass]
    public class Register
    {
        [TestMethod]
        public void testRegister()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
                driver.FindElement(By.XPath("//input[@type='text']")).Click();
                driver.FindElement(By.XPath("//input[@type='text']")).Clear();
                driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Rafael");
                driver.FindElement(By.XPath("(//input[@type='text'])[2]")).Clear();
                driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys("Rodrigues");
                driver.FindElement(By.XPath("//form[@id='basicBootstrapForm']/div[2]/div/textarea")).Clear();
                driver.FindElement(By.XPath("//form[@id='basicBootstrapForm']/div[2]/div/textarea")).SendKeys("rua teste");
                driver.FindElement(By.XPath("//input[@type='email']")).Clear();
                driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("testemai2l@email.com.br");
                driver.FindElement(By.XPath("//input[@type='tel']")).Clear();
                driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys("5119343542");
                driver.FindElement(By.Name("radiooptions")).Click();
                driver.FindElement(By.Id("checkbox1")).Click();
                driver.FindElement(By.Id("checkbox3")).Click();
                driver.FindElement(By.Id("msdd")).Click();
                driver.FindElement(By.Id("msdd")).Click();
                driver.FindElement(By.Id("msdd")).Click();
                driver.FindElement(By.Id("msdd")).Click();
                driver.FindElement(By.Id("msdd")).Click();
                driver.FindElement(By.Id("msdd")).Click();
                new SelectElement(driver.FindElement(By.Id("countries"))).SelectByText("Australia");
                driver.FindElement(By.XPath("//option[@value='Australia']")).Click();
                driver.FindElement(By.XPath("//form[@id='basicBootstrapForm']/div[10]/div/span/span/span/span[2]")).Click();
                driver.FindElement(By.Id("yearbox")).Click();
                new SelectElement(driver.FindElement(By.Id("yearbox"))).SelectByText("1974");
                driver.FindElement(By.XPath("//option[@value='1974']")).Click();
                driver.FindElement(By.XPath("(//select[@type='text'])[4]")).Click();
                new SelectElement(driver.FindElement(By.XPath("(//select[@type='text'])[4]"))).SelectByText("May");
                driver.FindElement(By.XPath("//option[@value='May']")).Click();
                driver.FindElement(By.Id("daybox")).Click();
                new SelectElement(driver.FindElement(By.Id("daybox"))).SelectByText("12");
                driver.FindElement(By.XPath("//option[@value='12']")).Click();
                driver.FindElement(By.Id("firstpassword")).Click();
                driver.FindElement(By.Id("firstpassword")).SendKeys("3mh0X875");
                driver.FindElement(By.Id("secondpassword")).Click();
                driver.FindElement(By.Id("secondpassword")).SendKeys("3mh0X875");
                //driver.FindElement(By.Id("basicBootstrapForm")).Click();
                driver.FindElement(By.Id("submitbtn")).Click();
            }
        }
    }
}