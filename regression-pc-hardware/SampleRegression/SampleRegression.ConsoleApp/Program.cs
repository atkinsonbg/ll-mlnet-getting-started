//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleRegression.Model;

namespace SampleRegression.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Vendor_name = @"adviser",
                Myct = 125F,
                Mmin = 256F,
                Mmax = 6000F,
                Cach = 256F,
                Chmin = 16F,
                Chmax = 128F,
                Prp = 198F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Erp with predicted Erp from sample data...\n\n");
            Console.WriteLine($"Vendor_name: {sampleData.Vendor_name}");
            Console.WriteLine($"Myct: {sampleData.Myct}");
            Console.WriteLine($"Mmin: {sampleData.Mmin}");
            Console.WriteLine($"Mmax: {sampleData.Mmax}");
            Console.WriteLine($"Cach: {sampleData.Cach}");
            Console.WriteLine($"Chmin: {sampleData.Chmin}");
            Console.WriteLine($"Chmax: {sampleData.Chmax}");
            Console.WriteLine($"Prp: {sampleData.Prp}");
            Console.WriteLine($"\n\nPredicted Erp: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
