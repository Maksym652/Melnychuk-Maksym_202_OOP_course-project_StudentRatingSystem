
namespace StudentRatingSystem
{
    partial class PointsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointsForm));
            this.PointsTable = new System.Windows.Forms.DataGridView();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentRatingDbDataSet4 = new StudentRatingSystem.StudentRatingDbDataSet4();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RatingPointBox = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.studentRatingDbDataSet2 = new StudentRatingSystem.StudentRatingDbDataSet2();
            this.pointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsTableAdapter = new StudentRatingSystem.StudentRatingDbDataSet2TableAdapters.PointsTableAdapter();
            this.studentRatingDbDataSet3 = new StudentRatingSystem.StudentRatingDbDataSet3();
            this.pointsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pointsTableAdapter1 = new StudentRatingSystem.StudentRatingDbDataSet3TableAdapters.PointsTableAdapter();
            this.pointsTableAdapter2 = new StudentRatingSystem.StudentRatingDbDataSet4TableAdapters.PointsTableAdapter();
            this.newPoint = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PointsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // PointsTable
            // 
            this.PointsTable.AllowUserToAddRows = false;
            this.PointsTable.AllowUserToDeleteRows = false;
            this.PointsTable.AllowUserToResizeColumns = false;
            this.PointsTable.AllowUserToResizeRows = false;
            this.PointsTable.AutoGenerateColumns = false;
            this.PointsTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PointsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.finalExamTypeDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.Id});
            this.PointsTable.DataSource = this.pointsBindingSource2;
            this.PointsTable.Location = new System.Drawing.Point(13, 13);
            this.PointsTable.Name = "PointsTable";
            this.PointsTable.ReadOnly = true;
            this.PointsTable.RowHeadersWidth = 51;
            this.PointsTable.RowTemplate.Height = 24;
            this.PointsTable.Size = new System.Drawing.Size(775, 352);
            this.PointsTable.TabIndex = 0;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Навчальна дисципліна";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectDataGridViewTextBoxColumn.Width = 200;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Кредити";
            this.creditsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditsDataGridViewTextBoxColumn.Width = 70;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Години";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursDataGridViewTextBoxColumn.Width = 70;
            // 
            // finalExamTypeDataGridViewTextBoxColumn
            // 
            this.finalExamTypeDataGridViewTextBoxColumn.DataPropertyName = "FinalExamType";
            this.finalExamTypeDataGridViewTextBoxColumn.HeaderText = "Підсумкове оцінювання";
            this.finalExamTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalExamTypeDataGridViewTextBoxColumn.Name = "finalExamTypeDataGridViewTextBoxColumn";
            this.finalExamTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalExamTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Бал";
            this.markDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.markDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.ReadOnly = true;
            this.markDataGridViewTextBoxColumn.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // pointsBindingSource2
            // 
            this.pointsBindingSource2.DataMember = "Points";
            this.pointsBindingSource2.DataSource = this.studentRatingDbDataSet4;
            // 
            // studentRatingDbDataSet4
            // 
            this.studentRatingDbDataSet4.DataSetName = "StudentRatingDbDataSet4";
            this.studentRatingDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(598, 408);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(190, 32);
            this.Close.TabIndex = 1;
            this.Close.Text = "Закрити";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(440, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Рейтинговий бал студента:";
            // 
            // RatingPointBox
            // 
            this.RatingPointBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingPointBox.Location = new System.Drawing.Point(688, 371);
            this.RatingPointBox.Name = "RatingPointBox";
            this.RatingPointBox.ReadOnly = true;
            this.RatingPointBox.Size = new System.Drawing.Size(100, 30);
            this.RatingPointBox.TabIndex = 3;
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(147, 408);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(138, 32);
            this.Ok.TabIndex = 4;
            this.Ok.Text = "Ввести";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // studentRatingDbDataSet2
            // 
            this.studentRatingDbDataSet2.DataSetName = "StudentRatingDbDataSet2";
            this.studentRatingDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointsBindingSource
            // 
            this.pointsBindingSource.DataMember = "Points";
            this.pointsBindingSource.DataSource = this.studentRatingDbDataSet2;
            // 
            // pointsTableAdapter
            // 
            this.pointsTableAdapter.ClearBeforeFill = true;
            // 
            // studentRatingDbDataSet3
            // 
            this.studentRatingDbDataSet3.DataSetName = "StudentRatingDbDataSet3";
            this.studentRatingDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointsBindingSource1
            // 
            this.pointsBindingSource1.DataMember = "Points";
            this.pointsBindingSource1.DataSource = this.studentRatingDbDataSet3;
            // 
            // pointsTableAdapter1
            // 
            this.pointsTableAdapter1.ClearBeforeFill = true;
            // 
            // pointsTableAdapter2
            // 
            this.pointsTableAdapter2.ClearBeforeFill = true;
            // 
            // newPoint
            // 
            this.newPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPoint.Location = new System.Drawing.Point(147, 375);
            this.newPoint.Name = "newPoint";
            this.newPoint.Size = new System.Drawing.Size(138, 27);
            this.newPoint.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Зміна балу:";
            // 
            // PointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPoint);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.RatingPointBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PointsTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PointsForm";
            this.Text = "Оцінки студента";
            this.Load += new System.EventHandler(this.PointsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PointsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StudentRatingDbDataSet2 studentRatingDbDataSet2;
        private System.Windows.Forms.BindingSource pointsBindingSource;
        private StudentRatingDbDataSet2TableAdapters.PointsTableAdapter pointsTableAdapter;
        private StudentRatingDbDataSet3 studentRatingDbDataSet3;
        private System.Windows.Forms.BindingSource pointsBindingSource1;
        private StudentRatingDbDataSet3TableAdapters.PointsTableAdapter pointsTableAdapter1;
        private StudentRatingDbDataSet4 studentRatingDbDataSet4;
        private System.Windows.Forms.BindingSource pointsBindingSource2;
        private StudentRatingDbDataSet4TableAdapters.PointsTableAdapter pointsTableAdapter2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RatingPointBox;
        private System.Windows.Forms.Button Ok;
        protected internal System.Windows.Forms.DataGridView PointsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.NumericUpDown newPoint;
    }
}