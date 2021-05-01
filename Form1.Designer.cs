
namespace BirdImagesUpload
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxAccessToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(513, 36);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(136, 23);
            this.buttonFolder.TabIndex = 0;
            this.buttonFolder.Text = "Select folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(13, 36);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(248, 23);
            this.numericUpDownInterval.TabIndex = 1;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(37, 18);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(157, 15);
            this.labelInterval.TabIndex = 2;
            this.labelInterval.Text = "Upload interval (in seconds):";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(279, 36);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(228, 23);
            this.textBoxFolder.TabIndex = 3;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(352, 18);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(82, 15);
            this.labelFolder.TabIndex = 4;
            this.labelFolder.Text = "Upload folder:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(279, 89);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(370, 161);
            this.textBoxOutput.TabIndex = 5;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(434, 71);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(48, 15);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Output:";
            // 
            // textBoxAccessToken
            // 
            this.textBoxAccessToken.Location = new System.Drawing.Point(12, 89);
            this.textBoxAccessToken.Name = "textBoxAccessToken";
            this.textBoxAccessToken.Size = new System.Drawing.Size(249, 23);
            this.textBoxAccessToken.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "AccessToken:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(67, 227);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(136, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 262);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAccessToken);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.buttonFolder);
            this.Name = "Form1";
            this.Text = "BirdImagesUpload";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxAccessToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
    }
}

