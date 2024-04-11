﻿using CameraControlLibrary;
using HalconAlgoCtrlLib;
using HalconDotNet;
using SMLogControlLibrary;
using SmoreControlLibrary;
using SmoreControlLibrary.SMData;
using SmoreControlLibrary.SMForm;
using SmoreControlLibrary.SystemConfig;
using SmoreVision.CommClass;
using SmoreVision.HardwareControl;
using SmoreVision.HardwareControlClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmoreControlLibrary.SystemConfig.JsonFileParse;

namespace SmoreVision.BusinessClass
{
    public struct ProductInfo
    {
        public string Product_Model;
        public string Product_content;
    }
    public delegate void SendProductInfo(ProductInfo proinfo);
    public struct AlgoResult
    {
        public HObject oriImg;
        public HObject maskImg;
        public Dictionary<string, string> dicAlgoRes;
        public bool bAlgoResult;
    }


    public delegate void SendAlgoResult(AlgoResult _algoResult);
    public class ActionRunThread
    {
        private const int ERROR_OK = 0;
        private const int ERROR_FAILED = -1;

        public bool Cycled = false;
        private string LastError = "";
        private int returnValue = 0;

        private CameraInterface m_CameraControl = null;
        private HalcoImgProc m_halconImgProc;
        private SiemensPLCControl m_SiemensPLCControl;
        private XMLConfigParse m_XMLConfigParse;
        private Task m_ActionThreadProcess;
        bool bTri = true;
        bool bchange = true;
        public SendProductInfo m_sendProduct;
        public SendAlgoResult m_sendAlgoResult;

        public ActionRunThread(CameraInterface _CameraControl, SiemensPLCControl _siemensPLCControl)
        {
            m_CameraControl = _CameraControl;
            m_SiemensPLCControl = _siemensPLCControl;
        }

        public int StartThread()
        {
            if (m_ActionThreadProcess == null || m_ActionThreadProcess.IsCompleted == true)
            {
                m_ActionThreadProcess = Task.Factory.StartNew(() => ThreadProcedureProcess());
                SMLogWindow.OutLog("动作交互线程开启.", Color.Green);
            }
            return ERROR_OK;
        }

        public int ThreadProcedureProcess()
        {
            try
            {
                Cycled = true;
                while (Cycled)
                {
                    switch (m_CameraControl.CCDName)
                    {
                        case "CCD1":
                            {
                                //收到plc触发相机命令
                                //if (m_SiemensPLCControl.ReadBool("DB89.60.0") && bTri)
                                if (m_SiemensPLCControl.ReadBool(m_XMLConfigParse.PLC.Items[0].Value) && bTri)
                                {
                                    bTri = false;
                                    //触发相机取图                                  
                                    if(m_halconImgProc.yfOnlineExcute())
                                    //if(m_halconImgProc.GrabTestImg())
                                    {
                                        //图像处理
                                      Dictionary<string,string> dicTemp=  m_halconImgProc.ImgProcess();

                                        m_sendAlgoResult(new AlgoResult() { oriImg=m_halconImgProc.ImgGray,dicAlgoRes=dicTemp,bAlgoResult=false });
                                    }
                                    
                                }

                                //if (!m_SiemensPLCControl.ReadBool("DB89.60.0") && !bTri)
                                if (!m_SiemensPLCControl.ReadBool(m_XMLConfigParse.PLC.Items[0].Value) && !bTri) 
                                {
                                    bTri = true;
                                }
                            }
                            break;
                        case "CCD2":
                            {
                               
                            }
                            break;
                        default:
                            break;
                    }
                    Thread.Sleep(10);
                }
                SMLogWindow.OutLog("动作交互线程结束.", Color.Green);
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                MessageBox.Show($"{ex.ToString()}", "提示!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return ERROR_FAILED;
            }
        }



       
    }
}
