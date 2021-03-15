using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_1
{
    class Gun
    {

        private string name;
        private float caliber;
        private double shotRange;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Caliber
        {
            get { return caliber; }
            set { caliber = value; }
        }
        public double ShotRange
        {
            get { return shotRange; }
            set { shotRange = value; }
        }

        
    }


}
