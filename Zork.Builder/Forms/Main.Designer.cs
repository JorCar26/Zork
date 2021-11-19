
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.EditRoomsButton = new System.Windows.Forms.Button();
            this.DeleteRoomsButton = new System.Windows.Forms.Button();
            this.RoomNeighborsLabel = new System.Windows.Forms.Label();
            this.RoomsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WestLabel = new System.Windows.Forms.Label();
            this.EastLabel = new System.Windows.Forms.Label();
            this.SouthLabel = new System.Windows.Forms.Label();
            this.NorthLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.northNeighborListBox = new System.Windows.Forms.ListBox();
            this.southNeighborListBox = new System.Windows.Forms.ListBox();
            this.eastNeighborListBox = new System.Windows.Forms.ListBox();
            this.westNeighborListBox = new System.Windows.Forms.ListBox();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(59, 31);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 28);
            this.toolStripDropDownButton1.Text = "&File";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
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
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 419);
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
            this.tabPage1.Controls.Add(this.RoomsLabel);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.RoomNeighborsLabel);
            this.tabPage1.Controls.Add(this.RoomsListBox);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.Description);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(65, 0);
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
            // RoomNeighborsLabel
            // 
            this.RoomNeighborsLabel.AutoSize = true;
            this.RoomNeighborsLabel.Location = new System.Drawing.Point(222, 76);
            this.RoomNeighborsLabel.Name = "RoomNeighborsLabel";
            this.RoomNeighborsLabel.Size = new System.Drawing.Size(114, 17);
            this.RoomNeighborsLabel.TabIndex = 6;
            this.RoomNeighborsLabel.Text = "Room Neighbors";
            // 
            // RoomsListBox
            // 
            this.RoomsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource, "Name", true));
            this.RoomsListBox.FormattingEnabled = true;
            this.RoomsListBox.ItemHeight = 16;
            this.RoomsListBox.Location = new System.Drawing.Point(2, 20);
            this.RoomsListBox.Name = "RoomsListBox";
            this.RoomsListBox.Size = new System.Drawing.Size(204, 308);
            this.RoomsListBox.TabIndex = 0;
            this.RoomsListBox.ValueMember = "Description";
            this.RoomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.WestLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.EastLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.SouthLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NorthLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.northNeighborListBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.southNeighborListBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.eastNeighborListBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.westNeighborListBox, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(225, 105);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(473, 100);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // WestLabel
            // 
            this.WestLabel.AutoSize = true;
            this.WestLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WestLabel.Location = new System.Drawing.Point(357, 0);
            this.WestLabel.Name = "WestLabel";
            this.WestLabel.Size = new System.Drawing.Size(113, 50);
            this.WestLabel.TabIndex = 3;
            this.WestLabel.Text = "West";
            this.WestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EastLabel
            // 
            this.EastLabel.AutoSize = true;
            this.EastLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EastLabel.Location = new System.Drawing.Point(239, 0);
            this.EastLabel.Name = "EastLabel";
            this.EastLabel.Size = new System.Drawing.Size(112, 50);
            this.EastLabel.TabIndex = 2;
            this.EastLabel.Text = "East";
            this.EastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SouthLabel
            // 
            this.SouthLabel.AutoSize = true;
            this.SouthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SouthLabel.Location = new System.Drawing.Point(121, 0);
            this.SouthLabel.Name = "SouthLabel";
            this.SouthLabel.Size = new System.Drawing.Size(112, 50);
            this.SouthLabel.TabIndex = 1;
            this.SouthLabel.Text = "South";
            this.SouthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NorthLabel
            // 
            this.NorthLabel.AutoSize = true;
            this.NorthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NorthLabel.Location = new System.Drawing.Point(3, 0);
            this.NorthLabel.Name = "NorthLabel";
            this.NorthLabel.Size = new System.Drawing.Size(112, 50);
            this.NorthLabel.TabIndex = 0;
            this.NorthLabel.Text = "North";
            this.NorthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(222, 22);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(120, 17);
            this.Description.TabIndex = 3;
            this.Description.Text = "Room Description";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.textBox1.Location = new System.Drawing.Point(225, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 22);
            this.textBox1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zork Start Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSONFiles|*json";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
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
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World file (*.json|*.json)";
            this.saveFileDialog.Title = "Save World";
            // 
            // northNeighborListBox
            // 
            this.northNeighborListBox.FormattingEnabled = true;
            this.northNeighborListBox.ItemHeight = 16;
            this.northNeighborListBox.Location = new System.Drawing.Point(3, 53);
            this.northNeighborListBox.Name = "northNeighborListBox";
            this.northNeighborListBox.Size = new System.Drawing.Size(112, 36);
            this.northNeighborListBox.TabIndex = 4;
            // 
            // southNeighborListBox
            // 
            this.southNeighborListBox.FormattingEnabled = true;
            this.southNeighborListBox.ItemHeight = 16;
            this.southNeighborListBox.Location = new System.Drawing.Point(121, 53);
            this.southNeighborListBox.Name = "southNeighborListBox";
            this.southNeighborListBox.Size = new System.Drawing.Size(112, 36);
            this.southNeighborListBox.TabIndex = 5;
            // 
            // eastNeighborListBox
            // 
            this.eastNeighborListBox.FormattingEnabled = true;
            this.eastNeighborListBox.ItemHeight = 16;
            this.eastNeighborListBox.Location = new System.Drawing.Point(239, 53);
            this.eastNeighborListBox.Name = "eastNeighborListBox";
            this.eastNeighborListBox.Size = new System.Drawing.Size(112, 36);
            this.eastNeighborListBox.TabIndex = 6;
            // 
            // westNeighborListBox
            // 
            this.westNeighborListBox.FormattingEnabled = true;
            this.westNeighborListBox.ItemHeight = 16;
            this.westNeighborListBox.Location = new System.Drawing.Point(357, 53);
            this.westNeighborListBox.Name = "westNeighborListBox";
            this.westNeighborListBox.Size = new System.Drawing.Size(113, 36);
            this.westNeighborListBox.TabIndex = 7;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.WorldViewModel);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.ListBox RoomsListBox;
        private System.Windows.Forms.Label RoomNeighborsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label WestLabel;
        private System.Windows.Forms.Label EastLabel;
        private System.Windows.Forms.Label SouthLabel;
        private System.Windows.Forms.Label NorthLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button EditRoomsButton;
        private System.Windows.Forms.Button DeleteRoomsButton;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox northNeighborListBox;
        private System.Windows.Forms.ListBox southNeighborListBox;
        private System.Windows.Forms.ListBox eastNeighborListBox;
        private System.Windows.Forms.ListBox westNeighborListBox;
    }
}