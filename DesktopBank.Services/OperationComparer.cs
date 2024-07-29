using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopBank.BusinessObjects.Generated.Models;

namespace DesktopBank.Services
{
    public class OperationComparer : IEqualityComparer<Operation>
    {
        public bool Equals(Operation x, Operation y)
        {
            // Compara las operaciones basadas en su ID (o cualquier otro identificador único)
            return x.OperationId == y.OperationId;
        }

        public int GetHashCode(Operation obj)
        {
            // Devuelve el hash del ID de la operación
            return obj.OperationId.GetHashCode();
        }
    }
}
