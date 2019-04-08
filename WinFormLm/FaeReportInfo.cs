using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WindowsFormsApplication1
{
   public class FaeReportInfo
    {
        
        public string Analysis_date { get; set; }
        public string Product { get; set; }
        public string Station { get; set; }
        public string  SN { get; set; }      
        public string Test_code { get; set; }
        public string  Analysis_method{ get; set; }
        public string  Root_cause { get; set; }
        public string Analyzer { get; set; }
        public Byte[] attach { get; set; }
        public string category { get; set; }
        public string Owner{ get; set; }
        public string AnalysisFromOwner { get; set; }
        public string Action { get; set; }
        public string Status{ get; set; }
        public string CloseDate { get; set; }
        public string Remark { get; set; }

    }
}
