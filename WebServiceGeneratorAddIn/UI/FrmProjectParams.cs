using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebServiceGeneratorAddIn.UI
{
    /// <summary>
    /// Add-In'in alacağı parametreleri sağlayan UI
    /// </summary>
    public partial class FrmProjectParams : Form
    {
        public CheckBox CbUseLink { get { return cbUseLink; } }
        
        private Connect addIn = null;
        private FrmManualWsdl frmManualWsdl = null;

        /// <summary>
        /// Parametre olarak Add-In'e ait olan objeyi alır
        /// </summary>
        /// <param name="addIn"></param>
        public FrmProjectParams(Connect addIn)
        {
            InitializeComponent();

            #region TEST_VALUES
            tbProjectName.Text = "TestProject";
            tbWsdlAddress.Text = "http://www.webservicex.com/globalweather.asmx?WSDL";
            tbSolutionPath.Text = @"D:\Test\";
            tbSolutionName.Text = "TestSolution";
            tbTemplatePath.Text = @"D:\TempProjectTemplates\Web\1033\WebServiceProject\WebServiceProject.vstemplate";
            #endregion

            this.addIn = addIn;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string wsdlAddress = tbWsdlAddress.Text;
            string solutionPath = tbSolutionPath.Text;
            string solutionName = tbSolutionName.Text;
            string projectName = tbProjectName.Text;
            string templatePath = tbTemplatePath.Text;

            //Eğer Wsdl adres linki kullanılacaksa
            if (cbUseLink.Checked)
                addIn.GenerateWebService(solutionPath, solutionName, projectName, templatePath, wsdlAddress, null);
            else
                addIn.GenerateWebService(solutionPath, solutionName, projectName, templatePath, null, frmManualWsdl.WsdlContent);
            this.Close();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frmManualWsdl = new FrmManualWsdl(this);
            frmManualWsdl.ShowDialog();
        }

        private void FrmProjectParams_Load(object sender, EventArgs e)
        {
            //Varsayılan olarak link kullan
            cbUseLink.Checked = true;
        }

        //Link kısmını checkbox'ın durumuna göre enable/disable et
        private void cbUseLink_CheckedChanged(object sender, EventArgs e)
        {
            tbWsdlAddress.Enabled = cbUseLink.Checked;
        }
    }
}
