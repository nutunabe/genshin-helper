namespace GenshinHelper.Application.Common;

public class ResponseModel
{
    public bool Success { get; set; } = true;

    public ResponseModel()
    {
    }
}

public class ResponseModel<T> : ResponseModel
{
    public T Result { get; set; }

    public ResponseModel(T result)
    {
        Result = result;
    }
}