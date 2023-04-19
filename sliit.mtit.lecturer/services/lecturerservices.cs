using sliit.mtit.lecturer.data;
using sliit.mtit.lecturer.models;
using System.Reflection;


namespace sliit.mtit.lecturer.services
{
    public class lecturerservices : Interfacelecturer
    {
        public List<models.lecturer> Getlecturer()
        {
            return lecturermockdataservice.lecturer;
        }

        public models.lecturer? Getlecturer(int id)
        {
            return lecturermockdataservice.lecturer.FirstOrDefault(x => x.Id == id);
        }

        public models.lecturer? Addlecturer(models.lecturer lecturer)
        {
            lecturermockdataservice.lecturer.Add(lecturer);
            return lecturer;
        }

        public models.lecturer? Updatelecturer(models.lecturer lecturer)
        {
            models.lecturer selectedlecturer = lecturermockdataservice.lecturer.FirstOrDefault(x => x.Id == lecturer.Id);
            if (selectedlecturer != null)
            {
                selectedlecturer.Address = lecturer.Address;
                selectedlecturer.Age = lecturer.Age;
                selectedlecturer.Name = lecturer.Name;
                return selectedlecturer;
            }

            return selectedlecturer;
        }

        public bool? Deletelecturer(int id)
        {
            models.lecturer selectedlecturer = lecturermockdataservice.lecturer.FirstOrDefault(x => x.Id == id);
            if (selectedlecturer != null)
            {
                lecturermockdataservice.lecturer.Remove(selectedlecturer);
                return true;
            }
            return false;
        }

      
        }
    }



