
namespace Recipes.Desktop.UserControls
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profileLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.editProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(35, 44);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(61, 15);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "My profile";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(35, 89);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Enabled = false;
            this.emailTextbox.Location = new System.Drawing.Point(35, 120);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.ReadOnly = true;
            this.emailTextbox.Size = new System.Drawing.Size(182, 23);
            this.emailTextbox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(35, 167);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(35, 313);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(182, 140);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 4;
            this.profilePictureBox.TabStop = false;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Enabled = false;
            this.descriptionTextbox.Location = new System.Drawing.Point(35, 198);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ReadOnly = true;
            this.descriptionTextbox.Size = new System.Drawing.Size(182, 73);
            this.descriptionTextbox.TabIndex = 5;
            // 
            // editProfileButton
            // 
            this.editProfileButton.Location = new System.Drawing.Point(164, 36);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(53, 23);
            this.editProfileButton.TabIndex = 6;
            this.editProfileButton.Text = "edit";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.profileLabel);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(258, 485);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Button editProfileButton;
    }
}
