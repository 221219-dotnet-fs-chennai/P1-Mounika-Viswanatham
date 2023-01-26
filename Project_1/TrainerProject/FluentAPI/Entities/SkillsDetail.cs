using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Entities;

[Table("Skills_Details")]
public partial class SkillsDetail
{
    [Key]
    [Column("user_id")]
    [StringLength(200)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Skill1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Skill2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Skill3 { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("SkillsDetail")]
    public virtual TrainerDetail User { get; set; } = null!;
}
