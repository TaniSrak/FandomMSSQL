using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FandomMSSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNames_Click(object sender, EventArgs e) //имена
        {
            string tmp = string.Empty;
            var _lstNames = LinqToSqlClass.GetNames(); 
            foreach (var item in _lstNames)
            {
                tmp += item + "\r\n";
            }
            MessageBox.Show(tmp);
            dgwTable.DataSource = ConvertMetods.ListOfString2DataSet(_lstNames); //обновление списка имен
        }

        private void btnSearch_Click(object sender, EventArgs e) //поиск
        {
            var _lstNames = LinqToSqlClass.GetNames(tbSearch.Text); //создаем список имен
            dgwTable.DataSource = ConvertMetods.ListOfString2DataSet(_lstNames);
        }

        private void btnReplace_Click(object sender, EventArgs e) //заменить
        {
            if(LinqToSqlClass.ReplaceName(tbFind.Text, tbReplace.Text))
            {
                var _lstNames = LinqToSqlClass.GetNames(tbSearch.Text); //создаем список имен
                dgwTable.DataSource = ConvertMetods.ListOfString2DataSet(_lstNames);

            }
        }
    }
}
