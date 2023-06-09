﻿/*
 * Programmare con C# 10 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 4:
 * Esercizio 4) Scrivere un’applicazione Console, con contesto nullable abilitato, che richieda
 * all’utente l’inserimento di una stringa, e poi ne stampi i primi due e gli ultimi
 * due caratteri.
 */

#nullable enable
Console.WriteLine("Inserisci una stringa: ");
string? str = Console.ReadLine();

if (str != null && str.Length > 1)
{
    Console.WriteLine("primi due caratteri:" + str[0] + str[1]);
    Console.WriteLine("ultimi due caratteri:" + str[^2] + str[^1]);
    Console.WriteLine("dal primo all'ultimo:" + str[..] );
    Console.WriteLine("dal secondo al penultimo:" + str[1..^1]);
    Console.WriteLine("dal secondo all'ultimo:" + str[1..^0]);
}
else
    Console.WriteLine("Stringa vuota; nulla da stampare");
