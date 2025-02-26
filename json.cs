//1. Basic JSON Handling

//1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Subjects { get; set; }
    }
    class CreateJson
    {
        static void Main()
        {
            Student student = new Student
            {
                Name = "Rohit",
                Age = 20,
                Subjects = new List<string> { "Math", "Science", "History" }
            };

            // Convert to JSON
            string json = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}

//2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    internal class ObjectToJson
    {
        static void Main()
        {
            Car car = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2022
            };

            // Convert to JSON
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}


//3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    class ReadJson
    {
        static void Main()
        {
            string jsonFilePath = "data.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            JArray jsonArray = JArray.Parse(jsonData);

            foreach (var item in jsonArray)
            {
                Console.WriteLine($"Name: {item["name"]}, Email: {item["email"]}");
            }
        }
    }
}

//4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    class MergeJson
    {
        static void Main()
        {
            JObject json1 = JObject.Parse("{ \"name\": \"Sanskriti\", \"age\": 25 }");
            JObject json2 = JObject.Parse("{ \"email\": \"sanskriti@gmail.com\", \"city\": \"MTJ\" }");

            json1.Merge(json2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

            Console.WriteLine(json1.ToString());
        }
    }
}


//5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONassignment
{
    class ValidateJson
    {
        static void Main()
        {
            string schemaJson = File.ReadAllText("schema.json");
            JSchema schema = JSchema.Parse(schemaJson);

            JObject userJson = JObject.Parse("{ \"name\": \"sanskriti\", \"email\": \"Sanskriti@gmail.com\" }");

            bool isValid = userJson.IsValid(schema, out IList<string> validationErrors);
            Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON");
        }
    }
}


//6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class ObjListToJsonArray
    {
        static void Main()
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 }
        };

            string json = JsonConvert.SerializeObject(people, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}

//7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    internal class ParseJson
    {
        static void Main()
        {
            string jsonData = File.ReadAllText("people.json");
            JArray peopleArray = JArray.Parse(jsonData);

            var filteredPeople = peopleArray.Where(p => (int)p["age"] > 25);
            Console.WriteLine(JArray.FromObject(filteredPeople).ToString());
        }
    }
}


//Hands-on Practice Problems
//1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    class ReadPrintkv
    {
        static void Main()
        {
            string jsonText = File.ReadAllText("data.json");
            JObject jsonObj = JObject.Parse(jsonText);

            foreach (var item in jsonObj)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}


//2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class ObjListToJsonArray
    {
        static void Main()
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 }
        };

            string json = JsonConvert.SerializeObject(people, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}

//3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    internal class FilterData
    {
        static void Main()
        {
            string json = File.ReadAllText("people.json");
            JArray jsonArray = JArray.Parse(json);

            var filteredUsers = jsonArray.Where(u => (int)u["age"] > 25);
            Console.WriteLine(JArray.FromObject(filteredUsers).ToString());
        }
    }
}



//4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONassignment
{
    internal class ValidateEmail
    {
        static void Main()
        {
            string schemaJson = File.ReadAllText("schema.json");
            JSchema schema = JSchema.Parse(schemaJson);
            JObject user = JObject.Parse(File.ReadAllText("user.json"));

            bool isValid = user.IsValid(schema, out IList<string> errors);
            Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
        }
    }
}

//5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    internal class MergeTwoJsonFile
    {
        static void Main()
        {
            JObject json1 = JObject.Parse(File.ReadAllText("user.json"));
            JObject json2 = JObject.Parse(File.ReadAllText("userData.json"));

            json1.Merge(json2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

            Console.WriteLine(json1.ToString());
        }
    }
}



//6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace JSONassignment
{
    internal class JsonToXml
    {
        static void Main()
        {
            string json = File.ReadAllText("data.json");
            JObject jsonObj = JObject.Parse(json);
            XDocument xml = JsonConvert.DeserializeXNode(jsonObj.ToString(), "Root");
            Console.WriteLine(xml.ToString());
        }
    }
}

//7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    internal class CsvToJson
    {
        static void Main()
        {
            var lines = File.ReadAllLines("info.csv");
            var headers = lines[0].Split(',');
            var jsonArray = new JArray(
                lines.Skip(1).Select(line => new JObject(headers.Zip(line.Split(','), (h, v) => new JProperty(h, v))))
            );
            Console.WriteLine(jsonArray.ToString());
        }
    }
}


