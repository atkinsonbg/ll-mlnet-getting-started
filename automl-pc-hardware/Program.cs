using System;
using Microsoft.ML;
using Microsoft.ML.AutoML;

namespace MLNET
{
    class Program
    {
        static void Main(string[] args)
        {
            string DATA_PATH = "../data/machine.data";

            // // See https://aka.ms/new-console-template for more information
            // Console.WriteLine("Hello, World!");

            var mlContext = new MLContext();

            var columnInformation = mlContext.Auto().InferColumns(DATA_PATH, labelColumnName: "erp", separatorChar: ',');

            var textLoader = mlContext.Data.CreateTextLoader(columnInformation.TextLoaderOptions);

            var data = textLoader.Load(DATA_PATH);

            var regressionExpSettings = new RegressionExperimentSettings
            {
                MaxExperimentTimeInSeconds = 20,
                OptimizingMetric = RegressionMetric.RSquared
            };

            var result = mlContext.Auto().CreateRegressionExperiment(regressionExpSettings).Execute(data, labelColumnName: "erp");

            Console.WriteLine(result.BestRun.ValidationMetrics.RSquared);
        }
    }

}