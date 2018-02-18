namespace Contractor
{
    partial class ContragentForm
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.account_grainDataSet = Account_grainDataSet();
            this.contragentGridView = new System.Windows.Forms.DataGridView();
            this.contragentGroupBox = new System.Windows.Forms.GroupBox();
            this.showAllContrButton = new System.Windows.Forms.Button();
            this.findContragentButton = new System.Windows.Forms.Button();
            this.contragentTextBox = new System.Windows.Forms.TextBox();
            this.nameContagentLabel = new System.Windows.Forms.Label();
            this.addContragentButton = new System.Windows.Forms.Button();
            this.changeContragentButton = new System.Windows.Forms.Button();
            this.removeContagentButton = new System.Windows.Forms.Button();
            this.сontractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сontractorTableAdapter = Account_grainDataSetTableAdapters.СontractorTableAdapter();
            this.reportButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcontractorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecontractorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subdivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailindexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_grainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contragentGridView)).BeginInit();
            this.contragentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сontractorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.account_grainDataSet;
            this.bindingSource1.Position = 0;
            // 
            // account_grainDataSet
            // 
            this.account_grainDataSet.DataSetName = "Account_grainDataSet";
            this.account_grainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contragentGridView
            // 
            this.contragentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contragentGridView.Location = new System.Drawing.Point(3, 95);
            this.contragentGridView.Name = "contragentGridView";
            this.contragentGridView.Size = new System.Drawing.Size(848, 259);
            this.contragentGridView.TabIndex = 0;
            // 
            // contragentGroupBox
            // 
            this.contragentGroupBox.Controls.Add(this.showAllContrButton);
            this.contragentGroupBox.Controls.Add(this.findContragentButton);
            this.contragentGroupBox.Controls.Add(this.contragentTextBox);
            this.contragentGroupBox.Controls.Add(this.nameContagentLabel);
            this.contragentGroupBox.Location = new System.Drawing.Point(12, 1);
            this.contragentGroupBox.Name = "contragentGroupBox";
            this.contragentGroupBox.Size = new System.Drawing.Size(641, 59);
            this.contragentGroupBox.TabIndex = 1;
            this.contragentGroupBox.TabStop = false;
            this.contragentGroupBox.Text = "Поиск";
            // 
            // showAllContrButton
            // 
            this.showAllContrButton.Location = new System.Drawing.Point(494, 20);
            this.showAllContrButton.Name = "showAllContrButton";
            this.showAllContrButton.Size = new System.Drawing.Size(141, 23);
            this.showAllContrButton.TabIndex = 6;
            this.showAllContrButton.Text = "Показать весь список";
            this.showAllContrButton.UseVisualStyleBackColor = true;
            this.showAllContrButton.Click += new System.EventHandler(this.showAllContrButton_Click);
            // 
            // findContragentButton
            // 
            this.findContragentButton.Location = new System.Drawing.Point(403, 20);
            this.findContragentButton.Name = "findContragentButton";
            this.findContragentButton.Size = new System.Drawing.Size(75, 23);
            this.findContragentButton.TabIndex = 2;
            this.findContragentButton.Text = "Найти";
            this.findContragentButton.UseVisualStyleBackColor = true;
            this.findContragentButton.Click += new System.EventHandler(this.findContragentButton_Click_1);
            // 
            // contragentTextBox
            // 
            this.contragentTextBox.Location = new System.Drawing.Point(166, 20);
            this.contragentTextBox.Name = "contragentTextBox";
            this.contragentTextBox.Size = new System.Drawing.Size(230, 20);
            this.contragentTextBox.TabIndex = 1;
            // 
            // nameContagentLabel
            // 
            this.nameContagentLabel.AutoSize = true;
            this.nameContagentLabel.Location = new System.Drawing.Point(10, 20);
            this.nameContagentLabel.Name = "nameContagentLabel";
            this.nameContagentLabel.Size = new System.Drawing.Size(149, 13);
            this.nameContagentLabel.TabIndex = 0;
            this.nameContagentLabel.Text = "Наименование контрагента";
            // 
            // addContragentButton
            // 
            this.addContragentButton.Location = new System.Drawing.Point(9, 66);
            this.addContragentButton.Name = "addContragentButton";
            this.addContragentButton.Size = new System.Drawing.Size(75, 23);
            this.addContragentButton.TabIndex = 2;
            this.addContragentButton.Text = "Добавить";
            this.addContragentButton.UseVisualStyleBackColor = true;
            this.addContragentButton.Click += new System.EventHandler(this.addContragentButton_Click);
            // 
            // changeContragentButton
            // 
            this.changeContragentButton.Location = new System.Drawing.Point(108, 66);
            this.changeContragentButton.Name = "changeContragentButton";
            this.changeContragentButton.Size = new System.Drawing.Size(75, 23);
            this.changeContragentButton.TabIndex = 3;
            this.changeContragentButton.Text = "Изменить";
            this.changeContragentButton.UseVisualStyleBackColor = true;
            this.changeContragentButton.Click += new System.EventHandler(this.changeContragentButton_Click);
            // 
            // removeContagentButton
            // 
            this.removeContagentButton.Location = new System.Drawing.Point(207, 66);
            this.removeContagentButton.Name = "removeContagentButton";
            this.removeContagentButton.Size = new System.Drawing.Size(75, 23);
            this.removeContagentButton.TabIndex = 4;
            this.removeContagentButton.Text = "Удалить";
            this.removeContagentButton.UseVisualStyleBackColor = true;
            this.removeContagentButton.Click += new System.EventHandler(this.removeContagentButton_Click);
            // 
            // сontractorBindingSource
            // 
            this.сontractorBindingSource.DataMember = "Сontractor";
            this.сontractorBindingSource.DataSource = this.bindingSource1;
            // 
            // сontractorTableAdapter
            // 
            this.сontractorTableAdapter.ClearBeforeFill = true;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(316, 66);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(136, 23);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "Сформировать отчет";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcontractorDataGridViewTextBoxColumn,
            this.namecontractorDataGridViewTextBoxColumn,
            this.subdivisionDataGridViewTextBoxColumn,
            this.juraddressDataGridViewTextBoxColumn,
            this.factaddressDataGridViewTextBoxColumn,
            this.mailindexDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сontractorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(973, 104);
            this.dataGridView1.TabIndex = 7;
            // 
            // idcontractorDataGridViewTextBoxColumn
            // 
            this.idcontractorDataGridViewTextBoxColumn.DataPropertyName = "id_contractor";
            this.idcontractorDataGridViewTextBoxColumn.HeaderText = "id_contractor";
            this.idcontractorDataGridViewTextBoxColumn.Name = "idcontractorDataGridViewTextBoxColumn";
            this.idcontractorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcontractorDataGridViewTextBoxColumn.Visible = false;
            // 
            // namecontractorDataGridViewTextBoxColumn
            // 
            this.namecontractorDataGridViewTextBoxColumn.DataPropertyName = "name_contractor";
            this.namecontractorDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.namecontractorDataGridViewTextBoxColumn.Name = "namecontractorDataGridViewTextBoxColumn";
            this.namecontractorDataGridViewTextBoxColumn.Width = 130;
            // 
            // subdivisionDataGridViewTextBoxColumn
            // 
            this.subdivisionDataGridViewTextBoxColumn.DataPropertyName = "subdivision";
            this.subdivisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.subdivisionDataGridViewTextBoxColumn.Name = "subdivisionDataGridViewTextBoxColumn";
            // 
            // juraddressDataGridViewTextBoxColumn
            // 
            this.juraddressDataGridViewTextBoxColumn.DataPropertyName = "jur_address";
            this.juraddressDataGridViewTextBoxColumn.HeaderText = "Юр. адрес";
            this.juraddressDataGridViewTextBoxColumn.Name = "juraddressDataGridViewTextBoxColumn";
            this.juraddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // factaddressDataGridViewTextBoxColumn
            // 
            this.factaddressDataGridViewTextBoxColumn.DataPropertyName = "fact_address";
            this.factaddressDataGridViewTextBoxColumn.HeaderText = "Факт. адрес";
            this.factaddressDataGridViewTextBoxColumn.Name = "factaddressDataGridViewTextBoxColumn";
            this.factaddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // mailindexDataGridViewTextBoxColumn
            // 
            this.mailindexDataGridViewTextBoxColumn.DataPropertyName = "mail_index";
            this.mailindexDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.mailindexDataGridViewTextBoxColumn.Name = "mailindexDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            // 
            // ContragentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.removeContagentButton);
            this.Controls.Add(this.changeContragentButton);
            this.Controls.Add(this.addContragentButton);
            this.Controls.Add(this.contragentGroupBox);
            this.Controls.Add(this.contragentGridView);
            this.Name = "ContragentForm";
            this.Text = "Контрагенты";
            this.Load += new System.EventHandler(this.ContragentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_grainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contragentGridView)).EndInit();
            this.contragentGroupBox.ResumeLayout(false);
            this.contragentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сontractorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView contragentGridView;
        private System.Windows.Forms.GroupBox contragentGroupBox;
        private System.Windows.Forms.Label nameContagentLabel;
        private System.Windows.Forms.Button findContragentButton;
        private System.Windows.Forms.TextBox contragentTextBox;
        private System.Windows.Forms.Button addContragentButton;
        private System.Windows.Forms.Button changeContragentButton;
        private System.Windows.Forms.Button removeContagentButton;
        private Account_grainDataSet account_grainDataSet;
        private System.Windows.Forms.BindingSource сontractorBindingSource;
        private Account_grainDataSetTableAdapters.СontractorTableAdapter сontractorTableAdapter;
        private System.Windows.Forms.Button showAllContrButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontractorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecontractorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailindexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
    }
}

