namespace ChangeMaker
{
  partial class ChangeMaker
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
      this.lblCurrency = new System.Windows.Forms.Label();
      this.tbxAmount = new System.Windows.Forms.TextBox();
      this.btnMakeChange = new System.Windows.Forms.Button();
      this.tbxResult = new System.Windows.Forms.TextBox();
      this.errError = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
      this.SuspendLayout();
      // 
      // lblCurrency
      // 
      this.lblCurrency.AutoSize = true;
      this.lblCurrency.Location = new System.Drawing.Point(13, 67);
      this.lblCurrency.Name = "lblCurrency";
      this.lblCurrency.Size = new System.Drawing.Size(18, 20);
      this.lblCurrency.TabIndex = 0;
      this.lblCurrency.Text = "$";
      // 
      // tbxAmount
      // 
      this.tbxAmount.Location = new System.Drawing.Point(38, 67);
      this.tbxAmount.MaxLength = 10;
      this.tbxAmount.Name = "tbxAmount";
      this.tbxAmount.Size = new System.Drawing.Size(100, 26);
      this.tbxAmount.TabIndex = 1;
      // 
      // btnMakeChange
      // 
      this.btnMakeChange.Location = new System.Drawing.Point(173, 60);
      this.btnMakeChange.Name = "btnMakeChange";
      this.btnMakeChange.Size = new System.Drawing.Size(123, 35);
      this.btnMakeChange.TabIndex = 2;
      this.btnMakeChange.Text = "Make Change";
      this.btnMakeChange.UseVisualStyleBackColor = true;
      this.btnMakeChange.Click += new System.EventHandler(this.btnMakeChange_Click);
      // 
      // tbxResult
      // 
      this.tbxResult.Location = new System.Drawing.Point(12, 99);
      this.tbxResult.Multiline = true;
      this.tbxResult.Name = "tbxResult";
      this.tbxResult.Size = new System.Drawing.Size(380, 284);
      this.tbxResult.TabIndex = 3;
      // 
      // errError
      // 
      this.errError.ContainerControl = this;
      // 
      // ChangeMaker
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(404, 395);
      this.Controls.Add(this.tbxResult);
      this.Controls.Add(this.btnMakeChange);
      this.Controls.Add(this.tbxAmount);
      this.Controls.Add(this.lblCurrency);
      this.MaximumSize = new System.Drawing.Size(426, 451);
      this.MinimumSize = new System.Drawing.Size(426, 451);
      this.Name = "ChangeMaker";
      this.Text = "ChangeMaker";
      ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblCurrency;
    private System.Windows.Forms.TextBox tbxAmount;
    private System.Windows.Forms.Button btnMakeChange;
    private System.Windows.Forms.TextBox tbxResult;
    private System.Windows.Forms.ErrorProvider errError;
  }
}

