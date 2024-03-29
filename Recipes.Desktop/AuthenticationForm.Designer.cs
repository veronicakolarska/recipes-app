﻿
namespace Recipes.Desktop
{
    partial class AuthenticationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.authenticationTabs = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.registerPage = new System.Windows.Forms.TabPage();
            this.registerConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.registerConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerPasswordLabel = new System.Windows.Forms.Label();
            this.registerPasswordInput = new System.Windows.Forms.TextBox();
            this.registerEmailLabel = new System.Windows.Forms.Label();
            this.registerEmailInput = new System.Windows.Forms.TextBox();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.registerEmailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.registerPasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.confirmPasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.authenticationTabs.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.registerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerEmailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerPasswordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // authenticationTabs
            // 
            this.authenticationTabs.Controls.Add(this.loginPage);
            this.authenticationTabs.Controls.Add(this.registerPage);
            this.authenticationTabs.Location = new System.Drawing.Point(217, 65);
            this.authenticationTabs.Name = "authenticationTabs";
            this.authenticationTabs.Padding = new System.Drawing.Point(71, 3);
            this.authenticationTabs.SelectedIndex = 0;
            this.authenticationTabs.Size = new System.Drawing.Size(365, 319);
            this.authenticationTabs.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.loginButton);
            this.loginPage.Controls.Add(this.passwordLabel);
            this.loginPage.Controls.Add(this.passwordInput);
            this.loginPage.Controls.Add(this.emailLabel);
            this.loginPage.Controls.Add(this.emailInput);
            this.loginPage.Location = new System.Drawing.Point(4, 24);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(357, 291);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Login";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(80, 215);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(190, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(80, 122);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(80, 140);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(190, 23);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(80, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(80, 63);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(190, 23);
            this.emailInput.TabIndex = 0;
            this.emailInput.TextChanged += new System.EventHandler(this.emailInput_TextChanged);
            // 
            // registerPage
            // 
            this.registerPage.Controls.Add(this.registerConfirmPasswordLabel);
            this.registerPage.Controls.Add(this.registerConfirmPasswordInput);
            this.registerPage.Controls.Add(this.registerButton);
            this.registerPage.Controls.Add(this.registerPasswordLabel);
            this.registerPage.Controls.Add(this.registerPasswordInput);
            this.registerPage.Controls.Add(this.registerEmailLabel);
            this.registerPage.Controls.Add(this.registerEmailInput);
            this.registerPage.Location = new System.Drawing.Point(4, 24);
            this.registerPage.Name = "registerPage";
            this.registerPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerPage.Size = new System.Drawing.Size(357, 291);
            this.registerPage.TabIndex = 1;
            this.registerPage.Text = "Register";
            this.registerPage.UseVisualStyleBackColor = true;
            // 
            // registerConfirmPasswordLabel
            // 
            this.registerConfirmPasswordLabel.AutoSize = true;
            this.registerConfirmPasswordLabel.Location = new System.Drawing.Point(83, 156);
            this.registerConfirmPasswordLabel.Name = "registerConfirmPasswordLabel";
            this.registerConfirmPasswordLabel.Size = new System.Drawing.Size(104, 15);
            this.registerConfirmPasswordLabel.TabIndex = 11;
            this.registerConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // registerConfirmPasswordInput
            // 
            this.registerConfirmPasswordInput.Location = new System.Drawing.Point(83, 174);
            this.registerConfirmPasswordInput.Name = "registerConfirmPasswordInput";
            this.registerConfirmPasswordInput.PasswordChar = '*';
            this.registerConfirmPasswordInput.Size = new System.Drawing.Size(190, 23);
            this.registerConfirmPasswordInput.TabIndex = 10;
            this.registerConfirmPasswordInput.TextChanged += new System.EventHandler(this.registerConfirmPasswordInput_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(83, 219);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(190, 23);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerPasswordLabel
            // 
            this.registerPasswordLabel.AutoSize = true;
            this.registerPasswordLabel.Location = new System.Drawing.Point(83, 98);
            this.registerPasswordLabel.Name = "registerPasswordLabel";
            this.registerPasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.registerPasswordLabel.TabIndex = 8;
            this.registerPasswordLabel.Text = "Password";
            // 
            // registerPasswordInput
            // 
            this.registerPasswordInput.Location = new System.Drawing.Point(83, 116);
            this.registerPasswordInput.Name = "registerPasswordInput";
            this.registerPasswordInput.PasswordChar = '*';
            this.registerPasswordInput.Size = new System.Drawing.Size(190, 23);
            this.registerPasswordInput.TabIndex = 7;
            this.registerPasswordInput.TextChanged += new System.EventHandler(this.registerPasswordInput_TextChanged);
            // 
            // registerEmailLabel
            // 
            this.registerEmailLabel.AutoSize = true;
            this.registerEmailLabel.Location = new System.Drawing.Point(83, 41);
            this.registerEmailLabel.Name = "registerEmailLabel";
            this.registerEmailLabel.Size = new System.Drawing.Size(36, 15);
            this.registerEmailLabel.TabIndex = 6;
            this.registerEmailLabel.Text = "Email";
            // 
            // registerEmailInput
            // 
            this.registerEmailInput.Location = new System.Drawing.Point(83, 59);
            this.registerEmailInput.Name = "registerEmailInput";
            this.registerEmailInput.Size = new System.Drawing.Size(190, 23);
            this.registerEmailInput.TabIndex = 5;
            this.registerEmailInput.TextChanged += new System.EventHandler(this.registerEmailInput_TextChanged);
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.ContainerControl = this;
            // 
            // registerEmailErrorProvider
            // 
            this.registerEmailErrorProvider.ContainerControl = this;
            // 
            // registerPasswordErrorProvider
            // 
            this.registerPasswordErrorProvider.ContainerControl = this;
            // 
            // confirmPasswordErrorProvider
            // 
            this.confirmPasswordErrorProvider.ContainerControl = this;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authenticationTabs);
            this.Name = "AuthenticationForm";
            this.Text = "Form1";
            this.authenticationTabs.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.registerPage.ResumeLayout(false);
            this.registerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerEmailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerPasswordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl authenticationTabs;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.TabPage registerPage;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label registerEmailLabel;
        private System.Windows.Forms.TextBox registerEmailInput;
        private System.Windows.Forms.Label registerPasswordLabel;
        private System.Windows.Forms.TextBox registerPasswordInput;
        private System.Windows.Forms.Label registerConfirmPasswordLabel;
        private System.Windows.Forms.TextBox registerConfirmPasswordInput;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordErrorProvider;
        private System.Windows.Forms.ErrorProvider registerEmailErrorProvider;
        private System.Windows.Forms.ErrorProvider registerPasswordErrorProvider;
        private System.Windows.Forms.ErrorProvider confirmPasswordErrorProvider;
    }
}

