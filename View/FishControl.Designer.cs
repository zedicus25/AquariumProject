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
            this.fishPB = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fishPB)).BeginInit();
            this.SuspendLayout();
            // 
            // fishPB
            // 
            this.fishPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fishPB.Location = new System.Drawing.Point(12, 13);
            this.fishPB.Name = "fishPB";
            this.fishPB.Size = new System.Drawing.Size(167, 113);
            this.fishPB.TabIndex = 0;
            this.fishPB.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(105, 143);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(74, 39);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // nameL
            // 
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.Location = new System.Drawing.Point(12, 133);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(87, 49);
            this.nameL.TabIndex = 2;
            this.nameL.Text = "label1";
            // 
            // FishControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fishPB);
            this.Name = "FishControl";
            this.Size = new System.Drawing.Size(191, 198);
            ((System.ComponentModel.ISupportInitialize)(this.fishPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fishPB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label nameL;
    }
}
