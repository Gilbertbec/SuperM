namespace SuperM.Business.Services
{
    using SuperM.Data.Repositories;

    public class TypeService
    {
        private SuperMContext Context;

        public TypeService()
        {
            Context = new SuperMContext();
        }

        public void GetAllTypes()
        {
        }
    }
}
