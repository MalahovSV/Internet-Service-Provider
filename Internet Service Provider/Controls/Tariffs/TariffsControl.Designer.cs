namespace Internet_Service_Provider.Controls.Tariffs
{
    partial class TariffsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableTariffs = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SyncCommandButton = new System.Windows.Forms.Button();
            this.refreshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableTariffs)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableTariffs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableTariffs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableTariffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableTariffs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tableTariffs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableTariffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableTariffs.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableTariffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTariffs.Location = new System.Drawing.Point(5, 64);
            this.tableTariffs.Margin = new System.Windows.Forms.Padding(5);
            this.tableTariffs.Name = "tableTariffs";
            this.tableTariffs.Size = new System.Drawing.Size(722, 402);
            this.tableTariffs.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.SyncCommandButton);
            this.flowLayoutPanel1.Controls.Add(this.refreshTable);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 53);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableTariffs, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 471);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.SyncCommandButton.Location = new System.Drawing.Point(3, 3);
            this.SyncCommandButton.Name = "SyncCommandButton";
            this.SyncCommandButton.Size = new System.Drawing.Size(45, 45);
            this.SyncCommandButton.TabIndex = 1;
            this.SyncCommandButton.UseVisualStyleBackColor = false;
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
            this.refreshTable.Location = new System.Drawing.Point(54, 3);
            this.refreshTable.Name = "refreshTable";
            this.refreshTable.Size = new System.Drawing.Size(45, 45);
            this.refreshTable.TabIndex = 2;
            this.refreshTable.UseVisualStyleBackColor = false;
            // 
            // TariffsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TariffsControl";
            this.Size = new System.Drawing.Size(732, 471);
            ((System.ComponentModel.ISupportInitialize)(this.tableTariffs)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableTariffs;
        private System.Windows.Forms.Button SyncCommandButton;
        private System.Windows.Forms.Button refreshTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
