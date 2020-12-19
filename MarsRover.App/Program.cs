﻿using System;
using NLog;
namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger _logger = NLog.LogManager.GetCurrentClassLogger();

            try
            {
                _logger.Log(LogLevel.Error, "DENEME");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}



