namespace Bank
{
    partial class RegistrationСontribution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.банкDataSet = new Bank.БанкDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.view_1TableAdapter = new Bank.БанкDataSetTableAdapters.View_1TableAdapter();
            this.видыВкладовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видыВкладовTableAdapter = new Bank.БанкDataSetTableAdapters.ВидыВкладовTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВидаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.датаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыВкладовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.клиентыDataGridViewTextBoxColumn,
            this.кодВидаВкладаDataGridViewTextBoxColumn,
            this.датаВкладаDataGridViewTextBoxColumn,
            this.датаВозвратаDataGridViewTextBoxColumn,
            this.суммаВкладаDataGridViewTextBoxColumn,
            this.статусВкладаDataGridViewTextBoxColumn,
            this.сотрудникиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.view1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(704, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.банкDataSet;
            // 
            // банкDataSet
            // 
            this.банкDataSet.DataSetName = "БанкDataSet";
            this.банкDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(417, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить данные";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(254, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(91, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // видыВкладовBindingSource
            // 
            this.видыВкладовBindingSource.DataMember = "ВидыВкладов";
            this.видыВкладовBindingSource.DataSource = this.банкDataSet;
            // 
            // видыВкладовTableAdapter
            // 
            this.видыВкладовTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодРегистрацииВклада";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодРегистрацииВклада";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // клиентыDataGridViewTextBoxColumn
            // 
            this.клиентыDataGridViewTextBoxColumn.DataPropertyName = "Клиенты";
            this.клиентыDataGridViewTextBoxColumn.HeaderText = "Клиенты";
            this.клиентыDataGridViewTextBoxColumn.Name = "клиентыDataGridViewTextBoxColumn";
            this.клиентыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодВидаВкладаDataGridViewTextBoxColumn
            // 
            this.кодВидаВкладаDataGridViewTextBoxColumn.DataPropertyName = "КодВидаВклада";
            this.кодВидаВкладаDataGridViewTextBoxColumn.DataSource = this.видыВкладовBindingSource;
            this.кодВидаВкладаDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.кодВидаВкладаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.кодВидаВкладаDataGridViewTextBoxColumn.HeaderText = "ВидВклада";
            this.кодВидаВкладаDataGridViewTextBoxColumn.Name = "кодВидаВкладаDataGridViewTextBoxColumn";
            this.кодВидаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодВидаВкладаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодВидаВкладаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодВидаВкладаDataGridViewTextBoxColumn.ValueMember = "КодВидаВклада";
            // 
            // датаВкладаDataGridViewTextBoxColumn
            // 
            this.датаВкладаDataGridViewTextBoxColumn.DataPropertyName = "ДатаВклада";
            this.датаВкладаDataGridViewTextBoxColumn.HeaderText = "ДатаВклада";
            this.датаВкладаDataGridViewTextBoxColumn.Name = "датаВкладаDataGridViewTextBoxColumn";
            this.датаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВозвратаDataGridViewTextBoxColumn
            // 
            this.датаВозвратаDataGridViewTextBoxColumn.DataPropertyName = "ДатаВозврата";
            this.датаВозвратаDataGridViewTextBoxColumn.HeaderText = "ДатаВозврата";
            this.датаВозвратаDataGridViewTextBoxColumn.Name = "датаВозвратаDataGridViewTextBoxColumn";
            this.датаВозвратаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаВкладаDataGridViewTextBoxColumn
            // 
            this.суммаВкладаDataGridViewTextBoxColumn.DataPropertyName = "СуммаВклада";
            this.суммаВкладаDataGridViewTextBoxColumn.HeaderText = "СуммаВклада";
            this.суммаВкладаDataGridViewTextBoxColumn.Name = "суммаВкладаDataGridViewTextBoxColumn";
            this.суммаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусВкладаDataGridViewTextBoxColumn
            // 
            this.статусВкладаDataGridViewTextBoxColumn.DataPropertyName = "СтатусВклада";
            this.статусВкладаDataGridViewTextBoxColumn.HeaderText = "СтатусВклада";
            this.статусВкладаDataGridViewTextBoxColumn.Name = "статусВкладаDataGridViewTextBoxColumn";
            this.статусВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникиDataGridViewTextBoxColumn
            // 
            this.сотрудникиDataGridViewTextBoxColumn.DataPropertyName = "Сотрудники";
            this.сотрудникиDataGridViewTextBoxColumn.HeaderText = "Сотрудники";
            this.сотрудникиDataGridViewTextBoxColumn.Name = "сотрудникиDataGridViewTextBoxColumn";
            this.сотрудникиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RegistrationСontribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 466);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegistrationСontribution";
            this.Text = "Регистрация вкладов";
            this.Load += new System.EventHandler(this.RegistrationСontribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыВкладовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРегистрацииВкладаDataGridViewTextBoxColumn;
        private БанкDataSet банкDataSet;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private БанкDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.BindingSource видыВкладовBindingSource;
        private БанкDataSetTableAdapters.ВидыВкладовTableAdapter видыВкладовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодВидаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникиDataGridViewTextBoxColumn;
    }
}