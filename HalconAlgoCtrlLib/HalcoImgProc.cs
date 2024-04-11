using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalconAlgoCtrlLib
{
    public class HalcoImgProc
    {

        private HDevEngine MyEngine = new HDevEngine();

        HImage hImageHeight = new HImage();
        HImage hImageGray = new HImage();
        HImage hImageX = new HImage();
        HImage hImageY = new HImage();
        HImage hImageZ = new HImage();

        HTuple AcqHandle1 = new HTuple();

        public HRegion hRegion = new HRegion();
        HRegion FinRegion = new HRegion();

        HObject dupImg = new HObject();

        HDevengineClass m_HDevengineClass;
        HTuple ImageFiles;
        HObject obj;

        #region 属性
        public string CCDName { get; set; } = "CCD1";
        public HObject ImgGray
        {
            get=> hImageGray;
        }

        #endregion


        #region 延锋3D

        public void yfInit()
        {
            m_HDevengineClass = new HDevengineClass();

            HOperatorSet.SetSystem("clip_region", "false");
            hRegion.ReadObject(Application.StartupPath + "\\Algo\\Halcon\\settings\\yf\\CircleTest.hobj");

            m_HDevengineClass.Init(Application.StartupPath + "\\Algo\\Halcon\\Main\\yf_test.hdev",
                                   Application.StartupPath + "\\Algo\\Halcon\\ThirdParty\\yf",
                                   new HTuple("ReadImg", "yf_get_sort_regoion", "Preprocess", "yf_get_xyz_value", "open_acquisition", "yf_grab_3d_image", "yf_grab_image", "close_acquisition"));
            // m_ListBox.AddInfo("初始化成功");
            OpenAcq();

        }

        public bool OpenAcq()
        {
            try
            {
                m_HDevengineClass.Excute(4);
                AcqHandle1=m_HDevengineClass.GetTup(4, "AcqHandle");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<string> yfReadImgFolder()
        {
            //yfcmb.Items.Clear();
            //HTuple ImageFiles;

            List<string> m_list = new List<string>();

            m_HDevengineClass.SetTup(0, "ImagePath", Application.StartupPath + "\\Algo\\Halcon\\Images\\yf");
            m_HDevengineClass.Excute(0);
            ImageFiles = m_HDevengineClass.GetTup(0, "ImageFiles");

            int inum = ImageFiles.Length;
            for (int i = 0; i < inum; i++)
            {
                m_list.Add(ImageFiles[i]);
                //yfcmb.Items.Add(i);
            }
            //yfcmb.SelectedIndex = 0;
            //m_ListBox.AddInfo("加载成功");
            return m_list;
        }
        public HObject yfGetImg(int index)
        {
            HObject objTemp;
            HOperatorSet.ReadImage(out objTemp, (HTuple)ImageFiles[index]);
            hImageGray.ReadImage((HTuple)ImageFiles[index]);
            return hImageGray;
        }
        public bool yfOfflineExcute(int index)
        {

            try
            {
                //  int index = yfcmb.SelectedIndex;

                hImageHeight.ReadImage((HTuple)ImageFiles[index-1]);
                m_HDevengineClass.SetObj(2, "HeightImg", hImageHeight);
                m_HDevengineClass.Excute(2);
                hImageX = m_HDevengineClass.GetImg(2, "ImageX");
                hImageY = m_HDevengineClass.GetImg(2, "ImageY");
                hImageZ = m_HDevengineClass.GetImg(2, "ImageZ");

                hImageGray.ReadImage((HTuple)ImageFiles[index]);

                // m_ListBox.AddInfo("执行成功");
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
                //m_ListBox.AddInfo(ex.ToString());
            }
        }

        public bool yfOnlineExcute()
        {
            try
            {
                m_HDevengineClass.SetTup(5, "AcqHandle", AcqHandle1);
                m_HDevengineClass.Excute(5);
                hImageGray=m_HDevengineClass.GetImg(5, "ImageGray");
                hImageX = m_HDevengineClass.GetImg(5, "ImageX");
                hImageY = m_HDevengineClass.GetImg(5, "ImageY");
                hImageZ = m_HDevengineClass.GetImg(5, "ImageZ");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool GrabTestImg()
        {
            try
            {
                m_HDevengineClass.SetTup(6, "AcqHandle", AcqHandle1);
                m_HDevengineClass.Excute(6);
                hImageGray=m_HDevengineClass.GetImg(6, "Image");
               // hImageGray.WriteImage("tiff", 0, "20240411.tif");
                return true;
            }catch(Exception ex)
            {
                return false;
            }
            
        }
        public Dictionary<string, string> ImgProcess()
        {
            Dictionary<string, string> dictemp = new Dictionary<string, string>();
            m_HDevengineClass.SetObj(3, "ImageGray", hImageGray);
            m_HDevengineClass.SetObj(3, "ImageX", hImageX);
            m_HDevengineClass.SetObj(3, "ImageY", hImageY);
            m_HDevengineClass.SetObj(3, "ImageZ", hImageZ);
            m_HDevengineClass.SetObj(3, "RegionPoint", hRegion);
            m_HDevengineClass.Excute(3);

            dupImg = m_HDevengineClass.GetObj(3, "MaskImg");
            HTuple xTuples = m_HDevengineClass.GetTup(3, "x_tuples");
            HTuple yTuples = m_HDevengineClass.GetTup(3, "y_tuples");
            HTuple zTuples = m_HDevengineClass.GetTup(3, "z_tuples");

            //Debug.WriteLine($"xtuples;{GetValArr(xTuples.ToFArr().ToList())}");
            //Debug.WriteLine($"ytuples;{GetValArr(yTuples.ToFArr().ToList())}");
            //Debug.WriteLine($"ztuples;{GetValArr(zTuples.ToFArr().ToList())}");

            dictemp.Add("xval", GetValArr(xTuples.ToFArr().ToList()));
            dictemp.Add("yval", GetValArr(yTuples.ToFArr().ToList()));
            dictemp.Add("zval", GetValArr(zTuples.ToFArr().ToList()));

            return dictemp;
        }

        public HObject GetMaskImg()
        {
            return dupImg;
        }
        private string GetValArr<T>(List<T> list)
        {
            string xval = "";
            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())//判断是否是最后一个元素
            {
                xval += enumerator.Current + ";";
            }
            return xval;
        }

        #endregion

        #region 调试

        public void StartDebug()
        {
            MyEngine.SetEngineAttribute("execute_procedures_jit_compiled", "false");

            // Set debug parameters
            MyEngine.SetEngineAttribute("debug_port", 57786);
            // MyEngine.SetEngineAttribute("debug_password", "1234");
            //MyEngine.SetEngineAttribute("debug_wait_for_connection","true");

            // Start debug server
            MyEngine.StartDebugServer();
        }
        #endregion
    }
}
