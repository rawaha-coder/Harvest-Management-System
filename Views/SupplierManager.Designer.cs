
namespace Harvest_Management_System.Views
{
    partial class SupplierManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSupplierManager = new System.Windows.Forms.Panel();
            this.pnlDisplaySupplier = new System.Windows.Forms.Panel();
            this.pnlSupplierManagerMiddle = new System.Windows.Forms.Panel();
            this.SupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupplierStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupplierFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupplierLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSupplierManagerLeftSide = new System.Windows.Forms.Panel();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.checkSupplierStatus = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.btnClearReset = new System.Windows.Forms.Button();
            this.txtSupplierFirstName = new System.Windows.Forms.TextBox();
            this.SupplierLastNameLabel = new System.Windows.Forms.Label();
            this.SupplierFirstNameLabel = new System.Windows.Forms.Label();
            this.txtSupplierLastName = new System.Windows.Forms.TextBox();
            this.nameSupplierErrorLabel = new System.Windows.Forms.Label();
            this.supplierFirstNameErrorLabel = new System.Windows.Forms.Label();
            this.supplierLastNameErrorLabel = new System.Windows.Forms.Label();
            this.panelSupplierManager.SuspendLayout();
            this.pnlDisplaySupplier.SuspendLayout();
            this.pnlSupplierManagerMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView)).BeginInit();
            this.pnlSupplierManagerLeftSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSupplierManager
            // 
            this.panelSupplierManager.AutoScroll = true;
            this.panelSupplierManager.Controls.Add(this.pnlDisplaySupplier);
            this.panelSupplierManager.Controls.Add(this.pnlSupplierManagerLeftSide);
            this.panelSupplierManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSupplierManager.Location = new System.Drawing.Point(0, 0);
            this.panelSupplierManager.Name = "panelSupplierManager";
            this.panelSupplierManager.Size = new System.Drawing.Size(1245, 769);
            this.panelSupplierManager.TabIndex = 0;
            // 
            // pnlDisplaySupplier
            // 
            this.pnlDisplaySupplier.AutoScroll = true;
            this.pnlDisplaySupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplaySupplier.Controls.Add(this.pnlSupplierManagerMiddle);
            this.pnlDisplaySupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplaySupplier.Location = new System.Drawing.Point(240, 0);
            this.pnlDisplaySupplier.Name = "pnlDisplaySupplier";
            this.pnlDisplaySupplier.Size = new System.Drawing.Size(1005, 769);
            this.pnlDisplaySupplier.TabIndex = 56;
            // 
            // pnlSupplierManagerMiddle
            // 
            this.pnlSupplierManagerMiddle.AutoScroll = true;
            this.pnlSupplierManagerMiddle.Controls.Add(this.SupplierDataGridView);
            this.pnlSupplierManagerMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSupplierManagerMiddle.Location = new System.Drawing.Point(0, 0);
            this.pnlSupplierManagerMiddle.Name = "pnlSupplierManagerMiddle";
            this.pnlSupplierManagerMiddle.Size = new System.Drawing.Size(1001, 765);
            this.pnlSupplierManagerMiddle.TabIndex = 0;
            // 
            // SupplierDataGridView
            // 
            this.SupplierDataGridView.AllowUserToAddRows = false;
            this.SupplierDataGridView.AllowUserToDeleteRows = false;
            this.SupplierDataGridView.AllowUserToOrderColumns = true;
            this.SupplierDataGridView.AllowUserToResizeColumns = false;
            this.SupplierDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.SupplierDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SupplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SupplierDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SupplierDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SupplierDataGridView.ColumnHeadersHeight = 36;
            this.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSupplierId,
            this.ColumnSupplierStatus,
            this.ColumnSupplierName,
            this.ColumnSupplierFirstName,
            this.ColumnSupplierLastName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SupplierDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.SupplierDataGridView.EnableHeadersVisualStyles = false;
            this.SupplierDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SupplierDataGridView.Location = new System.Drawing.Point(0, 0);
            this.SupplierDataGridView.Name = "SupplierDataGridView";
            this.SupplierDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SupplierDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.SupplierDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SupplierDataGridView.RowTemplate.Height = 25;
            this.SupplierDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplierDataGridView.Size = new System.Drawing.Size(1001, 765);
            this.SupplierDataGridView.TabIndex = 57;
            this.SupplierDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierDataGridView_CellDoubleClick);
            // 
            // ColumnSupplierId
            // 
            this.ColumnSupplierId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSupplierId.DataPropertyName = "SupplierId";
            this.ColumnSupplierId.HeaderText = "ID";
            this.ColumnSupplierId.MinimumWidth = 60;
            this.ColumnSupplierId.Name = "ColumnSupplierId";
            this.ColumnSupplierId.ReadOnly = true;
            this.ColumnSupplierId.Width = 60;
            // 
            // ColumnSupplierStatus
            // 
            this.ColumnSupplierStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSupplierStatus.DataPropertyName = "SupplierStatus";
            this.ColumnSupplierStatus.HeaderText = "Etat";
            this.ColumnSupplierStatus.MinimumWidth = 60;
            this.ColumnSupplierStatus.Name = "ColumnSupplierStatus";
            this.ColumnSupplierStatus.ReadOnly = true;
            this.ColumnSupplierStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSupplierStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSupplierStatus.Width = 60;
            // 
            // ColumnSupplierName
            // 
            this.ColumnSupplierName.DataPropertyName = "SupplierName";
            this.ColumnSupplierName.HeaderText = "Fournisseur";
            this.ColumnSupplierName.MinimumWidth = 200;
            this.ColumnSupplierName.Name = "ColumnSupplierName";
            this.ColumnSupplierName.ReadOnly = true;
            // 
            // ColumnSupplierFirstName
            // 
            this.ColumnSupplierFirstName.DataPropertyName = "SupplierFirstName";
            this.ColumnSupplierFirstName.HeaderText = "Prénom";
            this.ColumnSupplierFirstName.MinimumWidth = 160;
            this.ColumnSupplierFirstName.Name = "ColumnSupplierFirstName";
            this.ColumnSupplierFirstName.ReadOnly = true;
            // 
            // ColumnSupplierLastName
            // 
            this.ColumnSupplierLastName.DataPropertyName = "SupplierLastName";
            this.ColumnSupplierLastName.HeaderText = "Nom";
            this.ColumnSupplierLastName.MinimumWidth = 160;
            this.ColumnSupplierLastName.Name = "ColumnSupplierLastName";
            this.ColumnSupplierLastName.ReadOnly = true;
            // 
            // pnlSupplierManagerLeftSide
            // 
            this.pnlSupplierManagerLeftSide.AutoScroll = true;
            this.pnlSupplierManagerLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSupplierManagerLeftSide.Controls.Add(this.txtSupplierName);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.checkSupplierStatus);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.btnDelete);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.SupplierLabel);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.btnSaveSupplier);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.btnClearReset);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.txtSupplierFirstName);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.SupplierLastNameLabel);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.SupplierFirstNameLabel);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.txtSupplierLastName);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.nameSupplierErrorLabel);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.supplierFirstNameErrorLabel);
            this.pnlSupplierManagerLeftSide.Controls.Add(this.supplierLastNameErrorLabel);
            this.pnlSupplierManagerLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSupplierManagerLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSupplierManagerLeftSide.Name = "pnlSupplierManagerLeftSide";
            this.pnlSupplierManagerLeftSide.Size = new System.Drawing.Size(240, 769);
            this.pnlSupplierManagerLeftSide.TabIndex = 54;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierName.Location = new System.Drawing.Point(31, 140);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(184, 29);
            this.txtSupplierName.TabIndex = 56;
            // 
            // checkSupplierStatus
            // 
            this.checkSupplierStatus.AutoSize = true;
            this.checkSupplierStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkSupplierStatus.ForeColor = System.Drawing.Color.White;
            this.checkSupplierStatus.Location = new System.Drawing.Point(30, 341);
            this.checkSupplierStatus.Name = "checkSupplierStatus";
            this.checkSupplierStatus.Size = new System.Drawing.Size(55, 25);
            this.checkSupplierStatus.TabIndex = 55;
            this.checkSupplierStatus.Text = "Etat";
            this.checkSupplierStatus.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(12, 473);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(212, 30);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SupplierLabel.ForeColor = System.Drawing.Color.White;
            this.SupplierLabel.Location = new System.Drawing.Point(30, 116);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(95, 21);
            this.SupplierLabel.TabIndex = 40;
            this.SupplierLabel.Text = "Fournisseur:";
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveSupplier.FlatAppearance.BorderSize = 0;
            this.btnSaveSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnSaveSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSaveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveSupplier.Location = new System.Drawing.Point(12, 404);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(90, 30);
            this.btnSaveSupplier.TabIndex = 37;
            this.btnSaveSupplier.Text = "Ajouter";
            this.btnSaveSupplier.UseVisualStyleBackColor = false;
            this.btnSaveSupplier.Click += new System.EventHandler(this.btnSaveSupplier_Click);
            // 
            // btnClearReset
            // 
            this.btnClearReset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClearReset.FlatAppearance.BorderSize = 0;
            this.btnClearReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnClearReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnClearReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearReset.Location = new System.Drawing.Point(134, 404);
            this.btnClearReset.Name = "btnClearReset";
            this.btnClearReset.Size = new System.Drawing.Size(90, 30);
            this.btnClearReset.TabIndex = 38;
            this.btnClearReset.Text = "Vider";
            this.btnClearReset.UseVisualStyleBackColor = false;
            this.btnClearReset.Click += new System.EventHandler(this.btnClearReset_Click);
            // 
            // txtSupplierFirstName
            // 
            this.txtSupplierFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierFirstName.Location = new System.Drawing.Point(30, 210);
            this.txtSupplierFirstName.Name = "txtSupplierFirstName";
            this.txtSupplierFirstName.Size = new System.Drawing.Size(184, 29);
            this.txtSupplierFirstName.TabIndex = 2;
            // 
            // SupplierLastNameLabel
            // 
            this.SupplierLastNameLabel.AutoSize = true;
            this.SupplierLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SupplierLastNameLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.SupplierLastNameLabel.Location = new System.Drawing.Point(31, 256);
            this.SupplierLastNameLabel.Name = "SupplierLastNameLabel";
            this.SupplierLastNameLabel.Size = new System.Drawing.Size(48, 21);
            this.SupplierLastNameLabel.TabIndex = 46;
            this.SupplierLastNameLabel.Text = "Nom:";
            // 
            // SupplierFirstNameLabel
            // 
            this.SupplierFirstNameLabel.AutoSize = true;
            this.SupplierFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SupplierFirstNameLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.SupplierFirstNameLabel.Location = new System.Drawing.Point(30, 186);
            this.SupplierFirstNameLabel.Name = "SupplierFirstNameLabel";
            this.SupplierFirstNameLabel.Size = new System.Drawing.Size(68, 21);
            this.SupplierFirstNameLabel.TabIndex = 43;
            this.SupplierFirstNameLabel.Text = "Prénom:";
            // 
            // txtSupplierLastName
            // 
            this.txtSupplierLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierLastName.Location = new System.Drawing.Point(30, 280);
            this.txtSupplierLastName.Name = "txtSupplierLastName";
            this.txtSupplierLastName.Size = new System.Drawing.Size(184, 29);
            this.txtSupplierLastName.TabIndex = 3;
            // 
            // nameSupplierErrorLabel
            // 
            this.nameSupplierErrorLabel.AutoSize = true;
            this.nameSupplierErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameSupplierErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameSupplierErrorLabel.Location = new System.Drawing.Point(196, 116);
            this.nameSupplierErrorLabel.Name = "nameSupplierErrorLabel";
            this.nameSupplierErrorLabel.Size = new System.Drawing.Size(28, 37);
            this.nameSupplierErrorLabel.TabIndex = 41;
            this.nameSupplierErrorLabel.Text = "*";
            this.nameSupplierErrorLabel.Visible = false;
            // 
            // supplierFirstNameErrorLabel
            // 
            this.supplierFirstNameErrorLabel.AutoSize = true;
            this.supplierFirstNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supplierFirstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.supplierFirstNameErrorLabel.Location = new System.Drawing.Point(196, 184);
            this.supplierFirstNameErrorLabel.Name = "supplierFirstNameErrorLabel";
            this.supplierFirstNameErrorLabel.Size = new System.Drawing.Size(28, 37);
            this.supplierFirstNameErrorLabel.TabIndex = 42;
            this.supplierFirstNameErrorLabel.Text = "*";
            this.supplierFirstNameErrorLabel.Visible = false;
            // 
            // supplierLastNameErrorLabel
            // 
            this.supplierLastNameErrorLabel.AutoSize = true;
            this.supplierLastNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supplierLastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.supplierLastNameErrorLabel.Location = new System.Drawing.Point(196, 254);
            this.supplierLastNameErrorLabel.Name = "supplierLastNameErrorLabel";
            this.supplierLastNameErrorLabel.Size = new System.Drawing.Size(28, 37);
            this.supplierLastNameErrorLabel.TabIndex = 45;
            this.supplierLastNameErrorLabel.Text = "*";
            this.supplierLastNameErrorLabel.Visible = false;
            // 
            // SupplierManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1245, 769);
            this.Controls.Add(this.panelSupplierManager);
            this.Name = "SupplierManager";
            this.Text = "SupplierManager";
            this.Load += new System.EventHandler(this.SupplierManager_Load);
            this.panelSupplierManager.ResumeLayout(false);
            this.pnlDisplaySupplier.ResumeLayout(false);
            this.pnlSupplierManagerMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView)).EndInit();
            this.pnlSupplierManagerLeftSide.ResumeLayout(false);
            this.pnlSupplierManagerLeftSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupplierManager;
        private System.Windows.Forms.Panel pnlDisplaySupplier;
        private System.Windows.Forms.Panel pnlSupplierManagerLeftSide;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Button btnSaveSupplier;
        private System.Windows.Forms.Button btnClearReset;
        private System.Windows.Forms.TextBox txtSupplierFirstName;
        private System.Windows.Forms.Label SupplierLastNameLabel;
        private System.Windows.Forms.Label SupplierFirstNameLabel;
        private System.Windows.Forms.TextBox txtSupplierLastName;
        private System.Windows.Forms.Label nameSupplierErrorLabel;
        private System.Windows.Forms.Label supplierFirstNameErrorLabel;
        private System.Windows.Forms.Label supplierLastNameErrorLabel;
        private System.Windows.Forms.CheckBox checkSupplierStatus;
        private System.Windows.Forms.Panel pnlSupplierManagerMiddle;
        private System.Windows.Forms.DataGridView SupplierDataGridView;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplierId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSupplierStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplierFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplierLastName;
    }
}