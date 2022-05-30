namespace renameExtension
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.TabControl();
            this.tbpFolder = new System.Windows.Forms.TabPage();
            this.txtOldExtension = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewExtension = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmdRename = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmdBrowse = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpFile = new System.Windows.Forms.TabPage();
            this.rbAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbTagA = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtOldExtensionFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewExtensionFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMainPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmdRenameFile = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmdBrowseFile = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCountFile = new System.Windows.Forms.Label();
            this.lstSelectedFiles = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lklEmail = new System.Windows.Forms.LinkLabel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.tbpFolder.SuspendLayout();
            this.tbpFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rename your extension fast";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tbpFolder);
            this.pnlContent.Controls.Add(this.tbpFile);
            this.pnlContent.Location = new System.Drawing.Point(12, 106);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.SelectedIndex = 0;
            this.pnlContent.Size = new System.Drawing.Size(376, 463);
            this.pnlContent.TabIndex = 1;
            // 
            // tbpFolder
            // 
            this.tbpFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpFolder.Controls.Add(this.txtOldExtension);
            this.tbpFolder.Controls.Add(this.txtNewExtension);
            this.tbpFolder.Controls.Add(this.txtPath);
            this.tbpFolder.Controls.Add(this.cmdRename);
            this.tbpFolder.Controls.Add(this.cmdBrowse);
            this.tbpFolder.Controls.Add(this.lstFiles);
            this.tbpFolder.Controls.Add(this.lblCount);
            this.tbpFolder.Controls.Add(this.label6);
            this.tbpFolder.Controls.Add(this.label5);
            this.tbpFolder.Controls.Add(this.label3);
            this.tbpFolder.Controls.Add(this.label2);
            this.tbpFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbpFolder.Location = new System.Drawing.Point(4, 30);
            this.tbpFolder.Name = "tbpFolder";
            this.tbpFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFolder.Size = new System.Drawing.Size(368, 429);
            this.tbpFolder.TabIndex = 0;
            this.tbpFolder.Text = "Rename in folder";
            // 
            // txtOldExtension
            // 
            this.txtOldExtension.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldExtension.DefaultText = "";
            this.txtOldExtension.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldExtension.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldExtension.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldExtension.DisabledState.Parent = this.txtOldExtension;
            this.txtOldExtension.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldExtension.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldExtension.FocusedState.Parent = this.txtOldExtension;
            this.txtOldExtension.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOldExtension.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldExtension.HoverState.Parent = this.txtOldExtension;
            this.txtOldExtension.Location = new System.Drawing.Point(11, 117);
            this.txtOldExtension.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.txtOldExtension.MaxLength = 10;
            this.txtOldExtension.Name = "txtOldExtension";
            this.txtOldExtension.PasswordChar = '\0';
            this.txtOldExtension.PlaceholderText = "";
            this.txtOldExtension.SelectedText = "";
            this.txtOldExtension.ShadowDecoration.Parent = this.txtOldExtension;
            this.txtOldExtension.Size = new System.Drawing.Size(101, 30);
            this.txtOldExtension.TabIndex = 5;
            // 
            // txtNewExtension
            // 
            this.txtNewExtension.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewExtension.DefaultText = "";
            this.txtNewExtension.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewExtension.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewExtension.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewExtension.DisabledState.Parent = this.txtNewExtension;
            this.txtNewExtension.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewExtension.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewExtension.FocusedState.Parent = this.txtNewExtension;
            this.txtNewExtension.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewExtension.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewExtension.HoverState.Parent = this.txtNewExtension;
            this.txtNewExtension.Location = new System.Drawing.Point(124, 117);
            this.txtNewExtension.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNewExtension.MaxLength = 10;
            this.txtNewExtension.Name = "txtNewExtension";
            this.txtNewExtension.PasswordChar = '\0';
            this.txtNewExtension.PlaceholderText = "";
            this.txtNewExtension.SelectedText = "";
            this.txtNewExtension.ShadowDecoration.Parent = this.txtNewExtension;
            this.txtNewExtension.Size = new System.Drawing.Size(108, 30);
            this.txtNewExtension.TabIndex = 5;
            // 
            // txtPath
            // 
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.DefaultText = "";
            this.txtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.DisabledState.Parent = this.txtPath;
            this.txtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.FocusedState.Parent = this.txtPath;
            this.txtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.HoverState.Parent = this.txtPath;
            this.txtPath.Location = new System.Drawing.Point(7, 49);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderText = "";
            this.txtPath.ReadOnly = true;
            this.txtPath.SelectedText = "";
            this.txtPath.ShadowDecoration.Parent = this.txtPath;
            this.txtPath.Size = new System.Drawing.Size(258, 30);
            this.txtPath.TabIndex = 5;
            // 
            // cmdRename
            // 
            this.cmdRename.CheckedState.Parent = this.cmdRename;
            this.cmdRename.CustomImages.Parent = this.cmdRename;
            this.cmdRename.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmdRename.ForeColor = System.Drawing.Color.White;
            this.cmdRename.HoverState.Parent = this.cmdRename;
            this.cmdRename.Location = new System.Drawing.Point(111, 374);
            this.cmdRename.Name = "cmdRename";
            this.cmdRename.ShadowDecoration.Parent = this.cmdRename;
            this.cmdRename.Size = new System.Drawing.Size(146, 45);
            this.cmdRename.TabIndex = 4;
            this.cmdRename.Text = "Rename";
            this.cmdRename.Click += new System.EventHandler(this.cmdRename_Click);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.CheckedState.Parent = this.cmdBrowse;
            this.cmdBrowse.CustomImages.Parent = this.cmdBrowse;
            this.cmdBrowse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmdBrowse.ForeColor = System.Drawing.Color.White;
            this.cmdBrowse.HoverState.Parent = this.cmdBrowse;
            this.cmdBrowse.Location = new System.Drawing.Point(272, 49);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.ShadowDecoration.Parent = this.cmdBrowse;
            this.cmdBrowse.Size = new System.Drawing.Size(93, 30);
            this.cmdBrowse.TabIndex = 4;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click_1);
            // 
            // lstFiles
            // 
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 21;
            this.lstFiles.Location = new System.Drawing.Point(7, 189);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(355, 126);
            this.lstFiles.TabIndex = 2;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblCount.Location = new System.Drawing.Point(6, 323);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 21);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Count: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(118, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "New extension";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(7, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Old extension";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(7, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Files in folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chose the folder that you want rename yours files";
            // 
            // tbpFile
            // 
            this.tbpFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpFile.Controls.Add(this.rbAll);
            this.tbpFile.Controls.Add(this.rbTagA);
            this.tbpFile.Controls.Add(this.txtOldExtensionFile);
            this.tbpFile.Controls.Add(this.txtNewExtensionFile);
            this.tbpFile.Controls.Add(this.txtMainPath);
            this.tbpFile.Controls.Add(this.cmdRenameFile);
            this.tbpFile.Controls.Add(this.cmdBrowseFile);
            this.tbpFile.Controls.Add(this.label9);
            this.tbpFile.Controls.Add(this.lblCountFile);
            this.tbpFile.Controls.Add(this.lstSelectedFiles);
            this.tbpFile.Controls.Add(this.label7);
            this.tbpFile.Controls.Add(this.label8);
            this.tbpFile.Controls.Add(this.label4);
            this.tbpFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbpFile.Location = new System.Drawing.Point(4, 30);
            this.tbpFile.Name = "tbpFile";
            this.tbpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFile.Size = new System.Drawing.Size(368, 429);
            this.tbpFile.TabIndex = 1;
            this.tbpFile.Text = "Rename in files";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAll.CheckedState.BorderThickness = 0;
            this.rbAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAll.CheckedState.InnerOffset = -4;
            this.rbAll.Location = new System.Drawing.Point(272, 117);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(75, 25);
            this.rbAll.TabIndex = 17;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All text";
            this.rbAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAll.UncheckedState.BorderThickness = 2;
            this.rbAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbTagA
            // 
            this.rbTagA.AutoSize = true;
            this.rbTagA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTagA.CheckedState.BorderThickness = 0;
            this.rbTagA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTagA.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbTagA.CheckedState.InnerOffset = -4;
            this.rbTagA.Location = new System.Drawing.Point(272, 86);
            this.rbTagA.Name = "rbTagA";
            this.rbTagA.Size = new System.Drawing.Size(86, 25);
            this.rbTagA.TabIndex = 17;
            this.rbTagA.Text = "In a tags";
            this.rbTagA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTagA.UncheckedState.BorderThickness = 2;
            this.rbTagA.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTagA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txtOldExtensionFile
            // 
            this.txtOldExtensionFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldExtensionFile.DefaultText = "";
            this.txtOldExtensionFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldExtensionFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldExtensionFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldExtensionFile.DisabledState.Parent = this.txtOldExtensionFile;
            this.txtOldExtensionFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldExtensionFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldExtensionFile.FocusedState.Parent = this.txtOldExtensionFile;
            this.txtOldExtensionFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOldExtensionFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldExtensionFile.HoverState.Parent = this.txtOldExtensionFile;
            this.txtOldExtensionFile.Location = new System.Drawing.Point(6, 325);
            this.txtOldExtensionFile.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.txtOldExtensionFile.MaxLength = 10;
            this.txtOldExtensionFile.Name = "txtOldExtensionFile";
            this.txtOldExtensionFile.PasswordChar = '\0';
            this.txtOldExtensionFile.PlaceholderText = "";
            this.txtOldExtensionFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOldExtensionFile.SelectedText = "";
            this.txtOldExtensionFile.ShadowDecoration.Parent = this.txtOldExtensionFile;
            this.txtOldExtensionFile.Size = new System.Drawing.Size(108, 30);
            this.txtOldExtensionFile.TabIndex = 16;
            this.txtOldExtensionFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNewExtensionFile
            // 
            this.txtNewExtensionFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewExtensionFile.DefaultText = "";
            this.txtNewExtensionFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewExtensionFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewExtensionFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewExtensionFile.DisabledState.Parent = this.txtNewExtensionFile;
            this.txtNewExtensionFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewExtensionFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewExtensionFile.FocusedState.Parent = this.txtNewExtensionFile;
            this.txtNewExtensionFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewExtensionFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewExtensionFile.HoverState.Parent = this.txtNewExtensionFile;
            this.txtNewExtensionFile.Location = new System.Drawing.Point(121, 325);
            this.txtNewExtensionFile.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNewExtensionFile.MaxLength = 10;
            this.txtNewExtensionFile.Name = "txtNewExtensionFile";
            this.txtNewExtensionFile.PasswordChar = '\0';
            this.txtNewExtensionFile.PlaceholderText = "";
            this.txtNewExtensionFile.SelectedText = "";
            this.txtNewExtensionFile.ShadowDecoration.Parent = this.txtNewExtensionFile;
            this.txtNewExtensionFile.Size = new System.Drawing.Size(108, 30);
            this.txtNewExtensionFile.TabIndex = 16;
            // 
            // txtMainPath
            // 
            this.txtMainPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMainPath.DefaultText = "";
            this.txtMainPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMainPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMainPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMainPath.DisabledState.Parent = this.txtMainPath;
            this.txtMainPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMainPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMainPath.FocusedState.Parent = this.txtMainPath;
            this.txtMainPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMainPath.HoverState.Parent = this.txtMainPath;
            this.txtMainPath.Location = new System.Drawing.Point(83, 254);
            this.txtMainPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMainPath.Name = "txtMainPath";
            this.txtMainPath.PasswordChar = '\0';
            this.txtMainPath.PlaceholderText = "";
            this.txtMainPath.ReadOnly = true;
            this.txtMainPath.SelectedText = "";
            this.txtMainPath.ShadowDecoration.Parent = this.txtMainPath;
            this.txtMainPath.Size = new System.Drawing.Size(278, 30);
            this.txtMainPath.TabIndex = 16;
            // 
            // cmdRenameFile
            // 
            this.cmdRenameFile.CheckedState.Parent = this.cmdRenameFile;
            this.cmdRenameFile.CustomImages.Parent = this.cmdRenameFile;
            this.cmdRenameFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmdRenameFile.ForeColor = System.Drawing.Color.White;
            this.cmdRenameFile.HoverState.Parent = this.cmdRenameFile;
            this.cmdRenameFile.Location = new System.Drawing.Point(111, 374);
            this.cmdRenameFile.Name = "cmdRenameFile";
            this.cmdRenameFile.ShadowDecoration.Parent = this.cmdRenameFile;
            this.cmdRenameFile.Size = new System.Drawing.Size(146, 45);
            this.cmdRenameFile.TabIndex = 15;
            this.cmdRenameFile.Text = "Rename";
            this.cmdRenameFile.Click += new System.EventHandler(this.cmdRenameFile_Click);
            // 
            // cmdBrowseFile
            // 
            this.cmdBrowseFile.CheckedState.Parent = this.cmdBrowseFile;
            this.cmdBrowseFile.CustomImages.Parent = this.cmdBrowseFile;
            this.cmdBrowseFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmdBrowseFile.ForeColor = System.Drawing.Color.White;
            this.cmdBrowseFile.HoverState.Parent = this.cmdBrowseFile;
            this.cmdBrowseFile.Location = new System.Drawing.Point(272, 50);
            this.cmdBrowseFile.Name = "cmdBrowseFile";
            this.cmdBrowseFile.ShadowDecoration.Parent = this.cmdBrowseFile;
            this.cmdBrowseFile.Size = new System.Drawing.Size(93, 30);
            this.cmdBrowseFile.TabIndex = 14;
            this.cmdBrowseFile.Text = "Browse";
            this.cmdBrowseFile.Click += new System.EventHandler(this.cmdBrowseFile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label9.Location = new System.Drawing.Point(3, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Caminho";
            // 
            // lblCountFile
            // 
            this.lblCountFile.AutoSize = true;
            this.lblCountFile.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblCountFile.Location = new System.Drawing.Point(5, 226);
            this.lblCountFile.Name = "lblCountFile";
            this.lblCountFile.Size = new System.Drawing.Size(68, 21);
            this.lblCountFile.TabIndex = 13;
            this.lblCountFile.Text = "Count: 0";
            // 
            // lstSelectedFiles
            // 
            this.lstSelectedFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSelectedFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lstSelectedFiles.FormattingEnabled = true;
            this.lstSelectedFiles.ItemHeight = 21;
            this.lstSelectedFiles.Location = new System.Drawing.Point(9, 50);
            this.lstSelectedFiles.Name = "lstSelectedFiles";
            this.lstSelectedFiles.Size = new System.Drawing.Size(255, 168);
            this.lstSelectedFiles.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label7.Location = new System.Drawing.Point(117, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "New extension";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(6, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Old extension";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(-4, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chose the files that you want rename yours content";
            // 
            // lklEmail
            // 
            this.lklEmail.AutoSize = true;
            this.lklEmail.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklEmail.Location = new System.Drawing.Point(265, 10);
            this.lklEmail.Name = "lklEmail";
            this.lklEmail.Size = new System.Drawing.Size(123, 14);
            this.lklEmail.TabIndex = 2;
            this.lklEmail.TabStop = true;
            this.lklEmail.Text = "madembo18@gmail.com";
            this.lklEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEmail_LinkClicked);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblHelp.Location = new System.Drawing.Point(12, 9);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(42, 21);
            this.lblHelp.TabIndex = 14;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 583);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lklEmail);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Extension";
            this.pnlContent.ResumeLayout(false);
            this.tbpFolder.ResumeLayout(false);
            this.tbpFolder.PerformLayout();
            this.tbpFile.ResumeLayout(false);
            this.tbpFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl pnlContent;
        private System.Windows.Forms.TabPage tbpFolder;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lklEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstSelectedFiles;
        private System.Windows.Forms.Label lblCountFile;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2GradientButton cmdBrowse;
        private Guna.UI2.WinForms.Guna2GradientButton cmdRename;
        private Guna.UI2.WinForms.Guna2GradientButton cmdBrowseFile;
        private Guna.UI2.WinForms.Guna2GradientButton cmdRenameFile;
        private Guna.UI2.WinForms.Guna2TextBox txtOldExtension;
        private Guna.UI2.WinForms.Guna2TextBox txtNewExtension;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI2.WinForms.Guna2TextBox txtNewExtensionFile;
        private Guna.UI2.WinForms.Guna2TextBox txtMainPath;
        private Guna.UI2.WinForms.Guna2TextBox txtOldExtensionFile;
        private System.Windows.Forms.Label lblHelp;
        private Guna.UI2.WinForms.Guna2RadioButton rbAll;
        private Guna.UI2.WinForms.Guna2RadioButton rbTagA;
    }
}

