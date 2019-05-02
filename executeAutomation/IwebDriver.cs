using System;
using OpenQA.Selenium.Chrome;

namespace executeAutomation
{
    internal class IwebDriver
    {
        public static implicit operator IwebDriver(ChromeDriver v)
        {
            throw new NotImplementedException();
        }
    }
}