namespace Laba_2
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label_1 = new Label();
            label_3 = new Label();
            label_2 = new Label();
            label_4 = new Label();
            label_5 = new Label();
            label_6 = new Label();
            label_7 = new Label();
            listBox_1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_1
            // 
            label_1.BackColor = Color.AntiqueWhite;
            label_1.BorderStyle = BorderStyle.Fixed3D;
            label_1.Font = new Font("Segoe UI", 30F);
            label_1.Location = new Point(17, 37);
            label_1.Name = "label_1";
            label_1.Size = new Size(50, 50);
            label_1.TabIndex = 1;
            label_1.Text = "0";
            // 
            // label_3
            // 
            label_3.BackColor = Color.AntiqueWhite;
            label_3.BorderStyle = BorderStyle.Fixed3D;
            label_3.Font = new Font("Segoe UI", 30F);
            label_3.Location = new Point(129, 37);
            label_3.Name = "label_3";
            label_3.Size = new Size(50, 50);
            label_3.TabIndex = 2;
            label_3.Text = "0";
            // 
            // label_2
            // 
            label_2.BackColor = Color.AntiqueWhite;
            label_2.BorderStyle = BorderStyle.Fixed3D;
            label_2.Font = new Font("Segoe UI", 30F);
            label_2.Location = new Point(73, 37);
            label_2.Name = "label_2";
            label_2.Size = new Size(50, 50);
            label_2.TabIndex = 3;
            label_2.Text = "0";
            // 
            // label_4
            // 
            label_4.BackColor = Color.AntiqueWhite;
            label_4.BorderStyle = BorderStyle.Fixed3D;
            label_4.Font = new Font("Segoe UI", 30F);
            label_4.Location = new Point(185, 37);
            label_4.Name = "label_4";
            label_4.Size = new Size(50, 50);
            label_4.TabIndex = 4;
            label_4.Text = "0";
            // 
            // label_5
            // 
            label_5.BackColor = Color.AntiqueWhite;
            label_5.BorderStyle = BorderStyle.Fixed3D;
            label_5.Font = new Font("Segoe UI", 30F);
            label_5.Location = new Point(241, 37);
            label_5.Name = "label_5";
            label_5.Size = new Size(50, 50);
            label_5.TabIndex = 5;
            label_5.Text = "0";
            // 
            // label_6
            // 
            label_6.BackColor = Color.AntiqueWhite;
            label_6.BorderStyle = BorderStyle.Fixed3D;
            label_6.Font = new Font("Segoe UI", 30F);
            label_6.Location = new Point(297, 37);
            label_6.Name = "label_6";
            label_6.Size = new Size(50, 50);
            label_6.TabIndex = 6;
            label_6.Text = "0";
            // 
            // label_7
            // 
            label_7.BackColor = Color.AntiqueWhite;
            label_7.BorderStyle = BorderStyle.Fixed3D;
            label_7.Font = new Font("Segoe UI", 30F);
            label_7.Location = new Point(353, 37);
            label_7.Name = "label_7";
            label_7.Size = new Size(50, 50);
            label_7.TabIndex = 7;
            label_7.Text = "0";
            // 
            // listBox_1
            // 
            listBox_1.BackColor = Color.AntiqueWhite;
            listBox_1.Font = new Font("Segoe UI", 23F);
            listBox_1.FormattingEnabled = true;
            listBox_1.ImeMode = ImeMode.NoControl;
            listBox_1.ItemHeight = 42;
            listBox_1.Location = new Point(17, 128);
            listBox_1.Name = "listBox_1";
            listBox_1.Size = new Size(189, 46);
            listBox_1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(267, 128);
            button1.Name = "button1";
            button1.Size = new Size(136, 50);
            button1.TabIndex = 9;
            button1.Text = "Нажми на меня!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(button1);
            Controls.Add(listBox_1);
            Controls.Add(label_7);
            Controls.Add(label_6);
            Controls.Add(label_5);
            Controls.Add(label_4);
            Controls.Add(label_2);
            Controls.Add(label_3);
            Controls.Add(label_1);
            Name = "UserControl1";
            Size = new Size(420, 203);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label_1;
        private Label label_3;
        private Label label_2;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private ListBox listBox_1;
        private Button button1;
    }
}
