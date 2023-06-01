
namespace ATNetCoreTelegramBot.WFA.UI;

partial class FrmGroupInsert
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
        this.lblName = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.lblOrdering = new System.Windows.Forms.Label();
        this.numericOrdering = new System.Windows.Forms.NumericUpDown();
        this.btnInsert = new System.Windows.Forms.Button();
        this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.numericOrdering)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
        this.SuspendLayout();
        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Location = new System.Drawing.Point(509, 9);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(59, 22);
        this.lblName.TabIndex = 0;
        this.lblName.Text = "نام گروه";
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(169, 34);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(399, 29);
        this.txtName.TabIndex = 1;
        // 
        // lblOrdering
        // 
        this.lblOrdering.AutoSize = true;
        this.lblOrdering.Location = new System.Drawing.Point(55, 9);
        this.lblOrdering.Name = "lblOrdering";
        this.lblOrdering.Size = new System.Drawing.Size(90, 22);
        this.lblOrdering.TabIndex = 2;
        this.lblOrdering.Text = "ترتیب نمایش";
        // 
        // numericOrdering
        // 
        this.numericOrdering.Location = new System.Drawing.Point(55, 34);
        this.numericOrdering.Name = "numericOrdering";
        this.numericOrdering.Size = new System.Drawing.Size(90, 29);
        this.numericOrdering.TabIndex = 3;
        this.numericOrdering.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // btnInsert
        // 
        this.btnInsert.Location = new System.Drawing.Point(12, 32);
        this.btnInsert.Name = "btnInsert";
        this.btnInsert.Size = new System.Drawing.Size(37, 33);
        this.btnInsert.TabIndex = 4;
        this.btnInsert.UseVisualStyleBackColor = true;
        this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
        // 
        // errorProvider
        // 
        this.errorProvider.ContainerControl = this;
        this.errorProvider.RightToLeft = true;
        // 
        // FrmGroupInsert
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(580, 77);
        this.Controls.Add(this.btnInsert);
        this.Controls.Add(this.numericOrdering);
        this.Controls.Add(this.lblOrdering);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblName);
        this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        this.MaximizeBox = false;
        this.Name = "FrmGroupInsert";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Group [ Insert ]";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGroupInsert_FormClosing);
        ((System.ComponentModel.ISupportInitialize)(this.numericOrdering)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblOrdering;
    private System.Windows.Forms.NumericUpDown numericOrdering;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.ErrorProvider errorProvider;
}