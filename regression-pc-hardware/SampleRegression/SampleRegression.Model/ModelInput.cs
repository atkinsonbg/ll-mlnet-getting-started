//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace SampleRegression.Model
{
    public class ModelInput
    {
        [ColumnName("vendor_name"), LoadColumn(0)]
        public string Vendor_name { get; set; }


        [ColumnName("model_name"), LoadColumn(1)]
        public string Model_name { get; set; }


        [ColumnName("myct"), LoadColumn(2)]
        public float Myct { get; set; }


        [ColumnName("mmin"), LoadColumn(3)]
        public float Mmin { get; set; }


        [ColumnName("mmax"), LoadColumn(4)]
        public float Mmax { get; set; }


        [ColumnName("cach"), LoadColumn(5)]
        public float Cach { get; set; }


        [ColumnName("chmin"), LoadColumn(6)]
        public float Chmin { get; set; }


        [ColumnName("chmax"), LoadColumn(7)]
        public float Chmax { get; set; }


        [ColumnName("prp"), LoadColumn(8)]
        public float Prp { get; set; }


        [ColumnName("erp"), LoadColumn(9)]
        public float Erp { get; set; }


    }
}
