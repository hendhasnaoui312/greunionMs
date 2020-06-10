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
//using Chaufferie.ChargesMS.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Chaufferie.ChargesMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeReunion_sous_serviceController : ControllerBase
    {
        private readonly IGenericRepository<TypeReunion_sous_service> repository;

        #region Constructor
        public TypeReunion_sous_serviceController(IGenericRepository<TypeReunion_sous_service> repository)
        {
            this.repository = repository;

        }
        #endregion

        #region Read Function
        // GET: api/TypeReunion_sous_service
        [HttpGet("GetListTypeReunion_sous_service")]
        public async Task<IEnumerable<TypeReunion_sous_service>> GetListTypeReunion_sous_service() =>
             await (new GetListGenericHandler<TypeReunion_sous_service>(repository)).Handle(new GetListGenericQuery<TypeReunion_sous_service>(condition: null, includes: null), new CancellationToken());

        // GET: api/TypeReunion_sous_service/5
        [HttpGet("GetTypeReunion_sous_service")]
        public async Task<TypeReunion_sous_service> GetTypeReunion_sous_service(Guid id) =>
            await (new GetGenericHandler<TypeReunion_sous_service>(repository)).Handle(new GetGenericQuery<TypeReunion_sous_service>(condition: x => x.TypeReunion_sous_serviceId.Equals(id), null), new CancellationToken());
        #endregion

        #region Add Function
        // POST: api/TypeReunion_sous_service
        [HttpPost("PostTypeReunion_sous_service")]
        public async Task<TypeReunion_sous_service> PostTypeReunion_sous_service([FromBody] TypeReunion_sous_service TypeReunion_sous_service) =>
            await (new AddGenericHandler<TypeReunion_sous_service>(repository)).Handle(new AddGenericCommand<TypeReunion_sous_service>(TypeReunion_sous_service), new CancellationToken());
        #endregion

        #region Update Funtion
        // PUT: api/TypeReunion_sous_service/5
        [HttpPut("PutTypeReunion_sous_service")]
        public async Task<TypeReunion_sous_service> PutTypeReunion_sous_service([FromBody] TypeReunion_sous_service TypeReunion_sous_service) =>
           await (new PutGenericHandler<TypeReunion_sous_service>(repository)).Handle(new PutGenericCommand<TypeReunion_sous_service>(TypeReunion_sous_service), new CancellationToken());
        #endregion

        #region Remove Function
        // DELETE: api/TypeReunion_sous_service/5
        [HttpDelete("DeleteTypeReunion_sous_service")]
        public async Task<TypeReunion_sous_service> DeleteTypeReunion_sous_service(Guid id) =>
           await (new RemoveGenericHandler<TypeReunion_sous_service>(repository)).Handle(new RemoveGenericCommand<TypeReunion_sous_service>(id), new CancellationToken());
        #endregion
    }
}