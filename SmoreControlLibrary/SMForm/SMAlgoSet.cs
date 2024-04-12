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
    public partial class SMAlgoSet : UserControl
    {

        private static int ErrorOK = 0;
        public const int ERROR_OK = 0;
        private static int ErrorFailed = -1;

        private string ErrorInfo = "";
        private XMLConfigParse m_XMLConfigParse = null;
        private string ConfigFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}" + "Config\\" + "SmoreVisionConfig.xml";
        public SMAlgoSet()
        {
            InitializeComponent();
            m_XMLConfigParse = new XMLConfigParse();
        }

        private void SMAlgoSet_Load(object sender, EventArgs e)
        {
            int returnValue = InitialConfigFile();
            if (returnValue != ErrorOK)
            {
                MessageBox.Show($"加载配置文件失败,错误代码:{ErrorInfo}", "提示!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbtAlgoEnable.checkBox1.Checked=m_XMLConfigParse.Algo.RunEnable;

            lbPara1.Text=m_XMLConfigParse.Algo.Items[0].Name;
            lbPara2.Text=m_XMLConfigParse.Algo.Items[1].Name;
            lbPara3.Text=m_XMLConfigParse.Algo.Items[2].Name;
            lbPara4.Text=m_XMLConfigParse.Algo.Items[3].Name;
            lbPara5.Text=m_XMLConfigParse.Algo.Items[4].Name;

            ttPara1.textBox1.Text = m_XMLConfigParse.Algo.Items[0].Value;
            ttPara2.textBox1.Text = m_XMLConfigParse.Algo.Items[1].Value;
            ttPara3.textBox1.Text = m_XMLConfigParse.Algo.Items[2].Value;
            ttPara4.textBox1.Text = m_XMLConfigParse.Algo.Items[3].Value;
            ttPara5.textBox1.Text = m_XMLConfigParse.Algo.Items[4].Value;
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
                m_XMLConfigParse.Algo.RunEnable=cbtAlgoEnable.checkBox1.Checked;


                m_XMLConfigParse.Algo.Items[0].Value = ttPara1.textBox1.Text;
                m_XMLConfigParse.Algo.Items[1].Value = ttPara2.textBox1.Text;
                m_XMLConfigParse.Algo.Items[2].Value = ttPara3.textBox1.Text;
                m_XMLConfigParse.Algo.Items[3].Value = ttPara4.textBox1.Text;
                m_XMLConfigParse.Algo.Items[4].Value = ttPara5.textBox1.Text;

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
