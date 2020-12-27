/* Automatyzacja testowania z Selenium Web Driver
 * PTUIA 2020/2021
 * 
 * Kamil Wy¿go³
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
        public void Setup() //Wybranie przegl¹darki Google Chrome
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void Clean() //zamkniêcie przegl¹darki
        {
            try
            {
                driver.Quit();
            }
            catch (Exception) {}
        }

        private string GetAlertText() //pobranie tekstu alertu i jego zamkniêcie
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            return alertText;
        }

        [Test]
        public void Test00_AgeBelow() //Sprawdzenie wartoœci brzegowej, która uniemo¿liwia udzia³ w zawodach
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2011");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Brak kwalifikacji", alertText);
        }

        [Test]
        public void Test01_LowerMlodzik() //Sprawdzenie dolnej wartoœci brzegowej grupy „M³odzik”
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test02_UpperMlodzik() //Sprawdzenie górnej wartoœci brzegowej grupy „M³odzik”
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2007");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test03_LowerJunior() //Sprawdzenie dolnej wartoœci brzegowej grupy „Junior”
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2006");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Junior", alertText);
        }

        [Test]
        public void Test04_UpperJunior() //Sprawdzenie górnej wartoœci brzegowej grupy „Junior”
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Junior", alertText);
        }

        [Test]
        public void Test05_LowerDorosly() //Sprawdzenie dolnej wartoœci brzegowej grupy „Doros³y”
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Dorosly", alertText);
        }

        [Test]
        public void Test06_UpperDorosly() //Sprawdzenie górnej wartoœci brzegowej grupy „Doros³y”
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1956");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Dorosly", alertText);
        }

        [Test]
        public void Test07_LowerSenior() //Sprawdzenie dolnej wartoœci brzegowej grupy „Senior”
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1955");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Senior", alertText);
        }

        [Test]
        public void Test08_LowerParentalConsent() //Sprawdzenie dolnej wartoœci brzegowej, kiedy wymagana jest zgoda rodziców lub opiekunów prawnych
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test09_UpperParentalConsent() //Sprawdzenie górnej wartoœci brzegowej, kiedy wymagana jest zgoda rodziców lub opiekunów prawnych
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test10_LowerUnderageMedical() //Sprawdzenie dolnej wartoœci brzegowej, kiedy wymagane jest zaœwiadczenie od lekarza o braku przeciwskazañ (osoby niepe³noletnie)
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test11_UpperUnderageMedical() //Sprawdzenie górnej wartoœci brzegowej, kiedy wymagane jest zaœwiadczenie od lekarza o braku przeciwskazañ (osoby niepe³noletnie)
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test12_LowerSeniorMedical() //Sprawdzenie wartoœci brzegowej, kiedy wymagane jest zaœwiadczenie od lekarza o braku przeciwskazañ (seniorzy)
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1955");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test13_AgeRounding() //Sprawdzenie zaokr¹glania lat do pe³nych roczników
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31.12.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test14_DataValidationDateText() //Walidacja wprowadzonych danych (ci¹g znaków nie bêd¹cy poprawn¹ dat¹)
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("kot");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test15_DataValidationJavaScript() //Walidacja wprowadzonych danych (kod javascript)
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("<script type=\"text/javascript\">var tmp = 0;</script>");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertów
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();

            //sprawdzanie czy element <script> znalaz³ siê na stronie
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
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("<button>test</button>");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertów
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();

            //sprawdzanie czy element <button> znalaz³ siê na stronie
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
        public void Test17_DataValidationEmptyFName() //Walidacja wprowadzonych danych (puste imiê)
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
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
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
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
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            string alertText = GetAlertText();

            Assert.AreEqual("Data urodzenia nie moze byc pusta", alertText);
        }

        [Test]
        public void Test20_DataValidationDateNegativeNumberMedical() //Walidacja wprowadzonych danych (liczba ujemna w polu daty oraz zaznaczone zaœwiadczenie od lekarza)
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("-1");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test21_DataValidationDateNegativeNumber() //Walidacja wprowadzonych danych (liczba ujemna w polu daty)
        {
            //za³adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype³nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("-1");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pominiêcie alertu dot. ró¿nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }
    }
}