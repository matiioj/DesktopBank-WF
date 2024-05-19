using System;
using System.Collections.Generic;

namespace DesktopBank.BusinessObjects.Generated.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public Guid AccountNumber { get; set; }

    public int UserId { get; set; }

    public decimal AccountBalance { get; set; }

    public int AccountCurrency { get; set; }

    public long AccountCbu { get; set; }

    public string AccountAlias { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Currency AccountCurrencyNavigation { get; set; } = null!;

    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();

    public virtual ICollection<Operation> OperationDestinationAccounts { get; set; } = new List<Operation>();

    public virtual ICollection<Operation> OperationSourceAccounts { get; set; } = new List<Operation>();

    public virtual User User { get; set; } = null!;
}
