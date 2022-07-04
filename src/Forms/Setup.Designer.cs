
namespace LogCord.Forms
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.desc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.t_github = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.man = new Guna.UI2.WinForms.Guna2Button();
            this.auto = new Guna.UI2.WinForms.Guna2Button();
            this.msgdialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.t_pp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(692, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(743, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // desc
            // 
            this.desc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.desc.IsContextMenuEnabled = false;
            this.desc.IsSelectionEnabled = false;
            this.desc.Location = new System.Drawing.Point(221, 153);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(282, 17);
            this.desc.TabIndex = 4;
            this.desc.Text = "hi! we need your token to gather devices on account.";
            this.desc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.title.IsContextMenuEnabled = false;
            this.title.IsSelectionEnabled = false;
            this.title.Location = new System.Drawing.Point(324, 121);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(77, 28);
            this.title.TabIndex = 13;
            this.title.Text = "logcord";
            this.title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_github
            // 
            this.t_github.Animated = true;
            this.t_github.BackColor = System.Drawing.Color.Transparent;
            this.t_github.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(27)))), ((int)(((byte)(93)))));
            this.t_github.BorderRadius = 4;
            this.t_github.BorderThickness = 1;
            this.t_github.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.t_github.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.t_github.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.t_github.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.t_github.FillColor = System.Drawing.Color.Transparent;
            this.t_github.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.t_github.ForeColor = System.Drawing.Color.DarkOrchid;
            this.t_github.Location = new System.Drawing.Point(259, 251);
            this.t_github.Name = "t_github";
            this.t_github.Size = new System.Drawing.Size(204, 45);
            this.t_github.TabIndex = 14;
            this.t_github.Text = "Github";
            this.t_github.Click += new System.EventHandler(this.t_github_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.man);
            this.guna2Panel1.Controls.Add(this.auto);
            this.guna2Panel1.Controls.Add(this.t_pp);
            this.guna2Panel1.Controls.Add(this.title);
            this.guna2Panel1.Controls.Add(this.t_github);
            this.guna2Panel1.Controls.Add(this.desc);
            this.guna2Panel1.Location = new System.Drawing.Point(34, 52);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(733, 346);
            this.guna2Panel1.TabIndex = 16;
            // 
            // man
            // 
            this.man.Animated = true;
            this.man.BackColor = System.Drawing.Color.Transparent;
            this.man.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.man.BorderRadius = 8;
            this.man.BorderThickness = 1;
            this.man.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.man.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(55)))));
            this.man.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.man.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.man.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.man.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.man.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.man.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.man.ForeColor = System.Drawing.Color.Silver;
            this.man.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(80)))));
            this.man.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.man.HoverState.ForeColor = System.Drawing.Color.White;
            this.man.Location = new System.Drawing.Point(369, 193);
            this.man.Name = "man";
            this.man.PressedDepth = 10;
            this.man.ShadowDecoration.BorderRadius = 1;
            this.man.ShadowDecoration.Depth = 5;
            this.man.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4);
            this.man.Size = new System.Drawing.Size(155, 41);
            this.man.TabIndex = 32;
            this.man.Text = "Manually";
            this.man.Click += new System.EventHandler(this.man_Click);
            // 
            // auto
            // 
            this.auto.Animated = true;
            this.auto.BackColor = System.Drawing.Color.Transparent;
            this.auto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.auto.BorderRadius = 8;
            this.auto.BorderThickness = 1;
            this.auto.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.auto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(55)))));
            this.auto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(100)))));
            this.auto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.auto.Enabled = false;
            this.auto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.auto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.auto.ForeColor = System.Drawing.Color.Silver;
            this.auto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(80)))));
            this.auto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.auto.HoverState.ForeColor = System.Drawing.Color.White;
            this.auto.Location = new System.Drawing.Point(208, 193);
            this.auto.Name = "auto";
            this.auto.PressedDepth = 10;
            this.auto.ShadowDecoration.BorderRadius = 1;
            this.auto.ShadowDecoration.Depth = 5;
            this.auto.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4);
            this.auto.Size = new System.Drawing.Size(155, 41);
            this.auto.TabIndex = 31;
            this.auto.Text = "Auto (soon)";
            this.auto.Click += new System.EventHandler(this.auto_Click);
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
            // t_pp
            // 
            this.t_pp.Animated = true;
            this.t_pp.AnimatedGIF = true;
            this.t_pp.BackColor = System.Drawing.Color.Transparent;
            this.t_pp.BorderColor = System.Drawing.Color.Transparent;
            this.t_pp.BorderRadius = 4;
            this.t_pp.BorderThickness = 1;
            this.t_pp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.t_pp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.t_pp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.t_pp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.t_pp.FillColor = System.Drawing.Color.Transparent;
            this.t_pp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.t_pp.ForeColor = System.Drawing.Color.White;
            this.t_pp.Image = global::LogCord.Properties.Resources.icons8_key_48px;
            this.t_pp.ImageSize = new System.Drawing.Size(50, 50);
            this.t_pp.Location = new System.Drawing.Point(316, 50);
            this.t_pp.Name = "t_pp";
            this.t_pp.Size = new System.Drawing.Size(93, 68);
            this.t_pp.TabIndex = 16;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.IsContextMenuEnabled = false;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(225, 169);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(274, 17);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "which method should we use to obtain your token?";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel desc;
        private Guna.UI2.WinForms.Guna2HtmlLabel title;
        private Guna.UI2.WinForms.Guna2Button t_github;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button t_pp;
        private Guna.UI2.WinForms.Guna2MessageDialog msgdialog;
        private Guna.UI2.WinForms.Guna2Button man;
        private Guna.UI2.WinForms.Guna2Button auto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}

