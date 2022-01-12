
namespace demopod
{
    partial class AdministrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.opisaniesaita = new System.Windows.Forms.Label();
            this.createuser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createorg = new System.Windows.Forms.Button();
            this.createevent = new System.Windows.Forms.Button();
            this.goback1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // opisaniesaita
            // 
            this.opisaniesaita.AutoSize = true;
            this.opisaniesaita.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opisaniesaita.Location = new System.Drawing.Point(74, 25);
            this.opisaniesaita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.opisaniesaita.Name = "opisaniesaita";
            this.opisaniesaita.Size = new System.Drawing.Size(407, 60);
            this.opisaniesaita.TabIndex = 7;
            this.opisaniesaita.Text = "Добро пожаловать в панель Администратора\r\n\r\nВ этой панели вы можете создавать мер" +
    "оприятия (ивенты) добавлять продавцов/организаторов\r\nА также указывать информаци" +
    "ю о предстоящем мероприятии";
            // 
            // createuser
            // 
            this.createuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createuser.Location = new System.Drawing.Point(12, 91);
            this.createuser.Name = "createuser";
            this.createuser.Size = new System.Drawing.Size(225, 23);
            this.createuser.TabIndex = 8;
            this.createuser.Text = "Создание Пользователя";
            this.createuser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.createuser.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(260, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить информацию об организации";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // createorg
            // 
            this.createorg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createorg.Location = new System.Drawing.Point(12, 129);
            this.createorg.Name = "createorg";
            this.createorg.Size = new System.Drawing.Size(225, 23);
            this.createorg.TabIndex = 10;
            this.createorg.Text = "Создание организации";
            this.createorg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.createorg.UseVisualStyleBackColor = true;
            // 
            // createevent
            // 
            this.createevent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createevent.Location = new System.Drawing.Point(260, 129);
            this.createevent.Name = "createevent";
            this.createevent.Size = new System.Drawing.Size(212, 23);
            this.createevent.TabIndex = 11;
            this.createevent.Text = "Создание события";
            this.createevent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.createevent.UseVisualStyleBackColor = true;
            // 
            // goback1
            // 
            this.goback1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goback1.Location = new System.Drawing.Point(52, 158);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(75, 23);
            this.goback1.TabIndex = 12;
            this.goback1.Text = "Назад";
            this.goback1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.goback1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 188);
            this.Controls.Add(this.goback1);
            this.Controls.Add(this.createevent);
            this.Controls.Add(this.createorg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createuser);
            this.Controls.Add(this.opisaniesaita);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AdministrationForm";
            this.Text = "Панель Администратора";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label opisaniesaita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createuser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button createorg;
        private System.Windows.Forms.Button createevent;
        private System.Windows.Forms.Button goback1;
    }
}