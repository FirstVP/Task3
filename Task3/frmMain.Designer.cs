namespace Task3
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разведчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addButton = new System.Windows.Forms.Button();
            this.mainTB = new System.Windows.Forms.TextBox();
            this.cbMain = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.bomberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.lightFighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1047, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Меню";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разведчикToolStripMenuItem,
            this.bomberToolStripMenuItem,
            this.lightFighterToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // разведчикToolStripMenuItem
            // 
            this.разведчикToolStripMenuItem.Name = "разведчикToolStripMenuItem";
            this.разведчикToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.разведчикToolStripMenuItem.Text = "Scout";
            this.разведчикToolStripMenuItem.Click += new System.EventHandler(this.ScoutToolStripMenuItem_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(118, 291);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // mainTB
            // 
            this.mainTB.Location = new System.Drawing.Point(434, 27);
            this.mainTB.Multiline = true;
            this.mainTB.Name = "mainTB";
            this.mainTB.Size = new System.Drawing.Size(373, 205);
            this.mainTB.TabIndex = 2;
            // 
            // cbMain
            // 
            this.cbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMain.FormattingEnabled = true;
            this.cbMain.Location = new System.Drawing.Point(699, 291);
            this.cbMain.Name = "cbMain";
            this.cbMain.Size = new System.Drawing.Size(44, 21);
            this.cbMain.TabIndex = 3;
            this.cbMain.SelectedIndexChanged += new System.EventHandler(this.cbMain_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(484, 299);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 38);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // bomberToolStripMenuItem
            // 
            this.bomberToolStripMenuItem.Name = "bomberToolStripMenuItem";
            this.bomberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bomberToolStripMenuItem.Text = "Bomber";
            this.bomberToolStripMenuItem.Click += new System.EventHandler(this.bomberToolStripMenuItem_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(867, 56);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 46);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Ssve";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(866, 137);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(121, 44);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // lightFighterToolStripMenuItem
            // 
            this.lightFighterToolStripMenuItem.Name = "lightFighterToolStripMenuItem";
            this.lightFighterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lightFighterToolStripMenuItem.Text = "LightFighter";
            this.lightFighterToolStripMenuItem.Click += new System.EventHandler(this.lightFighterToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 362);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cbMain);
            this.Controls.Add(this.mainTB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mainMenu);
            this.Name = "frmMain";
            this.Text = "Fleet";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разведчикToolStripMenuItem;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox mainTB;
        private System.Windows.Forms.ComboBox cbMain;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem bomberToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ToolStripMenuItem lightFighterToolStripMenuItem;

    }
}

