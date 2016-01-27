using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Intro.Model
{
    public class Company : Person
    {
        public string IdentificationCode { get; set; }
        
        public override string GetSummarizedInfo()
        {
            return string.Format("Name: {0}, Identification Code: {1}", Name, IdentificationCode);
        }
    }
}