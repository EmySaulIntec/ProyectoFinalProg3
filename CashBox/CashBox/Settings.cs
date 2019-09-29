using DatabaseProject.Models;
using System;

namespace CashBox
{

    public class CloseTime
    {
        public int InitHour { get; set; }
        public int InitMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }
    }

    public class CashBox
    {
        public bool CashIsOpen { get; set; }
        public double Amount { get; set; }
    }

    public static class Settings
    {
        public static User LoggedUser { get; set; } = new User();

        public static CloseTime GetCloseTime()
        {
            return new CloseTime()
            {
                EndHour = Properties.Settings.Default.EndHour,
                EndMinute = Properties.Settings.Default.EndMinute,
                InitHour = Properties.Settings.Default.InitHour,
                InitMinute = Properties.Settings.Default.InitMinute
            };
        }


        public static CashBox GetCashBox()
        {
            return new CashBox()
            {
                CashIsOpen = Properties.Settings.Default.CashIsOpen,
                Amount = Properties.Settings.Default.Amount,
            };
        }


        public static bool CanDoTransactions()
        {

            CloseTime closeTime = GetCloseTime();

            TimeSpan initTime = TimeSpan.FromHours(closeTime.InitHour).Add(TimeSpan.FromMinutes(closeTime.InitMinute));
            TimeSpan endTime = TimeSpan.FromHours(closeTime.EndHour).Add(TimeSpan.FromMinutes(closeTime.EndMinute));

            TimeSpan now = TimeSpan.FromHours(DateTime.Now.Hour).Add(TimeSpan.FromMinutes(DateTime.Now.Minute));

            return (initTime <= now && endTime >= now) && Properties.Settings.Default.CashIsOpen;
        }

        public static void AddToCash(double amount)
        {
            Properties.Settings.Default.Amount += amount;
        }

        public static bool SubstractToCash(double amount)
        {
            if (Properties.Settings.Default.Amount - amount < 0)
                return false;

            Properties.Settings.Default.Amount -= amount;

            return true;
        }
    }
}
