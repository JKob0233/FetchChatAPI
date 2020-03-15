namespace ChatAPI
{
    partial class ChatRoom
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
            this.currentRoom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newMessage = new System.Windows.Forms.TextBox();
            this.createMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messages = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.messageLikes = new System.Windows.Forms.Label();
            this.likeButton = new System.Windows.Forms.Button();
            this.usersLiked = new System.Windows.Forms.Label();
            this.exitChat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentRoom
            // 
            this.currentRoom.AutoSize = true;
            this.currentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.currentRoom.Location = new System.Drawing.Point(12, 9);
            this.currentRoom.Name = "currentRoom";
            this.currentRoom.Size = new System.Drawing.Size(155, 26);
            this.currentRoom.TabIndex = 10;
            this.currentRoom.Text = "Current Room:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newMessage);
            this.groupBox1.Controls.Add(this.createMessage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(512, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 135);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Post a new message:";
            // 
            // newMessage
            // 
            this.newMessage.Location = new System.Drawing.Point(6, 31);
            this.newMessage.Name = "newMessage";
            this.newMessage.Size = new System.Drawing.Size(248, 32);
            this.newMessage.TabIndex = 6;
            // 
            // createMessage
            // 
            this.createMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createMessage.Location = new System.Drawing.Point(6, 69);
            this.createMessage.Name = "createMessage";
            this.createMessage.Size = new System.Drawing.Size(248, 59);
            this.createMessage.TabIndex = 4;
            this.createMessage.Text = "Post new message";
            this.createMessage.UseVisualStyleBackColor = true;
            this.createMessage.Click += new System.EventHandler(this.createMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Messages:";
            // 
            // messages
            // 
            this.messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messages.FormattingEnabled = true;
            this.messages.ItemHeight = 20;
            this.messages.Location = new System.Drawing.Point(17, 70);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(489, 224);
            this.messages.TabIndex = 7;
            this.messages.SelectedIndexChanged += new System.EventHandler(this.messages_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usersLiked);
            this.groupBox2.Controls.Add(this.likeButton);
            this.groupBox2.Controls.Add(this.messageLikes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(512, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 146);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Details";
            // 
            // messageLikes
            // 
            this.messageLikes.Location = new System.Drawing.Point(6, 18);
            this.messageLikes.Name = "messageLikes";
            this.messageLikes.Size = new System.Drawing.Size(248, 31);
            this.messageLikes.TabIndex = 12;
            // 
            // likeButton
            // 
            this.likeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.likeButton.Location = new System.Drawing.Point(9, 105);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(248, 35);
            this.likeButton.TabIndex = 7;
            this.likeButton.Text = "Like this message";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // usersLiked
            // 
            this.usersLiked.Location = new System.Drawing.Point(6, 58);
            this.usersLiked.Name = "usersLiked";
            this.usersLiked.Size = new System.Drawing.Size(248, 44);
            this.usersLiked.TabIndex = 13;
            // 
            // exitChat
            // 
            this.exitChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitChat.Location = new System.Drawing.Point(380, 11);
            this.exitChat.Name = "exitChat";
            this.exitChat.Size = new System.Drawing.Size(126, 53);
            this.exitChat.TabIndex = 12;
            this.exitChat.Text = "Exit chat room";
            this.exitChat.UseVisualStyleBackColor = true;
            this.exitChat.Click += new System.EventHandler(this.exitChat_Click);
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.exitChat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.currentRoom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messages);
            this.Name = "ChatRoom";
            this.Text = "ChatRoom";
            this.Load += new System.EventHandler(this.ChatRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newMessage;
        private System.Windows.Forms.Button createMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox messages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label messageLikes;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Label usersLiked;
        private System.Windows.Forms.Button exitChat;
    }
}