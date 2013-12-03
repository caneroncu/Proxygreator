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
        private Connect addIn = null;

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

            addIn.GenerateWebService(wsdlAddress, solutionPath, solutionName, projectName, templatePath);
            this.Close();
        }
    }
}
