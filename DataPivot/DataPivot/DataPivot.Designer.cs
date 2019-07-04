namespace DataPivot
{
    partial class DataPivot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPivot));
            this.dgvDataToPivot = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPivotData = new System.Windows.Forms.TextBox();
            this.tspDataPivot = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.allToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnPivot = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lblIndentElements = new System.Windows.Forms.Label();
            this.cbxTrimSpaces = new System.Windows.Forms.CheckBox();
            this.cbxQuoteElements = new System.Windows.Forms.CheckBox();
            this.lblWrapElements = new System.Windows.Forms.Label();
            this.udWrapCount = new System.Windows.Forms.DomainUpDown();
            this.cbxParaOwnLine = new System.Windows.Forms.CheckBox();
            this.udSpaceCount = new System.Windows.Forms.DomainUpDown();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pivotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataToPivot)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tspDataPivot.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDataToPivot
            // 
            this.dgvDataToPivot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataToPivot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataToPivot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDataToPivot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataToPivot.Location = new System.Drawing.Point(13, 51);
            this.dgvDataToPivot.MultiSelect = false;
            this.dgvDataToPivot.Name = "dgvDataToPivot";
            this.dgvDataToPivot.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDataToPivot.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataToPivot.Size = new System.Drawing.Size(268, 315);
            this.dgvDataToPivot.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.pivotToolStripMenuItem,
            this.copytoolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 70);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // copytoolStripMenuItem
            // 
            this.copytoolStripMenuItem.Name = "copytoolStripMenuItem";
            this.copytoolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copytoolStripMenuItem.Text = "Copy";
            this.copytoolStripMenuItem.Click += new System.EventHandler(this.copytoolStripMenuItem_Click);
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 55;
            // 
            // txtPivotData
            // 
            this.txtPivotData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPivotData.ContextMenuStrip = this.contextMenuStrip1;
            this.txtPivotData.Location = new System.Drawing.Point(287, 51);
            this.txtPivotData.Multiline = true;
            this.txtPivotData.Name = "txtPivotData";
            this.txtPivotData.ReadOnly = true;
            this.txtPivotData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPivotData.Size = new System.Drawing.Size(262, 315);
            this.txtPivotData.TabIndex = 2;
            this.txtPivotData.WordWrap = false;
            // 
            // tspDataPivot
            // 
            this.tspDataPivot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripSeparator1,
            this.allToolStripButton,
            this.toolStripSeparator2,
            this.pasteToolStripButton,
            this.btnPivot,
            this.copyToolStripButton,
            this.toolStripSeparator3,
            this.helpToolStripButton});
            this.tspDataPivot.Location = new System.Drawing.Point(0, 0);
            this.tspDataPivot.Name = "tspDataPivot";
            this.tspDataPivot.Size = new System.Drawing.Size(559, 25);
            this.tspDataPivot.TabIndex = 0;
            this.tspDataPivot.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.ToolTipText = "Clear both the Input and Output areas";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // allToolStripButton
            // 
            this.allToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.allToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("allToolStripButton.Image")));
            this.allToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allToolStripButton.Name = "allToolStripButton";
            this.allToolStripButton.Size = new System.Drawing.Size(25, 22);
            this.allToolStripButton.Text = "All";
            this.allToolStripButton.ToolTipText = "Paste data from the clipboard\r\nPivot and format the data\r\nCopy the output to the " +
    "clipboard";
            this.allToolStripButton.Click += new System.EventHandler(this.allToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.ToolTipText = "Paste data from the clipboard";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // btnPivot
            // 
            this.btnPivot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPivot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPivot.Name = "btnPivot";
            this.btnPivot.Size = new System.Drawing.Size(38, 22);
            this.btnPivot.Text = "Pivot";
            this.btnPivot.ToolTipText = "Pivot the data, format it, place it in output";
            this.btnPivot.Click += new System.EventHandler(this.btnPivot_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.ToolTipText = "Copy the output into the clipboard";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.lblIndentElements);
            this.gbOptions.Controls.Add(this.cbxTrimSpaces);
            this.gbOptions.Controls.Add(this.cbxQuoteElements);
            this.gbOptions.Controls.Add(this.lblWrapElements);
            this.gbOptions.Controls.Add(this.udWrapCount);
            this.gbOptions.Controls.Add(this.cbxParaOwnLine);
            this.gbOptions.Controls.Add(this.udSpaceCount);
            this.gbOptions.Location = new System.Drawing.Point(13, 372);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(534, 106);
            this.gbOptions.TabIndex = 3;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // lblIndentElements
            // 
            this.lblIndentElements.AutoSize = true;
            this.lblIndentElements.Location = new System.Drawing.Point(6, 20);
            this.lblIndentElements.Name = "lblIndentElements";
            this.lblIndentElements.Size = new System.Drawing.Size(86, 13);
            this.lblIndentElements.TabIndex = 9;
            this.lblIndentElements.Text = "Indent Elements:";
            // 
            // cbxTrimSpaces
            // 
            this.cbxTrimSpaces.AutoSize = true;
            this.cbxTrimSpaces.Checked = true;
            this.cbxTrimSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTrimSpaces.Location = new System.Drawing.Point(178, 43);
            this.cbxTrimSpaces.Name = "cbxTrimSpaces";
            this.cbxTrimSpaces.Size = new System.Drawing.Size(85, 17);
            this.cbxTrimSpaces.TabIndex = 8;
            this.cbxTrimSpaces.Text = "Trim Spaces";
            this.cbxTrimSpaces.UseVisualStyleBackColor = true;
            this.cbxTrimSpaces.CheckedChanged += new System.EventHandler(this.cbxTrimSpaces_CheckedChanged);
            // 
            // cbxQuoteElements
            // 
            this.cbxQuoteElements.AutoSize = true;
            this.cbxQuoteElements.Checked = true;
            this.cbxQuoteElements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxQuoteElements.Location = new System.Drawing.Point(6, 69);
            this.cbxQuoteElements.Name = "cbxQuoteElements";
            this.cbxQuoteElements.Size = new System.Drawing.Size(101, 17);
            this.cbxQuoteElements.TabIndex = 7;
            this.cbxQuoteElements.Text = "Quote Elements";
            this.cbxQuoteElements.UseVisualStyleBackColor = true;
            this.cbxQuoteElements.CheckedChanged += new System.EventHandler(this.cbxQuoteElements_CheckedChanged);
            // 
            // lblWrapElements
            // 
            this.lblWrapElements.AutoSize = true;
            this.lblWrapElements.Location = new System.Drawing.Point(6, 44);
            this.lblWrapElements.Name = "lblWrapElements";
            this.lblWrapElements.Size = new System.Drawing.Size(102, 13);
            this.lblWrapElements.TabIndex = 6;
            this.lblWrapElements.Text = "Wrap After Element:";
            // 
            // udWrapCount
            // 
            this.udWrapCount.Items.Add(10);
            this.udWrapCount.Items.Add(9);
            this.udWrapCount.Items.Add(8);
            this.udWrapCount.Items.Add(7);
            this.udWrapCount.Items.Add(6);
            this.udWrapCount.Items.Add(5);
            this.udWrapCount.Items.Add(4);
            this.udWrapCount.Items.Add(3);
            this.udWrapCount.Items.Add(2);
            this.udWrapCount.Items.Add(1);
            this.udWrapCount.Items.Add(0);
            this.udWrapCount.Location = new System.Drawing.Point(112, 42);
            this.udWrapCount.Name = "udWrapCount";
            this.udWrapCount.Size = new System.Drawing.Size(34, 20);
            this.udWrapCount.TabIndex = 5;
            this.udWrapCount.Text = "0";
            this.udWrapCount.SelectedItemChanged += new System.EventHandler(this.udWrapCount_SelectedItemChanged);
            // 
            // cbxParaOwnLine
            // 
            this.cbxParaOwnLine.AutoSize = true;
            this.cbxParaOwnLine.Location = new System.Drawing.Point(178, 19);
            this.cbxParaOwnLine.Name = "cbxParaOwnLine";
            this.cbxParaOwnLine.Size = new System.Drawing.Size(146, 17);
            this.cbxParaOwnLine.TabIndex = 3;
            this.cbxParaOwnLine.Text = "Parenthesis On Own Line";
            this.cbxParaOwnLine.UseVisualStyleBackColor = true;
            this.cbxParaOwnLine.CheckedChanged += new System.EventHandler(this.cbxParaOwnLine_CheckedChanged);
            // 
            // udSpaceCount
            // 
            this.udSpaceCount.Items.Add(10);
            this.udSpaceCount.Items.Add(9);
            this.udSpaceCount.Items.Add(8);
            this.udSpaceCount.Items.Add(7);
            this.udSpaceCount.Items.Add(6);
            this.udSpaceCount.Items.Add(5);
            this.udSpaceCount.Items.Add(4);
            this.udSpaceCount.Items.Add(3);
            this.udSpaceCount.Items.Add(2);
            this.udSpaceCount.Items.Add(1);
            this.udSpaceCount.Items.Add(0);
            this.udSpaceCount.Location = new System.Drawing.Point(112, 18);
            this.udSpaceCount.Name = "udSpaceCount";
            this.udSpaceCount.Size = new System.Drawing.Size(34, 20);
            this.udSpaceCount.TabIndex = 1;
            this.udSpaceCount.Text = "0";
            this.udSpaceCount.SelectedItemChanged += new System.EventHandler(this.udSpaceCount_SelectedItemChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(13, 32);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(34, 13);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Input:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(287, 31);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output:";
            // 
            // pivotToolStripMenuItem
            // 
            this.pivotToolStripMenuItem.Name = "pivotToolStripMenuItem";
            this.pivotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pivotToolStripMenuItem.Text = "Pivot";
            this.pivotToolStripMenuItem.Click += new System.EventHandler(this.pivotToolStripMenuItem_Click);
            // 
            // DataPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 490);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.dgvDataToPivot);
            this.Controls.Add(this.tspDataPivot);
            this.Controls.Add(this.txtPivotData);
            this.Controls.Add(this.gbOptions);
            this.MinimizeBox = false;
            this.Name = "DataPivot";
            this.ShowIcon = false;
            this.Text = "DataPivot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataToPivot)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tspDataPivot.ResumeLayout(false);
            this.tspDataPivot.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataToPivot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.TextBox txtPivotData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tspDataPivot;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripButton btnPivot;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton allToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.ToolStripMenuItem copytoolStripMenuItem;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.DomainUpDown udSpaceCount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox cbxParaOwnLine;
        private System.Windows.Forms.DomainUpDown udWrapCount;
        private System.Windows.Forms.Label lblWrapElements;
        private System.Windows.Forms.CheckBox cbxQuoteElements;
        private System.Windows.Forms.CheckBox cbxTrimSpaces;
        private System.Windows.Forms.Label lblIndentElements;
        private System.Windows.Forms.ToolStripMenuItem pivotToolStripMenuItem;
    }
}

