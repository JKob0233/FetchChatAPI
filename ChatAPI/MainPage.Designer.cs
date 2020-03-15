namespace ChatAPI
{
    partial class MainPage
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
            this.chatRooms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createChatRoom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newChatName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatRooms
            // 
            this.chatRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chatRooms.FormattingEnabled = true;
            this.chatRooms.ItemHeight = 25;
            this.chatRooms.Items.AddRange(new object[] {
            "Room 1"});
            this.chatRooms.Location = new System.Drawing.Point(12, 120);
            this.chatRooms.Name = "chatRooms";
            this.chatRooms.Size = new System.Drawing.Size(236, 179);
            this.chatRooms.TabIndex = 2;
            this.chatRooms.SelectedIndexChanged += new System.EventHandler(this.chatRooms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available Chat Rooms:";
            // 
            // createChatRoom
            // 
            this.createChatRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createChatRoom.Location = new System.Drawing.Point(6, 114);
            this.createChatRoom.Name = "createChatRoom";
            this.createChatRoom.Size = new System.Drawing.Size(248, 59);
            this.createChatRoom.TabIndex = 4;
            this.createChatRoom.Text = "Create new chat room";
            this.createChatRoom.UseVisualStyleBackColor = true;
            this.createChatRoom.Click += new System.EventHandler(this.createChatRoom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newChatName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.createChatRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(255, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new chat room:";
            // 
            // newChatName
            // 
            this.newChatName.Location = new System.Drawing.Point(6, 76);
            this.newChatName.Name = "newChatName";
            this.newChatName.Size = new System.Drawing.Size(248, 32);
            this.newChatName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the name of the chat room that you would like to create:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.currentUser.Location = new System.Drawing.Point(7, 9);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(313, 26);
            this.currentUser.TabIndex = 6;
            this.currentUser.Text = "You are currently logged in as: ";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.currentUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatRooms);
            this.Name = "MainPage";
            this.Text = "Chat API HomePage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chatRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createChatRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newChatName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentUser;
    }
}