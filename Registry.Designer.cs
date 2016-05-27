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
            this.party_passport = new System.Windows.Forms.TextBox();
            this.number_pasport = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.procent = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.name_procent = new System.Windows.Forms.ComboBox();
            this.bank_book = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.valuta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(133, 24);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(118, 20);
            this.f_name.TabIndex = 1;
            // 
            // s_name
            // 
            this.s_name.Location = new System.Drawing.Point(133, 50);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(118, 20);
            this.s_name.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(133, 76);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(118, 20);
            this.phone.TabIndex = 3;
            // 
            // party_passport
            // 
            this.party_passport.Location = new System.Drawing.Point(133, 102);
            this.party_passport.Name = "party_passport";
            this.party_passport.Size = new System.Drawing.Size(118, 20);
            this.party_passport.TabIndex = 4;
            // 
            // number_pasport
            // 
            this.number_pasport.Location = new System.Drawing.Point(133, 128);
            this.number_pasport.Name = "number_pasport";
            this.number_pasport.Size = new System.Drawing.Size(118, 20);
            this.number_pasport.TabIndex = 5;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(133, 180);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(118, 20);
            this.money.TabIndex = 7;
            // 
            // procent
            // 
            this.procent.Location = new System.Drawing.Point(133, 237);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(118, 20);
            this.procent.TabIndex = 9;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(31, 311);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 11;
            this.ok.Text = "ОК";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(158, 311);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 12;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // name_procent
            // 
            this.name_procent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_procent.FormattingEnabled = true;
            this.name_procent.Items.AddRange(new object[] {
            "Умные",
            "Обычные"});
            this.name_procent.Location = new System.Drawing.Point(133, 263);
            this.name_procent.Name = "name_procent";
            this.name_procent.Size = new System.Drawing.Size(118, 21);
            this.name_procent.TabIndex = 10;
            this.name_procent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bank_book
            // 
            this.bank_book.Location = new System.Drawing.Point(133, 154);
            this.bank_book.Name = "bank_book";
            this.bank_book.Size = new System.Drawing.Size(118, 20);
            this.bank_book.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Партия паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Номер паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Лицевой счёт";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Сумма вложения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Валюта";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Количество процентов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Проценты";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // valuta
            // 
            this.valuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valuta.FormattingEnabled = true;
            this.valuta.Items.AddRange(new object[] {
            "Гривна",
            "Долар",
            "Евро"});
            this.valuta.Location = new System.Drawing.Point(133, 206);
            this.valuta.Name = "valuta";
            this.valuta.Size = new System.Drawing.Size(118, 21);
            this.valuta.TabIndex = 8;
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 350);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bank_book);
            this.Controls.Add(this.name_procent);
            this.Controls.Add(this.valuta);
            this.Controls.Add(this.back);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.money);
            this.Controls.Add(this.number_pasport);
            this.Controls.Add(this.party_passport);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.f_name);
            this.Name = "Registry";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox party_passport;
        private System.Windows.Forms.TextBox number_pasport;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox procent;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox name_procent;
        private System.Windows.Forms.TextBox bank_book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox valuta;
    }
}