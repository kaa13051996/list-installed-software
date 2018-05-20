namespace list_soft_metro
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_user = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_name_user = new System.Windows.Forms.Label();
            this.panel_image = new System.Windows.Forms.Panel();
            this.button_main = new System.Windows.Forms.Button();
            this.panel_head = new System.Windows.Forms.Panel();
            this.button_info = new System.Windows.Forms.Button();
            this.panel_info = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_name_program = new System.Windows.Forms.Label();
            this.roundedPicBox = new list_soft_metro.RoundedPicBox();
            this.panel_user.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_image.SuspendLayout();
            this.panel_head.SuspendLayout();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicBox)).BeginInit();
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
            this.panel_user.Size = new System.Drawing.Size(183, 68);
            this.panel_user.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_name_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(89, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 68);
            this.panel1.TabIndex = 4;
            // 
            // label_name_user
            // 
            this.label_name_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.button_main.Size = new System.Drawing.Size(183, 40);
            this.button_main.TabIndex = 1;
            this.button_main.Text = "main";
            this.button_main.UseVisualStyleBackColor = false;
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.White;
            this.panel_head.Controls.Add(this.button_info);
            this.panel_head.Controls.Add(this.button_main);
            this.panel_head.Controls.Add(this.panel_user);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_head.Location = new System.Drawing.Point(18, 30);
            this.panel_head.Margin = new System.Windows.Forms.Padding(0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(183, 390);
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
            this.button_info.Size = new System.Drawing.Size(183, 40);
            this.button_info.TabIndex = 2;
            this.button_info.Text = "info";
            this.button_info.UseVisualStyleBackColor = false;
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.Transparent;
            this.panel_info.Controls.Add(this.dataGridView);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_info.Location = new System.Drawing.Point(201, 30);
            this.panel_info.Margin = new System.Windows.Forms.Padding(0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(410, 390);
            this.panel_info.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(410, 390);
            this.dataGridView.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.FillWeight = 194.9239F;
            this.name.Frozen = true;
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 200;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // date
            // 
            this.date.FillWeight = 5.076141F;
            this.date.HeaderText = "date install";
            this.date.Name = "date";
            this.date.ReadOnly = true;
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
            // roundedPicBox
            // 
            this.roundedPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roundedPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("roundedPicBox.InitialImage")));
            this.roundedPicBox.Location = new System.Drawing.Point(12, 3);
            this.roundedPicBox.Name = "roundedPicBox";
            this.roundedPicBox.Size = new System.Drawing.Size(66, 64);
            this.roundedPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundedPicBox.TabIndex = 2;
            this.roundedPicBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(629, 440);
            this.Controls.Add(this.label_name_program);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_head);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(18, 30, 18, 20);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "LIST SOFT";
            this.panel_user.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_image.ResumeLayout(false);
            this.panel_head.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_name_program;
        private System.Windows.Forms.Label label_name_user;
        private RoundedPicBox roundedPicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button button_info;
    }
}

