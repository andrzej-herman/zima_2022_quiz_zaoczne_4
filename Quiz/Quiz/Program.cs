using Quiz;




// tworzenie obiektu typu Gra
var game = new Game();

// tworzenie obiektu typu Message
var message = new Message();

// wyswietlanie powitania
message.DisplayWelcomeScreen();

// losowanie pytania z aktualnej kategorii
game.GetQuestion();

Console.WriteLine(game.CurrentQuestion.Content);
Console.WriteLine();
Console.WriteLine();

//konstruktor
//dalej => tworzenie bazy pytań
// wyjaśnić namespace


