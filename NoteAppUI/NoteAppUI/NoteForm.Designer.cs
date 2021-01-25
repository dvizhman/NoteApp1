
namespace NoteAppUI
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNoteCategory = new System.Windows.Forms.Label();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.dateTimePickerCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.labelModifiedAt = new System.Windows.Forms.Label();
            this.dateTimePickerModifiedAt = new System.Windows.Forms.DateTimePicker();
            this.textBoxNoteText = new System.Windows.Forms.TextBox();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.файлToolStripMenuItem, this.редактированиеToolStripMenuItem, this.помощьToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.создатьЗаметкуToolStripMenuItem, this.редактироватьЗаметкуToolStripMenuItem,
                this.удалитьЗаметкуToolStripMenuItem
            });
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer.Panel1MinSize = 200;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.textBoxNoteText);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePickerModifiedAt);
            this.splitContainer.Panel2.Controls.Add(this.labelModifiedAt);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePickerCreatedAt);
            this.splitContainer.Panel2.Controls.Add(this.labelCreatedAt);
            this.splitContainer.Panel2.Controls.Add(this.labelNoteCategory);
            this.splitContainer.Panel2.Controls.Add(this.labelName);
            this.splitContainer.Panel2MinSize = 228;
            this.splitContainer.Size = new System.Drawing.Size(599, 312);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxNotes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.comboBoxCategory);
            this.panelCategory.Controls.Add(this.labelCategory);
            this.panelCategory.Location = new System.Drawing.Point(0, 0);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(0);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(194, 27);
            this.panelCategory.TabIndex = 0;
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(3, 2);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(67, 21);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Категория:";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(76, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(115, 21);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(3, 30);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(188, 238);
            this.listBoxNotes.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Location = new System.Drawing.Point(0, 276);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(194, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(24, 24);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "button1";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelName.Location = new System.Drawing.Point(7, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(379, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название заметки";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNoteCategory
            // 
            this.labelNoteCategory.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoteCategory.Location = new System.Drawing.Point(7, 26);
            this.labelNoteCategory.Name = "labelNoteCategory";
            this.labelNoteCategory.Size = new System.Drawing.Size(379, 25);
            this.labelNoteCategory.TabIndex = 1;
            this.labelNoteCategory.Text = "Категория: ";
            this.labelNoteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.Location = new System.Drawing.Point(7, 51);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(60, 21);
            this.labelCreatedAt.TabIndex = 2;
            this.labelCreatedAt.Text = "Создано:";
            this.labelCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerCreatedAt
            // 
            this.dateTimePickerCreatedAt.Enabled = false;
            this.dateTimePickerCreatedAt.Location = new System.Drawing.Point(73, 51);
            this.dateTimePickerCreatedAt.Name = "dateTimePickerCreatedAt";
            this.dateTimePickerCreatedAt.Size = new System.Drawing.Size(122, 21);
            this.dateTimePickerCreatedAt.TabIndex = 3;
            // 
            // labelModifiedAt
            // 
            this.labelModifiedAt.Location = new System.Drawing.Point(201, 51);
            this.labelModifiedAt.Name = "labelModifiedAt";
            this.labelModifiedAt.Size = new System.Drawing.Size(60, 21);
            this.labelModifiedAt.TabIndex = 4;
            this.labelModifiedAt.Text = "Изменено:";
            this.labelModifiedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerModifiedAt
            // 
            this.dateTimePickerModifiedAt.Enabled = false;
            this.dateTimePickerModifiedAt.Location = new System.Drawing.Point(267, 51);
            this.dateTimePickerModifiedAt.Name = "dateTimePickerModifiedAt";
            this.dateTimePickerModifiedAt.Size = new System.Drawing.Size(122, 21);
            this.dateTimePickerModifiedAt.TabIndex = 5;
            // 
            // textBoxNoteText
            // 
            this.textBoxNoteText.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNoteText.Location = new System.Drawing.Point(3, 88);
            this.textBoxNoteText.MaxLength = 65535;
            this.textBoxNoteText.Multiline = true;
            this.textBoxNoteText.Name = "textBoxNoteText";
            this.textBoxNoteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNoteText.Size = new System.Drawing.Size(392, 221);
            this.textBoxNoteText.TabIndex = 6;
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // создатьЗаметкуToolStripMenuItem
            // 
            this.создатьЗаметкуToolStripMenuItem.Name = "создатьЗаметкуToolStripMenuItem";
            this.создатьЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.создатьЗаметкуToolStripMenuItem.Text = "Создать заметку";
            // 
            // редактироватьЗаметкуToolStripMenuItem
            // 
            this.редактироватьЗаметкуToolStripMenuItem.Name = "редактироватьЗаметкуToolStripMenuItem";
            this.редактироватьЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.редактироватьЗаметкуToolStripMenuItem.Text = "Редактировать заметку";
            // 
            // удалитьЗаметкуToolStripMenuItem
            // 
            this.удалитьЗаметкуToolStripMenuItem.Name = "удалитьЗаметкуToolStripMenuItem";
            this.удалитьЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.удалитьЗаметкуToolStripMenuItem.Text = "Удалить заметку";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 336);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(615, 375);
            this.Name = "Form1";
            this.Text = "Заметки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelCategory.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNoteCategory;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Label labelModifiedAt;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedAt;
        private System.Windows.Forms.DateTimePicker dateTimePickerModifiedAt;
        private System.Windows.Forms.TextBox textBoxNoteText;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

