
namespace StudentRatingSystem
{
    partial class EditStudentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentForm));
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.StudentSpecialtyNum = new System.Windows.Forms.NumericUpDown();
            this.StudentGroupNum = new System.Windows.Forms.NumericUpDown();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExtraPoints = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentSpecialtyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(47, 247);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(172, 34);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Скасувати";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(299, 247);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(172, 34);
            this.OkButton.TabIndex = 16;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // StudentSpecialtyNum
            // 
            this.StudentSpecialtyNum.Location = new System.Drawing.Point(246, 155);
            this.StudentSpecialtyNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StudentSpecialtyNum.Name = "StudentSpecialtyNum";
            this.StudentSpecialtyNum.Size = new System.Drawing.Size(123, 22);
            this.StudentSpecialtyNum.TabIndex = 15;
            // 
            // StudentGroupNum
            // 
            this.StudentGroupNum.Location = new System.Drawing.Point(246, 107);
            this.StudentGroupNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StudentGroupNum.Name = "StudentGroupNum";
            this.StudentGroupNum.Size = new System.Drawing.Size(123, 22);
            this.StudentGroupNum.TabIndex = 14;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(246, 62);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(277, 22);
            this.StudentName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Спеціальність (номер):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Група:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ПІБ студента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введіть дані про студента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Додаткові бали:";
            // 
            // ExtraPoints
            // 
            this.ExtraPoints.DecimalPlaces = 2;
            this.ExtraPoints.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ExtraPoints.Location = new System.Drawing.Point(246, 206);
            this.ExtraPoints.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ExtraPoints.Name = "ExtraPoints";
            this.ExtraPoints.Size = new System.Drawing.Size(123, 22);
            this.ExtraPoints.TabIndex = 19;
            this.ExtraPoints.ValueChanged += new System.EventHandler(this.ExtraPoints_ValueChanged);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 310);
            this.Controls.Add(this.ExtraPoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.StudentSpecialtyNum);
            this.Controls.Add(this.StudentGroupNum);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStudentForm";
            this.Text = "Редагування даних";
            ((System.ComponentModel.ISupportInitialize)(this.StudentSpecialtyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        protected internal System.Windows.Forms.NumericUpDown StudentSpecialtyNum;
        protected internal System.Windows.Forms.NumericUpDown StudentGroupNum;
        protected internal System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.NumericUpDown ExtraPoints;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}