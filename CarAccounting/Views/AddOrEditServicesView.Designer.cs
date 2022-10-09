using System.Windows.Forms;

namespace CarAccounting.Views
{
    partial class AddOrEditServicesView
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.typeOfWorkLabel = new System.Windows.Forms.Label();
            this.engineTypeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox3.Location = new System.Drawing.Point(381, 178);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(296, 30);
            this.textBox3.TabIndex = 8;
            // 
            // typeOfWorkLabel
            // 
            this.typeOfWorkLabel.AutoSize = true;
            this.typeOfWorkLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.typeOfWorkLabel.Location = new System.Drawing.Point(381, 155);
            this.typeOfWorkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeOfWorkLabel.Name = "typeOfWorkLabel";
            this.typeOfWorkLabel.Size = new System.Drawing.Size(220, 22);
            this.typeOfWorkLabel.TabIndex = 7;
            this.typeOfWorkLabel.Text = "Тип проведенных работ:";
            // 
            // engineTypeLabel
            // 
            this.engineTypeLabel.AutoSize = true;
            this.engineTypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.engineTypeLabel.Location = new System.Drawing.Point(15, 152);
            this.engineTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engineTypeLabel.Name = "engineTypeLabel";
            this.engineTypeLabel.Size = new System.Drawing.Size(168, 22);
            this.engineTypeLabel.TabIndex = 11;
            this.engineTypeLabel.Text = "Модель двигателя:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 178);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(296, 30);
            this.comboBox1.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.saveButton.Location = new System.Drawing.Point(179, 377);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 36);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cancelButton.Location = new System.Drawing.Point(381, 377);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 36);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddOrEditServicesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 480);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.engineTypeLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.typeOfWorkLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrEditServicesView";
            this.Text = "NewCarView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox3;
        private Label typeOfWorkLabel;
        private Label engineTypeLabel;
        private ComboBox comboBox1;
        private Button saveButton;
        private Button cancelButton;
    }
}