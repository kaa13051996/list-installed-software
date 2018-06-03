namespace list_soft_metro
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.panel_user = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_name_user = new System.Windows.Forms.Label();
            this.panel_image = new System.Windows.Forms.Panel();
            this.roundedPicBox = new list_soft_metro.RoundedPicBox();
            this.button_main = new System.Windows.Forms.Button();
            this.panel_head = new System.Windows.Forms.Panel();
            this.button_info = new System.Windows.Forms.Button();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.label_name_program = new System.Windows.Forms.Label();
            this.panel_common = new System.Windows.Forms.Panel();
            this.panel_user.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicBox)).BeginInit();
            this.panel_head.SuspendLayout();
            this.panel_common.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.panel_user.Controls.Add(this.panel1);
            this.panel_user.Controls.Add(this.panel_image);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Margin = new System.Windows.Forms.Padding(0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(213, 68);
            this.panel_user.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_name_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(89, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 68);
            this.panel1.TabIndex = 4;
            // 
            // label_name_user
            // 
            this.label_name_user.AutoSize = true;
            this.label_name_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_name_user.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_user.Location = new System.Drawing.Point(3, 26);
            this.label_name_user.Name = "label_name_user";
            this.label_name_user.Size = new System.Drawing.Size(91, 21);
            this.label_name_user.TabIndex = 0;
            this.label_name_user.Text = "name user";
            this.label_name_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_image
            // 
            this.panel_image.Controls.Add(this.roundedPicBox);
            this.panel_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_image.Location = new System.Drawing.Point(0, 0);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(89, 68);
            this.panel_image.TabIndex = 3;
            // 
            // roundedPicBox
            // 
            this.roundedPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roundedPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("roundedPicBox.InitialImage")));
            this.roundedPicBox.Location = new System.Drawing.Point(12, 2);
            this.roundedPicBox.Name = "roundedPicBox";
            this.roundedPicBox.Size = new System.Drawing.Size(66, 64);
            this.roundedPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundedPicBox.TabIndex = 2;
            this.roundedPicBox.TabStop = false;
            // 
            // button_main
            // 
            this.button_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.button_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_main.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_main.FlatAppearance.BorderSize = 0;
            this.button_main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button_main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_main.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main.Location = new System.Drawing.Point(0, 68);
            this.button_main.Margin = new System.Windows.Forms.Padding(0);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(213, 40);
            this.button_main.TabIndex = 1;
            this.button_main.Text = "main";
            this.button_main.UseVisualStyleBackColor = false;
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.panel_head.Controls.Add(this.button_info);
            this.panel_head.Controls.Add(this.button_main);
            this.panel_head.Controls.Add(this.panel_user);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_head.Location = new System.Drawing.Point(18, 30);
            this.panel_head.Margin = new System.Windows.Forms.Padding(0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(213, 390);
            this.panel_head.TabIndex = 0;
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.button_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_info.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_info.FlatAppearance.BorderSize = 0;
            this.button_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_info.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_info.Location = new System.Drawing.Point(0, 108);
            this.button_info.Margin = new System.Windows.Forms.Padding(0);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(213, 40);
            this.button_info.TabIndex = 2;
            this.button_info.Text = "info";
            this.button_info.UseVisualStyleBackColor = false;
            // 
            // textBox_info
            // 
            this.textBox_info.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_info.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_info.Location = new System.Drawing.Point(0, 0);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ReadOnly = true;
            this.textBox_info.Size = new System.Drawing.Size(452, 390);
            this.textBox_info.TabIndex = 1;
            this.textBox_info.Text = resources.GetString("textBox_info.Text");
            // 
            // label_name_program
            // 
            this.label_name_program.AutoSize = true;
            this.label_name_program.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(215)));
            this.label_name_program.Location = new System.Drawing.Point(20, 10);
            this.label_name_program.Name = "label_name_program";
            this.label_name_program.Size = new System.Drawing.Size(93, 23);
            this.label_name_program.TabIndex = 2;
            this.label_name_program.Text = "SOFT LIST";
            // 
            // panel_common
            // 
            this.panel_common.Controls.Add(this.textBox_info);
            this.panel_common.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_common.Location = new System.Drawing.Point(231, 30);
            this.panel_common.Name = "panel_common";
            this.panel_common.Size = new System.Drawing.Size(452, 390);
            this.panel_common.TabIndex = 6;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(701, 440);
            this.Controls.Add(this.panel_common);
            this.Controls.Add(this.label_name_program);
            this.Controls.Add(this.panel_head);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FormInfo";
            this.Padding = new System.Windows.Forms.Padding(18, 30, 18, 20);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "LIST SOFT";
            this.panel_user.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicBox)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_common.ResumeLayout(false);
            this.panel_common.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_name_program;
        private System.Windows.Forms.Label label_name_user;
        private RoundedPicBox roundedPicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_image;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Panel panel_common;
    }
}

