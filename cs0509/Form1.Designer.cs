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
            SuspendLayout();
            // 
            // buttonPropety
            // 
            buttonPropety.AutoSize = true;
            buttonPropety.BackColor = SystemColors.ActiveCaption;
            buttonPropety.Location = new Point(17, 10);
            buttonPropety.Name = "buttonPropety";
            buttonPropety.Size = new Size(197, 134);
            buttonPropety.TabIndex = 0;
            buttonPropety.Text = "button1";
            buttonPropety.UseVisualStyleBackColor = false;
            buttonPropety.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPropety);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPropety;
    }
}
