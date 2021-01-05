
namespace Recipes.Desktop
{
    partial class AddUser
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
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userImageUrlLabel = new System.Windows.Forms.Label();
            this.userImageDescriptionLabel = new System.Windows.Forms.Label();
            this.userEmailInput = new System.Windows.Forms.TextBox();
            this.userPasswordInput = new System.Windows.Forms.TextBox();
            this.userImageURLInput = new System.Windows.Forms.TextBox();
            this.userDescriptionInput = new System.Windows.Forms.TextBox();
            this.userAddedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Location = new System.Drawing.Point(98, 79);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(36, 15);
            this.userEmailLabel.TabIndex = 0;
            this.userEmailLabel.Text = "Email";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(98, 156);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.userPasswordLabel.TabIndex = 1;
            this.userPasswordLabel.Text = "Password";
            // 
            // userImageUrlLabel
            // 
            this.userImageUrlLabel.AutoSize = true;
            this.userImageUrlLabel.Location = new System.Drawing.Point(98, 225);
            this.userImageUrlLabel.Name = "userImageUrlLabel";
            this.userImageUrlLabel.Size = new System.Drawing.Size(64, 15);
            this.userImageUrlLabel.TabIndex = 2;
            this.userImageUrlLabel.Text = "Image URL";
            // 
            // userImageDescriptionLabel
            // 
            this.userImageDescriptionLabel.AutoSize = true;
            this.userImageDescriptionLabel.Location = new System.Drawing.Point(98, 300);
            this.userImageDescriptionLabel.Name = "userImageDescriptionLabel";
            this.userImageDescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.userImageDescriptionLabel.TabIndex = 3;
            this.userImageDescriptionLabel.Text = "Description";
            // 
            // userEmailInput
            // 
            this.userEmailInput.Location = new System.Drawing.Point(98, 109);
            this.userEmailInput.Name = "userEmailInput";
            this.userEmailInput.Size = new System.Drawing.Size(193, 23);
            this.userEmailInput.TabIndex = 4;
            // 
            // userPasswordInput
            // 
            this.userPasswordInput.Location = new System.Drawing.Point(98, 174);
            this.userPasswordInput.Name = "userPasswordInput";
            this.userPasswordInput.PasswordChar = '*';
            this.userPasswordInput.Size = new System.Drawing.Size(193, 23);
            this.userPasswordInput.TabIndex = 5;
            // 
            // userImageURLInput
            // 
            this.userImageURLInput.Location = new System.Drawing.Point(98, 243);
            this.userImageURLInput.Name = "userImageURLInput";
            this.userImageURLInput.Size = new System.Drawing.Size(193, 23);
            this.userImageURLInput.TabIndex = 6;
            // 
            // userDescriptionInput
            // 
            this.userDescriptionInput.Location = new System.Drawing.Point(98, 318);
            this.userDescriptionInput.Name = "userDescriptionInput";
            this.userDescriptionInput.Size = new System.Drawing.Size(193, 23);
            this.userDescriptionInput.TabIndex = 7;
            // 
            // userAddedButton
            // 
            this.userAddedButton.Location = new System.Drawing.Point(98, 381);
            this.userAddedButton.Name = "userAddedButton";
            this.userAddedButton.Size = new System.Drawing.Size(193, 23);
            this.userAddedButton.TabIndex = 8;
            this.userAddedButton.Text = "Add user";
            this.userAddedButton.UseVisualStyleBackColor = true;
            this.userAddedButton.Click += new System.EventHandler(this.userAddedButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.userAddedButton);
            this.Controls.Add(this.userDescriptionInput);
            this.Controls.Add(this.userImageURLInput);
            this.Controls.Add(this.userPasswordInput);
            this.Controls.Add(this.userEmailInput);
            this.Controls.Add(this.userImageDescriptionLabel);
            this.Controls.Add(this.userImageUrlLabel);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userEmailLabel);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Label userImageUrlLabel;
        private System.Windows.Forms.Label userImageDescriptionLabel;
        private System.Windows.Forms.TextBox userEmailInput;
        private System.Windows.Forms.TextBox userPasswordInput;
        private System.Windows.Forms.TextBox userImageURLInput;
        private System.Windows.Forms.TextBox userDescriptionInput;
        private System.Windows.Forms.Button userAddedButton;
    }
}