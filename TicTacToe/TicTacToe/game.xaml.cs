using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTacToe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class game : ContentPage
	{
        Boolean firstPlay = true;
        String Mark;
        gamePlay gameplay;
        player p1;
        player p2;



        public game ()
		{
			InitializeComponent ();
             p1 = new player { name = "player 1", id = 1 };
             p2 = new player { name = "player 2", id = 2 };
             gameplay = new  gamePlay();

        }

        public void Checked(Object sender, EventArgs e)
        {
            var b = sender as Button;
            Console.WriteLine("firstPlayer : " + firstPlay);
            if (firstPlay)
            {
                Mark = "X";
            }
            else
            {
                Mark = "O";
            }
            if (b.Id == b1.Id && b1.Text == null)
            {
                b1.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(0, 0, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                    firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(0, 0, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                    firstPlay = true;
                }
            }
            else if (b.Id == b2.Id && b2.Text == null)
            {
                b2.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(0, 1, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                    firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(0, 1, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                        firstPlay = true;
                }
            }
            else if(b.Id == b3.Id && b3.Text == null)
            {
                b3.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(0, 2, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                        firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(0, 2, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                        firstPlay = true;
                }
            }
            else if (b.Id == b4.Id && b4.Text == null)
            {
                b4.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(1, 0, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                    firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(1, 0, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                        firstPlay = true;
                }
            }
            else if (b.Id == b5.Id && b5.Text == null)
            {
                b5.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(1, 1, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                        firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(1, 1, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                        firstPlay = true;
                }
            }
            else if (b.Id == b6.Id && b6.Text == null)
            {
                b6.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(1, 2, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                        firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(1, 2, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                        firstPlay = true;
                }
            }
            else if (b.Id == b7.Id && b7.Text == null)
            {
                b7.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(2, 0, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                        firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(2, 0, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                        firstPlay = true;
                }
            }
            else if (b.Id == b8.Id && b8.Text == null)
            {
                b8.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(2, 1, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                        firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(2, 1, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                        firstPlay = true;
                }
            }
            else if (b.Id == b9.Id && b9.Text == null)
            {
                b9.Text = Mark;
                if (firstPlay)
                {
                    if (gameplay.addToBoard(2, 2, p1) == 1)
                    {
                        DisplayAlert("Game over", "Player 1 win", "ok");
                        gameOver();
                    }
                    firstPlay = false;
                }
                else
                {
                    if (gameplay.addToBoard(2, 2, p2) == 1)
                    {
                        DisplayAlert("Game over", "Player 2 win", "ok");
                        gameOver();
                    }
                    firstPlay = true;
                }


            }

            if (checkOver())
            {
                DisplayAlert("Game over", "it's a Draw", "ok");
                gameOver();
            }

        }

        public Boolean checkOver()
        {
            return
                (
                b1.Text != null &&
                b2.Text != null &&
                b3.Text != null &&
                b4.Text != null &&
                b5.Text != null &&
                b6.Text != null &&
                b7.Text != null &&
                b8.Text != null &&
                b9.Text != null);
                
        }

        public void gameOver()
        {
            gameplay.gameOver();
            b1.Text = null;
            b2.Text = null;
            b3.Text = null;
            b4.Text = null;
            b5.Text = null;
            b6.Text = null;
            b7.Text = null;
            b8.Text = null;
            b9.Text = null;
        }
    }
}