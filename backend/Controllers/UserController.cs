using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;
using backend.Domain.Cores;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController:ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        private List<User> Users = new List<User>
        {
                new User() {
                    Id = 1,
                    Username = "Rahmani",
                    Password = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", //123456
                    N = 1
                },
                new User() {
                    Id = 2,
                    Username = "Golizad",
                    Password = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5", //12345
                    N = 1
                },
                new User() {
                    Id = 3,
                    Username = "Ebrahimian",
                    Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", //1234
                    N = 1
                }
        };

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        private string CalculateSHA256(string str = "")
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashValue;
            UTF8Encoding objUtf8 = new UTF8Encoding();
            hashValue = sha256.ComputeHash(objUtf8.GetBytes(str));

            return GetStringFromHash(hashValue).ToLower();
        }

        [HttpGet]
        public IEnumerable<User> GetAllUser()
        {
            return Users.AsEnumerable().ToArray();
        }

        [HttpPost]
        public IEnumerable<User> Login(string Username, string Passworrd)
        {
            if (Username == null || Passworrd == null)
            {
                return Enumerable.Empty<User>();
            }

            string HashPassword = CalculateSHA256(Passworrd);
            Console.WriteLine(HashPassword);

            for (int i = 0; i < Users.Count(); i++)
            {
                if (Users[i].Username == Username && Users[i].Password == HashPassword)
                {
                    Users[i].Password = Passworrd;
                    Users[i].N--;

                    if (Users[i].N <= 0)
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(7, 100);

                        for (int j = 0; j < randomNumber - 2; j++)
                        {
                            HashPassword = CalculateSHA256(Passworrd);
                        }

                        Users[i].Password = HashPassword;
                        Users[i].N = randomNumber;
                    }
                    return Enumerable.Repeat(Users[i], 1);
                }
            }

            return Enumerable.Empty<User>();
        }

        [HttpPost]
        public IEnumerable<int> GetNumber(string Username)
        {
            if (Username == null)
            {
                return Enumerable.Empty<int>();
            }

            for (int i = 0; i < Users.Count(); i++)
            {
                if (Users[i].Username == Username)
                {
                    return Enumerable.Repeat(Users[i].N, 1);
                }
            }

            return Enumerable.Empty<int>();
        }

    }
}
