namespace Ramos_Lab2
{
    partial class Form1
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
            this.HotDog = new System.Windows.Forms.Label();
            this.Howard_Title = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Label();
            this.Soda = new System.Windows.Forms.Label();
            this.Chips = new System.Windows.Forms.Label();
            this.HotDogUpDown = new System.Windows.Forms.NumericUpDown();
            this.SodaUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChipsUpDown = new System.Windows.Forms.NumericUpDown();
            this.Quantity = new System.Windows.Forms.Label();
            this.GetSum = new System.Windows.Forms.Button();
            this.Tip = new System.Windows.Forms.Label();
            this.Sales_Tax = new System.Windows.Forms.Label();
            this.TotalDue = new System.Windows.Forms.Label();
            this.TaxTotal = new System.Windows.Forms.TextBox();
            this.TipTotal = new System.Windows.Forms.TextBox();
            this.BalanceTotal = new System.Windows.Forms.TextBox();
            this.NewOrder = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HotDogUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SodaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChipsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HotDog
            // 
            this.HotDog.AutoSize = true;
            this.HotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDog.Location = new System.Drawing.Point(104, 160);
            this.HotDog.MinimumSize = new System.Drawing.Size(50, 50);
            this.HotDog.Name = "HotDog";
            this.HotDog.Size = new System.Drawing.Size(231, 50);
            this.HotDog.TabIndex = 0;
            this.HotDog.Text = "Hot Dogs: $2.00";
            this.HotDog.Click += new System.EventHandler(this.label1_Click);
            // 
            // Howard_Title
            // 
            this.Howard_Title.AutoSize = true;
            this.Howard_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Howard_Title.Location = new System.Drawing.Point(49, 9);
            this.Howard_Title.Name = "Howard_Title";
            this.Howard_Title.Size = new System.Drawing.Size(682, 69);
            this.Howard_Title.TabIndex = 1;
            this.Howard_Title.Text = "Howard\'s Hot Dog Stand";
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(150, 104);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(98, 38);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // Soda
            // 
            this.Soda.AutoSize = true;
            this.Soda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soda.Location = new System.Drawing.Point(104, 210);
            this.Soda.Name = "Soda";
            this.Soda.Size = new System.Drawing.Size(177, 36);
            this.Soda.TabIndex = 3;
            this.Soda.Text = "Soda: $1.50";
            // 
            // Chips
            // 
            this.Chips.AutoSize = true;
            this.Chips.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chips.Location = new System.Drawing.Point(104, 258);
            this.Chips.Name = "Chips";
            this.Chips.Size = new System.Drawing.Size(184, 36);
            this.Chips.TabIndex = 4;
            this.Chips.Text = "Chips: $1.00";
            // 
            // HotDogUpDown
            // 
            this.HotDogUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDogUpDown.Location = new System.Drawing.Point(340, 160);
            this.HotDogUpDown.Name = "HotDogUpDown";
            this.HotDogUpDown.Size = new System.Drawing.Size(120, 34);
            this.HotDogUpDown.TabIndex = 5;
            this.HotDogUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // SodaUpDown
            // 
            this.SodaUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SodaUpDown.Location = new System.Drawing.Point(340, 210);
            this.SodaUpDown.Name = "SodaUpDown";
            this.SodaUpDown.Size = new System.Drawing.Size(120, 34);
            this.SodaUpDown.TabIndex = 6;
            // 
            // ChipsUpDown
            // 
            this.ChipsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsUpDown.Location = new System.Drawing.Point(340, 258);
            this.ChipsUpDown.Name = "ChipsUpDown";
            this.ChipsUpDown.Size = new System.Drawing.Size(120, 34);
            this.ChipsUpDown.TabIndex = 7;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(333, 104);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(139, 38);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity";
            // 
            // GetSum
            // 
            this.GetSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetSum.Location = new System.Drawing.Point(488, 160);
            this.GetSum.Name = "GetSum";
            this.GetSum.Size = new System.Drawing.Size(122, 51);
            this.GetSum.TabIndex = 9;
            this.GetSum.Text = "Get Total";
            this.GetSum.UseVisualStyleBackColor = true;
            this.GetSum.Click += new System.EventHandler(this.GetSum_Click);
            // 
            // Tip
            // 
            this.Tip.AutoSize = true;
            this.Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip.Location = new System.Drawing.Point(258, 366);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(70, 20);
            this.Tip.TabIndex = 11;
            this.Tip.Text = "18% tip:";
            // 
            // Sales_Tax
            // 
            this.Sales_Tax.AutoSize = true;
            this.Sales_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_Tax.Location = new System.Drawing.Point(235, 334);
            this.Sales_Tax.Name = "Sales_Tax";
            this.Sales_Tax.Size = new System.Drawing.Size(93, 20);
            this.Sales_Tax.TabIndex = 12;
            this.Sales_Tax.Text = "Sales Tax: ";
            // 
            // TotalDue
            // 
            this.TotalDue.AutoSize = true;
            this.TotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDue.Location = new System.Drawing.Point(211, 395);
            this.TotalDue.Name = "TotalDue";
            this.TotalDue.Size = new System.Drawing.Size(117, 20);
            this.TotalDue.TabIndex = 13;
            this.TotalDue.Text = "Total Balance:";
            // 
            // TaxTotal
            // 
            this.TaxTotal.Location = new System.Drawing.Point(340, 332);
            this.TaxTotal.Name = "TaxTotal";
            this.TaxTotal.Size = new System.Drawing.Size(100, 22);
            this.TaxTotal.TabIndex = 16;
            // 
            // TipTotal
            // 
            this.TipTotal.Location = new System.Drawing.Point(340, 360);
            this.TipTotal.Name = "TipTotal";
            this.TipTotal.Size = new System.Drawing.Size(100, 22);
            this.TipTotal.TabIndex = 17;
            // 
            // BalanceTotal
            // 
            this.BalanceTotal.Location = new System.Drawing.Point(340, 393);
            this.BalanceTotal.Name = "BalanceTotal";
            this.BalanceTotal.Size = new System.Drawing.Size(100, 22);
            this.BalanceTotal.TabIndex = 18;
            // 
            // NewOrder
            // 
            this.NewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrder.Location = new System.Drawing.Point(489, 243);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(121, 51);
            this.NewOrder.TabIndex = 20;
            this.NewOrder.Text = "New Order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(352, 421);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(79, 27);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.BalanceTotal);
            this.Controls.Add(this.TipTotal);
            this.Controls.Add(this.TaxTotal);
            this.Controls.Add(this.TotalDue);
            this.Controls.Add(this.Sales_Tax);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.GetSum);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ChipsUpDown);
            this.Controls.Add(this.SodaUpDown);
            this.Controls.Add(this.HotDogUpDown);
            this.Controls.Add(this.Chips);
            this.Controls.Add(this.Soda);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Howard_Title);
            this.Controls.Add(this.HotDog);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HotDogUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SodaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChipsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HotDog;
        private System.Windows.Forms.Label Howard_Title;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label Soda;
        private System.Windows.Forms.Label Chips;
        private System.Windows.Forms.NumericUpDown HotDogUpDown;
        private System.Windows.Forms.NumericUpDown SodaUpDown;
        private System.Windows.Forms.NumericUpDown ChipsUpDown;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Button GetSum;
        private System.Windows.Forms.Label Tip;
        private System.Windows.Forms.Label Sales_Tax;
        private System.Windows.Forms.Label TotalDue;
        private System.Windows.Forms.TextBox TaxTotal;
        private System.Windows.Forms.TextBox TipTotal;
        private System.Windows.Forms.TextBox BalanceTotal;
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button Exit;
    }
}

