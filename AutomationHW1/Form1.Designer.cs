namespace AutomationHW1
{
    partial class Form1
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
            this.LabelProject = new System.Windows.Forms.Label();
            this.LabelAccessToken = new System.Windows.Forms.Label();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.LabelTestName = new System.Windows.Forms.Label();
            this.LabelTestID = new System.Windows.Forms.Label();
            this.LabelConfigFile = new System.Windows.Forms.Label();
            this.LabelReportFile = new System.Windows.Forms.Label();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.textBoxTestID = new System.Windows.Forms.TextBox();
            this.textBoxConfigFile = new System.Windows.Forms.TextBox();
            this.textBoxReportFile = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.buttonRunTest = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxAccessToken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelProject
            // 
            this.LabelProject.AutoSize = true;
            this.LabelProject.Location = new System.Drawing.Point(32, 27);
            this.LabelProject.Name = "LabelProject";
            this.LabelProject.Size = new System.Drawing.Size(52, 17);
            this.LabelProject.TabIndex = 0;
            this.LabelProject.Text = "Project";
            // 
            // LabelAccessToken
            // 
            this.LabelAccessToken.AutoSize = true;
            this.LabelAccessToken.Location = new System.Drawing.Point(30, 57);
            this.LabelAccessToken.Name = "LabelAccessToken";
            this.LabelAccessToken.Size = new System.Drawing.Size(97, 17);
            this.LabelAccessToken.TabIndex = 1;
            this.LabelAccessToken.Text = "Access Token";
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Location = new System.Drawing.Point(32, 87);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(43, 17);
            this.LabelLabel.TabIndex = 2;
            this.LabelLabel.Text = "Label";
            // 
            // LabelTestName
            // 
            this.LabelTestName.AutoSize = true;
            this.LabelTestName.Location = new System.Drawing.Point(30, 119);
            this.LabelTestName.Name = "LabelTestName";
            this.LabelTestName.Size = new System.Drawing.Size(77, 17);
            this.LabelTestName.TabIndex = 3;
            this.LabelTestName.Text = "Test Name";
            // 
            // LabelTestID
            // 
            this.LabelTestID.AutoSize = true;
            this.LabelTestID.Location = new System.Drawing.Point(30, 149);
            this.LabelTestID.Name = "LabelTestID";
            this.LabelTestID.Size = new System.Drawing.Size(53, 17);
            this.LabelTestID.TabIndex = 4;
            this.LabelTestID.Text = "Test ID";
            // 
            // LabelConfigFile
            // 
            this.LabelConfigFile.AutoSize = true;
            this.LabelConfigFile.Location = new System.Drawing.Point(30, 181);
            this.LabelConfigFile.Name = "LabelConfigFile";
            this.LabelConfigFile.Size = new System.Drawing.Size(74, 17);
            this.LabelConfigFile.TabIndex = 5;
            this.LabelConfigFile.Text = "Config File";
            // 
            // LabelReportFile
            // 
            this.LabelReportFile.AutoSize = true;
            this.LabelReportFile.Location = new System.Drawing.Point(30, 211);
            this.LabelReportFile.Name = "LabelReportFile";
            this.LabelReportFile.Size = new System.Drawing.Size(77, 17);
            this.LabelReportFile.TabIndex = 6;
            this.LabelReportFile.Text = "Report File";
            // 
            // textBoxProject
            // 
            this.textBoxProject.Location = new System.Drawing.Point(146, 27);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(221, 22);
            this.textBoxProject.TabIndex = 7;
            this.textBoxProject.Text = "KsfNpLJSbdNlY8czyuwb";
            // 
            // textBoxTestID
            // 
            this.textBoxTestID.Location = new System.Drawing.Point(146, 146);
            this.textBoxTestID.Name = "textBoxTestID";
            this.textBoxTestID.Size = new System.Drawing.Size(221, 22);
            this.textBoxTestID.TabIndex = 8;
            this.textBoxTestID.Text = "N\\A";
            // 
            // textBoxConfigFile
            // 
            this.textBoxConfigFile.Location = new System.Drawing.Point(146, 178);
            this.textBoxConfigFile.Name = "textBoxConfigFile";
            this.textBoxConfigFile.Size = new System.Drawing.Size(221, 22);
            this.textBoxConfigFile.TabIndex = 9;
            this.textBoxConfigFile.Text = "N\\A";
            // 
            // textBoxReportFile
            // 
            this.textBoxReportFile.Location = new System.Drawing.Point(146, 206);
            this.textBoxReportFile.Name = "textBoxReportFile";
            this.textBoxReportFile.Size = new System.Drawing.Size(221, 22);
            this.textBoxReportFile.TabIndex = 11;
            this.textBoxReportFile.Text = "testim-report.xml";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(146, 82);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(221, 22);
            this.textBoxLabel.TabIndex = 13;
            this.textBoxLabel.Text = "Avengers";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Location = new System.Drawing.Point(146, 116);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(221, 22);
            this.textBoxTestName.TabIndex = 12;
            this.textBoxTestName.Text = "N\\A";
            // 
            // buttonRunTest
            // 
            this.buttonRunTest.Enabled = false;
            this.buttonRunTest.Location = new System.Drawing.Point(146, 254);
            this.buttonRunTest.Name = "buttonRunTest";
            this.buttonRunTest.Size = new System.Drawing.Size(75, 23);
            this.buttonRunTest.TabIndex = 15;
            this.buttonRunTest.Text = "Run Test";
            this.buttonRunTest.UseVisualStyleBackColor = true;
            this.buttonRunTest.Click += new System.EventHandler(this.buttonRunTest_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(35, 294);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(295, 238);
            this.richTextBoxOutput.TabIndex = 16;
            this.richTextBoxOutput.Text = "";
            // 
            // textBoxAccessToken
            // 
            this.textBoxAccessToken.Location = new System.Drawing.Point(146, 54);
            this.textBoxAccessToken.Name = "textBoxAccessToken";
            this.textBoxAccessToken.Size = new System.Drawing.Size(221, 22);
            this.textBoxAccessToken.TabIndex = 14;
            this.textBoxAccessToken.Text = "98IQGMuu1jTaBp3HvIMkmsk6tTa2jrS4hUFE247rX9ef0s3FAp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 544);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonRunTest);
            this.Controls.Add(this.textBoxAccessToken);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxTestName);
            this.Controls.Add(this.textBoxReportFile);
            this.Controls.Add(this.textBoxConfigFile);
            this.Controls.Add(this.textBoxTestID);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.LabelReportFile);
            this.Controls.Add(this.LabelConfigFile);
            this.Controls.Add(this.LabelTestID);
            this.Controls.Add(this.LabelTestName);
            this.Controls.Add(this.LabelLabel);
            this.Controls.Add(this.LabelAccessToken);
            this.Controls.Add(this.LabelProject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelProject;
        private System.Windows.Forms.Label LabelAccessToken;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label LabelTestName;
        private System.Windows.Forms.Label LabelTestID;
        private System.Windows.Forms.Label LabelConfigFile;
        private System.Windows.Forms.Label LabelReportFile;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.TextBox textBoxTestID;
        private System.Windows.Forms.TextBox textBoxConfigFile;
        private System.Windows.Forms.TextBox textBoxReportFile;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.Button buttonRunTest;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxAccessToken;
    }
}

