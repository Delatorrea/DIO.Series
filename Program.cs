using System.Collections.Generic;
using DIO.Series.Controllers;
using DIO.Series.Models;
using DIO.Series.Repository;
using DIO.Series.Views;
using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {

            Display display = new Display(
                new SeriesController(
                    new SeriesRepository(
                        new List<Serie>()
                    )
                )
            );
            display.Call();
        }
        
    }
}
