﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ChickenAPI.Data.AccessLayer.Repository;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.Data.TransferObjects.Map;

namespace ChickenAPI.Data.AccessLayer
{
    /// <inheritdoc />
    public interface IPortalService : IMappedRepository<PortalDto>
    {
        Task<IEnumerable<PortalDto>> GetByMapIdAsync(short mapId);
    }
}