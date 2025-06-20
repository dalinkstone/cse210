using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string file)
    {
	using (StreamWriter outputFile = new StreamWriter(file))
	{
		foreach (Entry e in _entries)
		{
			outputFile.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
			outputFile.WriteLine(e._entryText);
		}
	}

    }

    public void LoadFromFile(string file)
    {
	string[] lines = System.IO.File.ReadAllLines(file);


	// I'm pretty sure we I need to use a delimeter here in order to capture the Date 
	// variable and the Prompt variable appropriately. My idea is to use a delimeter of
	// '- Prompt: ' so that I avoid any chance someone could type a '-' in their entry
	// text and unknowingly break the program. For this purpose, I also need to use the 
	// .Replace method on the strings to remove the 'Date: ' and '- Prompt: ' text
	// from what will become the variables
	// 
	// I think this will work best and the code is so nice and concise.
	// I found the .replace method here: https://learn.microsoft.com/en-us/dotnet/api/system.string.replace
	for (int i = 0; i < lines.Length; i += 2)
	{
		Entry e = new Entry();

		string[] entryPieces = lines[i].Split(" - Prompt: ");
		e._date = entryPieces[0].Replace("Date: ", "");
		e._promptText = entryPieces[1];
		e._entryText = lines[i + 1];

		_entries.Add(e);
	}
    }
}
