﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace C_Sharp_HW19.PageObjects
{
    public class BestSellers : Footer
    {
        public BestSellers(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}