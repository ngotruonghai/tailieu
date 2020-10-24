using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mohinh3L
{
    public partial class Form2 : Form
    {
        public DataTable dt_DG = new DataTable();
        public Form2(DataTable dt)
        {
            InitializeComponent();
            dt_DG = dt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 crp = new CrystalReport1();
            crp.SetDataSource(dt_DG); //chỉ định datasource cho report
            crystalReportViewer1.ReportSource = crp; //hiển thị report lên form

        }
    }
}
