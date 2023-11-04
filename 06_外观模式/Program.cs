using static System.Console;


/*
设计模式：外观模式
目的：隐藏复杂的实现
*/


var facade = new Facade();
var result = facade.GetUserAuthorities(11);
Console.WriteLine(result);


interface IUserRepository
{
    object GetById(int id);
}

interface IRoleRepository
{
    IEnumerable<string> GetRoles(in int userId);
}

interface IAuthorityRepository
{
    IEnumerable<string> GetAuthorities(IEnumerable<string> roles);
}


class Facade
{
    private readonly IUserRepository _userRepository;
    private readonly IAuthorityRepository _authorityRepository;
    private readonly IRoleRepository _roleRepository;

    public Facade()
    {

    }

    public IEnumerable<string> GetUserAuthorities(in int userId)
    {
        var user = _userRepository.GetById(userId);
        var roles = _roleRepository.GetRoles(userId);
        var authorities = _authorityRepository.GetAuthorities(roles);
        return authorities;

    }
}