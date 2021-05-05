
namespace StudentRatingSystem
{
    partial class InputSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputSubjectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.Credits = new System.Windows.Forms.NumericUpDown();
            this.HoursCount = new System.Windows.Forms.NumericUpDown();
            this.ExamType = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Credits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть дані про навчальну дисципліну:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кредити:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Навчальні години:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип підсумкового контролю:";
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(250, 202);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(139, 29);
            this.Ok.TabIndex = 5;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(86, 47);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(318, 22);
            this.SubjectName.TabIndex = 6;
            // 
            // Credits
            // 
            this.Credits.DecimalPlaces = 1;
            this.Credits.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Credits.Location = new System.Drawing.Point(268, 83);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(136, 22);
            this.Credits.TabIndex = 7;
            // 
            // HoursCount
            // 
            this.HoursCount.Location = new System.Drawing.Point(268, 121);
            this.HoursCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HoursCount.Name = "HoursCount";
            this.HoursCount.Size = new System.Drawing.Size(136, 22);
            this.HoursCount.TabIndex = 8;
            // 
            // ExamType
            // 
            this.ExamType.AutoCompleteCustomSource.AddRange(new string[] {
            "залік",
            "іспит",
            "атестація"});
            this.ExamType.FormattingEnabled = true;
            this.ExamType.Items.AddRange(new object[] {
            "залік",
            "іспит",
            "атестація"});
            this.ExamType.Location = new System.Drawing.Point(268, 159);
            this.ExamType.Name = "ExamType";
            this.ExamType.Size = new System.Drawing.Size(136, 24);
            this.ExamType.TabIndex = 9;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(18, 202);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 29);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Скасувати";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // InputSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 251);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ExamType);
            this.Controls.Add(this.HoursCount);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputSubjectForm";
            this.Text = "Введення даних про предмет";
            ((System.ComponentModel.ISupportInitialize)(this.Credits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        protected internal System.Windows.Forms.TextBox SubjectName;
        protected internal System.Windows.Forms.NumericUpDown Credits;
        protected internal System.Windows.Forms.NumericUpDown HoursCount;
        protected internal System.Windows.Forms.ComboBox ExamType;
    }
}