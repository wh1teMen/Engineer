namespace progect
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.textBox_percent = new System.Windows.Forms.TextBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.textBox_incomeTax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_UpdateSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_percent
            // 
            this.textBox_percent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_percent.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_percent.Location = new System.Drawing.Point(142, 11);
            this.textBox_percent.MaxLength = 2;
            this.textBox_percent.Name = "textBox_percent";
            this.textBox_percent.Size = new System.Drawing.Size(67, 22);
            this.textBox_percent.TabIndex = 0;
            // 
            // textBox_salary
            // 
            this.textBox_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_salary.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_salary.Location = new System.Drawing.Point(142, 41);
            this.textBox_salary.MaxLength = 6;
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(67, 22);
            this.textBox_salary.TabIndex = 1;
            // 
            // textBox_incomeTax
            // 
            this.textBox_incomeTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_incomeTax.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_incomeTax.Location = new System.Drawing.Point(142, 70);
            this.textBox_incomeTax.MaxLength = 2;
            this.textBox_incomeTax.Name = "textBox_incomeTax";
            this.textBox_incomeTax.Size = new System.Drawing.Size(67, 22);
            this.textBox_incomeTax.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "% по ЗП";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Окладная часть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "% Подоходный \r\nналог";
            // 
            // button_UpdateSetting
            // 
            this.button_UpdateSetting.BackColor = System.Drawing.Color.Transparent;
            this.button_UpdateSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UpdateSetting.FlatAppearance.BorderSize = 0;
            this.button_UpdateSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_UpdateSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateSetting.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UpdateSetting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_UpdateSetting.Location = new System.Drawing.Point(15, 109);
            this.button_UpdateSetting.Name = "button_UpdateSetting";
            this.button_UpdateSetting.Size = new System.Drawing.Size(184, 42);
            this.button_UpdateSetting.TabIndex = 6;
            this.button_UpdateSetting.Text = "Изменить";
            this.button_UpdateSetting.UseVisualStyleBackColor = false;
            this.button_UpdateSetting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_UpdateSetting_MouseClick);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(224, 171);
            this.Controls.Add(this.button_UpdateSetting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_incomeTax);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.textBox_percent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_percent;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.TextBox textBox_incomeTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_UpdateSetting;
    }
}