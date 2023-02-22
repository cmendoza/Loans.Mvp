namespace Loans.Mvp.Infrastructure;

public interface IViewResult { }

public record ViewResult() : IViewResult
{
    public static ViewResult Empty { get; } = new();
}

public record ViewResult<T>(T Result) : IViewResult
{
    public static implicit operator ViewResult<T>(T result) => new(result);
}
