using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmoreVision.HardwareControlClass;

namespace SmoreControlLibrary.SMForm
{
    public partial class SMPLCSet : UserControl
    {
        private static int ErrorOK = 0;
        public const int ERROR_OK = 0;
        private static int ErrorFailed = -1;

        private string ErrorInfo = "";
        private XMLConfigParse m_XMLConfigParse = null;
        private string ConfigFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}" + "Config\\" + "SmoreVisionConfig.xml";

        private SiemensPLCControl m_SiemensPLCControl;

        private int returnValue = 0;

        public SMPLCSet()
        {
            InitializeComponent();
            m_XMLConfigParse = new XMLConfigParse();
            m_SiemensPLCControl = new SiemensPLCControl();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SMPLCSet_Load(object sender, EventArgs e)
        {
            int returnValue = InitialConfigFile();
            if (returnValue != ErrorOK)
            {
                MessageBox.Show($"加载配置文件失败,错误代码:{ErrorInfo}", "提示!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ttIP.textBox1.Text = m_XMLConfigParse.PLC.IP;
            ttPort.textBox1.Text = m_XMLConfigParse.PLC.Port.ToString();
            ttStartAdr.textBox1.Text = m_XMLConfigParse.PLC.Items[0].Adress;
            ttStartVal.textBox1.Text = m_XMLConfigParse.PLC.Items[0].Value;

            ttCallZeroAdr.textBox1.Text = m_XMLConfigParse.PLC.Items[1].Adress;
            ttCallbackZeroVal.textBox1.Text = m_XMLConfigParse.PLC.Items[1].Value;

            ttStopAdr.textBox1.Text = m_XMLConfigParse.PLC.Items[2].Adress;
            ttStopVal.textBox1.Text = m_XMLConfigParse.PLC.Items[2].Value;

            ttForwardAdr.textBox1.Text = m_XMLConfigParse.PLC.Items[3].Adress;
            ttForWardVal.textBox1.Text = m_XMLConfigParse.PLC.Items[3].Value;

            ttBackwardAdr.textBox1.Text = m_XMLConfigParse.PLC.Items[4].Adress;
            ttBackWardVal.textBox1.Text = m_XMLConfigParse.PLC.Items[4].Value;
        }

        private int InitialConfigFile()
        {
            int returnValue = XMLConfigParse.DeserializeFromXml<XMLConfigParse>(ConfigFilePath, ref m_XMLConfigParse, ref ErrorInfo);
            if (returnValue != XMLConfigParse.ErrorOK)
            {
                return returnValue;
            }
            returnValue = m_XMLConfigParse.GenerateNodeInfo();
            if (returnValue != XMLConfigParse.ErrorOK)
            {
                return returnValue;
            }
            return ErrorOK;
        }

        #region click_operation
        private void btnSaveConfig_BtnClick(object sender, EventArgs e)
        {
            try
            {
                m_XMLConfigParse.PLC.IP = ttIP.textBox1.Text.Trim();
                m_XMLConfigParse.PLC.Port = int.Parse(ttPort.textBox1.Text.Trim());


                m_XMLConfigParse.PLC.Items[0].Adress = ttStartAdr.textBox1.Text;
                m_XMLConfigParse.PLC.Items[0].Value = ttStartVal.textBox1.Text;

                m_XMLConfigParse.PLC.Items[1].Adress = ttCallZeroAdr.textBox1.Text;
                m_XMLConfigParse.PLC.Items[1].Value = ttCallbackZeroVal.textBox1.Text;

                m_XMLConfigParse.PLC.Items[2].Adress = ttStopAdr.textBox1.Text;
                m_XMLConfigParse.PLC.Items[2].Value = ttStopVal.textBox1.Text;

                m_XMLConfigParse.PLC.Items[3].Adress = ttForwardAdr.textBox1.Text;
                m_XMLConfigParse.PLC.Items[3].Value = ttForWardVal.textBox1.Text;

                m_XMLConfigParse.PLC.Items[4].Adress = ttBackwardAdr.textBox1.Text;
                m_XMLConfigParse.PLC.Items[4].Value = ttBackWardVal.textBox1.Text;


                XMLSerialize.SerializeToXml<XMLConfigParse>(ConfigFilePath, m_XMLConfigParse, ref ErrorInfo);
                MessageBox.Show("保存成功!", "提示!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败,错误代码{ex.ToString()}", "提示!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smButton2_BtnClick(object sender, EventArgs e)
        {
            returnValue = m_SiemensPLCControl.Initial(m_XMLConfigParse.PLC.IP);
            if (returnValue != ERROR_OK)
            {
                Console.WriteLine($"PLC初始化失败!");
                //Log.Add($"PLC初始化失败!", Color.Red);
                return;
            }
            else
            {
                Console.WriteLine($"PLC初始化成功!");
                //Log.Add($"PLC初始化成功!", Color.Green);
            }
        }

        private void btnPLCDDisConnect_BtnClick(object sender, EventArgs e)
        {

        }
        #endregion


        #region click_writedata
        private void btnStartWD_BtnClick(object sender, EventArgs e)
        {
            m_SiemensPLCControl.WriteUshort(m_XMLConfigParse.PLC.Items[0].Adress,ushort.Parse(m_XMLConfigParse.PLC.Items[0].Value));
        }

        private void btnCallZeroWD_BtnClick(object sender, EventArgs e)
        {
            m_SiemensPLCControl.WriteUshort(m_XMLConfigParse.PLC.Items[1].Adress, ushort.Parse(m_XMLConfigParse.PLC.Items[1].Value));
        }

        private void btnStopWD_BtnClick(object sender, EventArgs e)
        {
            m_SiemensPLCControl.WriteUshort(m_XMLConfigParse.PLC.Items[2].Adress, ushort.Parse(m_XMLConfigParse.PLC.Items[2].Value));
        }

        private void btnForWardWD_BtnClick(object sender, EventArgs e)
        {
            m_SiemensPLCControl.WriteUshort(m_XMLConfigParse.PLC.Items[3].Adress, ushort.Parse(m_XMLConfigParse.PLC.Items[3].Value));
        }

        private void btnBackwardWD_BtnClick(object sender, EventArgs e)
        {
            m_SiemensPLCControl.WriteUshort(m_XMLConfigParse.PLC.Items[4].Adress, ushort.Parse(m_XMLConfigParse.PLC.Items[4].Value));
        }

        #endregion

        #region click_readdata
        private void btnStartRD_BtnClick(object sender, EventArgs e)
        {
            bool bval = m_SiemensPLCControl.ReadBool(m_XMLConfigParse.PLC.Items[0].Adress);
            MessageBox.Show("Read::" + bval);
        }

        private void btnCallZeroRD_BtnClick(object sender, EventArgs e)
        {
            bool bval = m_SiemensPLCControl.ReadBool(m_XMLConfigParse.PLC.Items[1].Adress);
            MessageBox.Show("Read::" + bval);
        }

        private void btnStopRD_BtnClick(object sender, EventArgs e)
        {
            bool bval = m_SiemensPLCControl.ReadBool(m_XMLConfigParse.PLC.Items[2].Adress);
            MessageBox.Show("Read::" + bval);
        }

        private void btnForwardRD_BtnClick(object sender, EventArgs e)
        {
            bool bval = m_SiemensPLCControl.ReadBool(m_XMLConfigParse.PLC.Items[3].Adress);
            MessageBox.Show("Read::" + bval);
        }

        private void btnBackwardRD_BtnClick(object sender, EventArgs e)
        {
            bool bval = m_SiemensPLCControl.ReadBool(m_XMLConfigParse.PLC.Items[4].Adress);
            MessageBox.Show("Read::" + bval);
        }
        #endregion

        
    }
}
