namespace tagify
{
    partial class tagSelectorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tagSelectorDialog));
            this.tagHistory = new System.Windows.Forms.DataGridView();
            this.tagHistoryTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.uiIcons = new System.Windows.Forms.ImageList(this.components);
            this.removeButton = new System.Windows.Forms.Button();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.clearSelectedButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.tagSelectedTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagSelected = new System.Windows.Forms.DataGridView();
            this.addNewTagTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.addTagTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.removeTagsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.clearTagHistoryTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.clearSelectedTagsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteAllTagsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.applyChangesTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.discardChangesTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tagHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // tagHistory
            // 
            this.tagHistory.AllowUserToAddRows = false;
            this.tagHistory.AllowUserToDeleteRows = false;
            this.tagHistory.AllowUserToResizeColumns = false;
            this.tagHistory.AllowUserToResizeRows = false;
            this.tagHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tagHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tagHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tagHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagHistory.ColumnHeadersVisible = false;
            this.tagHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagHistoryTagName});
            this.tagHistory.Location = new System.Drawing.Point(12, 91);
            this.tagHistory.Name = "tagHistory";
            this.tagHistory.ReadOnly = true;
            this.tagHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tagHistory.RowHeadersVisible = false;
            this.tagHistory.RowHeadersWidth = 51;
            this.tagHistory.RowTemplate.Height = 29;
            this.tagHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tagHistory.ShowEditingIcon = false;
            this.tagHistory.Size = new System.Drawing.Size(333, 318);
            this.tagHistory.TabIndex = 0;
            // 
            // tagHistoryTagName
            // 
            this.tagHistoryTagName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tagHistoryTagName.HeaderText = "";
            this.tagHistoryTagName.MinimumWidth = 6;
            this.tagHistoryTagName.Name = "tagHistoryTagName";
            this.tagHistoryTagName.ReadOnly = true;
            this.tagHistoryTagName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tagHistoryTagName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.MinimumSize = new System.Drawing.Size(0, 40);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(730, 40);
            this.searchBox.TabIndex = 4;
            this.searchBox.Text = "Search Old Tags or Add New Tags";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tag History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(563, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selected Tags";
            // 
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ImageIndex = 0;
            this.addButton.ImageList = this.uiIcons;
            this.addButton.Location = new System.Drawing.Point(378, 201);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 11;
            this.addTagTooltip.SetToolTip(this.addButton, "Add Tag\r\nThis button adds the tags selected in the Tag History to the Selected Ta" +
        "gs list");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // uiIcons
            // 
            this.uiIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.uiIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("uiIcons.ImageStream")));
            this.uiIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.uiIcons.Images.SetKeyName(0, "add.png");
            this.uiIcons.Images.SetKeyName(1, "add_new.png");
            this.uiIcons.Images.SetKeyName(2, "close.png");
            this.uiIcons.Images.SetKeyName(3, "delete.png");
            this.uiIcons.Images.SetKeyName(4, "delete_history.png");
            this.uiIcons.Images.SetKeyName(5, "done.png");
            this.uiIcons.Images.SetKeyName(6, "remove.png");
            this.uiIcons.Images.SetKeyName(7, "warning.png");
            // 
            // removeButton
            // 
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.removeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.ImageIndex = 6;
            this.removeButton.ImageList = this.uiIcons;
            this.removeButton.Location = new System.Drawing.Point(378, 267);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(40, 40);
            this.removeButton.TabIndex = 12;
            this.removeTagsTooltip.SetToolTip(this.removeButton, "Remove Tags\r\nThis button removes the tags selected from the Selected Tags list");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearHistoryButton.FlatAppearance.BorderSize = 0;
            this.clearHistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearHistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clearHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearHistoryButton.ImageIndex = 4;
            this.clearHistoryButton.ImageList = this.uiIcons;
            this.clearHistoryButton.Location = new System.Drawing.Point(12, 415);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(40, 40);
            this.clearHistoryButton.TabIndex = 13;
            this.clearTagHistoryTooltip.SetToolTip(this.clearHistoryButton, "Clear Tag History");
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewButton.FlatAppearance.BorderSize = 0;
            this.addNewButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addNewButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewButton.ImageIndex = 1;
            this.addNewButton.ImageList = this.uiIcons;
            this.addNewButton.Location = new System.Drawing.Point(748, 12);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(40, 40);
            this.addNewButton.TabIndex = 14;
            this.addNewTagTooltip.SetToolTip(this.addNewButton, "Add New Tag\r\nThis button adds a new tag to the Selected Tags list");
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // clearSelectedButton
            // 
            this.clearSelectedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearSelectedButton.FlatAppearance.BorderSize = 0;
            this.clearSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clearSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSelectedButton.ImageIndex = 3;
            this.clearSelectedButton.ImageList = this.uiIcons;
            this.clearSelectedButton.Location = new System.Drawing.Point(455, 415);
            this.clearSelectedButton.Name = "clearSelectedButton";
            this.clearSelectedButton.Size = new System.Drawing.Size(40, 40);
            this.clearSelectedButton.TabIndex = 15;
            this.clearSelectedTagsTooltip.SetToolTip(this.clearSelectedButton, "Clear Selected Tags");
            this.clearSelectedButton.UseVisualStyleBackColor = true;
            this.clearSelectedButton.Click += new System.EventHandler(this.clearSelectedButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.ImageIndex = 5;
            this.acceptButton.ImageList = this.uiIcons;
            this.acceptButton.Location = new System.Drawing.Point(702, 415);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(40, 40);
            this.acceptButton.TabIndex = 16;
            this.applyChangesTooltip.SetToolTip(this.acceptButton, "Apply Changes");
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rejectButton.FlatAppearance.BorderSize = 0;
            this.rejectButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rejectButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rejectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectButton.ImageIndex = 2;
            this.rejectButton.ImageList = this.uiIcons;
            this.rejectButton.Location = new System.Drawing.Point(748, 415);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(40, 40);
            this.rejectButton.TabIndex = 17;
            this.discardChangesTooltip.SetToolTip(this.rejectButton, "Discard Changes");
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // tagSelectedTagName
            // 
            this.tagSelectedTagName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tagSelectedTagName.HeaderText = "";
            this.tagSelectedTagName.MinimumWidth = 6;
            this.tagSelectedTagName.Name = "tagSelectedTagName";
            this.tagSelectedTagName.ReadOnly = true;
            this.tagSelectedTagName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tagSelected
            // 
            this.tagSelected.AllowUserToAddRows = false;
            this.tagSelected.AllowUserToDeleteRows = false;
            this.tagSelected.AllowUserToResizeColumns = false;
            this.tagSelected.AllowUserToResizeRows = false;
            this.tagSelected.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tagSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagSelected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tagSelected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tagSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagSelected.ColumnHeadersVisible = false;
            this.tagSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagSelectedTagName});
            this.tagSelected.Location = new System.Drawing.Point(455, 91);
            this.tagSelected.Name = "tagSelected";
            this.tagSelected.ReadOnly = true;
            this.tagSelected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tagSelected.RowHeadersVisible = false;
            this.tagSelected.RowHeadersWidth = 51;
            this.tagSelected.RowTemplate.Height = 29;
            this.tagSelected.ShowEditingIcon = false;
            this.tagSelected.Size = new System.Drawing.Size(333, 318);
            this.tagSelected.TabIndex = 18;
            this.tagSelected.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.tagSelected_RowsAdded);
            // 
            // tagSelectorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.tagSelected);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.clearSelectedButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.clearHistoryButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.tagHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tagSelectorDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Tags";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tagSelectorDialog_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tagHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal DataGridView tagHistory;
        protected internal TextBox searchBox;
        protected internal Label label1;
        protected internal Label label2;
        protected internal Button addButton;
        protected internal Button removeButton;
        protected internal Button clearHistoryButton;
        protected internal Button addNewButton;
        protected internal Button clearSelectedButton;
        protected internal ImageList uiIcons;
        protected internal Button acceptButton;
        protected internal Button rejectButton;
        private DataGridViewTextBoxColumn tagHistoryTagName;
        private ToolTip addNewTagTooltip;
        private DataGridViewTextBoxColumn tagSelectedTagName;
        protected internal DataGridView tagSelected;
        private ToolTip addTagTooltip;
        private ToolTip removeTagsTooltip;
        private ToolTip clearTagHistoryTooltip;
        private ToolTip clearSelectedTagsTooltip;
        private ToolTip applyChangesTooltip;
        private ToolTip discardChangesTooltip;
        private ToolTip deleteAllTagsTooltip;
    }
}