namespace WindowsFormsApplication1
{
    partial class Operation
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
            this.depositor = new System.Windows.Forms.TextBox();
            this.chose_filter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.s_name = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.pasport_party = new System.Windows.Forms.Label();
            this.pasport = new System.Windows.Forms.Label();
            this.bank_book = new System.Windows.Forms.Label();
            this.dep_money = new System.Windows.Forms.Label();
            this.valuta = new System.Windows.Forms.Label();
            this.procent = new System.Windows.Forms.Label();
            this.procent_name = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.chose_operation = new System.Windows.Forms.ComboBox();
            this.money = new System.Windows.Forms.TextBox();
            this.ok_operation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.all_money = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // depositor
            // 
            this.depositor.Location = new System.Drawing.Point(38, 73);
            this.depositor.Name = "depositor";
            this.depositor.Size = new System.Drawing.Size(158, 20);
            this.depositor.TabIndex = 0;
            // 
            // chose_filter
            // 
            this.chose_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chose_filter.FormattingEnabled = true;
            this.chose_filter.IntegralHeight = false;
            this.chose_filter.Items.AddRange(new object[] {
            "Паспортные данные",
            "Лицевой счёт"});
            this.chose_filter.Location = new System.Drawing.Point(38, 27);
            this.chose_filter.Name = "chose_filter";
            this.chose_filter.Size = new System.Drawing.Size(158, 21);
            this.chose_filter.TabIndex = 2;
            this.chose_filter.SelectedIndexChanged += new System.EventHandler(this.chose_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Проценты";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Количество процентов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Валюта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Сумма вложения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Лицевой счёт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Партия паспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Имя";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(182, 100);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 13);
            this.name.TabIndex = 45;
            // 
            // s_name
            // 
            this.s_name.AutoSize = true;
            this.s_name.Location = new System.Drawing.Point(182, 126);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(0, 13);
            this.s_name.TabIndex = 46;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(182, 152);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(0, 13);
            this.phone.TabIndex = 47;
            // 
            // pasport_party
            // 
            this.pasport_party.AutoSize = true;
            this.pasport_party.Location = new System.Drawing.Point(182, 178);
            this.pasport_party.Name = "pasport_party";
            this.pasport_party.Size = new System.Drawing.Size(0, 13);
            this.pasport_party.TabIndex = 48;
            // 
            // pasport
            // 
            this.pasport.AutoSize = true;
            this.pasport.Location = new System.Drawing.Point(182, 207);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(0, 13);
            this.pasport.TabIndex = 49;
            // 
            // bank_book
            // 
            this.bank_book.AutoSize = true;
            this.bank_book.Location = new System.Drawing.Point(182, 233);
            this.bank_book.Name = "bank_book";
            this.bank_book.Size = new System.Drawing.Size(0, 13);
            this.bank_book.TabIndex = 50;
            // 
            // dep_money
            // 
            this.dep_money.AutoSize = true;
            this.dep_money.Location = new System.Drawing.Point(182, 256);
            this.dep_money.Name = "dep_money";
            this.dep_money.Size = new System.Drawing.Size(0, 13);
            this.dep_money.TabIndex = 51;
            // 
            // valuta
            // 
            this.valuta.AutoSize = true;
            this.valuta.Location = new System.Drawing.Point(182, 301);
            this.valuta.Name = "valuta";
            this.valuta.Size = new System.Drawing.Size(0, 13);
            this.valuta.TabIndex = 52;
            // 
            // procent
            // 
            this.procent.AutoSize = true;
            this.procent.Location = new System.Drawing.Point(182, 331);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(0, 13);
            this.procent.TabIndex = 53;
            // 
            // procent_name
            // 
            this.procent_name.AutoSize = true;
            this.procent_name.Location = new System.Drawing.Point(182, 358);
            this.procent_name.Name = "procent_name";
            this.procent_name.Size = new System.Drawing.Size(0, 13);
            this.procent_name.TabIndex = 54;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(202, 70);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 55;
            this.ok.Text = "Найти";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // chose_operation
            // 
            this.chose_operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chose_operation.FormattingEnabled = true;
            this.chose_operation.Items.AddRange(new object[] {
            "Снять деньги",
            "Вложить деньги"});
            this.chose_operation.Location = new System.Drawing.Point(38, 386);
            this.chose_operation.Name = "chose_operation";
            this.chose_operation.Size = new System.Drawing.Size(158, 21);
            this.chose_operation.TabIndex = 56;
            this.chose_operation.Visible = false;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(37, 423);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(159, 20);
            this.money.TabIndex = 57;
            this.money.Visible = false;
            // 
            // ok_operation
            // 
            this.ok_operation.Location = new System.Drawing.Point(202, 423);
            this.ok_operation.Name = "ok_operation";
            this.ok_operation.Size = new System.Drawing.Size(75, 23);
            this.ok_operation.TabIndex = 58;
            this.ok_operation.Text = "ОК";
            this.ok_operation.UseVisualStyleBackColor = true;
            this.ok_operation.Visible = false;
            this.ok_operation.Click += new System.EventHandler(this.ok_operation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Текущая сумма";
            // 
            // all_money
            // 
            this.all_money.AutoSize = true;
            this.all_money.Location = new System.Drawing.Point(182, 279);
            this.all_money.Name = "all_money";
            this.all_money.Size = new System.Drawing.Size(0, 13);
            this.all_money.TabIndex = 60;
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 472);
            this.Controls.Add(this.all_money);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ok_operation);
            this.Controls.Add(this.money);
            this.Controls.Add(this.chose_operation);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.procent_name);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.valuta);
            this.Controls.Add(this.dep_money);
            this.Controls.Add(this.bank_book);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.pasport_party);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.name);
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
            this.Controls.Add(this.chose_filter);
            this.Controls.Add(this.depositor);
            this.Name = "Operation";
            this.Text = "Операции";
            this.Load += new System.EventHandler(this.Operation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox depositor;
        private System.Windows.Forms.ComboBox chose_filter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label s_name;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label pasport_party;
        private System.Windows.Forms.Label pasport;
        private System.Windows.Forms.Label bank_book;
        private System.Windows.Forms.Label dep_money;
        private System.Windows.Forms.Label valuta;
        private System.Windows.Forms.Label procent;
        private System.Windows.Forms.Label procent_name;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ComboBox chose_operation;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Button ok_operation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label all_money;
    }
}