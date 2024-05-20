using DesktopBank.DAL;
using DesktopBank.Services;

public class CreateClientUserAndAccountService
{
    private readonly CreateClientService _clientService;
    private readonly CreateUserService _userService;
    private readonly CreateAccountService _accountService;
    private readonly UnitOfWork _unitOfWork;

    public CreateClientUserAndAccountService(CreateClientService clientService, CreateUserService userService, CreateAccountService accountService, UnitOfWork unitOfWork)
    {
        _clientService = clientService;
        _userService = userService;
        _accountService = accountService;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateClientUserAndAccountAsync(string clientName, string clientSurname, long clientCuil, string clientEmail, string username, string password, int currencyId)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                var client = await _clientService.CreateClientAsync(clientName, clientSurname, clientCuil, clientEmail);
                var user = await _userService.CreateUserAsync(client.ClientId, username, password);
                var account = await _accountService.CreateAccountAsync(user.UserId, currencyId);

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}