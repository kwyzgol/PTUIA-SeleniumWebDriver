/* Automatyzacja testowania z Selenium Web Driver
 * PTUIA 2020/2021
 * 
 * Kamil Wy�go�
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
        public void Setup() //Wybranie przegl�darki Google Chrome
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void Clean() //zamkni�cie przegl�darki
        {
            try
            {
                driver.Quit();
            }
            catch (Exception) {}
        }

        private string GetAlertText() //pobranie tekstu alertu i jego zamkni�cie
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            return alertText;
        }

        [Test]
        public void Test00_AgeBelow() //Sprawdzenie warto�ci brzegowej, kt�ra uniemo�liwia udzia� w zawodach
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2011");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Brak kwalifikacji", alertText);
        }

        [Test]
        public void Test01_LowerMlodzik() //Sprawdzenie dolnej warto�ci brzegowej grupy �M�odzik�
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test02_UpperMlodzik() //Sprawdzenie g�rnej warto�ci brzegowej grupy �M�odzik�
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2007");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test03_LowerJunior() //Sprawdzenie dolnej warto�ci brzegowej grupy �Junior�
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2006");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Junior", alertText);
        }

        [Test]
        public void Test04_UpperJunior() //Sprawdzenie g�rnej warto�ci brzegowej grupy �Junior�
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Junior", alertText);
        }

        [Test]
        public void Test05_LowerDorosly() //Sprawdzenie dolnej warto�ci brzegowej grupy �Doros�y�
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Dorosly", alertText);
        }

        [Test]
        public void Test06_UpperDorosly() //Sprawdzenie g�rnej warto�ci brzegowej grupy �Doros�y�
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1956");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Dorosly", alertText);
        }

        [Test]
        public void Test07_LowerSenior() //Sprawdzenie dolnej warto�ci brzegowej grupy �Senior�
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1955");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Senior", alertText);
        }

        [Test]
        public void Test08_LowerParentalConsent() //Sprawdzenie dolnej warto�ci brzegowej, kiedy wymagana jest zgoda rodzic�w lub opiekun�w prawnych
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test09_UpperParentalConsent() //Sprawdzenie g�rnej warto�ci brzegowej, kiedy wymagana jest zgoda rodzic�w lub opiekun�w prawnych
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test10_LowerUnderageMedical() //Sprawdzenie dolnej warto�ci brzegowej, kiedy wymagane jest za�wiadczenie od lekarza o braku przeciwskaza� (osoby niepe�noletnie)
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test11_UpperUnderageMedical() //Sprawdzenie g�rnej warto�ci brzegowej, kiedy wymagane jest za�wiadczenie od lekarza o braku przeciwskaza� (osoby niepe�noletnie)
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2003");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test12_LowerSeniorMedical() //Sprawdzenie warto�ci brzegowej, kiedy wymagane jest za�wiadczenie od lekarza o braku przeciwskaza� (seniorzy)
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.1955");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test13_AgeRounding() //Sprawdzenie zaokr�glania lat do pe�nych rocznik�w
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31.12.2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Mlodzik", alertText);
        }

        [Test]
        public void Test14_DataValidationDateText() //Walidacja wprowadzonych danych (ci�g znak�w nie b�d�cy poprawn� dat�)
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("kot");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test15_DataValidationJavaScript() //Walidacja wprowadzonych danych (kod javascript)
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("<script type=\"text/javascript\">var tmp = 0;</script>");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alert�w
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();

            //sprawdzanie czy element <script> znalaz� si� na stronie
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
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("<button>test</button>");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01.01.2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alert�w
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();

            //sprawdzanie czy element <button> znalaz� si� na stronie
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
        public void Test17_DataValidationEmptyFName() //Walidacja wprowadzonych danych (puste imi�)
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
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
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
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
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            string alertText = GetAlertText();

            Assert.AreEqual("Data urodzenia nie moze byc pusta", alertText);
        }

        [Test]
        public void Test20_DataValidationDateNegativeNumberMedical() //Walidacja wprowadzonych danych (liczba ujemna w polu daty oraz zaznaczone za�wiadczenie od lekarza)
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("-1");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }

        [Test]
        public void Test21_DataValidationDateNegativeNumber() //Walidacja wprowadzonych danych (liczba ujemna w polu daty)
        {
            //za�adowanie strony internetowej o podanym adresie URL
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");

            //wype�nienie formularza
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("-1");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //pomini�cie alertu dot. r�nicy
            driver.SwitchTo().Alert().Accept();

            string alertText = GetAlertText();

            Assert.AreEqual("Blad danych", alertText);
        }
    }
}