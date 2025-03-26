using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace MovieForms
{
    public partial class Form1 : Form
    {
        Connector connector = new Connector();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Заполняем ComboBox именами таблиц.
            for (int i = connector.GetTablesNames().Count-1; i >= 0; i--) 
            {
                CB_Table_Picker.Items.Add(connector.GetTablesNames()[i]);
            }
            AllocConsole();
        }
        //--------------------------Debug console--------------------------------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FreeConsole();
        }
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
        //-----------------------------------------------------------------------
        private string GetRowId()
        {
            string rowId = dataGridViewMain.CurrentRow.Cells[0].Value.ToString();
            return rowId;
        }

        private void CB_Table_Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CB_Table_Picker.SelectedItem == null) BTN_Add_Data_To_Table.Visible = false;
            switch (CB_Table_Picker.SelectedIndex)
            {
                case 0:
                case 1: dataGridViewMain.DataSource = connector.GetAllData(CB_Table_Picker.SelectedItem.ToString());
                        break;
                default: break;
            }
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            if(CB_Table_Picker.SelectedItem != null) dataGridViewMain.DataSource = connector.GetAllData(CB_Table_Picker.SelectedItem.ToString());
        }

        private void BTN_Add_Data_To_Table_Click(object sender, EventArgs e)
        {
            if (CB_Table_Picker.SelectedItem == null) MessageBox.Show("Не выбрана таблица", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                InsertToTable addInfoToTable = new InsertToTable(CB_Table_Picker.SelectedItem.ToString());
                addInfoToTable.ShowDialog();
            }
        }

        private void BTN_Delete_Row_Click(object sender, EventArgs e)
        {
            string index = GetRowId();
            Console.WriteLine(index);
            connector.DeleteData(index, CB_Table_Picker.SelectedItem.ToString());
        }

        private void BTN_Alter_row_Click(object sender, EventArgs e)
        {
            string i = GetRowId();
            Console.WriteLine(i);

        }
    }
}
