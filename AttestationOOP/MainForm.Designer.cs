namespace AttestationOOP
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_TotalCalc = new System.Windows.Forms.TextBox();
            this.panel_ForBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Percent = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_Backspace = new System.Windows.Forms.Button();
            this.btn_Splitter = new System.Windows.Forms.Button();
            this.btn_Seven = new System.Windows.Forms.Button();
            this.btn_Eight = new System.Windows.Forms.Button();
            this.btn_Nine = new System.Windows.Forms.Button();
            this.btn_Multi = new System.Windows.Forms.Button();
            this.btn_Four = new System.Windows.Forms.Button();
            this.btn_Five = new System.Windows.Forms.Button();
            this.btn_Six = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_One = new System.Windows.Forms.Button();
            this.btn_Two = new System.Windows.Forms.Button();
            this.btn_Three = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_PlusMinus = new System.Windows.Forms.Button();
            this.btn_Zero = new System.Windows.Forms.Button();
            this.btn_Comma = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_ForBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_TotalCalc
            // 
            this.tb_TotalCalc.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_TotalCalc.Location = new System.Drawing.Point(12, 12);
            this.tb_TotalCalc.Multiline = true;
            this.tb_TotalCalc.Name = "tb_TotalCalc";
            this.tb_TotalCalc.Size = new System.Drawing.Size(348, 65);
            this.tb_TotalCalc.TabIndex = 0;
            this.tb_TotalCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.tb_TotalCalc, "В данном окне будут вводится значения для расчета и итоговый вывод");
            // 
            // panel_ForBtn
            // 
            this.panel_ForBtn.Controls.Add(this.btn_Percent);
            this.panel_ForBtn.Controls.Add(this.btn_CE);
            this.panel_ForBtn.Controls.Add(this.btn_Backspace);
            this.panel_ForBtn.Controls.Add(this.btn_Splitter);
            this.panel_ForBtn.Controls.Add(this.btn_Seven);
            this.panel_ForBtn.Controls.Add(this.btn_Eight);
            this.panel_ForBtn.Controls.Add(this.btn_Nine);
            this.panel_ForBtn.Controls.Add(this.btn_Multi);
            this.panel_ForBtn.Controls.Add(this.btn_Four);
            this.panel_ForBtn.Controls.Add(this.btn_Five);
            this.panel_ForBtn.Controls.Add(this.btn_Six);
            this.panel_ForBtn.Controls.Add(this.btn_Minus);
            this.panel_ForBtn.Controls.Add(this.btn_One);
            this.panel_ForBtn.Controls.Add(this.btn_Two);
            this.panel_ForBtn.Controls.Add(this.btn_Three);
            this.panel_ForBtn.Controls.Add(this.btn_Plus);
            this.panel_ForBtn.Controls.Add(this.btn_PlusMinus);
            this.panel_ForBtn.Controls.Add(this.btn_Zero);
            this.panel_ForBtn.Controls.Add(this.btn_Comma);
            this.panel_ForBtn.Controls.Add(this.btn_Total);
            this.panel_ForBtn.Location = new System.Drawing.Point(12, 103);
            this.panel_ForBtn.Name = "panel_ForBtn";
            this.panel_ForBtn.Size = new System.Drawing.Size(348, 314);
            this.panel_ForBtn.TabIndex = 1;
            this.MyToolTip.SetToolTip(this.panel_ForBtn, "Данная панель содержит кнопки с цифрами и операндами");
            // 
            // btn_Percent
            // 
            this.btn_Percent.Image = ((System.Drawing.Image)(resources.GetObject("btn_Percent.Image")));
            this.btn_Percent.Location = new System.Drawing.Point(3, 3);
            this.btn_Percent.Name = "btn_Percent";
            this.btn_Percent.Size = new System.Drawing.Size(80, 54);
            this.btn_Percent.TabIndex = 0;
            this.MyToolTip.SetToolTip(this.btn_Percent, "Это операнд по выводу остатка от деления");
            this.btn_Percent.UseVisualStyleBackColor = true;
            this.btn_Percent.Click += new System.EventHandler(this.btn_RemainderOfDivision_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Image = ((System.Drawing.Image)(resources.GetObject("btn_CE.Image")));
            this.btn_CE.Location = new System.Drawing.Point(89, 3);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(80, 54);
            this.btn_CE.TabIndex = 1;
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_Backspace
            // 
            this.btn_Backspace.Image = ((System.Drawing.Image)(resources.GetObject("btn_Backspace.Image")));
            this.btn_Backspace.Location = new System.Drawing.Point(175, 3);
            this.btn_Backspace.Name = "btn_Backspace";
            this.btn_Backspace.Size = new System.Drawing.Size(80, 54);
            this.btn_Backspace.TabIndex = 2;
            this.btn_Backspace.UseVisualStyleBackColor = true;
            this.btn_Backspace.Click += new System.EventHandler(this.btn_Backspace_Click);
            // 
            // btn_Splitter
            // 
            this.btn_Splitter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Splitter.Image")));
            this.btn_Splitter.Location = new System.Drawing.Point(261, 3);
            this.btn_Splitter.Name = "btn_Splitter";
            this.btn_Splitter.Size = new System.Drawing.Size(80, 54);
            this.btn_Splitter.TabIndex = 3;
            this.btn_Splitter.UseVisualStyleBackColor = true;
            this.btn_Splitter.Click += new System.EventHandler(this.btn_Splitter_Click);
            // 
            // btn_Seven
            // 
            this.btn_Seven.Image = ((System.Drawing.Image)(resources.GetObject("btn_Seven.Image")));
            this.btn_Seven.Location = new System.Drawing.Point(3, 63);
            this.btn_Seven.Name = "btn_Seven";
            this.btn_Seven.Size = new System.Drawing.Size(80, 54);
            this.btn_Seven.TabIndex = 15;
            this.btn_Seven.UseVisualStyleBackColor = true;
            this.btn_Seven.Click += new System.EventHandler(this.btn_Seven_Click);
            // 
            // btn_Eight
            // 
            this.btn_Eight.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eight.Image")));
            this.btn_Eight.Location = new System.Drawing.Point(89, 63);
            this.btn_Eight.Name = "btn_Eight";
            this.btn_Eight.Size = new System.Drawing.Size(80, 54);
            this.btn_Eight.TabIndex = 16;
            this.btn_Eight.UseVisualStyleBackColor = true;
            this.btn_Eight.Click += new System.EventHandler(this.btn_Eight_Click);
            // 
            // btn_Nine
            // 
            this.btn_Nine.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nine.Image")));
            this.btn_Nine.Location = new System.Drawing.Point(175, 63);
            this.btn_Nine.Name = "btn_Nine";
            this.btn_Nine.Size = new System.Drawing.Size(80, 54);
            this.btn_Nine.TabIndex = 17;
            this.btn_Nine.UseVisualStyleBackColor = true;
            this.btn_Nine.Click += new System.EventHandler(this.btn_Nine_Click);
            // 
            // btn_Multi
            // 
            this.btn_Multi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Multi.Image")));
            this.btn_Multi.Location = new System.Drawing.Point(261, 63);
            this.btn_Multi.Name = "btn_Multi";
            this.btn_Multi.Size = new System.Drawing.Size(80, 54);
            this.btn_Multi.TabIndex = 4;
            this.btn_Multi.UseVisualStyleBackColor = true;
            this.btn_Multi.Click += new System.EventHandler(this.btn_Multi_Click);
            // 
            // btn_Four
            // 
            this.btn_Four.Image = ((System.Drawing.Image)(resources.GetObject("btn_Four.Image")));
            this.btn_Four.Location = new System.Drawing.Point(3, 123);
            this.btn_Four.Name = "btn_Four";
            this.btn_Four.Size = new System.Drawing.Size(80, 54);
            this.btn_Four.TabIndex = 12;
            this.btn_Four.UseVisualStyleBackColor = true;
            this.btn_Four.Click += new System.EventHandler(this.btn_Four_Click);
            // 
            // btn_Five
            // 
            this.btn_Five.Image = ((System.Drawing.Image)(resources.GetObject("btn_Five.Image")));
            this.btn_Five.Location = new System.Drawing.Point(89, 123);
            this.btn_Five.Name = "btn_Five";
            this.btn_Five.Size = new System.Drawing.Size(80, 54);
            this.btn_Five.TabIndex = 13;
            this.btn_Five.UseVisualStyleBackColor = true;
            this.btn_Five.Click += new System.EventHandler(this.btn_Five_Click);
            // 
            // btn_Six
            // 
            this.btn_Six.Image = ((System.Drawing.Image)(resources.GetObject("btn_Six.Image")));
            this.btn_Six.Location = new System.Drawing.Point(175, 123);
            this.btn_Six.Name = "btn_Six";
            this.btn_Six.Size = new System.Drawing.Size(80, 54);
            this.btn_Six.TabIndex = 14;
            this.btn_Six.UseVisualStyleBackColor = true;
            this.btn_Six.Click += new System.EventHandler(this.btn_Six_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minus.Image")));
            this.btn_Minus.Location = new System.Drawing.Point(261, 123);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(80, 54);
            this.btn_Minus.TabIndex = 5;
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_One
            // 
            this.btn_One.Image = ((System.Drawing.Image)(resources.GetObject("btn_One.Image")));
            this.btn_One.Location = new System.Drawing.Point(3, 183);
            this.btn_One.Name = "btn_One";
            this.btn_One.Size = new System.Drawing.Size(80, 54);
            this.btn_One.TabIndex = 9;
            this.btn_One.UseVisualStyleBackColor = true;
            this.btn_One.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Two
            // 
            this.btn_Two.Image = ((System.Drawing.Image)(resources.GetObject("btn_Two.Image")));
            this.btn_Two.Location = new System.Drawing.Point(89, 183);
            this.btn_Two.Name = "btn_Two";
            this.btn_Two.Size = new System.Drawing.Size(80, 54);
            this.btn_Two.TabIndex = 10;
            this.btn_Two.UseVisualStyleBackColor = true;
            this.btn_Two.Click += new System.EventHandler(this.btn_Two_Click);
            // 
            // btn_Three
            // 
            this.btn_Three.Image = ((System.Drawing.Image)(resources.GetObject("btn_Three.Image")));
            this.btn_Three.Location = new System.Drawing.Point(175, 183);
            this.btn_Three.Name = "btn_Three";
            this.btn_Three.Size = new System.Drawing.Size(80, 54);
            this.btn_Three.TabIndex = 11;
            this.btn_Three.UseVisualStyleBackColor = true;
            this.btn_Three.Click += new System.EventHandler(this.btn_Three_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Image = ((System.Drawing.Image)(resources.GetObject("btn_Plus.Image")));
            this.btn_Plus.Location = new System.Drawing.Point(261, 183);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(80, 54);
            this.btn_Plus.TabIndex = 6;
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_PlusMinus
            // 
            this.btn_PlusMinus.Image = ((System.Drawing.Image)(resources.GetObject("btn_PlusMinus.Image")));
            this.btn_PlusMinus.Location = new System.Drawing.Point(3, 243);
            this.btn_PlusMinus.Name = "btn_PlusMinus";
            this.btn_PlusMinus.Size = new System.Drawing.Size(80, 54);
            this.btn_PlusMinus.TabIndex = 19;
            this.btn_PlusMinus.UseVisualStyleBackColor = true;
            this.btn_PlusMinus.Click += new System.EventHandler(this.btn_PlusMinus_Click);
            // 
            // btn_Zero
            // 
            this.btn_Zero.Image = ((System.Drawing.Image)(resources.GetObject("btn_Zero.Image")));
            this.btn_Zero.Location = new System.Drawing.Point(89, 243);
            this.btn_Zero.Name = "btn_Zero";
            this.btn_Zero.Size = new System.Drawing.Size(80, 54);
            this.btn_Zero.TabIndex = 8;
            this.btn_Zero.UseVisualStyleBackColor = true;
            this.btn_Zero.Click += new System.EventHandler(this.btn_Zero_Click_1);
            // 
            // btn_Comma
            // 
            this.btn_Comma.Image = ((System.Drawing.Image)(resources.GetObject("btn_Comma.Image")));
            this.btn_Comma.Location = new System.Drawing.Point(175, 243);
            this.btn_Comma.Name = "btn_Comma";
            this.btn_Comma.Size = new System.Drawing.Size(80, 54);
            this.btn_Comma.TabIndex = 18;
            this.btn_Comma.UseVisualStyleBackColor = true;
            this.btn_Comma.Click += new System.EventHandler(this.btn_Comma_Click);
            // 
            // btn_Total
            // 
            this.btn_Total.Image = ((System.Drawing.Image)(resources.GetObject("btn_Total.Image")));
            this.btn_Total.Location = new System.Drawing.Point(261, 243);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(80, 54);
            this.btn_Total.TabIndex = 7;
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.btn_Total_Click);
            // 
            // MyToolTip
            // 
            this.MyToolTip.ToolTipTitle = "Подсказка для ячейки/окна";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 429);
            this.Controls.Add(this.panel_ForBtn);
            this.Controls.Add(this.tb_TotalCalc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.panel_ForBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panel_ForBtn;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Button btn_Percent;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_Backspace;
        private System.Windows.Forms.Button btn_Splitter;
        private System.Windows.Forms.Button btn_Seven;
        private System.Windows.Forms.Button btn_Eight;
        private System.Windows.Forms.Button btn_Nine;
        private System.Windows.Forms.Button btn_Multi;
        private System.Windows.Forms.Button btn_Four;
        private System.Windows.Forms.Button btn_Five;
        private System.Windows.Forms.Button btn_Six;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_One;
        private System.Windows.Forms.Button btn_Two;
        private System.Windows.Forms.Button btn_Three;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_PlusMinus;
        private System.Windows.Forms.Button btn_Zero;
        private System.Windows.Forms.Button btn_Comma;
        private System.Windows.Forms.Button btn_Total;
        public System.Windows.Forms.TextBox tb_TotalCalc;
    }
}

