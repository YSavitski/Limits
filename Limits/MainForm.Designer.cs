namespace Limits
{
    partial class MainForm
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpBanks = new System.Windows.Forms.TabPage();
            this.tbpBankGroups = new System.Windows.Forms.TabPage();
            this.tbpLimitsList = new System.Windows.Forms.TabPage();
            this.tbcLimitList = new System.Windows.Forms.TabControl();
            this.tbpLimitListBanks = new System.Windows.Forms.TabPage();
            this.btnEditBank = new System.Windows.Forms.Button();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvLimitListBanks = new System.Windows.Forms.DataGridView();
            this.tbpLimitListBankGroups = new System.Windows.Forms.TabPage();
            this.tbcMain.SuspendLayout();
            this.tbpLimitsList.SuspendLayout();
            this.tbcLimitList.SuspendLayout();
            this.tbpLimitListBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimitListBanks)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpBanks);
            this.tbcMain.Controls.Add(this.tbpBankGroups);
            this.tbcMain.Controls.Add(this.tbpLimitsList);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1914, 1045);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpBanks
            // 
            this.tbpBanks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpBanks.Location = new System.Drawing.Point(4, 25);
            this.tbpBanks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpBanks.Name = "tbpBanks";
            this.tbpBanks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpBanks.Size = new System.Drawing.Size(1906, 1016);
            this.tbpBanks.TabIndex = 0;
            this.tbpBanks.Text = "Контроль лимитов. Банки";
            this.tbpBanks.UseVisualStyleBackColor = true;
            // 
            // tbpBankGroups
            // 
            this.tbpBankGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpBankGroups.Location = new System.Drawing.Point(4, 25);
            this.tbpBankGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpBankGroups.Name = "tbpBankGroups";
            this.tbpBankGroups.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpBankGroups.Size = new System.Drawing.Size(1907, 1032);
            this.tbpBankGroups.TabIndex = 1;
            this.tbpBankGroups.Text = "Контроль лимитов. Банковские группы";
            this.tbpBankGroups.UseVisualStyleBackColor = true;
            // 
            // tbpLimitsList
            // 
            this.tbpLimitsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpLimitsList.Controls.Add(this.tbcLimitList);
            this.tbpLimitsList.Location = new System.Drawing.Point(4, 25);
            this.tbpLimitsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpLimitsList.Name = "tbpLimitsList";
            this.tbpLimitsList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpLimitsList.Size = new System.Drawing.Size(1906, 1016);
            this.tbpLimitsList.TabIndex = 2;
            this.tbpLimitsList.Text = "Лимитная ведомость";
            this.tbpLimitsList.UseVisualStyleBackColor = true;
            // 
            // tbcLimitList
            // 
            this.tbcLimitList.Controls.Add(this.tbpLimitListBanks);
            this.tbcLimitList.Controls.Add(this.tbpLimitListBankGroups);
            this.tbcLimitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcLimitList.Location = new System.Drawing.Point(4, 4);
            this.tbcLimitList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcLimitList.Name = "tbcLimitList";
            this.tbcLimitList.SelectedIndex = 0;
            this.tbcLimitList.Size = new System.Drawing.Size(1894, 1004);
            this.tbcLimitList.TabIndex = 0;
            // 
            // tbpLimitListBanks
            // 
            this.tbpLimitListBanks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpLimitListBanks.Controls.Add(this.btnEditBank);
            this.tbpLimitListBanks.Controls.Add(this.btnAddBank);
            this.tbpLimitListBanks.Controls.Add(this.dateTimePicker1);
            this.tbpLimitListBanks.Controls.Add(this.dgvLimitListBanks);
            this.tbpLimitListBanks.Location = new System.Drawing.Point(4, 25);
            this.tbpLimitListBanks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpLimitListBanks.Name = "tbpLimitListBanks";
            this.tbpLimitListBanks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpLimitListBanks.Size = new System.Drawing.Size(1886, 975);
            this.tbpLimitListBanks.TabIndex = 0;
            this.tbpLimitListBanks.Text = "Лимиты на банки";
            this.tbpLimitListBanks.UseVisualStyleBackColor = true;
            // 
            // btnEditBank
            // 
            this.btnEditBank.Font = new System.Drawing.Font("Matura MT Script Capitals", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditBank.Location = new System.Drawing.Point(1672, 53);
            this.btnEditBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditBank.Name = "btnEditBank";
            this.btnEditBank.Size = new System.Drawing.Size(137, 43);
            this.btnEditBank.TabIndex = 4;
            this.btnEditBank.Text = "Edit";
            this.btnEditBank.UseVisualStyleBackColor = true;
            // 
            // btnAddBank
            // 
            this.btnAddBank.Font = new System.Drawing.Font("Matura MT Script Capitals", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBank.Location = new System.Drawing.Point(1497, 53);
            this.btnAddBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(137, 43);
            this.btnAddBank.TabIndex = 3;
            this.btnAddBank.Text = "Add";
            this.btnAddBank.UseVisualStyleBackColor = true;
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1497, 7);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dgvLimitListBanks
            // 
            this.dgvLimitListBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLimitListBanks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvLimitListBanks.Location = new System.Drawing.Point(4, 4);
            this.dgvLimitListBanks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLimitListBanks.Name = "dgvLimitListBanks";
            this.dgvLimitListBanks.ReadOnly = true;
            this.dgvLimitListBanks.Size = new System.Drawing.Size(1389, 963);
            this.dgvLimitListBanks.TabIndex = 1;
            // 
            // tbpLimitListBankGroups
            // 
            this.tbpLimitListBankGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpLimitListBankGroups.Location = new System.Drawing.Point(4, 25);
            this.tbpLimitListBankGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpLimitListBankGroups.Name = "tbpLimitListBankGroups";
            this.tbpLimitListBankGroups.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpLimitListBankGroups.Size = new System.Drawing.Size(1886, 975);
            this.tbpLimitListBankGroups.TabIndex = 1;
            this.tbpLimitListBankGroups.Text = "Лимиты на банковские группы";
            this.tbpLimitListBankGroups.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.tbcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "Limits Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbcMain.ResumeLayout(false);
            this.tbpLimitsList.ResumeLayout(false);
            this.tbcLimitList.ResumeLayout(false);
            this.tbpLimitListBanks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimitListBanks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpBanks;
        private System.Windows.Forms.TabPage tbpBankGroups;
        private System.Windows.Forms.TabPage tbpLimitsList;
        private System.Windows.Forms.TabControl tbcLimitList;
        private System.Windows.Forms.TabPage tbpLimitListBanks;
        private System.Windows.Forms.TabPage tbpLimitListBankGroups;
        private System.Windows.Forms.DataGridView dgvLimitListBanks;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEditBank;
    }
}

