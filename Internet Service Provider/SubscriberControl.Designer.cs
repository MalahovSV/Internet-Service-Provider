namespace Internet_Service_Provider
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
            ((System.ComponentModel.ISupportInitialize)(this.tableSubscriber)).BeginInit();
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
            this.tableSubscriber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableSubscriber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableSubscriber.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableSubscriber.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSubscriber.Location = new System.Drawing.Point(0, 0);
            this.tableSubscriber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableSubscriber.Name = "tableSubscriber";
            this.tableSubscriber.Size = new System.Drawing.Size(732, 293);
            this.tableSubscriber.TabIndex = 0;
            // 
            // SubscriberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableSubscriber);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SubscriberControl";
            this.Size = new System.Drawing.Size(732, 471);
            ((System.ComponentModel.ISupportInitialize)(this.tableSubscriber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableSubscriber;
    }
}
