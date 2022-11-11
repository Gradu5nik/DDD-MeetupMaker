using MeetupMaker.Domain.Entities;

namespace MeetupMaker.Application.Common.Interfaces.Persistance;

public interface IUserRepo
{
    User? GetByEmail(string email);
    void Add(User user);
}