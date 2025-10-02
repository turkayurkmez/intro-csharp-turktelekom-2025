// See https://aka.ms/new-console-template for more information
using AbstractVEInterface;

Console.WriteLine("Hello, World!");

PDFDocument pdf = new PDFDocument();
ExcelDocument excelDocument = new ExcelDocument();
WordDocument wordDocument = new WordDocument();

DocumentPrinter documentPrinter = new DocumentPrinter();
//documentPrinter.Print(pdf);
documentPrinter.Print(excelDocument);
documentPrinter.Print(wordDocument);

