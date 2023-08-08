namespace progect
{
    partial class FormShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShow));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox_remcard = new System.Windows.Forms.TextBox();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Shows = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_folder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(918, 495);
            this.dataGridView.TabIndex = 0;
            // 
            // textBox_remcard
            // 
            this.textBox_remcard.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_remcard.Location = new System.Drawing.Point(12, 31);
            this.textBox_remcard.MaxLength = 10;
            this.textBox_remcard.Name = "textBox_remcard";
            this.textBox_remcard.Size = new System.Drawing.Size(136, 29);
            this.textBox_remcard.TabIndex = 4;
            // 
            // comboBox_month
            // 
            this.comboBox_month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(368, 40);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(75, 21);
            this.comboBox_month.TabIndex = 5;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_delete.BackgroundImage")));
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Location = new System.Drawing.Point(154, 30);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(30, 30);
            this.button_delete.TabIndex = 3;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Shows
            // 
            this.button_Shows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Shows.BackColor = System.Drawing.Color.Transparent;
            this.button_Shows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Shows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Shows.FlatAppearance.BorderSize = 0;
            this.button_Shows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Shows.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Shows.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Shows.Location = new System.Drawing.Point(515, 31);
            this.button_Shows.Name = "button_Shows";
            this.button_Shows.Size = new System.Drawing.Size(125, 30);
            this.button_Shows.TabIndex = 6;
            this.button_Shows.Text = "ПОКАЗАТЬ";
            this.button_Shows.UseVisualStyleBackColor = false;
            this.button_Shows.Click += new System.EventHandler(this.button_Shows_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.BackColor = System.Drawing.Color.Transparent;
            this.button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save.BackgroundImage")));
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_save.FlatAppearance.BorderSize = 3;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Location = new System.Drawing.Point(799, 23);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(40, 40);
            this.button_save.TabIndex = 2;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_save_MouseClick);
            // 
            // textBox_year
            // 
            this.textBox_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_year.Location = new System.Drawing.Point(449, 41);
            this.textBox_year.MaxLength = 4;
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(60, 20);
            this.textBox_year.TabIndex = 7;
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.BackColor = System.Drawing.Color.Transparent;
            this.button_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refresh.BackgroundImage")));
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_refresh.FlatAppearance.BorderSize = 3;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(730, 23);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(40, 40);
            this.button_refresh.TabIndex = 1;
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_refresh_MouseClick);
            // 
            // button_folder
            // 
            this.button_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_folder.BackColor = System.Drawing.Color.Transparent;
            this.button_folder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_folder.BackgroundImage")));
            this.button_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_folder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_folder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_folder.FlatAppearance.BorderSize = 3;
            this.button_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_folder.Location = new System.Drawing.Point(865, 23);
            this.button_folder.Name = "button_folder";
            this.button_folder.Size = new System.Drawing.Size(40, 40);
            this.button_folder.TabIndex = 8;
            this.button_folder.UseVisualStyleBackColor = false;
            this.button_folder.Click += new System.EventHandler(this.button_folder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(376, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Месяц";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(460, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Год";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер Рем.карты";
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_folder);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_Shows);
            this.Controls.Add(this.textBox_remcard);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.comboBox_month);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные";
            this.Load += new System.EventHandler(this.FormShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox_remcard;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Shows;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}