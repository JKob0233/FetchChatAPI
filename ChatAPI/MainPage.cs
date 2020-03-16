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
    public partial class MainPage : Form
    {
        public static Dictionary<string, List<Message>> server = new Dictionary<string, List<Message>>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            currentUser.Text = "You are currently logged in as: " + Login.username;
            Message room11 = new Message();
            room11.text = "This is a test message";
            room11.likes = new List<string> { "testUser", "User2" };
            Message room12 = new Message();
            room12.text = "This is a second test message";
            room12.likes = new List<string>();
            server.Add("Room 1", new List<Message> { room11, room12 });
        }

        private void createChatRoom_Click(object sender, EventArgs e)
        {
            if(newChatName.Text == null | newChatName.Text == "")
            {
                MessageBox.Show("Please enter a valid name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Please enter a valid name");
            }
            else if (chatRooms.Items.Contains(newChatName.Text))
            {
                MessageBox.Show("A chat room with that name already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("A chat room with that name already exists");
            }
            else
            {
                server.Add(newChatName.Text, new List<Message>());
                chatRooms.Items.Add(newChatName.Text);
            }
        }

        private void chatRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string room = chatRooms.SelectedItem.ToString();
            MessageBox.Show("Now entering " + room, "Entering Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChatRoom chatroom = new ChatRoom(server, room);
            chatroom.Show();
        }
    }

    public class Message
    {
        public string text { get; set; }
        public List<string> likes { get; set; }
    }
}
