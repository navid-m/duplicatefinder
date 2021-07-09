
namespace Duplicatefinder
{
    partial class SearchForm
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
            this.ChooseDirButton = new System.Windows.Forms.Button();
            this.FileCountLabel = new System.Windows.Forms.Label();
            this.FileTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ChooseDirButton
            // 
            this.ChooseDirButton.Location = new System.Drawing.Point(664, 459);
            this.ChooseDirButton.Name = "ChooseDirButton";
            this.ChooseDirButton.Size = new System.Drawing.Size(175, 29);
            this.ChooseDirButton.TabIndex = 0;
            this.ChooseDirButton.Text = "Choose Directory";
            this.ChooseDirButton.UseVisualStyleBackColor = true;
            this.ChooseDirButton.Click += new System.EventHandler(this.ChooseDirButton_Click);
            // 
            // FileCountLabel
            // 
            this.FileCountLabel.AutoSize = true;
            this.FileCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileCountLabel.Location = new System.Drawing.Point(13, 17);
            this.FileCountLabel.Name = "FileCountLabel";
            this.FileCountLabel.Size = new System.Drawing.Size(84, 20);
            this.FileCountLabel.TabIndex = 1;
            this.FileCountLabel.Text = "Files found:";
            this.FileCountLabel.Visible = false;
            // 
            // FileTreeView
            // 
            this.FileTreeView.Location = new System.Drawing.Point(13, 56);
            this.FileTreeView.Name = "FileTreeView";
            this.FileTreeView.Size = new System.Drawing.Size(826, 389);
            this.FileTreeView.TabIndex = 2;
            this.FileTreeView.Visible = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 501);
            this.Controls.Add(this.FileTreeView);
            this.Controls.Add(this.FileCountLabel);
            this.Controls.Add(this.ChooseDirButton);
            this.Name = "SearchForm";
            this.Text = "Duplicatefinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseDirButton;
        private System.Windows.Forms.Label FileCountLabel;
        private System.Windows.Forms.TreeView FileTreeView;
    }
}

