using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointement.Models;

[Index("StatusName", Name = "UQ__Appointm__05E7698A3F5A0383", IsUnique = true)]
public partial class AppointmentStatus
{
    [Key]
    [Column("AppointmentStatusID")]
    public int AppointmentStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StatusName { get; set; } = null!;

    [InverseProperty("AppointmentStatus")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
