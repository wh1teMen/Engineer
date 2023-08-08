namespace progect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_add = new System.Windows.Forms.Button();
            this.button_setting = new System.Windows.Forms.Button();
            this.label_SumBaraban = new System.Windows.Forms.Label();
            this.checkBox_show = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_kartridg = new System.Windows.Forms.Label();
            this.label_profit = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_add.BackgroundImage")));
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(12, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(90, 70);
            this.button_add.TabIndex = 0;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_add_MouseClick);
            // 
            // button_setting
            // 
            this.button_setting.BackColor = System.Drawing.Color.Transparent;
            this.button_setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_setting.BackgroundImage")));
            this.button_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_setting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_setting.FlatAppearance.BorderSize = 0;
            this.button_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_setting.Location = new System.Drawing.Point(204, 12);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(90, 70);
            this.button_setting.TabIndex = 3;
            this.button_setting.UseVisualStyleBackColor = false;
            this.button_setting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_setting_MouseClick);
            // 
            // label_SumBaraban
            // 
            this.label_SumBaraban.AutoSize = true;
            this.label_SumBaraban.BackColor = System.Drawing.Color.Transparent;
            this.label_SumBaraban.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SumBaraban.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_SumBaraban.Location = new System.Drawing.Point(79, 85);
            this.label_SumBaraban.Name = "label_SumBaraban";
            this.label_SumBaraban.Size = new System.Drawing.Size(50, 22);
            this.label_SumBaraban.TabIndex = 4;
            this.label_SumBaraban.Text = "*****";
            // 
            // checkBox_show
            // 
            this.checkBox_show.AutoSize = true;
            this.checkBox_show.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_show.Location = new System.Drawing.Point(217, 121);
            this.checkBox_show.Name = "checkBox_show";
            this.checkBox_show.Size = new System.Drawing.Size(75, 17);
            this.checkBox_show.TabIndex = 5;
            this.checkBox_show.Text = "Показать";
            this.checkBox_show.UseVisualStyleBackColor = false;
            this.checkBox_show.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Барабаны:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(144, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Картриджей:";
            // 
            // label_kartridg
            // 
            this.label_kartridg.AutoSize = true;
            this.label_kartridg.BackColor = System.Drawing.Color.Transparent;
            this.label_kartridg.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kartridg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_kartridg.Location = new System.Drawing.Point(232, 85);
            this.label_kartridg.Name = "label_kartridg";
            this.label_kartridg.Size = new System.Drawing.Size(50, 22);
            this.label_kartridg.TabIndex = 8;
            this.label_kartridg.Text = "*****";
            // 
            // label_profit
            // 
            this.label_profit.AutoSize = true;
            this.label_profit.BackColor = System.Drawing.Color.Transparent;
            this.label_profit.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_profit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_profit.Location = new System.Drawing.Point(79, 114);
            this.label_profit.Name = "label_profit";
            this.label_profit.Size = new System.Drawing.Size(50, 22);
            this.label_profit.TabIndex = 10;
            this.label_profit.Text = "*****";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.BackColor = System.Drawing.Color.Transparent;
            this.label_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_3.Location = new System.Drawing.Point(4, 118);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(93, 16);
            this.label_3.TabIndex = 9;
            this.label_3.Text = "Зарплата:     ";
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.Transparent;
            this.button_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_show.BackgroundImage")));
            this.button_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_show.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.button_show.FlatAppearance.BorderSize = 0;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.ForeColor = System.Drawing.Color.Transparent;
            this.button_show.Location = new System.Drawing.Point(108, 12);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(90, 70);
            this.button_show.TabIndex = 11;
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 151);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label_profit);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_kartridg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_show);
            this.Controls.Add(this.label_SumBaraban);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.button_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engineer v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Label label_SumBaraban;
        private System.Windows.Forms.CheckBox checkBox_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_kartridg;
        private System.Windows.Forms.Label label_profit;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Button button_show;
    }
}

