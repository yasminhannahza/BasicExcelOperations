using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Extensions.Rafiq;

namespace BasicExcelOperations
{
    partial class frmBasicExcelOps
    {
        private async Task ExcelBasicTask()
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;

            Excel.Workbooks workbooks = xlApp.Workbooks;
            Excel.Workbook workbook = workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];


            worksheet.Range["A1"].Value = "Hi World!";
            worksheet.Cells[3, await "C".GetColumnFromAlphabet()].Value = "Canggih nyer cara";

            Random random = new Random();

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                listNumbers.Add(random.Next(0, 10000000));
            }

            int line = 1;

            foreach (int number in listNumbers)
            {
                await UpdateProgressBar(line, listNumbers.Count, true);

                worksheet.Cells[line, await "B".GetColumnFromAlphabet()].Value = number;
                line++;
            }

            await listNumbers.FillExcelColumns(worksheet, 1, await "D".GetColumnFromAlphabet());

            workbook.Close(SaveChanges: false);
            xlApp.Quit();

            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(workbooks);
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
