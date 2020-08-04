using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class MovieStar
    {
        public MovieStar(string name, string surname, string sex, string nationality, DateTime dateOfbirth)
        {
            this.DateOfBirth = dateOfbirth;
            this.Name = name;
            this.Nationality = nationality;
            this.Sex = sex;
            this.Surname = surname;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }
    }
}
