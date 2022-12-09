﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class SicknessHistory: IBaseEntity
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int PatientId { get; set; }
    public virtual Patient Patient { get; set; }
    public int DoctorId { get; set; }
    public virtual Doctor Doctor { get; set; }


}
