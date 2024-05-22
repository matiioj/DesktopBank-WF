using DesktopBank.DAL;
using DesktopBank.Services;
using System.Runtime.InteropServices;

public class CreateBankUserEntitiesService
{
    private readonly CreateClientService _clientService;
    private readonly CreateUserService _userService;
    private readonly CreateAccountService _accountService;
    private readonly UnitOfWork _unitOfWork;
    private readonly CreateCardService _createCardService;

    public CreateBankUserEntitiesService(CreateClientService clientService, CreateUserService userService, CreateAccountService accountService, CreateCardService createCardService, UnitOfWork unitOfWork)
    {
        _clientService = clientService;
        _userService = userService;
        _accountService = accountService;
        _unitOfWork = unitOfWork;
        _createCardService = createCardService;
    }

    public async Task CreateBankUserEntitiesAsync(string clientName, string clientSurname, long clientCuil, string clientEmail, string username, string password, int currencyId)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                var client = await _clientService.CreateClientAsync(clientName, clientSurname, clientCuil, clientEmail);
                var user = await _userService.CreateUserAsync(client.ClientId, username, password);
                var account = await _accountService.CreateAccountAsync(user.UserId, currencyId);
                var card = await _createCardService.CreateCardAsync(account.AccountId, account.AccountCurrency);

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