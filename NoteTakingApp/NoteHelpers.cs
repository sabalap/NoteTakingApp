namespace NoteTakingApp;

internal class NoteHelpers
{
    internal List<Note> notes = new();

    internal void ListNotes()
    {
        Console.Clear();
        Console.WriteLine("Notes:\n");

        foreach (Note note in notes)
        {
            Console.WriteLine($"{note.ID}.{note.Title} - {note.Date:yyyy/MM/dd HH:mm:ss}");
        }
    }
}