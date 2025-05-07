namespace Ciot.Core.Types;

public class Result<TSuccessType, TErrorType>
{
    public TSuccessType Success { get; }
    public TErrorType? Error { get; }
    public bool IsSuccess => Success != null;
    public bool IsError => Error != null;

    private Result(TSuccessType success, TErrorType? error)
    {
        Success = success;
        Error = error;
    }

    public static Result<TSuccessType, TErrorType> Ok(TSuccessType success) =>
        new(success, default);

    public static Result<TSuccessType, TErrorType> Fail(TErrorType error) =>
        new(default, error);
}