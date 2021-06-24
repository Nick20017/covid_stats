namespace covidStats
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.casesLabel = new System.Windows.Forms.Label();
            this.deathsLabel = new System.Windows.Forms.Label();
            this.recoveredLabel = new System.Windows.Forms.Label();
            this.allStats = new System.Windows.Forms.Label();
            this.newStats = new System.Windows.Forms.Label();
            this.casesResult = new System.Windows.Forms.Label();
            this.newCasesResult = new System.Windows.Forms.Label();
            this.deathsResult = new System.Windows.Forms.Label();
            this.newDeathsResult = new System.Windows.Forms.Label();
            this.recoveredResult = new System.Windows.Forms.Label();
            this.newRecoveredResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.Lime;
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.Beige;
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.Location = new System.Drawing.Point(68, 44);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker.Size = new System.Drawing.Size(247, 20);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2021, 1, 8, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статистика COVID-19 в Украине";
            // 
            // casesLabel
            // 
            this.casesLabel.AutoSize = true;
            this.casesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.casesLabel.Location = new System.Drawing.Point(12, 111);
            this.casesLabel.Name = "casesLabel";
            this.casesLabel.Size = new System.Drawing.Size(60, 17);
            this.casesLabel.TabIndex = 3;
            this.casesLabel.Text = "Случаи:";
            // 
            // deathsLabel
            // 
            this.deathsLabel.AutoSize = true;
            this.deathsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deathsLabel.Location = new System.Drawing.Point(12, 128);
            this.deathsLabel.Name = "deathsLabel";
            this.deathsLabel.Size = new System.Drawing.Size(69, 17);
            this.deathsLabel.TabIndex = 6;
            this.deathsLabel.Text = "Смертей:";
            // 
            // recoveredLabel
            // 
            this.recoveredLabel.AutoSize = true;
            this.recoveredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recoveredLabel.Location = new System.Drawing.Point(12, 145);
            this.recoveredLabel.Name = "recoveredLabel";
            this.recoveredLabel.Size = new System.Drawing.Size(119, 17);
            this.recoveredLabel.TabIndex = 8;
            this.recoveredLabel.Text = "Выздоровевшие:";
            // 
            // allStats
            // 
            this.allStats.AutoSize = true;
            this.allStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allStats.Location = new System.Drawing.Point(131, 80);
            this.allStats.Name = "allStats";
            this.allStats.Size = new System.Drawing.Size(95, 17);
            this.allStats.TabIndex = 9;
            this.allStats.Text = "За всё время";
            // 
            // newStats
            // 
            this.newStats.AutoSize = true;
            this.newStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newStats.Location = new System.Drawing.Point(242, 80);
            this.newStats.Name = "newStats";
            this.newStats.Size = new System.Drawing.Size(140, 17);
            this.newStats.TabIndex = 10;
            this.newStats.Text = "За последние сутки";
            // 
            // casesResult
            // 
            this.casesResult.AutoSize = true;
            this.casesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.casesResult.Location = new System.Drawing.Point(131, 111);
            this.casesResult.Name = "casesResult";
            this.casesResult.Size = new System.Drawing.Size(0, 17);
            this.casesResult.TabIndex = 11;
            // 
            // newCasesResult
            // 
            this.newCasesResult.AutoSize = true;
            this.newCasesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCasesResult.Location = new System.Drawing.Point(242, 111);
            this.newCasesResult.Name = "newCasesResult";
            this.newCasesResult.Size = new System.Drawing.Size(0, 17);
            this.newCasesResult.TabIndex = 12;
            // 
            // deathsResult
            // 
            this.deathsResult.AutoSize = true;
            this.deathsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deathsResult.Location = new System.Drawing.Point(131, 128);
            this.deathsResult.Name = "deathsResult";
            this.deathsResult.Size = new System.Drawing.Size(0, 17);
            this.deathsResult.TabIndex = 13;
            // 
            // newDeathsResult
            // 
            this.newDeathsResult.AutoSize = true;
            this.newDeathsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDeathsResult.Location = new System.Drawing.Point(242, 128);
            this.newDeathsResult.Name = "newDeathsResult";
            this.newDeathsResult.Size = new System.Drawing.Size(0, 17);
            this.newDeathsResult.TabIndex = 14;
            // 
            // recoveredResult
            // 
            this.recoveredResult.AutoSize = true;
            this.recoveredResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recoveredResult.Location = new System.Drawing.Point(131, 145);
            this.recoveredResult.Name = "recoveredResult";
            this.recoveredResult.Size = new System.Drawing.Size(0, 17);
            this.recoveredResult.TabIndex = 15;
            // 
            // newRecoveredResult
            // 
            this.newRecoveredResult.AutoSize = true;
            this.newRecoveredResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRecoveredResult.Location = new System.Drawing.Point(242, 145);
            this.newRecoveredResult.Name = "newRecoveredResult";
            this.newRecoveredResult.Size = new System.Drawing.Size(0, 17);
            this.newRecoveredResult.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(394, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newRecoveredResult);
            this.Controls.Add(this.recoveredResult);
            this.Controls.Add(this.newDeathsResult);
            this.Controls.Add(this.deathsResult);
            this.Controls.Add(this.newCasesResult);
            this.Controls.Add(this.casesResult);
            this.Controls.Add(this.newStats);
            this.Controls.Add(this.allStats);
            this.Controls.Add(this.recoveredLabel);
            this.Controls.Add(this.deathsLabel);
            this.Controls.Add(this.casesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика COVID-19 в Украине";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label casesLabel;
        private System.Windows.Forms.Label deathsLabel;
        private System.Windows.Forms.Label recoveredLabel;
        private System.Windows.Forms.Label allStats;
        private System.Windows.Forms.Label newStats;
        private System.Windows.Forms.Label casesResult;
        private System.Windows.Forms.Label newCasesResult;
        private System.Windows.Forms.Label deathsResult;
        private System.Windows.Forms.Label newDeathsResult;
        private System.Windows.Forms.Label recoveredResult;
        private System.Windows.Forms.Label newRecoveredResult;
        private System.Windows.Forms.Label label2;
    }
}

