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
    public class Reunion_aprés_cloture : ControllerBase
    {
        private readonly IGenericRepository<Reunion_aprés_cloture> repository;

        public object Reunion_aprés_clotureId { get; private set; }

        #region Constructor
        public Reunion_aprés_cloture(IGenericRepository<Reunion_aprés_cloture> repository)
        {
            this.repository = repository;

        }
        #endregion

        #region Read Function
        // GET: api/Reunion_aprés_cloture
        [HttpGet("GetListReunion_aprés_cloture")]
        public async Task<IEnumerable<Reunion_aprés_cloture>> GetListReunion_aprés_cloture() =>
             await (new GetListGenericHandler<Reunion_aprés_cloture>(repository)).Handle(new GetListGenericQuery<Reunion_aprés_cloture>(condition: null, includes: null), new CancellationToken());

        // GET: api/Reunion_aprés_cloture/5
        [HttpGet("GetReunion_aprés_cloture")]
        public async Task<Reunion_aprés_cloture> GetReunion_aprés_cloture(Guid id) =>
            await (new GetGenericHandler<Reunion_aprés_cloture>(repository)).Handle(new GetGenericQuery<Reunion_aprés_cloture>(condition: x => x.Reunion_aprés_clotureId.Equals(id), null), new CancellationToken());
        #endregion

        #region Add Function
        // POST: api/Reunion_aprés_cloture
        [HttpPost("PostReunion_aprés_cloture")]
        public async Task<Reunion_aprés_cloture> PostReunion_aprés_cloture([FromBody] Reunion_aprés_cloture Reunion_aprés_cloture) =>
            await (new AddGenericHandler<Reunion_aprés_cloture>(repository)).Handle(new AddGenericCommand<Reunion_aprés_cloture>(Reunion_aprés_cloture), new CancellationToken());
        #endregion

        #region Update Funtion
        // PUT: api/Reunion_aprés_cloture/5
        [HttpPut("PutReunion_aprés_cloture")]
        public async Task<Reunion_aprés_cloture> PutReunion_aprés_cloture([FromBody] Reunion_aprés_cloture Reunion_aprés_cloture) =>
           await (new PutGenericHandler<Reunion_aprés_cloture>(repository)).Handle(new PutGenericCommand<Reunion_aprés_cloture>(Reunion_aprés_cloture), new CancellationToken());
        #endregion

        #region Remove Function
        // DELETE: api/Reunion_aprés_cloture/5
        [HttpDelete("DeleteReunion_aprés_cloture")]
        public async Task<Reunion_aprés_cloture> DeleteReunion_aprés_cloture(Guid id) =>
           await (new RemoveGenericHandler<Reunion_aprés_cloture>(repository)).Handle(new RemoveGenericCommand<Reunion_aprés_cloture>(id), new CancellationToken());
        #endregion
    }
}