
namespace Zork.Builder.Forms
{
    partial class EditRoomNameForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.EditRoomNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(288, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 30);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(181, 58);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(101, 30);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // EditRoomNameTextBox
            // 
            this.EditRoomNameTextBox.Location = new System.Drawing.Point(15, 30);
            this.EditRoomNameTextBox.Name = "EditRoomNameTextBox";
            this.EditRoomNameTextBox.Size = new System.Drawing.Size(374, 22);
            this.EditRoomNameTextBox.TabIndex = 5;
            this.EditRoomNameTextBox.TextChanged += new System.EventHandler(this.AddRoomNameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "&Name";
            // 
            // EditRoomNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 112);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.EditRoomNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "EditRoomNameForm";
            this.Text = "Edit Room Name";
            this.Load += new System.EventHandler(this.EditRoomNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox EditRoomNameTextBox;
        private System.Windows.Forms.Label NameLabel;
    }
}