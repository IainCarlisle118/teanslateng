using System;
using System.Linq;
using System.Linq.Expressions;
using Data.Entities;

namespace Data.Interfaces
{
    public interface ILanguagesRepository
    {
        void Insert(Languages languagesToAdd);
        Task Update(Languages entity);
        // Task<Languages> GetById(Guid id);
    }
}