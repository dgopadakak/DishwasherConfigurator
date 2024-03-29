﻿namespace DishwasherConfigurator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeViewActionSelecter = new TreeView();
            buttonSelectAction = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            labelTitleThread1 = new Label();
            labelTitleThread2 = new Label();
            labelTitleThread3 = new Label();
            buttonAddThread1 = new Button();
            buttonAddThread2 = new Button();
            buttonAddThread3 = new Button();
            buttonDelThread1 = new Button();
            buttonDelThread2 = new Button();
            buttonDelThread3 = new Button();
            comboBoxComPorts = new ComboBox();
            buttonUpdateComPorts = new Button();
            buttonAcceptCom = new Button();
            buttonCancelCom = new Button();
            buttonSendProgramByCom = new Button();
            buttonReadProgramByCom = new Button();
            buttonReadProgramFromFile = new Button();
            buttonWriteProgramToFile = new Button();
            buttonEditThread1 = new Button();
            buttonEditThread2 = new Button();
            buttonEditThread3 = new Button();
            buttonSelectActionCancel = new Button();
            groupBoxAddAction = new GroupBox();
            textBoxTime = new TextBox();
            labelTime = new Label();
            labelSelectedAction = new Label();
            groupBoxEditAction = new GroupBox();
            buttonCancelEdit = new Button();
            buttonConfirmEdit = new Button();
            labelTimeEdit = new Label();
            textBoxTimeEdit = new TextBox();
            labelNameEdit = new Label();
            buttonAddAfterSelectThread1 = new Button();
            buttonAddAfterSelectThread2 = new Button();
            buttonAddAfterSelectThread3 = new Button();
            groupBoxCalcul = new GroupBox();
            buttonSecToMinCal = new Button();
            labelMinOutputCal = new Label();
            textBoxSecInputCal = new TextBox();
            labelSecInputCal = new Label();
            buttonMinToSecCal = new Button();
            labelSecOutputCal = new Label();
            textBoxMinInputCal = new TextBox();
            labelMinInputCal = new Label();
            buttonExportThread1ToDOCX = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBoxAddAction.SuspendLayout();
            groupBoxEditAction.SuspendLayout();
            groupBoxCalcul.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewActionSelecter
            // 
            treeViewActionSelecter.HideSelection = false;
            treeViewActionSelecter.Location = new Point(12, 12);
            treeViewActionSelecter.Name = "treeViewActionSelecter";
            treeViewActionSelecter.Size = new Size(290, 537);
            treeViewActionSelecter.TabIndex = 0;
            // 
            // buttonSelectAction
            // 
            buttonSelectAction.Location = new Point(6, 22);
            buttonSelectAction.Name = "buttonSelectAction";
            buttonSelectAction.Size = new Size(170, 23);
            buttonSelectAction.TabIndex = 1;
            buttonSelectAction.Text = "Выбрать";
            buttonSelectAction.UseVisualStyleBackColor = true;
            buttonSelectAction.Click += buttonSelectAction_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(496, 27);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(238, 464);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "№";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 26;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Название";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 65;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Время";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 48;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            dataGridView2.Location = new Point(740, 27);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(238, 464);
            dataGridView2.TabIndex = 3;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "№";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 26;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Название";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column5.Width = 65;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Время";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.False;
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column6.Width = 48;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9 });
            dataGridView3.Location = new Point(984, 27);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(238, 464);
            dataGridView3.TabIndex = 4;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "№";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.False;
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column7.Width = 26;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Название";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Resizable = DataGridViewTriState.False;
            Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column8.Width = 65;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Время";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Resizable = DataGridViewTriState.False;
            Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column9.Width = 48;
            // 
            // labelTitleThread1
            // 
            labelTitleThread1.AutoSize = true;
            labelTitleThread1.Location = new Point(496, 9);
            labelTitleThread1.Name = "labelTitleThread1";
            labelTitleThread1.Size = new Size(98, 15);
            labelTitleThread1.TabIndex = 5;
            labelTitleThread1.Text = "1. Первый поток";
            // 
            // labelTitleThread2
            // 
            labelTitleThread2.AutoSize = true;
            labelTitleThread2.Location = new Point(740, 9);
            labelTitleThread2.Name = "labelTitleThread2";
            labelTitleThread2.Size = new Size(94, 15);
            labelTitleThread2.TabIndex = 6;
            labelTitleThread2.Text = "2. Второй поток";
            // 
            // labelTitleThread3
            // 
            labelTitleThread3.AutoSize = true;
            labelTitleThread3.Location = new Point(984, 9);
            labelTitleThread3.Name = "labelTitleThread3";
            labelTitleThread3.Size = new Size(92, 15);
            labelTitleThread3.TabIndex = 7;
            labelTitleThread3.Text = "3. Третий поток";
            // 
            // buttonAddThread1
            // 
            buttonAddThread1.Enabled = false;
            buttonAddThread1.Location = new Point(496, 497);
            buttonAddThread1.Name = "buttonAddThread1";
            buttonAddThread1.Size = new Size(238, 23);
            buttonAddThread1.TabIndex = 8;
            buttonAddThread1.Text = "Добавить в конец";
            buttonAddThread1.UseVisualStyleBackColor = true;
            buttonAddThread1.Click += buttonAddThread1_Click;
            // 
            // buttonAddThread2
            // 
            buttonAddThread2.Enabled = false;
            buttonAddThread2.Location = new Point(740, 497);
            buttonAddThread2.Name = "buttonAddThread2";
            buttonAddThread2.Size = new Size(238, 23);
            buttonAddThread2.TabIndex = 9;
            buttonAddThread2.Text = "Добавить в конец";
            buttonAddThread2.UseVisualStyleBackColor = true;
            buttonAddThread2.Click += buttonAddThread2_Click;
            // 
            // buttonAddThread3
            // 
            buttonAddThread3.Enabled = false;
            buttonAddThread3.Location = new Point(984, 497);
            buttonAddThread3.Name = "buttonAddThread3";
            buttonAddThread3.Size = new Size(238, 23);
            buttonAddThread3.TabIndex = 10;
            buttonAddThread3.Text = "Добавить в конец";
            buttonAddThread3.UseVisualStyleBackColor = true;
            buttonAddThread3.Click += buttonAddThread3_Click;
            // 
            // buttonDelThread1
            // 
            buttonDelThread1.Enabled = false;
            buttonDelThread1.Location = new Point(496, 584);
            buttonDelThread1.Name = "buttonDelThread1";
            buttonDelThread1.Size = new Size(238, 23);
            buttonDelThread1.TabIndex = 11;
            buttonDelThread1.Text = "Удалить выделенное";
            buttonDelThread1.UseVisualStyleBackColor = true;
            buttonDelThread1.Click += buttonDelThread1_Click;
            // 
            // buttonDelThread2
            // 
            buttonDelThread2.Enabled = false;
            buttonDelThread2.Location = new Point(740, 584);
            buttonDelThread2.Name = "buttonDelThread2";
            buttonDelThread2.Size = new Size(238, 23);
            buttonDelThread2.TabIndex = 12;
            buttonDelThread2.Text = "Удалить выделенное";
            buttonDelThread2.UseVisualStyleBackColor = true;
            buttonDelThread2.Click += buttonDelThread2_Click;
            // 
            // buttonDelThread3
            // 
            buttonDelThread3.Enabled = false;
            buttonDelThread3.Location = new Point(984, 584);
            buttonDelThread3.Name = "buttonDelThread3";
            buttonDelThread3.Size = new Size(238, 23);
            buttonDelThread3.TabIndex = 13;
            buttonDelThread3.Text = "Удалить выделенное";
            buttonDelThread3.UseVisualStyleBackColor = true;
            buttonDelThread3.Click += buttonDelThread3_Click;
            // 
            // comboBoxComPorts
            // 
            comboBoxComPorts.FormattingEnabled = true;
            comboBoxComPorts.Location = new Point(12, 556);
            comboBoxComPorts.Name = "comboBoxComPorts";
            comboBoxComPorts.Size = new Size(168, 23);
            comboBoxComPorts.TabIndex = 14;
            comboBoxComPorts.Text = "Выберете COM порт";
            // 
            // buttonUpdateComPorts
            // 
            buttonUpdateComPorts.Location = new Point(186, 556);
            buttonUpdateComPorts.Name = "buttonUpdateComPorts";
            buttonUpdateComPorts.Size = new Size(116, 23);
            buttonUpdateComPorts.TabIndex = 15;
            buttonUpdateComPorts.Text = "Обновить";
            buttonUpdateComPorts.UseVisualStyleBackColor = true;
            buttonUpdateComPorts.Click += buttonUpdateComPorts_Click;
            // 
            // buttonAcceptCom
            // 
            buttonAcceptCom.Location = new Point(12, 585);
            buttonAcceptCom.Name = "buttonAcceptCom";
            buttonAcceptCom.Size = new Size(142, 23);
            buttonAcceptCom.TabIndex = 16;
            buttonAcceptCom.Text = "Подтвердить";
            buttonAcceptCom.UseVisualStyleBackColor = true;
            buttonAcceptCom.Click += buttonAcceptCom_Click;
            // 
            // buttonCancelCom
            // 
            buttonCancelCom.Enabled = false;
            buttonCancelCom.Location = new Point(160, 584);
            buttonCancelCom.Name = "buttonCancelCom";
            buttonCancelCom.Size = new Size(142, 23);
            buttonCancelCom.TabIndex = 17;
            buttonCancelCom.Text = "Отмена";
            buttonCancelCom.UseVisualStyleBackColor = true;
            buttonCancelCom.Click += buttonCancelCom_Click;
            // 
            // buttonSendProgramByCom
            // 
            buttonSendProgramByCom.Enabled = false;
            buttonSendProgramByCom.Location = new Point(160, 613);
            buttonSendProgramByCom.Name = "buttonSendProgramByCom";
            buttonSendProgramByCom.Size = new Size(142, 23);
            buttonSendProgramByCom.TabIndex = 18;
            buttonSendProgramByCom.Text = "Залить прошивку";
            buttonSendProgramByCom.UseVisualStyleBackColor = true;
            buttonSendProgramByCom.Click += buttonSendProgramByCom_Click;
            // 
            // buttonReadProgramByCom
            // 
            buttonReadProgramByCom.Enabled = false;
            buttonReadProgramByCom.Location = new Point(12, 613);
            buttonReadProgramByCom.Name = "buttonReadProgramByCom";
            buttonReadProgramByCom.Size = new Size(142, 23);
            buttonReadProgramByCom.TabIndex = 19;
            buttonReadProgramByCom.Text = "Прочитать прошивку";
            buttonReadProgramByCom.UseVisualStyleBackColor = true;
            buttonReadProgramByCom.Click += buttonReadProgramByCom_Click;
            // 
            // buttonReadProgramFromFile
            // 
            buttonReadProgramFromFile.Location = new Point(696, 626);
            buttonReadProgramFromFile.Name = "buttonReadProgramFromFile";
            buttonReadProgramFromFile.Size = new Size(260, 23);
            buttonReadProgramFromFile.TabIndex = 20;
            buttonReadProgramFromFile.Text = "Открыть программу из файла";
            buttonReadProgramFromFile.UseVisualStyleBackColor = true;
            buttonReadProgramFromFile.Click += buttonReadProgramFromFile_Click;
            // 
            // buttonWriteProgramToFile
            // 
            buttonWriteProgramToFile.Location = new Point(962, 626);
            buttonWriteProgramToFile.Name = "buttonWriteProgramToFile";
            buttonWriteProgramToFile.Size = new Size(260, 23);
            buttonWriteProgramToFile.TabIndex = 21;
            buttonWriteProgramToFile.Text = "Сохранить программу в файл";
            buttonWriteProgramToFile.UseVisualStyleBackColor = true;
            buttonWriteProgramToFile.Click += buttonWriteProgramToFile_Click;
            // 
            // buttonEditThread1
            // 
            buttonEditThread1.Enabled = false;
            buttonEditThread1.Location = new Point(496, 555);
            buttonEditThread1.Name = "buttonEditThread1";
            buttonEditThread1.Size = new Size(238, 23);
            buttonEditThread1.TabIndex = 22;
            buttonEditThread1.Text = "Изменить выделенное";
            buttonEditThread1.UseVisualStyleBackColor = true;
            buttonEditThread1.Click += buttonEditThread1_Click;
            // 
            // buttonEditThread2
            // 
            buttonEditThread2.Enabled = false;
            buttonEditThread2.Location = new Point(740, 555);
            buttonEditThread2.Name = "buttonEditThread2";
            buttonEditThread2.Size = new Size(238, 23);
            buttonEditThread2.TabIndex = 23;
            buttonEditThread2.Text = "Изменить выделенное";
            buttonEditThread2.UseVisualStyleBackColor = true;
            buttonEditThread2.Click += buttonEditThread2_Click;
            // 
            // buttonEditThread3
            // 
            buttonEditThread3.Enabled = false;
            buttonEditThread3.Location = new Point(984, 555);
            buttonEditThread3.Name = "buttonEditThread3";
            buttonEditThread3.Size = new Size(238, 23);
            buttonEditThread3.TabIndex = 24;
            buttonEditThread3.Text = "Изменить выделенное";
            buttonEditThread3.UseVisualStyleBackColor = true;
            buttonEditThread3.Click += buttonEditThread3_Click;
            // 
            // buttonSelectActionCancel
            // 
            buttonSelectActionCancel.Enabled = false;
            buttonSelectActionCancel.Location = new Point(6, 114);
            buttonSelectActionCancel.Name = "buttonSelectActionCancel";
            buttonSelectActionCancel.Size = new Size(170, 23);
            buttonSelectActionCancel.TabIndex = 25;
            buttonSelectActionCancel.Text = "Отмена";
            buttonSelectActionCancel.UseVisualStyleBackColor = true;
            buttonSelectActionCancel.Click += buttonSelectActionCancel_Click;
            // 
            // groupBoxAddAction
            // 
            groupBoxAddAction.Controls.Add(textBoxTime);
            groupBoxAddAction.Controls.Add(labelTime);
            groupBoxAddAction.Controls.Add(labelSelectedAction);
            groupBoxAddAction.Controls.Add(buttonSelectAction);
            groupBoxAddAction.Controls.Add(buttonSelectActionCancel);
            groupBoxAddAction.Location = new Point(308, 12);
            groupBoxAddAction.Name = "groupBoxAddAction";
            groupBoxAddAction.Size = new Size(182, 145);
            groupBoxAddAction.TabIndex = 26;
            groupBoxAddAction.TabStop = false;
            groupBoxAddAction.Text = "Добавить действие";
            // 
            // textBoxTime
            // 
            textBoxTime.Enabled = false;
            textBoxTime.Location = new Point(74, 85);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(102, 23);
            textBoxTime.TabIndex = 28;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Enabled = false;
            labelTime.Location = new Point(6, 88);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(62, 15);
            labelTime.TabIndex = 27;
            labelTime.Text = "Время (с):";
            // 
            // labelSelectedAction
            // 
            labelSelectedAction.Location = new Point(6, 48);
            labelSelectedAction.Name = "labelSelectedAction";
            labelSelectedAction.Size = new Size(170, 34);
            labelSelectedAction.TabIndex = 26;
            labelSelectedAction.Text = "Действие не выбрано";
            // 
            // groupBoxEditAction
            // 
            groupBoxEditAction.Controls.Add(buttonCancelEdit);
            groupBoxEditAction.Controls.Add(buttonConfirmEdit);
            groupBoxEditAction.Controls.Add(labelTimeEdit);
            groupBoxEditAction.Controls.Add(textBoxTimeEdit);
            groupBoxEditAction.Controls.Add(labelNameEdit);
            groupBoxEditAction.Location = new Point(308, 307);
            groupBoxEditAction.Name = "groupBoxEditAction";
            groupBoxEditAction.Size = new Size(182, 144);
            groupBoxEditAction.TabIndex = 27;
            groupBoxEditAction.TabStop = false;
            groupBoxEditAction.Text = "Изменить действие";
            groupBoxEditAction.Visible = false;
            // 
            // buttonCancelEdit
            // 
            buttonCancelEdit.Location = new Point(6, 114);
            buttonCancelEdit.Name = "buttonCancelEdit";
            buttonCancelEdit.Size = new Size(170, 23);
            buttonCancelEdit.TabIndex = 4;
            buttonCancelEdit.Text = "Отмена";
            buttonCancelEdit.UseVisualStyleBackColor = true;
            buttonCancelEdit.Click += buttonCancelEdit_Click;
            // 
            // buttonConfirmEdit
            // 
            buttonConfirmEdit.Location = new Point(6, 85);
            buttonConfirmEdit.Name = "buttonConfirmEdit";
            buttonConfirmEdit.Size = new Size(170, 23);
            buttonConfirmEdit.TabIndex = 3;
            buttonConfirmEdit.Text = "Подтвердить";
            buttonConfirmEdit.UseVisualStyleBackColor = true;
            buttonConfirmEdit.Click += buttonConfirmEdit_Click;
            // 
            // labelTimeEdit
            // 
            labelTimeEdit.AutoSize = true;
            labelTimeEdit.Location = new Point(6, 59);
            labelTimeEdit.Name = "labelTimeEdit";
            labelTimeEdit.Size = new Size(62, 15);
            labelTimeEdit.TabIndex = 2;
            labelTimeEdit.Text = "Время (с):";
            // 
            // textBoxTimeEdit
            // 
            textBoxTimeEdit.Location = new Point(74, 56);
            textBoxTimeEdit.Name = "textBoxTimeEdit";
            textBoxTimeEdit.Size = new Size(102, 23);
            textBoxTimeEdit.TabIndex = 1;
            // 
            // labelNameEdit
            // 
            labelNameEdit.Location = new Point(6, 19);
            labelNameEdit.Name = "labelNameEdit";
            labelNameEdit.Size = new Size(170, 34);
            labelNameEdit.TabIndex = 0;
            labelNameEdit.Text = "Название действия";
            // 
            // buttonAddAfterSelectThread1
            // 
            buttonAddAfterSelectThread1.Enabled = false;
            buttonAddAfterSelectThread1.Location = new Point(496, 526);
            buttonAddAfterSelectThread1.Name = "buttonAddAfterSelectThread1";
            buttonAddAfterSelectThread1.Size = new Size(238, 23);
            buttonAddAfterSelectThread1.TabIndex = 28;
            buttonAddAfterSelectThread1.Text = "Добавить после выделенного";
            buttonAddAfterSelectThread1.UseVisualStyleBackColor = true;
            buttonAddAfterSelectThread1.Click += buttonAddAfterSelectThread1_Click;
            // 
            // buttonAddAfterSelectThread2
            // 
            buttonAddAfterSelectThread2.Enabled = false;
            buttonAddAfterSelectThread2.Location = new Point(740, 526);
            buttonAddAfterSelectThread2.Name = "buttonAddAfterSelectThread2";
            buttonAddAfterSelectThread2.Size = new Size(238, 23);
            buttonAddAfterSelectThread2.TabIndex = 29;
            buttonAddAfterSelectThread2.Text = "Добавить после выделенного";
            buttonAddAfterSelectThread2.UseVisualStyleBackColor = true;
            buttonAddAfterSelectThread2.Click += buttonAddAfterSelectThread2_Click;
            // 
            // buttonAddAfterSelectThread3
            // 
            buttonAddAfterSelectThread3.Enabled = false;
            buttonAddAfterSelectThread3.Location = new Point(984, 526);
            buttonAddAfterSelectThread3.Name = "buttonAddAfterSelectThread3";
            buttonAddAfterSelectThread3.Size = new Size(238, 23);
            buttonAddAfterSelectThread3.TabIndex = 30;
            buttonAddAfterSelectThread3.Text = "Добавить после выделенного";
            buttonAddAfterSelectThread3.UseVisualStyleBackColor = true;
            buttonAddAfterSelectThread3.Click += buttonAddAfterSelectThread3_Click;
            // 
            // groupBoxCalcul
            // 
            groupBoxCalcul.Controls.Add(buttonSecToMinCal);
            groupBoxCalcul.Controls.Add(labelMinOutputCal);
            groupBoxCalcul.Controls.Add(textBoxSecInputCal);
            groupBoxCalcul.Controls.Add(labelSecInputCal);
            groupBoxCalcul.Controls.Add(buttonMinToSecCal);
            groupBoxCalcul.Controls.Add(labelSecOutputCal);
            groupBoxCalcul.Controls.Add(textBoxMinInputCal);
            groupBoxCalcul.Controls.Add(labelMinInputCal);
            groupBoxCalcul.Location = new Point(308, 163);
            groupBoxCalcul.Name = "groupBoxCalcul";
            groupBoxCalcul.Size = new Size(182, 138);
            groupBoxCalcul.TabIndex = 31;
            groupBoxCalcul.TabStop = false;
            groupBoxCalcul.Text = "Калькулятор";
            // 
            // buttonSecToMinCal
            // 
            buttonSecToMinCal.Location = new Point(6, 109);
            buttonSecToMinCal.Name = "buttonSecToMinCal";
            buttonSecToMinCal.Size = new Size(170, 23);
            buttonSecToMinCal.TabIndex = 7;
            buttonSecToMinCal.Text = "Рассчитать";
            buttonSecToMinCal.UseVisualStyleBackColor = true;
            buttonSecToMinCal.Click += buttonSecToMinCal_Click;
            // 
            // labelMinOutputCal
            // 
            labelMinOutputCal.AutoSize = true;
            labelMinOutputCal.Location = new Point(104, 83);
            labelMinOutputCal.Name = "labelMinOutputCal";
            labelMinOutputCal.Size = new Size(53, 15);
            labelMinOutputCal.TabIndex = 6;
            labelMinOutputCal.Text = "= 0 мин.";
            // 
            // textBoxSecInputCal
            // 
            textBoxSecInputCal.Location = new Point(28, 80);
            textBoxSecInputCal.Name = "textBoxSecInputCal";
            textBoxSecInputCal.Size = new Size(70, 23);
            textBoxSecInputCal.TabIndex = 5;
            // 
            // labelSecInputCal
            // 
            labelSecInputCal.AutoSize = true;
            labelSecInputCal.Location = new Point(6, 83);
            labelSecInputCal.Name = "labelSecInputCal";
            labelSecInputCal.Size = new Size(16, 15);
            labelSecInputCal.TabIndex = 4;
            labelSecInputCal.Text = "с:";
            // 
            // buttonMinToSecCal
            // 
            buttonMinToSecCal.Location = new Point(6, 51);
            buttonMinToSecCal.Name = "buttonMinToSecCal";
            buttonMinToSecCal.Size = new Size(170, 23);
            buttonMinToSecCal.TabIndex = 3;
            buttonMinToSecCal.Text = "Рассчитать";
            buttonMinToSecCal.UseVisualStyleBackColor = true;
            buttonMinToSecCal.Click += buttonMinToSecCal_Click;
            // 
            // labelSecOutputCal
            // 
            labelSecOutputCal.AutoSize = true;
            labelSecOutputCal.Location = new Point(104, 25);
            labelSecOutputCal.Name = "labelSecOutputCal";
            labelSecOutputCal.Size = new Size(33, 15);
            labelSecOutputCal.TabIndex = 2;
            labelSecOutputCal.Text = "= 0 с";
            // 
            // textBoxMinInputCal
            // 
            textBoxMinInputCal.Location = new Point(50, 22);
            textBoxMinInputCal.Name = "textBoxMinInputCal";
            textBoxMinInputCal.Size = new Size(48, 23);
            textBoxMinInputCal.TabIndex = 1;
            // 
            // labelMinInputCal
            // 
            labelMinInputCal.AutoSize = true;
            labelMinInputCal.Location = new Point(6, 25);
            labelMinInputCal.Name = "labelMinInputCal";
            labelMinInputCal.Size = new Size(38, 15);
            labelMinInputCal.TabIndex = 0;
            labelMinInputCal.Text = "Мин.:";
            // 
            // buttonExportThread1ToDOCX
            // 
            buttonExportThread1ToDOCX.Location = new Point(442, 626);
            buttonExportThread1ToDOCX.Name = "buttonExportThread1ToDOCX";
            buttonExportThread1ToDOCX.Size = new Size(248, 23);
            buttonExportThread1ToDOCX.TabIndex = 32;
            buttonExportThread1ToDOCX.Text = "Экспорт первого потока в .docx";
            buttonExportThread1ToDOCX.UseVisualStyleBackColor = true;
            buttonExportThread1ToDOCX.Click += buttonExportThread1ToDOCX_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1234, 661);
            Controls.Add(buttonExportThread1ToDOCX);
            Controls.Add(groupBoxCalcul);
            Controls.Add(buttonAddAfterSelectThread3);
            Controls.Add(buttonAddAfterSelectThread2);
            Controls.Add(buttonAddAfterSelectThread1);
            Controls.Add(groupBoxEditAction);
            Controls.Add(groupBoxAddAction);
            Controls.Add(buttonEditThread3);
            Controls.Add(buttonEditThread2);
            Controls.Add(buttonEditThread1);
            Controls.Add(buttonWriteProgramToFile);
            Controls.Add(buttonReadProgramFromFile);
            Controls.Add(buttonReadProgramByCom);
            Controls.Add(buttonSendProgramByCom);
            Controls.Add(buttonCancelCom);
            Controls.Add(buttonAcceptCom);
            Controls.Add(buttonUpdateComPorts);
            Controls.Add(comboBoxComPorts);
            Controls.Add(buttonDelThread3);
            Controls.Add(buttonDelThread2);
            Controls.Add(buttonDelThread1);
            Controls.Add(buttonAddThread3);
            Controls.Add(buttonAddThread2);
            Controls.Add(buttonAddThread1);
            Controls.Add(labelTitleThread3);
            Controls.Add(labelTitleThread2);
            Controls.Add(labelTitleThread1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(treeViewActionSelecter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Конфигуратор посудомойки";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBoxAddAction.ResumeLayout(false);
            groupBoxAddAction.PerformLayout();
            groupBoxEditAction.ResumeLayout(false);
            groupBoxEditAction.PerformLayout();
            groupBoxCalcul.ResumeLayout(false);
            groupBoxCalcul.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewActionSelecter;
        private Button buttonSelectAction;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label labelTitleThread1;
        private Label labelTitleThread2;
        private Label labelTitleThread3;
        private Button buttonAddThread1;
        private Button buttonAddThread2;
        private Button buttonAddThread3;
        private Button buttonDelThread1;
        private Button buttonDelThread2;
        private Button buttonDelThread3;
        private ComboBox comboBoxComPorts;
        private Button buttonUpdateComPorts;
        private Button buttonAcceptCom;
        private Button buttonCancelCom;
        private Button buttonSendProgramByCom;
        private Button buttonReadProgramByCom;
        private Button buttonReadProgramFromFile;
        private Button buttonWriteProgramToFile;
        private Button buttonEditThread1;
        private Button buttonEditThread2;
        private Button buttonEditThread3;
        private Button buttonSelectActionCancel;
        private GroupBox groupBoxAddAction;
        private GroupBox groupBoxEditAction;
        private Label labelSelectedAction;
        private Label labelTime;
        private TextBox textBoxTime;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button buttonAddAfterSelectThread1;
        private Button buttonAddAfterSelectThread2;
        private Button buttonAddAfterSelectThread3;
        private GroupBox groupBoxCalcul;
        private Label labelSecOutputCal;
        private TextBox textBoxMinInputCal;
        private Label labelMinInputCal;
        private Button buttonMinToSecCal;
        private Button buttonSecToMinCal;
        private Label labelMinOutputCal;
        private TextBox textBoxSecInputCal;
        private Label labelSecInputCal;
        private Button buttonCancelEdit;
        private Button buttonConfirmEdit;
        private Label labelTimeEdit;
        private TextBox textBoxTimeEdit;
        private Label labelNameEdit;
        private Button buttonExportThread1ToDOCX;
    }
}