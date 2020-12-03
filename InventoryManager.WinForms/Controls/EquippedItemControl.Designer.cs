namespace InventoryManager.WinForms.Controls
{
    partial class EquippedItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.equipLocationTextBox = new System.Windows.Forms.TextBox();
            this.equippedItemComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // equipLocationTextBox
            // 
            this.equipLocationTextBox.Location = new System.Drawing.Point(3, 3);
            this.equipLocationTextBox.Name = "equipLocationTextBox";
            this.equipLocationTextBox.Size = new System.Drawing.Size(180, 22);
            this.equipLocationTextBox.TabIndex = 0;
            this.equipLocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equippedItemComboBox
            // 
            this.equippedItemComboBox.DisplayMember = "Name";
            this.equippedItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equippedItemComboBox.FormattingEnabled = true;
            this.equippedItemComboBox.Location = new System.Drawing.Point(3, 31);
            this.equippedItemComboBox.Name = "equippedItemComboBox";
            this.equippedItemComboBox.Size = new System.Drawing.Size(180, 24);
            this.equippedItemComboBox.TabIndex = 1;
            this.equippedItemComboBox.SelectedIndexChanged += new System.EventHandler(this.EquippedItemComboBox_SelectedIndexChanged);
            // 
            // EquippedItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equippedItemComboBox);
            this.Controls.Add(this.equipLocationTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.Name = "EquippedItemControl";
            this.Size = new System.Drawing.Size(186, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equipLocationTextBox;
        private System.Windows.Forms.ComboBox equippedItemComboBox;
    }
}
