﻿namespace DoubleTransposition;

public class Key
{
    public IList<int> Sequence { get; }

    public int Length => Sequence.Count;

    public Key(string key)
    {
        Sequence = ParseKey(key);
        if (!IsSequenceValid())
            throw new ArgumentException("Invalid sequence");
    }

    private IList<int> ParseKey(string key)
    {
        return key.Select(c => (int)char.GetNumericValue(c) - 1).ToList();
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