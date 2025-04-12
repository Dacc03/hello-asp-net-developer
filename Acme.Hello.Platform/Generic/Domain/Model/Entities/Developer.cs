namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a developer entity in the domain model for the Generic boundened context.
/// </summary>
public class Developer
{
    /// <summary>
    /// Gets the unique identifier for the developer.
    /// </summary>
    public Guid Id { get; } = Guid.NewGuid();
    /// <summary>
    /// Gets the first name of the developer.
    /// </summary>
    public string FirstName { get; }
    /// <summary>
    /// Gets the last name of the developer.
    /// </summary>
    public string LastName { get; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Developer"/> class with the specified first and last name.
    /// </summary>
    /// </remarks>
    /// Te constructor ensures that the first and last names are not null or whitespace.
    /// </remarks>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) ? " " : firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName) ? " " : lastName.Trim();
    }
    /// <summary>
    /// Gets the full name of the developer by concatenating the first and last names.
    /// </summary>
    /// <returns>The full name of the developers. </returns>
    
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    /// <summary>
    /// Checks if either the first name or last name is empty or consists only of whitespace.
    /// </summary>
    /// <returns> true if either name is empty; otherwise, false</returns>
    
    public bool IsNameEmpty() => !string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName);
}