using mg.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ng.api.Controllers
{
    public class NavigatorController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }


        public IEnumerable<FNavigatorModel> GetNavigator()
        {
            return navs;
        }

        /// <summary>
        /// 默认一些链接
        /// </summary>
        private static List<FNavigatorModel> navs = new List<FNavigatorModel>()
        {
            new FNavigatorModel() {FNameKey = "Dashboard",FClassName = "mg-nav-dashboard", FUrl = "",MChildren = new List<FNavigatorModel>() {
                new FNavigatorModel() {FNameKey = "Dashboard",FUrl="./go/go.dashboard" }
            } },

             new FNavigatorModel() {FNameKey = "NavAccount",FClassName = "mg-nav-account", FUrl = "",MChildren = new List<FNavigatorModel>() {
                new FNavigatorModel() {FNameKey = "BankAccount",FUrl="./go/go.bankaccount" },
                new FNavigatorModel() {FNameKey = "InvoiceSale",FUrl="./go/go.invoicesale" },
                new FNavigatorModel() {FNameKey = "InvoicePurchase",FUrl="./go/go.invoicepurchase" },
                new FNavigatorModel() {FNameKey = "Expense",FUrl="./go/go.expense" },
                new FNavigatorModel() {FNameKey = "Salaray",FUrl="./go/go.salary" },
                new FNavigatorModel() {FNameKey = "GeneralLedger",FUrl="./go/go.generalledger" },
                new FNavigatorModel() {FNameKey = "InvoiceFapiao",FUrl="./go/go.invoicefapiao" },
                new FNavigatorModel() {FNameKey = "PurchaseFapiao",FUrl="./go/go.purchasefapiao" },
                new FNavigatorModel() {FNameKey = "FixAssets",FUrl="./go/go.fixassets" },
            } },

            new FNavigatorModel() {FNameKey = "NavReport",FClassName = "mg-nav-report", FUrl = "",MChildren = new List<FNavigatorModel>() {
                new FNavigatorModel() {FNameKey = "AllReport",FUrl="./go/go.allreport" },
                new FNavigatorModel() {FNameKey = "AgedReceivables",FUrl="./go/go.AgedReceivables" },
                new FNavigatorModel() {FNameKey = "AgedPayables",FUrl="./go/go.AgedPayables" },
                new FNavigatorModel() {FNameKey = "BankAndCashSummary",FUrl="./go/go.BankAndCashSummary" },
                new FNavigatorModel() {FNameKey = "ExpenseClaimsReport",FUrl="./go/go.ExpenseClaimsReport" },
                new FNavigatorModel() {FNameKey = "GeneralLedger",FUrl="./go/go.GeneralLedger" },
                new FNavigatorModel() {FNameKey = "TrialBalanceReport",FUrl="./go/go.TrialBalanceReport" },
                new FNavigatorModel() {FNameKey = "IncomeStatement",FUrl="./go/go.IncomeStatement" },
                new FNavigatorModel() {FNameKey = "BalanceSheet",FUrl="./go/go.BalanceSheet" },
                new FNavigatorModel() {FNameKey = "CashFlowStatement",FUrl="./go/go.CashFlowStatement" },
            } },

             new FNavigatorModel() {FNameKey = "NavFolder",FClassName = "mg-nav-folder", FUrl = "",MChildren = new List<FNavigatorModel>() {
                new FNavigatorModel() {FNameKey = "AllContacts",FUrl="./go/go.allcontacts" },
                new FNavigatorModel() {FNameKey = "Customers",FUrl="./go/go.customers" },
                new FNavigatorModel() {FNameKey = "Suppliers",FUrl="./go/go.suppliers" },
                new FNavigatorModel() {FNameKey = "Other",FUrl="./go/go.other" },
                new FNavigatorModel() {FNameKey = "Employees",FUrl="./go/go.employees" },
             }},

             new FNavigatorModel() {FNameKey = "NavSetting",FClassName = "mg-nav-setting", FUrl = "",MChildren = new List<FNavigatorModel>() {
                  new FNavigatorModel() {FNameKey = "BasicSetting",MChildren = new List<FNavigatorModel>() {
                        new FNavigatorModel() {FNameKey = "OrganisationSettings",FUrl="./go/go.allreport" },
                        new FNavigatorModel() {FNameKey = "GlobalizationSettings",FUrl="./go/go.AgedReceivables" },
                        new FNavigatorModel() {FNameKey = "FinancialSettings",FUrl="./go/go.AgedPayables" },
                        new FNavigatorModel() {FNameKey = "InitialAmountOfBankAccount",FUrl="./go/go.BankAndCashSummary" },
                        new FNavigatorModel() {FNameKey = "TaxRate",FUrl="./go/go.ExpenseClaimsReport" },
                        new FNavigatorModel() {FNameKey = "Currency",FUrl="./go/go.GeneralLedger" },
                        new FNavigatorModel() {FNameKey = "InventoryItems",FUrl="./go/go.TrialBalanceReport" },
                        new FNavigatorModel() {FNameKey = "ExpenseItems",FUrl="./go/go.IncomeStatement" },
                        new FNavigatorModel() {FNameKey = "SalaryComponent",FUrl="./go/go.BalanceSheet" },
                        new FNavigatorModel() {FNameKey = "Tracking",FUrl="./go/go.CashFlowStatement" },
                        new FNavigatorModel() {FNameKey = "FastCodeManagement",FUrl="./go/go.BalanceSheet" },
                        new FNavigatorModel() {FNameKey = "Import",FUrl="./go/go.CashFlowStatement" },
                  } },

                  new FNavigatorModel() {FNameKey = "AdvanceSetting",MChildren = new List<FNavigatorModel>() {
                        new FNavigatorModel() {FNameKey = "Users",FUrl="./go/go.allreport" },
                        new FNavigatorModel() {FNameKey = "PrintSetting",FUrl="./go/go.AgedReceivables" },
                        new FNavigatorModel() {FNameKey = "CompanyPayroll",FUrl="./go/go.AgedPayables" },
                        new FNavigatorModel() {FNameKey = "OneKeyExport",FUrl="./go/go.BankAndCashSummary" },
                        new FNavigatorModel() {FNameKey = "ExcelPlugInDownload",FUrl="./go/go.ExpenseClaimsReport" },
                  } },

                   new FNavigatorModel() {FNameKey = "GeneralLedgerSetting",MChildren = new List<FNavigatorModel>() {
                        new FNavigatorModel() {FNameKey = "General Ledger Basic Info",FUrl="./go/go.allreport" },
                        new FNavigatorModel() {FNameKey = "Account",FUrl="./go/go.AgedReceivables" },
                        new FNavigatorModel() {FNameKey = "OpeningBalances",FUrl="./go/go.AgedPayables" },
                        new FNavigatorModel() {FNameKey = "AccountDocumentInitialization",FUrl="./go/go.BankAndCashSummary" },
                  } },

             } }
        };
    }
}