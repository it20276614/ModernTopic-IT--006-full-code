using System.Reflection;

namespace sliit.mtit.lecturer.services
{
    public interface Interfacelecturer
    {
        List<models.lecturer> Getlecturer();
        models.lecturer? Getlecturer(int id);
        models.lecturer? Addlecturer(models.lecturer lecturer);
        models.lecturer? Updatelecturer(models.lecturer lecturer);
        bool? Deletelecturer(int id);
    }
}
