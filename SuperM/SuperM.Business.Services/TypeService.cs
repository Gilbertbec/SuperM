namespace SuperM.Business.Services
{
    using SuperM.Data.Repositories;

    public class TypeService
    {
        private SuperMContext _context;

        public TypeService()
        {
            _context = new SuperMContext();
        }

        public void GetAllTypes()
        {
        }
    }
}
