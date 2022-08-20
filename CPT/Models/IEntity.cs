using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT.Models
{
    public interface IEntity: ISerializable
    {
        string GetId();
    }
}
