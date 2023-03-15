using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WinForm
{
    class SVCNTT : SV
    {
        private float Pascal;
        private float C_Sharp;
        private float SQL;
        public SVCNTT() : base()
        {
            this.Pascal = 0;
            this.C_Sharp = 0;
            this.SQL = 0;
        }
        public SVCNTT(int masv, string ht, DateTime ns, bool gt, float pascal, float c_Sharp, float sql) : base(masv, ht, ns, gt)
        {
            this.Pascal = pascal;
            this.C_Sharp = c_Sharp;
            this.SQL = sql;
        }
        public override float dTB()
        {
            return (Pascal + C_Sharp + SQL) / 3;
        }
        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine($"Diem Pascal:{this.Pascal}");
            Console.WriteLine($"Diem C_Sharp:{this.C_Sharp}");
            Console.WriteLine($"Diem SQL:{this.SQL}");

        }
    }
}
