using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShellHacksBackend.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        protected string UserName { get; private set; }
        protected string UserPass { get; private set; }
        public double MonthlyIncome { get; set; }
        public double MonthlyDebt { get; set; }
        public double MonthlySpending { get; set; }
        public double MonthlySaveAndInv { get; set; }
        public double TotalIncome { get; set; }
        public double TotalSpending { get; set; }
        public double TotalDebt { get; set; }
        public double TotalSaveAndInv { get; set; }
        public UserModel( int userid, string username, string userpass, double monthlyincome, double monthlydebt, double monthlyspending,
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