namespace WordCounter
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
            AcceptBtn = new Button();
            WordCountLabel = new Label();
            textBox1 = new TextBox();
            CharacterCountLabel = new Label();
            CharacterCountNoWhite = new Label();
            SuspendLayout();
            // 
            // AcceptBtn
            // 
            AcceptBtn.Location = new Point(663, 103);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(75, 23);
            AcceptBtn.TabIndex = 0;
            AcceptBtn.Text = "Reset";
            AcceptBtn.UseVisualStyleBackColor = true;
            AcceptBtn.Click += button1_Click;
            // 
            // WordCountLabel
            // 
            WordCountLabel.AutoSize = true;
            WordCountLabel.Location = new Point(275, 168);
            WordCountLabel.Name = "WordCountLabel";
            WordCountLabel.Size = new Size(38, 15);
            WordCountLabel.TabIndex = 1;
            WordCountLabel.Text = "label1";
            WordCountLabel.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // CharacterCountLabel
            // 
            CharacterCountLabel.AutoSize = true;
            CharacterCountLabel.Location = new Point(275, 208);
            CharacterCountLabel.Name = "CharacterCountLabel";
            CharacterCountLabel.Size = new Size(38, 15);
            CharacterCountLabel.TabIndex = 3;
            CharacterCountLabel.Text = "label2";
            // 
            // CharacterCountNoWhite
            // 
            CharacterCountNoWhite.AutoSize = true;
            CharacterCountNoWhite.Location = new Point(275, 247);
            CharacterCountNoWhite.Name = "CharacterCountNoWhite";
            CharacterCountNoWhite.Size = new Size(38, 15);
            CharacterCountNoWhite.TabIndex = 4;
            CharacterCountNoWhite.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CharacterCountNoWhite);
            Controls.Add(CharacterCountLabel);
            Controls.Add(textBox1);
            Controls.Add(WordCountLabel);
            Controls.Add(AcceptBtn);
            Name = "Form1";
            Text = "Nicks Word Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AcceptBtn;
        private Label WordCountLabel;
        private TextBox textBox1;
        private Label CharacterCountLabel;
        private Label CharacterCountNoWhite;
    }
}
