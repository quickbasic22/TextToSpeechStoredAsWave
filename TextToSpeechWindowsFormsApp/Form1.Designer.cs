namespace TextToSpeechWindowsFormsApp
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
            this.cbVoiceAge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVoiceGender = new System.Windows.Forms.ComboBox();
            this.txtTexttoSpeak = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.bntConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVoiceAge
            // 
            this.cbVoiceAge.FormattingEnabled = true;
            this.cbVoiceAge.Items.AddRange(new object[] {
            "Adult",
            "Teen",
            "Child",
            "Senior"});
            this.cbVoiceAge.Location = new System.Drawing.Point(164, 153);
            this.cbVoiceAge.Name = "cbVoiceAge";
            this.cbVoiceAge.Size = new System.Drawing.Size(153, 21);
            this.cbVoiceAge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to speech wave file program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age of voice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender of voice";
            // 
            // cbVoiceGender
            // 
            this.cbVoiceGender.FormattingEnabled = true;
            this.cbVoiceGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbVoiceGender.Location = new System.Drawing.Point(164, 259);
            this.cbVoiceGender.Name = "cbVoiceGender";
            this.cbVoiceGender.Size = new System.Drawing.Size(153, 21);
            this.cbVoiceGender.TabIndex = 4;
            // 
            // txtTexttoSpeak
            // 
            this.txtTexttoSpeak.Location = new System.Drawing.Point(419, 125);
            this.txtTexttoSpeak.Multiline = true;
            this.txtTexttoSpeak.Name = "txtTexttoSpeak";
            this.txtTexttoSpeak.Size = new System.Drawing.Size(309, 155);
            this.txtTexttoSpeak.TabIndex = 5;
            this.txtTexttoSpeak.Text = "When you click button all text here is spoken to a wave file";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(479, 88);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(149, 13);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Text thats spoken to wave file";
            // 
            // bntConvert
            // 
            this.bntConvert.Location = new System.Drawing.Point(343, 344);
            this.bntConvert.Name = "bntConvert";
            this.bntConvert.Size = new System.Drawing.Size(176, 57);
            this.bntConvert.TabIndex = 7;
            this.bntConvert.Text = "button1";
            this.bntConvert.UseVisualStyleBackColor = true;
            this.bntConvert.Click += new System.EventHandler(this.bntConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.bntConvert);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtTexttoSpeak);
            this.Controls.Add(this.cbVoiceGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVoiceAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVoiceAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVoiceGender;
        private System.Windows.Forms.TextBox txtTexttoSpeak;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button bntConvert;
    }
}

