using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Transactions;
using Stirnreihe.Data;

bool quit = false;
int choice;
var lineOfPeople = new LineOfPeople();


Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to?");
Console.WriteLine("1) Add a person to the line");
Console.WriteLine("2) Print the line");
Console.WriteLine("3) Clear the line");
Console.WriteLine("4) Exit");

do
{
    Console.WriteLine();
    Console.Write("Your choice: ");
    choice = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    switch (choice)
    {
        case 1: AddPersonToLine(); break;
        case 2: PrintTheLine(); break;
        case 3: ClearTheLine();break;
        case 4: quit = true; break;
        default: Console.WriteLine("Invalid input, please try again."); break;
    }
} while (!quit);

void AddPersonToLine()
{
    var person = new Person();
    Console.Write("First Name: ");
    person.FirstName = Console.ReadLine()!;
    Console.Write("Last Name: ");
    person.LastName = Console.ReadLine()!;
    Console.WriteLine("Height in cm: ");
    person.Height = int.Parse(Console.ReadLine()!);

    lineOfPeople.AddToFront(person);

}

void PrintTheLine()
{
    Node? current = lineOfPeople.First;
    if (current == null)
    {
        Console.WriteLine("The line is empty.");
        return;
    }

    Console.WriteLine("People in the line:");
    while (current != null)
    {
        Console.WriteLine(current.Person.ToString());
        current = current.Next;
    }
}

void ClearTheLine()
{
    lineOfPeople.Clear();
    Console.WriteLine("The line has been cleared.");
}