
namespace demopod
{
    partial class BuyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerForm));
            this.opisaniesaita = new System.Windows.Forms.Label();
            this.Takeaction = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.Fullname = new System.Windows.Forms.Label();
            this.Percentagetext = new System.Windows.Forms.TextBox();
            this.Telephontext = new System.Windows.Forms.TextBox();
            this.Fullnametext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // opisaniesaita
            // 
            this.opisaniesaita.AutoSize = true;
            this.opisaniesaita.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opisaniesaita.Location = new System.Drawing.Point(70, 22);
            this.opisaniesaita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.opisaniesaita.Name = "opisaniesaita";
            this.opisaniesaita.Size = new System.Drawing.Size(363, 45);
            this.opisaniesaita.TabIndex = 5;
            this.opisaniesaita.Text = "Добро пожаловать в форму покупки необходимого вам билета\r\nДля того чтобы осуществ" +
    "ить покупку билета, необходимо указать следующие данные, \r\nпосле чего нажать на " +
    "кнопку \"Оплатить\"";
            // 
            // Takeaction
            // 
            this.Takeaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Takeaction.Location = new System.Drawing.Point(243, 212);
            this.Takeaction.Name = "Takeaction";
            this.Takeaction.Size = new System.Drawing.Size(181, 47);
            this.Takeaction.TabIndex = 37;
            this.Takeaction.Text = "Оплатить";
            this.Takeaction.UseVisualStyleBackColor = true;
            this.Takeaction.Click += new System.EventHandler(this.Takeaction_Click);
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Location = new System.Drawing.Point(74, 181);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(32, 15);
            this.Percentage.TabIndex = 35;
            this.Percentage.Text = "E-Mail";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Location = new System.Drawing.Point(70, 127);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(41, 15);
            this.Telephone.TabIndex = 34;
            this.Telephone.Text = "Телефон";
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.Location = new System.Drawing.Point(74, 85);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(26, 15);
            this.Fullname.TabIndex = 33;
            this.Fullname.Text = "ФИО";
            // 
            // Percentagetext
            // 
            this.Percentagetext.Location = new System.Drawing.Point(130, 163);
            this.Percentagetext.Multiline = true;
            this.Percentagetext.Name = "Percentagetext";
            this.Percentagetext.Size = new System.Drawing.Size(294, 33);
            this.Percentagetext.TabIndex = 28;
            // 
            // Telephontext
            // 
            this.Telephontext.Location = new System.Drawing.Point(130, 124);
            this.Telephontext.Multiline = true;
            this.Telephontext.Name = "Telephontext";
            this.Telephontext.Size = new System.Drawing.Size(294, 33);
            this.Telephontext.TabIndex = 27;
            // 
            // Fullnametext
            // 
            this.Fullnametext.Location = new System.Drawing.Point(130, 82);
            this.Fullnametext.Multiline = true;
            this.Fullnametext.Name = "Fullnametext";
            this.Fullnametext.Size = new System.Drawing.Size(294, 33);
            this.Fullnametext.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(55, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 47);
            this.button1.TabIndex = 38;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Takeaction);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.Fullname);
            this.Controls.Add(this.Percentagetext);
            this.Controls.Add(this.Telephontext);
            this.Controls.Add(this.Fullnametext);
            this.Controls.Add(this.opisaniesaita);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BuyerForm";
            this.Text = "Осуществление покупки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label opisaniesaita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Takeaction;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.TextBox Percentagetext;
        private System.Windows.Forms.TextBox Telephontext;
        private System.Windows.Forms.TextBox Fullnametext;
        private System.Windows.Forms.Button button1;
    }
}