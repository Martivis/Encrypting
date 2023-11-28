namespace DoubleTransposition;

public class Key
{
    public IList<int> Sequence { get; }

    public int Length => Sequence.Count;

    public Key(string key)
    {
        Sequence = ParseKey(key);
    }

    private IList<int> ParseKey(string key)
    {
        return key.Select(c => (int)c - 1).ToList();
    }

    private bool IsSequenceValid()
    {
        var sorted = Sequence.Order().ToList();
        for (var i = 0; i < Length; i++)
        {
            if (sorted[i] != i)
                return false;
        }
        return true;
    }
}