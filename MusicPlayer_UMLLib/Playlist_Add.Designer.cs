namespace DNxMediaPlayer
{
    partial class Playlist_Add
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFiles = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(61, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(122, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Create new Playlist from:";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(12, 50);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnFiles
            // 
            this.btnFiles.Location = new System.Drawing.Point(93, 50);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(75, 23);
            this.btnFiles.TabIndex = 2;
            this.btnFiles.Text = "Files";
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(174, 50);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(75, 23);
            this.btnQueue.TabIndex = 3;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // Playlist_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnFiles);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lblMessage);
            this.Name = "Playlist_Add";
            this.Text = "Playlist_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.Button btnQueue;
    }
}