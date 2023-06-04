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
        components = new System.ComponentModel.Container();
        menuStrip = new MenuStrip();
        mnuFile = new ToolStripMenuItem();
        mnuFileInsert = new ToolStripMenuItem();
        mnuFileUpdate = new ToolStripMenuItem();
        mnuFileDelete = new ToolStripMenuItem();
        dataGridView = new DataGridView();
        Id = new DataGridViewTextBoxColumn();
        GroupName = new DataGridViewTextBoxColumn();
        Ordering = new DataGridViewTextBoxColumn();
        InsertDateTime = new DataGridViewTextBoxColumn();
        contextMenuStrip = new ContextMenuStrip(components);
        ContextMenuStripRefresh = new ToolStripMenuItem();
        menuStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        contextMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip
        // 
        menuStrip.Items.AddRange(new ToolStripItem[] { mnuFile });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Padding = new Padding(5, 1, 0, 1);
        menuStrip.Size = new Size(780, 24);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip1";
        // 
        // mnuFile
        // 
        mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileInsert, mnuFileUpdate, mnuFileDelete });
        mnuFile.Name = "mnuFile";
        mnuFile.Size = new Size(37, 22);
        mnuFile.Text = "File";
        // 
        // mnuFileInsert
        // 
        mnuFileInsert.Name = "mnuFileInsert";
        mnuFileInsert.Size = new Size(112, 22);
        mnuFileInsert.Text = "Insert";
        mnuFileInsert.Click += mnuFileInsert_Click;
        // 
        // mnuFileUpdate
        // 
        mnuFileUpdate.Name = "mnuFileUpdate";
        mnuFileUpdate.Size = new Size(112, 22);
        mnuFileUpdate.Text = "Update";
        mnuFileUpdate.Click += mnuFileUpdate_Click;
        // 
        // mnuFileDelete
        // 
        mnuFileDelete.Name = "mnuFileDelete";
        mnuFileDelete.Size = new Size(112, 22);
        mnuFileDelete.Text = "Delete";
        mnuFileDelete.Click += mnuFileDelete_Click;
        // 
        // dataGridView
        // 
        dataGridView.AllowUserToAddRows = false;
        dataGridView.AllowUserToDeleteRows = false;
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, GroupName, Ordering, InsertDateTime });
        dataGridView.ContextMenuStrip = contextMenuStrip;
        dataGridView.Dock = DockStyle.Fill;
        dataGridView.Location = new Point(0, 24);
        dataGridView.Margin = new Padding(3, 2, 3, 2);
        dataGridView.Name = "dataGridView";
        dataGridView.ReadOnly = true;
        dataGridView.RightToLeft = RightToLeft.Yes;
        dataGridView.RowTemplate.Height = 25;
        dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView.Size = new Size(780, 433);
        dataGridView.TabIndex = 1;
        // 
        // Id
        // 
        Id.FillWeight = 5.21159F;
        Id.HeaderText = "شناسه";
        Id.Name = "Id";
        Id.ReadOnly = true;
        Id.Width = 170;
        // 
        // GroupName
        // 
        GroupName.FillWeight = 449.2386F;
        GroupName.HeaderText = "نام";
        GroupName.Name = "GroupName";
        GroupName.ReadOnly = true;
        GroupName.Width = 287;
        // 
        // Ordering
        // 
        Ordering.FillWeight = 28.58869F;
        Ordering.HeaderText = "ترتیب";
        Ordering.Name = "Ordering";
        Ordering.ReadOnly = true;
        Ordering.Width = 60;
        // 
        // InsertDateTime
        // 
        InsertDateTime.FillWeight = 14.03406F;
        InsertDateTime.HeaderText = "تاریخ ثبت";
        InsertDateTime.Name = "InsertDateTime";
        InsertDateTime.ReadOnly = true;
        InsertDateTime.Width = 220;
        // 
        // contextMenuStrip
        // 
        contextMenuStrip.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
        contextMenuStrip.Items.AddRange(new ToolStripItem[] { ContextMenuStripRefresh });
        contextMenuStrip.Name = "contextMenuStrip";
        contextMenuStrip.Size = new Size(122, 26);
        // 
        // ContextMenuStripRefresh
        // 
        ContextMenuStripRefresh.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        ContextMenuStripRefresh.Name = "ContextMenuStripRefresh";
        ContextMenuStripRefresh.Size = new Size(121, 22);
        ContextMenuStripRefresh.Text = "Refresh";
        ContextMenuStripRefresh.Click += ContextMenuStripRefresh_Click;
        // 
        // FrmGroupIndex
        // 
        AutoScaleDimensions = new SizeF(9F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(780, 457);
        Controls.Add(dataGridView);
        Controls.Add(menuStrip);
        Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        MainMenuStrip = menuStrip;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "FrmGroupIndex";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Group [Index]";
        Load += FrmGroupIndex_Load;
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        contextMenuStrip.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem mnuFile;
    private ToolStripMenuItem mnuFileInsert;
    private ToolStripMenuItem mnuFileUpdate;
    private ToolStripMenuItem mnuFileDelete;
    private DataGridView dataGridView;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn GroupName;
    private DataGridViewTextBoxColumn Ordering;
    private DataGridViewTextBoxColumn InsertDateTime;
    private ContextMenuStrip contextMenuStrip;
    private ToolStripMenuItem ContextMenuStripRefresh;
}