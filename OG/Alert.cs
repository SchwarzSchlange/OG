﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OG
{
    internal class Alert
    {
        public static void Warning(string content)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"[{TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToLongTimeString()}] [Warning] => {content}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void Success(string content)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToLongTimeString()}] [Success] => {content}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void Error(string content)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToLongTimeString()}] [Error] => {content}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void Info(string content)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[{TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToLongTimeString()}] [Info] => {content}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

    }
}
