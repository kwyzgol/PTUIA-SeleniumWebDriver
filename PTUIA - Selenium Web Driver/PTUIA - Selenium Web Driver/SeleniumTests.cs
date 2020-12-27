/* Automatyzacja testowania z Selenium Web Driver
 * PTUIA 2020/2021
 * 
 * Kamil Wyżgoł
 * Grupa ISI3
 */

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PTUIA
{
    [TestFixture]
    public class SeleniumTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup() //Wybranie przeglądarki Google Chrome
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void Clean() //zamknięcie przeglądarki
        {
            try
            {
                driver.Quit();
            }
            catch (Exception) {}
        }

        private string GetAlertText() //pobranie tekstu alertu i jego zamknięcie
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            return alertText;
        }

        [Test]
        public void Test00_AgeBelow() //Sprawdzenie wartości brzegowej, która uniemożliwia udział w zawodach
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2011");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Brak kwalifikacji", alertText);
        }

        [Test]
        public void Test01_LowerMlodzik() //Sprawdzenie dolnej wartości brzegowej grupy „Młodzik”
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test02_UpperMlodzik() //Sprawdzenie górnej wartości brzegowej grupy „Młodzik”
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2007");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test03_LowerJunior() //Sprawdzenie dolnej wartości brzegowej grupy „Junior”
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2006");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Junior", alertText);
        }

        [Test]
        public void Test04_UpperJunior() //Sprawdzenie górnej wartości brzegowej grupy „Junior”
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Junior", alertText);
        }

        [Test]
        public void Test05_LowerDorosly() //Sprawdzenie dolnej wartości brzegowej grupy „Dorosły”
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Dorosly", alertText);
        }

        [Test]
        public void Test06_UpperDorosly() //Sprawdzenie górnej wartości brzegowej grupy „Dorosły”
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1956");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Dorosly", alertText);
        }

        [Test]
        public void Test07_LowerSenior() //Sprawdzenie dolnej wartości brzegowej grupy „Senior”
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1955");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Senior", alertText);
        }

        [Test]
        public void Test08_LowerParentalConsent() //Sprawdzenie dolnej wartości brzegowej, kiedy wymagana jest zgoda rodziców lub opiekunów prawnych
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test09_UpperParentalConsent() //Sprawdzenie górnej wartości brzegowej, kiedy wymagana jest zgoda rodziców lub opiekunów prawnych
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test10_LowerUnderageMedical() //Sprawdzenie dolnej wartości brzegowej, kiedy wymagane jest zaświadczenie od lekarza o braku przeciwskazań (osoby niepełnoletnie)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test11_UpperUnderageMedical() //Sprawdzenie górnej wartości brzegowej, kiedy wymagane jest zaświadczenie od lekarza o braku przeciwskazań (osoby niepełnoletnie)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test12_LowerSeniorMedical() //Sprawdzenie wartości brzegowej, kiedy wymagane jest zaświadczenie od lekarza o braku przeciwskazań (seniorzy)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1955");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test13_AgeRounding() //Sprawdzenie zaokrąglania lat do pełnych roczników
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31.12.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test14_DataValidationDateText() //Walidacja wprowadzonych danych (ciąg znaków nie będący poprawną datą)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("kot");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test15_DataValidationJavaScript() //Walidacja wprowadzonych danych (kod javascript)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("<script type=\"text/javascript\">var tmp = 0;</script>");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertów
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();

            //sprawdzanie czy element <script> znalazł się na stronie
            By element = By.XPath("//div[@id='returnSt']/script");
            bool result;
            try
            {
                driver.FindElement(element);
                result = true;
            }
            catch(NoSuchElementException)
            {
                result = false;
            }

            Assert.IsFalse(result);
        }

        [Test]
        public void Test16_DataValidationHTML() //Walidacja wprowadzonych danych (kod html)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("<button>test</button>");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertów
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();

            //sprawdzanie czy element <button> znalazł się na stronie
            By element = By.XPath("//div[@id='returnSt']/button");
            bool result;
            try
            {
                driver.FindElement(element);
                result = true;
            }
            catch (NoSuchElementException)
            {
                result = false;
            }

            Assert.IsFalse(result);
        }

        [Test]
        public void Test17_DataValidationEmptyFName() //Walidacja wprowadzonych danych (puste imię)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            string alertText = GetAlertText();

            Assert.AreEqual("First name must be filled out", alertText);
        }

        [Test]
        public void Test18_DataValidationEmptyLName() //Walidacja wprowadzonych danych (puste nazwisko)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            string alertText = GetAlertText();

            Assert.AreEqual("Nazwisko musi byc wypelnione", alertText);
        }

        [Test]
        public void Test19_DataValidationEmptyDate() //Walidacja wprowadzonych danych (pusta data)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            string alertText = GetAlertText();

            Assert.AreEqual("Data urodzenia nie moze byc pusta", alertText);
        }

        [Test]
        public void Test20_DataValidationDateNegativeNumberMedical() //Walidacja wprowadzonych danych (liczba ujemna w polu daty oraz zaznaczone zaświadczenie od lekarza)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("-1");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test21_DataValidationDateNegativeNumber() //Walidacja wprowadzonych danych (liczba ujemna w polu daty)
        {
            //załadowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wypełnienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("-1");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominięcie alertu dot. różnicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }
    }
}
