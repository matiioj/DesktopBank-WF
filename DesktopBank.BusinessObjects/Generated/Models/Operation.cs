using System;
using System.Collections.Generic;

namespace DesktopBank.BusinessObjects.Generated.Models;

public partial class Operation
{
    public int OperationId { get; set; }

    public int SourceAccountId { get; set; }

    public int DestinationAccountId { get; set; }

    public decimal OperationAmount { get; set; }

    public string OperationNote { get; set; } = null!;

    public DateTime OperationDate { get; set; }

    public byte OperationCodeId { get; set; }

    public virtual Account DestinationAccount { get; set; } = null!;

    public virtual OperationCode OperationCode { get; set; } = null!;

    public virtual Account SourceAccount { get; set; } = null!;
}
