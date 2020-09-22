﻿using NUnit.Framework;
using ScottPlot.Demo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ScottPlot.Tests.Cookbook
{
    class Chef
    {
        [Test]
        public void Test_Cookbook_Generator()
        {
            string sourceFolder = System.IO.Path.GetFullPath("../../../../ScottPlot.Demo/ScottPlot.Demo");
            Console.WriteLine(sourceFolder);
            var reportGen = new ReportGenerator(useDLL: true, sourceFolder: sourceFolder);
            Console.WriteLine("Generating cookbook in: " + reportGen.outputFolder);

            reportGen.ClearFolders();
            foreach (IPlotDemo recipe in reportGen.recipes)
            {
                Console.WriteLine($"Generating {recipe}...");
                reportGen.CreateImage(recipe);
            }
            reportGen.MakeReports();
        }
    }
}