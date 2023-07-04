/*
 * Programmare con C# 10 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 5:
 * Esercizio 1) Scrivere un’applicazione Console che stampi il valore predefinito, il valore
 * minimo e quello massimo di ognuno dei 12 tipi numerici primitivi.
 */

/*sbyte sb = default;
byte b = default;
short s = default;
ushort us = default;
int i = default;
uint ui = default;
long lo = default;
ulong ul = default;
float f = default;
double d = default;
decimal dec = default;
char ch = default;

Console.WriteLine("sbyte " + sb );
Console.WriteLine("byte " + b);
Console.WriteLine("short " + s);
Console.WriteLine("ushort " + us);
Console.WriteLine("int " + i);
Console.WriteLine("uint " + ui);
Console.WriteLine("long " + lo);
Console.WriteLine("ulong " + ul);
Console.WriteLine("float " + f);
Console.WriteLine("double " + d);
Console.WriteLine("decimal " + dec);
Console.WriteLine("char " + ch);
*/
using System.Runtime.InteropServices;

var types = new[] { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal) };

Console.WriteLine("| {0, 10} | {1, 7} | {2, 30} | {3, 30} |", "Type", "Byte(s)", "Min", "Max");
Console.WriteLine("|------------|---------|--------------------------------|--------------------------------|");
foreach (var type in types)
{
    Console.WriteLine(
       "| {0, 10} | {1, 7} | {2, 30} | {3, 30} |",
       type.Name,
       Marshal.SizeOf(Activator.CreateInstance(type)),
       type.GetField("MinValue").GetValue(null),
       type.GetField("MaxValue").GetValue(null));
}