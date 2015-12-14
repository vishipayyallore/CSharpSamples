using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using CSharp.Samples.IDataModels;

namespace CSharp.Samples.IDataRepositories
{

    public interface IRepository<T> where T : IEntity
    {
        #region Properties
        Task<List<T>> List { get; }
        #endregion

        #region Methods
        Task<HttpStatusCode> Add(T enitity);

        IEnumerable<T> GetItems(Func<T, bool> action);

        Task<T> FindById(string id);

        Task<HttpStatusCode> Update(T entity);
        #endregion
    }

}
