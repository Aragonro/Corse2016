namespace WindowsFormsApplication1
{
    partial class Registry
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
            this.f_name = new System.Windows.Forms.TextBox();
            this.s_name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.party_passport = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.number_pasport = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.procent = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.ComboBox();
            this.name_procent = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bank_book = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(105, 18);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(118, 20);
            this.f_name.TabIndex = 1;
            // 
            // s_name
            // 
            this.s_name.Location = new System.Drawing.Point(105, 47);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(118, 20);
            this.s_name.TabIndex = 3;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(105, 73);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(118, 20);
            this.phone.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 99);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Партия паспорта";
            // 
            // party_passport
            // 
            this.party_passport.Location = new System.Drawing.Point(154, 99);
            this.party_passport.Name = "party_passport";
            this.party_passport.Size = new System.Drawing.Size(118, 20);
            this.party_passport.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 125);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(118, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Номер паспорта";
            // 
            // number_pasport
            // 
            this.number_pasport.Location = new System.Drawing.Point(154, 125);
            this.number_pasport.Name = "number_pasport";
            this.number_pasport.Size = new System.Drawing.Size(118, 20);
            this.number_pasport.TabIndex = 9;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(12, 183);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(118, 20);
            this.textBox11.TabIndex = 10;
            this.textBox11.Text = "Суммя вложения";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(154, 182);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(118, 20);
            this.money.TabIndex = 11;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(12, 209);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(118, 20);
            this.textBox13.TabIndex = 14;
            this.textBox13.Text = "Валюта";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(12, 250);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(126, 20);
            this.textBox14.TabIndex = 15;
            this.textBox14.Text = "Количество процентов";
            // 
            // procent
            // 
            this.procent.Location = new System.Drawing.Point(154, 250);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(118, 20);
            this.procent.TabIndex = 16;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(12, 276);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(126, 20);
            this.textBox16.TabIndex = 17;
            this.textBox16.Text = "Поценты";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(24, 359);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 19;
            this.ok.Text = "ОК";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(154, 359);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 20;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // value
            // 
            this.value.FormattingEnabled = true;
            this.value.Items.AddRange(new object[] {
            "Гривна",
            "Долар",
            "Евро"});
            this.value.Location = new System.Drawing.Point(154, 208);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(118, 21);
            this.value.TabIndex = 21;
            // 
            // name_procent
            // 
            this.name_procent.FormattingEnabled = true;
            this.name_procent.Items.AddRange(new object[] {
            "Умные",
            "Обычные"});
            this.name_procent.Location = new System.Drawing.Point(154, 276);
            this.name_procent.Name = "name_procent";
            this.name_procent.Size = new System.Drawing.Size(118, 21);
            this.name_procent.TabIndex = 22;
            this.name_procent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Лицевой счёт";
            // 
            // bank_book
            // 
            this.bank_book.Location = new System.Drawing.Point(154, 151);
            this.bank_book.Name = "bank_book";
            this.bank_book.Size = new System.Drawing.Size(118, 20);
            this.bank_book.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Номер телефона";
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bank_book);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name_procent);
            this.Controls.Add(this.value);
            this.Controls.Add(this.back);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.money);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.number_pasport);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.party_passport);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.f_name);
            this.Name = "Registry";
            this.Text = "Registry";
            this.Load += new System.EventHandler(this.Registry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox party_passport;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox number_pasport;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox procent;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox value;
        private System.Windows.Forms.ComboBox name_procent;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox bank_book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}