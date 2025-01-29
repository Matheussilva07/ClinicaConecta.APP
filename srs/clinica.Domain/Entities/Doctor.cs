using clinica.Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace clinica.Domain.Entities;
public class Doctor
{
	[BsonElement]
	[BsonRepresentation(BsonType.ObjectId)]
	public string Id { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Cpf { get; set; } = string.Empty;
	public string Rg { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;
	public string Telephone { get; set; } = string.Empty;
	public string Expertise { get; set; } = string.Empty;
	public DateTime Date_Hire { get; set; }
	public DateTime? Date_Fire { get; set; }
    public decimal Value { get; set; }
    public Expiration Expiration { get; set; }
	public int Sessions {  get; set; }
	public int Work_hours { get; set; }
	public string Turns { get; set; } = string.Empty;
	public string BankAccount { get; set; } = string.Empty;
}


