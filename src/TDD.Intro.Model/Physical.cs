using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Intro.Model
{
    public class Physical : Person
    {
        public DateTime BornDate { get; set; }

        public virtual string GetSummarizedInfo()
        {
            return string.Format("Name: {0}, Born Date: {1}", Name, BornDate.ToShortDateString());
        }
    }
}
