namespace Core.Utilities.Results;

public class DataResult<T> : IDataResult<T>
{
    public DataResult(bool success, string message, T data) : this(success, data)
    {
        Message = message;
    }
    
    public DataResult(bool success, T data)
    {
        Success = success;
        Data = data;
    }

    public bool Success { get; }
    public string Message { get; }
    public T Data { get; }
}