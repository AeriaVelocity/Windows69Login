using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows69Login
{
    public partial class theWindow : Form
    {
        public theWindow()
        {
            InitializeComponent();
        }

        private void pressedOK(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Administrator")
            {
                if (passwordBox.Text == "bababooey")
                {
                    MessageBox.Show("The operation completed successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passwordBox.Text == "")
                {
                    MessageBox.Show("Please enter a password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("You are not the Administrator.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (usernameBox.Text == "")
                {
                    MessageBox.Show("You didn't even enter a username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (passwordBox.Text == "")
                    {
                        MessageBox.Show("This user, if they even existed, is temporarily locked down.\nAll users are required to have a password.\nPlease log in as Administrator and give this user a password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (usernameBox.Text == "username" && passwordBox.Text == "password")
                    {
                        Form2 troll = new Form2();
                        troll.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("The operation completed successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pressedCancel(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string funnyline = "";
            switch (rnd.Next(1, 8))
            {
                case 1:
                    funnyline = "You want to quit?\nThen, thou has lost an eighth!";
                    break;
                case 2:
                    funnyline = "Don't go now, there's a dimensional shambler waiting at the command prompt!";
                    break;
                case 3:
                    funnyline = "Get outta here and go back to your boring programs.";
                    break;
                case 4:
                    funnyline = "I wouldn't leave if I were you. Windows is much worse.";
                    break;
                case 5:
                    funnyline = "Just leave.\nWhen you come back, I'll be waiting with a bat.";
                    break;
                case 6:
                    funnyline = "Get outta here and go back to your boring programs.";
                    break;
                case 7:
                    funnyline = "Don't leave yet -- There's a demon around that corner!";
                    break;
                case 8:
                    funnyline = "Go ahead and leave. See if I care.";
                    break;
                default:
                    break;
                      
            }
            DialogResult thefunny = MessageBox.Show(funnyline, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (thefunny == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                /* Continue on */
            }
        }

        private void theKeys_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Process.Start("https://github.com/That1M8Head");
            Console.WriteLine("Whoa, self promotion! :O");
        }
    }
}
