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
            this.LabelCommandToRun = new System.Windows.Forms.Label();
            this.richTextBoxCommand = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LabelProject
            // 
            this.LabelProject.AutoSize = true;
            this.LabelProject.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProject.Location = new System.Drawing.Point(24, 22);
            this.LabelProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProject.Name = "LabelProject";
            this.LabelProject.Size = new System.Drawing.Size(50, 19);
            this.LabelProject.TabIndex = 0;
            this.LabelProject.Text = "Project";
            // 
            // LabelAccessToken
            // 
            this.LabelAccessToken.AutoSize = true;
            this.LabelAccessToken.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccessToken.Location = new System.Drawing.Point(22, 46);
            this.LabelAccessToken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAccessToken.Name = "LabelAccessToken";
            this.LabelAccessToken.Size = new System.Drawing.Size(82, 19);
            this.LabelAccessToken.TabIndex = 1;
            this.LabelAccessToken.Text = "Access Token";
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLabel.Location = new System.Drawing.Point(24, 71);
            this.LabelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(37, 19);
            this.LabelLabel.TabIndex = 2;
            this.LabelLabel.Text = "Label";
            // 
            // LabelTestName
            // 
            this.LabelTestName.AutoSize = true;
            this.LabelTestName.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestName.Location = new System.Drawing.Point(22, 97);
            this.LabelTestName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTestName.Name = "LabelTestName";
            this.LabelTestName.Size = new System.Drawing.Size(68, 19);
            this.LabelTestName.TabIndex = 3;
            this.LabelTestName.Text = "Test Name";
            // 
            // LabelTestID
            // 
            this.LabelTestID.AutoSize = true;
            this.LabelTestID.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestID.Location = new System.Drawing.Point(22, 121);
            this.LabelTestID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTestID.Name = "LabelTestID";
            this.LabelTestID.Size = new System.Drawing.Size(48, 19);
            this.LabelTestID.TabIndex = 4;
            this.LabelTestID.Text = "Test ID";
            // 
            // LabelConfigFile
            // 
            this.LabelConfigFile.AutoSize = true;
            this.LabelConfigFile.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfigFile.Location = new System.Drawing.Point(22, 147);
            this.LabelConfigFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelConfigFile.Name = "LabelConfigFile";
            this.LabelConfigFile.Size = new System.Drawing.Size(66, 19);
            this.LabelConfigFile.TabIndex = 5;
            this.LabelConfigFile.Text = "Config File";
            // 
            // LabelReportFile
            // 
            this.LabelReportFile.AutoSize = true;
            this.LabelReportFile.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReportFile.Location = new System.Drawing.Point(22, 171);
            this.LabelReportFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReportFile.Name = "LabelReportFile";
            this.LabelReportFile.Size = new System.Drawing.Size(70, 19);
            this.LabelReportFile.TabIndex = 6;
            this.LabelReportFile.Text = "Report File";
            // 
            // textBoxProject
            // 
            this.textBoxProject.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProject.Location = new System.Drawing.Point(110, 22);
            this.textBoxProject.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(167, 20);
            this.textBoxProject.TabIndex = 7;
            this.textBoxProject.Text = "KsfNpLJSbdNlY8czyuwb";
            // 
            // textBoxTestID
            // 
            this.textBoxTestID.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestID.Location = new System.Drawing.Point(110, 119);
            this.textBoxTestID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTestID.Name = "textBoxTestID";
            this.textBoxTestID.Size = new System.Drawing.Size(167, 20);
            this.textBoxTestID.TabIndex = 8;
            this.textBoxTestID.Text = "N\\A";
            // 
            // textBoxConfigFile
            // 
            this.textBoxConfigFile.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfigFile.Location = new System.Drawing.Point(110, 145);
            this.textBoxConfigFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConfigFile.Name = "textBoxConfigFile";
            this.textBoxConfigFile.Size = new System.Drawing.Size(167, 20);
            this.textBoxConfigFile.TabIndex = 9;
            this.textBoxConfigFile.Text = "N\\A";
            // 
            // textBoxReportFile
            // 
            this.textBoxReportFile.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReportFile.Location = new System.Drawing.Point(110, 167);
            this.textBoxReportFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReportFile.Name = "textBoxReportFile";
            this.textBoxReportFile.Size = new System.Drawing.Size(167, 20);
            this.textBoxReportFile.TabIndex = 11;
            this.textBoxReportFile.Text = "testim-report.xml";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(110, 67);
            this.textBoxLabel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(167, 20);
            this.textBoxLabel.TabIndex = 13;
            this.textBoxLabel.Text = "Avengers";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestName.Location = new System.Drawing.Point(110, 94);
            this.textBoxTestName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(167, 20);
            this.textBoxTestName.TabIndex = 12;
            this.textBoxTestName.Text = "N\\A";
            // 
            // buttonRunTest
            // 
            this.buttonRunTest.Enabled = false;
            this.buttonRunTest.Font = new System.Drawing.Font("Kristen ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunTest.Location = new System.Drawing.Point(136, 204);
            this.buttonRunTest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRunTest.Name = "buttonRunTest";
            this.buttonRunTest.Size = new System.Drawing.Size(105, 31);
            this.buttonRunTest.TabIndex = 15;
            this.buttonRunTest.Text = "Run Test";
            this.buttonRunTest.UseVisualStyleBackColor = true;
            this.buttonRunTest.Click += new System.EventHandler(this.buttonRunTest_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(28, 254);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(523, 267);
            this.richTextBoxOutput.TabIndex = 16;
            this.richTextBoxOutput.Text = "";
            // 
            // textBoxAccessToken
            // 
            this.textBoxAccessToken.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccessToken.Location = new System.Drawing.Point(110, 44);
            this.textBoxAccessToken.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAccessToken.Name = "textBoxAccessToken";
            this.textBoxAccessToken.Size = new System.Drawing.Size(167, 20);
            this.textBoxAccessToken.TabIndex = 14;
            this.textBoxAccessToken.Text = "98IQGMuu1jTaBp3HvIMkmsk6tTa2jrS4hUFE247rX9ef0s3FAp";
            // 
            // LabelCommandToRun
            // 
            this.LabelCommandToRun.AutoSize = true;
            this.LabelCommandToRun.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCommandToRun.Location = new System.Drawing.Point(374, 22);
            this.LabelCommandToRun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCommandToRun.Name = "LabelCommandToRun";
            this.LabelCommandToRun.Size = new System.Drawing.Size(130, 23);
            this.LabelCommandToRun.TabIndex = 17;
            this.LabelCommandToRun.Text = "Command To Run";
            // 
            // richTextBoxCommand
            // 
            this.richTextBoxCommand.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCommand.Location = new System.Drawing.Point(325, 51);
            this.richTextBoxCommand.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxCommand.Name = "richTextBoxCommand";
            this.richTextBoxCommand.ReadOnly = true;
            this.richTextBoxCommand.Size = new System.Drawing.Size(224, 136);
            this.richTextBoxCommand.TabIndex = 18;
            this.richTextBoxCommand.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutomationHW1.Properties.Resources._31016_katie_ux_ut;
            this.ClientSize = new System.Drawing.Size(571, 532);
            this.Controls.Add(this.richTextBoxCommand);
            this.Controls.Add(this.LabelCommandToRun);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label LabelCommandToRun;
        private System.Windows.Forms.RichTextBox richTextBoxCommand;
    }
}

