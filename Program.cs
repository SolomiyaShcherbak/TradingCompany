using AutoMapper;
using DAL.Concrete;
using System;

namespace TradingCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HandleMenu menu = new HandleMenu();
            menu.HandleStartMenu();
        }
    }
}
