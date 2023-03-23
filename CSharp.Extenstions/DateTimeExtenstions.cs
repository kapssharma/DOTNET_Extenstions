using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Extenstions
{
    public static class DateTimeExtenstions
    {
        /// <summary>
        ///     A DateTime extension method that return First Date Of Month.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>return a DateTime object</returns>
        public static DateTime FirstDateOfMonth(this DateTime @this)
        {
            return @this.AddDays((-1) * @this.Day + 1);
        }

        /// <summary>
        ///     A DateTime extension method that return Last Date Of Month.
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object</returns>
        public static DateTime LastDateOfMonth(this DateTime @this)
        {
            return @this.AddMonths(1).FirstDateOfMonth().AddDays(-1);
        }

        /// <summary>
        ///    A DateTime extension method that return Dates between two dates.
        /// </summary>
        /// <param name="@fromDate"></param>
        /// <param name="@toDate"></param>
        /// <returns></returns>
        public static DateTime[] DatesArray(this DateTime @fromDate, DateTime @toDate)
        {
            int days = (@toDate - @fromDate).Days;
            var dates = new DateTime[days];

            for (int i = 0; i < days; i++)
            {
                dates[i] = fromDate.AddDays(i);
            }

            return dates;
        }

        /// <summary>
        ///    A DateTime extension method that return Calendar Month Dates Array.
        /// </summary>
        /// <param name="@fromDate"></param>
        /// <param name="@toDate"></param>
        /// <returns></returns>
        /// 
        public static DateTime[] CalendarMonthDatesArray(this DateTime @this)
        {
            var first = @this.FirstDateOfMonth();
            var firstWeekDay = (int)first.DayOfWeek;
            if (firstWeekDay == 0)
                firstWeekDay = 7;

            var from = first.AddDays((int)DayOfWeek.Monday - firstWeekDay);
            var last = @this.LastDateOfMonth();
            var lastWeekDay = (int)last.DayOfWeek;
            if (lastWeekDay == 0)
                lastWeekDay = 7;

            var thru = last.AddDays(lastWeekDay - (int)DayOfWeek.Monday + 1);
            return from.DatesArray(thru);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyy(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy HH:mm
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 23:25
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyHHmm(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy HH:mm", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy hh:mm
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 11:25
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyhhmm(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy hh:mm", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy HH:mm:ss
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 23:25:10
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyHHmmss(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy HH:mm:ss", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy hh:mm:ss
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 11:25:10
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyhhmmss(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy hh:mm:ss", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy HH:mm tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 23:25 PM
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyHHmmtt(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy HH:mm tt", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy HH:mm t
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 23:25 P
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyHHmmt(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy HH:mm t", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy hh:mm t
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 11:25 P
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyhhmmt(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy hh:mm t", separator, separator1);
            return @this.ToString(format);
        }


        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy HH:mm:ss tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 23:25:12 PM
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyHHmmsstt(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy HH:mm:ss tt", separator, separator1);
            return @this.ToString(format);
        }


        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy HH:mm:ss tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 23:25:12 P
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyHHmmsst(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy HH:mm:ss t", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy hh:mm:ss tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 11:25:12 PM
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyhhmmsstt(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy hh:mm:ss tt", separator, separator1);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be dddd, dd MMMM yyyy hh:mm:ss t
        /// </code>
        /// <code>
        /// param1 (separator) default value is comma and param2 (separate1) default value is empty space.
        /// </code>
        /// e.g Thursday, 23 March 2023 11:25:12 P
        /// </example>
        /// </summary>
        public static string ToStringdddd_ddMMMMyyyyhhmmsst(this DateTime @this, string separator = ",", string separator1 = " ")
        {
            var format = string.Format("dddd{0} dd{1}MMMM{1}yyyy hh:mm:ss t", separator, separator1);
            return @this.ToString(format);
        }

        // Month day and Year.

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyy(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy", separator);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy HH:mm
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHHmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy HH:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy hh:mm
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhhmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy hh:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy HH:mm tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25 PM
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHHmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy HH:mm tt", separator);
            return @this.ToString(format);
        }


        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy hh:mm tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25 PM
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhhmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy hh:mm tt", separator);
            return @this.ToString(format);
        }


        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy HH:mm:ss tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25:12 PM
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHHmmsstt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy HH:mm:ss tt", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy hh:mm:ss tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25:12 PM
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhhmmsstt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy hh:mm:ss tt", separator);
            return @this.ToString(format);
        }


        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy HH:mm:ss t
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25 P
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHHmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy HH:mm t", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy hh:mm:ss t
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25 P
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhhmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy hh:mm t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy HH:mm:ss tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25:12 PM
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHHmmsst(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy HH:mm:ss t", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy hh:mm:ss t
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25:12 P
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhhmmsst(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy hh:mm:ss t", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy H:mm
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy H:mm", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy h:mm
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy h:mm", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy H:mm tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25 PM
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy H:mm tt", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy h:mm tt
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25 PM
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy h:mm tt", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy H:mm t
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25 P
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy H:mm t", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy h:mm t
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25 P
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy h:mm t", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy HH:mm:ss
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25:12
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHHmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy HH:mm:ss", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy hh:mm:ss
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25:12
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhhmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy hh:mm:ss", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy H:mm:ss
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 23:25:12
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyHmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy H:mm:ss", separator);
            return @this.ToString(format);
        }

        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MM/dd/yyyy h:mm:ss
        /// </code>
        /// <code>
        /// param1 (separator) default value is '/' 
        /// </code>
        /// e.g 03/23/2023 11:25:12
        /// </example>
        /// </summary>
        public static string ToStringMMddyyyyhmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy h:mm:ss", separator);
            return @this.ToString(format);
        }


        // Day and Month year

        /// <summary>
        ///     A DateTime extension method that return as string
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format dd/MM/yyyy</returns>
        public static string ToStringddMMyyyy(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 29/05/2023</returns>
        public static string ToStringddMMyyyyHHmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy HH:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 29/05/2023 05:50</returns>
        public static string ToStringddMMyyyyhhmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy hh:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29/May/2023 05:50 AM</returns>
        public static string ToStringddMMyyyyHHmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy HH:mm tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhhmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy hh:mm tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, </returns>
        public static string ToStringddMMyyyyHHmmsstt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy HH:mm:ss tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhhmmsstt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy hh:mm:ss tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyHHmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy HH:mm t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhhmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy hh:mm t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyHHmmsst(this DateTime @this, string separator = "/")
        {
            var format = string.Format("MM{0}dd{0}yyyy HH:mm:ss t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhhmmsst(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy hh:mm:ss t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy H:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyHmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy H:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format dd/MM/yyyy H:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy h:mm", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd/MM/yyyy H:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyHmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy H:mm tt", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd/MM/yyyy h:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy h:mm tt", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd/MM/yyyy H:mm t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyHmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy H:mm t", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd/MM/yyyy h:mm t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy h:mm t", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyHHmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy HH:mm:ss", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhhmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy hh:mm:ss", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyHmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy H:mm:ss", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd/MM/yyyy HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringddMMyyyyhmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("dd{0}MM{0}yyyy h:mm:ss", separator);
            return @this.ToString(format);
        }


        // Year  Month and day   

        /// <summary>
        ///     A DateTime extension method that return as string
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format yyyy/MM/dd</returns>
        public static string ToStringyyyyMMdd(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHHmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd HH:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhhmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd hh:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHHmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd HH:mm tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhhmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd hh:mm tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHHmmsstt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd HH:mm:ss tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhhmmsstt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd hh:mm:ss tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHHmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd HH:mm t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhhmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd hh:mm t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHHmmsst(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd HH:mm:ss t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhhmmsst(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd hh:mm:ss t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd H:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd H:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd H:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhmm(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd h:mm", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd H:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd H:mm tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd h:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhmmtt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd h:mm tt", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd H:mm t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd H:mm t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd h:mm t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhmmt(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd h:mm t", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHHmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd HH:mm:ss", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhhmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd hh:mm:ss", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddHmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd H:mm:ss", separator);
            return @this.ToString(format);
        }

        /// <summary>
        ///     A DateTime extension method that return as string format yyyy/MM/dd HH:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Friday, 29 May 2023 05:50 AM</returns>
        public static string ToStringyyyyMMddhmmss(this DateTime @this, string separator = "/")
        {
            var format = string.Format("yyyy{0}MM{0}dd h:mm:ss", separator);
            return @this.ToString(format);
        }


        // month and da
        ///     A DateTime extension method that return as string format MMMM dd
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format May 21</returns>
        public static string ToStringMMMMdd(this DateTime @this, string separator = " ")
        {
            var format = string.Format("MMMM{0}dd", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format dd MMMM 
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 21 May</returns>
        public static string ToStringddMMMM(this DateTime @this, string separator = " ")
        {
            var format = string.Format("dd{0}MMMM", separator);
            return @this.ToString(format);
        }

        // Hour and mins

        ///     A DateTime extension method that return as string format HH:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50</returns>
        public static string ToStringHHmm(this DateTime @this)
        {
            var format = string.Format("HH:mm");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format hh:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50</returns>
        public static string ToStringhhmm(this DateTime @this)
        {
            var format = string.Format("hh:mm");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format HH:mm:ss
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHHmmss(this DateTime @this)
        {
            var format = string.Format("HH:mm:ss");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format hh:mm:ss
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhhmmss(this DateTime @this)
        {
            var format = string.Format("hh:mm:ss");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format HH:mm:tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHHmmtt(this DateTime @this)
        {
            var format = string.Format("HH:mm tt");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format hh:mm:tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhhmmtt(this DateTime @this)
        {
            var format = string.Format("hh:mm tt");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format HH:mm:tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHHmmsstt(this DateTime @this)
        {
            var format = string.Format("HH:mm:ss tt");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format hh:mm:tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhhmmsstt(this DateTime @this)
        {
            var format = string.Format("hh:mm:ss tt");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format HH:mm:tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHHmmt(this DateTime @this)
        {
            var format = string.Format("HH:mm t");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format hh:mm:tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhhmmt(this DateTime @this)
        {
            var format = string.Format("hh:mm t");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format HH:mm:tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHHmmsst(this DateTime @this)
        {
            var format = string.Format("HH:mm:ss t");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format hh:mm:tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhhmmsst(this DateTime @this)
        {
            var format = string.Format("hh:mm:ss t");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format H:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 5:50</returns>
        public static string ToStringHmm(this DateTime @this)
        {
            var format = string.Format("H:mm");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format h:mm
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 5:50</returns>
        public static string ToStringhmm(this DateTime @this)
        {
            var format = string.Format("h:mm");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format H:mm:ss
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHmmss(this DateTime @this)
        {
            var format = string.Format("H:mm:ss");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format h:mm:ss
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhmmss(this DateTime @this)
        {
            var format = string.Format("h:mm:ss");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format H:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHmmtt(this DateTime @this)
        {
            var format = string.Format("H:mm tt");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format h:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhmmtt(this DateTime @this)
        {
            var format = string.Format("h:mm tt");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format H:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHmmsstt(this DateTime @this)
        {
            var format = string.Format("H:mm:ss tt");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format h:mm:ss tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhmmsstt(this DateTime @this)
        {
            var format = string.Format("h:mm:ss tt");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format H:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHmmt(this DateTime @this)
        {
            var format = string.Format("HH:mm t");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format h:mm tt
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhmmt(this DateTime @this)
        {
            var format = string.Format("h:mm t");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format H:mm:ss t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:21</returns>
        public static string ToStringHmmsst(this DateTime @this)
        {
            var format = string.Format("H:mm:ss t");
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format h:mm:ss t
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 05:50:20</returns>
        public static string ToStringhmmsst(this DateTime @this)
        {
            var format = string.Format("h:mm:ss t");
            return @this.ToString(format);
        }

        // Month Year
        ///     A DateTime extension method that return as string format yyyy MMMM
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 2023 May</returns>
        public static string ToStringyyyyMMMM(this DateTime @this, string separator = " ")
        {
            var format = string.Format("yyyy{0}MMMM", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format MMMM yyyy 
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format May 2023</returns>
        public static string ToStringMMMMyyyy(this DateTime @this, string separator = " ")
        {
            var format = string.Format("MMMM{0}yyyy", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format yyyy MMM
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 2023 Dec</returns>
        public static string ToStringyyyyMMM(this DateTime @this, string separator = " ")
        {
            var format = string.Format("yyyy{0}MMM", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format MMM yyyy 
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format Dec 2023</returns>
        public static string ToStringMMMyyyy(this DateTime @this, string separator = " ")
        {
            var format = string.Format("MMM{0}yyyy", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format yyyy MM
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 2023 12</returns>
        public static string ToStringyyyyMM(this DateTime @this, string separator = " ")
        {
            var format = string.Format("yyyy{0}MM", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format MM yyyy 
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 12 2023</returns>
        public static string ToStringMMyyyy(this DateTime @this, string separator = " ")
        {
            var format = string.Format("MM{0}yyyy", separator);
            return @this.ToString(format);
        }

        ///     A DateTime extension method that return as string format yyyy M
        /// </summary>
        /// <param name="@this">The @this to act on.</param>
        /// <returns>return a DateTime object as string format 2023 12</returns>
        public static string ToStringyyyyM(this DateTime @this, string separator = " ")
        {
            var format = string.Format("yyyy{0}M", separator);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be M yyyy 
        /// </code>
        /// e.g 2 2023
        /// </example>
        /// </summary>
        public static string ToStringMyyyy(this DateTime @this, string separator = " ")
        {
            var format = string.Format("M{0}yyyy", separator);
            return @this.ToString(format);
        }

        /// <summary>
        /// A DateTime extension method that return string 
        /// <example>
        /// <code>
        /// Return string will be MMM dd, yyyy
        /// </code>
        /// e.g March 31, 2023 
        /// </example>
        /// </summary>
        public static string ToStringMMMddyyyy(this DateTime @this)
        {
            var format = string.Format("MMM dd, yyyy");
            return @this.ToString(format);
        }

        ///// <summary>
        /////     A DateTime extension method that return Last Date Of Month.
        ///// </summary>
        ///// <param name="@this">The @this to act on.</param>
        ///// <returns>return a DateTime object</returns>
        //public static string DateTimeToyyyymmddhhmmss(this DateTime @this)
        //{
        //    return string.Format("{0}{1}{2}{3}{4}{5}", @this.Year, @this.Month, @this.Day, @this.Hour, @this.Minute, @this.Second);
        //}

        ///// <summary>
        /////     A DateTime extension method that return Last Date Of Month.
        ///// </summary>
        ///// <param name="@this">The @this to act on.</param>
        ///// <returns>return a DateTime object</returns>
        //public static string DateTimeToyymmddhhmmss(this DateTime @this)
        //{
        //    return string.Format("{0}{1}{2}{3}{4}{5}", @this.Year.ToString().Substring(@this.Year.ToString().Length - 2), 
        //        @this.Month, @this.Day, @this.Hour, @this.Minute, @this.Second);
        //}

        ///// <summary>
        /////     A DateTime extension method that return Last Date Of Month.
        ///// </summary>
        ///// <param name="@this">The @this to act on.</param>
        ///// <returns>return a DateTime object</returns>
        //public static string DateToyyyymmdd(this DateTime @this)
        //{
        //    return string.Format("{0}{1}{2}", @this.Year.ToString(),
        //        @this.Month, @this.Day);
        //}

        ///// <summary>
        /////     A DateTime extension method that return Last Date Of Month.
        ///// </summary>
        ///// <param name="@this">The @this to act on.</param>
        ///// <returns>return a DateTime object</returns>
        //public static string DateToyymmdd(this DateTime @this)
        //{
        //    return string.Format("{0}{1}{2}", @this.Year.ToString().Substring(@this.Year.ToString().Length - 2),
        //        @this.Month, @this.Day);
        //}

        ///// <summary>
        /////     A DateTime extension method that return Last Date Of Month.
        ///// </summary>
        ///// <param name="@this">The @this to act on.</param>
        ///// <returns>return a DateTime object</returns>
        //public static string DateTimeTohhmm(this DateTime @this)
        //{
        //    return string.Format("{0}:{1}", @this.Hour, @this.Minute);
        //}

        ///// <summary>
        /////     A DateTime extension method that return Last Date Of Month.
        ///// </summary>
        ///// <param name="@this">The @this to act on.</param>
        ///// <returns>return a DateTime object</returns>
        //public static string DateTimeToFormat(this DateTime @this)
        //{
        //    return string.Format("{0}{1}{2}", @this.Year.ToString().Substring(@this.Year.ToString().Length - 2),
        //        @this.Month, @this.Day);
        //}

        ///// <summary>
        /////     A DateTime extension method that return Last Date Of Month.
        ///// </summary>
        ///// <param name="@this">The @this to act on.</param>
        ///// <returns>return a DateTime object</returns>
        //public static TimeSpan DateTimeToTimeSpan(this DateTime @this)
        //{
        //    return new TimeSpan(@this.Hour, @this.Minute, @this.Second);
        //}
    }
}
