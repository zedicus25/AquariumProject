namespace Aquarium.View
{
    partial class Form1
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
            this.addFishBtn = new System.Windows.Forms.Button();
            this.addFeedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFishBtn
            // 
            this.addFishBtn.Location = new System.Drawing.Point(682, 394);
            this.addFishBtn.Name = "addFishBtn";
            this.addFishBtn.Size = new System.Drawing.Size(106, 44);
            this.addFishBtn.TabIndex = 0;
            this.addFishBtn.Text = "Add fish";
            this.addFishBtn.UseVisualStyleBackColor = true;
            this.addFishBtn.Click += new System.EventHandler(this.addFishBtn_Click);
            // 
            // addFeedBtn
            // 
            this.addFeedBtn.Location = new System.Drawing.Point(570, 394);
            this.addFeedBtn.Name = "addFeedBtn";
            this.addFeedBtn.Size = new System.Drawing.Size(106, 44);
            this.addFeedBtn.TabIndex = 1;
            this.addFeedBtn.Text = "Add feed";
            this.addFeedBtn.UseVisualStyleBackColor = true;
            this.addFeedBtn.Click += new System.EventHandler(this.addFeedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquarium.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addFeedBtn);
            this.Controls.Add(this.addFishBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFishBtn;
        private System.Windows.Forms.Button addFeedBtn;
    }
}

