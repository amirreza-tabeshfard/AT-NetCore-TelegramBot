using System.Runtime.Serialization;

namespace ATNetCoreTelegramBot.Common.Exceptions;

internal class ClientException : ApplicationException
{
    public ClientException(string message)
        : base(message)
    {

    }

    public ClientException(string message, Exception? exception)
        : base(message, exception)
    {

    }

    public ClientException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {

    }
}