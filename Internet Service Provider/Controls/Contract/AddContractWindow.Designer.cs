namespace Internet_Service_Provider.Controls.Contract
{
    partial class AddContractWindow
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
            this.addRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberContract = new System.Windows.Forms.TextBox();
            this.tariffCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateContract = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.clientCombo = new System.Windows.Forms.ComboBox();
            this.adressContract = new System.Windows.Forms.TextBox();
            this.canselOperation = new System.Windows.Forms.Button();
            this.upRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addRecord
            // 
            this.addRecord.Location = new System.Drawing.Point(141, 344);
            this.addRecord.Margin = new System.Windows.Forms.Padding(5);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(143, 45);
            this.addRecord.TabIndex = 0;
            this.addRecord.Text = "Добавить";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Visible = false;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер договора";
            // 
            // numberContract
            // 
            this.numberContract.Location = new System.Drawing.Point(221, 58);
            this.numberContract.Margin = new System.Windows.Forms.Padding(5);
            this.numberContract.Name = "numberContract";
            this.numberContract.Size = new System.Drawing.Size(331, 27);
            this.numberContract.TabIndex = 2;
            // 
            // tariffCombo
            // 
            this.tariffCombo.FormattingEnabled = true;
            this.tariffCombo.Location = new System.Drawing.Point(221, 207);
            this.tariffCombo.Margin = new System.Windows.Forms.Padding(5);
            this.tariffCombo.Name = "tariffCombo";
            this.tariffCombo.Size = new System.Drawing.Size(331, 28);
            this.tariffCombo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес подключения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Клиент";
            // 
            // dateContract
            // 
            this.dateContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateContract.Location = new System.Drawing.Point(221, 106);
            this.dateContract.Margin = new System.Windows.Forms.Padding(5);
            this.dateContract.Name = "dateContract";
            this.dateContract.Size = new System.Drawing.Size(331, 27);
            this.dateContract.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тариф";
            // 
            // clientCombo
            // 
            this.clientCombo.FormattingEnabled = true;
            this.clientCombo.Location = new System.Drawing.Point(221, 249);
            this.clientCombo.Margin = new System.Windows.Forms.Padding(5);
            this.clientCombo.Name = "clientCombo";
            this.clientCombo.Size = new System.Drawing.Size(331, 28);
            this.clientCombo.TabIndex = 8;
            // 
            // adressContract
            // 
            this.adressContract.Location = new System.Drawing.Point(221, 158);
            this.adressContract.Margin = new System.Windows.Forms.Padding(5);
            this.adressContract.Name = "adressContract";
            this.adressContract.Size = new System.Drawing.Size(331, 27);
            this.adressContract.TabIndex = 10;
            // 
            // canselOperation
            // 
            this.canselOperation.Location = new System.Drawing.Point(342, 344);
            this.canselOperation.Margin = new System.Windows.Forms.Padding(5);
            this.canselOperation.Name = "canselOperation";
            this.canselOperation.Size = new System.Drawing.Size(141, 45);
            this.canselOperation.TabIndex = 11;
            this.canselOperation.Text = "Отмена";
            this.canselOperation.UseVisualStyleBackColor = true;
            this.canselOperation.Click += new System.EventHandler(this.canselOperation_Click);
            // 
            // upRecord
            // 
            this.upRecord.Location = new System.Drawing.Point(141, 344);
            this.upRecord.Margin = new System.Windows.Forms.Padding(5);
            this.upRecord.Name = "upRecord";
            this.upRecord.Size = new System.Drawing.Size(143, 45);
            this.upRecord.TabIndex = 12;
            this.upRecord.Text = "Изменить";
            this.upRecord.UseVisualStyleBackColor = true;
            this.upRecord.Visible = false;
            // 
            // AddContractWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 441);
            this.Controls.Add(this.upRecord);
            this.Controls.Add(this.canselOperation);
            this.Controls.Add(this.adressContract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientCombo);
            this.Controls.Add(this.dateContract);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tariffCombo);
            this.Controls.Add(this.numberContract);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRecord);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddContractWindow";
            this.Text = "Добавление контракта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberContract;
        private System.Windows.Forms.ComboBox tariffCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateContract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox clientCombo;
        private System.Windows.Forms.TextBox adressContract;
        private System.Windows.Forms.Button canselOperation;
        private System.Windows.Forms.Button upRecord;
    }
}