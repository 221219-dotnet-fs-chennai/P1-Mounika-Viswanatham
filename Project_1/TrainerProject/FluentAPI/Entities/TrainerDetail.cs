using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Entities;

public partial class TrainerDetail
{
    [Key]
    [Column("user_id")]
    [StringLength(200)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [Unicode(false)]
    public string? Name { get; set; }

    public int? Age { get; set; }

    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("EmailID")]
    [Unicode(false)]
    public string? EmailId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Location { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Password { get; set; }

    [InverseProperty("User")]
    public virtual CompanyDetail? CompanyDetail { get; set; }

    [InverseProperty("User")]
    public virtual EducationDetail? EducationDetail { get; set; }

    [InverseProperty("User")]
    public virtual SkillsDetail? SkillsDetail { get; set; }
}
