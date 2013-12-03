namespace WebServiceGeneratorAddIn.UI
{
    partial class FrmProjectParams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSolutionPath = new System.Windows.Forms.Label();
            this.tbSolutionPath = new System.Windows.Forms.TextBox();
            this.tbSolutionName = new System.Windows.Forms.TextBox();
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.tbTemplatePath = new System.Windows.Forms.TextBox();
            this.lblTemplatePath = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbWsdlAddress = new System.Windows.Forms.TextBox();
            this.lblWsdlAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSolutionPath
            // 
            this.lblSolutionPath.AutoSize = true;
            this.lblSolutionPath.Location = new System.Drawing.Point(27, 71);
            this.lblSolutionPath.Name = "lblSolutionPath";
            this.lblSolutionPath.Size = new System.Drawing.Size(70, 13);
            this.lblSolutionPath.TabIndex = 0;
            this.lblSolutionPath.Text = "Solution Path";
            // 
            // tbSolutionPath
            // 
            this.tbSolutionPath.Location = new System.Drawing.Point(30, 87);
            this.tbSolutionPath.Name = "tbSolutionPath";
            this.tbSolutionPath.Size = new System.Drawing.Size(397, 20);
            this.tbSolutionPath.TabIndex = 2;
            // 
            // tbSolutionName
            // 
            this.tbSolutionName.Location = new System.Drawing.Point(30, 139);
            this.tbSolutionName.Name = "tbSolutionName";
            this.tbSolutionName.Size = new System.Drawing.Size(397, 20);
            this.tbSolutionName.TabIndex = 3;
            // 
            // lblSolutionName
            // 
            this.lblSolutionName.AutoSize = true;
            this.lblSolutionName.Location = new System.Drawing.Point(27, 123);
            this.lblSolutionName.Name = "lblSolutionName";
            this.lblSolutionName.Size = new System.Drawing.Size(76, 13);
            this.lblSolutionName.TabIndex = 2;
            this.lblSolutionName.Text = "Solution Name";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(30, 200);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(397, 20);
            this.tbProjectName.TabIndex = 4;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(27, 184);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(71, 13);
            this.lblProjectName.TabIndex = 4;
            this.lblProjectName.Text = "Project Name";
            // 
            // tbTemplatePath
            // 
            this.tbTemplatePath.Location = new System.Drawing.Point(30, 259);
            this.tbTemplatePath.Name = "tbTemplatePath";
            this.tbTemplatePath.Size = new System.Drawing.Size(397, 20);
            this.tbTemplatePath.TabIndex = 5;
            // 
            // lblTemplatePath
            // 
            this.lblTemplatePath.AutoSize = true;
            this.lblTemplatePath.Location = new System.Drawing.Point(27, 243);
            this.lblTemplatePath.Name = "lblTemplatePath";
            this.lblTemplatePath.Size = new System.Drawing.Size(76, 13);
            this.lblTemplatePath.TabIndex = 6;
            this.lblTemplatePath.Text = "Template Path";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(352, 311);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbWsdlAddress
            // 
            this.tbWsdlAddress.Location = new System.Drawing.Point(30, 34);
            this.tbWsdlAddress.Name = "tbWsdlAddress";
            this.tbWsdlAddress.Size = new System.Drawing.Size(397, 20);
            this.tbWsdlAddress.TabIndex = 1;
            // 
            // lblWsdlAddress
            // 
            this.lblWsdlAddress.AutoSize = true;
            this.lblWsdlAddress.Location = new System.Drawing.Point(27, 18);
            this.lblWsdlAddress.Name = "lblWsdlAddress";
            this.lblWsdlAddress.Size = new System.Drawing.Size(80, 13);
            this.lblWsdlAddress.TabIndex = 9;
            this.lblWsdlAddress.Text = "WSDL Address";
            // 
            // FrmProjectParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 352);
            this.Controls.Add(this.tbWsdlAddress);
            this.Controls.Add(this.lblWsdlAddress);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbTemplatePath);
            this.Controls.Add(this.lblTemplatePath);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.tbSolutionName);
            this.Controls.Add(this.lblSolutionName);
            this.Controls.Add(this.tbSolutionPath);
            this.Controls.Add(this.lblSolutionPath);
            this.Name = "FrmProjectParams";
            this.Text = "Web Service Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolutionPath;
        private System.Windows.Forms.TextBox tbSolutionPath;
        private System.Windows.Forms.TextBox tbSolutionName;
        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox tbTemplatePath;
        private System.Windows.Forms.Label lblTemplatePath;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbWsdlAddress;
        private System.Windows.Forms.Label lblWsdlAddress;
    }
}