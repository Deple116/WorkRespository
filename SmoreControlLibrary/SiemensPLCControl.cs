﻿using HslCommunication;
using HslCommunication.Profinet.Siemens;
using System;
using System.Drawing;
using System.Text;
using System.Threading;

namespace SmoreVision.HardwareControlClass
{
    public class SiemensPLCControl
    {
        private const int ERROR_OK = 0;
        private const int ERROR_FAILED = -1;

        private const bool ERROR_TRUE = true;
        private const bool ERROR_FALSE = false;

        public string LastError { get; private set; } = "";

        private static object objWrite = new object();


        public string ErrorInfo = "";

        private SiemensS7Net m_Siemens;

        public SiemensPLCControl()
        {
            
            if (HslCommunication.Authorization.SetAuthorizationCode("f562cc4c-4772-4b32-bdcd-f3e122c534e3"))
            {
                //SMLogWindow.OutLog("PLC通信注册成功.", Color.Green);
                Console.WriteLine($"PLC通信注册成功.");
            }
            else
            {
                //SMLogWindow.OutLog("PLC通信注册失败.", Color.Red);
            }
        }

        public int Initial(string ip)
        {
            try
            {
                m_Siemens = new SiemensS7Net(SiemensPLCS.S200Smart, ip) { ConnectTimeOut = 5000 };
                OperateResult connect = m_Siemens.ConnectServer();
                if (connect.IsSuccess)
                {
                    return ERROR_OK;
                }
                else
                {
                    return ERROR_FAILED;
                }
            }
            catch (Exception ex)
            {
                ErrorInfo = ex.ToString();
                return ERROR_FAILED;
            }
        }

        public int DeInitial()
        {
            try
            {

                if(m_Siemens!=null)m_Siemens.ConnectClose();
                return ERROR_OK;
            }
            catch (Exception ex)
            {
                ErrorInfo = ex.ToString();
                return ERROR_FAILED;
            }
        }

        /// <summary>
        /// 写Bool操作
        /// </summary>
        /// <returns></returns>
        public int WriteBool(string _dbAddress, bool _result)
        {
            try
            {
                if (m_Siemens==null) return ERROR_FAILED;
                lock (objWrite)
                {
                    OperateResult operateResult = m_Siemens.Write(_dbAddress, _result);
                    while (true)
                    {
                        //Thread.Sleep(50);
                        OperateResult<bool> result = m_Siemens.ReadBool(_dbAddress);
                        if (result.Content == _result)
                        {
                            return ERROR_OK;
                        }
                        else
                        {
                            OperateResult operateResultAgain = m_Siemens.Write(_dbAddress, _result);
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        /// <summary>
        /// 读Bool操作
        /// </summary>
        /// <returns></returns>
        public bool ReadBool(string _dbAddress)
        {
            try
            {
                OperateResult<bool> result=new OperateResult<bool>();
                if (m_Siemens!=null) result= m_Siemens.ReadBool(_dbAddress);
                return result.Content;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FALSE;
            }
        }

        /// <summary>
        /// 读ushort
        /// </summary>
        /// <param name="_dbAddress"></param>
        /// <returns></returns>
        public ushort ReadUshort(string _dbAddress)
        {
            try
            {
                OperateResult<ushort> result = new OperateResult<ushort>();
                if (m_Siemens!=null) result= m_Siemens.ReadUInt16(_dbAddress);

                return result.Content;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// 读ushort
        /// </summary>
        /// <param name="_dbAddress"></param>
        /// <returns></returns>
        public Byte ReadByte(string _dbAddress)
        {
            try
            {
                OperateResult<Byte> result = new OperateResult<Byte>();
                if (m_Siemens!=null) result= m_Siemens.ReadByte(_dbAddress);

                return result.Content;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dbAddress"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int WriteUshort(string _dbAddress, ushort value)
        {
            try
            {
                if (m_Siemens==null) return ERROR_FAILED;
                lock (objWrite)
                {
                    OperateResult operateResult = m_Siemens.Write(_dbAddress, value);
                    while (true)
                    {
                        //Thread.Sleep(50);
                        OperateResult<ushort> result = m_Siemens.ReadUInt16(_dbAddress);
                        if (result.Content == value)
                        {
                            return ERROR_OK;
                        }
                        else
                        {
                            OperateResult operateResultAgain = m_Siemens.Write(_dbAddress, value);
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return ERROR_FAILED;
            }
        }

        /// <summary>
        /// 读字符串
        /// </summary>
        /// <param name="_dbAddress"></param>
        /// <returns></returns>
        public string ReadString(string _dbAddress)
        {
            try
            {
                if (m_Siemens==null) return new OperateResult<string>().Content;
                OperateResult<string> result = m_Siemens.ReadString(_dbAddress, 16, Encoding.UTF8);
                return result.Content;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
