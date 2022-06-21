namespace Aquarium.View
{
    partial class AddingForm
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
            this.buyingControl1 = new Aquarium.View.BuyingControl();
            this.SuspendLayout();
            // 
            // buyingControl1
            // 
            this.buyingControl1.Location = new System.Drawing.Point(12, 12);
            this.buyingControl1.Name = "buyingControl1";
            this.buyingControl1.Size = new System.Drawing.Size(318, 329);
            this.buyingControl1.TabIndex = 0;
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 353);
            this.Controls.Add(this.buyingControl1);
            this.Name = "AddingForm";
            this.Text = "AddingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private BuyingControl buyingControl1;
    }
}