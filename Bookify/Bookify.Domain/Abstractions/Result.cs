using System.Diagnostics.CodeAnalysis;

namespace Bookify.Domain.Abstractions;

internal class Result
{
    protected internal Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None)
        {
            throw new InvalidOperationException();
        }

        if (!isSuccess && error == Error.None)
        {
            throw new InvalidOperationException();
        }

        IsSuccess = isSuccess;
        Error = error;
    }

    internal bool IsSuccess { get; }

    internal bool IsFailure => !IsSuccess;

    internal Error Error { get; }

    internal static Result Success() => new(true, Error.None);

    internal static Result Failure(Error error) => new(false, error);

    internal static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);

    internal static Result<TValue> Failure<TValue>(Error error) => new(default, false, error);

    internal static Result<TValue> Create<TValue>(TValue? value) =>
        value is not null ? Success(value) : Failure<TValue>(Error.NullValue);
}

internal class Result<TValue> : Result
{
    private readonly TValue? _value;

    protected internal Result(TValue? value, bool isSuccess, Error error)
        : base(isSuccess, error)
    {
        _value = value;
    }

    [NotNull]
    internal TValue Value => IsSuccess ? _value! : throw new InvalidOperationException("The value of a failure can not be accessed");

    public static implicit operator Result<TValue>(TValue? value) => Create(value);
}