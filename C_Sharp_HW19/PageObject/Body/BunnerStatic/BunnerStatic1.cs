﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace C_Sharp_HW19.PageObjects
{
    public class BunnerStatic1:Body
    {
        public BunnerStatic1(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
