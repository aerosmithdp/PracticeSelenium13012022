﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

// Natali nikulina

namespace C_Sharp_HW19.PageObjects
{
    public class BestSeller : Body
    {
        public BestSeller(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
