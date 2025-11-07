using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{
    public class LanguagesRespository : ILanguagesRepository
    {
        private readonly DbContext dbContext;
        private readonly IConfiguration _config;

        public LanguagesRespository(DbContext dbContext, IConfiguration config)
        {
            this.dbContext = dbContext;
            this._config = config;
        }

        public virtual void Insert(Languages languagesToAdd)
        {
            this.dbContext.Add<Languages>(languagesToAdd);
            this.dbContext.SaveChanges();
        }

        public async virtual Task Update(Languages languagesToUpdate)
        {
            this.dbContext.Update(languagesToUpdate);
            await this.dbContext.SaveChangesAsync();
        }

        public async virtual Task<Languages> GetById(Guid id)
        {
            return await this.dbContext.FindAsync<Languages>(id);
        }
    }
}
