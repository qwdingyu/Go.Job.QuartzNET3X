﻿using Go.Job.Service;
using System;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new SchedulerFactory().CreateSchedulerAndStart().Wait();
            Console.WriteLine("作业调度服务已启动!");
            string userCommand = string.Empty;
            while (userCommand != "exit")
            {
                if (string.IsNullOrEmpty(userCommand) == false)
                {
                    Console.WriteLine("     非退出指令,自动忽略...");
                }

                userCommand = Console.ReadLine();
            }
        }
    }
}