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

        public Form1()
        {
            InitializeComponent();

            treeViewActionSelecter.BeginUpdate();                                       // Настройка дерева возможных активностей
            treeViewActionSelecter.Nodes.Add("Служебные");
            treeViewActionSelecter.Nodes.Add("Набор воды");
            treeViewActionSelecter.Nodes.Add("Слив воды");
            treeViewActionSelecter.Nodes.Add("Мойка");
            treeViewActionSelecter.Nodes.Add("Сушка");
            treeViewActionSelecter.Nodes[0].Nodes.Add("Клапан соли по времени");                    // type: 0
            treeViewActionSelecter.Nodes[0].Nodes.Add("Пропуск по времени");                        // type: 1
            treeViewActionSelecter.Nodes[0].Nodes.Add("Пропуск до срабатывания прессостата");       // type: 2
            treeViewActionSelecter.Nodes[0].Nodes.Add("Пропуск до конца работы прессостата");       // type: 3
            treeViewActionSelecter.Nodes[1].Nodes.Add("Набор до прессостата");                      // type: 4
            treeViewActionSelecter.Nodes[1].Nodes.Add("Набор по времени");                          // type: 5
            treeViewActionSelecter.Nodes[2].Nodes.Add("Слив до прессостата");                       // type: 6
            treeViewActionSelecter.Nodes[2].Nodes.Add("Слив по времени");                           // type: 7
            treeViewActionSelecter.Nodes[3].Nodes.Add("Основная помпа по времени");                 // type: 8
            treeViewActionSelecter.Nodes[3].Nodes.Add("Тэн по времени");                            // type: 9
            treeViewActionSelecter.Nodes[3].Nodes.Add("Выброс таблетки");                           // type: 10
            treeViewActionSelecter.Nodes[3].Nodes.Add("Выброс ополаскивателя по времени");          // type: 11
            treeViewActionSelecter.Nodes[4].Nodes.Add("Вентилятор по времени");                     // type: 12
            treeViewActionSelecter.EndUpdate();                                         // Конец настройки
            treeViewActionSelecter.ExpandAll();                                         // Развернуть все в дереве

            updateComPorts();
        }

        #region Обработка выбора действия

        private void buttonSelectAction_Click(object sender, EventArgs e)
        {
            typeOfSelectedAction = getTypeOfAction();
            if (typeOfSelectedAction != -1)
            {
                buttonSelectActionCancel.Enabled = true;
                buttonAddThread1.Enabled = true;
                buttonAddThread2.Enabled = true;
                buttonAddThread3.Enabled = true;

                labelSelectedAction.Text = "Выбрано действие: " + treeViewActionSelecter.SelectedNode.Text;
                int[] typesOfTimeBasedActions = { 0, 1, 5, 7, 8, 9, 11, 12 };
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
                case "Клапан соли по времени": return 0;
                case "Пропуск по времени": return 1;
                case "Пропуск до срабатывания прессостата": return 2;
                case "Пропуск до конца работы прессостата": return 3;
                case "Набор до прессостата": return 4;
                case "Набор по времени": return 5;
                case "Слив до прессостата": return 6;
                case "Слив по времени": return 7;
                case "Основная помпа по времени": return 8;
                case "Тэн по времени": return 9;
                case "Выброс таблетки": return 10;
                case "Выброс ополаскивателя по времени": return 11;
                case "Вентилятор по времени": return 12;
            }
            return -1;
        }

        #endregion

        #region Обработка добавления действия

        private void buttonAddThread1_Click(object sender, EventArgs e)
        {
            int[] typesOfTimeBasedActions = { 0, 1, 5, 7, 8, 9, 11, 12 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                actionThread1.Add(new DishAction(typeOfSelectedAction, time));
                dataGridView1.Rows.Clear();
                for (int i = 0; i < actionThread1.Count; i++)
                {
                    string[] tempRow = { i.ToString(), getActionNameByType(actionThread1[i].getType()), actionThread1[i].getTime().ToString() };
                    dataGridView1.Rows.Add(tempRow);
                }

                labelSelectedAction.Text = "Действие не выбрано";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
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
            int[] typesOfTimeBasedActions = { 0, 1, 5, 7, 8, 9, 11, 12 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                actionThread2.Add(new DishAction(typeOfSelectedAction, time));
                dataGridView2.Rows.Clear();
                for (int i = 0; i < actionThread2.Count; i++)
                {
                    string[] tempRow = { i.ToString(), getActionNameByType(actionThread2[i].getType()), actionThread2[i].getTime().ToString() };
                    dataGridView2.Rows.Add(tempRow);
                }

                labelSelectedAction.Text = "Действие не выбрано";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
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
            int[] typesOfTimeBasedActions = { 0, 1, 5, 7, 8, 9, 11, 12 };
            int time = getTime();
            if (time != -1 || !typesOfTimeBasedActions.Contains(typeOfSelectedAction))
            {
                actionThread3.Add(new DishAction(typeOfSelectedAction, time));
                dataGridView3.Rows.Clear();
                for (int i = 0; i < actionThread3.Count; i++)
                {
                    string[] tempRow = { i.ToString(), getActionNameByType(actionThread3[i].getType()), actionThread3[i].getTime().ToString() };
                    dataGridView3.Rows.Add(tempRow);
                }

                labelSelectedAction.Text = "Действие не выбрано";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
                buttonDelThread3.Enabled = true;
                buttonEditThread3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private string getActionNameByType(int type)
        {
            switch (type)
            {
                case 0: return "Клапан соли";
                case 1: return "Пропуск по времени";
                case 2: return "Пропуск до сраб. пресс.";
                case 3: return "Пропуск до к. р. пресс.";
                case 4: return "Набор до пресс.";
                case 5: return "Набор по времени";
                case 6: return "Слив до пресс.";
                case 7: return "Слив по времени";
                case 8: return "Основная помпа";
                case 9: return "Тэн";
                case 10: return "Таблетка";
                case 11: return "Ополаскиватель";
                case 12: return "Вентилятор";
            }
            return "";
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
            while (inString.IndexOf("#") != -1)
            {
                string command = inString.Substring(0, inString.IndexOf("#"));
                inString = inString.Substring(inString.IndexOf("#") + 1);

                ///////////////////////////////////////////////////////////////////////////////////////////////////////
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
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void buttonReadProgramByCom_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
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

        private void buttonWriteProgramToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "Text files(*.txt)|*.txt";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = oSaveFileDialog.FileName;
                File.WriteAllText(fileName, compilateDishwasherProgram());
            }
        }

        private void buttonReadProgramFromFile_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////
        }

        private string compilateDishwasherProgram()
        {
            string s = actionThread1.Count + "$" + actionThread2.Count + "$" + actionThread3.Count + "$@";
            for (int i = 0; i < actionThread1.Count; i++)
            {
                s += actionThread1[i].getType() + ";" + actionThread1[i].getTime() + "$";
            }
            s += "@";
            for (int i = 0; i < actionThread2.Count; i++)
            {
                s += actionThread2[i].getType() + ";" + actionThread2[i].getTime() + "$";
            }
            s += "@";
            for (int i = 0; i < actionThread3.Count; i++)
            {
                s += actionThread3[i].getType() + ";" + actionThread3[i].getTime() + "$";
            }
            s += "@#";
            return s;
        }

        private void readDishwasherProgram(string s)
        {
            ////////////////////////////////////////////////////////////////////////////////
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeComPort();
        }
    }
}
