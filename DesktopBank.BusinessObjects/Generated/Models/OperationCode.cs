using System;
using System.Collections.Generic;

namespace DesktopBank.BusinessObjects.Generated.Models;

public partial class OperationCode
{
    public byte OperationCodeId { get; set; }

    public byte OperationCodeNumber { get; set; }

    public string OperationCodeDescription { get; set; } = null!;

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();
}
