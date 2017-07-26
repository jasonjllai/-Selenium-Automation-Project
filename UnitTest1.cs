using System;
using PageObjectDemo;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPageObjectDemo
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test10()
        {
            Pages.HomePage.Goto();
            //Pages.HomePage.ClickLogin();
            //Pages.LoginPage.Login("jl.lai@outlook.com", "");
            Pages.HomePage.ClickMotor();
            Pages.MotorPage.ClickSale();
            Pages.CarPage.ClickCar();
            Pages.CarPage.Search(3, 5, 7, "Leather seats");
            Browser.Close();


        }
    }
}
