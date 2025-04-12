using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointement.Models;

public partial class MedicalRecord
{
    [Key]
    [Column("RecordID")]
    public int RecordId { get; set; }

    [Column("PatientID")]
    public int PatientId { get; set; }

    [Column("AppointmentID")]
    public int? AppointmentId { get; set; }

    public DateOnly VisitDate { get; set; }

    public string? Symptoms { get; set; }

    public string? Diagnosis { get; set; }

    public string? Treatment { get; set; }

    public string? Notes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [ForeignKey("AppointmentId")]
    [InverseProperty("MedicalRecords")]
    public virtual Appointment? Appointment { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("MedicalRecords")]
    public virtual Patient Patient { get; set; } = null!;
}
