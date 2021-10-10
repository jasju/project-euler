class Problem<T> : IProblem
{
    public string Title { get; set; }
    public Func<T> Payload { get; set; }
    public int Number { get; set; }
    public T Solution { get; set; }
    bool IsSolved { get; set; }
    public void Solve()
    {
        Solution = Payload.Invoke();
        IsSolved = true;
    }

    public override string ToString()
    {
        var s = $"Problema #{Number} - {Title}";

        if (IsSolved)
        {
            s += $" - Solution = {Solution}";
        }

        return s;
    }
}