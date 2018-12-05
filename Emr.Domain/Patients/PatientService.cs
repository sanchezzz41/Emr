using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Patients.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.Patients
{
    public class PatientService : IPatientService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public PatientService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(PatientInfo patient)
        {
            var result = _mapper.Map<Patient>(patient);
            _context.Patients.Add(result);
            await _context.SaveChangesAsync();
            return result.PatientGuid;
        }

        /// <inheritdoc />
        public async Task Edit(PatientInfo patient, Guid patientGuid)
        {
            var result = await _context.Patients.SingleAsync(x => x.PatientGuid == patientGuid);
            result= _mapper.Map(patient, result);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task<List<PatientModel>> Get()
        {
            return await _context.Patients
                .AsNoTracking()
                .ProjectTo<PatientModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task Delete(Guid patientGuid)
        {
            var result = await _context.Patients.SingleAsync(x => x.PatientGuid == patientGuid);
            _context.Patients.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}
