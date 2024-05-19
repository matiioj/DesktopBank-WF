using System;
using System.Collections.Generic;

namespace DesktopBank.BusinessObjects.Generated.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string ClientSurname { get; set; } = null!;

    public long ClientCuil { get; set; }

    public string ClientEmail { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
