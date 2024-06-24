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

    public async Task CreateBankUserEntitiesAsync(string clientName, string clientSurname, long clientCuil, string clientEmail, string username, string password, int primaryCurrencyId, int secondaryCurrencyId)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                var client = await _clientService.CreateClientAsync(clientName, clientSurname, clientCuil, clientEmail);
                var user = await _userService.CreateUserAsync(client.ClientId, username, password);

                // primera cuenta con pesos
                var account1 = await _accountService.CreateAccountAsync(user.UserId, primaryCurrencyId);

                // segunda cuenta con moneda adicional (dolar)
                var account2 = await _accountService.CreateAccountAsync(user.UserId, secondaryCurrencyId);

                var card1 = await _createCardService.CreateCardAsync(account1.AccountId, account1.AccountCurrency);
                var card2 = await _createCardService.CreateCardAsync(account2.AccountId, account2.AccountCurrency);

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