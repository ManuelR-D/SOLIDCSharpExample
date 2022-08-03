using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.DependencyInversionPrinciple
{
    internal class PersonAPI : CrudAPI<IPersonDTO>
    {

        //Since the API doesnt work with a concrete DAO, any arbitrary DAO could be provided (i.e. PersonRedisDao, PersonOracleDao, MockDAO; etc)
        //as long as it comply with the generic interface with the IPersonDTO as type.
        public PersonAPI(ICrud<IPersonDTO> entityDao): base(entityDao)
        {
            if(entityDao == null)
            {
                this.entityDao = this.getDefaultDao();
            }
        }
        private ICrud<IPersonDTO> getDefaultDao()
        {
            return new PersonDAOMySQL("my connection string");
        }

        public override bool deleteById(int id)
        {
            return this.entityDao.deleteById(id);
        }

        public override IPersonDTO getById(int id)
        {
            return this.entityDao.getById(id);
        }

        public override IPersonDTO save(IPersonDTO entity)
        {
            return this.entityDao.save(entity);
        }

        public override bool update(IPersonDTO entity)
        {
            return this.update(entity);
        }
    }
}
