namespace MovieForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CB_Table_Picker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Add_Data_To_Table = new System.Windows.Forms.Button();
            this.BTN_Delete_Row = new System.Windows.Forms.Button();
            this.BTN_Alter_row = new System.Windows.Forms.Button();
            this.CHKBX_Show_Console = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Table_Picker
            // 
            this.CB_Table_Picker.FormattingEnabled = true;
            this.CB_Table_Picker.Location = new System.Drawing.Point(810, 28);
            this.CB_Table_Picker.Name = "CB_Table_Picker";
            this.CB_Table_Picker.Size = new System.Drawing.Size(162, 21);
            this.CB_Table_Picker.TabIndex = 0;
            this.CB_Table_Picker.SelectedIndexChanged += new System.EventHandler(this.CB_Table_Picker_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите таблицу для работы:";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMain.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMain.Location = new System.Drawing.Point(13, 28);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMain.Size = new System.Drawing.Size(791, 327);
            this.dataGridViewMain.TabIndex = 2;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Location = new System.Drawing.Point(811, 56);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(160, 23);
            this.BTN_Refresh.TabIndex = 3;
            this.BTN_Refresh.Text = "Обновить";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(810, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-----------------------------------------------------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Add_Data_To_Table
            // 
            this.BTN_Add_Data_To_Table.Location = new System.Drawing.Point(813, 102);
            this.BTN_Add_Data_To_Table.Name = "BTN_Add_Data_To_Table";
            this.BTN_Add_Data_To_Table.Size = new System.Drawing.Size(158, 23);
            this.BTN_Add_Data_To_Table.TabIndex = 5;
            this.BTN_Add_Data_To_Table.Text = "Добавить запись";
            this.BTN_Add_Data_To_Table.UseVisualStyleBackColor = true;
            this.BTN_Add_Data_To_Table.Click += new System.EventHandler(this.BTN_Add_Data_To_Table_Click);
            // 
            // BTN_Delete_Row
            // 
            this.BTN_Delete_Row.Location = new System.Drawing.Point(813, 132);
            this.BTN_Delete_Row.Name = "BTN_Delete_Row";
            this.BTN_Delete_Row.Size = new System.Drawing.Size(158, 23);
            this.BTN_Delete_Row.TabIndex = 6;
            this.BTN_Delete_Row.Text = "Удалить запись";
            this.BTN_Delete_Row.UseVisualStyleBackColor = true;
            this.BTN_Delete_Row.Click += new System.EventHandler(this.BTN_Delete_Row_Click);
            // 
            // BTN_Alter_row
            // 
            this.BTN_Alter_row.Location = new System.Drawing.Point(813, 162);
            this.BTN_Alter_row.Name = "BTN_Alter_row";
            this.BTN_Alter_row.Size = new System.Drawing.Size(158, 23);
            this.BTN_Alter_row.TabIndex = 7;
            this.BTN_Alter_row.Text = "Изменить запись";
            this.BTN_Alter_row.UseVisualStyleBackColor = true;
            this.BTN_Alter_row.Click += new System.EventHandler(this.BTN_Alter_row_Click);
            // 
            // CHKBX_Show_Console
            // 
            this.CHKBX_Show_Console.AutoSize = true;
            this.CHKBX_Show_Console.Location = new System.Drawing.Point(813, 337);
            this.CHKBX_Show_Console.Name = "CHKBX_Show_Console";
            this.CHKBX_Show_Console.Size = new System.Drawing.Size(120, 17);
            this.CHKBX_Show_Console.TabIndex = 8;
            this.CHKBX_Show_Console.Text = "Показать консоль";
            this.CHKBX_Show_Console.UseVisualStyleBackColor = true;
            this.CHKBX_Show_Console.CheckedChanged += new System.EventHandler(this.CHKBX_Show_Console_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 384);
            this.Controls.Add(this.CHKBX_Show_Console);
            this.Controls.Add(this.BTN_Alter_row);
            this.Controls.Add(this.BTN_Delete_Row);
            this.Controls.Add(this.BTN_Add_Data_To_Table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Table_Picker);
            this.Name = "Form1";
            this.Text = "MovieDB ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Table_Picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Add_Data_To_Table;
        private System.Windows.Forms.Button BTN_Delete_Row;
        private System.Windows.Forms.Button BTN_Alter_row;
        private System.Windows.Forms.CheckBox CHKBX_Show_Console;
    }
}

