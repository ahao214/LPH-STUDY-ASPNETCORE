using static System.Console;


/*
设计模式：外观模式
目的：隐藏复杂的实现
*/





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