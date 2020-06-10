using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Chaufferie.ChargesMS.Domain.Commands;
using Chaufferie.ChargesMS.Domain.Handlers;
using Chaufferie.ChargesMS.Domain.Interfaces;
using Chaufferie.ChargesMS.Domain.Models;
using Chaufferie.ChargesMS.Domain.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chaufferie.ChargesMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RéunionController : ControllerBase
    {
        private readonly IGenericRepository<Réunion> repository;

        #region Constructor
        public RéunionController(IGenericRepository<Réunion> repository)
        {
            this.repository = repository;

        }
        #endregion

        #region Read Function
        // GET: api/Réunion
        [HttpGet("GetListRéunion")]
        public async Task<IEnumerable<Réunion>> GetListRéunion() =>
             await (new GetListGenericHandler<Réunion>(repository)).Handle(new GetListGenericQuery<Réunion>(condition: null, includes: null), new CancellationToken());

        // GET: api/Réunion/5
        [HttpGet("GetRéunion")]
        public async Task<Réunion> GetRéunion(Guid id) =>
            await (new GetGenericHandler<Réunion>(repository)).Handle(new GetGenericQuery<Réunion>(condition: x => x.RéunionId.Equals(id), null), new CancellationToken());
        #endregion

        #region Add Function
        // POST: api/Réunion
        [HttpPost("PostRéunion")]
        public async Task<Réunion> PostRéunion([FromBody] Réunion Réunion) =>
            await (new AddGenericHandler<Réunion>(repository)).Handle(new AddGenericCommand<Réunion>(Réunion), new CancellationToken());
        #endregion

        #region Update Funtion
        // PUT: api/Réunion/5
        [HttpPut("PutRéunion")]
        public async Task<Réunion> PutRéunion([FromBody] Réunion Réunion) =>
           await (new PutGenericHandler<Réunion>(repository)).Handle(new PutGenericCommand<Réunion>(Réunion), new CancellationToken());
        #endregion

        #region Remove Function
        // DELETE: api/Réunion/5
        [HttpDelete("DeleteRéunion")]
        public async Task<Réunion> DeleteRéunion(Guid id) =>
           await (new RemoveGenericHandler<Réunion>(repository)).Handle(new RemoveGenericCommand<Réunion>(id), new CancellationToken());
        #endregion
    }
}