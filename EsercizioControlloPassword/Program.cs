string password = "LaMiaPassword";

string passwordMinuscola = password.ToLower(); //lamiapassword

bool contieneLetteraMaiuscola = password != passwordMinuscola;

string inputPassword = Console.ReadLine();
// modo easy
bool contieneNumero =
    inputPassword.Contains('0') ||
    inputPassword.Contains('1') ||
    inputPassword.Contains('2') ||
    inputPassword.Contains('3') ||
    inputPassword.Contains('4') ||
    inputPassword.Contains('5') ||
    inputPassword.Contains('6') ||
    inputPassword.Contains('7') ||
    inputPassword.Contains('8') ||
    inputPassword.Contains('9');

// modo pro
bool contieneNumeroPro = inputPassword.All(char.IsDigit);

bool contieneCarattereSpeciale =
    inputPassword.Contains('#') ||
    inputPassword.Contains('?') ||
    inputPassword.Contains('!');