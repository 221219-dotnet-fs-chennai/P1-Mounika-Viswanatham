using System;
using System.Collections.Generic;

namespace FluentAPI.Entities;

public partial class TrainerDetail
{
    public string UserId { get; set; } = null!;

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? EmailId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Location { get; set; }

    public string? Password { get; set; }

    public virtual CompanyDetail? CompanyDetail { get; set; }

    public virtual EducationDetail? EducationDetail { get; set; }

    public virtual SkillsDetail? SkillsDetail { get; set; }
}
