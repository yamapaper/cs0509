namespace cs0509
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
            buttonPropety = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonPropety
            // 
            buttonPropety.AutoSize = true;
            buttonPropety.BackColor = SystemColors.ActiveCaption;
            buttonPropety.Location = new Point(1, 0);
            buttonPropety.Name = "buttonPropety";
            buttonPropety.Size = new Size(197, 134);
            buttonPropety.TabIndex = 0;
            buttonPropety.Text = "button1";
            buttonPropety.UseVisualStyleBackColor = false;
            buttonPropety.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1, 140);
            button1.Name = "button1";
            button1.Size = new Size(192, 109);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(311, 94);
            button2.Name = "button2";
            button2.Size = new Size(84, 49);
            button2.TabIndex = 2;
            button2.Text = "up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(230, 140);
            button3.Name = "button3";
            button3.Size = new Size(84, 49);
            button3.TabIndex = 3;
            button3.Text = "left";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(392, 140);
            button4.Name = "button4";
            button4.Size = new Size(84, 49);
            button4.TabIndex = 4;
            button4.Text = "right";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(311, 186);
            button5.Name = "button5";
            button5.Size = new Size(84, 49);
            button5.TabIndex = 5;
            button5.Text = "down";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 157);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonPropety);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPropety;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
