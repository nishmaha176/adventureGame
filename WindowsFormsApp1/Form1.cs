using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class johnPorksMansion : Form
    {
        int page = 1;
        public johnPorksMansion()
        {
            InitializeComponent();
            outputLabel.Text = "You are trapped in the basement of John Pork's Mansion. How will you escape?";
            option1Button.Text = "Window";
            option2Button.Text = "Vent System";
            pictureBox.Image = WindowsFormsApp1.Properties.Resources.hauntedmansion2;
        }
        SoundPlayer boom = new SoundPlayer(Properties.Resources.vine_boom);
        SoundPlayer win = new SoundPlayer(Properties.Resources.mixkit_achievement_bell_600);
        SoundPlayer lose = new SoundPlayer(Properties.Resources.mixkit_losing_bleeps_2026);
        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 14;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page==15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if(page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            DisplayPage();

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                Random randGen = new Random();
                int random = randGen.Next(0, 100);
                if (random > 50)
                {
                    page = 3;
                }
                else
                {
                    page = 2;
                }
             }
            else if (page==2)
            {
                page = 99;
            }
            else if (page==3)
            {
                page = 4;
            }
            else if (page==4)
            {
                page = 99;
            }
            else if (page==5)
            {
                page = 6;
            }
            else if (page==6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 10)
            {
                page = 13;
            }
            if (page == 5)
            {
                page = 17;
            }
            DisplayPage() ;

        }
        public async void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    
                        outputLabel.Text = "You wake up locked in the basement of John Pork's Mansion. \n How will you escape?";
                        option1Button.Text = "Vent";
                        option2Button.Text = "Window";
                        option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.hauntedmansion2;
                    boom.Play();
                    break;
                    
                case 2:                   
                        outputLabel.Text = "John pork caught you and locked you up.\n Play again?";
                        option1Button.Text = "Yes";
                        option2Button.Text = "No";
                        option3Button.Text = "";
                 pictureBox.Image = WindowsFormsApp1.Properties.Resources.johnporkmad;
                    lose.Play();
                    break;

                case 3:
                    outputLabel.Text = "You are thirsty and starving.\n You reach the kitchen.\n You see a mango and water.";
                    option1Button.Text = "Eat Mango";
                    option2Button.Text = "Drink Water";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.FinalMangoWater;
                    boom.Play();
                    break;

                case 5:
                    outputLabel.Text = "You feel rejeuvenated and have energy now.\n Which way will you go to escape?";
                    option1Button.Text = "Basement";
                    option2Button.Text = "Upstairs";
                    option3Button.Text = "Main Floor";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.mang;
                    boom.Play();
                    break;

                case 4:
                    outputLabel.Text = "You drank poisoned still water and fainted.\n Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.poisonwater;
                    lose.Play();
                    break;

                case 6:
                    outputLabel.Text = "You find John Pork asleep in his bed.\n Where will you go from here?";
                    option1Button.Text = "Sneak Past His Room";
                    option2Button.Text = "Back Downstairs";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.johnporksleeping;
                    boom.Play();
                    break;

                case 7:
                    outputLabel.Text = "The stairs break and you die on impact of a brain injury.\n Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.stairs;
                    lose.Play();
                    break;

                case 8:
                    outputLabel.Text = "You see two doors that lead outside. \nYou find a key on a nearby table.\n Which door do you open?";
                    option1Button.Text = "Left";
                    option2Button.Text = "Right";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.doors;
                    boom.Play();
                    break;

                case 9:
                    outputLabel.Text = "Wrong Door. John Pork wakes up and catches you struggling to open it.\n Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.johnporkmad;
                    lose.Play();
                    break;

                case 10:
                    outputLabel.Text = "The door opens, but you wake up John Pork. \nWhat will you do?";
                    option1Button.Text = "Run";
                    option2Button.Text = "Hide In A Bush";
                    option3Button.Text = "Fight Him";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.doors;
                    boom.Play();
                    break;

                case 11:
                    outputLabel.Text = "You can't outrun John Pork, he locks you back in the basement.\n Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.johnporkmad;
                    lose.Play();
                    break;

                case 12:
                    outputLabel.Text = "John Pork sees you and takes you back to the basement.\n Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.johnporkmad;
                    lose.Play();
                    break;

                case 13:
                    outputLabel.Text = "You successfully beat up John Pork and ran away.\n Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.hauntedmansion2;
                    win.Play();
                    break;

                case 14:
                    outputLabel.Text = "The basement is clear. You see a boarded up doorframe leading to outside. \n There is a hammer and a saw. \nWhich will you use to break the boards?";
                    option1Button.Text = "Hammer";
                    option2Button.Text = "Saw";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.boardeddoor;
                    boom.Play();
                    break;

                case 15:                  
                    outputLabel.Text = "The hammer is loud. You hear footsteps after breaking the boards.";
                    await Task.Delay(2000);    
                    outputLabel.Text = "The hammer is loud. You hear footsteps after breaking the boards.\n John Pork catches you and boards back up the door, locking you away.\n Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.johnporkmad;
                    lose.Play();
                    break;

                case 16:
                    outputLabel.Text = "You quietly saw through the boards and escaped.\n Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "no";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.hauntedmansion2;
                    win.Play();
                    break;

                case 17:
                    outputLabel.Text = "You hear footsteps down the hall.\n What will you do?";
                    option1Button.Text = "Hide";
                    option2Button.Text = "Investigate";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.hall;
                    boom.Play();
                    break;

                case 18:
                    outputLabel.Text = "You knocked over a plant trying to hide and were caught. \nPlay again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.johnporkmad;
                    lose.Play();
                    break;

                case 19:
                    outputLabel.Text = "Quandale Dingle is sleepwalking down the hall. \nYou see a door and a window leading outside.";
                    option1Button.Text = "Escape Through Door";
                    option2Button.Text = "Escape Through Window";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.doorwindow;
                    boom.Play();
                    break;

                case 20:
                    outputLabel.Text = "The door was a trap! \n You were knocked out and sent back to the basement \nPlay again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.johnporkmad;
                    lose.Play();
                    break;

                case 21:
                    outputLabel.Text = "You silently escape and run away. \nPlay again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.hauntedmansion2;
                    win.Play();
                    break;

                case 99:
                    outputLabel.Text = "Thanks For Playing!";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    option3Button.Text = "";
                    // pictureBox.Image = ;
                    await Task.Delay(2000);
                    Application.Exit();
                    break;




            }
        }
    }
}
