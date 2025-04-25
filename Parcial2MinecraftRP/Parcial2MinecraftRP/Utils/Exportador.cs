using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using OfficeOpenXml;
using OfficeOpenXml.Style; 

namespace Parcial2MinecraftRP.Utils
{
    public static class Exportador
    {
        public static void ExportarACsv<T>(IEnumerable<T> data, string filePath, string delimiter = ",")
        {
            if (data == null || !data.Any())
            {
                MessageBox.Show("La lista de datos está vacía. No se generará el archivo CSV.");
                return;
            }

            PropertyInfo[] properties = typeof(T).GetProperties();

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    string header = string.Join(delimiter, properties.Select(p => EscapeCsvValue(p.Name, delimiter)));
                    sw.WriteLine(header);

                    foreach (var item in data)
                    {
                        string row = string.Join(delimiter, properties.Select(p =>
                        {
                            object value = p.GetValue(item);
                            return EscapeCsvValue(value?.ToString() ?? "", delimiter);
                        }));
                        sw.WriteLine(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el archivo CSV: {ex.Message}");
            }
        }

        private static string EscapeCsvValue(string value, string delimiter)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            bool needsEscaping = value.Contains(delimiter) || value.Contains("\"") || value.Contains("\r") || value.Contains("\n");

            if (needsEscaping)
            {
                value = value.Replace("\"", "\"\"");
                return $"\"{value}\"";
            }
            else
            {
                return value;
            }
        }

        public static void ExportarAExcel<T>(IEnumerable<T> data, string filePath, string sheetName = "Datos")
        {
            if (data == null || !data.Any())
            {
                MessageBox.Show("La lista de datos está vacía. No se generará el archivo Excel.");
                return;
            }


            PropertyInfo[] properties = typeof(T).GetProperties();

            try
            {
                using (var package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(sheetName);

                    
                    for (int col = 0; col < properties.Length; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = properties[col].Name;
                    }


                    int row = 2;
                    foreach (var item in data)
                    {
                        for (int col = 0; col < properties.Length; col++)
                        {
                            PropertyInfo property = properties[col];
                            object value = property.GetValue(item);

                            worksheet.Cells[row, col + 1].Value = value;

                            if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
                            {
                                if (value is DateTime dateTimeValue && dateTimeValue != DateTime.MinValue)
                                {

                                    worksheet.Cells[row, col + 1].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                                }
                            }
                        }
                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    FileInfo fileInfo = new FileInfo(filePath);
                    package.SaveAs(fileInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el archivo Excel: {ex.Message}");
            }
        }
    }
}
