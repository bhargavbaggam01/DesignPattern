namespace BuilderDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportDirector reportDirector = new ReportDirector();
            ExcelReportBuilder excelReport = new ExcelReportBuilder();

            Report report = reportDirector.MakeReport(excelReport);           
            report.DisplayReport();
        }
    }
}
