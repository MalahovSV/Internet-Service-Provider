namespace Internet_Service_Provider.Controls
{
    partial class HelpWindow
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
            this.textComponent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textComponent
            // 
            this.textComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textComponent.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textComponent.Location = new System.Drawing.Point(0, 0);
            this.textComponent.Name = "textComponent";
            this.textComponent.ReadOnly = true;
            this.textComponent.Size = new System.Drawing.Size(651, 354);
            this.textComponent.TabIndex = 0;
            this.textComponent.Text = "Название программы: ISP.\nВерсия: v1.0001.\nРазработчик: Малахов С. В. группы ИВТ-9" +
    "1з.\nДата разработки: 20 декабря 2021 года.";
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textComponent);
            this.Name = "HelpWindow";
            this.Size = new System.Drawing.Size(651, 354);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textComponent;
    }
}
