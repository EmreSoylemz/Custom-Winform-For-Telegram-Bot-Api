
namespace Custom_Winform_For_Telegram_Bot_Api
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnSendDocument = new System.Windows.Forms.Button();
            this.btnSelectDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(98, 12);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(350, 110);
            this.txtMessage.TabIndex = 0;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(98, 167);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(350, 110);
            this.txtFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message :";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(349, 128);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(99, 23);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click_1);
            // 
            // btnSendDocument
            // 
            this.btnSendDocument.Location = new System.Drawing.Point(349, 283);
            this.btnSendDocument.Name = "btnSendDocument";
            this.btnSendDocument.Size = new System.Drawing.Size(99, 23);
            this.btnSendDocument.TabIndex = 4;
            this.btnSendDocument.Text = "Send Document";
            this.btnSendDocument.UseVisualStyleBackColor = true;
            this.btnSendDocument.Click += new System.EventHandler(this.btnSendDocument_Click_1);
            // 
            // btnSelectDocument
            // 
            this.btnSelectDocument.Location = new System.Drawing.Point(231, 283);
            this.btnSelectDocument.Name = "btnSelectDocument";
            this.btnSelectDocument.Size = new System.Drawing.Size(99, 23);
            this.btnSelectDocument.TabIndex = 5;
            this.btnSelectDocument.Text = "Select Document";
            this.btnSelectDocument.UseVisualStyleBackColor = true;
            this.btnSelectDocument.Click += new System.EventHandler(this.btnSelectDocument_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 331);
            this.Controls.Add(this.btnSelectDocument);
            this.Controls.Add(this.btnSendDocument);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnSendDocument;
        private System.Windows.Forms.Button btnSelectDocument;
    }
}

