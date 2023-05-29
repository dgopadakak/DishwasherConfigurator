using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DishwasherConfigurator
{
    public partial class Form1 : Form
    {
        private SerialPort? serialPort;

        private List<DishAction?> actionThread1 = new List<DishAction?>();
        private List<DishAction?> actionThread2 = new List<DishAction?>();
        private List<DishAction?> actionThread3 = new List<DishAction?>();

        private string inString = "";

        private int typeOfSelectedAction = -1;

        private byte numOfEditingThread = 0;
        private int indexOfEditingAction = -1;

        public Form1()
        {
            InitializeComponent();

            treeViewActionSelecter.BeginUpdate();                                       // Настройка дерева возможных активностей
            treeViewActionSelecter.Nodes.Add("Соль");
            treeViewActionSelecter.Nodes.Add("Служебные");
            treeViewActionSelecter.Nodes.Add("Набор воды");
            treeViewActionSelecter.Nodes.Add("Слив воды");
            treeViewActionSelecter.Nodes.Add("Мойка");
            treeViewActionSelecter.Nodes.Add("Сушка");
            treeViewActionSelecter.Nodes.Add("Сложные функции");
            treeViewActionSelecter.Nodes[0].Nodes.Add("Клапан соли вкл.");                          // type: 0
            treeViewActionSelecter.Nodes[0].Nodes.Add("Клапан соли выкл.");                         // type: 1
            treeViewActionSelecter.Nodes[1].Nodes.Add("Пропуск по времени");                        // type: 2
            treeViewActionSelecter.Nodes[1].Nodes.Add("Пропуск до срабатывания прессостата");       // type: 3
            treeViewActionSelecter.Nodes[1].Nodes.Add("Пропуск до конца работы прессостата");       // type: 4
            treeViewActionSelecter.Nodes[1].Nodes.Add("Пустота");                                   // type: -1
            treeViewActionSelecter.Nodes[2].Nodes.Add("Набор вкл.");                                // type: 5
            treeViewActionSelecter.Nodes[2].Nodes.Add("Набор выкл.");                               // type: 6
            treeViewActionSelecter.Nodes[3].Nodes.Add("Слив вкл.");                                 // type: 7
            treeViewActionSelecter.Nodes[3].Nodes.Add("Слив выкл.");                                // type: 8
            treeViewActionSelecter.Nodes[4].Nodes.Add("Помпа вкл.");                                // type: 9
            treeViewActionSelecter.Nodes[4].Nodes.Add("Помпа выкл.");                               // type: 10
            treeViewActionSelecter.Nodes[4].Nodes.Add("Тэн вкл.");                                  // type: 11
            treeViewActionSelecter.Nodes[4].Nodes.Add("Тэн выкл.");                                 // type: 12
            treeViewActionSelecter.Nodes[4].Nodes.Add("Выброс таблетки");                           // type: 13
            treeViewActionSelecter.Nodes[4].Nodes.Add("Ополаскиватель вкл.");                       // type: 14
            treeViewActionSelecter.Nodes[4].Nodes.Add("Ополаскиватель выкл.");                      // type: 15
            treeViewActionSelecter.Nodes[5].Nodes.Add("Вентилятор вкл.");                           // type: 16
            treeViewActionSelecter.Nodes[5].Nodes.Add("Вентилятор выкл.");                          // type: 17
            treeViewActionSelecter.Nodes[6].Nodes.Add("Набор воды + помпа вкл.");                   // type: 18
            treeViewActionSelecter.Nodes[6].Nodes.Add("Набор воды + помпа выкл.");                  // type: 19
            treeViewActionSelecter.EndUpdate();                                         // Конец настройки
            treeViewActionSelecter.ExpandAll();                                         // Развернуть все в дереве

            updateComPorts();
        }

        #region Обработка выбора действия

        private void buttonSelectAction_Click(object sender, EventArgs e)
        {
            typeOfSelectedAction = getTypeOfAction();
            if (typeOfSelectedAction != -2)
            {
                buttonSelectActionCancel.Enabled = true;
                buttonAddThread1.Enabled = true;
                buttonAddThread2.Enabled = true;
                buttonAddThread3.Enabled = true;
                if (actionThread1.Count > 0)
                {
                    buttonAddAfterSelectThread1.Enabled = true;
                }
                if (actionThread2.Count > 0)
                {
                    buttonAddAfterSelectThread2.Enabled = true;
                }
                if (actionThread3.Count > 0)
                {
                    buttonAddAfterSelectThread3.Enabled = true;
                }

                labelSelectedAction.Text = "Выбрано: " + treeViewActionSelecter.SelectedNode.Text;
                int[] typesOfTimeBasedActions = { 2 };
                if (typesOfTimeBasedActions.Contains(typeOfSelectedAction))
                {
                    labelTime.Enabled = true;
                    textBoxTime.Enabled = true;
                }
                else
                {
                    textBoxTime.Text = "";
                    labelTime.Enabled = false;
                    textBoxTime.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Выберете действие!");
            }
        }

        private void buttonSelectActionCancel_Click(object sender, EventArgs e)
        {
            labelSelectedAction.Text = "Действие не выбрано";
            buttonSelectActionCancel.Enabled = false;
            textBoxTime.Text = "";
            labelTime.Enabled = false;
            textBoxTime.Enabled = false;
            buttonAddThread1.Enabled = false;
            buttonAddThread2.Enabled = false;
            buttonAddThread3.Enabled = false;
        }

        private int getTypeOfAction()
        {
            switch (treeViewActionSelecter.SelectedNode.Text)
            {
                case "Пустота": return -1;
                case "Клапан соли вкл.": return 0;
                case "Клапан соли выкл.": return 1;
                case "Пропуск по времени": return 2;
                case "Пропуск до срабатывания прессостата": return 3;
                case "Пропуск до конца работы прессостата": return 4;
                case "Набор вкл.": return 5;
                case "Набор выкл.": return 6;
                case "Слив вкл.": return 7;
                case "Слив выкл.": return 8;
                case "Помпа вкл.": return 9;
                case "Помпа выкл.": return 10;
                case "Тэн вкл.": return 11;
                case "Тэн выкл.": return 12;
                case "Выброс таблетки": return 13;
                case "Ополаскиватель вкл.": return 14;
                case "Ополаскиватель выкл.": return 15;
                case "Вентилятор вкл.": return 16;
                case "Вентилятор выкл.": return 17;
                case "Набор воды + помпа вкл.": return 18;
                case "Набор воды + помпа выкл.": return 19;
            }
            return -2;
        }

        #endregion

        #region Обработка добавления действия в конец

        private void buttonAddThread1_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                closeEditGroupBox();
                int selectedActionIndex = -1;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    selectedActionIndex = dataGridView1.CurrentCell.RowIndex;
                }
                actionThread1.Add(new DishAction(typeOfSelectedAction, time));
                dataGridView1.Rows.Clear();
                int iCorrection = 0;
                for (int i = 0; i < actionThread1.Count; i++)
                {
                    string[] tempRow = { "", "", "" };
                    if (actionThread1[i].getType() == -1)
                    {
                        iCorrection++;
                    }
                    else
                    {
                        tempRow[0] = (i - iCorrection).ToString();
                        tempRow[1] = getActionNameByType(actionThread1[i].getType());
                        tempRow[2] = actionThread1[i].getTime().ToString();
                    }
                    dataGridView1.Rows.Add(tempRow);
                }
                if (selectedActionIndex != -1)
                {
                    dataGridView1.Rows[selectedActionIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[selectedActionIndex].Cells[0];
                }

                labelSelectedAction.Text = "Действие не выбрано";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
                buttonAddAfterSelectThread1.Enabled = false;
                buttonAddAfterSelectThread2.Enabled = false;
                buttonAddAfterSelectThread3.Enabled = false;
                buttonDelThread1.Enabled = true;
                buttonEditThread1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void buttonAddThread2_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                closeEditGroupBox();
                int selectedActionIndex = -1;
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    selectedActionIndex = dataGridView2.CurrentCell.RowIndex;
                }
                actionThread2.Add(new DishAction(typeOfSelectedAction, time));
                dataGridView2.Rows.Clear();
                int iCorrection = 0;
                for (int i = 0; i < actionThread2.Count; i++)
                {
                    string[] tempRow = { "", "", "" };
                    if (actionThread2[i].getType() == -1)
                    {
                        iCorrection++;
                    }
                    else
                    {
                        tempRow[0] = (i - iCorrection).ToString();
                        tempRow[1] = getActionNameByType(actionThread2[i].getType());
                        tempRow[2] = actionThread2[i].getTime().ToString();
                    }
                    dataGridView2.Rows.Add(tempRow);
                }
                if (selectedActionIndex != -1)
                {
                    dataGridView2.Rows[selectedActionIndex].Selected = true;
                    dataGridView2.CurrentCell = dataGridView2.Rows[selectedActionIndex].Cells[0];
                }

                labelSelectedAction.Text = "Действие не выбрано";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
                buttonAddAfterSelectThread1.Enabled = false;
                buttonAddAfterSelectThread2.Enabled = false;
                buttonAddAfterSelectThread3.Enabled = false;
                buttonDelThread2.Enabled = true;
                buttonEditThread2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void buttonAddThread3_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                closeEditGroupBox();
                int selectedActionIndex = -1;
                if (dataGridView3.SelectedRows.Count > 0)
                {
                    selectedActionIndex = dataGridView3.CurrentCell.RowIndex;
                }
                actionThread3.Add(new DishAction(typeOfSelectedAction, time));
                dataGridView3.Rows.Clear();
                int iCorrection = 0;
                for (int i = 0; i < actionThread3.Count; i++)
                {
                    string[] tempRow = { "", "", "" };
                    if (actionThread3[i].getType() == -1)
                    {
                        iCorrection++;
                    }
                    else
                    {
                        tempRow[0] = (i - iCorrection).ToString();
                        tempRow[1] = getActionNameByType(actionThread3[i].getType());
                        tempRow[2] = actionThread3[i].getTime().ToString();
                    }
                    dataGridView3.Rows.Add(tempRow);
                }
                if (selectedActionIndex != -1)
                {
                    dataGridView3.Rows[selectedActionIndex].Selected = true;
                    dataGridView3.CurrentCell = dataGridView3.Rows[selectedActionIndex].Cells[0];
                }

                labelSelectedAction.Text = "Действие не выбрано";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
                buttonAddAfterSelectThread1.Enabled = false;
                buttonAddAfterSelectThread2.Enabled = false;
                buttonAddAfterSelectThread3.Enabled = false;
                buttonDelThread3.Enabled = true;
                buttonEditThread3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private int getTime()
        {
            try
            {
                int time = Int32.Parse(textBoxTime.Text);
                if (time > 0)
                {
                    return time;
                }
            }
            catch
            {
                return -1;
            }
            return -1;
        }

        #endregion

        #region Обработка добавления действия в строку, следующую за выделенной

        private void buttonAddAfterSelectThread1_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    closeEditGroupBox();
                    int selectedActionIndex = dataGridView1.CurrentCell.RowIndex;
                    actionThread1.Insert(selectedActionIndex + 1, new DishAction(typeOfSelectedAction, time));
                    dataGridView1.Rows.Clear();
                    int iCorrection = 0;
                    for (int i = 0; i < actionThread1.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread1[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread1[i].getType());
                            tempRow[2] = actionThread1[i].getTime().ToString();
                        }
                        dataGridView1.Rows.Add(tempRow);
                    }
                    dataGridView1.Rows[selectedActionIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[selectedActionIndex].Cells[0];

                    labelSelectedAction.Text = "Действие не выбрано";
                    buttonSelectActionCancel.Enabled = false;
                    textBoxTime.Text = "";
                    labelTime.Enabled = false;
                    textBoxTime.Enabled = false;
                    buttonAddThread1.Enabled = false;
                    buttonAddThread2.Enabled = false;
                    buttonAddThread3.Enabled = false;
                    buttonAddAfterSelectThread1.Enabled = false;
                    buttonAddAfterSelectThread2.Enabled = false;
                    buttonAddAfterSelectThread3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ошибка добавления!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void buttonAddAfterSelectThread2_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    closeEditGroupBox();
                    int selectedActionIndex = dataGridView2.CurrentCell.RowIndex;
                    actionThread2.Insert(selectedActionIndex + 1, new DishAction(typeOfSelectedAction, time));
                    dataGridView2.Rows.Clear();
                    int iCorrection = 0;
                    for (int i = 0; i < actionThread2.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread2[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread2[i].getType());
                            tempRow[2] = actionThread2[i].getTime().ToString();
                        }
                        dataGridView2.Rows.Add(tempRow);
                    }
                    dataGridView2.Rows[selectedActionIndex].Selected = true;
                    dataGridView2.CurrentCell = dataGridView2.Rows[selectedActionIndex].Cells[0];

                    labelSelectedAction.Text = "Действие не выбрано";
                    buttonSelectActionCancel.Enabled = false;
                    textBoxTime.Text = "";
                    labelTime.Enabled = false;
                    textBoxTime.Enabled = false;
                    buttonAddThread1.Enabled = false;
                    buttonAddThread2.Enabled = false;
                    buttonAddThread3.Enabled = false;
                    buttonAddAfterSelectThread1.Enabled = false;
                    buttonAddAfterSelectThread2.Enabled = false;
                    buttonAddAfterSelectThread3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ошибка добавления!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void buttonAddAfterSelectThread3_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                if (dataGridView3.SelectedRows.Count > 0)
                {
                    closeEditGroupBox();
                    int selectedActionIndex = dataGridView3.CurrentCell.RowIndex;
                    actionThread3.Insert(selectedActionIndex + 1, new DishAction(typeOfSelectedAction, time));
                    dataGridView3.Rows.Clear();
                    int iCorrection = 0;
                    for (int i = 0; i < actionThread3.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread3[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread3[i].getType());
                            tempRow[2] = actionThread3[i].getTime().ToString();
                        }
                        dataGridView3.Rows.Add(tempRow);
                    }
                    dataGridView3.Rows[selectedActionIndex].Selected = true;
                    dataGridView3.CurrentCell = dataGridView3.Rows[selectedActionIndex].Cells[0];

                    labelSelectedAction.Text = "Действие не выбрано";
                    buttonSelectActionCancel.Enabled = false;
                    textBoxTime.Text = "";
                    labelTime.Enabled = false;
                    textBoxTime.Enabled = false;
                    buttonAddThread1.Enabled = false;
                    buttonAddThread2.Enabled = false;
                    buttonAddThread3.Enabled = false;
                    buttonAddAfterSelectThread1.Enabled = false;
                    buttonAddAfterSelectThread2.Enabled = false;
                    buttonAddAfterSelectThread3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ошибка добавления!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        #endregion

        #region Работа с COM-портом

        private void buttonUpdateComPorts_Click(object sender, EventArgs e)
        {
            updateComPorts();
        }

        private void buttonAcceptCom_Click(object sender, EventArgs e)
        {
            if (comboBoxComPorts.SelectedIndex != -1)
            {
                try
                {
                    string? selectedComPort = comboBoxComPorts.SelectedItem.ToString();
                    serialPort = new SerialPort(selectedComPort, 9600);
                    serialPort.Open();
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceivedHandler);
                    Thread.Sleep(2000);

                    comboBoxComPorts.Enabled = false;
                    buttonUpdateComPorts.Enabled = false;
                    buttonAcceptCom.Enabled = false;
                    buttonCancelCom.Enabled = true;
                    buttonSendProgramByCom.Enabled = true;
                    buttonReadProgramByCom.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Неполадки с выбранным портом!");
                }
            }
            else
            {
                MessageBox.Show("Выберите COM порт!");
            }
        }

        private void dataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            inString += sp.ReadExisting();
            parseInString();
        }

        private void parseInString()
        {
            while (inString.IndexOf("!") != -1)
            {
                string command = inString.Substring(0, inString.IndexOf("!"));
                inString = inString.Substring(inString.IndexOf("!") + 1);

                if (command.IndexOf("@#program#") > 0)
                {
                    readDishwasherProgram(command);
                }
                if (command.IndexOf("OK") > 0)
                {
                    if (command.Substring(0, command.IndexOf("O")) == compilateDishwasherProgram(false))
                    {
                        MessageBox.Show("Программа успешно записана!");
                    }
                    else
                    {
                        MessageBox.Show("Целостность программы нарушена при записи (или при проверке целостности возникла ошибка)! Попробуйте еще раз.");
                    }
                }
            }
        }

        private void updateComPorts()
        {
            comboBoxComPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxComPorts.Items.Add(port);
            }
            comboBoxComPorts.SelectedIndex = -1;
            comboBoxComPorts.Text = "Выберите COM порт";
        }

        private void buttonCancelCom_Click(object sender, EventArgs e)
        {
            closeComPort();
            updateComPorts();
            comboBoxComPorts.Enabled = true;
            buttonUpdateComPorts.Enabled = true;
            buttonAcceptCom.Enabled = true;
            buttonCancelCom.Enabled = false;
            buttonSendProgramByCom.Enabled = false;
            buttonReadProgramByCom.Enabled = false;
        }

        private void buttonSendProgramByCom_Click(object sender, EventArgs e)
        {
            string s = compilateDishwasherProgram(false) + "!";
            try
            {
                serialPort.Write(s);
            }
            catch
            {
                MessageBox.Show("Ошибка отправки программы! Проверьте подключение!");
            }
        }

        private void buttonReadProgramByCom_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("get_program!");
            }
            catch
            {
                MessageBox.Show("Ошибка запроса программы! Проверьте подключение!");
            }
        }

        private void closeComPort()
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }

        #endregion

        #region Сохранение в файл и чтение из него

        private void buttonWriteProgramToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "Text files(*.txt)|*.txt";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = oSaveFileDialog.FileName;
                File.WriteAllText(fileName, compilateDishwasherProgram(true));
            }
        }

        private void buttonReadProgramFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Text files(*.txt)|*.txt";
            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = oOpenFileDialog.FileName;
                readDishwasherProgram(File.ReadAllText(fileName));
            }
        }

        #endregion

        #region Превращение программы в строку и обратно

        private string compilateDishwasherProgram(bool isEmptySpacesNeeded)
        {
            string s;
            if (isEmptySpacesNeeded)
            {
                s = actionThread1.Count + "$" + actionThread2.Count + "$" + actionThread3.Count + "$@";
            }
            else
            {
                int n1 = actionThread1.Count;
                int n2 = actionThread2.Count;
                int n3 = actionThread3.Count;
                for (int i = 0; i < actionThread1.Count; i++)
                {
                    if (actionThread1[i].getType() == -1)
                    {
                        n1--;
                    }
                }
                for (int i = 0; i < actionThread2.Count; i++)
                {
                    if (actionThread2[i].getType() == -1)
                    {
                        n2--;
                    }
                }
                for (int i = 0; i < actionThread3.Count; i++)
                {
                    if (actionThread3[i].getType() == -1)
                    {
                        n3--;
                    }
                }
                s = n1 + "$" + n2 + "$" + n3 + "$@";
            }
            for (int i = 0; i < actionThread1.Count; i++)
            {
                if (actionThread1[i].getType() != -1 || isEmptySpacesNeeded)
                {
                    s += actionThread1[i].getType() + ";" + actionThread1[i].getTime() + "$";
                }
            }
            s += "@";
            for (int i = 0; i < actionThread2.Count; i++)
            {
                if (actionThread2[i].getType() != -1 || isEmptySpacesNeeded)
                {
                    s += actionThread2[i].getType() + ";" + actionThread2[i].getTime() + "$";
                }
            }
            s += "@";
            for (int i = 0; i < actionThread3.Count; i++)
            {
                if (actionThread3[i].getType() != -1 || isEmptySpacesNeeded)
                {
                    s += actionThread3[i].getType() + ";" + actionThread3[i].getTime() + "$";
                }
            }
            s += "@#program#";
            return s;
        }

        private void readDishwasherProgram(string s)
        {
            if (s.IndexOf("@#program#") > 0)
            {
                try
                {
                    actionThread1.Clear();
                    actionThread2.Clear();
                    actionThread3.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();
                    dataGridView3.Rows.Clear();

                    string nums = s.Substring(0, s.IndexOf("@"));
                    s = s.Substring(s.IndexOf("@") + 1);

                    int n1 = Int32.Parse(nums.Substring(0, nums.IndexOf("$")));
                    nums = nums.Substring(nums.IndexOf("$") + 1);
                    int n2 = Int32.Parse(nums.Substring(0, nums.IndexOf("$")));
                    nums = nums.Substring(nums.IndexOf("$") + 1);
                    int n3 = Int32.Parse(nums.Substring(0, nums.IndexOf("$")));

                    string thread1 = s.Substring(0, s.IndexOf("@"));
                    s = s.Substring(s.IndexOf("@") + 1);
                    for (int i = 0; i < n1; i++)
                    {
                        string tempAction = thread1.Substring(0, thread1.IndexOf("$"));
                        thread1 = thread1.Substring(thread1.IndexOf("$") + 1);
                        int type = Int32.Parse(tempAction.Substring(0, tempAction.IndexOf(";")));
                        tempAction = tempAction.Substring(tempAction.IndexOf(";") + 1);
                        int time = Int32.Parse(tempAction);
                        actionThread1.Add(new DishAction(type, time));
                    }
                    string thread2 = s.Substring(0, s.IndexOf("@"));
                    s = s.Substring(s.IndexOf("@") + 1);
                    for (int i = 0; i < n2; i++)
                    {
                        string tempAction = thread2.Substring(0, thread2.IndexOf("$"));
                        thread2 = thread2.Substring(thread2.IndexOf("$") + 1);
                        int type = Int32.Parse(tempAction.Substring(0, tempAction.IndexOf(";")));
                        tempAction = tempAction.Substring(tempAction.IndexOf(";") + 1);
                        int time = Int32.Parse(tempAction);
                        actionThread2.Add(new DishAction(type, time));
                    }
                    string thread3 = s.Substring(0, s.IndexOf("@"));
                    for (int i = 0; i < n3; i++)
                    {
                        string tempAction = thread3.Substring(0, thread3.IndexOf("$"));
                        thread3 = thread3.Substring(thread3.IndexOf("$") + 1);
                        int type = Int32.Parse(tempAction.Substring(0, tempAction.IndexOf(";")));
                        tempAction = tempAction.Substring(tempAction.IndexOf(";") + 1);
                        int time = Int32.Parse(tempAction);
                        actionThread3.Add(new DishAction(type, time));
                    }
                    int iCorrection = 0;
                    for (int i = 0; i < actionThread1.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread1[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread1[i].getType());
                            tempRow[2] = actionThread1[i].getTime().ToString();
                        }
                        dataGridView1.Rows.Add(tempRow);
                    }
                    iCorrection = 0;
                    for (int i = 0; i < actionThread2.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread2[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread2[i].getType());
                            tempRow[2] = actionThread2[i].getTime().ToString();
                        }
                        dataGridView2.Rows.Add(tempRow);
                    }
                    iCorrection = 0;
                    for (int i = 0; i < actionThread3.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread3[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread3[i].getType());
                            tempRow[2] = actionThread3[i].getTime().ToString();
                        }
                        dataGridView3.Rows.Add(tempRow);
                    }
                    if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
                    {
                        buttonDelThread1.Enabled = true;
                        buttonEditThread1.Enabled = true;
                    }
                    if (dataGridView2.Rows != null && dataGridView2.Rows.Count != 0)
                    {
                        buttonDelThread2.Enabled = true;
                        buttonEditThread2.Enabled = true;
                    }
                    if (dataGridView3.Rows != null && dataGridView3.Rows.Count != 0)
                    {
                        buttonDelThread3.Enabled = true;
                        buttonEditThread3.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("На вход поступил файл правильной конфигурации, но программа в нем повреждена! Попробуйте снова.");
                    actionThread1.Clear();
                    actionThread2.Clear();
                    actionThread3.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();
                    dataGridView3.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("На вход поступил файл неправильной конфигурации! Вероятнее всего это не программа.");
            }
        }

        #endregion

        #region Изменение действия

        private void buttonEditThread1_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int selectedActionIndex = dataGridView1.CurrentCell.RowIndex;
            if (typesOfTimeBasedActions.Contains(actionThread1[selectedActionIndex].getType()))
            {
                buttonDelThread1.Enabled = false;
                buttonReadProgramFromFile.Enabled = false;
                buttonReadProgramByCom.Enabled = false;
                numOfEditingThread = 1;
                indexOfEditingAction = selectedActionIndex;
                groupBoxEditAction.Visible = true;
                labelNameEdit.Text = getActionNameByType(actionThread1[selectedActionIndex].getType());
                textBoxTimeEdit.Text = actionThread1[selectedActionIndex].getTime().ToString();
            }
            else
            {
                MessageBox.Show("Данное действие не зависит от времени!");
            }
        }

        private void buttonEditThread2_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int selectedActionIndex = dataGridView2.CurrentCell.RowIndex;
            if (typesOfTimeBasedActions.Contains(actionThread2[selectedActionIndex].getType()))
            {
                buttonDelThread2.Enabled = false;
                buttonReadProgramFromFile.Enabled = false;
                buttonReadProgramByCom.Enabled = false;
                numOfEditingThread = 2;
                indexOfEditingAction = selectedActionIndex;
                groupBoxEditAction.Visible = true;
                labelNameEdit.Text = getActionNameByType(actionThread2[selectedActionIndex].getType());
                textBoxTimeEdit.Text = actionThread2[selectedActionIndex].getTime().ToString();
            }
            else
            {
                MessageBox.Show("Данное действие не зависит от времени!");
            }
        }

        private void buttonEditThread3_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 2 };
            int selectedActionIndex = dataGridView3.CurrentCell.RowIndex;
            if (typesOfTimeBasedActions.Contains(actionThread3[selectedActionIndex].getType()))
            {
                buttonDelThread3.Enabled = false;
                buttonReadProgramFromFile.Enabled = false;
                buttonReadProgramByCom.Enabled = false;
                numOfEditingThread = 3;
                indexOfEditingAction = selectedActionIndex;
                groupBoxEditAction.Visible = true;
                labelNameEdit.Text = getActionNameByType(actionThread3[selectedActionIndex].getType());
                textBoxTimeEdit.Text = actionThread3[selectedActionIndex].getTime().ToString();
            }
            else
            {
                MessageBox.Show("Данное действие не зависит от времени!");
            }
        }

        private void buttonConfirmEdit_Click(object sender, EventArgs e)
        {
            int time = getTimeEdit();
            int selectedActionIndex = -1;
            if (time != -1)
            {
                switch (numOfEditingThread)
                {
                    case 1:
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            selectedActionIndex = dataGridView1.CurrentCell.RowIndex;
                        }
                        actionThread1[indexOfEditingAction].setTime(Int32.Parse(textBoxTimeEdit.Text));
                        dataGridView1.Rows.Clear();
                        int iCorrection = 0;
                        for (int i = 0; i < actionThread1.Count; i++)
                        {
                            string[] tempRow = { "", "", "" };
                            if (actionThread1[i].getType() == -1)
                            {
                                iCorrection++;
                            }
                            else
                            {
                                tempRow[0] = (i - iCorrection).ToString();
                                tempRow[1] = getActionNameByType(actionThread1[i].getType());
                                tempRow[2] = actionThread1[i].getTime().ToString();
                            }
                            dataGridView1.Rows.Add(tempRow);
                        }
                        if (selectedActionIndex != -1)
                        {
                            dataGridView1.Rows[selectedActionIndex].Selected = true;
                            dataGridView1.CurrentCell = dataGridView1.Rows[selectedActionIndex].Cells[0];
                        }
                        break;
                    case 2:
                        if (dataGridView2.SelectedRows.Count > 0)
                        {
                            selectedActionIndex = dataGridView2.CurrentCell.RowIndex;
                        }
                        actionThread2[indexOfEditingAction].setTime(Int32.Parse(textBoxTimeEdit.Text));
                        dataGridView2.Rows.Clear();
                        iCorrection = 0;
                        for (int i = 0; i < actionThread2.Count; i++)
                        {
                            string[] tempRow = { "", "", "" };
                            if (actionThread2[i].getType() == -1)
                            {
                                iCorrection++;
                            }
                            else
                            {
                                tempRow[0] = (i - iCorrection).ToString();
                                tempRow[1] = getActionNameByType(actionThread2[i].getType());
                                tempRow[2] = actionThread2[i].getTime().ToString();
                            }
                            dataGridView2.Rows.Add(tempRow);
                        }
                        if (selectedActionIndex != -1)
                        {
                            dataGridView2.Rows[selectedActionIndex].Selected = true;
                            dataGridView2.CurrentCell = dataGridView2.Rows[selectedActionIndex].Cells[0];
                        }
                        break;
                    case 3:
                        if (dataGridView3.SelectedRows.Count > 0)
                        {
                            selectedActionIndex = dataGridView3.CurrentCell.RowIndex;
                        }
                        actionThread3[indexOfEditingAction].setTime(Int32.Parse(textBoxTimeEdit.Text));
                        dataGridView3.Rows.Clear();
                        iCorrection = 0;
                        for (int i = 0; i < actionThread3.Count; i++)
                        {
                            string[] tempRow = { "", "", "" };
                            if (actionThread3[i].getType() == -1)
                            {
                                iCorrection++;
                            }
                            else
                            {
                                tempRow[0] = (i - iCorrection).ToString();
                                tempRow[1] = getActionNameByType(actionThread3[i].getType());
                                tempRow[2] = actionThread3[i].getTime().ToString();
                            }
                            dataGridView3.Rows.Add(tempRow);
                        }
                        if (selectedActionIndex != -1)
                        {
                            dataGridView3.Rows[selectedActionIndex].Selected = true;
                            dataGridView3.CurrentCell = dataGridView3.Rows[selectedActionIndex].Cells[0];
                        }
                        break;
                }
                closeEditGroupBox();
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            closeEditGroupBox();
        }

        private int getTimeEdit()
        {
            try
            {
                int time = Int32.Parse(textBoxTimeEdit.Text);
                if (time > 0)
                {
                    return time;
                }
            }
            catch
            {
                return -1;
            }
            return -1;
        }

        private void closeEditGroupBox()
        {
            groupBoxEditAction.Visible = false;
            if (actionThread1.Count > 0)
            {
                buttonDelThread1.Enabled = true;
            }
            if (actionThread2.Count > 0)
            {
                buttonDelThread2.Enabled = true;
            }
            if (actionThread3.Count > 0)
            {
                buttonDelThread3.Enabled = true;
            }
            buttonReadProgramFromFile.Enabled = true;
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    buttonReadProgramByCom.Enabled = true;
                }
            }
        }

        #endregion

        #region Удаление действий из потоков

        private void buttonDelThread1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedActionIndex = dataGridView1.CurrentCell.RowIndex;
                actionThread1.RemoveAt(selectedActionIndex);
                int countRows = dataGridView1.Rows.Count;
                dataGridView1.Rows.Clear();
                if (countRows - 1 > 0)
                {
                    int iCorrection = 0;
                    for (int i = 0; i < actionThread1.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread1[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread1[i].getType());
                            tempRow[2] = actionThread1[i].getTime().ToString();
                        }
                        dataGridView1.Rows.Add(tempRow);
                    }
                }
                else
                {
                    buttonAddAfterSelectThread1.Enabled = false;
                    buttonDelThread1.Enabled = false;
                    buttonEditThread1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ошибка удаления!");
            }
        }

        private void buttonDelThread2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedActionIndex = dataGridView2.CurrentCell.RowIndex;
                actionThread2.RemoveAt(selectedActionIndex);
                int countRows = dataGridView2.Rows.Count;
                dataGridView2.Rows.Clear();
                if (countRows - 1 > 0)
                {
                    int iCorrection = 0;
                    for (int i = 0; i < actionThread2.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread2[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread2[i].getType());
                            tempRow[2] = actionThread2[i].getTime().ToString();
                        }
                        dataGridView2.Rows.Add(tempRow);
                    }
                }
                else
                {
                    buttonAddAfterSelectThread2.Enabled = false;
                    buttonDelThread2.Enabled = false;
                    buttonEditThread2.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ошибка удаления!");
            }
        }

        private void buttonDelThread3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int selectedActionIndex = dataGridView3.CurrentCell.RowIndex;
                actionThread3.RemoveAt(selectedActionIndex);
                int countRows = dataGridView3.Rows.Count;
                dataGridView3.Rows.Clear();
                if (countRows - 1 > 0)
                {
                    int iCorrection = 0;
                    for (int i = 0; i < actionThread3.Count; i++)
                    {
                        string[] tempRow = { "", "", "" };
                        if (actionThread3[i].getType() == -1)
                        {
                            iCorrection++;
                        }
                        else
                        {
                            tempRow[0] = (i - iCorrection).ToString();
                            tempRow[1] = getActionNameByType(actionThread3[i].getType());
                            tempRow[2] = actionThread3[i].getTime().ToString();
                        }
                        dataGridView3.Rows.Add(tempRow);
                    }
                }
                else
                {
                    buttonAddAfterSelectThread3.Enabled = false;
                    buttonDelThread3.Enabled = false;
                    buttonEditThread3.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ошибка удаления!");
            }
        }

        #endregion

        #region Работа калькулятора

        private void buttonMinToSecCal_Click(object sender, EventArgs e)
        {
            try
            {
                long min = long.Parse(textBoxMinInputCal.Text);
                labelSecOutputCal.Text = "= " + (min * 60) + " с";
            }
            catch
            {
                labelSecOutputCal.Text = "= Ошибка";
            }
        }

        private void buttonSecToMinCal_Click(object sender, EventArgs e)
        {
            try
            {
                long sec = long.Parse(textBoxSecInputCal.Text);
                labelMinOutputCal.Text = "= " + (sec / 60) + " мин.";
            }
            catch
            {
                labelMinOutputCal.Text = "= Ошибка";
            }
        }

        #endregion

        private string getActionNameByType(int type)
        {
            switch (type)
            {
                case -1: return "";
                case 0: return "Клапан соли вкл.";
                case 1: return "Клапан соли выкл.";
                case 2: return "Пропуск по времени";
                case 3: return "Пропуск до сраб. пресс.";
                case 4: return "Пропуск до к. р. пресс.";
                case 5: return "Набор вкл.";
                case 6: return "Набор выкл.";
                case 7: return "Слив вкл.";
                case 8: return "Слив выкл.";
                case 9: return "Помпа вкл.";
                case 10: return "Помпа выкл.";
                case 11: return "Тэн вкл.";
                case 12: return "Тэн выкл.";
                case 13: return "Выброс таблетки";
                case 14: return "Ополаскиватель вкл.";
                case 15: return "Ополаскиватель выкл.";
                case 16: return "Вентилятор вкл.";
                case 17: return "Вентилятор выкл.";
                case 18: return "Набор + помпа вкл.";
                case 19: return "Набор + помпа выкл.";
            }
            return "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeComPort();
        }
    }
}
