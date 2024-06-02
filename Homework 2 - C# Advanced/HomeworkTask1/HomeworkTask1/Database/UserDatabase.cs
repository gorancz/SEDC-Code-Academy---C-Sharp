using HomeworkTask1.Models;
namespace HomeworkTask1.Database
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; } = new List<User>
    {
        new User { Id = 1, Name = "Milos", Age = 22 },
        new User { Id = 2, Name = "Petar", Age = 30 },
        new User { Id = 3, Name = "Zoran", Age = 34 },
        new User { Id = 4, Name = "Milan", Age = 44 }
    };

        public static List<User> SearchById(int id)
        {
            return Users
                .Where(user => user.Id == id)
                .ToList();
        }

        public static List<User> SearchByName(string name)
        {
            return Users
                .Where(user => user.Name == name)
                .ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return Users
                .Where(user => user.Age == age)
                .ToList();
        }
    }
}
