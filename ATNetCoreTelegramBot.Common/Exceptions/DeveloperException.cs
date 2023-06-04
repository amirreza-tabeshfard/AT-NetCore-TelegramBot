using System.Runtime.Serialization;

namespace ATNetCoreTelegramBot.Common.Exceptions;

public class DeveloperException : ApplicationException
{
    public DeveloperException(string message)
        : base(message)
    {

    }

    public DeveloperException(string message, Exception? exception)
        : base(message, exception)
    {

    }

    public DeveloperException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
            
    }
}