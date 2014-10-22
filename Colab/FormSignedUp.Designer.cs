namespace Colab
{
    partial class FormSignedUp
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
            this.labelSignedUpThanks = new System.Windows.Forms.Label();
            this.labelSignedUpYouCan = new System.Windows.Forms.Label();
            this.labelSignedUpId = new System.Windows.Forms.Label();
            this.buttonSignedUpClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSignedUpThanks
            // 
            this.labelSignedUpThanks.AutoSize = true;
            this.labelSignedUpThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignedUpThanks.Location = new System.Drawing.Point(151, 21);
            this.labelSignedUpThanks.Name = "labelSignedUpThanks";
            this.labelSignedUpThanks.Size = new System.Drawing.Size(160, 20);
            this.labelSignedUpThanks.TabIndex = 0;
            this.labelSignedUpThanks.Text = "Thanks for signing up";
            // 
            // labelSignedUpYouCan
            // 
            this.labelSignedUpYouCan.AutoSize = true;
            this.labelSignedUpYouCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignedUpYouCan.Location = new System.Drawing.Point(74, 111);
            this.labelSignedUpYouCan.Name = "labelSignedUpYouCan";
            this.labelSignedUpYouCan.Size = new System.Drawing.Size(355, 20);
            this.labelSignedUpYouCan.TabIndex = 1;
            this.labelSignedUpYouCan.Text = "You can now log in using your iwaikato password.";
            // 
            // labelSignedUpId
            // 
            this.labelSignedUpId.AutoSize = true;
            this.labelSignedUpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignedUpId.Location = new System.Drawing.Point(196, 67);
            this.labelSignedUpId.Name = "labelSignedUpId";
            this.labelSignedUpId.Size = new System.Drawing.Size(0, 20);
            this.labelSignedUpId.TabIndex = 2;
            // 
            // buttonSignedUpClose
            // 
            this.buttonSignedUpClose.Location = new System.Drawing.Point(371, 148);
            this.buttonSignedUpClose.Name = "buttonSignedUpClose";
            this.buttonSignedUpClose.Size = new System.Drawing.Size(98, 25);
            this.buttonSignedUpClose.TabIndex = 3;
            this.buttonSignedUpClose.Text = "Close";
            this.buttonSignedUpClose.UseVisualStyleBackColor = true;
            this.buttonSignedUpClose.Click += new System.EventHandler(this.buttonSignedUpClose_Click);
            // 
            // FormSignedUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 183);
            this.Controls.Add(this.buttonSignedUpClose);
            this.Controls.Add(this.labelSignedUpId);
            this.Controls.Add(this.labelSignedUpYouCan);
            this.Controls.Add(this.labelSignedUpThanks);
            this.Name = "FormSignedUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignedUpThanks;
        private System.Windows.Forms.Label labelSignedUpYouCan;
        private System.Windows.Forms.Label labelSignedUpId;
        private System.Windows.Forms.Button buttonSignedUpClose;
    }
}