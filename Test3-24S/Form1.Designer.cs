namespace Test3_24S
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
            tx1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tx2 = new TextBox();
            label1 = new Label();
            tx3 = new TextBox();
            label2 = new Label();
            tx4 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // tx1
            // 
            tx1.Location = new Point(64, 55);
            tx1.Margin = new Padding(3, 4, 3, 4);
            tx1.Name = "tx1";
            tx1.Size = new Size(114, 27);
            tx1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(64, 119);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(64, 183);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 31);
            button2.TabIndex = 1;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tx2
            // 
            tx2.Enabled = false;
            tx2.Location = new Point(286, 55);
            tx2.Margin = new Padding(3, 4, 3, 4);
            tx2.Name = "tx2";
            tx2.Size = new Size(114, 27);
            tx2.TabIndex = 0;
            tx2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 61);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "Sum";
            // 
            // tx3
            // 
            tx3.Enabled = false;
            tx3.Location = new Point(286, 119);
            tx3.Margin = new Padding(3, 4, 3, 4);
            tx3.Name = "tx3";
            tx3.Size = new Size(114, 27);
            tx3.TabIndex = 0;
            tx3.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 125);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Count";
            // 
            // tx4
            // 
            tx4.Enabled = false;
            tx4.Location = new Point(286, 183);
            tx4.Margin = new Padding(3, 4, 3, 4);
            tx4.Name = "tx4";
            tx4.Size = new Size(114, 27);
            tx4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 189);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Average";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 295);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tx4);
            Controls.Add(tx3);
            Controls.Add(tx2);
            Controls.Add(tx1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx1;
        private Button button1;
        private Button button2;
        private TextBox tx2;
        private Label label1;
        private TextBox tx3;
        private Label label2;
        private TextBox tx4;
        private Label label3;
    }
}
