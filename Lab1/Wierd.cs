namespace Lab1;

public class Wierd
{
    private sealed record PrivateClass();

    public abstract record Result
    {
        private Result() { }

        public sealed record Success<T>(T Value) : Result;
        
        public sealed record Failure(string Value) : Result;
    }

    public static Result Func()
    {
        return new Result.Success<PrivateClass>(new());
    }
}

public record Bebra
{
    public string Aboba { get; init; }
}