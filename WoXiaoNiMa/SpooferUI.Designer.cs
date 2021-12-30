namespace WoCaoNiMa
{
    partial class SpooferUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpooferUI));
            this.Spoofables = new System.Windows.Forms.Panel();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.SpoofOptions = new System.Windows.Forms.Panel();
            this.SpoofInfo = new System.Windows.Forms.RichTextBox();
            this.MainSpoofSettings = new System.Windows.Forms.Panel();
            this.LoadBackup = new System.Windows.Forms.Button();
            this.RandomSpoof = new System.Windows.Forms.Button();
            this.Langs = new System.Windows.Forms.ListBox();
            this.IsRedacted = new System.Windows.Forms.CheckBox();
            this.SaveSettingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SpoofOptions.SuspendLayout();
            this.MainSpoofSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spoofables
            // 
            this.Spoofables.AutoScroll = true;
            this.Spoofables.BackColor = System.Drawing.SystemColors.Control;
            this.Spoofables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spoofables.Location = new System.Drawing.Point(0, 0);
            this.Spoofables.Name = "Spoofables";
            this.Spoofables.Size = new System.Drawing.Size(530, 450);
            this.Spoofables.TabIndex = 0;
            // 
            // MainContainer
            // 
            this.MainContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.SpoofOptions);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.Spoofables);
            this.MainContainer.Size = new System.Drawing.Size(800, 450);
            this.MainContainer.SplitterDistance = 266;
            this.MainContainer.TabIndex = 1;
            // 
            // SpoofOptions
            // 
            this.SpoofOptions.Controls.Add(this.SpoofInfo);
            this.SpoofOptions.Controls.Add(this.MainSpoofSettings);
            this.SpoofOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpoofOptions.Location = new System.Drawing.Point(0, 0);
            this.SpoofOptions.Name = "SpoofOptions";
            this.SpoofOptions.Size = new System.Drawing.Size(266, 450);
            this.SpoofOptions.TabIndex = 2;
            // 
            // SpoofInfo
            // 
            this.SpoofInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpoofInfo.Location = new System.Drawing.Point(0, 144);
            this.SpoofInfo.Name = "SpoofInfo";
            this.SpoofInfo.ReadOnly = true;
            this.SpoofInfo.Size = new System.Drawing.Size(266, 306);
            this.SpoofInfo.TabIndex = 0;
            this.SpoofInfo.Text = "";
            this.SpoofInfo.WordWrap = false;
            // 
            // MainSpoofSettings
            // 
            this.MainSpoofSettings.Controls.Add(this.IsRedacted);
            this.MainSpoofSettings.Controls.Add(this.SaveSettingsBtn);
            this.MainSpoofSettings.Controls.Add(this.Langs);
            this.MainSpoofSettings.Controls.Add(this.LoadBackup);
            this.MainSpoofSettings.Controls.Add(this.RandomSpoof);
            this.MainSpoofSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainSpoofSettings.Location = new System.Drawing.Point(0, 0);
            this.MainSpoofSettings.Name = "MainSpoofSettings";
            this.MainSpoofSettings.Size = new System.Drawing.Size(266, 144);
            this.MainSpoofSettings.TabIndex = 0;
            // 
            // LoadBackup
            // 
            this.LoadBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBackup.Location = new System.Drawing.Point(0, 23);
            this.LoadBackup.Name = "LoadBackup";
            this.LoadBackup.Size = new System.Drawing.Size(266, 23);
            this.LoadBackup.TabIndex = 0;
            this.LoadBackup.Text = "Load Backup";
            this.LoadBackup.UseVisualStyleBackColor = true;
            this.LoadBackup.Click += new System.EventHandler(this.LoadBackup_Click);
            // 
            // RandomSpoof
            // 
            this.RandomSpoof.Dock = System.Windows.Forms.DockStyle.Top;
            this.RandomSpoof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomSpoof.Location = new System.Drawing.Point(0, 0);
            this.RandomSpoof.Name = "RandomSpoof";
            this.RandomSpoof.Size = new System.Drawing.Size(266, 23);
            this.RandomSpoof.TabIndex = 1;
            this.RandomSpoof.Text = "Random Spoof All";
            this.RandomSpoof.UseVisualStyleBackColor = true;
            // 
            // Langs
            // 
            this.Langs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Langs.FormattingEnabled = true;
            this.Langs.Location = new System.Drawing.Point(0, 88);
            this.Langs.Name = "Langs";
            this.Langs.Size = new System.Drawing.Size(266, 56);
            this.Langs.TabIndex = 0;
            // 
            // IsRedacted
            // 
            this.IsRedacted.AutoSize = true;
            this.IsRedacted.Dock = System.Windows.Forms.DockStyle.Top;
            this.IsRedacted.Location = new System.Drawing.Point(0, 71);
            this.IsRedacted.Name = "IsRedacted";
            this.IsRedacted.Size = new System.Drawing.Size(266, 17);
            this.IsRedacted.TabIndex = 0;
            this.IsRedacted.Text = "Redact";
            this.IsRedacted.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsBtn
            // 
            this.SaveSettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBtn.Location = new System.Drawing.Point(0, 46);
            this.SaveSettingsBtn.Name = "SaveSettingsBtn";
            this.SaveSettingsBtn.Size = new System.Drawing.Size(266, 25);
            this.SaveSettingsBtn.TabIndex = 2;
            this.SaveSettingsBtn.Text = "Save App Settings";
            this.SaveSettingsBtn.UseVisualStyleBackColor = true;
            this.SaveSettingsBtn.Click += new System.EventHandler(this.SaveSettingsBtn_Click);
            // 
            // SpooferUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpooferUI";
            this.Text = "Qīpiàn yònghù jièmiàn";
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.SpoofOptions.ResumeLayout(false);
            this.MainSpoofSettings.ResumeLayout(false);
            this.MainSpoofSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Spoofables;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.Panel SpoofOptions;
        private System.Windows.Forms.Button RandomSpoof;
        private System.Windows.Forms.Button LoadBackup;
        private System.Windows.Forms.RichTextBox SpoofInfo;
        private System.Windows.Forms.Panel MainSpoofSettings;
        private System.Windows.Forms.ListBox Langs;
        private System.Windows.Forms.CheckBox IsRedacted;
        private System.Windows.Forms.Button SaveSettingsBtn;
    }
}