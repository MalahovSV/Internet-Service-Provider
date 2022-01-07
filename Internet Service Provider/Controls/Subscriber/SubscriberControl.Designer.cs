namespace Internet_Service_Provider.Controls.Subscriber
{
    partial class SubscriberControl
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
            this.tableSubscriber = new System.Windows.Forms.DataGridView();
            this.RefreshTable = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SyncCommandButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tableSubscriber)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSubscriber
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableSubscriber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableSubscriber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableSubscriber.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableSubscriber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableSubscriber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableSubscriber.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableSubscriber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSubscriber.Location = new System.Drawing.Point(5, 64);
            this.tableSubscriber.Margin = new System.Windows.Forms.Padding(5);
            this.tableSubscriber.Name = "tableSubscriber";
            this.tableSubscriber.Size = new System.Drawing.Size(722, 402);
            this.tableSubscriber.TabIndex = 0;
            // 
            // RefreshTable
            // 
            this.RefreshTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.RefreshTable.BackgroundImage = global::Internet_Service_Provider.Properties.Resources.refresh;
            this.RefreshTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshTable.FlatAppearance.BorderSize = 0;
            this.RefreshTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RefreshTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.RefreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshTable.Location = new System.Drawing.Point(54, 3);
            this.RefreshTable.Name = "RefreshTable";
            this.RefreshTable.Size = new System.Drawing.Size(45, 45);
            this.RefreshTable.TabIndex = 2;
            this.RefreshTable.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.SyncCommandButton);
            this.flowLayoutPanel1.Controls.Add(this.RefreshTable);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 53);
            this.flowLayoutPanel1.TabIndex = 3;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableSubscriber, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 471);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SubscriberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SubscriberControl";
            this.Size = new System.Drawing.Size(732, 471);
            ((System.ComponentModel.ISupportInitialize)(this.tableSubscriber)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableSubscriber;
        private System.Windows.Forms.Button SyncCommandButton;
        private System.Windows.Forms.Button RefreshTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
