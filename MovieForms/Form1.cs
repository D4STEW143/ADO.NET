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
        }

        private void CB_Table_Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_Table_Picker.SelectedIndex)
            {
                case 0:
                case 1: dataGridViewMain.DataSource = connector.GetAllData(CB_Table_Picker.SelectedItem.ToString());
                        break;
                default: break;
            }
        }

        
    }
}
