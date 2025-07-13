using System;
using System.Collections.Generic;

public class NotesApp
{
    static List<string> notes = new List<string>(); // قائمة لتخزين الملاحظات

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Notes App! 🌟");

        while (true)
        {
            Console.WriteLine("\n1. create a new note");
            Console.WriteLine("2. view a note");
            Console.WriteLine("3. delete a note");
            Console.WriteLine("4. exit");
            Console.Write("Please choose an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNote();
                    break;
                case "2":
                    ViewNotes();
                    break;
                case "3":
                    DeleteNote();
                    break;
                case "4":
                    Console.WriteLine("thank you for using the Notes App! Goodbye! 👋");
                    return;
                default:
                    Console.WriteLine("❌ Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void CreateNote()
    {
        Console.WriteLine("\n create a new note");
        Console.Write("title of the note: ");
        string title = Console.ReadLine() ?? "untitled";
        Console.Write("content of the note: ");
        string content = Console.ReadLine() ?? "no content";

        string fullNote = $"title : {title} | content :  {content}";
        notes.Add(fullNote);
        Console.WriteLine("note created successfully! 📝");
    }

    private static void ViewNotes()
    {
        Console.WriteLine("\n📋 list of all notes");

        if (notes.Count == 0)
        {
            Console.WriteLine("❗ No notes available.");
            return;
        }

        for (int i = 0; i < notes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {notes[i]}");
        }
    }

    private static void DeleteNote()
    {
        ViewNotes();

        if (notes.Count == 0) return;

        Console.Write("\nEnter the number of the note you want to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= notes.Count)
        {
            string removedNote = notes[index - 1];
            notes.RemoveAt(index - 1);
            Console.WriteLine($"🗑️ note is deleted successfully {removedNote}");
        }
        else
        {
            Console.WriteLine("❌ Invalid note number. Please try again.");
        }
    }
}
