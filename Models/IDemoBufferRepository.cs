namespace Simple_OMR.Models
{
    public interface IDemoBufferRepository
    {
        DemoBufferModel GetPerson(int id);
        IEnumerable<DemoBufferModel> GetAll();
        IEnumerable<DemoBufferModel> All();

        DemoBufferModel Add(DemoBufferModel person);
        DemoBufferModel Delete(int id);
        DemoBufferModel Update(DemoBufferModel personInfoChanges);

    }
}
