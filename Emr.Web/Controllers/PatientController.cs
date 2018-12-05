using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emr.Domain.Patients;
using Emr.Domain.Patients.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Emr.Web.Controllers
{
    [Route("api/patients")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        /// <summary>
        /// Создание пациента
        /// </summary>
        /// <param name="infoModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> Create(PatientInfo infoModel)
        {
            return await _patientService.Create(infoModel);
        }

        /// <summary>
        /// Создание пациента
        /// </summary>
        /// <param name="patientGuid"></param>
        /// <returns></returns>
        [HttpDelete("{patientGuid}")]
        public async Task Delete(Guid patientGuid)
        {
            await _patientService.Delete(patientGuid);
        }

        /// <summary>
        /// Создание пациента
        /// </summary>
        /// <param name="infoModel"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<PatientModel>> Get(string search)
        {
            return await _patientService.Get();
        }

    }
}
