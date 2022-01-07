namespace Internet_Service_Provider.Controls.Contract
{
    partial class ContractControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableContracts = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowWindowCreater = new System.Windows.Forms.Button();
            this.SyncCommandButton = new System.Windows.Forms.Button();
            this.PrintReport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.refreshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableContracts)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableContracts
            // 
            this.tableContracts.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableContracts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tableContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableContracts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableContracts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableContracts.DefaultCellStyle = dataGridViewCellStyle8;
            this.tableContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContracts.Location = new System.Drawing.Point(5, 64);
            this.tableContracts.Margin = new System.Windows.Forms.Padding(5);
            this.tableContracts.Name = "tableContracts";
            this.tableContracts.ReadOnly = true;
            this.tableContracts.Size = new System.Drawing.Size(722, 402);
            this.tableContracts.TabIndex = 0;
            this.tableContracts.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tableContracts_DataError);
            this.tableContracts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tableContracts_EditingControlShowing);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.ShowWindowCreater);
            this.flowLayoutPanel1.Controls.Add(this.SyncCommandButton);
            this.flowLayoutPanel1.Controls.Add(this.refreshTable);
            this.flowLayoutPanel1.Controls.Add(this.PrintReport);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 53);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ShowWindowCreater
            // 
            this.ShowWindowCreater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ShowWindowCreater.FlatAppearance.BorderSize = 0;
            this.ShowWindowCreater.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ShowWindowCreater.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.ShowWindowCreater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowWindowCreater.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowWindowCreater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.ShowWindowCreater.Location = new System.Drawing.Point(3, 3);
            this.ShowWindowCreater.Name = "ShowWindowCreater";
            this.ShowWindowCreater.Size = new System.Drawing.Size(45, 45);
            this.ShowWindowCreater.TabIndex = 2;
            this.ShowWindowCreater.Text = "+";
            this.ShowWindowCreater.UseVisualStyleBackColor = false;
            // 
            // SyncCommandButton
            // 
            this.SyncCommandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SyncCommandButton.BackgroundImage = global::Internet_Service_Provider.Properties.Resources.ExampleIcon;
            this.SyncCommandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SyncCommandButton.FlatAppearance.BorderSize = 0;
            this.SyncCommandButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SyncCommandButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.SyncCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncCommandButton.Location = new System.Drawing.Point(54, 3);
            this.SyncCommandButton.Name = "SyncCommandButton";
            this.SyncCommandButton.Size = new System.Drawing.Size(45, 45);
            this.SyncCommandButton.TabIndex = 1;
            this.SyncCommandButton.UseVisualStyleBackColor = false;
            // 
            // PrintReport
            // 
            this.PrintReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.PrintReport.BackgroundImage = global::Internet_Service_Provider.Properties.Resources.New_DocMini1;
            this.PrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrintReport.FlatAppearance.BorderSize = 0;
            this.PrintReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PrintReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.PrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintReport.Location = new System.Drawing.Point(156, 3);
            this.PrintReport.Name = "PrintReport";
            this.PrintReport.Size = new System.Drawing.Size(45, 45);
            this.PrintReport.TabIndex = 3;
            this.PrintReport.UseVisualStyleBackColor = false;
            this.PrintReport.Click += new System.EventHandler(this.PrintReport_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableContracts, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 471);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // refreshTable
            // 
            this.refreshTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.refreshTable.BackgroundImage = global::Internet_Service_Provider.Properties.Resources.refresh;
            this.refreshTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshTable.FlatAppearance.BorderSize = 0;
            this.refreshTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.refreshTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.refreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshTable.Location = new System.Drawing.Point(105, 3);
            this.refreshTable.Name = "refreshTable";
            this.refreshTable.Size = new System.Drawing.Size(45, 45);
            this.refreshTable.TabIndex = 4;
            this.refreshTable.UseVisualStyleBackColor = false;
            this.refreshTable.Click += new System.EventHandler(this.refreshTable_Click);
            // 
            // ContractControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ContractControl";
            this.Size = new System.Drawing.Size(732, 471);
            this.VisibleChanged += new System.EventHandler(this.ContractControl_VisibleChanged);
            this.Enter += new System.EventHandler(this.ContractControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tableContracts)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableContracts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SyncCommandButton;
        private System.Windows.Forms.Button ShowWindowCreater;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PrintReport;
        private System.Windows.Forms.Button refreshTable;
    }
}
