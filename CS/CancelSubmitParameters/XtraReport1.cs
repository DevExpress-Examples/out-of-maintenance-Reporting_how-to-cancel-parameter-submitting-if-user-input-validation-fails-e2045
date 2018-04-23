using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
// ...

namespace CancelSubmitParameters {
    public partial class XtraReport1 : XtraReport {
        int parameter;
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_ParametersRequestSubmit(object sender, 
            ParametersRequestEventArgs e) {
            if ((int)e.ParametersInformation[0].Parameter.Value > 10 || 
                (int)e.ParametersInformation[0].Parameter.Value < 0) {
                e.ParametersInformation[0].Parameter.Value = parameter;
                e.ParametersInformation[0].Editor.Text = parameter.ToString();
            }
        }

        private void XtraReport1_ParametersRequestValueChanged(object sender, 
            ParametersRequestValueChangedEventArgs e) {
            parameter = (int)e.ChangedParameterInfo.Parameter.Value;
        }

    }
}
