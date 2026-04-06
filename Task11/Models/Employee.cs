using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Task11.Models;

[Keyless]
public partial class Employee
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public int? Salary { get; set; }
}
