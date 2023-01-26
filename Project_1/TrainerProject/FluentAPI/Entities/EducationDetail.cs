using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Entities;

[Table("Education_Details")]
public partial class EducationDetail
{
    [Key]
    [Column("user_id")]
    [StringLength(200)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [Column("institutionName")]
    [StringLength(20)]
    [Unicode(false)]
    public string? InstitutionName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Degree { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Specialization { get; set; }

    [Unicode(false)]
    public string? PassingYear { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("EducationDetail")]
    public virtual TrainerDetail User { get; set; } = null!;
}
