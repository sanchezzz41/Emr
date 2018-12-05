using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Drags.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.Drags
{
    //Наследуем от IDragService
    public class DragService : IDragService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public DragService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(DragInfo model)
        {
            var result = _mapper.Map<Drag>(model);
            _context.Drags.Add(result);
            await _context.SaveChangesAsync();
            return result.DragGuid;
        }

        /// <inheritdoc />
        public async Task<List<DragModel>> Get()
        {
            return await _context.Drags
                .ProjectTo<DragModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task Delete(Guid dragGuid)
        {
            var result = await _context.Drags.SingleAsync(x => x.DragGuid == dragGuid);
            _context.Drags.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}
