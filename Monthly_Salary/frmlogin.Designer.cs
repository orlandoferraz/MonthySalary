namespace Monthly_Salary
{
    partial class frmlogin
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
            this.btnok = new MetroFramework.Controls.MetroButton();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.checkremember = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnok.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnok.Highlight = true;
            this.btnok.Location = new System.Drawing.Point(206, 208);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(107, 30);
            this.btnok.Style = MetroFramework.MetroColorStyle.Green;
            this.btnok.TabIndex = 3;
            this.btnok.Text = "Okay";
            this.btnok.UseSelectable = true;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btncancel.Highlight = true;
            this.btncancel.Location = new System.Drawing.Point(337, 208);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(107, 30);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseSelectable = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(140, 79);
            this.txtusername.MaxLength = 100;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PromptText = "Your User Name";
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(304, 23);
            this.txtusername.Style = MetroFramework.MetroColorStyle.Green;
            this.txtusername.TabIndex = 0;
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMark = "Your User Name";
            this.txtusername.WaterMarkColor = System.Drawing.Color.Black;
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(140, 127);
            this.txtpassword.MaxLength = 100;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PromptText = "Your Password";
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(304, 23);
            this.txtpassword.Style = MetroFramework.MetroColorStyle.Green;
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMark = "Your Password";
            this.txtpassword.WaterMarkColor = System.Drawing.Color.Black;
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(140, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(140, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password:";
            // 
            // checkremember
            // 
            this.checkremember.AutoSize = true;
            this.checkremember.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkremember.Location = new System.Drawing.Point(163, 156);
            this.checkremember.Name = "checkremember";
            this.checkremember.Size = new System.Drawing.Size(115, 19);
            this.checkremember.Style = MetroFramework.MetroColorStyle.Green;
            this.checkremember.TabIndex = 2;
            this.checkremember.Text = "Remember Me";
            this.checkremember.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Monthly_Salary.Properties.Resources.Gender_Neutral_User_96px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(24, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 99);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmlogin
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(480, 268);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkremember);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmlogin";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnok;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox checkremember;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}