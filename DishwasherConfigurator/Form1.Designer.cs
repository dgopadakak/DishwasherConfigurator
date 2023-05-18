namespace DishwasherConfigurator
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBoxAddAction.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewActionSelecter
            // 
            treeViewActionSelecter.HideSelection = false;
            treeViewActionSelecter.Location = new Point(12, 12);
            treeViewActionSelecter.Name = "treeViewActionSelecter";
            treeViewActionSelecter.Size = new Size(274, 537);
            treeViewActionSelecter.TabIndex = 0;
            // 
            // buttonSelectAction
            // 
            buttonSelectAction.Location = new Point(6, 22);
            buttonSelectAction.Name = "buttonSelectAction";
            buttonSelectAction.Size = new Size(171, 23);
            buttonSelectAction.TabIndex = 1;
            buttonSelectAction.Text = "Выбрать";
            buttonSelectAction.UseVisualStyleBackColor = true;
            buttonSelectAction.Click += buttonSelectAction_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(481, 27);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(243, 493);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "№";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 45;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Название";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 84;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Время";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 67;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            dataGridView2.Location = new Point(730, 27);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(243, 493);
            dataGridView2.TabIndex = 3;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "№";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.Width = 45;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Название";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.Width = 84;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Время";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.False;
            Column6.Width = 67;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9 });
            dataGridView3.Location = new Point(979, 27);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(243, 493);
            dataGridView3.TabIndex = 4;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "№";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.False;
            Column7.Width = 45;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Название";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Resizable = DataGridViewTriState.False;
            Column8.Width = 84;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Время";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Resizable = DataGridViewTriState.False;
            Column9.Width = 67;
            // 
            // labelTitleThread1
            // 
            labelTitleThread1.AutoSize = true;
            labelTitleThread1.Location = new Point(481, 9);
            labelTitleThread1.Name = "labelTitleThread1";
            labelTitleThread1.Size = new Size(98, 15);
            labelTitleThread1.TabIndex = 5;
            labelTitleThread1.Text = "1. Первый поток";
            // 
            // labelTitleThread2
            // 
            labelTitleThread2.AutoSize = true;
            labelTitleThread2.Location = new Point(730, 9);
            labelTitleThread2.Name = "labelTitleThread2";
            labelTitleThread2.Size = new Size(94, 15);
            labelTitleThread2.TabIndex = 6;
            labelTitleThread2.Text = "2. Второй поток";
            // 
            // labelTitleThread3
            // 
            labelTitleThread3.AutoSize = true;
            labelTitleThread3.Location = new Point(979, 9);
            labelTitleThread3.Name = "labelTitleThread3";
            labelTitleThread3.Size = new Size(92, 15);
            labelTitleThread3.TabIndex = 7;
            labelTitleThread3.Text = "3. Третий поток";
            // 
            // buttonAddThread1
            // 
            buttonAddThread1.Enabled = false;
            buttonAddThread1.Location = new Point(481, 526);
            buttonAddThread1.Name = "buttonAddThread1";
            buttonAddThread1.Size = new Size(243, 23);
            buttonAddThread1.TabIndex = 8;
            buttonAddThread1.Text = "Добавить сюда";
            buttonAddThread1.UseVisualStyleBackColor = true;
            buttonAddThread1.Click += buttonAddThread1_Click;
            // 
            // buttonAddThread2
            // 
            buttonAddThread2.Enabled = false;
            buttonAddThread2.Location = new Point(730, 526);
            buttonAddThread2.Name = "buttonAddThread2";
            buttonAddThread2.Size = new Size(243, 23);
            buttonAddThread2.TabIndex = 9;
            buttonAddThread2.Text = "Добавить сюда";
            buttonAddThread2.UseVisualStyleBackColor = true;
            buttonAddThread2.Click += buttonAddThread2_Click;
            // 
            // buttonAddThread3
            // 
            buttonAddThread3.Enabled = false;
            buttonAddThread3.Location = new Point(979, 526);
            buttonAddThread3.Name = "buttonAddThread3";
            buttonAddThread3.Size = new Size(243, 23);
            buttonAddThread3.TabIndex = 10;
            buttonAddThread3.Text = "Добавить сюда";
            buttonAddThread3.UseVisualStyleBackColor = true;
            buttonAddThread3.Click += buttonAddThread3_Click;
            // 
            // buttonDelThread1
            // 
            buttonDelThread1.Enabled = false;
            buttonDelThread1.Location = new Point(481, 555);
            buttonDelThread1.Name = "buttonDelThread1";
            buttonDelThread1.Size = new Size(243, 23);
            buttonDelThread1.TabIndex = 11;
            buttonDelThread1.Text = "Удалить выделенное";
            buttonDelThread1.UseVisualStyleBackColor = true;
            // 
            // buttonDelThread2
            // 
            buttonDelThread2.Enabled = false;
            buttonDelThread2.Location = new Point(730, 555);
            buttonDelThread2.Name = "buttonDelThread2";
            buttonDelThread2.Size = new Size(243, 23);
            buttonDelThread2.TabIndex = 12;
            buttonDelThread2.Text = "Удалить выделенное";
            buttonDelThread2.UseVisualStyleBackColor = true;
            // 
            // buttonDelThread3
            // 
            buttonDelThread3.Enabled = false;
            buttonDelThread3.Location = new Point(979, 555);
            buttonDelThread3.Name = "buttonDelThread3";
            buttonDelThread3.Size = new Size(243, 23);
            buttonDelThread3.TabIndex = 13;
            buttonDelThread3.Text = "Удалить выделенное";
            buttonDelThread3.UseVisualStyleBackColor = true;
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
            buttonUpdateComPorts.Size = new Size(100, 23);
            buttonUpdateComPorts.TabIndex = 15;
            buttonUpdateComPorts.Text = "Обновить";
            buttonUpdateComPorts.UseVisualStyleBackColor = true;
            buttonUpdateComPorts.Click += buttonUpdateComPorts_Click;
            // 
            // buttonAcceptCom
            // 
            buttonAcceptCom.Location = new Point(12, 585);
            buttonAcceptCom.Name = "buttonAcceptCom";
            buttonAcceptCom.Size = new Size(134, 23);
            buttonAcceptCom.TabIndex = 16;
            buttonAcceptCom.Text = "Подтвердить";
            buttonAcceptCom.UseVisualStyleBackColor = true;
            buttonAcceptCom.Click += buttonAcceptCom_Click;
            // 
            // buttonCancelCom
            // 
            buttonCancelCom.Enabled = false;
            buttonCancelCom.Location = new Point(152, 585);
            buttonCancelCom.Name = "buttonCancelCom";
            buttonCancelCom.Size = new Size(134, 23);
            buttonCancelCom.TabIndex = 17;
            buttonCancelCom.Text = "Отмена";
            buttonCancelCom.UseVisualStyleBackColor = true;
            buttonCancelCom.Click += buttonCancelCom_Click;
            // 
            // buttonSendProgramByCom
            // 
            buttonSendProgramByCom.Enabled = false;
            buttonSendProgramByCom.Location = new Point(12, 614);
            buttonSendProgramByCom.Name = "buttonSendProgramByCom";
            buttonSendProgramByCom.Size = new Size(134, 23);
            buttonSendProgramByCom.TabIndex = 18;
            buttonSendProgramByCom.Text = "Залить прошивку";
            buttonSendProgramByCom.UseVisualStyleBackColor = true;
            buttonSendProgramByCom.Click += buttonSendProgramByCom_Click;
            // 
            // buttonReadProgramByCom
            // 
            buttonReadProgramByCom.Enabled = false;
            buttonReadProgramByCom.Location = new Point(152, 614);
            buttonReadProgramByCom.Name = "buttonReadProgramByCom";
            buttonReadProgramByCom.Size = new Size(134, 23);
            buttonReadProgramByCom.TabIndex = 19;
            buttonReadProgramByCom.Text = "Прочитать прошивку";
            buttonReadProgramByCom.UseVisualStyleBackColor = true;
            buttonReadProgramByCom.Click += buttonReadProgramByCom_Click;
            // 
            // buttonReadProgramFromFile
            // 
            buttonReadProgramFromFile.Location = new Point(1031, 626);
            buttonReadProgramFromFile.Name = "buttonReadProgramFromFile";
            buttonReadProgramFromFile.Size = new Size(191, 23);
            buttonReadProgramFromFile.TabIndex = 20;
            buttonReadProgramFromFile.Text = "Открыть программу из файла";
            buttonReadProgramFromFile.UseVisualStyleBackColor = true;
            // 
            // buttonWriteProgramToFile
            // 
            buttonWriteProgramToFile.Location = new Point(834, 626);
            buttonWriteProgramToFile.Name = "buttonWriteProgramToFile";
            buttonWriteProgramToFile.Size = new Size(191, 23);
            buttonWriteProgramToFile.TabIndex = 21;
            buttonWriteProgramToFile.Text = "Сохранить программу в файл";
            buttonWriteProgramToFile.UseVisualStyleBackColor = true;
            // 
            // buttonEditThread1
            // 
            buttonEditThread1.Enabled = false;
            buttonEditThread1.Location = new Point(481, 584);
            buttonEditThread1.Name = "buttonEditThread1";
            buttonEditThread1.Size = new Size(243, 23);
            buttonEditThread1.TabIndex = 22;
            buttonEditThread1.Text = "Изменить выделенное";
            buttonEditThread1.UseVisualStyleBackColor = true;
            // 
            // buttonEditThread2
            // 
            buttonEditThread2.Enabled = false;
            buttonEditThread2.Location = new Point(730, 584);
            buttonEditThread2.Name = "buttonEditThread2";
            buttonEditThread2.Size = new Size(243, 23);
            buttonEditThread2.TabIndex = 23;
            buttonEditThread2.Text = "Изменить выделенное";
            buttonEditThread2.UseVisualStyleBackColor = true;
            // 
            // buttonEditThread3
            // 
            buttonEditThread3.Enabled = false;
            buttonEditThread3.Location = new Point(979, 584);
            buttonEditThread3.Name = "buttonEditThread3";
            buttonEditThread3.Size = new Size(243, 23);
            buttonEditThread3.TabIndex = 24;
            buttonEditThread3.Text = "Изменить выделенное";
            buttonEditThread3.UseVisualStyleBackColor = true;
            // 
            // buttonSelectActionCancel
            // 
            buttonSelectActionCancel.Enabled = false;
            buttonSelectActionCancel.Location = new Point(6, 114);
            buttonSelectActionCancel.Name = "buttonSelectActionCancel";
            buttonSelectActionCancel.Size = new Size(171, 23);
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
            groupBoxAddAction.Location = new Point(292, 12);
            groupBoxAddAction.Name = "groupBoxAddAction";
            groupBoxAddAction.Size = new Size(183, 145);
            groupBoxAddAction.TabIndex = 26;
            groupBoxAddAction.TabStop = false;
            groupBoxAddAction.Text = "Добавить действие";
            // 
            // textBoxTime
            // 
            textBoxTime.Enabled = false;
            textBoxTime.Location = new Point(74, 85);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(103, 23);
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
            labelSelectedAction.Size = new Size(171, 34);
            labelSelectedAction.TabIndex = 26;
            labelSelectedAction.Text = "Действие не выбрано";
            // 
            // groupBoxEditAction
            // 
            groupBoxEditAction.Location = new Point(292, 379);
            groupBoxEditAction.Name = "groupBoxEditAction";
            groupBoxEditAction.Size = new Size(183, 141);
            groupBoxEditAction.TabIndex = 27;
            groupBoxEditAction.TabStop = false;
            groupBoxEditAction.Text = "Изменить действие";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1234, 661);
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
    }
}