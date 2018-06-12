using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiWinfrom
{
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }
        public String CatID;
        public string err;
        public void HienThiReport()
        {
            BLL_QuanLySP bll = new BLL_QuanLySP();
            DataTable dt = new DataTable();
            dt = bll.GetListProWithCatID(ref err, Convert.ToInt32(CatID));
            dt.Columns.Add("STT");
            int i = 1;
            foreach (DataRow item in dt.Rows)
            {
                item["STT"] = i;
                i++;
            }
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "ThiWinfrom.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource _dataSource = new ReportDataSource("DS_InBaoCao", dt);
            reportViewer1.LocalReport.DataSources.Add(_dataSource);
            this.reportViewer1.RefreshReport();
        }
        private void Frm_Report_Load(object sender, EventArgs e)
        {
            HienThiReport();
            
        }
    }
}
