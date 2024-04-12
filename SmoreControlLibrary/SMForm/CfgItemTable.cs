using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoreControlLibrary.SMForm
{
   
    public partial class CfgItemTable : UserControl
    {
        public CfgItemTable()
        {
            InitializeComponent();
        }

        public void InitControl(Dictionary<int,cfgItemPara> _dic)
        {
            tableLayoutPanel1.ColumnCount=_dic.Count;
            for (int i=0;i<_dic.Count;i++)
            {
                switch (_dic[i].type)
                {
                    case CtrlType.Label:
                        tableLayoutPanel1.Controls.Add(new Label() {TextAlign=ContentAlignment.MiddleCenter, Name=_dic[i].Name, Text=_dic[i].Content,
                                                    Font=new Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                                                    ForeColor = System.Drawing.Color.Black,
                                                    BackColor = System.Drawing.Color.Transparent
                                                    },i, 0);
                        break;
                    case CtrlType.Button:
                        break;
                    case CtrlType.Text:
                        break;
                }

            }
        }

    }

    public class cfgItemPara
    {
        public string Name;
        public string Content;
        public CtrlType type;
    }

    public enum CtrlType
    {
        Label,
        Button,
        Text,
    }


}
