using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLY_QUANAN
{
    internal class XuatHoaDon
    {
        public static bool xuatHoaDon(string content, System.Data.DataTable dataTable, string billId, string customerName, string orderDate, float fullValue, string tenNv)
        {
            try
            {
                
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbooks oBooks;
                Microsoft.Office.Interop.Excel.Sheets oSheets;
                Microsoft.Office.Interop.Excel.Workbook oBook;
                Microsoft.Office.Interop.Excel.Worksheet oSheet;

               
                oExcel.Visible = true;
                oExcel.DisplayAlerts = false;
                oExcel.Application.SheetsInNewWorkbook = 1;
                oBooks = oExcel.Workbooks;
                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
                oSheets = oBook.Worksheets;
                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                string sheetName = content;
                string title = "Đơn hàng " + content;

                oSheet.Name = sheetName;

               
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");
                head.MergeCells = true;
                head.Value2 = title;
                head.Font.Bold = true;
                head.Font.Name = "Times New Roman";
                head.Font.Size = "20";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


               
                int billIdRow = 1;
                Microsoft.Office.Interop.Excel.Range billIdLabelCell = oSheet.get_Range("A" + billIdRow, "A" + billIdRow);
                billIdLabelCell.Value2 = "Mã hóa đơn: " + billId;

                int customerRow = 2;
                Microsoft.Office.Interop.Excel.Range customerNameLabelCell = oSheet.get_Range("A" + customerRow, "A" + customerRow);
                customerNameLabelCell.Value2 = "Tên khách hàng:";
                Microsoft.Office.Interop.Excel.Range customerNameValueCell = oSheet.get_Range("B" + customerRow, "B" + customerRow);
                customerNameValueCell.Value2 = customerName;

                int orderDateRow = customerRow + 1;
                Microsoft.Office.Interop.Excel.Range orderDateLabelCell = oSheet.get_Range("A" + orderDateRow, "A" + orderDateRow);
                orderDateLabelCell.Value2 = "Ngày đặt:";
                Microsoft.Office.Interop.Excel.Range orderDateValueCell = oSheet.get_Range("B" + orderDateRow, "B" + orderDateRow);
                orderDateValueCell.Value2 = orderDate;

                int totalBillValueRow = orderDateRow + 1;
                Microsoft.Office.Interop.Excel.Range totalBillValueLabelCell = oSheet.get_Range("A" + totalBillValueRow, "A" + totalBillValueRow);
                totalBillValueLabelCell.Value2 = "Tổng giá trị hóa đơn:";
                Microsoft.Office.Interop.Excel.Range totalBillValueValueCell = oSheet.get_Range("B" + totalBillValueRow, "B" + totalBillValueRow);
                totalBillValueValueCell.Value2 = fullValue.ToString();

                int tenNhanVienRow = totalBillValueRow + 1;
                Microsoft.Office.Interop.Excel.Range tenNhanVienLabelCell = oSheet.get_Range("A" + tenNhanVienRow, "A" + tenNhanVienRow);
                tenNhanVienLabelCell.Value2 = "Người tạo bill:";
                Microsoft.Office.Interop.Excel.Range tenNhanVienValueCell = oSheet.get_Range("B" + tenNhanVienRow, "B" + tenNhanVienRow);
                tenNhanVienValueCell.Value2 = tenNv;
                tenNhanVienValueCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;


            
                int columnRow = tenNhanVienRow + 1;

                


                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A" + columnRow, "A" + columnRow);
                cl1.Value2 = "Thứ tự bill";
                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B" + columnRow, "B" + columnRow);
                cl2.Value2 = "Tên món ăn";
                cl2.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C" + columnRow, "C" + columnRow);
                cl3.Value2 = "Đơn giá";
                cl3.ColumnWidth = 14;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D" + columnRow, "D" + columnRow);
                cl4.Value2 = "Số lượng";
                cl4.ColumnWidth = 23.71;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E" + columnRow, "E" + columnRow);
                cl5.Value2 = "Tổng giá";
                cl5.ColumnWidth = 10.71;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A" + columnRow, "E" + columnRow);


              
                int size = dataTable.Columns.Count;


                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

               

                string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

             

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];

                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        arr[row, col] = dataRow[col].ToString();
                    }
                }

             

                int rowStart = 7;

                int columnStart = 1;

                int rowEnd = rowStart + dataTable.Rows.Count - 1;

                int columnEnd = dataTable.Columns.Count;

              

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

              

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

         

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

     

                range.Value2 = arr;

        

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

             

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

             
                oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }
    }
}
