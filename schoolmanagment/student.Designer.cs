namespace schoolmanagment
{
    partial class student
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            update = new Button();
            clear = new Button();
            button3 = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            studentid = new DataGridViewTextBoxColumn();
            firstname = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            pname = new DataGridViewTextBoxColumn();
            pnic = new DataGridViewTextBoxColumn();
            pgender = new DataGridViewTextBoxColumn();
            pnumber = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(43, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 236);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "6", "7", "8", "9", "10", "11" });
            comboBox1.Location = new Point(225, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(319, 142);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(228, 142);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 190);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 3;
            label5.Text = "Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 146);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 2;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 97);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 53);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(423, 9);
            label1.Name = "label1";
            label1.Size = new Size(419, 60);
            label1.TabIndex = 1;
            label1.Text = "Skills International";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(663, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 236);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parent Details";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(228, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 27);
            textBox5.TabIndex = 8;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(319, 142);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 24);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "female";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(228, 142);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(63, 24);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "male";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(225, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(225, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 27);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 194);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 3;
            label6.Text = "Contact Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 146);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 2;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(123, 97);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 1;
            label8.Text = "NIC";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(96, 53);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 0;
            label9.Text = "Parent Name";
            // 
            // update
            // 
            update.BackColor = Color.Aqua;
            update.Location = new Point(43, 336);
            update.Name = "update";
            update.Size = new Size(111, 46);
            update.TabIndex = 10;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.PeachPuff;
            clear.Location = new Point(190, 336);
            clear.Name = "clear";
            clear.Size = new Size(111, 46);
            clear.TabIndex = 11;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Chartreuse;
            button3.Location = new Point(1093, 336);
            button3.Name = "button3";
            button3.Size = new Size(111, 46);
            button3.TabIndex = 12;
            button3.Text = "SAVE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.IndianRed;
            delete.Location = new Point(353, 336);
            delete.Name = "delete";
            delete.Size = new Size(111, 46);
            delete.TabIndex = 13;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentid, firstname, lastname, gender, grade, pname, pnic, pgender, pnumber });
            dataGridView1.Location = new Point(24, 402);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1180, 389);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // studentid
            // 
            studentid.DataPropertyName = "studentid";
            studentid.HeaderText = "studentid";
            studentid.MinimumWidth = 6;
            studentid.Name = "studentid";
            studentid.Width = 125;
            // 
            // firstname
            // 
            firstname.DataPropertyName = "firstname";
            firstname.HeaderText = "firstname";
            firstname.MinimumWidth = 6;
            firstname.Name = "firstname";
            firstname.Width = 125;
            // 
            // lastname
            // 
            lastname.DataPropertyName = "lastname";
            lastname.HeaderText = "lastname";
            lastname.MinimumWidth = 6;
            lastname.Name = "lastname";
            lastname.Width = 125;
            // 
            // gender
            // 
            gender.DataPropertyName = "gender";
            gender.HeaderText = "gender";
            gender.MinimumWidth = 6;
            gender.Name = "gender";
            gender.Width = 125;
            // 
            // grade
            // 
            grade.DataPropertyName = "grade";
            grade.HeaderText = "grade";
            grade.MinimumWidth = 6;
            grade.Name = "grade";
            grade.Width = 125;
            // 
            // pname
            // 
            pname.DataPropertyName = "pname";
            pname.HeaderText = "pname";
            pname.MinimumWidth = 6;
            pname.Name = "pname";
            pname.Width = 125;
            // 
            // pnic
            // 
            pnic.DataPropertyName = "pnic";
            pnic.HeaderText = "pnic";
            pnic.MinimumWidth = 6;
            pnic.Name = "pnic";
            pnic.Width = 125;
            // 
            // pgender
            // 
            pgender.DataPropertyName = "pgender";
            pgender.HeaderText = "pgender";
            pgender.MinimumWidth = 6;
            pgender.Name = "pgender";
            pgender.Width = 125;
            // 
            // pnumber
            // 
            pnumber.DataPropertyName = "pnumber";
            pnumber.HeaderText = "pnumber";
            pnumber.MinimumWidth = 6;
            pnumber.Name = "pnumber";
            pnumber.Width = 125;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1228, 818);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(button3);
            Controls.Add(clear);
            Controls.Add(update);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "student";
            Text = "student";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private Button update;
        private Button clear;
        private Button button3;
        private Button delete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn studentid;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn grade;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn pnic;
        private DataGridViewTextBoxColumn pgender;
        private DataGridViewTextBoxColumn pnumber;
    }
}