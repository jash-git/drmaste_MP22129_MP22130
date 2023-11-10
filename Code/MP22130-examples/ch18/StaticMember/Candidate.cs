using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    class Candidate
    {
        public string Name { get; set; }  // 候選人姓名(自動屬性實作)      
        private static int num;       // 記錄累計登記人數(私有靜態欄位成員)
        public static int Num        // 記錄累計登記人數為公用靜態唯讀屬性
        {
            get { return num; }
        }

        public Candidate()
        {
            num++;
        }

        public Candidate(string vname)
        {
            Name = vname;
            num++;
        }

        public static string Msg()
        {
            return $"目前登記總人數：{num} 人";
        }
    }
}
