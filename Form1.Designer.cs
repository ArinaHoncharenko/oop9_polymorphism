namespace oop9_products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.listBoxShoppingCart = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalculateTotal = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.listBoxStoreProducts = new System.Windows.Forms.ListBox();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCharacteristics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть товар:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість, шт:";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(139, 86);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownQuantity.TabIndex = 2;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToCart.Location = new System.Drawing.Point(24, 166);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(198, 30);
            this.buttonAddToCart.TabIndex = 4;
            this.buttonAddToCart.Text = "Додати в кошик";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // listBoxShoppingCart
            // 
            this.listBoxShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxShoppingCart.FormattingEnabled = true;
            this.listBoxShoppingCart.ItemHeight = 20;
            this.listBoxShoppingCart.Location = new System.Drawing.Point(16, 232);
            this.listBoxShoppingCart.Name = "listBoxShoppingCart";
            this.listBoxShoppingCart.Size = new System.Drawing.Size(260, 144);
            this.listBoxShoppingCart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кошик:";
            // 
            // buttonCalculateTotal
            // 
            this.buttonCalculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateTotal.Location = new System.Drawing.Point(280, 86);
            this.buttonCalculateTotal.Name = "buttonCalculateTotal";
            this.buttonCalculateTotal.Size = new System.Drawing.Size(198, 33);
            this.buttonCalculateTotal.TabIndex = 7;
            this.buttonCalculateTotal.Text = "Готово";
            this.buttonCalculateTotal.UseVisualStyleBackColor = true;
            this.buttonCalculateTotal.Click += new System.EventHandler(this.buttonCalculateTotal_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(277, 130);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 20);
            this.labelTotal.TabIndex = 8;
            // 
            // listBoxStoreProducts
            // 
            this.listBoxStoreProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStoreProducts.FormattingEnabled = true;
            this.listBoxStoreProducts.ItemHeight = 20;
            this.listBoxStoreProducts.Location = new System.Drawing.Point(287, 232);
            this.listBoxStoreProducts.Name = "listBoxStoreProducts";
            this.listBoxStoreProducts.Size = new System.Drawing.Size(260, 144);
            this.listBoxStoreProducts.TabIndex = 9;
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(139, 42);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(121, 28);
            this.comboBoxProductName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Для формування замовлення введіть дані:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(283, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "В наявності:";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeight.Location = new System.Drawing.Point(139, 127);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(121, 26);
            this.textBoxWeight.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Вага, г:";
            // 
            // labelCharacteristics
            // 
            this.labelCharacteristics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCharacteristics.Location = new System.Drawing.Point(276, 39);
            this.labelCharacteristics.Name = "labelCharacteristics";
            this.labelCharacteristics.Size = new System.Drawing.Size(271, 41);
            this.labelCharacteristics.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 395);
            this.Controls.Add(this.labelCharacteristics);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.listBoxStoreProducts);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonCalculateTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxShoppingCart);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.ListBox listBoxShoppingCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculateTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ListBox listBoxStoreProducts;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCharacteristics;
    }
}

