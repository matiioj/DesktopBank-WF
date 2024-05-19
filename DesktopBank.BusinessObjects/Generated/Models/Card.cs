using System;
using System.Collections.Generic;

namespace DesktopBank.BusinessObjects.Generated.Models;

public partial class Card
{
    public int CardId { get; set; }

    public string CardNumber { get; set; } = null!;

    public int CardAccountId { get; set; }

    public DateTime CardExpirationDate { get; set; }

    public byte CardCvv { get; set; }

    public byte TypeOfCard { get; set; }

    public byte StatusOfCard { get; set; }

    public byte CardCurrency { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Account CardAccount { get; set; } = null!;
}
