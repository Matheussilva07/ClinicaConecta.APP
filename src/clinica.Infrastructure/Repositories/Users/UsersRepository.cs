using clinica.Domain.Entities;
using clinica.Domain.Repositories.Users;
using clinica.Infrastructure.DataAccess;
using MongoDB.Driver;

namespace clinica.Infrastructure.Repositories.Users;
internal class UsersRepository : IWriteOnlyUserRepository, IReadOnlyUserRepository
{
	private readonly IMongoCollection<User> _users = ClinicaDbContext.GetUsersCollection();

	public async Task AddAsync(User user)
	{
	   await _users.InsertOneAsync(user);
	}
	public async Task<bool> ExistUserWithThisEmail(string email)
	{
		var filter = Builders<User>.Filter.Eq(u => u.Email, email);

		var method = await _users.FindAsync<User>(filter);

		var user = await method.FirstOrDefaultAsync();

		if (user is null)
		{
			return false;
		}
		
		return true;	
	}
	public async Task<User> GetUserByEmail(string email)
	{
		var filter = Builders<User>.Filter.Eq(u => u.Email, email);

		var method = await _users.FindAsync<User>(filter);

		var user = await method.FirstOrDefaultAsync();

		return user;		
	}
	public async Task<User> GetUserByUserIdentifier(string userIdentifier)
	{
		var filter = Builders<User>.Filter.Eq(user => user.UserIdentifier, Guid.Parse(userIdentifier));

		var method = await _users.FindAsync<User>(filter);

		var user = await method.FirstOrDefaultAsync();

		return user;
	}
}
