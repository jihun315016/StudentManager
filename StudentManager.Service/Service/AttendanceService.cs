using StudentManager.Data.DAC;
using StudentManager.Data.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using Excel = Microsoft.Office.Interop.Excel;

namespace StudentManager.Service.Service
{
    public class AttendanceService
    {
        public DataTable GetAllAttendanceList(DateTime start, DateTime end)
        {
            AttendanceDAC dac = new AttendanceDAC();
            DataTable dt = dac.GetAllAttendanceList(start, end);
            dac.Dispose();

            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                int isAtt = int.Parse(dr["IS_ATTENDANCE"].ToString());
                list.Add(isAtt == 1 ? "O" : "X");
            }

            dt.Columns.Remove("IS_ATTENDANCE");
            dt.Columns.Add("IS_ATTENDANCE");

            for (int i = 0; i < list.Count; i++) 
            {
                dt.Rows[i]["IS_ATTENDANCE"] = list[i];
            }

            return dt;
        }

        public DataTable GetAttendanceListByStuNo(int stuNo)
        {
            AttendanceDAC dac = new AttendanceDAC();
            DataTable dt = dac.GetAttendanceListByStuNo(stuNo);
            dac.Dispose();
            return dt;
        }

        public List<bool> GetIsAttendance(List<int> stuNoList, int courseNo, DateTime attDate)
        {
            AttendanceDAC dac = new AttendanceDAC();
            List<bool> list = new List<bool>();
            int isExistNum = 0;

            foreach (int stuNo in stuNoList)
            {
                int attResult = dac.IsAttendanceCheck(stuNo, courseNo, attDate);
                isExistNum += attResult;
                bool isAtt = attResult == 1 ? true : false;
                list.Add(isAtt);
            }

            return list;
        }

        // 출석 정보를 INSERT 할지 UPDATE 할지 확인
        public bool isAttendance(int courseNo, DateTime attDate)
        {
            AttendanceDAC dac = new AttendanceDAC();
            if (dac.isAttendance(courseNo, attDate) > 0)
                return true;
            else
                return false;
        }

        public bool InsertAttendance(List<int> stuNoList, int courseNo, DateTime date, List<int> isAttList)
        {
            AttendanceDAC dac = new AttendanceDAC();
            bool result = dac.InsertAttendance(stuNoList, courseNo, date, isAttList);
            dac.Dispose();

            return result;
        }

        public bool UpdateAttendance(List<int> stuNoList, int courseNo, DateTime date, List<int> isAttList)
        {
            AttendanceDAC dac = new AttendanceDAC();
            bool result = dac.UpdateAttendance(stuNoList, courseNo, date, isAttList);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// 출석부 엑셀 Export
        /// </summary>
        /// <param name="dt">export할 데이터 테이블</param>
        /// <param name="file">저장 경로</param>
        /// <param name="date">출석 시작 날짜, 어느 날짜부터 출석부를 뽑을건지</param>
        /// <param name="period">출석 기간, date로부터 어느 기간동안 출석부를 뽑을건지</param>
        /// <param name="courseNo">export할 수업 번호</param>
        /// <returns>export 성공 여부</returns>
        public bool ExportAttendanceBook(DataTable dt, string file, DateTime date, int period, int courseNo)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
            Excel.Worksheet xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);
            Excel.Range rg;
            Dictionary<string, int> columnWidths = new Dictionary<string, int>();
            columnWidths.Add("STUDENT_NO", 10);
            columnWidths.Add("STUDENT_NAME", 8);
            columnWidths.Add("AGE", 8);
            columnWidths.Add("SCHOOL", 14);
            columnWidths.Add("STUDENT_CONTACT", 14);
            columnWidths.Add("GUARDIAN_CONTACT", 14);
            columnWidths.Add("GUARDIAN_RERATIONSHIP", 8);

            string courseName = "전체 출석부";
            string teacher = string.Empty;
            if (courseNo > 0)
            {
                CourseDAC dac = new CourseDAC();
                EmployeeCourseVO courseInfo = dac.GetCourseInfoByPk(courseNo);
                courseName = courseInfo.CourseName;
            }

            rg = xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 1]];
            rg.Font.Bold = true;
            rg.Font.Size = 12;
            xlWorkSheet.Cells[1, 1] = $"{courseName} {teacher}";
            xlWorkSheet.Cells[3, 1] = $"{DateTime.Now.ToString("yyyy-MM-dd")} ~ {DateTime.Now.AddDays(period).ToString("yyyy-MM-dd")}";

            int startRow = 4;
           
            for (int c = 0; c < dt.Columns.Count; c++)
            {
                xlWorkSheet.Cells[startRow, c + 1] = dt.Columns[c].Caption;
                rg = xlWorkSheet.Range[xlWorkSheet.Cells[startRow, c + 1], xlWorkSheet.Cells[startRow, c + 1]];
                rg.ColumnWidth = columnWidths[dt.Columns[c].ColumnName];
            }

            for (int i = dt.Columns.Count; i < dt.Columns.Count + period; i++)
            {
                xlWorkSheet.Cells[startRow, i + 1] = date.Day.ToString();

                rg = xlWorkSheet.Range[xlWorkSheet.Cells[startRow, i + 1], xlWorkSheet.Cells[startRow, i + 1]];                
                if (date.ToString("ddd") == "토")                
                    rg.Font.Color = Color.FromArgb(0, 0, 255);                
                else if (date.ToString("ddd") == "일")
                    rg.Font.Color = Color.FromArgb(255, 0, 0);
                date = date.AddDays(1);
            }

            // 칼럼 배경색, 가운데 정렬, 굵게 설정
            rg = xlWorkSheet.Range[xlWorkSheet.Cells[startRow, 1], xlWorkSheet.Cells[startRow, dt.Columns.Count + period]];
            rg.Font.Bold = true;
            rg.Interior.Color = Color.FromArgb(255, 228, 196);
            rg.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // 출석부 테두리
            rg = xlWorkSheet.Range[xlWorkSheet.Cells[startRow, 1], xlWorkSheet.Cells[dt.Rows.Count, dt.Columns.Count + period]];
            rg.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            for (int r = startRow; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    xlWorkSheet.Cells[r + 1, c + 1] = dt.Rows[r][c].ToString();
                }
            }

            xlWorkBook.SaveAs(file, Excel.XlFileFormat.xlWorkbookNormal);
            xlWorkBook.Close();
            xlApp.Quit();

            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                xlApp = null;

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                xlWorkBook = null;

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                xlWorkSheet = null;

                return true;
            }
            catch
            {
                xlApp = null;
                xlWorkBook = null;
                xlWorkSheet = null;

                return false;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
