namespace calc
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
            this.clear = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chislo1 = new System.Windows.Forms.TextBox();
            this.chislo2 = new System.Windows.Forms.TextBox();
            this.resultat = new System.Windows.Forms.TextBox();
            this.Chislo1label = new System.Windows.Forms.Label();
            this.DeistvieLabel = new System.Windows.Forms.Label();
            this.Chislo2Label = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Prisvoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(438, 348);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(160, 60);
            this.clear.TabIndex = 0;
            this.clear.Text = "Изчисти";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(438, 273);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(160, 69);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Изчисли";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Събиране",
            "Изваждане",
            "Умножение",
            "Деление",
            "Корен Квадратен",
            "Реципрочно",
            " "});
            this.comboBox1.Location = new System.Drawing.Point(322, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // chislo1
            // 
            this.chislo1.Location = new System.Drawing.Point(13, 108);
            this.chislo1.Name = "chislo1";
            this.chislo1.Size = new System.Drawing.Size(276, 20);
            this.chislo1.TabIndex = 4;
            this.chislo1.Text = "0";
            // 
            // chislo2
            // 
            this.chislo2.Location = new System.Drawing.Point(13, 189);
            this.chislo2.Name = "chislo2";
            this.chislo2.Size = new System.Drawing.Size(276, 20);
            this.chislo2.TabIndex = 5;
            this.chislo2.Text = "0";
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(13, 334);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(276, 20);
            this.resultat.TabIndex = 6;
            // 
            // Chislo1label
            // 
            this.Chislo1label.AutoSize = true;
            this.Chislo1label.Location = new System.Drawing.Point(13, 71);
            this.Chislo1label.Name = "Chislo1label";
            this.Chislo1label.Size = new System.Drawing.Size(137, 13);
            this.Chislo1label.TabIndex = 7;
            this.Chislo1label.Text = "Първо число за действие";
            // 
            // DeistvieLabel
            // 
            this.DeistvieLabel.AutoSize = true;
            this.DeistvieLabel.Location = new System.Drawing.Point(322, 108);
            this.DeistvieLabel.Name = "DeistvieLabel";
            this.DeistvieLabel.Size = new System.Drawing.Size(57, 13);
            this.DeistvieLabel.TabIndex = 8;
            this.DeistvieLabel.Text = "Действие";
            // 
            // Chislo2Label
            // 
            this.Chislo2Label.AutoSize = true;
            this.Chislo2Label.Location = new System.Drawing.Point(16, 156);
            this.Chislo2Label.Name = "Chislo2Label";
            this.Chislo2Label.Size = new System.Drawing.Size(134, 13);
            this.Chislo2Label.TabIndex = 9;
            this.Chislo2Label.Text = "Второ число за действие";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(16, 315);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(53, 13);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Резултат";
            // 
            // Prisvoi
            // 
            this.Prisvoi.Location = new System.Drawing.Point(13, 259);
            this.Prisvoi.Name = "Prisvoi";
            this.Prisvoi.Size = new System.Drawing.Size(276, 33);
            this.Prisvoi.TabIndex = 11;
            this.Prisvoi.Text = "Присвои";
            this.Prisvoi.UseVisualStyleBackColor = false;
            this.Prisvoi.Click += new System.EventHandler(this.Prisvoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 408);
            this.Controls.Add(this.Prisvoi);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Chislo2Label);
            this.Controls.Add(this.DeistvieLabel);
            this.Controls.Add(this.Chislo1label);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.chislo2);
            this.Controls.Add(this.chislo1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.clear);
            this.Name = "Form1";
            this.Text = "Калкулатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox chislo1;
        private System.Windows.Forms.TextBox chislo2;
        private System.Windows.Forms.TextBox resultat;
        private System.Windows.Forms.Label Chislo1label;
        private System.Windows.Forms.Label DeistvieLabel;
        private System.Windows.Forms.Label Chislo2Label;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button Prisvoi;
    }
}

