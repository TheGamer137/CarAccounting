using System.Windows.Forms;

namespace CarAccounting.Views
{
    partial class AddOrEditCarView
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
            this.textBoxServices = new System.Windows.Forms.TextBox();
            this.typeOfWorkLabel = new System.Windows.Forms.Label();
            this.engineTypeLabel = new System.Windows.Forms.Label();
            this.comboBoxEngineType = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.carNumberPlateLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carMarkLabel = new System.Windows.Forms.Label();
            this.dateOfWorkLabel = new System.Windows.Forms.Label();
            this.textBoxNumberPlate = new System.Windows.Forms.TextBox();
            this.textBoxCarMark = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.textBoxDateOfWork = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxServices
            // 
            this.textBoxServices.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxServices.Location = new System.Drawing.Point(381, 232);
            this.textBoxServices.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxServices.Name = "textBoxServices";
            this.textBoxServices.Size = new System.Drawing.Size(296, 30);
            this.textBoxServices.TabIndex = 8;
            // 
            // typeOfWorkLabel
            // 
            this.typeOfWorkLabel.AutoSize = true;
            this.typeOfWorkLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.typeOfWorkLabel.Location = new System.Drawing.Point(381, 209);
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
            this.engineTypeLabel.Location = new System.Drawing.Point(381, 140);
            this.engineTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engineTypeLabel.Name = "engineTypeLabel";
            this.engineTypeLabel.Size = new System.Drawing.Size(168, 22);
            this.engineTypeLabel.TabIndex = 11;
            this.engineTypeLabel.Text = "Модель двигателя:";
            // 
            // comboBoxEngineType
            // 
            this.comboBoxEngineType.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxEngineType.FormattingEnabled = true;
            this.comboBoxEngineType.Location = new System.Drawing.Point(381, 166);
            this.comboBoxEngineType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEngineType.Name = "comboBoxEngineType";
            this.comboBoxEngineType.Size = new System.Drawing.Size(296, 30);
            this.comboBoxEngineType.TabIndex = 12;
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
            // carNumberPlateLabel
            // 
            this.carNumberPlateLabel.AutoSize = true;
            this.carNumberPlateLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.carNumberPlateLabel.Location = new System.Drawing.Point(13, 209);
            this.carNumberPlateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carNumberPlateLabel.Name = "carNumberPlateLabel";
            this.carNumberPlateLabel.Size = new System.Drawing.Size(184, 22);
            this.carNumberPlateLabel.TabIndex = 5;
            this.carNumberPlateLabel.Text = "Гос. номер машины:";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.carModelLabel.Location = new System.Drawing.Point(13, 140);
            this.carModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(156, 22);
            this.carModelLabel.TabIndex = 3;
            this.carModelLabel.Text = "Модель машины:";
            // 
            // carMarkLabel
            // 
            this.carMarkLabel.AutoSize = true;
            this.carMarkLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.carMarkLabel.Location = new System.Drawing.Point(13, 72);
            this.carMarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carMarkLabel.Name = "carMarkLabel";
            this.carMarkLabel.Size = new System.Drawing.Size(147, 22);
            this.carMarkLabel.TabIndex = 0;
            this.carMarkLabel.Text = "Марка машины:";
            // 
            // dateOfWorkLabel
            // 
            this.dateOfWorkLabel.AutoSize = true;
            this.dateOfWorkLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateOfWorkLabel.Location = new System.Drawing.Point(381, 72);
            this.dateOfWorkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfWorkLabel.Name = "dateOfWorkLabel";
            this.dateOfWorkLabel.Size = new System.Drawing.Size(109, 22);
            this.dateOfWorkLabel.TabIndex = 9;
            this.dateOfWorkLabel.Text = "Дата работ:";
            // 
            // textBoxNumberPlate
            // 
            this.textBoxNumberPlate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxNumberPlate.Location = new System.Drawing.Point(13, 232);
            this.textBoxNumberPlate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumberPlate.Name = "textBoxNumberPlate";
            this.textBoxNumberPlate.Size = new System.Drawing.Size(296, 30);
            this.textBoxNumberPlate.TabIndex = 6;
            // 
            // textBoxCarMark
            // 
            this.textBoxCarMark.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxCarMark.Location = new System.Drawing.Point(13, 163);
            this.textBoxCarMark.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarMark.Name = "textBoxCarMark";
            this.textBoxCarMark.Size = new System.Drawing.Size(296, 30);
            this.textBoxCarMark.TabIndex = 4;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.carModelTextBox.Location = new System.Drawing.Point(13, 95);
            this.carModelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(296, 30);
            this.carModelTextBox.TabIndex = 2;
            // 
            // textBoxDateOfWork
            // 
            this.textBoxDateOfWork.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxDateOfWork.Location = new System.Drawing.Point(381, 95);
            this.textBoxDateOfWork.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDateOfWork.Name = "textBoxDateOfWork";
            this.textBoxDateOfWork.Size = new System.Drawing.Size(296, 30);
            this.textBoxDateOfWork.TabIndex = 10;
            // 
            // AddOrEditCarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 480);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBoxEngineType);
            this.Controls.Add(this.engineTypeLabel);
            this.Controls.Add(this.textBoxDateOfWork);
            this.Controls.Add(this.dateOfWorkLabel);
            this.Controls.Add(this.textBoxServices);
            this.Controls.Add(this.typeOfWorkLabel);
            this.Controls.Add(this.textBoxNumberPlate);
            this.Controls.Add(this.carNumberPlateLabel);
            this.Controls.Add(this.textBoxCarMark);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.carMarkLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrEditCarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrEditServicesView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxServices;
        private Label typeOfWorkLabel;
        private Label engineTypeLabel;
        private ComboBox comboBoxEngineType;
        private Button saveButton;
        private Button cancelButton;
        private Label carNumberPlateLabel;
        private Label carModelLabel;
        private Label carMarkLabel;
        private Label dateOfWorkLabel;
        private TextBox textBoxNumberPlate;
        private TextBox textBoxCarMark;
        private TextBox carModelTextBox;
        private TextBox textBoxDateOfWork;
    }
}