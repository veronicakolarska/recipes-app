
namespace Recipes.Desktop
{
    partial class RecipeTile
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
            this.recipeTitleLabel = new System.Windows.Forms.Label();
            this.recipePictureBox = new System.Windows.Forms.PictureBox();
            this.favouriteCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeTitleLabel
            // 
            this.recipeTitleLabel.AutoSize = true;
            this.recipeTitleLabel.Location = new System.Drawing.Point(20, 16);
            this.recipeTitleLabel.Name = "recipeTitleLabel";
            this.recipeTitleLabel.Size = new System.Drawing.Size(38, 15);
            this.recipeTitleLabel.TabIndex = 0;
            this.recipeTitleLabel.Text = "label1";
            // 
            // recipePictureBox
            // 
            this.recipePictureBox.Location = new System.Drawing.Point(20, 44);
            this.recipePictureBox.Name = "recipePictureBox";
            this.recipePictureBox.Size = new System.Drawing.Size(112, 81);
            this.recipePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recipePictureBox.TabIndex = 1;
            this.recipePictureBox.TabStop = false;
            // 
            // favouriteCheckBox
            // 
            this.favouriteCheckBox.AutoSize = true;
            this.favouriteCheckBox.Location = new System.Drawing.Point(20, 133);
            this.favouriteCheckBox.Name = "favouriteCheckBox";
            this.favouriteCheckBox.Size = new System.Drawing.Size(75, 19);
            this.favouriteCheckBox.TabIndex = 3;
            this.favouriteCheckBox.Text = "Favourite";
            this.favouriteCheckBox.UseVisualStyleBackColor = true;
            this.favouriteCheckBox.CheckedChanged += new System.EventHandler(this.favouriteCheckBox_CheckedChanged);
            // 
            // RecipeTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.favouriteCheckBox);
            this.Controls.Add(this.recipePictureBox);
            this.Controls.Add(this.recipeTitleLabel);
            this.Name = "RecipeTile";
            this.Size = new System.Drawing.Size(153, 165);
            ((System.ComponentModel.ISupportInitialize)(this.recipePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipeTitleLabel;
        private System.Windows.Forms.PictureBox recipePictureBox;
        private System.Windows.Forms.CheckBox favouriteCheckBox;
    }
}
