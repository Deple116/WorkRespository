using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ToolTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathGray = "C:\\Users\\deple\\Desktop\\延锋\\github\\bin\\Debug\\Algo\\Halcon\\Images\\yf\\2位_Gray.tif";
            string pathHeight = "C:\\Users\\deple\\Desktop\\延锋\\github\\bin\\Debug\\Algo\\Halcon\\Images\\yf\\2位_Height.tif";

            Console.WriteLine($"path:{pathGray}");

            List<string> strRes = GetSpecPath(pathGray);

            Console.WriteLine($"strRes:{string.Join(";",strRes.ToArray())}");

            Console.WriteLine("end");
            Console.ReadKey();

        }

        public static List<string> GetSpecPath(string path)
        {
            List<string> templist = new List<string>();

            string[] splitFold = path.Split(new char[] { '\\' });

            string lastItem = splitFold[splitFold.Length-1];

            bool bgray = lastItem.Contains("Gray");
            bool bHeight = lastItem.Contains("Height");

            if (!bgray&&!bHeight) { return null; }
            string temp = "";
            if (bgray) temp=lastItem.Replace("Gray", "Height");
            if (bHeight) temp=lastItem.Replace("Height", "Gray");

            splitFold[splitFold.Length-1]=temp;
            string strRes = string.Join("\\", splitFold);

            templist.Add(bHeight ? path:strRes);
            templist.Add(bgray ? path : strRes);
            return templist;
        }
    }
}
