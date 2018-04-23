using System;
// ...

namespace RunningSum {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private int currentTotal = 0;

        private void Detail_BeforePrint(object sender, 
        System.Drawing.Printing.PrintEventArgs e) {
            currentTotal += Convert.ToInt32(this.GetCurrentColumnValue("UnitsOnOrder"));
        }

        private void GroupFooter1_BeforePrint(object sender, 
        System.Drawing.Printing.PrintEventArgs e) {
            this.xrLabel3.Text = currentTotal.ToString();
        }

    }
}