//8

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{
    internal class GenerateJson
    {
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }
        static void Main()
        {
            string connectionString = "your_connection_string";
            string query = "SELECT Name, Age, Email FROM Users";
            var users = new List<User>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Name = reader["Name"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }

            string jsonReport = JsonConvert.SerializeObject(users, Formatting.Indented);
            Console.WriteLine(jsonReport);
            System.IO.File.WriteAllText("UserReport.json", jsonReport);
        }
    }
}

//ipl and censorship analyser
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    class IplCensorshipAnalyzer
    {
        static void Main(string[] args)
        {
            // Input file paths
            string jsonInputPath = @"C:\Users\HP\Documents\C#\Assignment26\iplData.json";
            string csvInputPath = @"C:\Users\HP\Documents\C#\Assignment26\iplData.csv";

            // Output file paths
            string jsonOutputPath = @"C:\Users\HP\Documents\C#\Assignment26\censored_ipl_data.json";
            string csvOutputPath = @"C:\Users\HP\Documents\C#\Assignment26\censored_ipl_data.csv";

            // 1. Process JSON Input
            if (File.Exists(jsonInputPath))
            {
                string jsonContent = File.ReadAllText(jsonInputPath);
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(jsonContent);
                ApplyCensorship(matches);
                string censoredJson = JsonConvert.SerializeObject(matches, Formatting.Indented);
                File.WriteAllText(jsonOutputPath, censoredJson);
                Console.WriteLine("Censored JSON file created: " + jsonOutputPath);
            }
            else
            {
                Console.WriteLine("JSON input file not found: " + jsonInputPath);
            }

            // 2. Process CSV Input
            if (File.Exists(csvInputPath))
            {
                var csvLines = File.ReadAllLines(csvInputPath).ToList();
                var headers = csvLines[0].Split(',').ToList();
                var censoredCsv = new List<string> { string.Join(",", headers) };

                for (int i = 1; i < csvLines.Count; i++)
                {
                    var fields = csvLines[i].Split(',').ToList();
                    var match = new Match
                    {
                        MatchId = int.Parse(fields[0]),
                        Team1 = fields[1],
                        Team2 = fields[2],
                        Score = new Dictionary<string, int>
                    {
                        { fields[1], int.Parse(fields[3]) },
                        { fields[2], int.Parse(fields[4]) }
                    },
                        Winner = fields[5],
                        PlayerOfMatch = fields[6]
                    };
                    ApplyCensorship(new List<Match> { match });

                    censoredCsv.Add($"{match.MatchId},{match.Team1},{match.Team2},{match.Score[match.Team1]},{match.Score[match.Team2]},{match.Winner},{match.PlayerOfMatch}");
                }

                File.WriteAllLines(csvOutputPath, censoredCsv);
                Console.WriteLine("Censored CSV file created: " + csvOutputPath);
            }
            else
            {
                Console.WriteLine("CSV input file not found: " + csvInputPath);
            }
        }

        // Apply censorship rules
        static void ApplyCensorship(List<Match> matches)
        {
            foreach (var match in matches)
            {
                match.Team1 = MaskTeamName(match.Team1);
                match.Team2 = MaskTeamName(match.Team2);
                match.Winner = MaskTeamName(match.Winner);
                match.PlayerOfMatch = "REDACTED";

                // Update score dictionary keys
                var newScore = new Dictionary<string, int>();
                foreach (var kvp in match.Score)
                {
                    newScore[MaskTeamName(kvp.Key)] = kvp.Value;
                }
                match.Score = newScore;
            }
        }

        // Mask team names
        static string MaskTeamName(string teamName)
        {
            if (string.IsNullOrEmpty(teamName)) return teamName;
            string[] parts = teamName.Split(' ');
            if (parts.Length > 1)
            {
                return parts[0] + " ***";
            }
            return teamName;
        }
    }

    // Match class to represent IPL match data
    class Match
    {
        public int MatchId { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public Dictionary<string, int> Score { get; set; }
        public string Winner { get; set; }
        public string PlayerOfMatch { get; set; }
    }
}