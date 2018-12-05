using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emr.Domain.Patients.Models;

namespace Emr.Domain.Patients
{
    public interface IPatientService
    {
        Task<Guid> Create(PatientInfo patient);
        Task Edit(PatientInfo patient, Guid patientGuid);
        Task<List<PatientModel>> Get();
        Task Delete(Guid patientGuid);
    }
}
