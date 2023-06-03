namespace ATNetCoreTelegramBot.WFA.UI;

partial class FrmUsers
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
        components = new System.ComponentModel.Container();
        dataGridView = new DataGridView();
        ChatID = new DataGridViewTextBoxColumn();
        UserName = new DataGridViewTextBoxColumn();
        FirstName = new DataGridViewTextBoxColumn();
        LastName = new DataGridViewTextBoxColumn();
        IsBot = new DataGridViewCheckBoxColumn();
        IsPremium = new DataGridViewCheckBoxColumn();
        LanguageCode = new DataGridViewTextBoxColumn();
        AddedToAttachmentMenu = new DataGridViewCheckBoxColumn();
        CanJoinGroups = new DataGridViewCheckBoxColumn();
        CanReadAllGroupMessages = new DataGridViewCheckBoxColumn();
        SupportsInlineQueries = new DataGridViewCheckBoxColumn();
        InsertDateTime = new DataGridViewTextBoxColumn();
        contextMenuStrip = new ContextMenuStrip(components);
        ContextMenuStripRefresh = new ToolStripMenuItem();
        menuStrip = new MenuStrip();
        mnuFile = new ToolStripMenuItem();
        mnuFileInsert = new ToolStripMenuItem();
        mnuFileUpdate = new ToolStripMenuItem();
        mnuFileDelete = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        contextMenuStrip.SuspendLayout();
        menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView
        // 
        dataGridView.AllowUserToAddRows = false;
        dataGridView.AllowUserToDeleteRows = false;
        dataGridView.BorderStyle = BorderStyle.Fixed3D;
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Columns.AddRange(new DataGridViewColumn[] { ChatID, UserName, FirstName, LastName, IsBot, IsPremium, LanguageCode, AddedToAttachmentMenu, CanJoinGroups, CanReadAllGroupMessages, SupportsInlineQueries, InsertDateTime });
        dataGridView.ContextMenuStrip = contextMenuStrip;
        dataGridView.Dock = DockStyle.Fill;
        dataGridView.Location = new Point(0, 24);
        dataGridView.Margin = new Padding(3, 2, 3, 2);
        dataGridView.Name = "dataGridView";
        dataGridView.ReadOnly = true;
        dataGridView.RightToLeft = RightToLeft.Yes;
        dataGridView.RowTemplate.Height = 25;
        dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView.Size = new Size(1980, 433);
        dataGridView.TabIndex = 3;
        // 
        // ChatID
        // 
        ChatID.Frozen = true;
        ChatID.HeaderText = "ChatID";
        ChatID.Name = "ChatID";
        ChatID.ReadOnly = true;
        ChatID.Width = 200;
        // 
        // UserName
        // 
        UserName.Frozen = true;
        UserName.HeaderText = "UserName";
        UserName.Name = "UserName";
        UserName.ReadOnly = true;
        UserName.Width = 200;
        // 
        // FirstName
        // 
        FirstName.HeaderText = "FirstName";
        FirstName.Name = "FirstName";
        FirstName.ReadOnly = true;
        FirstName.Width = 200;
        // 
        // LastName
        // 
        LastName.HeaderText = "LastName";
        LastName.Name = "LastName";
        LastName.ReadOnly = true;
        LastName.Width = 200;
        // 
        // IsBot
        // 
        IsBot.HeaderText = "Is Bot";
        IsBot.Name = "IsBot";
        IsBot.ReadOnly = true;
        // 
        // IsPremium
        // 
        IsPremium.HeaderText = "Is Premium";
        IsPremium.Name = "IsPremium";
        IsPremium.ReadOnly = true;
        // 
        // LanguageCode
        // 
        LanguageCode.HeaderText = "Language Code";
        LanguageCode.Name = "LanguageCode";
        LanguageCode.ReadOnly = true;
        LanguageCode.Width = 200;
        // 
        // AddedToAttachmentMenu
        // 
        AddedToAttachmentMenu.HeaderText = "Added To Attachment Menu";
        AddedToAttachmentMenu.Name = "AddedToAttachmentMenu";
        AddedToAttachmentMenu.ReadOnly = true;
        AddedToAttachmentMenu.Width = 250;
        // 
        // CanJoinGroups
        // 
        CanJoinGroups.HeaderText = "Can Join Groups";
        CanJoinGroups.Name = "CanJoinGroups";
        CanJoinGroups.ReadOnly = true;
        CanJoinGroups.Width = 200;
        // 
        // CanReadAllGroupMessages
        // 
        CanReadAllGroupMessages.HeaderText = "Can Read All Group Messages";
        CanReadAllGroupMessages.Name = "CanReadAllGroupMessages";
        CanReadAllGroupMessages.ReadOnly = true;
        CanReadAllGroupMessages.Width = 250;
        // 
        // SupportsInlineQueries
        // 
        SupportsInlineQueries.HeaderText = "Supports Inline Queries";
        SupportsInlineQueries.Name = "SupportsInlineQueries";
        SupportsInlineQueries.ReadOnly = true;
        SupportsInlineQueries.Width = 200;
        // 
        // InsertDateTime
        // 
        InsertDateTime.HeaderText = "Insert DateTime";
        InsertDateTime.Name = "InsertDateTime";
        InsertDateTime.ReadOnly = true;
        InsertDateTime.Width = 150;
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
        // 
        // menuStrip
        // 
        menuStrip.Items.AddRange(new ToolStripItem[] { mnuFile });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Padding = new Padding(5, 1, 0, 1);
        menuStrip.Size = new Size(1980, 24);
        menuStrip.TabIndex = 2;
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
        // 
        // mnuFileUpdate
        // 
        mnuFileUpdate.Name = "mnuFileUpdate";
        mnuFileUpdate.Size = new Size(112, 22);
        mnuFileUpdate.Text = "Update";
        // 
        // mnuFileDelete
        // 
        mnuFileDelete.Name = "mnuFileDelete";
        mnuFileDelete.Size = new Size(112, 22);
        mnuFileDelete.Text = "Delete";
        // 
        // FrmUsers
        // 
        AutoScaleDimensions = new SizeF(9F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1980, 457);
        Controls.Add(dataGridView);
        Controls.Add(menuStrip);
        Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmUsers";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "User [Index]";
        FormClosing += FrmUsers_FormClosing;
        Load += FrmUsers_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        contextMenuStrip.ResumeLayout(false);
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView;
    private MenuStrip menuStrip;
    private ToolStripMenuItem mnuFile;
    private ToolStripMenuItem mnuFileInsert;
    private ToolStripMenuItem mnuFileUpdate;
    private ToolStripMenuItem mnuFileDelete;
    private ContextMenuStrip contextMenuStrip;
    private ToolStripMenuItem ContextMenuStripRefresh;
    private DataGridViewTextBoxColumn ChatID;
    private DataGridViewTextBoxColumn UserName;
    private DataGridViewTextBoxColumn FirstName;
    private DataGridViewTextBoxColumn LastName;
    private DataGridViewCheckBoxColumn IsBot;
    private DataGridViewCheckBoxColumn IsPremium;
    private DataGridViewTextBoxColumn LanguageCode;
    private DataGridViewCheckBoxColumn AddedToAttachmentMenu;
    private DataGridViewCheckBoxColumn CanJoinGroups;
    private DataGridViewCheckBoxColumn CanReadAllGroupMessages;
    private DataGridViewCheckBoxColumn SupportsInlineQueries;
    private DataGridViewTextBoxColumn InsertDateTime;
}