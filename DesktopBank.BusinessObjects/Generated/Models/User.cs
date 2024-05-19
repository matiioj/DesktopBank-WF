using System;
using System.Collections.Generic;

namespace DesktopBank.BusinessObjects.Generated.Models;

public partial class User
{
    public int UserId { get; set; }

    public int ClientId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Client Client { get; set; } = null!;
}
