
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFarmManager = new System.Windows.Forms.Panel();
            this.panelDisplayFarm = new System.Windows.Forms.Panel();
            this.FarmDataGridView = new System.Windows.Forms.DataGridView();
            this.pnlAddFarm = new System.Windows.Forms.Panel();
            this.ChampLabel = new System.Windows.Forms.Label();
            this.dateHarvestDate = new System.Windows.Forms.DateTimePicker();
            this.datePlantingDate = new System.Windows.Forms.DateTimePicker();
            this.HarvestLabel = new System.Windows.Forms.Label();
            this.PlantationLabel = new System.Windows.Forms.Label();
            this.btnSaveFarm = new System.Windows.Forms.Button();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearReset = new System.Windows.Forms.Button();
            this.txtFarmAddress = new System.Windows.Forms.TextBox();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlantingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHarvestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFarmArea = new System.Windows.Forms.TextBox();
            this.txtFarmName = new System.Windows.Forms.TextBox();
            this.pnlFarmManager.SuspendLayout();
            this.panelDisplayFarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FarmDataGridView)).BeginInit();
            this.pnlAddFarm.SuspendLayout();
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
            this.pnlFarmManager.Size = new System.Drawing.Size(1241, 730);
            this.pnlFarmManager.TabIndex = 0;
            // 
            // panelDisplayFarm
            // 
            this.panelDisplayFarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDisplayFarm.Controls.Add(this.FarmDataGridView);
            this.panelDisplayFarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayFarm.Location = new System.Drawing.Point(259, 0);
            this.panelDisplayFarm.Name = "panelDisplayFarm";
            this.panelDisplayFarm.Size = new System.Drawing.Size(982, 730);
            this.panelDisplayFarm.TabIndex = 41;
            // 
            // FarmDataGridView
            // 
            this.FarmDataGridView.AllowUserToAddRows = false;
            this.FarmDataGridView.AllowUserToDeleteRows = false;
            this.FarmDataGridView.AllowUserToOrderColumns = true;
            this.FarmDataGridView.AllowUserToResizeColumns = false;
            this.FarmDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.FarmDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.FarmDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FarmDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FarmDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FarmDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.FarmDataGridView.ColumnHeadersHeight = 36;
            this.FarmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FarmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnArea,
            this.ColumnPlantingDate,
            this.ColumnHarvestDate});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FarmDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.FarmDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FarmDataGridView.EnableHeadersVisualStyles = false;
            this.FarmDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FarmDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FarmDataGridView.Name = "FarmDataGridView";
            this.FarmDataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.FarmDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.FarmDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.FarmDataGridView.RowTemplate.Height = 25;
            this.FarmDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FarmDataGridView.Size = new System.Drawing.Size(978, 726);
            this.FarmDataGridView.TabIndex = 3;
            this.FarmDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FarmDataGridView_CellDoubleClick);
            // 
            // pnlAddFarm
            // 
            this.pnlAddFarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddFarm.Controls.Add(this.txtFarmName);
            this.pnlAddFarm.Controls.Add(this.label1);
            this.pnlAddFarm.Controls.Add(this.txtFarmArea);
            this.pnlAddFarm.Controls.Add(this.ChampLabel);
            this.pnlAddFarm.Controls.Add(this.dateHarvestDate);
            this.pnlAddFarm.Controls.Add(this.datePlantingDate);
            this.pnlAddFarm.Controls.Add(this.HarvestLabel);
            this.pnlAddFarm.Controls.Add(this.PlantationLabel);
            this.pnlAddFarm.Controls.Add(this.btnSaveFarm);
            this.pnlAddFarm.Controls.Add(this.AddressLabel);
            this.pnlAddFarm.Controls.Add(this.btnDelete);
            this.pnlAddFarm.Controls.Add(this.btnClearReset);
            this.pnlAddFarm.Controls.Add(this.txtFarmAddress);
            this.pnlAddFarm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddFarm.Location = new System.Drawing.Point(0, 0);
            this.pnlAddFarm.Name = "pnlAddFarm";
            this.pnlAddFarm.Size = new System.Drawing.Size(259, 730);
            this.pnlAddFarm.TabIndex = 40;
            // 
            // ChampLabel
            // 
            this.ChampLabel.AutoSize = true;
            this.ChampLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChampLabel.ForeColor = System.Drawing.Color.White;
            this.ChampLabel.Location = new System.Drawing.Point(45, 79);
            this.ChampLabel.Name = "ChampLabel";
            this.ChampLabel.Size = new System.Drawing.Size(63, 21);
            this.ChampLabel.TabIndex = 29;
            this.ChampLabel.Text = "Champ:";
            // 
            // dateHarvestDate
            // 
            this.dateHarvestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHarvestDate.Location = new System.Drawing.Point(45, 392);
            this.dateHarvestDate.Name = "dateHarvestDate";
            this.dateHarvestDate.Size = new System.Drawing.Size(160, 23);
            this.dateHarvestDate.TabIndex = 4;
            // 
            // datePlantingDate
            // 
            this.datePlantingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePlantingDate.Location = new System.Drawing.Point(45, 319);
            this.datePlantingDate.Name = "datePlantingDate";
            this.datePlantingDate.Size = new System.Drawing.Size(160, 23);
            this.datePlantingDate.TabIndex = 3;
            // 
            // HarvestLabel
            // 
            this.HarvestLabel.AutoSize = true;
            this.HarvestLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HarvestLabel.ForeColor = System.Drawing.Color.White;
            this.HarvestLabel.Location = new System.Drawing.Point(45, 368);
            this.HarvestLabel.Name = "HarvestLabel";
            this.HarvestLabel.Size = new System.Drawing.Size(64, 21);
            this.HarvestLabel.TabIndex = 38;
            this.HarvestLabel.Text = "Récolte:";
            // 
            // PlantationLabel
            // 
            this.PlantationLabel.AutoSize = true;
            this.PlantationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlantationLabel.ForeColor = System.Drawing.Color.White;
            this.PlantationLabel.Location = new System.Drawing.Point(45, 294);
            this.PlantationLabel.Name = "PlantationLabel";
            this.PlantationLabel.Size = new System.Drawing.Size(83, 21);
            this.PlantationLabel.TabIndex = 37;
            this.PlantationLabel.Text = "Plantation:";
            // 
            // btnSaveFarm
            // 
            this.btnSaveFarm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveFarm.FlatAppearance.BorderSize = 0;
            this.btnSaveFarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnSaveFarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSaveFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFarm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveFarm.Location = new System.Drawing.Point(19, 469);
            this.btnSaveFarm.Name = "btnSaveFarm";
            this.btnSaveFarm.Size = new System.Drawing.Size(90, 30);
            this.btnSaveFarm.TabIndex = 5;
            this.btnSaveFarm.Text = "Ajouter";
            this.btnSaveFarm.UseVisualStyleBackColor = false;
            this.btnSaveFarm.Click += new System.EventHandler(this.btnSaveFarm_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.AddressLabel.Location = new System.Drawing.Point(45, 149);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnClearReset.Click += new System.EventHandler(this.btnClearReset_Click);
            // 
            // txtFarmAddress
            // 
            this.txtFarmAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFarmAddress.Location = new System.Drawing.Point(45, 173);
            this.txtFarmAddress.Name = "txtFarmAddress";
            this.txtFarmAddress.Size = new System.Drawing.Size(160, 29);
            this.txtFarmAddress.TabIndex = 2;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "FarmId";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Champs";
            this.ColumnName.MinimumWidth = 200;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.DataPropertyName = "Address";
            this.ColumnAddress.HeaderText = "Adresse";
            this.ColumnAddress.MinimumWidth = 260;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnArea
            // 
            this.ColumnArea.DataPropertyName = "Area";
            this.ColumnArea.HeaderText = "Area";
            this.ColumnArea.MinimumWidth = 60;
            this.ColumnArea.Name = "ColumnArea";
            this.ColumnArea.ReadOnly = true;
            // 
            // ColumnPlantingDate
            // 
            this.ColumnPlantingDate.DataPropertyName = "PlantingDate";
            this.ColumnPlantingDate.HeaderText = "Planting Date";
            this.ColumnPlantingDate.MinimumWidth = 80;
            this.ColumnPlantingDate.Name = "ColumnPlantingDate";
            this.ColumnPlantingDate.ReadOnly = true;
            // 
            // ColumnHarvestDate
            // 
            this.ColumnHarvestDate.DataPropertyName = "HarvestDate";
            this.ColumnHarvestDate.HeaderText = "Harvest Date";
            this.ColumnHarvestDate.MinimumWidth = 80;
            this.ColumnHarvestDate.Name = "ColumnHarvestDate";
            this.ColumnHarvestDate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(45, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Superficie:";
            // 
            // txtFarmArea
            // 
            this.txtFarmArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFarmArea.Location = new System.Drawing.Point(45, 247);
            this.txtFarmArea.Name = "txtFarmArea";
            this.txtFarmArea.Size = new System.Drawing.Size(160, 29);
            this.txtFarmArea.TabIndex = 39;
            this.txtFarmArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberEntred);
            // 
            // txtFarmName
            // 
            this.txtFarmName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFarmName.Location = new System.Drawing.Point(45, 103);
            this.txtFarmName.Name = "txtFarmName";
            this.txtFarmName.Size = new System.Drawing.Size(160, 29);
            this.txtFarmName.TabIndex = 42;
            // 
            // FarmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1241, 730);
            this.Controls.Add(this.pnlFarmManager);
            this.Name = "FarmManager";
            this.Text = "FarmManager";
            this.Load += new System.EventHandler(this.FarmManager_Load);
            this.pnlFarmManager.ResumeLayout(false);
            this.panelDisplayFarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FarmDataGridView)).EndInit();
            this.pnlAddFarm.ResumeLayout(false);
            this.pnlAddFarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFarmManager;
        private System.Windows.Forms.Panel panelDisplayFarm;
        private System.Windows.Forms.DataGridView FarmDataGridView;
        private System.Windows.Forms.Panel pnlAddFarm;
        private System.Windows.Forms.Label ChampLabel;
        private System.Windows.Forms.DateTimePicker dateHarvestDate;
        private System.Windows.Forms.DateTimePicker datePlantingDate;
        private System.Windows.Forms.Label HarvestLabel;
        private System.Windows.Forms.Label PlantationLabel;
        private System.Windows.Forms.Button btnSaveFarm;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearReset;
        private System.Windows.Forms.TextBox txtFarmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlantingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHarvestDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFarmArea;
        private System.Windows.Forms.TextBox txtFarmName;
    }
}