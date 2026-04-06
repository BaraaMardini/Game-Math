using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace لعبة_Math_Game
{
    public partial class Form1 : Form
    { // Add Sub Mul Div Mix Easy Med Hard Mix  /*             Random rnd = new Random();
      //   f = rnd.Next(10, 20);
        Random rnd = new Random();
        int NumberQuestions;
        string OperationType;
        string QuestionLevel;
        int AnswerQuestionsTrue = 0;
        int AnswerQuestionsFalse = 0;
        int PrivateNumber = 0;
        int Counter = 10;

        char TypeOfOperation()
        {
            if (OperationType == "Add")
            {
                return '+';
            }
            else if (OperationType == "Sub")
            {
                return '-';
            }
            else if (OperationType == "Mul")
            {
                return '*';
            }
            else if (OperationType == "Div")
            {
                return '/';
            }
            else
            {
                int Number = 0;
                Number = rnd.Next(1, 5);
                if (Number == 1)
                {
                    return '+';
                }
                else if (Number == 2)
                {
                    return '-';
                }
                else if (Number == 3)
                {
                    return '*';
                }
                else
                {
                    return '/';
                }

            }

        }

        int LevelOfQuestions()
        {
            if (QuestionLevel == "Easy")
            {
                return 1;
            }
            else if (QuestionLevel == "Med")
            {
                return 2;
            }
            else if (QuestionLevel == "Hard")
            {
                return 3;
            }
            else
            {
                return 4;
            }


        }

        int Number1()
        {
            int level = LevelOfQuestions();

            if (level == 1)
            {
                return rnd.Next(1, 5);
            }
            else if (level == 2)
            {
                return rnd.Next(1, 10);
            }
            else if (level == 3)
            {
                return rnd.Next(1, 15);
            }
            else
            {
                return rnd.Next(1, 20);
            }

        }
        int Number2()
        {

            if (LevelOfQuestions() == 1)
            {
                return rnd.Next(1, 5);
            }
            else if (LevelOfQuestions() == 2)
            {
                return rnd.Next(1, 10);
            }
            else if (LevelOfQuestions() == 3)
            {
                return rnd.Next(1, 15);
            }
            else
            {
                return rnd.Next(1, 20);
            }

        }
      
        bool CheakTheAnswerIsTrue()
        {

            string Question1 = TbTextQuestion.Text;
            float Question = Convert.ToSingle(new DataTable().Compute(Question1, null));




            double Answer = Convert.ToDouble(AnswerQuestion.Text);

            if (Question == Answer)
            {
                return true;
            }
            return false;


        }
        void CompleteGame()
        {


            

            if (CheakTheAnswerIsTrue())
            {
                MessageBox.Show("True", " Result ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AnswerQuestionsTrue++;
                TbAnswerTrue.Text = AnswerQuestionsTrue.ToString();
                timer1.Enabled = false;
                Counter = 0;
            }
            else
            {
                MessageBox.Show("False", " Result  ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AnswerQuestionsFalse++;
                TbAnswerFalse.Text = AnswerQuestionsFalse.ToString();   
                timer1.Enabled = false;
            Counter = 0;
            }



        }
        void NextQuestion()
        {
            int number1 = Number1();
            int number2 = Number2();
            char typeOfOperations = TypeOfOperation();
            TbTextQuestion.Text = number1.ToString() + typeOfOperations.ToString() + number2.ToString();
            Counter = 10;
            timer1.Enabled = true;
            LbCheakAnswer.Enabled = true;
        }

        void StartGame()
        {
            int number1 = Number1();
            int number2 = Number2();
            char typeOfOperations = TypeOfOperation();
            TbTextQuestion.Text = number1.ToString() + typeOfOperations.ToString() + number2.ToString();
            timer1.Enabled = true;

        }

        void EndTheGame()
        {
            if (AnswerQuestionsFalse < AnswerQuestionsTrue)
            {
                MessageBox.Show("You Are Win", " Result The Game ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if(AnswerQuestionsFalse > AnswerQuestionsTrue)
            {
                MessageBox.Show("You Are False ", " Result The Game ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("    Draw   ", " Result The Game ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            CbQuestionsLevel.Enabled = false;
            CbOperationType.Enabled = false;



        }
        void RestartGame()
        {
            AnswerQuestionsTrue = 0;
            AnswerQuestionsFalse = 0;
            TbAnswerTrue.Text = "";
            TbAnswerFalse.Text = "";
            RbStartGame.Checked = false;
            CbOperationType.Text = "";
            CbQuestionsLevel.Text = "";
            CbQuestionsLevel.Enabled = true;
            CbOperationType.Enabled = true ;
            TbTextQuestion.Text = "";
            AnswerQuestion.Text = "";
            RbNumber3.Checked = false;
            RbNumber5.Checked=false;
            RbNumber10.Checked = false;
            RbNumber15.Checked = false;
            Counter = 10;
            LbNextQuestion.Enabled= true;
            LbCheakAnswer.Enabled = true;

           

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void RbNumber3_CheckedChanged(object sender, EventArgs e)
        {
            NumberQuestions = 3;


        }

        private void RbNumber5_CheckedChanged(object sender, EventArgs e)
        {
            NumberQuestions = 5;
        }

        private void RbNumber10_CheckedChanged(object sender, EventArgs e)
        {
            NumberQuestions = 10;

        }

        private void RbNumber15_CheckedChanged(object sender, EventArgs e)
        {
            NumberQuestions = 15;
        }

        private void CbQuestionsLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionLevel = CbQuestionsLevel.Text;
           

        }

        public void CbOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperationType = CbOperationType.Text;
          
        }



        public void RbStartGame_CheckedChanged(object sender, EventArgs e)
        {


            StartGame();


        }









  

        private void LbNextQuestion_Click(object sender, EventArgs e)
        {
            //
            TbTextQuestion.Text = "";
            AnswerQuestion.Text = "";
            NextQuestion();
            if (NumberQuestions == AnswerQuestionsFalse + AnswerQuestionsTrue + 1)
            {
                LbNextQuestion.Enabled = false;

            }
            LbCheakAnswer.Enabled = true;
        }

        private void LbCheakAnswer_Click(object sender, EventArgs e)
        {
            PrivateNumber++;
            CompleteGame();
            TbAnswerTrue.Text = AnswerQuestionsTrue.ToString();
            TbAnswerFalse.Text = AnswerQuestionsFalse.ToString();

          
            LbCheakAnswer.Enabled = false;


            if (AnswerQuestionsFalse + AnswerQuestionsTrue == NumberQuestions)
            {
                EndTheGame();
                
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Counter--;
            
            LbTimer.Text = Counter.ToString();
            if (Counter == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("You are Lost ",  "Result", MessageBoxButtons.OK,MessageBoxIcon.Error);

                Counter = 0;
               LbCheakAnswer.Enabled=false;
                AnswerQuestionsFalse++;
                TbAnswerFalse.Text = AnswerQuestionsFalse.ToString();


            }

        }

        private void TbAnswerTrue_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbRstartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
            timer1.Enabled = false;
            
        }

        private void TbTextQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnswerQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
