using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieForms
{
    public partial class InsertToTable : Form
    {
        string table = "";
        Connector connector = new Connector();
        DataTable dataTable = new DataTable();
        List<Label> lbl = new List<Label>();
        List<TextBox> textBoxes = new List<TextBox>();
        int label_Y_cord = 25;
        int textbox_Y_cord = 25;
        public InsertToTable()
        {
            InitializeComponent();
        }
        public InsertToTable(string table_name) : this()
        {
            table = table_name; //На всякий пожарный сохраняет название таблицы строкой
            dataTable = connector.GetAllData(table_name);

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                lbl.Add(new Label());
                lbl[i].Size = new Size(70, 25);
                lbl[i].Text = dataTable.Columns[i].ColumnName;
                lbl[i].Location = new Point(8, label_Y_cord);
                label_Y_cord += 50;
                this.Controls.Add(lbl[i]);
            }
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                textBoxes.Add(new TextBox());
                textBoxes[i].Location = new Point(150, textbox_Y_cord);
                textBoxes[i].Size = new Size(150, 25);
                textbox_Y_cord += 50;
                this.Controls.Add(textBoxes[i]);
            }
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if(table == "Directors")
            {
                if (textBoxes[1] != null && textBoxes[2] != null)
                {
                    connector.InsertDataToDirectors(textBoxes[1].Text.ToString(), textBoxes[2].Text.ToString());
                }
            }
            else if (table == "Movies")
            {
                if (textBoxes[1] != null && textBoxes[2] != null && textBoxes[3] != null)
                {
                    connector.InsertDataToMovies(textBoxes[1].Text.ToString(), textBoxes[2].Text.ToString(), textBoxes[3].Text.ToString());
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
