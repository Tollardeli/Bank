namespace Bank
{
    partial class Сontribution
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодВидаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минСуммаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодвалютыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.обменныйКурсВалютBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.банкDataSet = new Bank.БанкDataSet();
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видыВкладовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.видыВкладовTableAdapter = new Bank.БанкDataSetTableAdapters.ВидыВкладовTableAdapter();
            this.обменныйКурсВалютTableAdapter = new Bank.БанкDataSetTableAdapters.ОбменныйКурсВалютTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обменныйКурсВалютBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыВкладовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВидаВкладаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn,
            this.минСуммаВкладаDataGridViewTextBoxColumn,
            this.кодвалютыDataGridViewTextBoxColumn,
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.видыВкладовBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(505, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодВидаВкладаDataGridViewTextBoxColumn
            // 
            this.кодВидаВкладаDataGridViewTextBoxColumn.DataPropertyName = "КодВидаВклада";
            this.кодВидаВкладаDataGridViewTextBoxColumn.HeaderText = "КодВидаВклада";
            this.кодВидаВкладаDataGridViewTextBoxColumn.Name = "кодВидаВкладаDataGridViewTextBoxColumn";
            this.кодВидаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодВидаВкладаDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // минимальныйСрокВкладаМесDataGridViewTextBoxColumn
            // 
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn.DataPropertyName = "МинимальныйСрокВкладаМес";
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn.HeaderText = "МинимальныйСрокВкладаМес";
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn.Name = "минимальныйСрокВкладаМесDataGridViewTextBoxColumn";
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // минСуммаВкладаDataGridViewTextBoxColumn
            // 
            this.минСуммаВкладаDataGridViewTextBoxColumn.DataPropertyName = "МинСуммаВклада";
            this.минСуммаВкладаDataGridViewTextBoxColumn.HeaderText = "МинСуммаВклада";
            this.минСуммаВкладаDataGridViewTextBoxColumn.Name = "минСуммаВкладаDataGridViewTextBoxColumn";
            this.минСуммаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодвалютыDataGridViewTextBoxColumn
            // 
            this.кодвалютыDataGridViewTextBoxColumn.DataPropertyName = "Код_валюты";
            this.кодвалютыDataGridViewTextBoxColumn.DataSource = this.обменныйКурсВалютBindingSource;
            this.кодвалютыDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.кодвалютыDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.кодвалютыDataGridViewTextBoxColumn.HeaderText = "Валюта";
            this.кодвалютыDataGridViewTextBoxColumn.MaxDropDownItems = 1;
            this.кодвалютыDataGridViewTextBoxColumn.Name = "кодвалютыDataGridViewTextBoxColumn";
            this.кодвалютыDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодвалютыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодвалютыDataGridViewTextBoxColumn.ValueMember = "Код_валюты";
            // 
            // обменныйКурсВалютBindingSource
            // 
            this.обменныйКурсВалютBindingSource.DataMember = "ОбменныйКурсВалют";
            this.обменныйКурсВалютBindingSource.DataSource = this.банкDataSet;
            // 
            // банкDataSet
            // 
            this.банкDataSet.DataSetName = "БанкDataSet";
            this.банкDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // процентнаяСтавкаГодоваяDataGridViewTextBoxColumn
            // 
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn.DataPropertyName = "ПроцентнаяСтавкаГодовая";
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn.HeaderText = "ПроцентнаяСтавкаГодовая";
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn.Name = "процентнаяСтавкаГодоваяDataGridViewTextBoxColumn";
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видыВкладовBindingSource
            // 
            this.видыВкладовBindingSource.DataMember = "ВидыВкладов";
            this.видыВкладовBindingSource.DataSource = this.банкDataSet;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(188, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(364, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // видыВкладовTableAdapter
            // 
            this.видыВкладовTableAdapter.ClearBeforeFill = true;
            // 
            // обменныйКурсВалютTableAdapter
            // 
            this.обменныйКурсВалютTableAdapter.ClearBeforeFill = true;
            // 
            // Сontribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 471);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Сontribution";
            this.Text = "Вид вклада";
            this.Load += new System.EventHandler(this.Сontribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обменныйКурсВалютBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыВкладовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private БанкDataSet банкDataSet;
        private System.Windows.Forms.BindingSource видыВкладовBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private БанкDataSetTableAdapters.ВидыВкладовTableAdapter видыВкладовTableAdapter;
        private System.Windows.Forms.BindingSource обменныйКурсВалютBindingSource;
        private БанкDataSetTableAdapters.ОбменныйКурсВалютTableAdapter обменныйКурсВалютTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВидаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальныйСрокВкладаМесDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минСуммаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодвалютыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентнаяСтавкаГодоваяDataGridViewTextBoxColumn;
    }
}