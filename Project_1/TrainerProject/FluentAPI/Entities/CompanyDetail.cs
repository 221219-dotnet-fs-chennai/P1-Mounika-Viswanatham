using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Entities;

[Table("Company_Detail")]
public partial class CompanyDetail
{
    [Key]
    [Column("user_id")]
    [StringLength(200)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Experience { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CompanyDetail")]
    public virtual TrainerDetail User { get; set; } = null!;
}
