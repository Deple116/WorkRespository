using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using HalconDotNet;
using CameraControlLibrary;

namespace HalconAlgoCtrlLib
{

    public struct CameraHalconImageCallPack
    {
        public HObject picture;
    }
    public class HalconCamCotrol:CameraInterface<CameraHalconImageCallPack>
    {

        public const int ERROR_OK = 0;
        public const int ERROR_FAILED = -1;
        public string LastError { get; private set; } = "";
        public ConcurrentQueue<CameraHalconImageCallPack> cameraImageCallPack_Buffer;

        private HalcoImgProc halcoImgProc;

        public HalconCamCotrol(string _cameraName)
        {
            CCDName = _cameraName;
            halcoImgProc = new HalcoImgProc();

            cameraImageCallPack_Buffer = new ConcurrentQueue<CameraHalconImageCallPack>();

        }

        #region Interface

        public string CCDName { get; set; } = "";

        public string cameraType { get; set; } = "";
        public int Initial()
        {
            try
            {
                if(!halcoImgProc.OpenAcq()) return ERROR_FAILED;
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int DeInitial()
        {
            try
            {

                if (halcoImgProc != null)
                {
                    if (!halcoImgProc.CloseAcq())
                    {
                        LastError = $"相机{CCDName}关闭失败!";
                        return ERROR_FAILED;
                    }
                }
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int LoadCfg(string filepath)
        {
            try
            {

                //if (m_DahuaCamera.loadCfg(filepath))
                //{
                //    return ERROR_OK;
                //}
                //else
                //{
                //    LastError = $"相机{CCDName}loadcfg失败!";
                //    return ERROR_FAILED;
                //}
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int SetSoftwareTriggerMode()
        {
            if (!halcoImgProc.setSoftwareTriggerMode())
            {
                LastError = $"设置相机{CCDName}为软触发模式失败!";
                return ERROR_FAILED;
            }
            return ERROR_OK;
        }

        public int SetExternalTriggerMode()
        {
            if (!halcoImgProc.setExternalTriggerMode())
            {
                LastError = $"设置相机{CCDName}为外部触发模式失败!";
                return ERROR_FAILED;
            }
            return ERROR_OK;
        }

        public int SoftWareTriggerOnce()
        {
            try
            {
                if (!halcoImgProc.softWareTriggerOnce())
                {
                    LastError = $"相机{CCDName}单次软触发失败!";
                    return ERROR_FAILED;
                }
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int SetFreeRunMode()
        {
            try
            {              
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int StopGrab()
        {
            try
            {
               
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int StartGrab()
        {
            try
            {

                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int SetExposure(float _value)
        {
            try
            {
                if (halcoImgProc.setExposure(_value))
                {
                    return ERROR_OK;
                }
                else
                {
                    LastError = $"相机{CCDName}设置曝光时间失败!";
                    return ERROR_FAILED;
                }
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int SetGamma(double _value)
        {
            try
            {
               
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int SetTriggerDlay(float _value)
        {
            try
            {
                
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int GetExposure(ref float _value)
        {
            try
            {
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int setGain(float _value)
        {
            try
            {
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int setUserConfig(int index)
        {
            try
            {
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int setSharpness(long _value)
        {
            try
            {
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int getGain(ref float _value)
        {
            try
            {
                
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int SetBlanceWhite(uint _rvalue, uint _gvalue, uint _bvalue)
        {
            try
            {
                return ERROR_OK;

            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public bool IsEmpty()
        {

            return cameraImageCallPack_Buffer.IsEmpty;
        }

        public CameraHalconImageCallPack TryDequeue()
        {
            CameraHalconImageCallPack cameraImageCallPack = new CameraHalconImageCallPack();
            cameraImageCallPack_Buffer.TryDequeue(out cameraImageCallPack);
            return cameraImageCallPack;
        }



        #endregion
    }
}
