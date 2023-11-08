using HospitalManagement.Model;
using HospitalManagement.Shared.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.Infrastructure.Persistence.Configuration;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.ToTable("Doctors");
        builder.HasKey(x => x.Id);
        builder.HasData(new
        {
            Id = 1,
            DoctorId =123,
            DoctorName = "Abul Kalam",
            DoctorSpecialization = "Surgeon",
            DoctorQualifiction = "Phd",
            Created =  DateTimeOffset.Now,
            CreatedBy = "Shahid",
            Status = EntityStatus.Created,


        });
    }

}
