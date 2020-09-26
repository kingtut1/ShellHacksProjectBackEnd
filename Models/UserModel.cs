using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShellHacksBackend.Models
{
    using Newtonsoft.Json;
    public class UserModel
    {
        [JsonProperty(PropertyName = "userid")]
        public int UserId { get; set; }
        [JsonProperty(PropertyName = "username")]
        protected string UserName { get; private set; }
        [JsonProperty(PropertyName = "userpass")]
        protected string UserPass { get; private set; }
        [JsonProperty(PropertyName = "monthlyincome")]
        public double MonthlyIncome { get; set; }
        [JsonProperty(PropertyName = "monthlyincome")]
        public double MonthlyDebt { get; set; }
        [JsonProperty(PropertyName = "monthlyspending")]
        public double MonthlySpending { get; set; }
        [JsonProperty(PropertyName = "monthlySaveAndInv")]
        public double MonthlySaveAndInv { get; set; }
        [JsonProperty(PropertyName = "totalincome")]
        public double TotalIncome { get; set; }
        [JsonProperty(PropertyName = "totalspending")]
        public double TotalSpending { get; set; }
        [JsonProperty(PropertyName = "totaldebt")]
        public double TotalDebt { get; set; }
        [JsonProperty(PropertyName = "totalSaveAndInv")]
        public double TotalSaveAndInv { get; set; }
        public UserModel(int userid, string username, string userpass, double monthlyincome, double monthlydebt, double monthlyspending,
            double monthlySaveAndInv, double totalincome, double totalspending, double totaldebt, double totalsaveandinv)
        {
            // user related info
            UserId = userid;
            UserName = username;
            UserPass = userpass;

            //monthy information
            MonthlyIncome = monthlyincome;
            MonthlyDebt = monthlydebt;
            MonthlySpending = monthlyspending;
            MonthlySaveAndInv = monthlySaveAndInv;

            //total information
            TotalIncome = totalincome;
            TotalSpending = totalspending;
            TotalDebt = totaldebt;
            TotalSaveAndInv = totalsaveandinv;
        }
    }
}