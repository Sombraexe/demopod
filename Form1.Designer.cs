namespace demopod
{
    partial class MainmenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainmenuForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdminPanel = new System.Windows.Forms.Button();
            this.opisaniesaita = new System.Windows.Forms.Label();
            this.buying = new System.Windows.Forms.Button();
            this.contactsorganization = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventTableAdapter1 = new demopod.TicketDataSetTableAdapters.EventTableAdapter();
            this.eventLocationOgrTableAdapter1 = new demopod.TicketDataSetTableAdapters.EventLocationOgrTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(692, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Cursor = System.Windows.Forms.Cursors.No;
            this.AdminPanel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminPanel.ForeColor = System.Drawing.Color.Red;
            this.AdminPanel.Location = new System.Drawing.Point(593, 88);
            this.AdminPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(110, 32);
            this.AdminPanel.TabIndex = 2;
            this.AdminPanel.Text = "!Админпанель!";
            this.AdminPanel.UseVisualStyleBackColor = true;
            this.AdminPanel.Click += new System.EventHandler(this.AdminPanel_Click);
            // 
            // opisaniesaita
            // 
            this.opisaniesaita.AutoSize = true;
            this.opisaniesaita.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opisaniesaita.Location = new System.Drawing.Point(120, 22);
            this.opisaniesaita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.opisaniesaita.Name = "opisaniesaita";
            this.opisaniesaita.Size = new System.Drawing.Size(572, 48);
            this.opisaniesaita.TabIndex = 3;
            this.opisaniesaita.Text = resources.GetString("opisaniesaita.Text");
            this.opisaniesaita.Click += new System.EventHandler(this.label1_Click);
            // 
            // buying
            // 
            this.buying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buying.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buying.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buying.Location = new System.Drawing.Point(465, 88);
            this.buying.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buying.Name = "buying";
            this.buying.Size = new System.Drawing.Size(122, 32);
            this.buying.TabIndex = 4;
            this.buying.Text = "КУПИТЬ БИЛЕТЫ";
            this.buying.UseVisualStyleBackColor = true;
            // 
            // contactsorganization
            // 
            this.contactsorganization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactsorganization.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactsorganization.Location = new System.Drawing.Point(334, 88);
            this.contactsorganization.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.contactsorganization.Name = "contactsorganization";
            this.contactsorganization.Size = new System.Drawing.Size(127, 32);
            this.contactsorganization.TabIndex = 5;
            this.contactsorganization.Text = "Контакты организации";
            this.contactsorganization.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // eventTableAdapter1
            // 
            this.eventTableAdapter1.ClearBeforeFill = true;
            // 
            // eventLocationOgrTableAdapter1
            // 
            this.eventLocationOgrTableAdapter1.ClearBeforeFill = true;
            // 
            // MainmenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 412);
            this.Controls.Add(this.contactsorganization);
            this.Controls.Add(this.buying);
            this.Controls.Add(this.opisaniesaita);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainmenuForm";
            this.Text = "OnlineSells - Покупка онлайн билетов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdminPanel;
        private System.Windows.Forms.Label opisaniesaita;
        private System.Windows.Forms.Button buying;
        private System.Windows.Forms.Button contactsorganization;
        private TicketDataSetTableAdapters.EventTableAdapter eventTableAdapter1;
        private TicketDataSetTableAdapters.EventLocationOgrTableAdapter eventLocationOgrTableAdapter1;
    }
}

