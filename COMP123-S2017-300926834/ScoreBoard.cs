using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_300926834
{
    //name: komaldeep kaur
   public class ScoreBoard: PickHighestCardForm
    {
        //PUBLIC VARIABLES

        //PRIVATE VARIABLES
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

    // public  properties
    public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;

            }
        }
        public int Score
        {
            get { return this._score; }
            set { this._score = value; }
        }
        public TextBox ScoreTextBox
        {
            get { return this._scoreTextBox; }
            set { this._scoreTextBox = value; }
        }
        public int Time
        {
            get { return this._time; }
            set { this._time = value; }
        }
        public TextBox TimeTextBox
        {
            get { return this._timeTextBox; }
            set { this._timeTextBox = value; }
        }
        //constructors
        /// <summary>
        /// it is the main constructor with 3 parameters
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }

        //public methods
        public static void UpdateTime()
        {
          
            if (ScoreBoard.Time == 0)
            {
                CountDownTimer.Enabled = false;
                DealButton.Enabled = false;
                this._disableDealtCards();
                this._showFinalScore();
            }

        }

    }
}
