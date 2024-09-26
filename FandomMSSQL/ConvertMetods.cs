using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FandomMSSQL
{
    public class ConvertMetods //класс для конвертации
    {
        public static DataTable ListOfString2DataSet(List<string> _lst)
        {
            DataTable result = new DataTable();
            result.Columns.Add("Имя");
            foreach (string str in _lst)
            {
                result.Rows.Add(str); //метод добавляющий строку В столбец
            }
            return result;
        }
    }
}
