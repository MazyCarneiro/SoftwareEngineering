namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label applicantIDLabel;
            System.Windows.Forms.Label employerIdLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label jobIDLabel;
            this.applicantIDTextBox = new System.Windows.Forms.TextBox();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.employerIdTextBox = new System.Windows.Forms.TextBox();
            this.reviewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.jobIDTextBox = new System.Windows.Forms.TextBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicantTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.ApplicantTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Database1DataSetTableAdapters.TableAdapterManager();
            this.reviewerTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.ReviewerTableAdapter();
            this.jobTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.JobTableAdapter();
            this.applicantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reviewerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            applicantIDLabel = new System.Windows.Forms.Label();
            employerIdLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            jobIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // applicantIDLabel
            // 
            applicantIDLabel.AutoSize = true;
            applicantIDLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            applicantIDLabel.Location = new System.Drawing.Point(12, 74);
            applicantIDLabel.Name = "applicantIDLabel";
            applicantIDLabel.Size = new System.Drawing.Size(68, 13);
            applicantIDLabel.TabIndex = 7;
            applicantIDLabel.Text = "Applicant ID:";
            // 
            // employerIdLabel
            // 
            employerIdLabel.AutoSize = true;
            employerIdLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            employerIdLabel.Location = new System.Drawing.Point(480, 78);
            employerIdLabel.Name = "employerIdLabel";
            employerIdLabel.Size = new System.Drawing.Size(65, 13);
            employerIdLabel.TabIndex = 9;
            employerIdLabel.Text = "Employer Id:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            fullNameLabel.Location = new System.Drawing.Point(23, 101);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 10;
            fullNameLabel.Text = "Full Name:";
            // 
            // jobIDLabel
            // 
            jobIDLabel.AutoSize = true;
            jobIDLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            jobIDLabel.Location = new System.Drawing.Point(39, 127);
            jobIDLabel.Name = "jobIDLabel";
            jobIDLabel.Size = new System.Drawing.Size(41, 13);
            jobIDLabel.TabIndex = 21;
            jobIDLabel.Text = "Job ID:";
            // 
            // applicantIDTextBox
            // 
            this.applicantIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "ApplicantID", true));
            this.applicantIDTextBox.Location = new System.Drawing.Point(86, 71);
            this.applicantIDTextBox.Name = "applicantIDTextBox";
            this.applicantIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.applicantIDTextBox.TabIndex = 8;
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataMember = "Applicant";
            this.applicantBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "HAPPY TECH FEEDBACK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // employerIdTextBox
            // 
            this.employerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewerBindingSource, "EmployerId", true));
            this.employerIdTextBox.Location = new System.Drawing.Point(551, 75);
            this.employerIdTextBox.Name = "employerIdTextBox";
            this.employerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.employerIdTextBox.TabIndex = 10;
            // 
            // reviewerBindingSource
            // 
            this.reviewerBindingSource.DataMember = "Reviewer";
            this.reviewerBindingSource.DataSource = this.database1DataSet;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(86, 98);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fullNameTextBox.TabIndex = 11;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.fullNameTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "SAVE AS PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(551, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 26);
            this.button2.TabIndex = 15;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(281, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 26);
            this.button3.TabIndex = 16;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 581);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 26);
            this.button4.TabIndex = 17;
            this.button4.Text = "PREVIOUS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(146, 580);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 26);
            this.button5.TabIndex = 18;
            this.button5.Text = "NEXT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // jobIDTextBox
            // 
            this.jobIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "JobID", true));
            this.jobIDTextBox.Location = new System.Drawing.Point(86, 124);
            this.jobIDTextBox.Name = "jobIDTextBox";
            this.jobIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobIDTextBox.TabIndex = 22;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.database1DataSet;
            // 
            // applicantTableAdapter
            // 
            this.applicantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicantTableAdapter = this.applicantTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CommentsTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.ReviewerTableAdapter = this.reviewerTableAdapter;
            this.tableAdapterManager.SectionTableAdapter = null;
            this.tableAdapterManager.TemplateTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reviewerTableAdapter
            // 
            this.reviewerTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // applicantDataGridView
            // 
            this.applicantDataGridView.AutoGenerateColumns = false;
            this.applicantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.applicantDataGridView.DataSource = this.applicantBindingSource;
            this.applicantDataGridView.Location = new System.Drawing.Point(720, 9);
            this.applicantDataGridView.Name = "applicantDataGridView";
            this.applicantDataGridView.Size = new System.Drawing.Size(642, 182);
            this.applicantDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ApplicantID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ApplicantID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmailAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmailAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "D_O_B";
            this.dataGridViewTextBoxColumn5.HeaderText = "D_O_B";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JobID";
            this.dataGridViewTextBoxColumn6.HeaderText = "JobID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 572);
            this.dataGridView1.TabIndex = 23;
            // 
            // reviewerDataGridView
            // 
            this.reviewerDataGridView.AutoGenerateColumns = false;
            this.reviewerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.reviewerDataGridView.DataSource = this.reviewerBindingSource;
            this.reviewerDataGridView.Location = new System.Drawing.Point(1020, 188);
            this.reviewerDataGridView.Name = "reviewerDataGridView";
            this.reviewerDataGridView.Size = new System.Drawing.Size(342, 141);
            this.reviewerDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmployerId";
            this.dataGridViewTextBoxColumn7.HeaderText = "EmployerId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Full-Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Full-Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Email-Address";
            this.dataGridViewTextBoxColumn11.HeaderText = "Email-Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 680);
            this.Controls.Add(this.reviewerDataGridView);
            this.Controls.Add(this.applicantDataGridView);
            this.Controls.Add(jobIDLabel);
            this.Controls.Add(this.jobIDTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(employerIdLabel);
            this.Controls.Add(this.employerIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(applicantIDLabel);
            this.Controls.Add(this.applicantIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private Database1DataSetTableAdapters.ApplicantTableAdapter applicantTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox applicantIDTextBox;
        private System.Windows.Forms.Label label1;
        private Database1DataSetTableAdapters.ReviewerTableAdapter reviewerTableAdapter;
        private System.Windows.Forms.BindingSource reviewerBindingSource;
        private System.Windows.Forms.TextBox employerIdTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private Database1DataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox jobIDTextBox;
        private System.Windows.Forms.DataGridView applicantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView reviewerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}

