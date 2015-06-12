using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace resume_list
{
    public partial class form1_main : Form
    {
        public form1_main()
        {
            InitializeComponent();
            label_status.Text = string.Empty;
        }

        public string ConvertName(string RawName)
        {
            if (RawName.Trim() == "")
            {
                return "";
            }

            string varResult;
            //char[] charsToTrim = { ' ', '\t', '\n' };
            //varResult = RawName.Trim(charsToTrim);
            varResult = RawName.Replace("\n", string.Empty);
            varResult = varResult.Replace("\r", string.Empty);
            varResult = varResult.Replace("\t", string.Empty);
            varResult = varResult.Replace(" ", string.Empty);
            varResult = varResult.Replace("นามสกุล:", " ");

            return varResult;
        }

        public void SavedName()
        {
            if (textbox_paste_name.Text.Trim() == string.Empty)
            {
                return;
            }

            //Resume.accdb
            string varDbPath = AppDomain.CurrentDomain.BaseDirectory + "Resume.accdb";
            string varConnectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varDbPath + ";Persist Security Info=False;";
            string varName = textbox_view_name.Text;
            string varSQLSelect = "select [Name] from [List] where [Name]='" + varName + "'";
            string varSQLInsert = "insert into [List] (Name) values('" + varName + "')";

            OleDbConnection objCon = new OleDbConnection(varConnectionStr);
            OleDbCommand objCom = new OleDbCommand(varSQLSelect, objCon);
            OleDbDataReader objReader;

            objCon.Open();
            objReader = objCom.ExecuteReader();

            if (objReader.HasRows == true)
            {
                label_status.ForeColor = Color.Red;
                label_status.Text = "มีรายชื่อนี้แล้วในฐานข้อมูล";

            } else if(objReader.HasRows == false){
                objCom = new OleDbCommand(varSQLInsert, objCon);
                try
                {
                    objCom.ExecuteNonQuery();
                    label_status.ForeColor = Color.Green;
                    label_status.Text = "บันทึกชื่อ " + varName + " ลงในฐานข้อมูลเรียบร้อยแล้ว";
                    Clipboard.SetText(varName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            objCon.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textbox_view_name.Text = ConvertName(this.textbox_paste_name.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavedName();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.textbox_paste_name.SelectAll();
            this.label_status.Text = string.Empty;
        }
        
    }
}
