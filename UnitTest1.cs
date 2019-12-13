using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;
using NUnit.Framework;
using Docker.DotNet.Models;

namespace CSharpJessica
{
    [TestClass]
    // Desafio 1: NUnit (Assert.AreEqual / Assert.IsTrue/ Assert.IsFalse)
    public class UnitTest1
    {
        IWebDriver driver;
        WebDriverWait wait;

        [Test]
        //Verfica se o carro é sandero 
        public void NUnit_VerificaStringCarro()
        {
            string carro = "sandero";
            Assert.IsTrue(carro.Equals("sandero"));
        }

        [Test]
        //Verfica se a cidade é diferente de Contagem
        public void NUnit_VerificaStringCidade()
        {
            string cidade = "Contagem";
            Assert.IsFalse(cidade.Equals("Belo Horizonte"));
        }

        [Test]
        //Verfica se o nome é igual à Celeste
        public void NUnit_VerificaStringNome()
        {
            string nome = "Celeste";
            Assert.AreEqual("Celeste", nome);
        }

        // Desafio 2: Ações de Navegação - Interagindo com Sites
        [Test]
        public void NavegacaoGoogle_1()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://www.google.com.br"); // Teste de navegação até o site Google.
            string titleGoogle = driver.Title;
            Assert.AreEqual("Google", titleGoogle); // Verifica se realmente esta na página do Google.
            driver.Close();               
        }

        [Test]
        public void NavegacaoGoogle_2()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://www.google.com.br"); 
            string link = driver.Url;
            Assert.IsTrue(condition: link.Equals("https://www.google.com.br/")); // Verifica se o Link é realmente do Google.
            driver.Close();
        }

        // Desafio 3: Localizando e interagindo com elementos de Sites
        [Test]
        public void Pesquisa_Google()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com.br");

            driver.FindElement(By.Name("P")).SendKeys("teste");

        }



    
}