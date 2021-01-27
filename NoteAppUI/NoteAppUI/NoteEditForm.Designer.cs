using System.ComponentModel;

namespace NoteAppUI
{
    partial class NoteEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelName = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.dateTimePickerCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.labelModifiedAt = new System.Windows.Forms.Label();
            this.dateTimePickerModifiedAt = new System.Windows.Forms.DateTimePicker();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(118, 11);
            this.textBox_Name.MaxLength = 50;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(354, 21);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(12, 32);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(100, 23);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Категория";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(118, 34);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(116, 21);
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.Location = new System.Drawing.Point(12, 55);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(100, 23);
            this.labelCreatedAt.TabIndex = 4;
            this.labelCreatedAt.Text = "Создана";
            this.labelCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerCreatedAt
            // 
            this.dateTimePickerCreatedAt.Enabled = false;
            this.dateTimePickerCreatedAt.Location = new System.Drawing.Point(118, 57);
            this.dateTimePickerCreatedAt.Name = "dateTimePickerCreatedAt";
            this.dateTimePickerCreatedAt.Size = new System.Drawing.Size(116, 21);
            this.dateTimePickerCreatedAt.TabIndex = 5;
            // 
            // labelModifiedAt
            // 
            this.labelModifiedAt.Location = new System.Drawing.Point(240, 55);
            this.labelModifiedAt.Name = "labelModifiedAt";
            this.labelModifiedAt.Size = new System.Drawing.Size(100, 23);
            this.labelModifiedAt.TabIndex = 6;
            this.labelModifiedAt.Text = "Изменена";
            this.labelModifiedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerModifiedAt
            // 
            this.dateTimePickerModifiedAt.Enabled = false;
            this.dateTimePickerModifiedAt.Location = new System.Drawing.Point(346, 57);
            this.dateTimePickerModifiedAt.Name = "dateTimePickerModifiedAt";
            this.dateTimePickerModifiedAt.Size = new System.Drawing.Size(116, 21);
            this.dateTimePickerModifiedAt.TabIndex = 7;
            // 
            // textBox_Text
            // 
            this.textBox_Text.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Text.Location = new System.Drawing.Point(12, 81);
            this.textBox_Text.MaxLength = 65535;
            this.textBox_Text.Multiline = true;
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Text.Size = new System.Drawing.Size(460, 285);
            this.textBox_Text.TabIndex = 8;
            this.textBox_Text.TextChanged += new System.EventHandler(this.textBox_Text_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(403, 372);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 22);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(328, 372);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(69, 22);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // NoteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 406);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.dateTimePickerModifiedAt);
            this.Controls.Add(this.labelModifiedAt);
            this.Controls.Add(this.dateTimePickerCreatedAt);
            this.Controls.Add(this.labelCreatedAt);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.labelName);
            this.MinimumSize = new System.Drawing.Size(500, 345);
            this.Name = "NoteEditForm";
            this.Text = "Редактирование заметки";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Label labelModifiedAt;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedAt;
        private System.Windows.Forms.DateTimePicker dateTimePickerModifiedAt;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBox_Text;
    }
}