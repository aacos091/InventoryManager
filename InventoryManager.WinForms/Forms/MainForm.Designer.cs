namespace InventoryManager.WinForms.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.equippedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.LeftHandEquippedItemControl = new InventoryManager.WinForms.Controls.EquippedItemControl();
            this.FeetEquippedItemControl = new InventoryManager.WinForms.Controls.EquippedItemControl();
            this.RightHandEquippedItemControl = new InventoryManager.WinForms.Controls.EquippedItemControl();
            this.HeadEquippedItemControl = new InventoryManager.WinForms.Controls.EquippedItemControl();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.availableItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playerInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.playerInventoryListBox = new System.Windows.Forms.ListBox();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.playerHealthTextBox = new System.Windows.Forms.TextBox();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemWeightTextBox = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemWeightLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            this.equippedItemsGroupBox.SuspendLayout();
            this.availableItemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.playerInventoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.WinForms.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(15, 30);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(794, 701);
            this.mainTabControl.TabIndex = 3;
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.equippedItemsGroupBox);
            this.playersTabPage.Controls.Add(this.moveLeftButton);
            this.playersTabPage.Controls.Add(this.moveRightButton);
            this.playersTabPage.Controls.Add(this.availableItemsGroupBox);
            this.playersTabPage.Controls.Add(this.playerInventoryGroupBox);
            this.playersTabPage.Controls.Add(this.playerScoreTextBox);
            this.playersTabPage.Controls.Add(this.playerScoreLabel);
            this.playersTabPage.Controls.Add(this.playerHealthTextBox);
            this.playersTabPage.Controls.Add(this.playerHealthLabel);
            this.playersTabPage.Controls.Add(this.playerNameTextBox);
            this.playersTabPage.Controls.Add(this.playerNameLabel);
            this.playersTabPage.Controls.Add(this.deletePlayerButton);
            this.playersTabPage.Controls.Add(this.addPlayerButton);
            this.playersTabPage.Controls.Add(this.playersListBox);
            this.playersTabPage.Location = new System.Drawing.Point(4, 25);
            this.playersTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playersTabPage.Size = new System.Drawing.Size(786, 672);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "Players";
            this.playersTabPage.UseVisualStyleBackColor = true;
            // 
            // equippedItemsGroupBox
            // 
            this.equippedItemsGroupBox.Controls.Add(this.LeftHandEquippedItemControl);
            this.equippedItemsGroupBox.Controls.Add(this.FeetEquippedItemControl);
            this.equippedItemsGroupBox.Controls.Add(this.RightHandEquippedItemControl);
            this.equippedItemsGroupBox.Controls.Add(this.HeadEquippedItemControl);
            this.equippedItemsGroupBox.Location = new System.Drawing.Point(167, 148);
            this.equippedItemsGroupBox.Name = "equippedItemsGroupBox";
            this.equippedItemsGroupBox.Size = new System.Drawing.Size(613, 355);
            this.equippedItemsGroupBox.TabIndex = 1;
            this.equippedItemsGroupBox.TabStop = false;
            this.equippedItemsGroupBox.Text = "Equipped Items";
            // 
            // LeftHandEquippedItemControl
            // 
            this.LeftHandEquippedItemControl.EquipLocation = InventoryManager.Data.EquipLocations.LeftHand;
            this.LeftHandEquippedItemControl.EquippedItem = null;
            this.LeftHandEquippedItemControl.Location = new System.Drawing.Point(6, 158);
            this.LeftHandEquippedItemControl.Name = "LeftHandEquippedItemControl";
            this.LeftHandEquippedItemControl.Player = null;
            this.LeftHandEquippedItemControl.Size = new System.Drawing.Size(236, 60);
            this.LeftHandEquippedItemControl.TabIndex = 3;
            // 
            // FeetEquippedItemControl
            // 
            this.FeetEquippedItemControl.EquipLocation = InventoryManager.Data.EquipLocations.Feet;
            this.FeetEquippedItemControl.EquippedItem = null;
            this.FeetEquippedItemControl.Location = new System.Drawing.Point(211, 289);
            this.FeetEquippedItemControl.Name = "FeetEquippedItemControl";
            this.FeetEquippedItemControl.Player = null;
            this.FeetEquippedItemControl.Size = new System.Drawing.Size(236, 60);
            this.FeetEquippedItemControl.TabIndex = 2;
            // 
            // RightHandEquippedItemControl
            // 
            this.RightHandEquippedItemControl.EquipLocation = InventoryManager.Data.EquipLocations.RightHand;
            this.RightHandEquippedItemControl.EquippedItem = null;
            this.RightHandEquippedItemControl.Location = new System.Drawing.Point(377, 158);
            this.RightHandEquippedItemControl.Name = "RightHandEquippedItemControl";
            this.RightHandEquippedItemControl.Player = null;
            this.RightHandEquippedItemControl.Size = new System.Drawing.Size(236, 60);
            this.RightHandEquippedItemControl.TabIndex = 1;
            // 
            // HeadEquippedItemControl
            // 
            this.HeadEquippedItemControl.EquipLocation = InventoryManager.Data.EquipLocations.Head;
            this.HeadEquippedItemControl.EquippedItem = null;
            this.HeadEquippedItemControl.Location = new System.Drawing.Point(211, 21);
            this.HeadEquippedItemControl.Name = "HeadEquippedItemControl";
            this.HeadEquippedItemControl.Player = null;
            this.HeadEquippedItemControl.Size = new System.Drawing.Size(236, 60);
            this.HeadEquippedItemControl.TabIndex = 0;
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(405, 581);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(93, 23);
            this.moveLeftButton.TabIndex = 14;
            this.moveLeftButton.Text = "<<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(405, 552);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(93, 23);
            this.moveRightButton.TabIndex = 13;
            this.moveRightButton.Text = ">>";
            this.moveRightButton.UseVisualStyleBackColor = true;
            // 
            // availableItemsGroupBox
            // 
            this.availableItemsGroupBox.Controls.Add(this.listBox1);
            this.availableItemsGroupBox.Location = new System.Drawing.Point(504, 509);
            this.availableItemsGroupBox.Name = "availableItemsGroupBox";
            this.availableItemsGroupBox.Size = new System.Drawing.Size(237, 158);
            this.availableItemsGroupBox.TabIndex = 12;
            this.availableItemsGroupBox.TabStop = false;
            this.availableItemsGroupBox.Text = "Available Items";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.itemsBindingSource1;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 132);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Name";
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.worldViewModelBindingSource;
            // 
            // playerInventoryGroupBox
            // 
            this.playerInventoryGroupBox.Controls.Add(this.playerInventoryListBox);
            this.playerInventoryGroupBox.Location = new System.Drawing.Point(194, 509);
            this.playerInventoryGroupBox.Name = "playerInventoryGroupBox";
            this.playerInventoryGroupBox.Size = new System.Drawing.Size(205, 158);
            this.playerInventoryGroupBox.TabIndex = 11;
            this.playerInventoryGroupBox.TabStop = false;
            this.playerInventoryGroupBox.Text = "In&ventory";
            // 
            // playerInventoryListBox
            // 
            this.playerInventoryListBox.DataSource = this.inventoryBindingSource1;
            this.playerInventoryListBox.DisplayMember = "Name";
            this.playerInventoryListBox.FormattingEnabled = true;
            this.playerInventoryListBox.ItemHeight = 16;
            this.playerInventoryListBox.Location = new System.Drawing.Point(3, 18);
            this.playerInventoryListBox.Name = "playerInventoryListBox";
            this.playerInventoryListBox.Size = new System.Drawing.Size(196, 132);
            this.playerInventoryListBox.TabIndex = 0;
            this.playerInventoryListBox.ValueMember = "Name";
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.playersBindingSource;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Score", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerScoreTextBox.Location = new System.Drawing.Point(167, 120);
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.Size = new System.Drawing.Size(104, 22);
            this.playerScoreTextBox.TabIndex = 10;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(164, 100);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(49, 17);
            this.playerScoreLabel.TabIndex = 9;
            this.playerScoreLabel.Text = "&Score:";
            // 
            // playerHealthTextBox
            // 
            this.playerHealthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerHealthTextBox.Location = new System.Drawing.Point(167, 75);
            this.playerHealthTextBox.Name = "playerHealthTextBox";
            this.playerHealthTextBox.Size = new System.Drawing.Size(104, 22);
            this.playerHealthTextBox.TabIndex = 8;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(164, 55);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(53, 17);
            this.playerHealthLabel.TabIndex = 7;
            this.playerHealthLabel.Text = "&Health:";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerNameTextBox.Location = new System.Drawing.Point(167, 30);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(234, 22);
            this.playerNameTextBox.TabIndex = 6;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(164, 10);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(49, 17);
            this.playerNameLabel.TabIndex = 5;
            this.playerNameLabel.Text = "&Name:";
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(84, 644);
            this.deletePlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.deletePlayerButton.TabIndex = 2;
            this.deletePlayerButton.Text = "&Delete";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            this.deletePlayerButton.Click += new System.EventHandler(this.DeletePlayerButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(3, 644);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "&Add...";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.DataSource = this.playersBindingSource;
            this.playersListBox.DisplayMember = "Name";
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 16;
            this.playersListBox.Location = new System.Drawing.Point(5, 10);
            this.playersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(153, 628);
            this.playersListBox.TabIndex = 0;
            this.playersListBox.ValueMember = "Health";
            this.playersListBox.SelectedIndexChanged += new System.EventHandler(this.PlayersListBox_SelectedIndexChanged);
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemWeightTextBox);
            this.itemsTabPage.Controls.Add(this.itemWeightLabel);
            this.itemsTabPage.Controls.Add(this.itemNameTextBox);
            this.itemsTabPage.Controls.Add(this.itemNameLabel);
            this.itemsTabPage.Controls.Add(this.deleteItemButton);
            this.itemsTabPage.Controls.Add(this.addItemButton);
            this.itemsTabPage.Controls.Add(this.itemsListBox);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.itemsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemsTabPage.Size = new System.Drawing.Size(717, 672);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemWeightTextBox
            // 
            this.itemWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Weight", true));
            this.itemWeightTextBox.Location = new System.Drawing.Point(165, 87);
            this.itemWeightTextBox.Name = "itemWeightTextBox";
            this.itemWeightTextBox.Size = new System.Drawing.Size(122, 22);
            this.itemWeightTextBox.TabIndex = 8;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemWeightLabel
            // 
            this.itemWeightLabel.AutoSize = true;
            this.itemWeightLabel.Location = new System.Drawing.Point(165, 67);
            this.itemWeightLabel.Name = "itemWeightLabel";
            this.itemWeightLabel.Size = new System.Drawing.Size(52, 17);
            this.itemWeightLabel.TabIndex = 7;
            this.itemWeightLabel.Text = "Weight";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Name", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(165, 25);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(253, 22);
            this.itemNameTextBox.TabIndex = 6;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(165, 5);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(45, 17);
            this.itemNameLabel.TabIndex = 5;
            this.itemNameLabel.Text = "Name";
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(87, 398);
            this.deleteItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(75, 23);
            this.deleteItemButton.TabIndex = 4;
            this.deleteItemButton.Text = "&Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(6, 398);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "&Add...";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.DataSource = this.itemsBindingSource;
            this.itemsListBox.DisplayMember = "Name";
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 16;
            this.itemsListBox.Location = new System.Drawing.Point(6, 5);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(153, 388);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.ValueMember = "Name";
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.playersBindingSource;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(821, 28);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem,
            this.closeWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openWorldToolStripMenuItem.Text = "Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.closeWorldToolStripMenuItem.Text = "Close World";
            this.closeWorldToolStripMenuItem.Click += new System.EventHandler(this.closeWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World files (*.json)|*.json";
            this.saveFileDialog.Title = "Save world file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 742);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.playersTabPage.ResumeLayout(false);
            this.playersTabPage.PerformLayout();
            this.equippedItemsGroupBox.ResumeLayout(false);
            this.availableItemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.playerInventoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.itemsTabPage.ResumeLayout(false);
            this.itemsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox playerHealthTextBox;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.TextBox playerScoreTextBox;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox playerInventoryGroupBox;
        private System.Windows.Forms.ListBox playerInventoryListBox;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.GroupBox availableItemsGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.TextBox itemWeightTextBox;
        private System.Windows.Forms.Label itemWeightLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.GroupBox equippedItemsGroupBox;
        private Controls.EquippedItemControl LeftHandEquippedItemControl;
        private Controls.EquippedItemControl FeetEquippedItemControl;
        private Controls.EquippedItemControl RightHandEquippedItemControl;
        private Controls.EquippedItemControl HeadEquippedItemControl;
        private System.Windows.Forms.ToolStripMenuItem closeWorldToolStripMenuItem;
    }
}

