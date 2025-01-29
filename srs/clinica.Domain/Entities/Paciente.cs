using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace clinica.Domain.Entities;
public class Paciente
{
	[BsonElement]
	[BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
	public string? Email { get; set; } = string.Empty;
	public string Telephone { get; set; } = string.Empty;
	public string CPF { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;
	public DateTime Birth { get; set; }
}
