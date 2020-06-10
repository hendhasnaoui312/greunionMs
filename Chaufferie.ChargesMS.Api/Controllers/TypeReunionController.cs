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
    public class TypeReunionController : ControllerBase
    {
        private readonly IGenericRepository<TypeReunion> repository;

        #region Constructor
        public TypeReunionController(IGenericRepository<TypeReunion> repository)
        {
            this.repository = repository;

        }
        #endregion

        #region Read Function
        // GET: api/TypeReunion
        [HttpGet("GetListTypeReunion")]
        public async Task<IEnumerable<TypeReunion>> GetListTypeReunion() =>
             await (new GetListGenericHandler<TypeReunion>(repository)).Handle(new GetListGenericQuery<TypeReunion>(condition: null, includes: null), new CancellationToken());

        // GET: api/TypeReunion/5
        [HttpGet("GetTypeReunion")]
        public async Task<TypeReunion> GetTypeReunion(Guid id) =>
            await (new GetGenericHandler<TypeReunion>(repository)).Handle(new GetGenericQuery<TypeReunion>(condition: x => x.TypeReunionId.Equals(id), null), new CancellationToken());
        #endregion

        #region Add Function
        // POST: api/TypeReunion
        [HttpPost("PostTypeReunion")]
        public async Task<TypeReunion> PostTypeReunion([FromBody] TypeReunion TypeReunion) =>
            await (new AddGenericHandler<TypeReunion>(repository)).Handle(new AddGenericCommand<TypeReunion>(TypeReunion), new CancellationToken());
        #endregion

        #region Update Funtion
        // PUT: api/TypeReunion/5
        [HttpPut("PutTypeReunion")]
        public async Task<TypeReunion> PutTypeReunion([FromBody] TypeReunion TypeReunion) =>
           await (new PutGenericHandler<TypeReunion>(repository)).Handle(new PutGenericCommand<TypeReunion>(TypeReunion), new CancellationToken());
        #endregion

        #region Remove Function
        // DELETE: api/TypeReunion/5
        [HttpDelete("DeleteTypeReunion")]
        public async Task<TypeReunion> DeleteTypeReunion(Guid id) =>
           await (new RemoveGenericHandler<TypeReunion>(repository)).Handle(new RemoveGenericCommand<TypeReunion>(id), new CancellationToken());
        #endregion
    }
}
