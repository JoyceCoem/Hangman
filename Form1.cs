/*  Filename: HangmanProject.sln
 *  Author: Joyce Koloando Coem
 *  Created: 11/04/2023
 *  Description: This program is composed of all the methods and constructor  that will be use to build the game  "Hangman".
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HangmanProject
{
    public partial class HangmanGame : Form
    {
        public HangmanGame()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            btnStart.Visible = false;//this line will make the start button to invisible
            btnExit.Visible = false;//this line will make the exit button to invisible
            lblWelcome.Visible = false;//this line will make the lblWelcome to invisible
            groupBox2.Visible = true;//this line will make the groupBox2 to visible
            groupBox1.Visible = true;//this line will make the groupBox1 to visible
            groupBox3.Visible = true;//this line will make the groupBox3 to visible
            MessageBox.Show("Welcome to HangMan, Which color do you think it is?", "Hangman", MessageBoxButtons.OKCancel);// this line will show a messagebox to welcome the user
            DrawHang();// this line will call the drawHang method to draw the post
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();// this line will exit or close the application
        }
        // this variable has been initiased to keep track of which bodypart needs to be drawn
        int Number = 0;
        //this initialize variable will be use later on .
        string Colors = "";
        // initialized for future use.
        int score = 0;

        //this line create a new list of labels which will be represent by underscores.
        List<Label> List = new List<Label>();

        //creating Arraylist to keep track of correct and incorrect answers
        ArrayList correctAnswer = new ArrayList();
        ArrayList incorrectAnswer = new ArrayList();


        //creating sortedList for the scoreBoard and the highScores
        IDictionary<string, int> scores = new Dictionary<string, int>();
        IDictionary<string, int> highScores = new Dictionary<string, int>();





        //this enumaration is used to store all the bodyparts taht will be drawn.
        enum bodyOfHangnam
        {
            head,
            leftEye,
            rightEye,
            mouth,
            leftArm,
            rightArm,
            body,
            leftLeg,
            rightLeg,
            nose
        }




        //this method will create or Draw the hang post .
        void DrawHang()
        {
           
            Graphics g = HangmanPost.CreateGraphics();// this graphcs will be draw inside the panel(hangmanPost)
            Pen p = new Pen(Color.Yellow, 10);// the pen used to draw with 
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 50));
            DesignLabel();// this calls the method that creates labels
            // message used to welcome the Player
            



        }






        //the code will draw body of the man  and will use the enum a name 
        void DrawBodyOfHangman(bodyOfHangnam bh)
        {
            
            Graphics g = HangmanPost.CreateGraphics();
            Pen p = new Pen(Color.Red, 5);

            // using the if/else if to check which part am i drawing
            if (bh == bodyOfHangnam.head)// draw the head
                g.DrawEllipse(p, 40, 50, 40, 40);

            else if (bh == bodyOfHangnam.leftEye)//draw the left eye with the ellipse that will draw small square
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 50, 60, 5, 5);
            }
            else if (bh == bodyOfHangnam.rightEye)//draw the right eye with the ellipse that will draw small square
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 63, 60, 5, 5);
            }
            else if (bh == bodyOfHangnam.mouth)// draw the  mouth with an arc   
                g.DrawArc(p, 50, 60, 20, 20, 45, 90);

            else if (bh == bodyOfHangnam.body)// draw the body
                g.DrawLine(p, new Point(60, 90), new Point(60, 170));

            else if (bh == bodyOfHangnam.leftArm)//draw the left Arm
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));

            else if (bh == bodyOfHangnam.rightArm)// draw the right Arm
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));

            else if (bh == bodyOfHangnam.leftLeg)// draw the left leg
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));

            else if (bh == bodyOfHangnam.rightLeg)// Draw the right Leg
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));

            else if (bh == bodyOfHangnam.nose)// Draw the nose
            {
                SolidBrush s = new SolidBrush(Color.Pink);
                g.FillEllipse(s, 55, 69, 5, 5);

            }

        }


        /* this method will generate the undercores 
         * it will give random word to a variable
         * will convert any string variable to a cha array(charArray)
         * and will create the length of the word to put it as underscore
         */
        void DesignLabel()
        {
            Colors = RandomWord(); // this line is getting the random word 
            char[] word = Colors.ToCharArray();//this line is casting the random word to a character
            int between = 460 / word.Length;// this line is putting space between character and label


            for (int loop = 0; loop < word.Length; loop++)// this for loop will iterate through each character 
            {

                List.Add(new Label());// this line is creating new labels
                List[loop].Location = new Point((loop * between) + 20, 110);// specifying the location of the labels
                List[loop].Text = "___"; // this line is specifiying that that the label should like "___"
                List[loop].Parent = groupBox2;//set the parent of the control 
                List[loop].BringToFront();// is bringing to front 
                List[loop].CreateControl();// is creating a control 
            }

            //the text of lblNumber will display the length o the word to guess
            lblNumber.Text = "" + (word.Length).ToString();

        }




        // populate my array to generate random word
        string RandomWord()//this line will draw random colors
        {
            string[] colorList = new string[10];
            colorList[0] = "BLUE";
            colorList[1] = "YELLOW";
            colorList[2] = "GRAY";
            colorList[3] = "BROWN";
            colorList[4] = "MAROON";
            colorList[5] = "PINK";
            colorList[6] = "BELGE";
            colorList[7] = "PURPLE";
            colorList[8] = "BLACK";
            colorList[9] = "WHITE";
            Random ranGen = new Random(); // instance of the random generator
            var idx = ranGen.Next(0, 9);
            return colorList[ranGen.Next(0, colorList.Length)];

        }





        private void HangmanGame_Shown(object sender, EventArgs e)
        {
            DrawHang();
          
            // calling the DrawHang method to draw the hang post

        }





        // thi mehod reset the game to a new state
        void clearGame()
        {
            Graphics g = HangmanPost.CreateGraphics(); // recreate another graphics for the panel
            g.Clear(HangmanPost.BackColor);//clear everything
            DrawHang();// Redraw the hang post
            RandomWord();// new random word
            DesignLabel();// generate labels for the new word


            lstBxscoreboard.Items.Clear();
            score = 0;// this line is initializing or reseting the counter 
            Number = 0;//reset the bodypart counter

            lblSize.Text = "Wrong Letter : ";//clear and reset the missed guesses 
            txtLetter.Text = "";
        }



        private void btnGuess_Click(object sender, EventArgs e)
        {
           
          
            score++;//increments the score variables by 1 
            char l = txtLetter.Text.ToUpper().ToCharArray()[0];//Get the character that the user submitted, conversed to lowercase and to a variable
            //only one element in properties
            try
            {

                if ((Char.IsLetter(l)) && (Colors.Contains(l)))//Check if the character entered is actually a letter
                {
                    correctAnswer.Add(l);//Adds the letter to the correct ArrayList.
                    //Create a character array of containing all the characters in the word.
                    char[] ltts = Colors.ToCharArray();
                    //Iterate through the entire array.
                    for (int loop = 0; loop < ltts.Length; loop++)
                    {
                        if (ltts[loop] == l) //Check if the letter submitted is the correct letter.
                            List[loop].Text = l.ToString();
                    }


                    //Check to see if the user has won 
                    foreach (Label W in List)
                        if (W.Text == "___") return;

                    UpdateScore();//Updates the scoreboard and highscore list.


                    MessageBox.Show("You Woon!!!!", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.None);


                }
                else
                {
                    incorrectAnswer.Add(l);//Adds the letter to the incorrect ArrayList.

                    MessageBox.Show("The word does not contain this letter!", "Try again!", MessageBoxButtons.RetryCancel);
                    lblMissed.Text += " " + l.ToString() + " ,";
                    //drawing the next bodypart upon incorrect guess.
                    DrawBodyOfHangman((bodyOfHangnam)Number);
                    Number++;
                    lblLives.Text = "Lives used : " + Number.ToString() + "/10";


                    //Reaching the final bodypart triggers the game lost message.
                    if (Number == 10)
                    {
                        MessageBox.Show("you have lost,The Colors was " + this.Colors, "Oops!");
                        clearGame(); //Call the method to reset the game state when you lose
                    }
                }
            }
            catch(Exception ex)
            {
                if (char.IsNumber(l))//check if it is letter
                {
                    MessageBox.Show(ex.Message+"Please enter only Letter", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    
                }
                
            }
            
            
        }

        // This methods will updates the scoreboard and the highscore list.
        private void UpdateScore()                                         //This method updates the scoreboard and the highscore list.
        {
            if (!scores.ContainsKey(Colors))                                     //Checks if the scores dictionary does not contain the current word's key.
            {
                scores.Add(Colors, score);                                       //Adds the score to the sortedList. *The dictionary version of it. 
            }
            else                                                               //Otherwise, set the value to score.
            {
                scores[Colors] = score;
            }

            if (!highScores.ContainsKey(Colors))                                 //Checks if the highscores dictionary does not contain the word's key.
            {
                highScores.Add(Colors, score);                                   //Adds the high score to the Dictionary for display later.
            }

            if (score < highScores[Colors])                                      //Check if the current score is lower than the previous high score.
            {
                highScores[Colors] = score;                                      //Replace the score in the highscore dictionary.
            }

            lstBxscoreboard.Items.Add(scores[Colors]);                                //Add the score entry to the scoreboardListBox.

            UpdateHighScore();                                          //Update the high score listBox using the method.
        }



        private void UpdateHighScore()                                  //This method updates the high score listBox, displaying the high scores of each word attempted.
        {
            lstBxhighScore.Items.Clear();                                       //Clears the highscore listBox.

            foreach (var word in highScores.Keys)                              //Iterates through the keys in highscores Dictionary.
            {
                var score = highScores[Colors];                                  //Sets the score variable to the highscore key's value.
                lstBxhighScore.Items.Add($"{word}: {score}");                   //Adds the word and it's score as a string to display in the highScoresBox.
            }
        }

        

        private void btnRestart_Click(object sender, EventArgs e)
        {
            clearGame();//Reset the game 
        }
    }
    /*this code will create a sub-form
     *but it won't be use in this application
    */

    class startGame : Form
    {
        public startGame()
        {
            InitializeComponent();

        }
        void InitializeComponent()
        {
            try
            {
                this.Name = "HangmanGame";

                this.Size = new System.Drawing.Size(700,433);
                this.Text = "Hangman, Let Play";
                this.BackgroundImage = System.Drawing.Bitmap.FromFile("C:/Users/jc12j/Downloads/hang.jpeg");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message," you cannot see the Background image");
            }
            
        }
        
       
        
        
       
    }

     
}
