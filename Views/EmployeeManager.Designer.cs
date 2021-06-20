﻿
namespace Harvest_Management_System.Views
{
    partial class EmployeeManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEmployeemanager = new System.Windows.Forms.Panel();
            this.pnlDisplayEmployee = new System.Windows.Forms.Panel();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeStatusColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeHireDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFireDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePermissionDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDisplayCloseFire = new System.Windows.Forms.Panel();
            this.txtListEmployeeCloseFire = new System.Windows.Forms.TextBox();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.chackEmployeeStatus = new System.Windows.Forms.CheckBox();
            this.btnClearReset = new System.Windows.Forms.Button();
            this.datePermissionDate = new System.Windows.Forms.DateTimePicker();
            this.labelLastName = new System.Windows.Forms.Label();
            this.dateFireDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateHireDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.pnlEmployeemanager.SuspendLayout();
            this.pnlDisplayEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.pnlDisplayCloseFire.SuspendLayout();
            this.pnlAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployeemanager
            // 
            this.pnlEmployeemanager.AutoScroll = true;
            this.pnlEmployeemanager.Controls.Add(this.pnlDisplayEmployee);
            this.pnlEmployeemanager.Controls.Add(this.pnlDisplayCloseFire);
            this.pnlEmployeemanager.Controls.Add(this.pnlAddEmployee);
            this.pnlEmployeemanager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeemanager.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeemanager.Name = "pnlEmployeemanager";
            this.pnlEmployeemanager.Size = new System.Drawing.Size(1165, 705);
            this.pnlEmployeemanager.TabIndex = 0;
            // 
            // pnlDisplayEmployee
            // 
            this.pnlDisplayEmployee.AutoScroll = true;
            this.pnlDisplayEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayEmployee.Controls.Add(this.EmployeeDataGridView);
            this.pnlDisplayEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayEmployee.Location = new System.Drawing.Point(245, 0);
            this.pnlDisplayEmployee.Name = "pnlDisplayEmployee";
            this.pnlDisplayEmployee.Size = new System.Drawing.Size(721, 705);
            this.pnlDisplayEmployee.TabIndex = 37;
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.AllowUserToOrderColumns = true;
            this.EmployeeDataGridView.AllowUserToResizeColumns = false;
            this.EmployeeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.EmployeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.EmployeeDataGridView.ColumnHeadersHeight = 36;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeStatusColumn,
            this.employeeIdColumn,
            this.employeeFullNameColumn,
            this.employeeFirstNameColumn,
            this.employeeLastNameColumn,
            this.employeeHireDateColumn,
            this.employeeFireDateColumn,
            this.employeePermissionDateColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.EmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeDataGridView.EnableHeadersVisualStyles = false;
            this.EmployeeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EmployeeDataGridView.MultiSelect = false;
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.EmployeeDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.EmployeeDataGridView.RowTemplate.Height = 25;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(717, 701);
            this.EmployeeDataGridView.TabIndex = 2;
            this.EmployeeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellDoubleClick);
            // 
            // employeeStatusColumn
            // 
            this.employeeStatusColumn.DataPropertyName = "EmployeeStatus";
            this.employeeStatusColumn.HeaderText = "Etat";
            this.employeeStatusColumn.MinimumWidth = 40;
            this.employeeStatusColumn.Name = "employeeStatusColumn";
            this.employeeStatusColumn.ReadOnly = true;
            this.employeeStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // employeeIdColumn
            // 
            this.employeeIdColumn.DataPropertyName = "EmployeeId";
            this.employeeIdColumn.HeaderText = "Id";
            this.employeeIdColumn.MinimumWidth = 40;
            this.employeeIdColumn.Name = "employeeIdColumn";
            this.employeeIdColumn.ReadOnly = true;
            // 
            // employeeFullNameColumn
            // 
            this.employeeFullNameColumn.DataPropertyName = "FullName";
            this.employeeFullNameColumn.HeaderText = "Employée";
            this.employeeFullNameColumn.MinimumWidth = 200;
            this.employeeFullNameColumn.Name = "employeeFullNameColumn";
            this.employeeFullNameColumn.ReadOnly = true;
            // 
            // employeeFirstNameColumn
            // 
            this.employeeFirstNameColumn.DataPropertyName = "FirstName";
            this.employeeFirstNameColumn.HeaderText = "Prénom";
            this.employeeFirstNameColumn.MinimumWidth = 100;
            this.employeeFirstNameColumn.Name = "employeeFirstNameColumn";
            this.employeeFirstNameColumn.ReadOnly = true;
            // 
            // employeeLastNameColumn
            // 
            this.employeeLastNameColumn.DataPropertyName = "LastName";
            this.employeeLastNameColumn.HeaderText = "Nom";
            this.employeeLastNameColumn.MinimumWidth = 100;
            this.employeeLastNameColumn.Name = "employeeLastNameColumn";
            this.employeeLastNameColumn.ReadOnly = true;
            // 
            // employeeHireDateColumn
            // 
            this.employeeHireDateColumn.DataPropertyName = "HireDate";
            this.employeeHireDateColumn.HeaderText = "Debut CTR";
            this.employeeHireDateColumn.MinimumWidth = 80;
            this.employeeHireDateColumn.Name = "employeeHireDateColumn";
            this.employeeHireDateColumn.ReadOnly = true;
            this.employeeHireDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // employeeFireDateColumn
            // 
            this.employeeFireDateColumn.DataPropertyName = "FireDate";
            this.employeeFireDateColumn.HeaderText = "Fin CTR";
            this.employeeFireDateColumn.MinimumWidth = 80;
            this.employeeFireDateColumn.Name = "employeeFireDateColumn";
            this.employeeFireDateColumn.ReadOnly = true;
            // 
            // employeePermissionDateColumn
            // 
            this.employeePermissionDateColumn.DataPropertyName = "PermitDate";
            this.employeePermissionDateColumn.HeaderText = "SCDZP";
            this.employeePermissionDateColumn.MinimumWidth = 80;
            this.employeePermissionDateColumn.Name = "employeePermissionDateColumn";
            this.employeePermissionDateColumn.ReadOnly = true;
            // 
            // pnlDisplayCloseFire
            // 
            this.pnlDisplayCloseFire.AutoScroll = true;
            this.pnlDisplayCloseFire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayCloseFire.Controls.Add(this.txtListEmployeeCloseFire);
            this.pnlDisplayCloseFire.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDisplayCloseFire.Location = new System.Drawing.Point(966, 0);
            this.pnlDisplayCloseFire.Name = "pnlDisplayCloseFire";
            this.pnlDisplayCloseFire.Size = new System.Drawing.Size(199, 705);
            this.pnlDisplayCloseFire.TabIndex = 36;
            // 
            // txtListEmployeeCloseFire
            // 
            this.txtListEmployeeCloseFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtListEmployeeCloseFire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtListEmployeeCloseFire.ForeColor = System.Drawing.Color.Red;
            this.txtListEmployeeCloseFire.Location = new System.Drawing.Point(0, 0);
            this.txtListEmployeeCloseFire.Multiline = true;
            this.txtListEmployeeCloseFire.Name = "txtListEmployeeCloseFire";
            this.txtListEmployeeCloseFire.Size = new System.Drawing.Size(195, 701);
            this.txtListEmployeeCloseFire.TabIndex = 3;
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddEmployee.Controls.Add(this.btnDelete);
            this.pnlAddEmployee.Controls.Add(this.labelFirstName);
            this.pnlAddEmployee.Controls.Add(this.chackEmployeeStatus);
            this.pnlAddEmployee.Controls.Add(this.btnClearReset);
            this.pnlAddEmployee.Controls.Add(this.datePermissionDate);
            this.pnlAddEmployee.Controls.Add(this.labelLastName);
            this.pnlAddEmployee.Controls.Add(this.dateFireDate);
            this.pnlAddEmployee.Controls.Add(this.label1);
            this.pnlAddEmployee.Controls.Add(this.dateHireDate);
            this.pnlAddEmployee.Controls.Add(this.label2);
            this.pnlAddEmployee.Controls.Add(this.btnSave);
            this.pnlAddEmployee.Controls.Add(this.label3);
            this.pnlAddEmployee.Controls.Add(this.txtLastName);
            this.pnlAddEmployee.Controls.Add(this.txtFirstName);
            this.pnlAddEmployee.Controls.Add(this.firstNameErrorLabel);
            this.pnlAddEmployee.Controls.Add(this.lastNameErrorLabel);
            this.pnlAddEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(245, 705);
            this.pnlAddEmployee.TabIndex = 34;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(16, 546);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 30);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.ForeColor = System.Drawing.Color.White;
            this.labelFirstName.Location = new System.Drawing.Point(39, 84);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(65, 21);
            this.labelFirstName.TabIndex = 18;
            this.labelFirstName.Text = "Prénom";
            // 
            // chackEmployeeStatus
            // 
            this.chackEmployeeStatus.AutoSize = true;
            this.chackEmployeeStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chackEmployeeStatus.ForeColor = System.Drawing.Color.White;
            this.chackEmployeeStatus.Location = new System.Drawing.Point(39, 412);
            this.chackEmployeeStatus.Name = "chackEmployeeStatus";
            this.chackEmployeeStatus.Size = new System.Drawing.Size(55, 25);
            this.chackEmployeeStatus.TabIndex = 6;
            this.chackEmployeeStatus.Text = "Etat";
            this.chackEmployeeStatus.UseVisualStyleBackColor = true;
            // 
            // btnClearReset
            // 
            this.btnClearReset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClearReset.FlatAppearance.BorderSize = 0;
            this.btnClearReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnClearReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnClearReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearReset.Location = new System.Drawing.Point(118, 474);
            this.btnClearReset.Name = "btnClearReset";
            this.btnClearReset.Size = new System.Drawing.Size(90, 30);
            this.btnClearReset.TabIndex = 8;
            this.btnClearReset.Text = "Reset";
            this.btnClearReset.UseVisualStyleBackColor = false;
            this.btnClearReset.Click += new System.EventHandler(this.btnClearReset_Click);
            // 
            // datePermissionDate
            // 
            this.datePermissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePermissionDate.Location = new System.Drawing.Point(39, 366);
            this.datePermissionDate.Name = "datePermissionDate";
            this.datePermissionDate.Size = new System.Drawing.Size(160, 23);
            this.datePermissionDate.TabIndex = 5;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.ForeColor = System.Drawing.Color.White;
            this.labelLastName.Location = new System.Drawing.Point(39, 144);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(45, 21);
            this.labelLastName.TabIndex = 19;
            this.labelLastName.Text = "Nom";
            // 
            // dateFireDate
            // 
            this.dateFireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFireDate.Location = new System.Drawing.Point(39, 299);
            this.dateFireDate.Name = "dateFireDate";
            this.dateFireDate.Size = new System.Drawing.Size(160, 23);
            this.dateFireDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Debut CTR";
            // 
            // dateHireDate
            // 
            this.dateHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHireDate.Location = new System.Drawing.Point(39, 234);
            this.dateHireDate.Name = "dateHireDate";
            this.dateHireDate.Size = new System.Drawing.Size(160, 23);
            this.dateHireDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fin CTR";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(16, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date SCDZP";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLastName.Location = new System.Drawing.Point(39, 168);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 23);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.fxLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFirstName.Location = new System.Drawing.Point(39, 108);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 23);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.fxFirstName_TextChanged);
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(180, 84);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(28, 37);
            this.firstNameErrorLabel.TabIndex = 31;
            this.firstNameErrorLabel.Text = "*";
            this.firstNameErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(180, 144);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(28, 37);
            this.lastNameErrorLabel.TabIndex = 32;
            this.lastNameErrorLabel.Text = "*";
            this.lastNameErrorLabel.Visible = false;
            // 
            // EmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1165, 705);
            this.Controls.Add(this.pnlEmployeemanager);
            this.Name = "EmployeeManager";
            this.Text = "EmployeeManager";
            this.Load += new System.EventHandler(this.EmployeeManager_Load);
            this.pnlEmployeemanager.ResumeLayout(false);
            this.pnlDisplayEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.pnlDisplayCloseFire.ResumeLayout(false);
            this.pnlDisplayCloseFire.PerformLayout();
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeemanager;
        private System.Windows.Forms.Panel pnlDisplayEmployee;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn employeeStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeHireDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFireDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePermissionDateColumn;
        private System.Windows.Forms.Panel pnlDisplayCloseFire;
        private System.Windows.Forms.TextBox txtListEmployeeCloseFire;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.CheckBox chackEmployeeStatus;
        private System.Windows.Forms.Button btnClearReset;
        private System.Windows.Forms.DateTimePicker datePermissionDate;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.DateTimePicker dateFireDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateHireDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
    }
}