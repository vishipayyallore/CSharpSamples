using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Samples.IDataModels
{

    public interface IEntity
    {
        #region Properties
        string Id { get; set; }
        #endregion
    }

}
