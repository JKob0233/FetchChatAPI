using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPI
{
    public partial class ChatRoom : Form
    {
        public static List<Message> roomMessages = new List<Message>();

        public ChatRoom(Dictionary<string, List<Message>> server, string room)
        {
            InitializeComponent();
            messages.Items.Clear();
            roomMessages = server[room];
            currentRoom.Text = "Currently viewing: " + room;
            foreach(Message message in roomMessages)
            {
                messages.Items.Add(message.text);
            }
        }

        private void createMessage_Click(object sender, EventArgs e)
        {
            if (newMessage.Text == null | newMessage.Text == "")
            {
                MessageBox.Show("Please enter a valid message");
                Console.WriteLine("Please enter a valid message");
            }
            else
            {
                Message newMess = new Message();
                newMess.text = newMessage.Text;
                newMess.likes = new List<string>();
                roomMessages.Add(newMess);
                messages.Items.Add(newMessage.Text);
            }
        }

        private void messages_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Message m in roomMessages)
            {
                if(m.text == messages.SelectedItem.ToString())
                {
                    messageLikes.Text = "Number of likes: " + m.likes.Count.ToString();
                    usersLiked.Text = "Liked by Users: " + String.Join(", ", m.likes.ToArray());
                }
            }
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            foreach (Message m in roomMessages)
            {
                if (m.text == messages.SelectedItem.ToString())
                {
                    if (!m.likes.Contains(Login.username))
                    {
                        m.likes.Add(Login.username);
                        messageLikes.Text = "Number of likes: " + m.likes.Count.ToString();
                        usersLiked.Text = "Liked by Users: " + String.Join(", ", m.likes.ToArray());
                    }
                    else
                    {
                        MessageBox.Show("User has already liked this message.");
                    }                    
                }
            }
        }

        private void exitChat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChatRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
