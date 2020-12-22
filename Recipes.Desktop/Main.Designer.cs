
namespace Recipes.Desktop
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.registerPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.loginPage);
            this.tabControl1.Controls.Add(this.registerPage);
            this.tabControl1.Location = new System.Drawing.Point(217, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(71, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 255);
            this.tabControl1.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.Location = new System.Drawing.Point(4, 24);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(357, 227);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Login";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // registerPage
            // 
            this.registerPage.Location = new System.Drawing.Point(4, 24);
            this.registerPage.Name = "registerPage";
            this.registerPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerPage.Size = new System.Drawing.Size(378, 227);
            this.registerPage.TabIndex = 1;
            this.registerPage.Text = "Register";
            this.registerPage.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.TabPage registerPage;
    }
}

