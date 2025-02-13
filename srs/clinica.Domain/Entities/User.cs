using clinica.Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace clinica.Domain.Entities;
public class User
{
	[BsonElement]
	[BsonRepresentation(BsonType.ObjectId)]
	public string Id { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Password { get; set; } = string.Empty;

	[BsonGuidRepresentation(GuidRepresentation.CSharpLegacy)]
	public Guid UserIdentifier { get; set; }
	public string Role { get; set; } = Roles.TEAM_MEMBER;
}
