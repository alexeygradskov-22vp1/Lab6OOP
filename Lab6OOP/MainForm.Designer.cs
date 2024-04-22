namespace Lab6OOP
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
            this.resultFuncTB = new System.Windows.Forms.TextBox();
            this.CalcFuncBtn = new System.Windows.Forms.Button();
            this.sysTime = new System.Windows.Forms.TextBox();
            this.getSysTimeBtn = new System.Windows.Forms.Button();
            this.ChatArea = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sysTimeLabel = new System.Windows.Forms.Label();
            this.avgVectorLabel = new System.Windows.Forms.Label();
            this.inputVectorTB = new System.Windows.Forms.TextBox();
            this.inputVectorNumbersBtn = new System.Windows.Forms.Button();
            this.inputVectorLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultFuncTB
            // 
            this.resultFuncTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultFuncTB.Location = new System.Drawing.Point(12, 100);
            this.resultFuncTB.Name = "resultFuncTB";
            this.resultFuncTB.Size = new System.Drawing.Size(186, 22);
            this.resultFuncTB.TabIndex = 0;
            // 
            // CalcFuncBtn
            // 
            this.CalcFuncBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcFuncBtn.Location = new System.Drawing.Point(39, 185);
            this.CalcFuncBtn.Name = "CalcFuncBtn";
            this.CalcFuncBtn.Size = new System.Drawing.Size(122, 37);
            this.CalcFuncBtn.TabIndex = 1;
            this.CalcFuncBtn.Text = "Выч. функцию";
            this.CalcFuncBtn.UseVisualStyleBackColor = true;
            this.CalcFuncBtn.Click += new System.EventHandler(this.calculateAvgVector_Click);
            // 
            // sysTime
            // 
            this.sysTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sysTime.Location = new System.Drawing.Point(12, 37);
            this.sysTime.Name = "sysTime";
            this.sysTime.Size = new System.Drawing.Size(186, 22);
            this.sysTime.TabIndex = 2;
            // 
            // getSysTimeBtn
            // 
            this.getSysTimeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getSysTimeBtn.Location = new System.Drawing.Point(39, 142);
            this.getSysTimeBtn.Name = "getSysTimeBtn";
            this.getSysTimeBtn.Size = new System.Drawing.Size(122, 37);
            this.getSysTimeBtn.TabIndex = 3;
            this.getSysTimeBtn.Text = "Время";
            this.getSysTimeBtn.UseVisualStyleBackColor = true;
            this.getSysTimeBtn.Click += new System.EventHandler(this.getSysTime_Click);
            // 
            // ChatArea
            // 
            this.ChatArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatArea.Location = new System.Drawing.Point(535, 12);
            this.ChatArea.MinimumSize = new System.Drawing.Size(4, 200);
            this.ChatArea.Multiline = true;
            this.ChatArea.Name = "ChatArea";
            this.ChatArea.Size = new System.Drawing.Size(193, 200);
            this.ChatArea.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(571, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Зап. чат";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.startChat_Click);
            // 
            // sysTimeLabel
            // 
            this.sysTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sysTimeLabel.AutoSize = true;
            this.sysTimeLabel.Location = new System.Drawing.Point(12, 18);
            this.sysTimeLabel.Name = "sysTimeLabel";
            this.sysTimeLabel.Size = new System.Drawing.Size(125, 16);
            this.sysTimeLabel.TabIndex = 6;
            this.sysTimeLabel.Text = "Системное время:";
            // 
            // avgVectorLabel
            // 
            this.avgVectorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.avgVectorLabel.AutoSize = true;
            this.avgVectorLabel.Location = new System.Drawing.Point(7, 81);
            this.avgVectorLabel.Name = "avgVectorLabel";
            this.avgVectorLabel.Size = new System.Drawing.Size(191, 16);
            this.avgVectorLabel.TabIndex = 7;
            this.avgVectorLabel.Text = "Среднее значение вектора:";
            // 
            // inputVectorTB
            // 
            this.inputVectorTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputVectorTB.Location = new System.Drawing.Point(10, 356);
            this.inputVectorTB.Name = "inputVectorTB";
            this.inputVectorTB.Size = new System.Drawing.Size(188, 22);
            this.inputVectorTB.TabIndex = 8;
            this.inputVectorTB.TextChanged += new System.EventHandler(this.inputVectorTB_TextChanged);
            // 
            // inputVectorNumbersBtn
            // 
            this.inputVectorNumbersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputVectorNumbersBtn.Location = new System.Drawing.Point(10, 396);
            this.inputVectorNumbersBtn.Name = "inputVectorNumbersBtn";
            this.inputVectorNumbersBtn.Size = new System.Drawing.Size(143, 42);
            this.inputVectorNumbersBtn.TabIndex = 9;
            this.inputVectorNumbersBtn.Text = "Сохранить";
            this.inputVectorNumbersBtn.UseVisualStyleBackColor = true;
            this.inputVectorNumbersBtn.Click += new System.EventHandler(this.inputVectorNumbersBtn_Click);
            // 
            // inputVectorLabel
            // 
            this.inputVectorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputVectorLabel.AutoSize = true;
            this.inputVectorLabel.Location = new System.Drawing.Point(9, 321);
            this.inputVectorLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.inputVectorLabel.Name = "inputVectorLabel";
            this.inputVectorLabel.Size = new System.Drawing.Size(163, 32);
            this.inputVectorLabel.TabIndex = 10;
            this.inputVectorLabel.Text = "Введите 10 значений вектора через запятую";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(160, 408);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.inputVectorLabel);
            this.Controls.Add(this.inputVectorNumbersBtn);
            this.Controls.Add(this.inputVectorTB);
            this.Controls.Add(this.avgVectorLabel);
            this.Controls.Add(this.sysTimeLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ChatArea);
            this.Controls.Add(this.getSysTimeBtn);
            this.Controls.Add(this.sysTime);
            this.Controls.Add(this.CalcFuncBtn);
            this.Controls.Add(this.resultFuncTB);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultFuncTB;
        private System.Windows.Forms.Button CalcFuncBtn;
        private System.Windows.Forms.TextBox sysTime;
        private System.Windows.Forms.Button getSysTimeBtn;
        private System.Windows.Forms.TextBox ChatArea;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label sysTimeLabel;
        private System.Windows.Forms.Label avgVectorLabel;
        private System.Windows.Forms.TextBox inputVectorTB;
        private System.Windows.Forms.Button inputVectorNumbersBtn;
        private System.Windows.Forms.Label inputVectorLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

