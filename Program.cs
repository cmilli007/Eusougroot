const string ParaSairDigite = "tchau Groot";
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("--CHAT DO GROOT--");
Console.ResetColor();
string pergunta;

do 
{
    Console.WriteLine("Faça uma pergunta para o Groot?");
     pergunta = Console.ReadLine()!;
     string resposta = GrootResponde(pergunta);

            Exibe(GrootResponde(pergunta));
}
while (pergunta.Trim().ToLower() != ParaSairDigite);

    void Exibe(string resposta)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Resposta: {resposta}");
    Console.ResetColor();
}

    string resposta(string pergunta);
{
    return pergunta.Trim().ToLower() == FraseParaSair ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}