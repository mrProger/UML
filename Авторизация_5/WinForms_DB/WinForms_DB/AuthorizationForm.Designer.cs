
namespace WinForms_DB
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginInputBox = new System.Windows.Forms.TextBox();
            this.PasswordInputBox = new System.Windows.Forms.TextBox();
            this.PasswordImage = new System.Windows.Forms.PictureBox();
            this.LoginImage = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.BackButton);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(483, 71);
            this.HeaderPanel.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(443, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 39);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(265, 56);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Авторизация";
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BodyPanel.Controls.Add(this.LoginButton);
            this.BodyPanel.Controls.Add(this.LoginInputBox);
            this.BodyPanel.Controls.Add(this.PasswordInputBox);
            this.BodyPanel.Controls.Add(this.PasswordImage);
            this.BodyPanel.Controls.Add(this.LoginImage);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 71);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(483, 379);
            this.BodyPanel.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(12, 319);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(459, 48);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // LoginInputBox
            // 
            this.LoginInputBox.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInputBox.Location = new System.Drawing.Point(93, 69);
            this.LoginInputBox.Multiline = true;
            this.LoginInputBox.Name = "LoginInputBox";
            this.LoginInputBox.Size = new System.Drawing.Size(378, 69);
            this.LoginInputBox.TabIndex = 5;
            // 
            // PasswordInputBox
            // 
            this.PasswordInputBox.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInputBox.Location = new System.Drawing.Point(93, 166);
            this.PasswordInputBox.Multiline = true;
            this.PasswordInputBox.Name = "PasswordInputBox";
            this.PasswordInputBox.PasswordChar = '*';
            this.PasswordInputBox.Size = new System.Drawing.Size(378, 69);
            this.PasswordInputBox.TabIndex = 4;
            // 
            // PasswordImage
            // 
            this.PasswordImage.Image = ((System.Drawing.Image)(resources.GetObject("PasswordImage.Image")));
            this.PasswordImage.Location = new System.Drawing.Point(12, 166);
            this.PasswordImage.Name = "PasswordImage";
            this.PasswordImage.Size = new System.Drawing.Size(75, 69);
            this.PasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordImage.TabIndex = 3;
            this.PasswordImage.TabStop = false;
            // 
            // LoginImage
            // 
            this.LoginImage.Image = ((System.Drawing.Image)(resources.GetObject("LoginImage.Image")));
            this.LoginImage.Location = new System.Drawing.Point(12, 69);
            this.LoginImage.Name = "LoginImage";
            this.LoginImage.Size = new System.Drawing.Size(75, 69);
            this.LoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginImage.TabIndex = 2;
            this.LoginImage.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(400, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(37, 39);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "<";
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox LoginImage;
        private System.Windows.Forms.TextBox PasswordInputBox;
        private System.Windows.Forms.PictureBox PasswordImage;
        private System.Windows.Forms.TextBox LoginInputBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label BackButton;
    }
}