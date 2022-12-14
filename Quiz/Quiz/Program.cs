using Quiz;

// tworzenie obiektu typu Gra
var game = new Game();

// tworzenie obiektu typu Message
var message = new Message();

// wyswietlanie powitania
message.DisplayWelcomeScreen();

while(true)
{
    // losowanie pytania z aktualnej kategorii
    game.GetQuestion();

    // wyświetlanie pytania i pobieranie odpowiedzi gracza
    int playerAnswer = game.CurrentQuestion.DisplayQuestion();

    // sprawdzanie czy gracz udzielił prawidłowej odpowiedzi
    var correct = game.CheckPlayerAnswer(playerAnswer);

    // rodział logiki na dwie ścieżki w zależmości od odpowiedzi gracza
    if (correct)
    {
        if (game.IsLastCategory())
        {
            message.FinalScreen();
            break;
        }
        else
        {
            message.GoodAnswer();
        }
    }
    else
    {
        message.DisplayFailAndGameOver();
        break;
    }
}


