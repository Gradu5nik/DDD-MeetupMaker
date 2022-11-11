using MeetupMaker.Application.Common.Interfaces.Persistance;
using MeetupMaker.Domain.Entities;

namespace MeetupMaker.Infrastructure.Persistance;
public class UserRepo : IUserRepo
{
    private static readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }
}