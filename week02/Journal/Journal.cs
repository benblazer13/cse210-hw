using System;
using System.Collections.Generic;
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
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in journal yet.\n");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        Console.WriteLine("================");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal saved to {file}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}\n");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded from {file}\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{file}' not found.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}\n");
        }
    }
}