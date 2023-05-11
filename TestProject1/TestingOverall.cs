using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestProject1
{
    internal class TestingOverall
    {
        [Test]
        public void SimpleTest()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("Register")).Click();
            driver.Quit();


        }
        [Test]
        public void AddToCart()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("AddToCart")).Click();
            driver.Quit();


        }
       /* [Test]
        public void Login()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/Account/Login");
            driver.FindElement(By.Id("Name")).SendKeys("Harshitha");
            
           
            driver.Quit();


        }*/
        [Test]
        public void AddToCartFunctionRemove()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/Cart");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("ContinueShopping")).Click();
            driver.Quit();


        }
        [Test]
        public void ViewDetails()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/Product");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("ViewDetails")).Click();
            driver.Quit();


        }
        [Test]
        public void Login()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("Login")).Click();
            driver.Quit();


        }
        [Test]
        public void Logout()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/Account");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("Logout")).Click();
            driver.Quit();


        }

        [Test]
        public void Home()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("Home")).Click();
            driver.Quit();


        }
        [Test]
        public void Privacy()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("http://localhost:5093/");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("Privacy")).Click();
            driver.Quit();


        }
    }
}
