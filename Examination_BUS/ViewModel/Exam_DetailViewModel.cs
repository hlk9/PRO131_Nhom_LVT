using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.ViewModel
{
    public class Exam_DetailViewModel
    {
        public int Id { get; set; }

        public string examDetailCode { get; set; }

        public int duration { get; set; }

        public double passMark { get; set; }

        public int totalQuestion { get; set; }

        public double maxiumMark { get; set; }

        public int reTestNumber { get; set;}
    }
}
