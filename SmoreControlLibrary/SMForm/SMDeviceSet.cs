using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoreControlLibrary.SMForm
{
    public partial class SMDeviceSet : UserControl
    {

        private static int ErrorOK = 0;
        public const int ERROR_OK = 0;
        private static int ErrorFailed = -1;

        private string ErrorInfo = "";
        private XMLConfigParse m_XMLConfigParse = null;
        private string ConfigFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}" + "Config\\" + "SmoreVisionConfig.xml";
        public SMDeviceSet()
        {
            InitializeComponent();
            m_XMLConfigParse = new XMLConfigParse();
        }

        private void SMDeviceSet_Load(object sender, EventArgs e)
        {
            int returnValue = InitialConfigFile();
            if (returnValue != ErrorOK)
            {
                MessageBox.Show($"加载配置文件失败,错误代码:{ErrorInfo}", "提示!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ttProjName.textBox1.Text = m_XMLConfigParse.Device.Items[0].ProjName;
            ttProductName.textBox1.Text = m_XMLConfigParse.Device.Items[0].ProductName;
            ttNumber.textBox1.Text = m_XMLConfigParse.Device.Items[0].Number;
            ttDetectUser.textBox1.Text = m_XMLConfigParse.Device.Items[0].DetectUser;
            ttDetectDate.textBox1.Text = m_XMLConfigParse.Device.Items[0].DetectDate;
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

        private void btnSaveConfig_BtnClick(object sender, EventArgs e)
        {
            try
            {
            
                m_XMLConfigParse.Device.Items[0].ProjName = ttProjName.textBox1.Text;
                m_XMLConfigParse.Device.Items[0].ProductName = ttProductName.textBox1.Text;
                m_XMLConfigParse.Device.Items[0].Number = ttNumber.textBox1.Text;
                m_XMLConfigParse.Device.Items[0].DetectUser = ttDetectUser.textBox1.Text;
                m_XMLConfigParse.Device.Items[0].DetectDate = ttDetectDate.textBox1.Text;

                XMLSerialize.SerializeToXml<XMLConfigParse>(ConfigFilePath, m_XMLConfigParse, ref ErrorInfo);
                MessageBox.Show("保存成功!", "提示!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败,错误代码{ex.ToString()}", "提示!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
