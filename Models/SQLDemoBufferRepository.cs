namespace Simple_OMR.Models
{
    public class SQLDemoBufferRepository : IDemoBufferRepository
    {
        private readonly AppDbContext context;

        public SQLDemoBufferRepository(AppDbContext context)
        {
            this.context = context;
        }

        public DemoBufferModel Add(DemoBufferModel person)
        {
            context.demoBufferModels.Add(person);
            context.SaveChanges();
            return person;
        }

        public IEnumerable<DemoBufferModel> All()
        {
            return context.demoBufferModels.ToList();
        }

        public DemoBufferModel Delete(int id)
        {
            DemoBufferModel person = context.demoBufferModels.Find(id);
            if(person != null)
            {
                context.demoBufferModels.Remove(person);
                context.SaveChanges();
            }
            return person;
        }

        public IEnumerable<DemoBufferModel> GetAll()
        {
            return context.demoBufferModels;
        }

        public DemoBufferModel GetPerson(int id)
        {
            return context.demoBufferModels.Find(id);
        }

        public DemoBufferModel Update(DemoBufferModel personInfoChanges)
        {
            var person = context.demoBufferModels.Attach(personInfoChanges);
            person.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return personInfoChanges;
        }
    }
}
