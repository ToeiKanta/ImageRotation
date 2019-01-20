namespace ImageRotation
{
    partial class ImageRotation
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
            this.BTN_choose_folder = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_choose_folder
            // 
            this.BTN_choose_folder.Location = new System.Drawing.Point(21, 12);
            this.BTN_choose_folder.Name = "BTN_choose_folder";
            this.BTN_choose_folder.Size = new System.Drawing.Size(202, 72);
            this.BTN_choose_folder.TabIndex = 4;
            this.BTN_choose_folder.Text = "Choose folder";
            this.BTN_choose_folder.UseVisualStyleBackColor = true;
            this.BTN_choose_folder.Click += new System.EventHandler(this.BTN_choose_folder_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(21, 90);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(202, 60);
            this.BTN_Save.TabIndex = 5;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // ImageRotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 173);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.BTN_choose_folder);
            this.Name = "ImageRotation";
            this.Text = "ImageRotation";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_choose_folder;
        private System.Windows.Forms.Button BTN_Save;
    }
}

