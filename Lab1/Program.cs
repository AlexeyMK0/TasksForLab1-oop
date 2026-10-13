// See https://aka.ms/new-console-template for more information

using Lab1;

var s = new Stock([1, 2, 3]);
// ((List<int>)s.Entries).Add(10);
Console.WriteLine(string.Join(", ", s.Entries));

Console.WriteLine(string.Join(", ", s.Entries));


public sealed class Stock
{
    private readonly List<int> _entries = [];

    public Stock(IEnumerable<int> entries)
    {
        _entries = entries.ToList();
    }

    public IReadOnlyCollection<int> Entries => _entries.AsReadOnly();
}


public sealed record Sku(string Value)
{
    public int Length => Value.Length;
}