using DatabaseProject.Models;
using System;

namespace CashBox
{
    public class SettingCloseTime
    {
        public int InitHour { get; set; }
        public int InitMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }
    }

    public static class Settings
    {
        public static User LoggedUser { get; set; } = new User();

        public static SettingCloseTime GetCloseTime()
        {
            return new SettingCloseTime()
            {
                EndHour = Properties.Settings.Default.EndHour,
                EndMinute = Properties.Settings.Default.EndMinute,
                InitHour = Properties.Settings.Default.InitHour,
                InitMinute = Properties.Settings.Default.InitMinute
            };
        }

        public static bool CanDoTransactions()
        {

            SettingCloseTime closeTime = GetCloseTime();

            TimeSpan initTime = TimeSpan.FromHours(closeTime.InitHour).Add(TimeSpan.FromMinutes(closeTime.InitMinute));
            TimeSpan endTime = TimeSpan.FromHours(closeTime.EndHour).Add(TimeSpan.FromMinutes(closeTime.EndMinute));

            TimeSpan now = TimeSpan.FromHours(DateTime.Now.Hour).Add(TimeSpan.FromMinutes(DateTime.Now.Minute));

            return (initTime <= now && endTime >= now) && Properties.Settings.Default.CashIsOpen;
        }

      
      
    }
}
