namespace ProjectPRN211
{
    partial class frmMemberManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberManagement));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvMember = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRole = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.txtLastName = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMember
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMember.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMember.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMember.EnableHeadersVisualStyles = false;
            this.dgvMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMember.Location = new System.Drawing.Point(12, 226);
            this.dgvMember.MultiSelect = false;
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowHeadersVisible = false;
            this.dgvMember.RowHeadersWidth = 55;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(758, 279);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvMember.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMember.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMember.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMember.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMember.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMember.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMember.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMember.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMember.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMember.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMember.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvMember.ThemeStyle.ReadOnly = true;
            this.dgvMember.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMember.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMember.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMember.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMember.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMember.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMember.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Member Management";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(488, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Role";
            // 
            // cboRole
            // 
            this.cboRole.BackColor = System.Drawing.Color.Transparent;
            this.cboRole.BaseColor = System.Drawing.Color.White;
            this.cboRole.BorderColor = System.Drawing.Color.Silver;
            this.cboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FocusedColor = System.Drawing.Color.Empty;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRole.ForeColor = System.Drawing.Color.Black;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "User",
            "All"});
            this.cboRole.Location = new System.Drawing.Point(576, 142);
            this.cboRole.Name = "cboRole";
            this.cboRole.OnHoverItemBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.cboRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboRole.Size = new System.Drawing.Size(160, 26);
            this.cboRole.TabIndex = 13;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Search";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BaseColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColor = System.Drawing.Color.Silver;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFirstName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.Location = new System.Drawing.Point(150, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(160, 30);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(150, 100);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(160, 30);
            this.txtUsername.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(150, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(160, 30);
            this.txtPassword.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(150, 178);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(160, 30);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.BaseColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.Silver;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLastName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.Location = new System.Drawing.Point(576, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(160, 30);
            this.txtLastName.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(576, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(160, 30);
            this.txtEmail.TabIndex = 14;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImage = global::ProjectPRN211.Properties.Resources.Line_4;
            this.gunaPanel1.Location = new System.Drawing.Point(43, 48);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(693, 1);
            this.gunaPanel1.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges1;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.IdleBorderRadius = 1;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(492, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 1;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.onHoverState.BorderRadius = 1;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.OnIdleState.BorderRadius = 1;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.OnPressedState.BorderRadius = 1;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(98, 29);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowMouseEffects = true;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AnimationSpeed = 200;
            this.btnDelete.AutoGenerateColors = false;
            this.btnDelete.AutoRoundBorders = false;
            this.btnDelete.AutoSizeLeftIcon = true;
            this.btnDelete.AutoSizeRightIcon = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.ButtonTextMarginLeft = 0;
            this.btnDelete.ColorContrastOnClick = 45;
            this.btnDelete.ColorContrastOnHover = 45;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDelete.CustomizableEdges = borderEdges2;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelete.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelete.IconMarginLeft = 11;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelete.IconSize = 25;
            this.btnDelete.IdleBorderColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.IdleBorderRadius = 1;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.IdleIconLeftImage = null;
            this.btnDelete.IdleIconRightImage = null;
            this.btnDelete.IndicateFocus = false;
            this.btnDelete.Location = new System.Drawing.Point(638, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.OnDisabledState.BorderRadius = 1;
            this.btnDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnDisabledState.BorderThickness = 1;
            this.btnDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.OnDisabledState.IconLeftImage = null;
            this.btnDelete.OnDisabledState.IconRightImage = null;
            this.btnDelete.onHoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.onHoverState.BorderRadius = 1;
            this.btnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.onHoverState.BorderThickness = 1;
            this.btnDelete.onHoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.onHoverState.IconLeftImage = null;
            this.btnDelete.onHoverState.IconRightImage = null;
            this.btnDelete.OnIdleState.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.OnIdleState.BorderRadius = 1;
            this.btnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnIdleState.BorderThickness = 1;
            this.btnDelete.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnIdleState.IconLeftImage = null;
            this.btnDelete.OnIdleState.IconRightImage = null;
            this.btnDelete.OnPressedState.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.OnPressedState.BorderRadius = 1;
            this.btnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnPressedState.BorderThickness = 1;
            this.btnDelete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnPressedState.IconLeftImage = null;
            this.btnDelete.OnPressedState.IconRightImage = null;
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextMarginLeft = 0;
            this.btnDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelete.UseDefaultRadiusAndThickness = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowAnimations = true;
            this.bunifuButton3.AllowMouseEffects = true;
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.AutoRoundBorders = false;
            this.bunifuButton3.AutoSizeLeftIcon = true;
            this.bunifuButton3.AutoSizeRightIcon = true;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.DarkCyan;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.ButtonText = "Menu";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges3;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton3.IconSize = 25;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.CadetBlue;
            this.bunifuButton3.IdleBorderRadius = 1;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(12, 514);
            this.bunifuButton3.Name = "bunifuButton3";
            this.bunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.OnDisabledState.BorderRadius = 1;
            this.bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnDisabledState.BorderThickness = 1;
            this.bunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.OnDisabledState.IconLeftImage = null;
            this.bunifuButton3.OnDisabledState.IconRightImage = null;
            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuButton3.onHoverState.BorderRadius = 1;
            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.onHoverState.BorderThickness = 1;
            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.onHoverState.IconLeftImage = null;
            this.bunifuButton3.onHoverState.IconRightImage = null;
            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.CadetBlue;
            this.bunifuButton3.OnIdleState.BorderRadius = 1;
            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnIdleState.BorderThickness = 1;
            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnIdleState.IconLeftImage = null;
            this.bunifuButton3.OnIdleState.IconRightImage = null;
            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.DarkCyan;
            this.bunifuButton3.OnPressedState.BorderRadius = 1;
            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnPressedState.BorderThickness = 1;
            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnPressedState.IconLeftImage = null;
            this.bunifuButton3.OnPressedState.IconRightImage = null;
            this.bunifuButton3.Size = new System.Drawing.Size(118, 39);
            this.bunifuButton3.TabIndex = 19;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.AllowAnimations = true;
            this.bunifuButton4.AllowMouseEffects = true;
            this.bunifuButton4.AllowToggling = false;
            this.bunifuButton4.AnimationSpeed = 200;
            this.bunifuButton4.AutoGenerateColors = false;
            this.bunifuButton4.AutoRoundBorders = false;
            this.bunifuButton4.AutoSizeLeftIcon = true;
            this.bunifuButton4.AutoSizeRightIcon = true;
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackColor1 = System.Drawing.Color.DarkCyan;
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.ButtonText = "Exit";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.ColorContrastOnClick = 45;
            this.bunifuButton4.ColorContrastOnHover = 45;
            this.bunifuButton4.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton4.CustomizableEdges = borderEdges4;
            this.bunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton4.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton4.IconMarginLeft = 11;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton4.IconSize = 25;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.CadetBlue;
            this.bunifuButton4.IdleBorderRadius = 1;
            this.bunifuButton4.IdleBorderThickness = 1;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.IndicateFocus = false;
            this.bunifuButton4.Location = new System.Drawing.Point(652, 514);
            this.bunifuButton4.Name = "bunifuButton4";
            this.bunifuButton4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.OnDisabledState.BorderRadius = 1;
            this.bunifuButton4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnDisabledState.BorderThickness = 1;
            this.bunifuButton4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.OnDisabledState.IconLeftImage = null;
            this.bunifuButton4.OnDisabledState.IconRightImage = null;
            this.bunifuButton4.onHoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuButton4.onHoverState.BorderRadius = 1;
            this.bunifuButton4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.onHoverState.BorderThickness = 1;
            this.bunifuButton4.onHoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuButton4.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.onHoverState.IconLeftImage = null;
            this.bunifuButton4.onHoverState.IconRightImage = null;
            this.bunifuButton4.OnIdleState.BorderColor = System.Drawing.Color.CadetBlue;
            this.bunifuButton4.OnIdleState.BorderRadius = 1;
            this.bunifuButton4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnIdleState.BorderThickness = 1;
            this.bunifuButton4.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.bunifuButton4.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnIdleState.IconLeftImage = null;
            this.bunifuButton4.OnIdleState.IconRightImage = null;
            this.bunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.DarkCyan;
            this.bunifuButton4.OnPressedState.BorderRadius = 1;
            this.bunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnPressedState.BorderThickness = 1;
            this.bunifuButton4.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnPressedState.IconLeftImage = null;
            this.bunifuButton4.OnPressedState.IconRightImage = null;
            this.bunifuButton4.Size = new System.Drawing.Size(118, 39);
            this.bunifuButton4.TabIndex = 20;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton4.TextMarginLeft = 0;
            this.bunifuButton4.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton4.UseDefaultRadiusAndThickness = true;
            this.bunifuButton4.Click += new System.EventHandler(this.bunifuButton4_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(780, 562);
            this.Controls.Add(this.bunifuButton4);
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMember);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberManagement";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox cboRole;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtFirstName;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaTextBox txtLastName;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
    }
}