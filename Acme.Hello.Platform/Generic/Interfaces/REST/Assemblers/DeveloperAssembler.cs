using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// This class is responsible for convert from REST resources to domain entities.
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a GreetDeveloperResponse to a Developer entity.
    /// </summary>
    /// <param name="request">The GreetDeveloperResponse </param>
    /// <returns></returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null 
            || string.IsNullOrWhiteSpace(request.FirtstName) 
            || string.IsNullOrWhiteSpace(request.LastName))
        {
            return null;
        }
        
        return new Developer(request.FirtstName, request.LastName);
    }
}