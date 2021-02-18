using NUnit.Framework;
using System.Threading;
using ScriptingToFramework.Pages;
using Framework.Selenium;
using static ScriptingToFramework.Pages.CareersLink;

namespace ScriptingToFramework.Test
{
    public class AutomationAssessmentTests
    {   
        [SetUp]
        public void BeforeEach()
        {
            Driver.Init();
            Driver.Current.Url = "https://www.ilabquality.com/";
        }

        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
        }

        [Test, Category("Ilab")]
        public void Ilab_SA_Job_Application()
        {
            var careers = new CareersLink(Driver.Current);
            var careersLinkMap = new CareersLinkMap(Driver.Current);
            //Validate before clicking.
            
            careers.GoTo();
            Thread.Sleep(2000);
            //Validate before clicking.
            careers.ClickIlabCareersLink();
            Thread.Sleep(2000);
            careers.FillApplicationForm();
            string s = careersLinkMap.ErrorText.Text;
            Assert.AreEqual(s, "You need to upload at least one file.");
        }
        
        [Test, Category("bank")]
        public void FirstCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionOne();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }

        [Test, Category("bank")]
        public void SecondCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionTwo();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }



        [Test, Category("bank")]
        public void ThirdCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionThree();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }

        [Test, Category("bank")]
        public void FourthCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionFour();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }

        [Test, Category("bank")]
        public void FifthCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionFive();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
            
        }

        [Test, Category("bank")]
        public void Customer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionOne();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("31459");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            yourName.Transactions();

            Thread.Sleep(2000);

            bank.DateTime();

            Thread.Sleep(5000);

            var Transact = bank.Map.TransactionDeposited.Text;

            Assert.AreEqual("31459", Transact);

            bank.Back();

            Thread.Sleep(2000);

            bank.Withdrawl();
            Thread.Sleep(2000);

            bank.Amount("31459");
            bank.FinaliseDeposit();
            Thread.Sleep(2000);
            bank.DepositSuccessful();

            Thread.Sleep(2000);
            var withdrawn = bank.Map.PaymentSuccessful.Text;
            Assert.AreEqual("Transaction successful", withdrawn);

            Thread.Sleep(2000);
            yourName.Transactions();
            Thread.Sleep(2000);
            bank.DateTime();

            Thread.Sleep(5000);

            var _Transact = bank.Map.TransactionDeposited.Text;

            Assert.AreEqual("31459", _Transact);
            bank.ApplicationLogout();
        }
    }
}