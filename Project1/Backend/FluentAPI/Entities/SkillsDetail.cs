using System;
using System.Collections.Generic;

namespace FluentAPI.Entities;

public partial class SkillsDetail
{
    public string UserId { get; set; } = null!;

    public string? Skill1 { get; set; }

    public string? Skill2 { get; set; }

    public string? Skill3 { get; set; }

    public virtual TrainerDetail User { get; set; } = null!;
}
