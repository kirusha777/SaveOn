namespace saving_online_pages
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.link = new System.Windows.Forms.TextBox();
            this.name_link = new System.Windows.Forms.Label();
            this.save_website = new System.Windows.Forms.Button();
            this.proxy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(12, 28);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(129, 20);
            this.link.TabIndex = 0;
            this.link.Text = "https://cattish.ru/breed/";
            // 
            // name_link
            // 
            this.name_link.AutoSize = true;
            this.name_link.Location = new System.Drawing.Point(12, 9);
            this.name_link.Name = "name_link";
            this.name_link.Size = new System.Drawing.Size(129, 13);
            this.name_link.TabIndex = 1;
            this.name_link.Text = "введите ссылку на сайт";
            // 
            // save_website
            // 
            this.save_website.Location = new System.Drawing.Point(30, 107);
            this.save_website.Name = "save_website";
            this.save_website.Size = new System.Drawing.Size(90, 23);
            this.save_website.TabIndex = 2;
            this.save_website.Text = "скачать сайт";
            this.save_website.UseVisualStyleBackColor = true;
            this.save_website.Click += new System.EventHandler(this.save_website_Click);
            // 
            // proxy
            // 
            this.proxy.AutoSize = true;
            this.proxy.Location = new System.Drawing.Point(12, 70);
            this.proxy.Name = "proxy";
            this.proxy.Size = new System.Drawing.Size(136, 17);
            this.proxy.TabIndex = 3;
            this.proxy.Text = "использовать прокси";
            this.proxy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 166);
            this.Controls.Add(this.proxy);
            this.Controls.Add(this.save_website);
            this.Controls.Add(this.name_link);
            this.Controls.Add(this.link);
            this.Name = "Form1";
            this.Text = "saving online pages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Label name_link;
        private System.Windows.Forms.Button save_website;
        private System.Windows.Forms.CheckBox proxy;
    }
}

