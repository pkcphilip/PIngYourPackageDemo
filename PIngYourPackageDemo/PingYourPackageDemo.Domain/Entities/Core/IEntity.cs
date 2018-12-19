using System;

namespace PingYourPackageDemo.Domain.Entities.Core
{
    public interface IEntity
    {
        Guid Key { get; set; }
    }
}
