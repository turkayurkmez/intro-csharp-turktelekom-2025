using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class ReportGenerator
    {
        public string OutputFormat { get; set; }

        public string ExcelFilePath { get; set; }


        /*eğer bir class'ın tüm set özellerikeri "init" olarak tanımlıysa bu nesne immutable'dır!'*/
        public string ReportFormat { get; init; }

        //public ReportGenerator()
        //{
        //    OutputFormat = "PDF";
        //}

        public ReportGenerator(string excelFilePath)
        {
            ExcelFilePath = excelFilePath;
        }

        public ReportGenerator(string excelFilePath, string outputFormat, string reportFormat)
        {
            ExcelFilePath = excelFilePath;
            OutputFormat = outputFormat;
            ReportFormat = reportFormat;
                
        }

        //Record icad edildi...
    }
}
