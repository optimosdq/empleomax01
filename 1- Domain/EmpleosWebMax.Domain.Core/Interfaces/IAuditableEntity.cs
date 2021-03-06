using System;
using System.Collections.Generic;
using System.Text;

namespace EmpleosWebMax.Domain.Core.Interfaces
{
    public interface IAuditableEntity
    {
        string CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        string LastModifiedBy { get; set; }
        DateTime LastModifiedAt { get; set; }
    }
}
