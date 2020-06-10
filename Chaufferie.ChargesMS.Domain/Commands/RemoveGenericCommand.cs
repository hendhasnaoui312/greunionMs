using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chaufferie.ChargesMS.Domain.Commands
{
    public class RemoveGenericCommand<TEntity> : IRequest<TEntity> where TEntity : class
    {
        public RemoveGenericCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; }
    }
}
