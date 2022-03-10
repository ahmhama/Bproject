using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Testing.Any()) return;

            var testings= new List<Testing>
            {

                // new Relatives
                // {
                //     RelativeId = 1,
                //     firstName = "Ahmed",
                //     lastName = "Mahmoud",
                //     gender = "Male",
                //     address = "Haram",
                //     number = "10101010",
                //     email = "email@email.com"

                // }
                // new Child
                // {
                //     ChildId = 1,
                //     ChildFirstName = "Mohamed",
                //     ChildMiniName = "Ahmed",
                //     ChildLastName = "Mahmoud",
                //     ChildGender = "Male",
                //     ChildBirthDate =DateTime.Parse("15/2/2021"),
                //     ChildAddress = "Dokki",
                //     RelativeId = 1
                // }
                // new Doctor
                // {
                //     DoctorId = 1,
                //     firstName = "Omar",
                //     lastName = "Hossam",
                //     gender ="Male",
                //     address = "october",
                //     number = "01010011",
                //     Email = "Email@email.com",
                //     specilization = "Child Doctor",
                //     HealthOfficeId = 1
                // }

                // new Diseases
                // {
                //     DiseaseId = 1,
                //     Name = "marad",
                //     sideEffect = "nomarad",
                //     vaccineName = "vaccine"
                // }
                // new Checking
                // {
                //     ChildId = 1,
                //     DiseasesId = 1,
                //     doctorId = 1,
                //     CheckResultDescription= "Good",
                //     Weight = 15,
                //     Height= 112,
                //     date = DateTime.Parse("15/2/2012")

                // }
                //  new VaccineCamping
                //  {
                //      VaccineCampingId = 1,
                //      VaccineCampingName ="vaccinecamping",
                //      VaccineCampingDescription="description",
                //      Date =DateTime.Parse("15/2/2019"),
                //      Time = TimeSpan.Parse("22:10"),
                //      adminId= 1,


                //  }
                // new Event 
                // {
                //     ChildId = 1,
                //     doctorId = 1,
                //     VaccineCampingId= 1,
                //     Date = DateTime.Today
                // }

                // new HealthOffice 
                // {
                //     HealthOfficeId = 1,
                //     name = "Ministry of Health",
                //     address= "Haram",
                //     email = "email@gamil.com",
                //     number = "10203102321",
                //     MinisrtAdminId = 1

                // }
                // new Vaccine
                // {
                //     VaccineId = 1,
                //     VaccineAge = "15",
                //     DateTime = DateTime.Parse("12/2/2000"),
                //     VaccineName = "shalalatfal",
                //     diseasesName = "marad",
                //     DoseRoute = "2"
                // }
                // new VaccineTransaction 
                // {
                //     ChildId = 1,
                //     doctorId =1,
                //     VaccineId =1,
                //     Date = DateTime.Parse("10/2/2019"),
                //     DueDate = DateTime.Parse("2/1/1998")
                // }

                new Testing 
                {
                    TestingName = "Testing 1",
                    TestingNumber = 1
                },
                new Testing 
                {
                    TestingName = "Testing 2",
                    TestingNumber = 2
                }



                
            };

            await context.Testing.AddRangeAsync(testings);
            await context.SaveChangesAsync();
        }
    }
}