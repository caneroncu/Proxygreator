namespace WebServiceGeneratorAddIn.UI
{
    partial class FrmManualWsdl
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
            this.tbWsdlContent = new System.Windows.Forms.TextBox();
            this.btnSaveWsdlContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWsdlContent
            // 
            this.tbWsdlContent.Location = new System.Drawing.Point(12, 12);
            this.tbWsdlContent.Multiline = true;
            this.tbWsdlContent.Name = "tbWsdlContent";
            this.tbWsdlContent.Size = new System.Drawing.Size(620, 546);
            this.tbWsdlContent.TabIndex = 0;
            // 
            // btnSaveWsdlContent
            // 
            this.btnSaveWsdlContent.Location = new System.Drawing.Point(557, 569);
            this.btnSaveWsdlContent.Name = "btnSaveWsdlContent";
            this.btnSaveWsdlContent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWsdlContent.TabIndex = 1;
            this.btnSaveWsdlContent.Text = "Save";
            this.btnSaveWsdlContent.UseVisualStyleBackColor = true;
            this.btnSaveWsdlContent.Click += new System.EventHandler(this.btnSaveWsdlContent_Click);
            // 
            // FrmManualWsdl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 604);
            this.Controls.Add(this.btnSaveWsdlContent);
            this.Controls.Add(this.tbWsdlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManualWsdl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter WSDL content";
            this.Load += new System.EventHandler(this.FrmManualWsdl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWsdlContent;
        private System.Windows.Forms.Button btnSaveWsdlContent;
    }
}