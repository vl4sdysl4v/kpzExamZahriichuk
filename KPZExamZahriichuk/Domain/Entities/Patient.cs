using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Patient : IBaseEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public int DoctorId { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual ICollection<SicknessHistory> SicknessHistories { get; set; }
}
