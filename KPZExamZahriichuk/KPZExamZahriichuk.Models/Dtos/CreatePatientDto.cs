﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZExamZahriichuk.Models.Dtos;

public class CreatePatientDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
    public int DoctorId { get; set; }
}