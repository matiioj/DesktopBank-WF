using System;
using System.Collections.Generic;

namespace DesktopBank.BusinessObjects.Generated.Models;

public partial class Currency
{
    public int CurrencyId { get; set; }

    public string CurrencySign { get; set; } = null!;

    public string CurrencyName { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
