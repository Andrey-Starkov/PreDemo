
namespace PreDemo
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
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.phonetxtbox = new System.Windows.Forms.TextBox();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.Fiotxtbox = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pages = new System.Windows.Forms.Label();
            this.pagecount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Location = new System.Drawing.Point(12, 12);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.Size = new System.Drawing.Size(1313, 426);
            this.ClientsGrid.TabIndex = 0;
            this.ClientsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsGrid_CellClick);
            // 
            // phonetxtbox
            // 
            this.phonetxtbox.Location = new System.Drawing.Point(552, 545);
            this.phonetxtbox.Name = "phonetxtbox";
            this.phonetxtbox.Size = new System.Drawing.Size(100, 20);
            this.phonetxtbox.TabIndex = 14;
            this.phonetxtbox.TextChanged += new System.EventHandler(this.phonetxtbox_TextChanged);
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(551, 519);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(100, 20);
            this.emailtxtbox.TabIndex = 13;
            this.emailtxtbox.TextChanged += new System.EventHandler(this.emailtxtbox_TextChanged);
            // 
            // Fiotxtbox
            // 
            this.Fiotxtbox.Location = new System.Drawing.Point(551, 494);
            this.Fiotxtbox.Name = "Fiotxtbox";
            this.Fiotxtbox.Size = new System.Drawing.Size(100, 20);
            this.Fiotxtbox.TabIndex = 12;
            this.Fiotxtbox.TextChanged += new System.EventHandler(this.Fiotxtbox_TextChanged);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Phone.Location = new System.Drawing.Point(468, 548);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(78, 21);
            this.Phone.TabIndex = 11;
            this.Phone.Text = "Телефон";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.email.Location = new System.Drawing.Point(468, 519);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 21);
            this.email.TabIndex = 10;
            this.email.Text = "email";
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.FIO.Location = new System.Drawing.Point(468, 494);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(51, 21);
            this.FIO.TabIndex = 9;
            this.FIO.Text = "ФИО";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(459, 462);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(90, 21);
            this.Search.TabIndex = 8;
            this.Search.Text = "Поиск по:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Sex.Location = new System.Drawing.Point(814, 462);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(46, 21);
            this.Sex.TabIndex = 15;
            this.Sex.Text = "Пол:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "F",
            "Все"});
            this.comboBox1.Location = new System.Drawing.Point(818, 493);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(1027, 494);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(31, 33);
            this.left.TabIndex = 17;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click_1);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(1095, 494);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(31, 33);
            this.right.TabIndex = 18;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1049, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Страницы";
            // 
            // pages
            // 
            this.pages.AutoSize = true;
            this.pages.Location = new System.Drawing.Point(1075, 504);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(0, 13);
            this.pages.TabIndex = 20;
            // 
            // pagecount
            // 
            this.pagecount.FormattingEnabled = true;
            this.pagecount.Items.AddRange(new object[] {
            "10",
            "50",
            "200",
            "Все"});
            this.pagecount.Location = new System.Drawing.Point(1150, 493);
            this.pagecount.Name = "pagecount";
            this.pagecount.Size = new System.Drawing.Size(86, 21);
            this.pagecount.TabIndex = 21;
            this.pagecount.SelectedIndexChanged += new System.EventHandler(this.pagecount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1150, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Кол-во на странице";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить Клиента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pagecount);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.phonetxtbox);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.Fiotxtbox);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ClientsGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.TextBox phonetxtbox;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.TextBox Fiotxtbox;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pages;
        private System.Windows.Forms.ComboBox pagecount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

