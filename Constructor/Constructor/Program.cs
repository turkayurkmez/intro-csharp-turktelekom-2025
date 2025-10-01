// See https://aka.ms/new-console-template for more information
using Constructor;

Console.WriteLine("Hello, World!");
ReportGenerator reportGenerator = new ReportGenerator("C:\\rapor.xlsx");
Console.WriteLine(reportGenerator.OutputFormat);

ReportGenerator reportGenerator1 = new ReportGenerator("C:\\test.xlsx");
reportGenerator1.OutputFormat = "PDF";
reportGenerator1.OutputFormat = "HTML";

ReportGenerator reportGenerator2 = new ReportGenerator("test.xlsx", "HTML", "Professional");


ReportGenerator reportGenerator3 = new ReportGenerator("a.xlsx") { OutputFormat = "PDF", ReportFormat = "Basic" };

