namespace RandomValueGenerator.View
{
    partial class ValueView
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(103, 64);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(76, 145);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(40, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Result:";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(122, 145);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 13);
            this.resultText.TabIndex = 2;
            // 
            // ValueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "ValueView";
            this.Text = "RandomValueGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label resultText;
    }
}