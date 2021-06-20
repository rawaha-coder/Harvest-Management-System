
namespace Harvest_Management_System.Views
{
    partial class FarmManager
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
            this.pnlFarmManager = new System.Windows.Forms.Panel();
            this.pnlAddFarm = new System.Windows.Forms.Panel();
            this.ChampLabel = new System.Windows.Forms.Label();
            this.dateHarvestDate = new System.Windows.Forms.DateTimePicker();
            this.datePlantingDate = new System.Windows.Forms.DateTimePicker();
            this.HarvestLabel = new System.Windows.Forms.Label();
            this.cmbxFarmName = new System.Windows.Forms.ComboBox();
            this.PlantationLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearReset = new System.Windows.Forms.Button();
            this.txtFarmAddress = new System.Windows.Forms.TextBox();
            this.nameFarmErrorLabel = new System.Windows.Forms.Label();
            this.addressFarmErrorLabel = new System.Windows.Forms.Label();
            this.panelDisplayFarm = new System.Windows.Forms.Panel();
            this.FarmDataGridView = new System.Windows.Forms.DataGridView();
            this.FarmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FarmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFarmManager.SuspendLayout();
            this.pnlAddFarm.SuspendLayout();
            this.panelDisplayFarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FarmDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFarmManager
            // 
            this.pnlFarmManager.AutoScroll = true;
            this.pnlFarmManager.Controls.Add(this.panelDisplayFarm);
            this.pnlFarmManager.Controls.Add(this.pnlAddFarm);
            this.pnlFarmManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFarmManager.Location = new System.Drawing.Point(0, 0);
            this.pnlFarmManager.Name = "pnlFarmManager";
            this.pnlFarmManager.Size = new System.Drawing.Size(1176, 730);
            this.pnlFarmManager.TabIndex = 0;
            // 
            // pnlAddFarm
            // 
            this.pnlAddFarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddFarm.Controls.Add(this.ChampLabel);
            this.pnlAddFarm.Controls.Add(this.dateHarvestDate);
            this.pnlAddFarm.Controls.Add(this.datePlantingDate);
            this.pnlAddFarm.Controls.Add(this.HarvestLabel);
            this.pnlAddFarm.Controls.Add(this.cmbxFarmName);
            this.pnlAddFarm.Controls.Add(this.PlantationLabel);
            this.pnlAddFarm.Controls.Add(this.btnSave);
            this.pnlAddFarm.Controls.Add(this.AddressLabel);
            this.pnlAddFarm.Controls.Add(this.btnDelete);
            this.pnlAddFarm.Controls.Add(this.btnClearReset);
            this.pnlAddFarm.Controls.Add(this.txtFarmAddress);
            this.pnlAddFarm.Controls.Add(this.nameFarmErrorLabel);
            this.pnlAddFarm.Controls.Add(this.addressFarmErrorLabel);
            this.pnlAddFarm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddFarm.Location = new System.Drawing.Point(0, 0);
            this.pnlAddFarm.Name = "pnlAddFarm";
            this.pnlAddFarm.Size = new System.Drawing.Size(250, 730);
            this.pnlAddFarm.TabIndex = 40;
            // 
            // ChampLabel
            // 
            this.ChampLabel.AutoSize = true;
            this.ChampLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChampLabel.ForeColor = System.Drawing.Color.White;
            this.ChampLabel.Location = new System.Drawing.Point(45, 107);
            this.ChampLabel.Name = "ChampLabel";
            this.ChampLabel.Size = new System.Drawing.Size(63, 21);
            this.ChampLabel.TabIndex = 29;
            this.ChampLabel.Text = "Champ:";
            // 
            // dateHarvestDate
            // 
            this.dateHarvestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHarvestDate.Location = new System.Drawing.Point(45, 352);
            this.dateHarvestDate.Name = "dateHarvestDate";
            this.dateHarvestDate.Size = new System.Drawing.Size(160, 23);
            this.dateHarvestDate.TabIndex = 4;
            // 
            // datePlantingDate
            // 
            this.datePlantingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePlantingDate.Location = new System.Drawing.Point(45, 279);
            this.datePlantingDate.Name = "datePlantingDate";
            this.datePlantingDate.Size = new System.Drawing.Size(160, 23);
            this.datePlantingDate.TabIndex = 3;
            // 
            // HarvestLabel
            // 
            this.HarvestLabel.AutoSize = true;
            this.HarvestLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HarvestLabel.ForeColor = System.Drawing.Color.White;
            this.HarvestLabel.Location = new System.Drawing.Point(45, 328);
            this.HarvestLabel.Name = "HarvestLabel";
            this.HarvestLabel.Size = new System.Drawing.Size(64, 21);
            this.HarvestLabel.TabIndex = 38;
            this.HarvestLabel.Text = "Récolte:";
            // 
            // cmbxFarmName
            // 
            this.cmbxFarmName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxFarmName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxFarmName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbxFarmName.FormattingEnabled = true;
            this.cmbxFarmName.Location = new System.Drawing.Point(45, 132);
            this.cmbxFarmName.Name = "cmbxFarmName";
            this.cmbxFarmName.Size = new System.Drawing.Size(160, 29);
            this.cmbxFarmName.TabIndex = 1;
            // 
            // PlantationLabel
            // 
            this.PlantationLabel.AutoSize = true;
            this.PlantationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlantationLabel.ForeColor = System.Drawing.Color.White;
            this.PlantationLabel.Location = new System.Drawing.Point(45, 254);
            this.PlantationLabel.Name = "PlantationLabel";
            this.PlantationLabel.Size = new System.Drawing.Size(83, 21);
            this.PlantationLabel.TabIndex = 37;
            this.PlantationLabel.Text = "Plantation:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(19, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.AddressLabel.Location = new System.Drawing.Point(45, 177);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(68, 21);
            this.AddressLabel.TabIndex = 34;
            this.AddressLabel.Text = "Adresse:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(19, 536);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // btnClearReset
            // 
            this.btnClearReset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClearReset.FlatAppearance.BorderSize = 0;
            this.btnClearReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnClearReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnClearReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearReset.Location = new System.Drawing.Point(138, 469);
            this.btnClearReset.Name = "btnClearReset";
            this.btnClearReset.Size = new System.Drawing.Size(90, 30);
            this.btnClearReset.TabIndex = 6;
            this.btnClearReset.Text = "Vider";
            this.btnClearReset.UseVisualStyleBackColor = false;
            // 
            // txtFarmAddress
            // 
            this.txtFarmAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFarmAddress.Location = new System.Drawing.Point(45, 201);
            this.txtFarmAddress.Name = "txtFarmAddress";
            this.txtFarmAddress.Size = new System.Drawing.Size(160, 29);
            this.txtFarmAddress.TabIndex = 2;
            // 
            // nameFarmErrorLabel
            // 
            this.nameFarmErrorLabel.AutoSize = true;
            this.nameFarmErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameFarmErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameFarmErrorLabel.Location = new System.Drawing.Point(187, 107);
            this.nameFarmErrorLabel.Name = "nameFarmErrorLabel";
            this.nameFarmErrorLabel.Size = new System.Drawing.Size(28, 37);
            this.nameFarmErrorLabel.TabIndex = 31;
            this.nameFarmErrorLabel.Text = "*";
            this.nameFarmErrorLabel.Visible = false;
            // 
            // addressFarmErrorLabel
            // 
            this.addressFarmErrorLabel.AutoSize = true;
            this.addressFarmErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressFarmErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.addressFarmErrorLabel.Location = new System.Drawing.Point(187, 175);
            this.addressFarmErrorLabel.Name = "addressFarmErrorLabel";
            this.addressFarmErrorLabel.Size = new System.Drawing.Size(28, 37);
            this.addressFarmErrorLabel.TabIndex = 32;
            this.addressFarmErrorLabel.Text = "*";
            this.addressFarmErrorLabel.Visible = false;
            // 
            // panelDisplayFarm
            // 
            this.panelDisplayFarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDisplayFarm.Controls.Add(this.FarmDataGridView);
            this.panelDisplayFarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayFarm.Location = new System.Drawing.Point(250, 0);
            this.panelDisplayFarm.Name = "panelDisplayFarm";
            this.panelDisplayFarm.Size = new System.Drawing.Size(926, 730);
            this.panelDisplayFarm.TabIndex = 41;
            // 
            // FarmDataGridView
            // 
            this.FarmDataGridView.AllowUserToAddRows = false;
            this.FarmDataGridView.AllowUserToDeleteRows = false;
            this.FarmDataGridView.AllowUserToOrderColumns = true;
            this.FarmDataGridView.AllowUserToResizeColumns = false;
            this.FarmDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.FarmDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FarmDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FarmDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FarmDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FarmDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FarmDataGridView.ColumnHeadersHeight = 36;
            this.FarmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FarmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FarmId,
            this.FarmName,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FarmDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FarmDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FarmDataGridView.EnableHeadersVisualStyles = false;
            this.FarmDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FarmDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FarmDataGridView.Name = "FarmDataGridView";
            this.FarmDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FarmDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.FarmDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FarmDataGridView.RowTemplate.Height = 25;
            this.FarmDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FarmDataGridView.Size = new System.Drawing.Size(922, 726);
            this.FarmDataGridView.TabIndex = 3;
            // 
            // FarmId
            // 
            this.FarmId.DataPropertyName = "FarmId";
            this.FarmId.HeaderText = "FarmId";
            this.FarmId.Name = "FarmId";
            this.FarmId.ReadOnly = true;
            this.FarmId.Visible = false;
            // 
            // FarmName
            // 
            this.FarmName.DataPropertyName = "FarmName";
            this.FarmName.HeaderText = "Champs";
            this.FarmName.MinimumWidth = 200;
            this.FarmName.Name = "FarmName";
            this.FarmName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FarmAddress";
            this.dataGridViewTextBoxColumn1.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 260;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FarmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1176, 730);
            this.Controls.Add(this.pnlFarmManager);
            this.Name = "FarmManager";
            this.Text = "FarmManager";
            this.pnlFarmManager.ResumeLayout(false);
            this.pnlAddFarm.ResumeLayout(false);
            this.pnlAddFarm.PerformLayout();
            this.panelDisplayFarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FarmDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFarmManager;
        private System.Windows.Forms.Panel panelDisplayFarm;
        private System.Windows.Forms.DataGridView FarmDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FarmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FarmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pnlAddFarm;
        private System.Windows.Forms.Label ChampLabel;
        private System.Windows.Forms.DateTimePicker dateHarvestDate;
        private System.Windows.Forms.DateTimePicker datePlantingDate;
        private System.Windows.Forms.Label HarvestLabel;
        private System.Windows.Forms.ComboBox cmbxFarmName;
        private System.Windows.Forms.Label PlantationLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearReset;
        private System.Windows.Forms.TextBox txtFarmAddress;
        private System.Windows.Forms.Label nameFarmErrorLabel;
        private System.Windows.Forms.Label addressFarmErrorLabel;
    }
}