namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;


/// <summary>
/// This is a request to greet a developer.
/// </summary>
/// <param name="FirtstName"> The first name of the developer. Can be null   </param>
/// <param name="LastName"> The last name of the developer . Can be null    </param>
public record GreetDeveloperRequest(string? FirtstName, string? LastName);
