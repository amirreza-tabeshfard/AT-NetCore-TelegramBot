namespace ATNetCoreTelegramBot.WFA.UI;

partial class FrmGroupIndex
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = default;

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
        this.menuStrip = new System.Windows.Forms.MenuStrip();
        this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuFileInsert = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuFileUpdate = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuFileDelete = new System.Windows.Forms.ToolStripMenuItem();
        this.dataGridView = new System.Windows.Forms.DataGridView();
        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Ordering = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.InsertDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.ContextMenuStripRefresh = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
        this.contextMenuStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip
        // 
        this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.mnuFile});
        this.menuStrip.Location = new System.Drawing.Point(0, 0);
        this.menuStrip.Name = "menuStrip";
        this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
        this.menuStrip.Size = new System.Drawing.Size(780, 24);
        this.menuStrip.TabIndex = 0;
        this.menuStrip.Text = "menuStrip1";
        // 
        // mnuFile
        // 
        this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.mnuFileInsert,
        this.mnuFileUpdate,
        this.mnuFileDelete});
        this.mnuFile.Name = "mnuFile";
        this.mnuFile.Size = new System.Drawing.Size(37, 22);
        this.mnuFile.Text = "File";
        // 
        // mnuFileInsert
        // 
        this.mnuFileInsert.Name = "mnuFileInsert";
        this.mnuFileInsert.Size = new System.Drawing.Size(112, 22);
        this.mnuFileInsert.Text = "Insert";
        this.mnuFileInsert.Click += new System.EventHandler(this.mnuFileInsert_Click);
        // 
        // mnuFileUpdate
        // 
        this.mnuFileUpdate.Name = "mnuFileUpdate";
        this.mnuFileUpdate.Size = new System.Drawing.Size(112, 22);
        this.mnuFileUpdate.Text = "Update";
        this.mnuFileUpdate.Click += new System.EventHandler(this.mnuFileUpdate_Click);
        // 
        // mnuFileDelete
        // 
        this.mnuFileDelete.Name = "mnuFileDelete";
        this.mnuFileDelete.Size = new System.Drawing.Size(112, 22);
        this.mnuFileDelete.Text = "Delete";
        this.mnuFileDelete.Click += new System.EventHandler(this.mnuFileDelete_Click);
        // 
        // dataGridView
        // 
        this.dataGridView.AllowUserToAddRows = false;
        this.dataGridView.AllowUserToDeleteRows = false;
        this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.Id,
        this.GroupName,
        this.Ordering,
        this.InsertDateTime});
        this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
        this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView.Location = new System.Drawing.Point(0, 24);
        this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.dataGridView.Name = "dataGridView";
        this.dataGridView.ReadOnly = true;
        this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.dataGridView.RowTemplate.Height = 25;
        this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView.Size = new System.Drawing.Size(780, 433);
        this.dataGridView.TabIndex = 1;
        // 
        // Id
        // 
        this.Id.FillWeight = 5.21159F;
        this.Id.HeaderText = "شناسه";
        this.Id.Name = "Id";
        this.Id.ReadOnly = true;
        this.Id.Width = 170;
        // 
        // GroupName
        // 
        this.GroupName.FillWeight = 449.2386F;
        this.GroupName.HeaderText = "نام";
        this.GroupName.Name = "GroupName";
        this.GroupName.ReadOnly = true;
        this.GroupName.Width = 287;
        // 
        // Ordering
        // 
        this.Ordering.FillWeight = 28.58869F;
        this.Ordering.HeaderText = "ترتیب";
        this.Ordering.Name = "Ordering";
        this.Ordering.ReadOnly = true;
        this.Ordering.Width = 60;
        // 
        // InsertDateTime
        // 
        this.InsertDateTime.FillWeight = 14.03406F;
        this.InsertDateTime.HeaderText = "تاریخ ثبت";
        this.InsertDateTime.Name = "InsertDateTime";
        this.InsertDateTime.ReadOnly = true;
        this.InsertDateTime.Width = 220;
        // 
        // contextMenuStrip
        // 
        this.contextMenuStrip.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
        this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.ContextMenuStripRefresh});
        this.contextMenuStrip.Name = "contextMenuStrip";
        this.contextMenuStrip.Size = new System.Drawing.Size(181, 48);
        // 
        // ContextMenuStripRefresh
        // 
        this.ContextMenuStripRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ContextMenuStripRefresh.Name = "ContextMenuStripRefresh";
        this.ContextMenuStripRefresh.Size = new System.Drawing.Size(180, 22);
        this.ContextMenuStripRefresh.Text = "Refresh";
        this.ContextMenuStripRefresh.Click += new System.EventHandler(this.ContextMenuStripRefresh_Click);
        // 
        // FrmGroupIndex
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(780, 457);
        this.Controls.Add(this.dataGridView);
        this.Controls.Add(this.menuStrip);
        this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.MainMenuStrip = this.menuStrip;
        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.MaximizeBox = false;
        this.Name = "FrmGroupIndex";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Group [Index]";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGroupIndex_FormClosing);
        this.Load += new System.EventHandler(this.FrmGroupIndex_Load);
        this.menuStrip.ResumeLayout(false);
        this.menuStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
        this.contextMenuStrip.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileInsert;
    private System.Windows.Forms.ToolStripMenuItem mnuFileUpdate;
    private System.Windows.Forms.ToolStripMenuItem mnuFileDelete;
    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ordering;
    private System.Windows.Forms.DataGridViewTextBoxColumn InsertDateTime;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem ContextMenuStripRefresh;
}