using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class CStudent : IPass, ILevel
    {
        private String passOK;
        private int score = 60;      	// 設定及格分數
        public int Score            	// 實作score屬性
        {
            get { return score; }
            set { score = value; }
        }
        public String Pass(int grade)  	// 實作Pass()方法 
        {
            if (grade >= score) passOK = "及格";
            else passOK = "不及格";
            return passOK;
        }
        // ------------------------------------------------------------------------------
        private String levelN;
        private int high = 80;       	// 設定高標分數
        public int High            	// 實作High屬性
        {
            get { return high; }
            set { high = value; }
        }
        private int low = 50;       	// 設定低標分數
        public int Low            	// 實作Low屬性
        {
            get { return low; }
            set { low = value; }
        }
        public String Level(int grade)  // 實作Level()方法
        {
            if (grade >= high) levelN = "表現優異";
            if ((grade >= low) && (grade<high)) levelN = "差強人意";
            if (grade < low) levelN = "有待加強";
            return levelN;
        }
    }
}
