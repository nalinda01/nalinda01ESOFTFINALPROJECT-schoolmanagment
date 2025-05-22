namespace schoolmanagment
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 325);
            button1.Name = "button1";
            button1.Size = new Size(184, 78);
            button1.TabIndex = 0;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSpringGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(266, 325);
            button2.Name = "button2";
            button2.Size = new Size(184, 78);
            button2.TabIndex = 1;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 53);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 2;
            label1.Text = "EMAIL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 107);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 30);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 30);
            textBox2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(72, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(378, 138);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(56, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 163);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIN DETAILS";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(498, 415);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Name = "login";
            Text = "Form1";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
    }
}
