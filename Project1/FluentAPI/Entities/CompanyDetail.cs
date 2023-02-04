using System;
using System.Collections.Generic;

namespace FluentAPI.Entities;

public partial class CompanyDetail
{
    public string UserId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? Experience { get; set; }

    public virtual TrainerDetail User { get; set; } = null!;
}
