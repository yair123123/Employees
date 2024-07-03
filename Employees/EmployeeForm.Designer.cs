namespace Employees
{
    partial class EmployeeForm
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
            TextBox textBox_id;
            button_prev = new Button();
            button_next = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox_last = new TextBox();
            textBox_first = new TextBox();
            textBox_tz = new TextBox();
            textBox_city = new TextBox();
            textBox_num = new TextBox();
            textBoxstreet = new TextBox();
            textBox_phone = new TextBox();
            textBox_selolar = new TextBox();
            comboBox1 = new ComboBox();
            label_dob = new Label();
            label_city = new Label();
            label_num = new Label();
            label_street = new Label();
            label_phone = new Label();
            label_selolar = new Label();
            label_last_name = new Label();
            label_first_name = new Label();
            label_tz = new Label();
            label_id = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            radioButton_famle = new RadioButton();
            radioButton_male = new RadioButton();
            radioButton_widower = new RadioButton();
            radioButton_divorcee = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton_married = new RadioButton();
            radioButton_Bachelor = new RadioButton();
            textBox_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(606, 48);
            textBox_id.Name = "textBox_id";
            textBox_id.ReadOnly = true;
            textBox_id.Size = new Size(100, 23);
            textBox_id.TabIndex = 8;
            textBox_id.Text = "1";
            // 
            // button_prev
            // 
            button_prev.BackColor = SystemColors.Control;
            button_prev.Location = new Point(144, 321);
            button_prev.Name = "button_prev";
            button_prev.Size = new Size(144, 44);
            button_prev.TabIndex = 0;
            button_prev.Text = "<<<";
            button_prev.UseVisualStyleBackColor = false;
            // 
            // button_next
            // 
            button_next.BackColor = SystemColors.Control;
            button_next.Location = new Point(388, 321);
            button_next.Name = "button_next";
            button_next.Size = new Size(128, 44);
            button_next.TabIndex = 1;
            button_next.Text = ">>>";
            button_next.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Location = new Point(348, 541);
            button3.Name = "button3";
            button3.Size = new Size(181, 34);
            button3.TabIndex = 2;
            button3.Text = "חיפוש עובד לפי תעודת זהות";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Location = new Point(557, 541);
            button4.Name = "button4";
            button4.Size = new Size(184, 34);
            button4.TabIndex = 3;
            button4.Text = "חיפוש עובד לפי קוד";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.Location = new Point(104, 477);
            button5.Name = "button5";
            button5.Size = new Size(88, 35);
            button5.TabIndex = 4;
            button5.Text = "מחיקה";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.Location = new Point(281, 477);
            button6.Name = "button6";
            button6.Size = new Size(93, 35);
            button6.TabIndex = 5;
            button6.Text = "עדכון";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Location = new Point(455, 477);
            button7.Name = "button7";
            button7.Size = new Size(87, 35);
            button7.TabIndex = 6;
            button7.Text = "הוספת עובד";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Control;
            button8.Location = new Point(596, 477);
            button8.Name = "button8";
            button8.Size = new Size(85, 35);
            button8.TabIndex = 7;
            button8.Text = "חדש";
            button8.UseVisualStyleBackColor = false;
            button8.Click += DeleteDetails;
            // 
            // textBox_last
            // 
            textBox_last.Location = new Point(166, 48);
            textBox_last.Name = "textBox_last";
            textBox_last.Size = new Size(100, 23);
            textBox_last.TabIndex = 9;
            // 
            // textBox_first
            // 
            textBox_first.Location = new Point(312, 48);
            textBox_first.Name = "textBox_first";
            textBox_first.Size = new Size(100, 23);
            textBox_first.TabIndex = 10;
            // 
            // textBox_tz
            // 
            textBox_tz.Location = new Point(455, 48);
            textBox_tz.Name = "textBox_tz";
            textBox_tz.Size = new Size(100, 23);
            textBox_tz.TabIndex = 11;
            // 
            // textBox_city
            // 
            textBox_city.Location = new Point(12, 413);
            textBox_city.Name = "textBox_city";
            textBox_city.Size = new Size(100, 23);
            textBox_city.TabIndex = 12;
            // 
            // textBox_num
            // 
            textBox_num.Location = new Point(144, 413);
            textBox_num.Name = "textBox_num";
            textBox_num.Size = new Size(100, 23);
            textBox_num.TabIndex = 13;
            // 
            // textBoxstreet
            // 
            textBoxstreet.Location = new Point(274, 413);
            textBoxstreet.Name = "textBoxstreet";
            textBoxstreet.Size = new Size(100, 23);
            textBoxstreet.TabIndex = 14;
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(429, 413);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(100, 23);
            textBox_phone.TabIndex = 15;
            // 
            // textBox_selolar
            // 
            textBox_selolar.Location = new Point(581, 413);
            textBox_selolar.Name = "textBox_selolar";
            textBox_selolar.Size = new Size(100, 23);
            textBox_selolar.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // label_dob
            // 
            label_dob.AutoSize = true;
            label_dob.Location = new Point(60, 24);
            label_dob.Name = "label_dob";
            label_dob.Size = new Size(68, 15);
            label_dob.TabIndex = 18;
            label_dob.Text = "תאריך לידה";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new Point(43, 395);
            label_city.Name = "label_city";
            label_city.Size = new Size(24, 15);
            label_city.TabIndex = 19;
            label_city.Text = "עיר";
            // 
            // label_num
            // 
            label_num.AutoSize = true;
            label_num.Location = new Point(166, 395);
            label_num.Name = "label_num";
            label_num.Size = new Size(38, 15);
            label_num.TabIndex = 20;
            label_num.Text = "מספר";
            // 
            // label_street
            // 
            label_street.AutoSize = true;
            label_street.Location = new Point(312, 395);
            label_street.Name = "label_street";
            label_street.Size = new Size(32, 15);
            label_street.TabIndex = 21;
            label_street.Text = "רחוב";
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new Point(455, 395);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(65, 15);
            label_phone.TabIndex = 22;
            label_phone.Text = "טלפון בבית";
            // 
            // label_selolar
            // 
            label_selolar.AutoSize = true;
            label_selolar.Location = new Point(606, 395);
            label_selolar.Name = "label_selolar";
            label_selolar.Size = new Size(56, 15);
            label_selolar.TabIndex = 23;
            label_selolar.Text = "טלפון נייד";
            // 
            // label_last_name
            // 
            label_last_name.AutoSize = true;
            label_last_name.Location = new Point(190, 24);
            label_last_name.Name = "label_last_name";
            label_last_name.Size = new Size(68, 15);
            label_last_name.TabIndex = 24;
            label_last_name.Text = "שם משפחה";
            // 
            // label_first_name
            // 
            label_first_name.AutoSize = true;
            label_first_name.Location = new Point(348, 24);
            label_first_name.Name = "label_first_name";
            label_first_name.Size = new Size(53, 15);
            label_first_name.TabIndex = 25;
            label_first_name.Text = "שם פרטי";
            // 
            // label_tz
            // 
            label_tz.AutoSize = true;
            label_tz.Location = new Point(487, 24);
            label_tz.Name = "label_tz";
            label_tz.Size = new Size(68, 15);
            label_tz.TabIndex = 26;
            label_tz.Text = "תעודת זהות";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(637, 24);
            label_id.Name = "label_id";
            label_id.Size = new Size(24, 15);
            label_id.TabIndex = 27;
            label_id.Text = "קוד";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(60, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 156);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_famle);
            groupBox1.Controls.Add(radioButton_male);
            groupBox1.Location = new Point(550, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(156, 157);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // radioButton_famle
            // 
            radioButton_famle.AutoSize = true;
            radioButton_famle.Location = new Point(7, 74);
            radioButton_famle.Name = "radioButton_famle";
            radioButton_famle.Size = new Size(53, 19);
            radioButton_famle.TabIndex = 33;
            radioButton_famle.TabStop = true;
            radioButton_famle.Text = "נקבה";
            radioButton_famle.UseVisualStyleBackColor = true;
            radioButton_famle.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Location = new Point(7, 31);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(43, 19);
            radioButton_male.TabIndex = 33;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "זכר";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_widower
            // 
            radioButton_widower.AutoSize = true;
            radioButton_widower.Location = new Point(7, 159);
            radioButton_widower.Name = "radioButton_widower";
            radioButton_widower.Size = new Size(51, 19);
            radioButton_widower.TabIndex = 31;
            radioButton_widower.TabStop = true;
            radioButton_widower.Text = "אלמן";
            radioButton_widower.UseVisualStyleBackColor = true;
            // 
            // radioButton_divorcee
            // 
            radioButton_divorcee.AutoSize = true;
            radioButton_divorcee.Location = new Point(7, 111);
            radioButton_divorcee.Name = "radioButton_divorcee";
            radioButton_divorcee.Size = new Size(49, 19);
            radioButton_divorcee.TabIndex = 32;
            radioButton_divorcee.TabStop = true;
            radioButton_divorcee.Text = "גרוש";
            radioButton_divorcee.UseVisualStyleBackColor = true;
            radioButton_divorcee.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton_divorcee);
            groupBox2.Controls.Add(radioButton_widower);
            groupBox2.Controls.Add(radioButton_married);
            groupBox2.Controls.Add(radioButton_Bachelor);
            groupBox2.Location = new Point(368, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 207);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // radioButton_married
            // 
            radioButton_married.AutoSize = true;
            radioButton_married.Location = new Point(6, 65);
            radioButton_married.Name = "radioButton_married";
            radioButton_married.Size = new Size(45, 19);
            radioButton_married.TabIndex = 33;
            radioButton_married.TabStop = true;
            radioButton_married.Text = "נשוי";
            radioButton_married.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bachelor
            // 
            radioButton_Bachelor.AutoSize = true;
            radioButton_Bachelor.Location = new Point(7, 22);
            radioButton_Bachelor.Name = "radioButton_Bachelor";
            radioButton_Bachelor.Size = new Size(46, 19);
            radioButton_Bachelor.TabIndex = 33;
            radioButton_Bachelor.TabStop = true;
            radioButton_Bachelor.Text = "רווק";
            radioButton_Bachelor.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(775, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label_id);
            Controls.Add(label_tz);
            Controls.Add(label_first_name);
            Controls.Add(label_last_name);
            Controls.Add(label_selolar);
            Controls.Add(label_phone);
            Controls.Add(label_street);
            Controls.Add(label_num);
            Controls.Add(label_city);
            Controls.Add(label_dob);
            Controls.Add(comboBox1);
            Controls.Add(textBox_selolar);
            Controls.Add(textBox_phone);
            Controls.Add(textBoxstreet);
            Controls.Add(textBox_num);
            Controls.Add(textBox_city);
            Controls.Add(textBox_tz);
            Controls.Add(textBox_first);
            Controls.Add(textBox_last);
            Controls.Add(textBox_id);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button_next);
            Controls.Add(button_prev);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_prev;
        private Button button_next;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox_id;
        private TextBox textBox_last;
        private TextBox textBox_first;
        private TextBox textBox_tz;
        private TextBox textBox_city;
        private TextBox textBox_num;
        private TextBox textBoxstreet;
        private TextBox textBox_phone;
        private TextBox textBox_selolar;
        private ComboBox comboBox1;
        private Label label_dob;
        private Label label_city;
        private Label label_num;
        private Label label_street;
        private Label label_phone;
        private Label label_selolar;
        private Label label_last_name;
        private Label label_first_name;
        private Label label_tz;
        private Label label_id;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton_famle;
        private RadioButton radioButton_male;
        private RadioButton radioButton_widower;
        private RadioButton radioButton_divorcee;
        private GroupBox groupBox2;
        private RadioButton radioButton_married;
        private RadioButton radioButton_Bachelor;
    }
}