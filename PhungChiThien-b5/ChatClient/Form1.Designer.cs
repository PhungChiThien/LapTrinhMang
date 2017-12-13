namespace ChatClient
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbxConversation = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(225, 338);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 23);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 340);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(207, 20);
            this.txtHost.TabIndex = 20;
            this.txtHost.Text = "127.0.0.1";
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(328, 311);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(97, 23);
            this.btnVideo.TabIndex = 19;
            this.btnVideo.Text = "Send Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(328, 285);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(97, 23);
            this.btnSound.TabIndex = 18;
            this.btnSound.Text = "Send Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(328, 256);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(97, 23);
            this.btnImg.TabIndex = 17;
            this.btnImg.Text = "Send Image";
            this.btnImg.UseVisualStyleBackColor = true;
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(328, 230);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(97, 23);
            this.btnText.TabIndex = 16;
            this.btnText.Text = "Send";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 230);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(310, 104);
            this.txtInput.TabIndex = 15;
            // 
            // lbxConversation
            // 
            this.lbxConversation.FormattingEnabled = true;
            this.lbxConversation.Location = new System.Drawing.Point(12, 12);
            this.lbxConversation.Name = "lbxConversation";
            this.lbxConversation.Size = new System.Drawing.Size(413, 212);
            this.lbxConversation.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 370);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbxConversation);
            this.Name = "Form1";
            this.Text = "ChatClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnText_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lbxConversation;
    }
}

