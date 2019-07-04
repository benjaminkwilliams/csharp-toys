namespace DataInsert
{
    partial class DataInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataInsert));
            this.tspDataInsert = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.allToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.formatToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.dgvDataToFormat = new System.Windows.Forms.DataGridView();
            this.txtOutputData = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbxFirstLineHeader = new System.Windows.Forms.CheckBox();
            this.lblIndentElements = new System.Windows.Forms.Label();
            this.cbxTrimSpaces = new System.Windows.Forms.CheckBox();
            this.lblWrapElements = new System.Windows.Forms.Label();
            this.udWrapCount = new System.Windows.Forms.DomainUpDown();
            this.udSpaceCount = new System.Windows.Forms.DomainUpDown();
            this.clbQuoteElements = new System.Windows.Forms.CheckedListBox();
            this.lblQuoteElements = new System.Windows.Forms.Label();
            this.ckbAllowNulls = new System.Windows.Forms.CheckBox();
            this.tspDataInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataToFormat)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspDataInsert
            // 
            this.tspDataInsert.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspDataInsert.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripSeparator,
            this.allToolStripButton,
            this.toolStripSeparator1,
            this.pasteToolStripButton,
            this.formatToolStripButton,
            this.copyToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.tspDataInsert.Location = new System.Drawing.Point(0, 0);
            this.tspDataInsert.Name = "tspDataInsert";
            this.tspDataInsert.Size = new System.Drawing.Size(745, 27);
            this.tspDataInsert.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // allToolStripButton
            // 
            this.allToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.allToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("allToolStripButton.Image")));
            this.allToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allToolStripButton.Name = "allToolStripButton";
            this.allToolStripButton.Size = new System.Drawing.Size(31, 24);
            this.allToolStripButton.Text = "All";
            this.allToolStripButton.Click += new System.EventHandler(this.allToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // formatToolStripButton
            // 
            this.formatToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.formatToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("formatToolStripButton.Image")));
            this.formatToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formatToolStripButton.Name = "formatToolStripButton";
            this.formatToolStripButton.Size = new System.Drawing.Size(60, 24);
            this.formatToolStripButton.Text = "Format";
            this.formatToolStripButton.Click += new System.EventHandler(this.formatToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(11, 375);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(55, 17);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Output:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(15, 30);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(43, 17);
            this.lblInput.TabIndex = 9;
            this.lblInput.Text = "Input:";
            // 
            // dgvDataToFormat
            // 
            this.dgvDataToFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataToFormat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataToFormat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDataToFormat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataToFormat.Location = new System.Drawing.Point(15, 53);
            this.dgvDataToFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDataToFormat.MultiSelect = false;
            this.dgvDataToFormat.Name = "dgvDataToFormat";
            this.dgvDataToFormat.RowHeadersWidth = 51;
            this.dgvDataToFormat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataToFormat.Size = new System.Drawing.Size(511, 319);
            this.dgvDataToFormat.TabIndex = 6;
            // 
            // txtOutputData
            // 
            this.txtOutputData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputData.Location = new System.Drawing.Point(15, 395);
            this.txtOutputData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutputData.Multiline = true;
            this.txtOutputData.Name = "txtOutputData";
            this.txtOutputData.ReadOnly = true;
            this.txtOutputData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutputData.Size = new System.Drawing.Size(713, 173);
            this.txtOutputData.TabIndex = 7;
            this.txtOutputData.WordWrap = false;
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.ckbAllowNulls);
            this.gbOptions.Controls.Add(this.cbxFirstLineHeader);
            this.gbOptions.Controls.Add(this.lblIndentElements);
            this.gbOptions.Controls.Add(this.cbxTrimSpaces);
            this.gbOptions.Controls.Add(this.lblWrapElements);
            this.gbOptions.Controls.Add(this.udWrapCount);
            this.gbOptions.Controls.Add(this.udSpaceCount);
            this.gbOptions.Location = new System.Drawing.Point(15, 576);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOptions.Size = new System.Drawing.Size(712, 89);
            this.gbOptions.TabIndex = 8;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // cbxFirstLineHeader
            // 
            this.cbxFirstLineHeader.AutoSize = true;
            this.cbxFirstLineHeader.Location = new System.Drawing.Point(244, 53);
            this.cbxFirstLineHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFirstLineHeader.Name = "cbxFirstLineHeader";
            this.cbxFirstLineHeader.Size = new System.Drawing.Size(139, 21);
            this.cbxFirstLineHeader.TabIndex = 10;
            this.cbxFirstLineHeader.Text = "First Line Header";
            this.cbxFirstLineHeader.UseVisualStyleBackColor = true;
            this.cbxFirstLineHeader.CheckedChanged += new System.EventHandler(this.cbxFirstLineHeader_CheckedChanged);
            // 
            // lblIndentElements
            // 
            this.lblIndentElements.AutoSize = true;
            this.lblIndentElements.Location = new System.Drawing.Point(8, 25);
            this.lblIndentElements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndentElements.Name = "lblIndentElements";
            this.lblIndentElements.Size = new System.Drawing.Size(113, 17);
            this.lblIndentElements.TabIndex = 9;
            this.lblIndentElements.Text = "Indent Elements:";
            // 
            // cbxTrimSpaces
            // 
            this.cbxTrimSpaces.AutoSize = true;
            this.cbxTrimSpaces.Checked = true;
            this.cbxTrimSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTrimSpaces.Enabled = false;
            this.cbxTrimSpaces.Location = new System.Drawing.Point(244, 23);
            this.cbxTrimSpaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTrimSpaces.Name = "cbxTrimSpaces";
            this.cbxTrimSpaces.Size = new System.Drawing.Size(109, 21);
            this.cbxTrimSpaces.TabIndex = 8;
            this.cbxTrimSpaces.Text = "Trim Spaces";
            this.cbxTrimSpaces.UseVisualStyleBackColor = true;
            // 
            // lblWrapElements
            // 
            this.lblWrapElements.AutoSize = true;
            this.lblWrapElements.Location = new System.Drawing.Point(8, 54);
            this.lblWrapElements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWrapElements.Name = "lblWrapElements";
            this.lblWrapElements.Size = new System.Drawing.Size(135, 17);
            this.lblWrapElements.TabIndex = 6;
            this.lblWrapElements.Text = "Wrap After Element:";
            // 
            // udWrapCount
            // 
            this.udWrapCount.Enabled = false;
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
            this.udWrapCount.Location = new System.Drawing.Point(149, 52);
            this.udWrapCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.udWrapCount.Name = "udWrapCount";
            this.udWrapCount.Size = new System.Drawing.Size(45, 22);
            this.udWrapCount.TabIndex = 5;
            this.udWrapCount.Text = "0";
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
            this.udSpaceCount.Location = new System.Drawing.Point(149, 22);
            this.udSpaceCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.udSpaceCount.Name = "udSpaceCount";
            this.udSpaceCount.Size = new System.Drawing.Size(45, 22);
            this.udSpaceCount.TabIndex = 1;
            this.udSpaceCount.Text = "0";
            this.udSpaceCount.SelectedItemChanged += new System.EventHandler(this.udSpaceCount_SelectedItemChanged);
            // 
            // clbQuoteElements
            // 
            this.clbQuoteElements.FormattingEnabled = true;
            this.clbQuoteElements.Location = new System.Drawing.Point(533, 53);
            this.clbQuoteElements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbQuoteElements.Name = "clbQuoteElements";
            this.clbQuoteElements.Size = new System.Drawing.Size(192, 310);
            this.clbQuoteElements.TabIndex = 11;
            // 
            // lblQuoteElements
            // 
            this.lblQuoteElements.AutoSize = true;
            this.lblQuoteElements.Location = new System.Drawing.Point(533, 30);
            this.lblQuoteElements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuoteElements.Name = "lblQuoteElements";
            this.lblQuoteElements.Size = new System.Drawing.Size(51, 17);
            this.lblQuoteElements.TabIndex = 12;
            this.lblQuoteElements.Text = "Quote:";
            // 
            // ckbAllowNulls
            // 
            this.ckbAllowNulls.AutoSize = true;
            this.ckbAllowNulls.Checked = true;
            this.ckbAllowNulls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAllowNulls.Location = new System.Drawing.Point(407, 23);
            this.ckbAllowNulls.Name = "ckbAllowNulls";
            this.ckbAllowNulls.Size = new System.Drawing.Size(97, 21);
            this.ckbAllowNulls.TabIndex = 11;
            this.ckbAllowNulls.Text = "Allow Nulls";
            this.ckbAllowNulls.UseVisualStyleBackColor = true;
            // 
            // DataInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 692);
            this.Controls.Add(this.lblQuoteElements);
            this.Controls.Add(this.clbQuoteElements);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.dgvDataToFormat);
            this.Controls.Add(this.txtOutputData);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.tspDataInsert);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataInsert";
            this.ShowIcon = false;
            this.Text = "DataInsert";
            this.tspDataInsert.ResumeLayout(false);
            this.tspDataInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataToFormat)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDataInsert;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton allToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton formatToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.DataGridView dgvDataToFormat;
        private System.Windows.Forms.TextBox txtOutputData;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label lblIndentElements;
        private System.Windows.Forms.CheckBox cbxTrimSpaces;
        private System.Windows.Forms.Label lblWrapElements;
        private System.Windows.Forms.DomainUpDown udWrapCount;
        private System.Windows.Forms.DomainUpDown udSpaceCount;
        private System.Windows.Forms.CheckedListBox clbQuoteElements;
        private System.Windows.Forms.CheckBox cbxFirstLineHeader;
        private System.Windows.Forms.Label lblQuoteElements;
        private System.Windows.Forms.CheckBox ckbAllowNulls;
    }
}

