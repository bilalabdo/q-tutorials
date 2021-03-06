namespace netBox.Schemas
{
  using GraphQL.Types;
  using netBox.Models;
  using netBox.Repositories;
  using netBox.Types;

  /// <summary>
  /// All mutations defined in the schema used to modify data.
  /// </summary>
  /// <example>
  /// This is an example mutation to create a new human.
  /// <c>
  /// mutation createHuman($human: HumanInput!) {
  ///   createHuman(human: $human)
  ///   {
  ///     id
  ///     name
  ///     dateOfBirth
  ///     appearsIn
  ///   }
  /// }
  /// This is an example JSON of the variables you also need to specify to create a new human:
  /// {
  ///  "human": {
  ///     "name": "Muhammad Rehan Saeed",
  ///     "homePlanet": "Earth",
  ///     "dateOfBirth": "2000-01-01",
  ///     "appearsIn": [ "NEWHOPE" ]
  ///   }
  /// }
  /// </c>
  /// </example>
  public class MutationObject : ObjectGraphType<object>
  {
    public MutationObject()
    {
      this.Name = "Mutation";
      this.Description = "The mutation type, represents all updates we can make to our data.";
    }
  }
}
