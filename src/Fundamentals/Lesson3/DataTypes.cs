// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using Dumpify;
using System.Globalization;

namespace Fundamentals.Lesson3
{
    internal static class DataTypes
    {
        public static void UsingBuiltInDataTypes()
        {
            byte limitedNumber = 200;
            //limitedNumber = 3000; // results in error because it is out of range
            var maxByte = byte.MaxValue;
            var numberOfBytes = byte.PopCount(limitedNumber);

            ushort nonZeroNumber = 1;
            //nonZeroNumber = -200; // results in error because it is out of range
            var isEven = ushort.IsEvenInteger(nonZeroNumber);

            decimal currentBalance = 200320.434364m;
            currentBalance.Dump();
            var balanceScale = currentBalance.Scale;
            var roundedBalance = decimal.Round(currentBalance, 2);
            var balanceWithCurrency = currentBalance.ToString("C");
            var balanceWithBOBCurrency = currentBalance.ToString("C", new CultureInfo("es-BO"));
        }

        public static float CalculateBMI(float weight, float height)
        {
            // Calculate BMI using the formula: BMI = weight / (height * height)
            float bmi = weight / (height * height);

            return bmi;
        }

        public static void UsingDateTime()
        {
            var now = DateTime.Now;
            now.Dump();
            var utcnow = DateTime.UtcNow;
            var customDate = new DateTime(2023, 06, 05);
            var tommorrowDate = now.AddDays(1);
            var dayOfTheWeek = now.DayOfWeek;
            // You have different options if you want to retrieve the string of a date
            var dateString = now.ToShortDateString();
            var dateTimeString = now.ToLongDateString();
        }

        public static void UsingTimeSpan()
        {
            // Timespan is useful to size the time spend between two dates
            var timeBetween = DateTime.Now.Subtract(DateTime.Now.AddDays(1));
            
            var time = new TimeSpan(12, 30, 40);
            time.Dump();
            // You can also add a timespan to a DateTime
            var days = time.Days;
            var newTime = DateTime.Now.Add(time);
        }
    }
}
