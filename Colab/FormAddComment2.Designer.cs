namespace Colab
{
    partial class FormAddComment2
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
            this.buttonComment = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelKaidenComment = new System.Windows.Forms.Label();
            this.labelKaiden = new System.Windows.Forms.Label();
            this.labelAshleyComment = new System.Windows.Forms.Label();
            this.labelAshley = new System.Windows.Forms.Label();
            this.labelJohn = new System.Windows.Forms.Label();
            this.labelJohnComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(261, 213);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(99, 23);
            this.buttonComment.TabIndex = 11;
            this.buttonComment.Text = "Add Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(24, 142);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(336, 65);
            this.textBoxComment.TabIndex = 10;
            // 
            // labelKaidenComment
            // 
            this.labelKaidenComment.AutoSize = true;
            this.labelKaidenComment.Location = new System.Drawing.Point(21, 79);
            this.labelKaidenComment.Name = "labelKaidenComment";
            this.labelKaidenComment.Size = new System.Drawing.Size(135, 13);
            this.labelKaidenComment.TabIndex = 9;
            this.labelKaidenComment.Text = "Maybe add a background?";
            // 
            // labelKaiden
            // 
            this.labelKaiden.AutoSize = true;
            this.labelKaiden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKaiden.Location = new System.Drawing.Point(21, 63);
            this.labelKaiden.Name = "labelKaiden";
            this.labelKaiden.Size = new System.Drawing.Size(89, 13);
            this.labelKaiden.TabIndex = 8;
            this.labelKaiden.Text = "Kaiden Alenko";
            // 
            // labelAshleyComment
            // 
            this.labelAshleyComment.AutoSize = true;
            this.labelAshleyComment.Location = new System.Drawing.Point(21, 42);
            this.labelAshleyComment.Name = "labelAshleyComment";
            this.labelAshleyComment.Size = new System.Drawing.Size(135, 13);
            this.labelAshleyComment.TabIndex = 7;
            this.labelAshleyComment.Text = "That\'s really cool Shepard!!";
            // 
            // labelAshley
            // 
            this.labelAshley.AutoSize = true;
            this.labelAshley.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAshley.Location = new System.Drawing.Point(21, 26);
            this.labelAshley.Name = "labelAshley";
            this.labelAshley.Size = new System.Drawing.Size(94, 13);
            this.labelAshley.TabIndex = 6;
            this.labelAshley.Text = "Ashley Williams";
            // 
            // labelJohn
            // 
            this.labelJohn.AutoSize = true;
            this.labelJohn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJohn.Location = new System.Drawing.Point(21, 100);
            this.labelJohn.Name = "labelJohn";
            this.labelJohn.Size = new System.Drawing.Size(85, 13);
            this.labelJohn.TabIndex = 12;
            this.labelJohn.Text = "John Shepard";
            // 
            // labelJohnComment
            // 
            this.labelJohnComment.AutoSize = true;
            this.labelJohnComment.Location = new System.Drawing.Point(21, 116);
            this.labelJohnComment.Name = "labelJohnComment";
            this.labelJohnComment.Size = new System.Drawing.Size(133, 13);
            this.labelJohnComment.TabIndex = 13;
            this.labelJohnComment.Text = "Thanks Kaiden, I\'ll do that.";
            // 
            // FormAddComment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 245);
            this.Controls.Add(this.labelJohnComment);
            this.Controls.Add(this.labelJohn);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelKaidenComment);
            this.Controls.Add(this.labelKaiden);
            this.Controls.Add(this.labelAshleyComment);
            this.Controls.Add(this.labelAshley);
            this.Name = "FormAddComment2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelKaidenComment;
        private System.Windows.Forms.Label labelKaiden;
        private System.Windows.Forms.Label labelAshleyComment;
        private System.Windows.Forms.Label labelAshley;
        private System.Windows.Forms.Label labelJohn;
        private System.Windows.Forms.Label labelJohnComment;
    }
}