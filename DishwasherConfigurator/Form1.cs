using System.IO.Ports;

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
            treeViewActionSelecter.Nodes[0].Nodes.Add("������ ����");                               // type: 0
            treeViewActionSelecter.Nodes[0].Nodes.Add("������� �� �������");                        // type: 1
            treeViewActionSelecter.Nodes[0].Nodes.Add("������� �� ������������ �����������");       // type: 2
            treeViewActionSelecter.Nodes[0].Nodes.Add("������� �� ����� ������ �����������");       // type: 3
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
            if (typeOfSelectedAction != -1)
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
                case "������ ����": return 0;
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
            return -1;
        }

        #endregion

        // TODO: ������� ��������� ���������� ��������

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeComPort();
        }
    }
}
