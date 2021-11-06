
namespace Zork.Builder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.neighborDirections = new System.Windows.Forms.GroupBox();
            this.eastNeighborControl = new Zork.Builder.Controls.NeighborControl();
            this.southNeighborControl = new Zork.Builder.Controls.NeighborControl();
            this.westNeighborControl = new Zork.Builder.Controls.NeighborControl();
            this.northNeighborControl = new Zork.Builder.Controls.NeighborControl();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.EditRoomsButton = new System.Windows.Forms.Button();
            this.DeleteRoomsButton = new System.Windows.Forms.Button();
            this.RoomsListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Description = new System.Windows.Forms.Label();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.playerStartComboBox = new System.Windows.Forms.ComboBox();
            this.startingLocationTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.neighborDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(59, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripDropDownButton1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.newToolStripMenuItem.Text = "&New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.saveAsToolStripMenuItem.Text = "&Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 423);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 420);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.neighborDirections);
            this.tabPage1.Controls.Add(this.fileNameLabel);
            this.tabPage1.Controls.Add(this.fileNameTextBox);
            this.tabPage1.Controls.Add(this.RoomsLabel);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.RoomsListBox);
            this.tabPage1.Controls.Add(this.Description);
            this.tabPage1.Controls.Add(this.roomDescriptionTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // neighborDirections
            // 
            this.neighborDirections.Controls.Add(this.eastNeighborControl);
            this.neighborDirections.Controls.Add(this.southNeighborControl);
            this.neighborDirections.Controls.Add(this.westNeighborControl);
            this.neighborDirections.Controls.Add(this.northNeighborControl);
            this.neighborDirections.Location = new System.Drawing.Point(223, 70);
            this.neighborDirections.Name = "neighborDirections";
            this.neighborDirections.Size = new System.Drawing.Size(502, 258);
            this.neighborDirections.TabIndex = 9;
            this.neighborDirections.TabStop = false;
            this.neighborDirections.Text = "Room Neighbors";
            // 
            // eastNeighborControl
            // 
            this.eastNeighborControl.Location = new System.Drawing.Point(291, 97);
            this.eastNeighborControl.Name = "eastNeighborControl";
            this.eastNeighborControl.NeighborDirection = Zork.Commands.EAST;
            this.eastNeighborControl.Size = new System.Drawing.Size(179, 60);
            this.eastNeighborControl.TabIndex = 3;
            // 
            // southNeighborControl
            // 
            this.southNeighborControl.Location = new System.Drawing.Point(180, 177);
            this.southNeighborControl.Name = "southNeighborControl";
            this.southNeighborControl.NeighborDirection = Zork.Commands.SOUTH;
            this.southNeighborControl.Size = new System.Drawing.Size(179, 60);
            this.southNeighborControl.TabIndex = 2;
            // 
            // westNeighborControl
            // 
            this.westNeighborControl.Location = new System.Drawing.Point(71, 97);
            this.westNeighborControl.Name = "westNeighborControl";
            this.westNeighborControl.NeighborDirection = Zork.Commands.WEST;
            this.westNeighborControl.Size = new System.Drawing.Size(179, 60);
            this.westNeighborControl.TabIndex = 1;
            // 
            // northNeighborControl
            // 
            this.northNeighborControl.Location = new System.Drawing.Point(180, 21);
            this.northNeighborControl.Name = "northNeighborControl";
            this.northNeighborControl.NeighborDirection = Zork.Commands.NORTH;
            this.northNeighborControl.Size = new System.Drawing.Size(179, 60);
            this.northNeighborControl.TabIndex = 0;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(220, 334);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(71, 17);
            this.fileNameLabel.TabIndex = 7;
            this.fileNameLabel.Text = "File Name";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FileName", true));
            this.fileNameTextBox.Location = new System.Drawing.Point(223, 354);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(502, 22);
            this.fileNameTextBox.TabIndex = 8;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(72, 3);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(52, 17);
            this.RoomsLabel.TabIndex = 1;
            this.RoomsLabel.Text = "Rooms";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AddRoomButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditRoomsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteRoomsButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 334);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 86);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRoomButton.Location = new System.Drawing.Point(3, 3);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(60, 37);
            this.AddRoomButton.TabIndex = 0;
            this.AddRoomButton.Text = "&Add...";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // EditRoomsButton
            // 
            this.EditRoomsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditRoomsButton.Location = new System.Drawing.Point(69, 3);
            this.EditRoomsButton.Name = "EditRoomsButton";
            this.EditRoomsButton.Size = new System.Drawing.Size(60, 37);
            this.EditRoomsButton.TabIndex = 1;
            this.EditRoomsButton.Text = "&Edit..";
            this.EditRoomsButton.UseVisualStyleBackColor = true;
            // 
            // DeleteRoomsButton
            // 
            this.DeleteRoomsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteRoomsButton.Location = new System.Drawing.Point(135, 3);
            this.DeleteRoomsButton.Name = "DeleteRoomsButton";
            this.DeleteRoomsButton.Size = new System.Drawing.Size(62, 37);
            this.DeleteRoomsButton.TabIndex = 2;
            this.DeleteRoomsButton.Text = "&Delete";
            this.DeleteRoomsButton.UseVisualStyleBackColor = true;
            this.DeleteRoomsButton.Click += new System.EventHandler(this.DeleteRoomsButton_Click);
            // 
            // RoomsListBox
            // 
            this.RoomsListBox.DataSource = this.roomsBindingSource;
            this.RoomsListBox.DisplayMember = "Name";
            this.RoomsListBox.FormattingEnabled = true;
            this.RoomsListBox.ItemHeight = 16;
            this.RoomsListBox.Location = new System.Drawing.Point(2, 20);
            this.RoomsListBox.Name = "RoomsListBox";
            this.RoomsListBox.Size = new System.Drawing.Size(204, 308);
            this.RoomsListBox.TabIndex = 0;
            this.RoomsListBox.ValueMember = "Name";
            this.RoomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(220, 22);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(120, 17);
            this.Description.TabIndex = 3;
            this.Description.Text = "Room Description";
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(223, 42);
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(502, 22);
            this.roomDescriptionTextBox.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.startingLocationTextBox);
            this.tabPage2.Controls.Add(this.playerStartComboBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zork Start Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zork Welcome Message";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON File|*json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON File|*json";
            this.saveFileDialog.Title = "Save World";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player Starting Location";
            // 
            // playerStartComboBox
            // 
            this.playerStartComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.playerStartComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.roomsBindingSource, "Name", true));
            this.playerStartComboBox.DataSource = this.roomsBindingSource;
            this.playerStartComboBox.DisplayMember = "Name";
            this.playerStartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerStartComboBox.FormattingEnabled = true;
            this.playerStartComboBox.Location = new System.Drawing.Point(259, 97);
            this.playerStartComboBox.Name = "playerStartComboBox";
            this.playerStartComboBox.Size = new System.Drawing.Size(240, 24);
            this.playerStartComboBox.TabIndex = 4;
            this.playerStartComboBox.ValueMember = "Name";
            // 
            // startingLocationTextBox
            // 
            this.startingLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "Game.World.StartingLocation", true));
            this.startingLocationTextBox.Location = new System.Drawing.Point(292, 69);
            this.startingLocationTextBox.Name = "startingLocationTextBox";
            this.startingLocationTextBox.ReadOnly = true;
            this.startingLocationTextBox.Size = new System.Drawing.Size(168, 22);
            this.startingLocationTextBox.TabIndex = 5;
            this.startingLocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Main";
            this.Text = "Zork Builder";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.neighborDirections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button EditRoomsButton;
        private System.Windows.Forms.Button DeleteRoomsButton;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RoomsListBox;
        private System.Windows.Forms.GroupBox neighborDirections;
        private Controls.NeighborControl eastNeighborControl;
        private Controls.NeighborControl southNeighborControl;
        private Controls.NeighborControl westNeighborControl;
        private Controls.NeighborControl northNeighborControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox playerStartComboBox;
        private System.Windows.Forms.TextBox startingLocationTextBox;
    }
}