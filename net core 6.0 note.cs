//*DemoBuffer
//49 / 10.11s
//Microsoft.EntityFrameworkCore.Tools
//builder.Services.AddScoped<IDemoBufferRepository, SQLDemoBufferRepository>();




//# repository pattern vs ssms procedure


//$$$$$ Image tag helper like token for detecting image change & using cache
//{
//        < img class= "card-img-top" style = "width:300px; height:300px;" src = "~/media/noimage.svg.png" asp - append - version = "true"
//}

//$$$$$
//// In Model/(class)AppDbContext.cs :
//inherite model from DbContext
//install nuget pacakage > entityframeworkcore.sqlserver (automatically installs Microsoft.EntityFrameworkCore)
//< code >
//                    using Microsoft.EntityFrameworkCore;

//                    namespace Simple_OMR.Models
//{
//    public class AppDbContext : DbContext
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//        {

//        }
//        public DbSet<DemoBufferModel> demoBufferModels { get; set; }
//    }
//}
//</ code >
//// In appsettings.json : Added the below connection string
//< code >
//                    ,
//                      "ConnectionStrings": {
//    "DBConnection": "Data Source=Avenger;Initial Catalog=Simple_OMR;Integrated Security=True;"
//                      }
//</ code >
//// In Program.cs: Added the database connection string as service
//< code >
//                    builder.Services.AddDbContextPool<AppDbContext>(options =>
//                    {
//                        options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
//                    });
//</ code >

//$$$$$
//// In Model/(class)DemoBufferModel.cs :
//< code >
//                    namespace Simple_OMR.Models
//{
//    public class DemoBufferModel
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Description { get; set; }
//        public string Email { get; set; }
//    }
//}
//</ code >
//$$$$$
//// In Model/(class)IDemoBufferRepository.cs :
//< code >
//                    namespace Simple_OMR.Models
//{
//    public interface IDemoBufferRepository
//    {
//        DemoBufferModel GetPerson(int id);
//        IEnumerable<DemoBufferModel> GetAll();
//        DemoBufferModel Add(DemoBufferModel person);
//        DemoBufferModel Delete(int id);
//        DemoBufferModel Update(DemoBufferModel personInfoChanges);

//    }
//}
//</ code >
//// In Model/(class)SQLDemoBufferRepository.cs :
//< code >
//                    namespace Simple_OMR.Models
//{
//    public class SQLDemoBufferRepository : IDemoBufferRepository
//    {
//        private readonly AppDbContext context;

//        public SQLDemoBufferRepository(AppDbContext context)
//        {
//            this.context = context;
//        }

//        public DemoBufferModel Add(DemoBufferModel person)
//        {
//            context.demoBufferModels.Add(person);
//            context.SaveChanges();
//            return person;
//        }

//        public DemoBufferModel Delete(int id)
//        {
//            DemoBufferModel person = context.demoBufferModels.Find(id);
//            if (person != null)
//            {
//                context.demoBufferModels.Remove(person);
//                context.SaveChanges();
//            }
//            return person;
//        }

//        public IEnumerable<DemoBufferModel> GetAll()
//        {
//            return context.demoBufferModels;
//        }

//        public DemoBufferModel GetPerson(int id)
//        {
//            return context.demoBufferModels.Find(id);
//        }

//        public DemoBufferModel Update(DemoBufferModel personInfoChanges)
//        {
//            var person = context.demoBufferModels.Attach(personInfoChanges);
//            person.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//            context.SaveChanges();
//            return personInfoChanges;
//        }
//    }
//}
//</ code >


//< code >
//</ code >