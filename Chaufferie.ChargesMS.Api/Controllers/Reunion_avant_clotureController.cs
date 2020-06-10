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
    public class Reunion_avant_clotureController : ControllerBase
    {
        private readonly IGenericRepository<Reunion_avant_cloture> repository;

        #region Constructor
        public Reunion_avant_clotureController(IGenericRepository<Reunion_avant_cloture> repository)
        {
            this.repository = repository;

        }
        #endregion

        #region Read Function
        // GET: api/Reunion_avant_cloture
        [HttpGet("GetListReunion_avant_cloture")]
        public async Task<IEnumerable<Reunion_avant_cloture>> GetListReunion_avant_cloture() =>
             await (new GetListGenericHandler<Reunion_avant_cloture>(repository)).Handle(new GetListGenericQuery<Reunion_avant_cloture>(condition: null, includes: null), new CancellationToken());

        // GET: api/Reunion_avant_cloture/5
        [HttpGet("GetReunion_avant_cloture")]
        public async Task<Reunion_avant_cloture> GetReunion_avant_cloture(Guid id) =>
            await (new GetGenericHandler<Reunion_avant_cloture>(repository)).Handle(new GetGenericQuery<Reunion_avant_cloture>(condition: x => x.Reunion_avant_clotureId.Equals(id), null), new CancellationToken());
        #endregion

        #region Add Function
        // POST: api/Reunion_avant_cloture
        [HttpPost("PostReunion_avant_cloture")]
        public async Task<Reunion_avant_cloture> PostReunion_avant_cloture([FromBody] Reunion_avant_cloture Reunion_avant_cloture) =>
            await (new AddGenericHandler<Reunion_avant_cloture>(repository)).Handle(new AddGenericCommand<Reunion_avant_cloture>(Reunion_avant_cloture), new CancellationToken());
        #endregion

        #region Update Funtion
        // PUT: api/Reunion_avant_cloture/5
        [HttpPut("PutReunion_avant_cloture")]
        public async Task<Reunion_avant_cloture> PutReunion_avant_cloture([FromBody] Reunion_avant_cloture Reunion_avant_cloture) =>
           await (new PutGenericHandler<Reunion_avant_cloture>(repository)).Handle(new PutGenericCommand<Reunion_avant_cloture>(Reunion_avant_cloture), new CancellationToken());
        #endregion

        #region Remove Function
        // DELETE: api/Reunion_avant_cloture/5
        [HttpDelete("DeleteReunion_avant_cloture")]
        public async Task<Reunion_avant_cloture> DeleteReunion_avant_cloture(Guid id) =>
           await (new RemoveGenericHandler<Reunion_avant_cloture>(repository)).Handle(new RemoveGenericCommand<Reunion_avant_cloture>(id), new CancellationToken());
        #endregion
    }
}