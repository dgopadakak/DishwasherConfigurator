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

            treeViewActionSelecter.BeginUpdate();                                       // ��������� ������ ��������� �����������
            treeViewActionSelecter.Nodes.Add("���������");
            treeViewActionSelecter.Nodes.Add("����� ����");
            treeViewActionSelecter.Nodes.Add("���� ����");
            treeViewActionSelecter.Nodes.Add("�����");
            treeViewActionSelecter.Nodes.Add("�����");
            treeViewActionSelecter.Nodes[0].Nodes.Add("������ ���� �� �������");                    // type: 0
            treeViewActionSelecter.Nodes[0].Nodes.Add("������� �� �������");                        // type: 1
            treeViewActionSelecter.Nodes[0].Nodes.Add("������� �� ������������ �����������");       // type: 2
            treeViewActionSelecter.Nodes[0].Nodes.Add("������� �� ����� ������ �����������");       // type: 3
            treeViewActionSelecter.Nodes[0].Nodes.Add("�������");                                   // type: -1
            treeViewActionSelecter.Nodes[1].Nodes.Add("����� �� �����������");                      // type: 4
            treeViewActionSelecter.Nodes[1].Nodes.Add("����� �� �������");                          // type: 5
            treeViewActionSelecter.Nodes[2].Nodes.Add("���� �� �����������");                       // type: 6
            treeViewActionSelecter.Nodes[2].Nodes.Add("���� �� �������");                           // type: 7
            treeViewActionSelecter.Nodes[3].Nodes.Add("�������� ����� �� �������");                 // type: 8
            treeViewActionSelecter.Nodes[3].Nodes.Add("��� �� �������");                            // type: 9
            treeViewActionSelecter.Nodes[3].Nodes.Add("������ ��������");                           // type: 10
            treeViewActionSelecter.Nodes[3].Nodes.Add("������ �������������� �� �������");          // type: 11
            treeViewActionSelecter.Nodes[4].Nodes.Add("���������� �� �������");                     // type: 12
            treeViewActionSelecter.EndUpdate();                                         // ����� ���������
            treeViewActionSelecter.ExpandAll();                                         // ���������� ��� � ������

            updateComPorts();
        }

        #region ��������� ������ ��������

        private void buttonSelectAction_Click(object sender, EventArgs e)
        {
            typeOfSelectedAction = getTypeOfAction();
            if (typeOfSelectedAction != -2)
            {
                buttonSelectActionCancel.Enabled = true;
                buttonAddThread1.Enabled = true;
                buttonAddThread2.Enabled = true;
                buttonAddThread3.Enabled = true;

                labelSelectedAction.Text = "������� ��������: " + treeViewActionSelecter.SelectedNode.Text;
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
                MessageBox.Show("�������� ��������!");
            }
        }

        private void buttonSelectActionCancel_Click(object sender, EventArgs e)
        {
            labelSelectedAction.Text = "�������� �� �������";
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
                case "�������": return -1;
                case "������ ���� �� �������": return 0;
                case "������� �� �������": return 1;
                case "������� �� ������������ �����������": return 2;
                case "������� �� ����� ������ �����������": return 3;
                case "����� �� �����������": return 4;
                case "����� �� �������": return 5;
                case "���� �� �����������": return 6;
                case "���� �� �������": return 7;
                case "�������� ����� �� �������": return 8;
                case "��� �� �������": return 9;
                case "������ ��������": return 10;
                case "������ �������������� �� �������": return 11;
                case "���������� �� �������": return 12;
            }
            return -2;
        }

        #endregion

        #region ��������� ���������� ��������

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

                labelSelectedAction.Text = "�������� �� �������";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
                buttonAddAfterSelectThread1.Enabled = true;
                buttonDelThread1.Enabled = true;
                buttonEditThread1.Enabled = true;
            }
            else
            {
                MessageBox.Show("��������� ��������� ������!");
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

                labelSelectedAction.Text = "�������� �� �������";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
                buttonAddAfterSelectThread2.Enabled = true;
                buttonDelThread2.Enabled = true;
                buttonEditThread2.Enabled = true;
            }
            else
            {
                MessageBox.Show("��������� ��������� ������!");
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

                labelSelectedAction.Text = "�������� �� �������";
                buttonSelectActionCancel.Enabled = false;
                textBoxTime.Text = "";
                labelTime.Enabled = false;
                textBoxTime.Enabled = false;
                buttonAddThread1.Enabled = false;
                buttonAddThread2.Enabled = false;
                buttonAddThread3.Enabled = false;
                buttonAddAfterSelectThread3.Enabled = true;
                buttonDelThread3.Enabled = true;
                buttonEditThread3.Enabled = true;
            }
            else
            {
                MessageBox.Show("��������� ��������� ������!");
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

        #region ������ � COM-������

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
                    MessageBox.Show("��������� � ��������� ������!");
                }
            }
            else
            {
                MessageBox.Show("�������� COM ����!");
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
            comboBoxComPorts.Text = "�������� COM ����";
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

        #region ���������� � ���� � ������ �� ����

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

        #region ����������� ��������� � ������ � �������

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
                    for (int i = 0; i < actionThread1.Count; i++)
                    {
                        string[] tempRow = { i.ToString(), getActionNameByType(actionThread1[i].getType()), actionThread1[i].getTime().ToString() };
                        dataGridView1.Rows.Add(tempRow);
                    }
                    for (int i = 0; i < actionThread2.Count; i++)
                    {
                        string[] tempRow = { i.ToString(), getActionNameByType(actionThread2[i].getType()), actionThread2[i].getTime().ToString() };
                        dataGridView2.Rows.Add(tempRow);
                    }
                    for (int i = 0; i < actionThread3.Count; i++)
                    {
                        string[] tempRow = { i.ToString(), getActionNameByType(actionThread3[i].getType()), actionThread3[i].getTime().ToString() };
                        dataGridView3.Rows.Add(tempRow);
                    }
                    if (actionThread1.Count > 0)
                    {
                        buttonAddAfterSelectThread1.Enabled = true;
                        buttonDelThread1.Enabled = true;
                        buttonEditThread1.Enabled = true;
                    }
                    if (actionThread2.Count > 0)
                    {
                        buttonAddAfterSelectThread2.Enabled = true;
                        buttonDelThread2.Enabled = true;
                        buttonEditThread2.Enabled = true;
                    }
                    if (actionThread3.Count > 0)
                    {
                        buttonAddAfterSelectThread3.Enabled = true;
                        buttonDelThread3.Enabled = true;
                        buttonEditThread3.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("�� ���� �������� ���� ���������� ������������, �� ��������� � ��� ����������! ���������� �����.");
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
                MessageBox.Show("�� ���� �������� ���� ������������ ������������! ��������� ����� ��� �� ���������.");
            }
        }

        #endregion

        #region �������� �������� �� �������

        private void buttonDelThread1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedActionIndex = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                actionThread1.RemoveAt(selectedActionIndex);
                dataGridView1.Rows.Clear();
                if (actionThread1.Count > 0)
                {
                    for (int i = 0; i < actionThread1.Count; i++)
                    {
                        string[] tempRow = { i.ToString(), getActionNameByType(actionThread1[i].getType()), actionThread1[i].getTime().ToString() };
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
                MessageBox.Show("������ ��������!");
            }
        }

        private void buttonDelThread2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedActionIndex = Int32.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                actionThread2.RemoveAt(selectedActionIndex);
                dataGridView2.Rows.Clear();
                if (actionThread2.Count > 0)
                {
                    for (int i = 0; i < actionThread2.Count; i++)
                    {
                        string[] tempRow = { i.ToString(), getActionNameByType(actionThread2[i].getType()), actionThread2[i].getTime().ToString() };
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
                MessageBox.Show("������ ��������!");
            }
        }

        private void buttonDelThread3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int selectedActionIndex = Int32.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
                actionThread3.RemoveAt(selectedActionIndex);
                dataGridView3.Rows.Clear();
                if (actionThread3.Count > 0)
                {
                    for (int i = 0; i < actionThread3.Count; i++)
                    {
                        string[] tempRow = { i.ToString(), getActionNameByType(actionThread3[i].getType()), actionThread3[i].getTime().ToString() };
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
                MessageBox.Show("������ ��������!");
            }
        }

        #endregion

        private string getActionNameByType(int type)
        {
            switch (type)
            {
                case -1: return "";
                case 0: return "������ ����";
                case 1: return "������� �� �������";
                case 2: return "������� �� ����. �����.";
                case 3: return "������� �� �. �. �����.";
                case 4: return "����� �� �����.";
                case 5: return "����� �� �������";
                case 6: return "���� �� �����.";
                case 7: return "���� �� �������";
                case 8: return "�������� �����";
                case 9: return "���";
                case 10: return "��������";
                case 11: return "��������������";
                case 12: return "����������";
            }
            return "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeComPort();
        }
    }
}
