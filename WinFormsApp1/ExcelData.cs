using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp1
{
    public class ExcelData
    {
        public string name { get; set; }
        
        public string video { get; set; }
        public int i { get; set; }
        public int n { get; set; }
        public string time { get; set; }

        public string ctime {  get; set; }

        public ExcelData(string name, string video, int i, int n, string time, string ctime)
        {
            this.name = name;
            this.video = video;
            this.i = i;
            this.n = n;
            this.time = time;
            this.ctime = ctime;
        }

        public string returnData()
        {
            return this.name + " | " + this.video + " | " + this.i + " | " + this.n + " | " + this.time + " | " + this.ctime + " |";
        }
    }
}
