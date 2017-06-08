namespace rssv_lv2_1
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
            this.startButton = new System.Windows.Forms.Button();
            this.critValueTB = new System.Windows.Forms.TextBox();
            this.critValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numbersTB = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(28, 462);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(126, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start ucitavanja";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // critValueTB
            // 
            this.critValueTB.Location = new System.Drawing.Point(16, 38);
            this.critValueTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.critValueTB.Name = "critValueTB";
            this.critValueTB.Size = new System.Drawing.Size(132, 22);
            this.critValueTB.TabIndex = 2;
            this.critValueTB.Text = "0";
            // 
            // critValue
            // 
            this.critValue.AutoSize = true;
            this.critValue.Location = new System.Drawing.Point(24, 18);
            this.critValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.critValue.Name = "critValue";
            this.critValue.Size = new System.Drawing.Size(120, 17);
            this.critValue.TabIndex = 3;
            this.critValue.Text = "Kriticna vrijednost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brojevi ucitani iz datoteke";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numbersTB
            // 
            this.numbersTB.Location = new System.Drawing.Point(248, 38);
            this.numbersTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numbersTB.Name = "numbersTB";
            this.numbersTB.ReadOnly = true;
            this.numbersTB.Size = new System.Drawing.Size(436, 415);
            this.numbersTB.TabIndex = 5;
            this.numbersTB.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(569, 462);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 535);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.numbersTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.critValue);
            this.Controls.Add(this.critValueTB);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox critValueTB;
        private System.Windows.Forms.Label critValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox numbersTB;
        private System.Windows.Forms.Button exitButton;
    }
}

