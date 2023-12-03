using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employez_salary
{
    public class Employe:Persone
    {
        public string designation { get; set; }
        public string Department { get; set; }
        private double HR { get; set; }
        private double PF { get; set; }
        private double TA { get; set; }
        private double Basic { get; set; }

        public Employe(double hr,double pf,double ta, double basic) 
        {
            HR= hr;
            PF= pf;
            TA= ta;
            Basic= basic;
        }
        public double Salary()
        {
            return HR-PF + TA+Basic;
        }
    }
}
