
namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripmenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNoteText = new System.Windows.Forms.TextBox();
            this.dateTimePickerModifiedAt = new System.Windows.Forms.DateTimePicker();
            this.labelModifiedAt = new System.Windows.Forms.Label();
            this.dateTimePickerCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.labelNoteCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItemFile, this.toolStripMenuItemEditMenu, this.toolStripmenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(666, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItemExit.Text = "Выход";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemEditMenu
            // 
            this.toolStripMenuItemEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItemCreate, this.toolStripMenuItemEdit, this.toolStripMenuItemDelete});
            this.toolStripMenuItemEditMenu.Name = "toolStripMenuItemEditMenu";
            this.toolStripMenuItemEditMenu.Size = new System.Drawing.Size(112, 20);
            this.toolStripMenuItemEditMenu.Text = "Редактирование";
            // 
            // toolStripMenuItemCreate
            // 
            this.toolStripMenuItemCreate.Image = global::NoteAppUI.Icons.Icons.Add;
            this.toolStripMenuItemCreate.Name = "toolStripMenuItemCreate";
            this.toolStripMenuItemCreate.Size = new System.Drawing.Size(206, 22);
            this.toolStripMenuItemCreate.Text = "Создать заметку";
            this.toolStripMenuItemCreate.Click += new System.EventHandler(this.toolStripMenuItemCreate_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Image = global::NoteAppUI.Icons.Icons.Edit;
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(206, 22);
            this.toolStripMenuItemEdit.Text = "Редактировать заметку";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Image = global::NoteAppUI.Icons.Icons.Delete;
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(206, 22);
            this.toolStripMenuItemDelete.Text = "Удалить заметку";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // toolStripmenuItemHelp
            // 
            this.toolStripmenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripMenuItemAbout});
            this.toolStripmenuItemHelp.Name = "toolStripmenuItemHelp";
            this.toolStripmenuItemHelp.Size = new System.Drawing.Size(64, 20);
            this.toolStripmenuItemHelp.Text = "Помощь";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemAbout.Text = "О программе";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
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
            this.splitContainer.Size = new System.Drawing.Size(666, 338);
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
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 332);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.comboBoxCategory);
            this.panelCategory.Controls.Add(this.labelCategory);
            this.panelCategory.Location = new System.Drawing.Point(0, 0);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(0);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(194, 29);
            this.panelCategory.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(89, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(102, 22);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(3, 2);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(78, 23);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Категория:";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 14;
            this.listBoxNotes.Location = new System.Drawing.Point(3, 32);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(188, 256);
            this.listBoxNotes.TabIndex = 1;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            this.listBoxNotes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxNotes_KeyUp);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonRemove);
            this.panelButtons.Controls.Add(this.buttonEdit);
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Location = new System.Drawing.Point(0, 300);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(194, 32);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImage = global::NoteAppUI.Icons.Icons.Delete;
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Location = new System.Drawing.Point(73, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(28, 26);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImage = global::NoteAppUI.Icons.Icons.Edit;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(38, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(28, 26);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::NoteAppUI.Icons.Icons.Add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(28, 26);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNoteText
            // 
            this.textBoxNoteText.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNoteText.Location = new System.Drawing.Point(3, 95);
            this.textBoxNoteText.MaxLength = 65535;
            this.textBoxNoteText.Multiline = true;
            this.textBoxNoteText.Name = "textBoxNoteText";
            this.textBoxNoteText.ReadOnly = true;
            this.textBoxNoteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNoteText.Size = new System.Drawing.Size(457, 236);
            this.textBoxNoteText.TabIndex = 6;
            // 
            // dateTimePickerModifiedAt
            // 
            this.dateTimePickerModifiedAt.Enabled = false;
            this.dateTimePickerModifiedAt.Location = new System.Drawing.Point(315, 55);
            this.dateTimePickerModifiedAt.Name = "dateTimePickerModifiedAt";
            this.dateTimePickerModifiedAt.Size = new System.Drawing.Size(142, 23);
            this.dateTimePickerModifiedAt.TabIndex = 5;
            // 
            // labelModifiedAt
            // 
            this.labelModifiedAt.Location = new System.Drawing.Point(238, 55);
            this.labelModifiedAt.Name = "labelModifiedAt";
            this.labelModifiedAt.Size = new System.Drawing.Size(71, 23);
            this.labelModifiedAt.TabIndex = 4;
            this.labelModifiedAt.Text = "Изменено:";
            this.labelModifiedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerCreatedAt
            // 
            this.dateTimePickerCreatedAt.Enabled = false;
            this.dateTimePickerCreatedAt.Location = new System.Drawing.Point(85, 55);
            this.dateTimePickerCreatedAt.Name = "dateTimePickerCreatedAt";
            this.dateTimePickerCreatedAt.Size = new System.Drawing.Size(142, 23);
            this.dateTimePickerCreatedAt.TabIndex = 3;
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.Location = new System.Drawing.Point(8, 55);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(71, 23);
            this.labelCreatedAt.TabIndex = 2;
            this.labelCreatedAt.Text = "Создано:";
            this.labelCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNoteCategory
            // 
            this.labelNoteCategory.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoteCategory.Location = new System.Drawing.Point(8, 28);
            this.labelNoteCategory.Name = "labelNoteCategory";
            this.labelNoteCategory.Size = new System.Drawing.Size(452, 27);
            this.labelNoteCategory.TabIndex = 1;
            this.labelNoteCategory.Text = "Категория: ";
            this.labelNoteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelName.Location = new System.Drawing.Point(8, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(452, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название заметки";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(666, 362);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(682, 401);
            this.Name = "MainForm";
            this.Text = "Заметки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteForm_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
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

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNoteCategory;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Label labelModifiedAt;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedAt;
        private System.Windows.Forms.DateTimePicker dateTimePickerModifiedAt;
        private System.Windows.Forms.TextBox textBoxNoteText;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripmenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditMenu;
    }
}

