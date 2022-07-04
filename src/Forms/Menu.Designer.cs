
namespace LogCord.Forms
{
    partial class Menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.desc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.platform = new Guna.UI2.WinForms.Guna2Button();
            this.version = new Guna.UI2.WinForms.Guna2Button();
            this.sessid = new Guna.UI2.WinForms.Guna2Button();
            this.loggedin = new Guna.UI2.WinForms.Guna2Button();
            this.select = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.counter = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.descpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.settingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dragctrl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.msgdialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.accountbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.b3 = new Guna.UI2.WinForms.Guna2Button();
            this.b2 = new Guna.UI2.WinForms.Guna2Button();
            this.includeBots = new Guna.UI2.WinForms.Guna2Button();
            this.chk_gateway_spoof = new Guna.UI2.WinForms.Guna2Button();
            this.clearData = new Guna.UI2.WinForms.Guna2Button();
            this.chk_hide_sessions = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain.SuspendLayout();
            this.descpanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            resources.ApplyResources(this.guna2ControlBox1, "guna2ControlBox1");
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            // 
            // guna2ControlBox2
            // 
            resources.ApplyResources(this.guna2ControlBox2, "guna2ControlBox2");
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.CustomClick = true;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel3, "guna2HtmlLabel3");
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.IsContextMenuEnabled = false;
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            // 
            // desc
            // 
            resources.ApplyResources(this.desc, "desc");
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.desc.IsContextMenuEnabled = false;
            this.desc.IsSelectionEnabled = false;
            this.desc.Name = "desc";
            this.desc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // platform
            // 
            this.platform.Animated = true;
            this.platform.BackColor = System.Drawing.Color.Transparent;
            this.platform.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(53)))), ((int)(((byte)(117)))));
            this.platform.BorderRadius = 4;
            this.platform.BorderThickness = 1;
            this.platform.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.platform.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.platform.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.platform.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.platform.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.platform, "platform");
            this.platform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.platform.Name = "platform";
            this.tooltip.SetToolTip(this.platform, resources.GetString("platform.ToolTip"));
            // 
            // version
            // 
            this.version.Animated = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(53)))), ((int)(((byte)(117)))));
            this.version.BorderRadius = 4;
            this.version.BorderThickness = 1;
            this.version.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.version.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.version.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.version.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.version.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.version, "version");
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.version.Name = "version";
            this.tooltip.SetToolTip(this.version, resources.GetString("version.ToolTip"));
            // 
            // sessid
            // 
            this.sessid.Animated = true;
            this.sessid.BackColor = System.Drawing.Color.Transparent;
            this.sessid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.sessid.BorderRadius = 4;
            this.sessid.BorderThickness = 1;
            this.sessid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sessid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sessid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sessid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sessid.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.sessid, "sessid");
            this.sessid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.sessid.Name = "sessid";
            this.tooltip.SetToolTip(this.sessid, resources.GetString("sessid.ToolTip"));
            this.sessid.DoubleClick += new System.EventHandler(this.sessid_DoubleClick);
            // 
            // loggedin
            // 
            this.loggedin.Animated = true;
            this.loggedin.BackColor = System.Drawing.Color.Transparent;
            this.loggedin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.loggedin.BorderRadius = 4;
            this.loggedin.BorderThickness = 1;
            this.loggedin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loggedin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loggedin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loggedin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loggedin.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.loggedin, "loggedin");
            this.loggedin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.loggedin.Name = "loggedin";
            this.tooltip.SetToolTip(this.loggedin, resources.GetString("loggedin.ToolTip"));
            // 
            // select
            // 
            this.select.AutoRoundedCorners = true;
            this.select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.select.BorderColor = System.Drawing.Color.Indigo;
            this.select.BorderRadius = 17;
            this.select.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.select.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.select.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.select, "select");
            this.select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.select.Name = "select";
            this.select.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // tooltip
            // 
            this.tooltip.AllowLinksHandling = true;
            this.tooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.tooltip.BorderColor = System.Drawing.Color.Black;
            this.tooltip.ForeColor = System.Drawing.Color.White;
            this.tooltip.MaximumSize = new System.Drawing.Size(0, 0);
            this.tooltip.ShowAlways = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.guna2Button2.BorderRadius = 4;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2Button2.Name = "guna2Button2";
            this.tooltip.SetToolTip(this.guna2Button2, resources.GetString("guna2Button2.ToolTip"));
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.guna2Button5.BorderRadius = 4;
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Button5, "guna2Button5");
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2Button5.Name = "guna2Button5";
            this.tooltip.SetToolTip(this.guna2Button5, resources.GetString("guna2Button5.ToolTip"));
            this.guna2Button5.Click += new System.EventHandler(this.clearData_Click);
            // 
            // counter
            // 
            this.counter.Animated = true;
            this.counter.BackColor = System.Drawing.Color.Transparent;
            this.counter.BorderColor = System.Drawing.Color.Transparent;
            this.counter.BorderRadius = 4;
            this.counter.BorderThickness = 1;
            this.counter.DefaultAutoSize = true;
            this.counter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.counter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.counter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.counter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.counter.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.counter, "counter");
            this.counter.ForeColor = System.Drawing.Color.DimGray;
            this.counter.Name = "counter";
            this.counter.PressedColor = System.Drawing.Color.Transparent;
            this.counter.Click += new System.EventHandler(this.counter_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.guna2Button3);
            this.panelMain.Controls.Add(this.descpanel);
            this.panelMain.Controls.Add(this.counter);
            this.panelMain.Controls.Add(this.b3);
            this.panelMain.Controls.Add(this.guna2HtmlLabel3);
            this.panelMain.Controls.Add(this.b2);
            this.panelMain.Controls.Add(this.platform);
            this.panelMain.Controls.Add(this.includeBots);
            this.panelMain.Controls.Add(this.version);
            this.panelMain.Controls.Add(this.select);
            this.panelMain.Controls.Add(this.sessid);
            this.panelMain.Controls.Add(this.loggedin);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // descpanel
            // 
            this.descpanel.Controls.Add(this.desc);
            resources.ApplyResources(this.descpanel, "descpanel");
            this.descpanel.Name = "descpanel";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.guna2Button1);
            this.settingsPanel.Controls.Add(this.guna2Button5);
            this.settingsPanel.Controls.Add(this.guna2HtmlLabel2);
            this.settingsPanel.Controls.Add(this.guna2HtmlLabel1);
            this.settingsPanel.Controls.Add(this.guna2Panel6);
            this.settingsPanel.Controls.Add(this.guna2Panel3);
            this.settingsPanel.Controls.Add(this.guna2Panel5);
            this.settingsPanel.Controls.Add(this.guna2Button2);
            resources.ApplyResources(this.settingsPanel, "settingsPanel");
            this.settingsPanel.Name = "settingsPanel";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel2, "guna2HtmlLabel2");
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.IsContextMenuEnabled = false;
            this.guna2HtmlLabel2.IsSelectionEnabled = false;
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Tomato;
            this.guna2HtmlLabel1.IsContextMenuEnabled = false;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.UseSystemCursors = true;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel12);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel6.Controls.Add(this.chk_gateway_spoof);
            resources.ApplyResources(this.guna2Panel6, "guna2Panel6");
            this.guna2Panel6.Name = "guna2Panel6";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel12, "guna2HtmlLabel12");
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel12.IsContextMenuEnabled = false;
            this.guna2HtmlLabel12.IsSelectionEnabled = false;
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel13, "guna2HtmlLabel13");
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel13.IsContextMenuEnabled = false;
            this.guna2HtmlLabel13.IsSelectionEnabled = false;
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.UseSystemCursors = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel3.Controls.Add(this.clearData);
            resources.ApplyResources(this.guna2Panel3, "guna2Panel3");
            this.guna2Panel3.Name = "guna2Panel3";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel4, "guna2HtmlLabel4");
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel4.IsContextMenuEnabled = false;
            this.guna2HtmlLabel4.IsSelectionEnabled = false;
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel5, "guna2HtmlLabel5");
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.IsContextMenuEnabled = false;
            this.guna2HtmlLabel5.IsSelectionEnabled = false;
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.UseSystemCursors = true;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel10);
            this.guna2Panel5.Controls.Add(this.chk_hide_sessions);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel11);
            resources.ApplyResources(this.guna2Panel5, "guna2Panel5");
            this.guna2Panel5.Name = "guna2Panel5";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel10, "guna2HtmlLabel10");
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel10.IsContextMenuEnabled = false;
            this.guna2HtmlLabel10.IsSelectionEnabled = false;
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel11, "guna2HtmlLabel11");
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel11.IsContextMenuEnabled = false;
            this.guna2HtmlLabel11.IsSelectionEnabled = false;
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.UseSystemCursors = true;
            // 
            // dragctrl
            // 
            this.dragctrl.DockIndicatorTransparencyValue = 0.6D;
            this.dragctrl.TargetControl = this;
            this.dragctrl.TransparentWhileDrag = false;
            // 
            // msgdialog
            // 
            this.msgdialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgdialog.Caption = null;
            this.msgdialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.msgdialog.Parent = null;
            this.msgdialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgdialog.Text = null;
            // 
            // accountbtn
            // 
            this.accountbtn.Animated = true;
            this.accountbtn.BackColor = System.Drawing.Color.Transparent;
            this.accountbtn.BorderColor = System.Drawing.Color.Indigo;
            this.accountbtn.BorderRadius = 4;
            this.accountbtn.BorderThickness = 1;
            this.accountbtn.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.accountbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accountbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accountbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accountbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accountbtn.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.accountbtn, "accountbtn");
            this.accountbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountbtn.Image = global::LogCord.Properties.Resources.icons8_contacts;
            this.accountbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountbtn.Name = "accountbtn";
            this.accountbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountbtn.Click += new System.EventHandler(this.accountbtn_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.guna2Button3.BorderRadius = 4;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Button3, "guna2Button3");
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2Button3.Image = global::LogCord.Properties.Resources.settings;
            this.guna2Button3.Name = "guna2Button3";
            this.tooltip.SetToolTip(this.guna2Button3, resources.GetString("guna2Button3.ToolTip"));
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // b3
            // 
            this.b3.Animated = true;
            this.b3.BackColor = System.Drawing.Color.Transparent;
            this.b3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.b3.BorderRadius = 4;
            this.b3.BorderThickness = 1;
            this.b3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b3.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.b3, "b3");
            this.b3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b3.Image = global::LogCord.Properties.Resources.save;
            this.b3.Name = "b3";
            this.tooltip.SetToolTip(this.b3, resources.GetString("b3.ToolTip"));
            this.b3.Click += new System.EventHandler(this.SaveSessions_Click);
            // 
            // b2
            // 
            this.b2.Animated = true;
            this.b2.BackColor = System.Drawing.Color.Transparent;
            this.b2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.b2.BorderRadius = 4;
            this.b2.BorderThickness = 1;
            this.b2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b2.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.b2, "b2");
            this.b2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b2.Image = global::LogCord.Properties.Resources.github;
            this.b2.Name = "b2";
            this.tooltip.SetToolTip(this.b2, resources.GetString("b2.ToolTip"));
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // includeBots
            // 
            this.includeBots.Animated = true;
            this.includeBots.BackColor = System.Drawing.Color.Transparent;
            this.includeBots.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.includeBots.BorderRadius = 4;
            this.includeBots.BorderThickness = 1;
            this.includeBots.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.includeBots.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.includeBots.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.includeBots.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.includeBots.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.includeBots.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.includeBots, "includeBots");
            this.includeBots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.includeBots.Image = global::LogCord.Properties.Resources.bot;
            this.includeBots.Name = "includeBots";
            this.tooltip.SetToolTip(this.includeBots, resources.GetString("includeBots.ToolTip"));
            this.includeBots.Click += new System.EventHandler(this.includeBots_Click);
            // 
            // chk_gateway_spoof
            // 
            this.chk_gateway_spoof.Animated = true;
            this.chk_gateway_spoof.BackColor = System.Drawing.Color.Transparent;
            this.chk_gateway_spoof.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.chk_gateway_spoof.BorderRadius = 4;
            this.chk_gateway_spoof.BorderThickness = 1;
            this.chk_gateway_spoof.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.chk_gateway_spoof.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.chk_gateway_spoof.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.chk_gateway_spoof.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.chk_gateway_spoof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chk_gateway_spoof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.chk_gateway_spoof.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.chk_gateway_spoof, "chk_gateway_spoof");
            this.chk_gateway_spoof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chk_gateway_spoof.Image = global::LogCord.Properties.Resources.bot;
            this.chk_gateway_spoof.Name = "chk_gateway_spoof";
            this.tooltip.SetToolTip(this.chk_gateway_spoof, resources.GetString("chk_gateway_spoof.ToolTip"));
            this.chk_gateway_spoof.Click += new System.EventHandler(this.chk_gateway_spoof_Click);
            // 
            // clearData
            // 
            this.clearData.Animated = true;
            this.clearData.BackColor = System.Drawing.Color.Transparent;
            this.clearData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.clearData.BorderRadius = 4;
            this.clearData.BorderThickness = 1;
            this.clearData.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.clearData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearData.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.clearData, "clearData");
            this.clearData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clearData.Image = global::LogCord.Properties.Resources.erase;
            this.clearData.Name = "clearData";
            this.clearData.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // chk_hide_sessions
            // 
            this.chk_hide_sessions.Animated = true;
            this.chk_hide_sessions.BackColor = System.Drawing.Color.Transparent;
            this.chk_hide_sessions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.chk_hide_sessions.BorderRadius = 4;
            this.chk_hide_sessions.BorderThickness = 1;
            this.chk_hide_sessions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.chk_hide_sessions.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.chk_hide_sessions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.chk_hide_sessions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.chk_hide_sessions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chk_hide_sessions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.chk_hide_sessions.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.chk_hide_sessions, "chk_hide_sessions");
            this.chk_hide_sessions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chk_hide_sessions.Image = global::LogCord.Properties.Resources.hide;
            this.chk_hide_sessions.Name = "chk_hide_sessions";
            this.chk_hide_sessions.Click += new System.EventHandler(this.chk_hide_sessions_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2Button1.Name = "guna2Button1";
            this.tooltip.SetToolTip(this.guna2Button1, resources.GetString("guna2Button1.ToolTip"));
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.accountbtn);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Shown += new System.EventHandler(this.FormOnShown);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.descpanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel desc;
        private Guna.UI2.WinForms.Guna2Button platform;
        private Guna.UI2.WinForms.Guna2Button version;
        private Guna.UI2.WinForms.Guna2Button sessid;
        private Guna.UI2.WinForms.Guna2Button loggedin;
        private Guna.UI2.WinForms.Guna2ComboBox select;
        private Guna.UI2.WinForms.Guna2Button includeBots;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltip;
        private Guna.UI2.WinForms.Guna2Button b2;
        private Guna.UI2.WinForms.Guna2Button b3;
        private Guna.UI2.WinForms.Guna2Button counter;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel descpanel;
        private Guna.UI2.WinForms.Guna2Panel settingsPanel;
        private Guna.UI2.WinForms.Guna2Button chk_hide_sessions;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button clearData;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2DragControl dragctrl;
        private Guna.UI2.WinForms.Guna2Button chk_gateway_spoof;
        private Guna.UI2.WinForms.Guna2MessageDialog msgdialog;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button accountbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

