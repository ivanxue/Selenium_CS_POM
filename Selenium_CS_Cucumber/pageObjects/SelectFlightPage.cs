﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_CS_Cucumber.pageObjects
{
    public class SelectFlightPage
    {
        IWebDriver driver;

        [FindsBy(How = How.Name, Using = "reserveFlights")]
        public IWebElement reserveBtn { get; set; }

        public SelectFlightPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void reserveFlight()
        {
            reserveBtn.Click();
        }
    }
}