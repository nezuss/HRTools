using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment4
{
    internal class Company
    {
        // Params
        private const string FILENAME = "../../../DB.txt";
        private const char DELIMETR = '|';

        private int id;
        public string name;
        public string address;
        public string email;
        public string phone;
        public string expertise;
        public Int16 rating;                // Not need .ToString()
        public string comments;

        private static int maxId;
        public static List<string> _companies = new List<string>();
        public static Dictionary<int, Company> companies = new Dictionary<int, Company>();

        // Input
        public Company(string Name, string Address,
                       string Email, string Phone, string Expertise,
                       Int16 Rating, string Comments)
        {
            id = ++Company.maxId;
            this.name = Name;
            this.address = Address;
            this.email = Email;
            this.phone = Phone;
            this.expertise = Expertise;
            this.rating = Rating;
            this.comments = Comments;
            companies.Add(id, this);
        }

        // Output
        public Company(string line)
        {
            string[] data = line.Split(DELIMETR);
            this.id = int.Parse(data[0]);
            if (Company.maxId < id) Company.maxId = id;
            this.name = data[1];
            this.address = data[2];
            this.email = data[3];
            this.phone = data[4];
            this.expertise = data[5];
            this.rating = Int16.Parse(data[6]);
            this.comments = data[7];
            companies.Add(id, this);
        }

        // Get
        public int GetId() { return id; }
        public string GetName() { return name; }
        public string GetAddress() { return address; }
        public string GetEmail() { return email; }
        public string GetPhone() { return phone; }
        public string GetExpertise() { return expertise; }
        public Int16 GetRating() { return rating; }
        public string GetComments() { return comments; }
        public string ToSaveConstruct() { return id.ToString() + DELIMETR + name + DELIMETR
                                               + address + DELIMETR + email + DELIMETR
                                               + phone + DELIMETR + expertise + DELIMETR
                                               + rating + DELIMETR + comments; }

        public static List<Company> GetCompanies() { return new List<Company>(companies.Values); }

        // Actions
        public static void Save()
        {
            if (!File.Exists(Company.FILENAME)) File.WriteAllText(Company.FILENAME, string.Empty);
            StreamWriter fOut = new StreamWriter(FILENAME);
            foreach (Company company in Company.companies.Values)
                fOut.WriteLine(company.ToSaveConstruct());

            fOut.Close();
        }
        public static void Load()
        {
            if (!File.Exists(Company.FILENAME)) return;
            string rCompanies = File.ReadAllText(Company.FILENAME);
            string[] rCompany = rCompanies.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (string param in rCompany)
            {
                if (string.IsNullOrEmpty(param)) continue;
                new Company(param);
            }
        }
        public static void Delete(int Id) { if (Company.GetCompany(Id) != null)
                                                Company.companies.Remove(Id); }
        public static Company GetCompany(int Id)
        {
            if (Company.companies.ContainsKey(Id)) return Company.companies[Id];
            else return null;
        }
    }
}