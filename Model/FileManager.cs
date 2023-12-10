
using Spire.Xls; 

namespace Multiprocessor_And_Multithreaded_Programming.Model
{
    public interface IFileManager
    {
        void ExportData(List<Trains> studentsList, string filePath);

    }
    public class FileManager : IFileManager 
    {

        public void ExportData(List<Trains> trainsList, string filePath)
        {
            Workbook workbook = new Workbook(); // объект типа книга для экселя
            Worksheet sheet = workbook.Worksheets[0]; // лист в книге 
            sheet.Range[1, 1].Value = $"Название"; // ячейка 1
            sheet.Range[1, 2].Text = $"Тип поезда";
            sheet.Range[1, 3].Text = $"Дни курсирования";
            sheet.Range[1, 4].Text = $"Отправление";
            sheet.Range[1, 5].Text = $"Прибытие";
            sheet.Range[1, 5].ColumnWidth = 16;
            sheet.Range[1, 6].Text = $"Конечный пункт";
            for (int i = 2; i < trainsList.Count + 2; i++)
            {
                sheet.Range[i, 1].Text = trainsList[i - 2].TrainsName;
                sheet.Range[i, 2].Text = trainsList[i - 2].TrainsType;
                sheet.Range[i, 3].Text = trainsList[i - 2].TrainsDOC;
                sheet.Range[i, 4].Text = trainsList[i - 2].Departure.ToString("D");
                sheet.Range[i, 5].Text = trainsList[i - 2].Arrival.ToString("D");
                sheet.Range[i, 6].Text = trainsList[i - 2].WhereWay!.WhereWay;
            }
            workbook.SaveToFile(filePath, ExcelVersion.Version2016);
        }
    }
}
