
namespace StudentRatingSystem
{
    partial class SubjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsForm));
            this.subjectsTable = new System.Windows.Forms.DataGridView();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentRatingDbDataSet6 = new StudentRatingSystem.StudentRatingDbDataSet6();
            this.pointsTableAdapter = new StudentRatingSystem.StudentRatingDbDataSet6TableAdapters.PointsTableAdapter();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.EditSubject = new System.Windows.Forms.Button();
            this.DeleteSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsTable
            // 
            this.subjectsTable.AutoGenerateColumns = false;
            this.subjectsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.finalExamTypeDataGridViewTextBoxColumn});
            this.subjectsTable.DataSource = this.pointsBindingSource;
            this.subjectsTable.Location = new System.Drawing.Point(13, 13);
            this.subjectsTable.Name = "subjectsTable";
            this.subjectsTable.RowHeadersWidth = 51;
            this.subjectsTable.RowTemplate.Height = 24;
            this.subjectsTable.Size = new System.Drawing.Size(659, 310);
            this.subjectsTable.TabIndex = 0;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Назва предмету";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 225;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Кредити";
            this.creditsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.Width = 70;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Години";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.Width = 70;
            // 
            // finalExamTypeDataGridViewTextBoxColumn
            // 
            this.finalExamTypeDataGridViewTextBoxColumn.DataPropertyName = "FinalExamType";
            this.finalExamTypeDataGridViewTextBoxColumn.HeaderText = "Підсумковий контроль";
            this.finalExamTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalExamTypeDataGridViewTextBoxColumn.Name = "finalExamTypeDataGridViewTextBoxColumn";
            this.finalExamTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // pointsBindingSource
            // 
            this.pointsBindingSource.DataMember = "Points";
            this.pointsBindingSource.DataSource = this.studentRatingDbDataSet6;
            // 
            // studentRatingDbDataSet6
            // 
            this.studentRatingDbDataSet6.DataSetName = "StudentRatingDbDataSet6";
            this.studentRatingDbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointsTableAdapter
            // 
            this.pointsTableAdapter.ClearBeforeFill = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(352, 372);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(204, 36);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Вихід";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(13, 330);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(204, 36);
            this.Add.TabIndex = 5;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // EditSubject
            // 
            this.EditSubject.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.EditSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditSubject.Location = new System.Drawing.Point(239, 330);
            this.EditSubject.Name = "EditSubject";
            this.EditSubject.Size = new System.Drawing.Size(204, 36);
            this.EditSubject.TabIndex = 6;
            this.EditSubject.Text = "Редагувати";
            this.EditSubject.UseVisualStyleBackColor = true;
            // 
            // DeleteSubject
            // 
            this.DeleteSubject.DialogResult = System.Windows.Forms.DialogResult.No;
            this.DeleteSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSubject.Location = new System.Drawing.Point(468, 330);
            this.DeleteSubject.Name = "DeleteSubject";
            this.DeleteSubject.Size = new System.Drawing.Size(204, 36);
            this.DeleteSubject.TabIndex = 7;
            this.DeleteSubject.Text = "Видалити";
            this.DeleteSubject.UseVisualStyleBackColor = true;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 418);
            this.Controls.Add(this.DeleteSubject);
            this.Controls.Add(this.EditSubject);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.subjectsTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubjectsForm";
            this.Text = "Навчальні дисципліни групи №";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRatingDbDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StudentRatingDbDataSet6 studentRatingDbDataSet6;
        private System.Windows.Forms.BindingSource pointsBindingSource;
        private StudentRatingDbDataSet6TableAdapters.PointsTableAdapter pointsTableAdapter;
        private System.Windows.Forms.Button Cancel;
        protected internal System.Windows.Forms.DataGridView subjectsTable;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button EditSubject;
        private System.Windows.Forms.Button DeleteSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamTypeDataGridViewTextBoxColumn;
    }
}