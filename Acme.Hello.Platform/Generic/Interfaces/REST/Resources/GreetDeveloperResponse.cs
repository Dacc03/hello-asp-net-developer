namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;


/// <summary>
///
/// This is a response to greet a developer. It contains the developer's ID, full name, and a message.
/// It is used as output for greeting requests.
/// </summary>
/// <param name="Id"> The id of the developer.Can be null</param>
/// <param name="Fullname"> The Fullname of the developer.Can be null</param>
/// <param name="Message"> The greeting message.</param>
public record GreetDeveloperResponse(Guid? Id, string? Fullname, string? Message)
{
    /// <summary>
    /// This constructor is used to create a GreetDeveloperResponse with only a message.
    /// </summary>
    /// <param name="Message"></param>
    public GreetDeveloperResponse(string Message) : this(null, null, Message)
    {
        
    }
}