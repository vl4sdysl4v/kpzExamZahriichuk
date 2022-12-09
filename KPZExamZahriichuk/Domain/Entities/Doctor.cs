
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Doctor: IBaseEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual ICollection<Patient> Patients { get; set; }
    public virtual ICollection<SicknessHistory> SicknessHistories { get; set; }
}
