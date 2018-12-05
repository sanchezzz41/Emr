using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.Drags.Models;

namespace Emr.Domain.Drags
{
    //Потом добавить в Sturtup (services.AddScoped<>)
    public interface IDragService
    {
        Task<Guid> Create(DragInfo model);

        Task<List<DragModel>> Get();

        Task Delete(Guid dragGuid);
    }
}
