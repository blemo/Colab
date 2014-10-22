namespace Colab
{
    partial class FormAddComment1
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
            this.labelAshley = new System.Windows.Forms.Label();
            this.labelAshleyComment = new System.Windows.Forms.Label();
            this.labelKaiden = new System.Windows.Forms.Label();
            this.labelKaidenComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAshley
            // 
            this.labelAshley.AutoSize = true;
            this.labelAshley.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAshley.Location = new System.Drawing.Point(27, 22);
            this.labelAshley.Name = "labelAshley";
            this.labelAshley.Size = new System.Drawing.Size(94, 13);
            this.labelAshley.TabIndex = 0;
            this.labelAshley.Text = "Ashley Williams";
            // 
            // labelAshleyComment
            // 
            this.labelAshleyComment.AutoSize = true;
            this.labelAshleyComment.Location = new System.Drawing.Point(27, 38);
            this.labelAshleyComment.Name = "labelAshleyComment";
            this.labelAshleyComment.Size = new System.Drawing.Size(135, 13);
            this.labelAshleyComment.TabIndex = 1;
            this.labelAshleyComment.Text = "That\'s really cool Shepard!!";
            // 
            // labelKaiden
            // 
            this.labelKaiden.AutoSize = true;
            this.labelKaiden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKaiden.Location = new System.Drawing.Point(27, 59);
            this.labelKaiden.Name = "labelKaiden";
            this.labelKaiden.Size = new System.Drawing.Size(89, 13);
            this.labelKaiden.TabIndex = 2;
            this.labelKaiden.Text = "Kaiden Alenko";
            // 
            // labelKaidenComment
            // 
            this.labelKaidenComment.AutoSize = true;
            this.labelKaidenComment.Location = new System.Drawing.Point(27, 75);
            this.labelKaidenComment.Name = "labelKaidenComment";
            this.labelKaidenComment.Size = new System.Drawing.Size(135, 13);
            this.labelKaidenComment.TabIndex = 3;
            this.labelKaidenComment.Text = "Maybe add a background?";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(30, 100);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(336, 65);
            this.textBoxComment.TabIndex = 4;
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(267, 171);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(99, 23);
            this.buttonComment.TabIndex = 5;
            this.buttonComment.Text = "Add Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // FormAddComment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(409, 206);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelKaidenComment);
            this.Controls.Add(this.labelKaiden);
            this.Controls.Add(this.labelAshleyComment);
            this.Controls.Add(this.labelAshley);
            this.Name = "FormAddComment1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAshley;
        private System.Windows.Forms.Label labelAshleyComment;
        private System.Windows.Forms.Label labelKaiden;
        private System.Windows.Forms.Label labelKaidenComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonComment;
    }
}