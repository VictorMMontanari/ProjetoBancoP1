namespace ProjetoBanco
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
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label21 = new Label();
            label20 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label19 = new Label();
            comboBox3 = new ComboBox();
            label18 = new Label();
            comboBox2 = new ComboBox();
            label12 = new Label();
            label17 = new Label();
            label11 = new Label();
            label10 = new Label();
            label16 = new Label();
            label9 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(28, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criar Conta";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(21, 78);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "N° da Conta";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(21, 202);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Criar Conta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(98, 165);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Poupança";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 165);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Corrente";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 116);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Saldo";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nome";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(245, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Depositar / Sacar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 145);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(137, 145);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 4;
            label6.Text = "Saldo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 116);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 116);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 6;
            label5.Text = "Conta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 87);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 87);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Nome:";
            // 
            // button3
            // 
            button3.Location = new Point(18, 137);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Sacar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(18, 87);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Depositar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 37);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Valor";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(28, 321);
            label7.Name = "label7";
            label7.Size = new Size(248, 30);
            label7.TabIndex = 3;
            label7.Text = "Saldo Conta Selecionado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 321);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(560, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(305, 225);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Transferir";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(137, 40);
            label21.Name = "label21";
            label21.Size = new Size(30, 15);
            label21.TabIndex = 4;
            label21.Text = "Para";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(227, 142);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 15;
            label20.Text = "label20";
            // 
            // button4
            // 
            button4.Location = new Point(141, 183);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Transferir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(227, 111);
            label19.Name = "label19";
            label19.Size = new Size(44, 15);
            label19.TabIndex = 14;
            label19.Text = "label19";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(178, 37);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 1;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(227, 78);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 13;
            label18.Text = "label18";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 0;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 78);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 7;
            label12.Text = "label12";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(178, 142);
            label17.Name = "label17";
            label17.Size = new Size(39, 15);
            label17.TabIndex = 12;
            label17.Text = "Saldo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 142);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 6;
            label11.Text = "Saldo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 111);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 5;
            label10.Text = "Conta: ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(178, 111);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 11;
            label16.Text = "Conta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 78);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 4;
            label9.Text = "Nome:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(178, 78);
            label15.Name = "label15";
            label15.Size = new Size(43, 15);
            label15.TabIndex = 10;
            label15.Text = "Nome:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(58, 142);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 9;
            label14.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(58, 111);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 8;
            label13.Text = "label13";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 450);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private Button button4;
        private TextBox textBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label1;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label12;
        private Label label17;
        private Label label11;
        private Label label10;
        private Label label16;
        private Label label9;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label21;
    }
}