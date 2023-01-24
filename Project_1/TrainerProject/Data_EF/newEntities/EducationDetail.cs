using System;
using System.Collections.Generic;

namespace Data_EF.newEntities;

public partial class EducationDetail
{
    public string UserId { get; set; } = null!;

    public string? InstitutionName { get; set; }

    public string? Degree { get; set; }

    public string? Specialization { get; set; }

    public string? PassingYear { get; set; }

    public virtual TrainerDetail User { get; set; } = null!;
}
