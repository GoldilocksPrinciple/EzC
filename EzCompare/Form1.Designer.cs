namespace EzCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dir1Label = new System.Windows.Forms.Label();
            this.Dir1Path = new System.Windows.Forms.TextBox();
            this.Dir1Button = new System.Windows.Forms.Button();
            this.Dir2Label = new System.Windows.Forms.Label();
            this.Dir2Path = new System.Windows.Forms.TextBox();
            this.Dir2Button = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputDirPath = new System.Windows.Forms.TextBox();
            this.OutputDirButton = new System.Windows.Forms.Button();
            this.RadioLabel = new System.Windows.Forms.Label();
            this.RadioButtonDir1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonDir2 = new System.Windows.Forms.RadioButton();
            this.InfoTextbox = new System.Windows.Forms.TextBox();
            this.CompareButton = new System.Windows.Forms.Button();
            this.RadioLabel2 = new System.Windows.Forms.Label();
            this.RadioButtonItemTag = new System.Windows.Forms.RadioButton();
            this.RadioButtonTrans = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Dir1Label
            // 
            this.Dir1Label.AutoSize = true;
            this.Dir1Label.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir1Label.Location = new System.Drawing.Point(47, 43);
            this.Dir1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dir1Label.Name = "Dir1Label";
            this.Dir1Label.Size = new System.Drawing.Size(133, 25);
            this.Dir1Label.TabIndex = 0;
            this.Dir1Label.Text = "Directory 1:";
            // 
            // Dir1Path
            // 
            this.Dir1Path.BackColor = System.Drawing.SystemColors.Control;
            this.Dir1Path.Enabled = false;
            this.Dir1Path.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir1Path.Location = new System.Drawing.Point(192, 41);
            this.Dir1Path.Margin = new System.Windows.Forms.Padding(4);
            this.Dir1Path.Name = "Dir1Path";
            this.Dir1Path.Size = new System.Drawing.Size(577, 32);
            this.Dir1Path.TabIndex = 1;
            // 
            // Dir1Button
            // 
            this.Dir1Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir1Button.Location = new System.Drawing.Point(809, 41);
            this.Dir1Button.Margin = new System.Windows.Forms.Padding(4);
            this.Dir1Button.Name = "Dir1Button";
            this.Dir1Button.Size = new System.Drawing.Size(39, 33);
            this.Dir1Button.TabIndex = 2;
            this.Dir1Button.Text = "...";
            this.Dir1Button.UseVisualStyleBackColor = true;
            this.Dir1Button.Click += new System.EventHandler(this.Dir1Button_Click);
            // 
            // Dir2Label
            // 
            this.Dir2Label.AutoSize = true;
            this.Dir2Label.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir2Label.Location = new System.Drawing.Point(47, 97);
            this.Dir2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dir2Label.Name = "Dir2Label";
            this.Dir2Label.Size = new System.Drawing.Size(133, 25);
            this.Dir2Label.TabIndex = 3;
            this.Dir2Label.Text = "Directory 2:";
            // 
            // Dir2Path
            // 
            this.Dir2Path.BackColor = System.Drawing.SystemColors.Control;
            this.Dir2Path.Enabled = false;
            this.Dir2Path.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir2Path.Location = new System.Drawing.Point(192, 95);
            this.Dir2Path.Margin = new System.Windows.Forms.Padding(4);
            this.Dir2Path.Name = "Dir2Path";
            this.Dir2Path.Size = new System.Drawing.Size(577, 32);
            this.Dir2Path.TabIndex = 4;
            // 
            // Dir2Button
            // 
            this.Dir2Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir2Button.Location = new System.Drawing.Point(809, 95);
            this.Dir2Button.Margin = new System.Windows.Forms.Padding(4);
            this.Dir2Button.Name = "Dir2Button";
            this.Dir2Button.Size = new System.Drawing.Size(39, 33);
            this.Dir2Button.TabIndex = 5;
            this.Dir2Button.Text = "...";
            this.Dir2Button.UseVisualStyleBackColor = true;
            this.Dir2Button.Click += new System.EventHandler(this.Dir2Button_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(24, 153);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(149, 25);
            this.OutputLabel.TabIndex = 6;
            this.OutputLabel.Text = "Output Path:";
            // 
            // OutputDirPath
            // 
            this.OutputDirPath.BackColor = System.Drawing.SystemColors.Control;
            this.OutputDirPath.Enabled = false;
            this.OutputDirPath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputDirPath.Location = new System.Drawing.Point(192, 149);
            this.OutputDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.OutputDirPath.Name = "OutputDirPath";
            this.OutputDirPath.Size = new System.Drawing.Size(577, 32);
            this.OutputDirPath.TabIndex = 7;
            // 
            // OutputDirButton
            // 
            this.OutputDirButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputDirButton.Location = new System.Drawing.Point(809, 149);
            this.OutputDirButton.Margin = new System.Windows.Forms.Padding(4);
            this.OutputDirButton.Name = "OutputDirButton";
            this.OutputDirButton.Size = new System.Drawing.Size(39, 33);
            this.OutputDirButton.TabIndex = 8;
            this.OutputDirButton.Text = "...";
            this.OutputDirButton.UseVisualStyleBackColor = true;
            this.OutputDirButton.Click += new System.EventHandler(this.OutputDirButton_Click);
            // 
            // RadioLabel
            // 
            this.RadioLabel.AutoSize = true;
            this.RadioLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioLabel.Location = new System.Drawing.Point(96, 219);
            this.RadioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RadioLabel.Name = "RadioLabel";
            this.RadioLabel.Size = new System.Drawing.Size(325, 22);
            this.RadioLabel.TabIndex = 9;
            this.RadioLabel.Text = "Output missing lines of text file(s) in:";
            // 
            // RadioButtonDir1
            // 
            this.RadioButtonDir1.AutoSize = true;
            this.RadioButtonDir1.Checked = true;
            this.RadioButtonDir1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonDir1.Location = new System.Drawing.Point(472, 220);
            this.RadioButtonDir1.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonDir1.Name = "RadioButtonDir1";
            this.RadioButtonDir1.Size = new System.Drawing.Size(119, 25);
            this.RadioButtonDir1.TabIndex = 10;
            this.RadioButtonDir1.TabStop = true;
            this.RadioButtonDir1.Text = "Directory 1";
            this.RadioButtonDir1.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDir2
            // 
            this.RadioButtonDir2.AutoSize = true;
            this.RadioButtonDir2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonDir2.Location = new System.Drawing.Point(629, 220);
            this.RadioButtonDir2.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonDir2.Name = "RadioButtonDir2";
            this.RadioButtonDir2.Size = new System.Drawing.Size(119, 25);
            this.RadioButtonDir2.TabIndex = 11;
            this.RadioButtonDir2.Text = "Directory 2";
            this.RadioButtonDir2.UseVisualStyleBackColor = true;
            // 
            // InfoTextbox
            // 
            this.InfoTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.InfoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTextbox.Location = new System.Drawing.Point(29, 310);
            this.InfoTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.InfoTextbox.Name = "InfoTextbox";
            this.InfoTextbox.ReadOnly = true;
            this.InfoTextbox.Size = new System.Drawing.Size(787, 25);
            this.InfoTextbox.TabIndex = 14;
            this.InfoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompareButton
            // 
            this.CompareButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareButton.Location = new System.Drawing.Point(347, 357);
            this.CompareButton.Margin = new System.Windows.Forms.Padding(4);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(159, 58);
            this.CompareButton.TabIndex = 15;
            this.CompareButton.Text = "COMPARE";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // RadioLabel2
            // 
            this.RadioLabel2.AutoSize = true;
            this.RadioLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioLabel2.Location = new System.Drawing.Point(156, 266);
            this.RadioLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RadioLabel2.Name = "RadioLabel2";
            this.RadioLabel2.Size = new System.Drawing.Size(265, 22);
            this.RadioLabel2.TabIndex = 16;
            this.RadioLabel2.Text = "Finding differences base on:";
            // 
            // RadioButtonItemTag
            // 
            this.RadioButtonItemTag.AutoSize = true;
            this.RadioButtonItemTag.Checked = true;
            this.RadioButtonItemTag.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonItemTag.Location = new System.Drawing.Point(472, 263);
            this.RadioButtonItemTag.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonItemTag.Name = "RadioButtonItemTag";
            this.RadioButtonItemTag.Size = new System.Drawing.Size(100, 25);
            this.RadioButtonItemTag.TabIndex = 17;
            this.RadioButtonItemTag.TabStop = true;
            this.RadioButtonItemTag.Text = "ItemTag";
            this.RadioButtonItemTag.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTrans
            // 
            this.RadioButtonTrans.AutoSize = true;
            this.RadioButtonTrans.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonTrans.Location = new System.Drawing.Point(629, 263);
            this.RadioButtonTrans.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonTrans.Name = "RadioButtonTrans";
            this.RadioButtonTrans.Size = new System.Drawing.Size(119, 25);
            this.RadioButtonTrans.TabIndex = 18;
            this.RadioButtonTrans.Text = "Translation";
            this.RadioButtonTrans.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 428);
            this.Controls.Add(this.RadioButtonTrans);
            this.Controls.Add(this.RadioButtonItemTag);
            this.Controls.Add(this.RadioLabel2);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.InfoTextbox);
            this.Controls.Add(this.RadioButtonDir2);
            this.Controls.Add(this.RadioButtonDir1);
            this.Controls.Add(this.RadioLabel);
            this.Controls.Add(this.OutputDirButton);
            this.Controls.Add(this.OutputDirPath);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Dir2Button);
            this.Controls.Add(this.Dir2Path);
            this.Controls.Add(this.Dir2Label);
            this.Controls.Add(this.Dir1Button);
            this.Controls.Add(this.Dir1Path);
            this.Controls.Add(this.Dir1Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "EzCompare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dir1Label;
        private System.Windows.Forms.TextBox Dir1Path;
        private System.Windows.Forms.Button Dir1Button;
        private System.Windows.Forms.Label Dir2Label;
        private System.Windows.Forms.TextBox Dir2Path;
        private System.Windows.Forms.Button Dir2Button;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputDirPath;
        private System.Windows.Forms.Button OutputDirButton;
        private System.Windows.Forms.Label RadioLabel;
        private System.Windows.Forms.RadioButton RadioButtonDir1;
        private System.Windows.Forms.RadioButton RadioButtonDir2;
        private System.Windows.Forms.TextBox InfoTextbox;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.Label RadioLabel2;
        private System.Windows.Forms.RadioButton RadioButtonItemTag;
        private System.Windows.Forms.RadioButton RadioButtonTrans;
    }
}

