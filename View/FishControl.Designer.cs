namespace Aquarium.View
{
    partial class FishControl
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
            this.nameL = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.fishPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fishPB)).BeginInit();
            this.SuspendLayout();
            // 
            // nameL
            // 
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.Location = new System.Drawing.Point(9, 102);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(69, 39);
            this.nameL.TabIndex = 2;
            this.nameL.Text = "label1";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(84, 102);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(48, 39);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Buy";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // fishPB
            // 
            this.fishPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fishPB.Location = new System.Drawing.Point(12, 13);
            this.fishPB.Name = "fishPB";
            this.fishPB.Size = new System.Drawing.Size(120, 86);
            this.fishPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fishPB.TabIndex = 0;
            this.fishPB.TabStop = false;
            // 
            // FishControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fishPB);
            this.Name = "FishControl";
            this.Size = new System.Drawing.Size(144, 150);
            ((System.ComponentModel.ISupportInitialize)(this.fishPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fishPB;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Button saveBtn;
    }
}
