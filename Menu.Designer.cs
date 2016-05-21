namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.button_registry = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Next_day = new System.Windows.Forms.Button();
            this.thisdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_registry
            // 
            this.button_registry.Location = new System.Drawing.Point(59, 86);
            this.button_registry.Name = "button_registry";
            this.button_registry.Size = new System.Drawing.Size(272, 37);
            this.button_registry.TabIndex = 0;
            this.button_registry.Text = "Регистрация нового вкладчика";
            this.button_registry.UseVisualStyleBackColor = true;
            this.button_registry.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Операции с вкладчиком";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Next_day
            // 
            this.Next_day.Location = new System.Drawing.Point(216, 341);
            this.Next_day.Name = "Next_day";
            this.Next_day.Size = new System.Drawing.Size(115, 25);
            this.Next_day.TabIndex = 3;
            this.Next_day.Text = "Следующий день";
            this.Next_day.UseVisualStyleBackColor = true;
            this.Next_day.Click += new System.EventHandler(this.Next_day_Click);
            // 
            // thisdate
            // 
            this.thisdate.Location = new System.Drawing.Point(216, 315);
            this.thisdate.Name = "thisdate";
            this.thisdate.Size = new System.Drawing.Size(115, 20);
            this.thisdate.TabIndex = 4;
            this.thisdate.Text = "01.01.2009";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 395);
            this.Controls.Add(this.thisdate);
            this.Controls.Add(this.Next_day);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_registry);
            this.Name = "Menu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_registry;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Next_day;
        private System.Windows.Forms.TextBox thisdate;
    }
}

