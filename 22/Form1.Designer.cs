
namespace _22
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
            this.textboxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFirstLine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxFileContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxFileName
            // 
            this.textboxFileName.Location = new System.Drawing.Point(134, 11);
            this.textboxFileName.Name = "textboxFileName";
            this.textboxFileName.Size = new System.Drawing.Size(406, 31);
            this.textboxFileName.TabIndex = 0;
            this.textboxFileName.Text = "../../Form1.cs";
            this.textboxFileName.TextChanged += new System.EventHandler(this.textboxFileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name:";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(13, 386);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(139, 52);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "First line:";
            // 
            // labelFirstLine
            // 
            this.labelFirstLine.AutoSize = true;
            this.labelFirstLine.Location = new System.Drawing.Point(129, 56);
            this.labelFirstLine.Name = "labelFirstLine";
            this.labelFirstLine.Size = new System.Drawing.Size(70, 25);
            this.labelFirstLine.TabIndex = 4;
            this.labelFirstLine.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "File:";
            // 
            // textboxFileContent
            // 
            this.textboxFileContent.Location = new System.Drawing.Point(134, 117);
            this.textboxFileContent.Multiline = true;
            this.textboxFileContent.Name = "textboxFileContent";
            this.textboxFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxFileContent.Size = new System.Drawing.Size(654, 219);
            this.textboxFileContent.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxFileContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFirstLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxFileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFirstLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxFileContent;
    }
}

