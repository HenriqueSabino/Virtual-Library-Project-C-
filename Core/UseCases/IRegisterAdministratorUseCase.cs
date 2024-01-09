namespace VirtualLibrary.Core.UseCases
{
    public interface IRegisterAdministratorUseCase
    {
        void RegisterAdministrator(string username, string password, string email);
    }
}