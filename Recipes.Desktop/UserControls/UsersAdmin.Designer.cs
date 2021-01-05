
namespace Recipes.Desktop.UserControls
{
    partial class UsersAdmin
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
            this.usersAdminDataGrid = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersAdminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usersAdminDataGrid
            // 
            this.usersAdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersAdminDataGrid.Location = new System.Drawing.Point(34, 104);
            this.usersAdminDataGrid.Name = "usersAdminDataGrid";
            this.usersAdminDataGrid.RowTemplate.Height = 25;
            this.usersAdminDataGrid.Size = new System.Drawing.Size(942, 350);
            this.usersAdminDataGrid.TabIndex = 1;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(69, 38);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // UsersAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersAdminDataGrid);
            this.Name = "UsersAdmin";
            this.Size = new System.Drawing.Size(1010, 494);
            ((System.ComponentModel.ISupportInitialize)(this.usersAdminDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersAdminDataGrid;
        private System.Windows.Forms.Button addUserButton;
    }
}
