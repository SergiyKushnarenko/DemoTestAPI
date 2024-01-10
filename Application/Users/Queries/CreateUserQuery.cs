using Application.Interfaces.Repository;
using Application.Users.DTOs;
using MediatR;

namespace Application.Users.Queries;

public record CreateUserQuery() : IRequest<List<UserInfoDto>>;
public class CreateUserQueryHandler : IRequestHandler<CreateUserQuery, List<UserInfoDto>>
{
    private readonly IUserRepository _userRepository;

    public CreateUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<UserInfoDto>> Handle(CreateUserQuery request, CancellationToken cancellationToken)
    {
        var result = await _userRepository.GetAllUsers();
        //Add Map
        var mappedResult = new List<UserInfoDto>()
        {
            new UserInfoDto()
            {
                Email = "dadasd@.com",
                FirstName = "My Clean",
                LastName = "Acrh"
            }
        };
        return mappedResult;
    }
}