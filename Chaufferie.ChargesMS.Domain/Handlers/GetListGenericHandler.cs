using Chaufferie.ChargesMS.Domain.Interfaces;
using Chaufferie.ChargesMS.Domain.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chaufferie.ChargesMS.Domain.Handlers
{
    public class GetListGenericHandler<TEntity> : IRequestHandler<GetListGenericQuery<TEntity>, IEnumerable<TEntity>> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> Repository;
        public GetListGenericHandler(IGenericRepository<TEntity> Repository)
        {
            this.Repository = Repository;
        }

        public Task<IEnumerable<TEntity>> Handle(GetListGenericQuery<TEntity> request, CancellationToken cancellationToken)
        {

            var result = Repository.GetList(request.Condition, request.Includes);
            return Task.FromResult(result);
        }


    }
}
