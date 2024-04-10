using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmoreControlLibrary.SMInfo
{

    public delegate void TriDevice();

    public struct DeviceInfo
    {
        //产品型号
        public string  ProductModel;
        //设备编号
        public string EquipmentNumber;
        //模型版本
        public string ModelVersion;
        //模型日期
        public string ModelDate;
        //当前批次号
        public string BatchNumber;
    }

    public partial class SMInfoWindow : UserControl
    {
        #region property
        private string _projname;
        [Category("SmoreControl"),Description("项目名称")]
        public string ProjName
        {
            get { return _projname; }
            set { _projname = value; this.lbProjName.Text =$"  项目名称：{value}";}
        }

        private string _productname;
        [Category("SmoreControl"), Description("产品名称")]
        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; this.lbProductName.Text = $"  产品名称：{value}"; }
        }

        private string _number;
        [Category("SmoreControl"), Description("单号")]
        public string Number
        {
            get { return _number; }
            set { _number = value; this.lbNumber.Text = $"  委托单号：{value}"; }
        }

        private string _CurrUser;
        [Category("SmoreControl"), Description("当前用户")]
        public string CurrUser
        {
            get { return _CurrUser; }
            set { _CurrUser = value; this.lbCurUser.Text = $"  当前用户：{value}"; }
        }

        private string _DetectUser;
        [Category("SmoreControl"), Description("检测用户")]
        public string DetectUser
        {
            get { return _DetectUser; }
            set { _DetectUser = value; this.lbDetectPerson.Text = $"  检测用户：{value}"; }
        }

        private string _detectDate;
        [Category("SmoreControl"), Description("检测日期")]
        public string DetectDate
        {
            get { return _detectDate; }
            set { _detectDate = value; this.lbDetectDate.Text = $"  检测日期：{value}"; }
        }
        #endregion

        private XMLConfigParse m_XMLConfigParse = null;
        private static int ErrorOK = 0;
        private string ErrorInfo = "";
        private string ConfigFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}" + "Config\\" + "SmoreVisionConfig.xml";
       // private string ConfigFilePath = "";
        //设备信息
        private DeviceInfo _DeviceInfo;
        public DeviceInfo GetDeviceInfo
        {
            get { return _DeviceInfo; }
            set { _DeviceInfo = value; }
        }

        public TriDevice m_TriDevice;

        public SMInfoWindow()
        {
            InitializeComponent();
            
        }

        public void AddConfig(XMLConfigParse xmlConfig)
        {
            m_XMLConfigParse = xmlConfig;
        }

        private void smButton1_BtnClick(object sender, EventArgs e)
        {
            FormChangeInfo formChangeInfo = new FormChangeInfo();

            List<FileInfo> list = GetFamilyFiles(new DirectoryInfo($@"{AppDomain.CurrentDomain.BaseDirectory}Formula"));
            
            formChangeInfo.ProjName = m_XMLConfigParse.Device.Items[0].ProjName;
            formChangeInfo.DetectDate = m_XMLConfigParse.Device.Items[0].DetectDate;
            formChangeInfo.ProductName = m_XMLConfigParse.Device.Items[0].ProductName;
            formChangeInfo.AddItems(list);

            formChangeInfo.ShowDialog();

            if (!formChangeInfo.CHANGE) return;
            if (formChangeInfo.DetectDate == "" || formChangeInfo.DetectDate == null || formChangeInfo.ProjName == "" || formChangeInfo.ProjName == null || formChangeInfo.ProductName == "" || formChangeInfo.ProductName == null) return;
            m_XMLConfigParse.Device.Items[0].ProductName = formChangeInfo.ProductName;
            m_XMLConfigParse.Device.Items[0].DetectDate = formChangeInfo.DetectDate;
            m_XMLConfigParse.Device.Items[0].ProjName = formChangeInfo.ProjName;
            XMLSerialize.SerializeToXml<XMLConfigParse>(ConfigFilePath, m_XMLConfigParse, ref ErrorInfo);

            Update();
            m_TriDevice();
        }

        private void SMInfoWindow_Load(object sender, EventArgs e)
        {
            if(m_XMLConfigParse==null) m_XMLConfigParse = new XMLConfigParse();


        }

        public void Init()
        {
            int returnValue = InitialConfigFile();
            if (returnValue != ErrorOK)
            {
                MessageBox.Show($"加载配置文件失败,错误代码:{ErrorInfo}", "提示!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Update();

        }

        private void Update()
        {
            //项目名称
            ProjName = m_XMLConfigParse.Device.Items[0].ProjName;
            ////产品型号
            ProductName = m_XMLConfigParse.Device.Items[0].ProductName;
            //委托单号
            Number = m_XMLConfigParse.Device.Items[0].Number;
            //检测日期
            DetectDate = m_XMLConfigParse.Device.Items[0].DetectDate;
            //检测人员
            DetectUser = m_XMLConfigParse.Device.Items[0].DetectUser;
            //当前用户
            CurrUser = m_XMLConfigParse.Device.Items[0].CurrUser;
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


        private List<FileInfo> GetFamilyFiles(FileSystemInfo familyPath)
        {
            List<FileInfo> familyFileList = new List<FileInfo>();
            //判断目录是否存在
            if (!familyPath.Exists) return null;
            DirectoryInfo dir = familyPath as DirectoryInfo;
            //不是目录则返回
            if (dir == null) return null;
            //将文件后缀为rfa的文件添加进列表
            familyFileList.AddRange(dir.GetFiles("*.json"));
            //递归遍历文件夹
            foreach (DirectoryInfo dinfo in dir.GetDirectories())
            {
                familyFileList.AddRange(GetFamilyFiles(dinfo));
            }

            return familyFileList;
        }
    }
}
