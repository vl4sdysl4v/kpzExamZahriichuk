using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZExamZahriichuk.Models.Dtos;

public class CreateSicknessDto
{
    public string Description { get; set; }
    public string Date { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }

}
