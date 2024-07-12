namespace Users_Interface
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
            this.buttonCreateCardCatalogue = new System.Windows.Forms.Button();
            this.dataGridViewApartments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExchangeApplication = new System.Windows.Forms.Button();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonShowListOFApplications = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApartments)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateCardCatalogue
            // 
            this.buttonCreateCardCatalogue.Location = new System.Drawing.Point(13, 13);
            this.buttonCreateCardCatalogue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateCardCatalogue.Name = "buttonCreateCardCatalogue";
            this.buttonCreateCardCatalogue.Size = new System.Drawing.Size(153, 56);
            this.buttonCreateCardCatalogue.TabIndex = 0;
            this.buttonCreateCardCatalogue.Text = "Сформировать картотеку";
            this.buttonCreateCardCatalogue.UseVisualStyleBackColor = true;
            this.buttonCreateCardCatalogue.Click += new System.EventHandler(this.buttonCreateCardCatalogue_Click);
            // 
            // dataGridViewApartments
            // 
            this.dataGridViewApartments.AllowUserToAddRows = false;
            this.dataGridViewApartments.AllowUserToDeleteRows = false;
            this.dataGridViewApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApartments.Location = new System.Drawing.Point(13, 88);
            this.dataGridViewApartments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewApartments.Name = "dataGridViewApartments";
            this.dataGridViewApartments.ReadOnly = true;
            this.dataGridViewApartments.Size = new System.Drawing.Size(678, 219);
            this.dataGridViewApartments.TabIndex = 1;
            this.dataGridViewApartments.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Картотека";
            this.label1.Visible = false;
            // 
            // buttonExchangeApplication
            // 
            this.buttonExchangeApplication.Location = new System.Drawing.Point(33, 24);
            this.buttonExchangeApplication.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExchangeApplication.Name = "buttonExchangeApplication";
            this.buttonExchangeApplication.Size = new System.Drawing.Size(153, 56);
            this.buttonExchangeApplication.TabIndex = 3;
            this.buttonExchangeApplication.Text = "Отправить заявку на обмен";
            this.buttonExchangeApplication.UseVisualStyleBackColor = true;
            this.buttonExchangeApplication.Click += new System.EventHandler(this.buttonExchangeApplication_Click);
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Location = new System.Drawing.Point(184, 99);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(153, 24);
            this.textBoxRooms.TabIndex = 4;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(184, 140);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(153, 24);
            this.textBoxArea.TabIndex = 5;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(184, 181);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(153, 24);
            this.textBoxFloor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество комнат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Площадь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Этаж";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Заполните\r\nполя снизу!\r\n";
            this.label5.Visible = false;
            // 
            // buttonShowListOFApplications
            // 
            this.buttonShowListOFApplications.Location = new System.Drawing.Point(13, 340);
            this.buttonShowListOFApplications.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowListOFApplications.Name = "buttonShowListOFApplications";
            this.buttonShowListOFApplications.Size = new System.Drawing.Size(153, 56);
            this.buttonShowListOFApplications.TabIndex = 11;
            this.buttonShowListOFApplications.Text = "Вывести список заявок";
            this.buttonShowListOFApplications.UseVisualStyleBackColor = true;
            this.buttonShowListOFApplications.Click += new System.EventHandler(this.buttonShowListOFApplications_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExchangeApplication);
            this.groupBox1.Controls.Add(this.textBoxRooms);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxArea);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxFloor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(790, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 224);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заявка";
            // 
            // dataGridViewApplications
            // 
            this.dataGridViewApplications.AllowUserToAddRows = false;
            this.dataGridViewApplications.AllowUserToDeleteRows = false;
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.Location = new System.Drawing.Point(13, 451);
            this.dataGridViewApplications.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.ReadOnly = true;
            this.dataGridViewApplications.Size = new System.Drawing.Size(678, 219);
            this.dataGridViewApplications.TabIndex = 13;
            this.dataGridViewApplications.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Список заявок";
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 831);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewApplications);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonShowListOFApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewApartments);
            this.Controls.Add(this.buttonCreateCardCatalogue);
            this.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бюро обмена";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApartments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCardCatalogue;
        private System.Windows.Forms.DataGridView dataGridViewApartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExchangeApplication;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonShowListOFApplications;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewApplications;
        private System.Windows.Forms.Label label6;
    }
}

