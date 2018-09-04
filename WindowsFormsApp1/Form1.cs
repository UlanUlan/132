using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathToExcelFile = "123.xlsx";
            ConnexionExcel ConxObject = new ConnexionExcel(pathToExcelFile);

            var queruRusBac = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetRus")
                              where a.Educ.Contains("бакалавриат")
                               select a;

            var queruRusMas = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetRus")
                              where a.Educ.Contains("магистратура")
                               select a;

            var queruRusDoc = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetRus")
                              where a.Educ.Contains("докторантура")
                               select a;

            var queruEngBac = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetEng")
                              where a.Educ.Contains("bachelor")
                              select a;

            var queruEngMas = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetEng")
                              where a.Educ.Contains("master")
                              select a;

            var queruEngDoc = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetEng")
                              where a.Educ.Contains("doctor")
                              select a;

            var queruKazBac = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetKaz")
                              where a.Educ.Contains("бакалавриат")
                              select a;

            var queruKazMas = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetKaz")
                              where a.Educ.Contains("магистратура")
                              select a;

            var queruKazDoc = from a in ConxObject.UrlConnexion.Worksheet<ExcelFile>("SheetKaz")
                              where a.Educ.Contains("докторантура")
                              select a;




            foreach (var q in queruRusBac)
            {
                chartRus.Series["бакалавриат"].Points.AddXY(q.Fac, q.Count);
            }
            foreach (var q in queruRusMas)
            {
                chartRus.Series["магистратура"].Points.AddXY(q.Fac, q.Count);
            }
            foreach (var q in queruRusDoc)
            {
                chartRus.Series["докторантура"].Points.AddXY(q.Fac, q.Count);
            }


            foreach (var q in queruEngBac)
            {
                chartEng.Series["bachelor"].Points.AddXY(q.Fac, q.Count);
            }
            foreach (var q in queruEngMas)
            {
                chartEng.Series["master"].Points.AddXY(q.Fac, q.Count);
            }
            foreach (var q in queruEngDoc)
            {
                chartEng.Series["doctor"].Points.AddXY(q.Fac, q.Count);
            }


            foreach (var q in queruKazBac)
            {
                chartKaz.Series["бакалавриат"].Points.AddXY(q.Fac, q.Count);
            }
            foreach (var q in queruKazMas)
            {
                chartKaz.Series["магистратура"].Points.AddXY(q.Fac, q.Count);
            }
            foreach (var q in queruKazDoc)
            {
                chartKaz.Series["докторантура"].Points.AddXY(q.Fac, q.Count);
            }
        }
    }
}
