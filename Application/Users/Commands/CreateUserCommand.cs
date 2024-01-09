using Application.Interfaces.Repository;
using Application.Users.DTOs;
using MediatR;

namespace Application.Users.Commands;


public record CreateUserCommand(): IRequest<List<UserInfoDto>>;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, List<UserInfoDto>>
{
    private readonly IUserRepository _userRepository;

    public CreateUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<UserInfoDto>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
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