using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebServiceGeneratorAddIn.UI
{
    public partial class FrmManualWsdl : Form
    {
        public string WsdlContent { get; set; }

        private Form callerForm = null;

        public FrmManualWsdl(Form callerForm)
        {
            InitializeComponent();

            this.callerForm = callerForm;
        }

        private void btnSaveWsdlContent_Click(object sender, EventArgs e)
        {
            WsdlContent = tbWsdlContent.Text;
            //Manual Wsdl kaydı yapıldıysa use link checkbox'unun tick'ini kaldır
            ((FrmProjectParams)callerForm).CbUseLink.Checked = false;
            this.Close();
        }

        private void FrmManualWsdl_Load(object sender, EventArgs e)
        {

        }
    }
}
