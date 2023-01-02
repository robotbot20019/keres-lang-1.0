namespace Keres_ide_2023
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTestCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadColorCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUpdateCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createKeresWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTxtWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.autocompleteMenu1.SetAutocompleteMenu(this.fastColoredTextBox1, this.autocompleteMenu1);
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(55, 41);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 41;
            this.fastColoredTextBox1.CharWidth = 22;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.FoldingIndicatorColor = System.Drawing.Color.OrangeRed;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 27.75F);
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.Maroon;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 24);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(800, 426);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.MinFragmentLength = 1;
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.codeToolStripMenuItem,
            this.runToolStripMenuItem,
            this.keresToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardCodeToolStripMenuItem,
            this.colorCodeToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // standardCodeToolStripMenuItem
            // 
            this.standardCodeToolStripMenuItem.Name = "standardCodeToolStripMenuItem";
            this.standardCodeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.standardCodeToolStripMenuItem.Text = "Standard code";
            this.standardCodeToolStripMenuItem.Click += new System.EventHandler(this.standardCodeToolStripMenuItem_Click);
            // 
            // colorCodeToolStripMenuItem
            // 
            this.colorCodeToolStripMenuItem.Name = "colorCodeToolStripMenuItem";
            this.colorCodeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.colorCodeToolStripMenuItem.Text = "Color code";
            this.colorCodeToolStripMenuItem.Click += new System.EventHandler(this.colorCodeToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runProjectToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // runProjectToolStripMenuItem
            // 
            this.runProjectToolStripMenuItem.Name = "runProjectToolStripMenuItem";
            this.runProjectToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.runProjectToolStripMenuItem.Text = "Run project";
            this.runProjectToolStripMenuItem.Click += new System.EventHandler(this.runProjectToolStripMenuItem_Click);
            // 
            // keresToolStripMenuItem
            // 
            this.keresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTestCodeToolStripMenuItem,
            this.loadColorCodeToolStripMenuItem,
            this.loadUpdateCodeToolStripMenuItem});
            this.keresToolStripMenuItem.Name = "keresToolStripMenuItem";
            this.keresToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.keresToolStripMenuItem.Text = "Keres";
            // 
            // loadTestCodeToolStripMenuItem
            // 
            this.loadTestCodeToolStripMenuItem.Name = "loadTestCodeToolStripMenuItem";
            this.loadTestCodeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadTestCodeToolStripMenuItem.Text = "Load test code";
            this.loadTestCodeToolStripMenuItem.Click += new System.EventHandler(this.loadTestCodeToolStripMenuItem_Click);
            // 
            // loadColorCodeToolStripMenuItem
            // 
            this.loadColorCodeToolStripMenuItem.Name = "loadColorCodeToolStripMenuItem";
            this.loadColorCodeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadColorCodeToolStripMenuItem.Text = "Load color code";
            this.loadColorCodeToolStripMenuItem.Click += new System.EventHandler(this.loadColorCodeToolStripMenuItem_Click);
            // 
            // loadUpdateCodeToolStripMenuItem
            // 
            this.loadUpdateCodeToolStripMenuItem.Name = "loadUpdateCodeToolStripMenuItem";
            this.loadUpdateCodeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadUpdateCodeToolStripMenuItem.Text = "Load update code";
            this.loadUpdateCodeToolStripMenuItem.Click += new System.EventHandler(this.loadUpdateCodeToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createKeresWindowToolStripMenuItem,
            this.createTxtWindowToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // createKeresWindowToolStripMenuItem
            // 
            this.createKeresWindowToolStripMenuItem.Name = "createKeresWindowToolStripMenuItem";
            this.createKeresWindowToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.createKeresWindowToolStripMenuItem.Text = "Create keres window";
            this.createKeresWindowToolStripMenuItem.Click += new System.EventHandler(this.createKeresWindowToolStripMenuItem_Click);
            // 
            // createTxtWindowToolStripMenuItem
            // 
            this.createTxtWindowToolStripMenuItem.Name = "createTxtWindowToolStripMenuItem";
            this.createTxtWindowToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.createTxtWindowToolStripMenuItem.Text = "Create txt window";
            this.createTxtWindowToolStripMenuItem.Click += new System.EventHandler(this.createTxtWindowToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ide keres 2023";
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTestCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadColorCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadUpdateCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createKeresWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTxtWindowToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

