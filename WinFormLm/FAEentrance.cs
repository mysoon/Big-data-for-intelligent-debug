using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FAEentrance : Form
    {
        public FAEentrance()
        {
            InitializeComponent();
        }

  

        private void recordUpload_Click_1(object sender, EventArgs e)
        {
            string sql = null;

            FaeReportInfo analysisRecord = new FaeReportInfo();
            analysisRecord.Analysis_date = string.Format("{0:d}", failureDebugDate.Value);
            analysisRecord.Product = familyName.Text.Trim();
            analysisRecord.Station = testStationName.Text.Trim();
            analysisRecord.SN = serialNumber.Text.Trim();

            analysisRecord.Test_code = failureCode.Text.Trim();
            analysisRecord.Analysis_method = debugNotes.Text.Trim();
            analysisRecord.Root_cause = failureRootCause.Text.Trim();
            analysisRecord.Analyzer = AnaID.Text.Trim();
            analysisRecord.attach = null;
            analysisRecord.category = failueCatalog.Text.Trim();
            analysisRecord.Owner = ownerShip.Text.Trim();
            analysisRecord.AnalysisFromOwner = ownerCommend.Text.Trim();
            analysisRecord.Action = improveAction.Text.Trim();
            analysisRecord.Status = improveStatus.Text.Trim();
            analysisRecord.CloseDate = string.Format("{0:d}", failureDebugDate.Value);
            analysisRecord.Remark = remark.Text.Trim();
            sql = string.Format("insert into faereport(Analysis_date,Product,Station,SN,Test_code,Analysis_method,Root_cause,Analyzer,attach, category,Owner,AnalysisFromOwner,Action,Status,CloseDate,Remark)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')"
                ,analysisRecord.Analysis_date, analysisRecord.Product, analysisRecord.Station, analysisRecord.SN, analysisRecord.Test_code, analysisRecord.Analysis_method, analysisRecord.Root_cause, analysisRecord.Analyzer, analysisRecord.attach, analysisRecord.category, analysisRecord.Owner, analysisRecord.AnalysisFromOwner, analysisRecord.Action, analysisRecord.Status, analysisRecord.CloseDate, analysisRecord.Remark);
            //sql = string.Format("insert into faereport(Analysis_date,Product,Station,SN,Test_code,Analysis_method,Root_cause,Analyzer)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", analysisRecord.Analysis_date, analysisRecord.Product, analysisRecord.Station, analysisRecord.SN, analysisRecord.Test_code, analysisRecord.Analysis_method, analysisRecord.Root_cause, analysisRecord.Analyzer);
            int i = WinFormLm.SqlHelper.update(sql);
        }
    }
}
