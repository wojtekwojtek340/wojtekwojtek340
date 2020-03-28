using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Mechatronika_w_medycynie
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
       
        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public double ReadCell(int i, int j)
        {
            if (ws.Cells[i, j].Value2 != null && ws.Cells[i, j].Value2 != -4E+28)
            {
                return ws.Cells[i, j].Value2;
            }
            else
            {
                return 0;
            }
                
        }
    }
}
