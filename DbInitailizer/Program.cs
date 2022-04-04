using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DatabaseLookups
{
    public static class DbConstant
    {
        public static void Main(string[] args)
        {
        }


        private static string[] GetDataFromFile(string path)
        {
            var reader = new StreamReader(path);

            List<string> listA = new List<string>();
            listA.Add(Values.PREFER_NOT_TO_SAY_DFAULT);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listA.Add(FirstLetterToUpper(values[0]));
            };
            reader.Close();

            return listA.ToArray();
        }
        public static void Create()
        {
            Debug.WriteLine("Getting Connection ...");

            //your connection string 
            string connString = "Data Source=.;Initial Catalog=Anthera;User ID=dylan;Password=sa";

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);


            try
            {
                Debug.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();
                CreateTables(conn);
                Debug.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Unscape(new List<string[]> {
                Values.children,
                Values.eyeColour,
                Values.hairColour,
                Values.hereTo,
                Values.gender,
                Values.jobTitle,
                Values.relationship,
                Values.smoking,
                Values.preferenceSex,
                Values.religion,
                Values.educationLevel,
                Values.personality,
                Values.role});
            }

        }
        public static void CreateTables(SqlConnection conn)
        {
            //gender
            int rowsEffected = Insert(Tables.children, ColumnName.children, Values.children, conn);
            Debug.WriteLine($"{Tables.children} | {rowsEffected}");

            rowsEffected = Insert(Tables.drinking, ColumnName.drinking, Values.drinking, conn);
            Debug.WriteLine($"{Tables.drinking} | {rowsEffected}");

            rowsEffected = Insert(Tables.eyeColour, ColumnName.eyeColour, Values.eyeColour, conn);
            Debug.WriteLine($"{Tables.eyeColour} | {rowsEffected}");

            rowsEffected = Insert(Tables.hairColour, ColumnName.hairColour, Values.hairColour, conn);
            Debug.WriteLine($"{Tables.hairColour} | {rowsEffected}");

            rowsEffected = Insert(Tables.hereTo, ColumnName.hereTo, Values.hereTo, conn);
            Debug.WriteLine($"{Tables.hereTo} | {rowsEffected}");

            rowsEffected = Insert(Tables.gender, ColumnName.gender, Values.gender, conn);
            Debug.WriteLine($"{Tables.gender} | {rowsEffected}");

            rowsEffected = Insert(Tables.jobTitle, ColumnName.jobTitle, Values.jobTitle, conn);
            Debug.WriteLine($"{Tables.jobTitle} | {rowsEffected}");

            rowsEffected = Insert(Tables.relationship, ColumnName.relationship, Values.relationship, conn);
            Debug.WriteLine($"{Tables.relationship} | {rowsEffected}");

            rowsEffected = Insert(Tables.sexuality, ColumnName.sexuality, Values.sexuality, conn);
            Debug.WriteLine($"{Tables.sexuality} | {rowsEffected}");

            rowsEffected = Insert(Tables.smoking, ColumnName.smoking, Values.smoking, conn);
            Debug.WriteLine($"{Tables.smoking} | {rowsEffected}");

            rowsEffected = Insert(Tables.preferenceSex, ColumnName.preferenceSex, Values.preferenceSex, conn);
            Debug.WriteLine($"{Tables.preferenceSex} | {rowsEffected}");

            rowsEffected = Insert(Tables.religion, ColumnName.religion, Values.religion, conn);
            Debug.WriteLine($"{Tables.religion} | {rowsEffected}");

            rowsEffected = Insert(Tables.educationLevel, ColumnName.educationLevel, Values.educationLevel, conn);
            Debug.WriteLine($"{Tables.educationLevel} | {rowsEffected}");

            rowsEffected = Insert(Tables.personality, ColumnName.personality, Values.personality, conn);
            Debug.WriteLine($"{Tables.personality} | {rowsEffected}");

            rowsEffected = Insert(Tables.role, ColumnName.role, Values.role, conn);
            Debug.WriteLine($"{Tables.role} | {rowsEffected}");


           
        }
        public static int Insert(string tableName, string insertValues, string[] values, SqlConnection sqlConnection)
        {
            var x = new Query
            {
                Name = tableName,
                InsertValues = insertValues,
                Values = values
            };
            return ExecuteQuery(sqlConnection, x.Build());
        }
        public static int ExecuteQuery(SqlConnection sqlConnection, string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            return command.ExecuteNonQuery();
        }
        public class Query
        {
            public string Name { get; set; }
            public string InsertValues { get; set; }
            public string[] Values { get; set; }
            public string Build()
            {
                var x = $"INSERT INTO[dbo].[{Name}] ([{InsertValues}]) VALUES ";

                string y = null;
                for(int i = 0; i < Values.Length; i++)
                {
                    Values[i] = Values[i].Replace("'", "''");
                    Values[i] = Values[i].Replace(",", "");


                    y += "('";
                    y += Values[i];
                    y += "')";

                    if (i != Values.Length - 1)
                    {
                        y += ",";
                    }
                }
                Debug.WriteLine(x + y);
                return x+y+";";
            }

        }
        public static class Tables
        {
            public static readonly string children = "children"; 
            public static readonly string drinking = "drinking"; 
            public static readonly string eyeColour = "eye_colour"; 
            public static readonly string hairColour = "hair_colour"; 
            public static readonly string hereTo = "here_to"; 
            public static readonly string gender = "gender"; 
            public static readonly string jobTitle = "job_title"; 
            public static readonly string relationship = "relationship"; 
            public static readonly string sexuality = "sexuality"; 
            public static readonly string smoking = "smoking"; 
            public static readonly string preferenceSex = "preference_sex"; 
            public static readonly string religion = "religion";
            public static readonly string educationLevel = "education_level";
            public static readonly string personality = "personality";
            public static readonly string role = "role";
        }
        public static class ColumnName
        {
            public static readonly string children = "children_type";
            public static readonly string drinking = "drinking_type";
            public static readonly string eyeColour = "colour";
            public static readonly string hairColour = "colour";
            public static readonly string hereTo = "here_to_type";
            public static readonly string gender = "gender_name";
            public static readonly string jobTitle = "title";
            public static readonly string relationship = "relationship_type";
            public static readonly string sexuality = "sexuality_type";
            public static readonly string smoking = "smoking_type";
            public static readonly string preferenceSex = "sex";
            public static readonly string religion = "religion_name";
            public static readonly string educationLevel = "education_level_name";
            public static readonly string personality = "personality_name";
            public static readonly string role = "role_name";
        }
        public static class Values
        {
            public static readonly string PREFER_NOT_TO_SAY_DFAULT = "I'd perfer not to say";
            public static readonly string ABOUT_ME_DEFAULT = "Write something about your self...";
            public static readonly string HEIGHT_DEFAULT = "163 cm";
            public static readonly string WEIGHT_DEFAULT = "60 kg";
            public static readonly int DEFAULT_PHOTO_LIMIT = 6;

            public static readonly string[] children = new string[] { Children.Someday, Children.AlreadyHave, Children.NoNever, Children.GrownUp, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] drinking = new string[] { Drinking.DrinkSocialy, Drinking.Never, Drinking.DrinkOften, Drinking.NoImSober, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] eyeColour = new string[] { EyeColour.Blue, EyeColour.Brown, EyeColour.Green, EyeColour.Hazel, EyeColour.Amber, EyeColour.CosmeticIris, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] hairColour = new string[] { HairColour.Black, HairColour.Brown, HairColour.Blonde, HairColour.Red, HairColour.Dyed, HairColour.Shaved, HairColour.Bald, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] hereTo = new string[] { HereTo.Date, HereTo.Chat, HereTo.Relationship};
            public static readonly string[] gender = new string[] { Gender.Female, Gender.Male, Gender.TransWoman, Gender.TransMan };
            public static readonly string[] jobTitle = GetDataFromFile(@"W:\projects\TheOneMaybe\Anthera\DbInitailizer\data\job_titles.csv");//need to add more
            public static readonly string[] relationship = new string[] { Relationship.ImSingle, Relationship.ItsComplicated, Relationship.ImTaken, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] sexuality = new string[] { Sexuality.ImStraight, Sexuality.ImBisexual, Sexuality.ImGay, Sexuality.AskMe, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] smoking = new string[] { Smoking.IdontSmoke, Smoking.SmokeOccasionally, Smoking.HateSmoking, Smoking.HeavySmoker, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] preferenceSex = new string[] { PreferenceSex.Female, PreferenceSex.Male, PreferenceSex.Both };
            public static readonly string[] religion = GetDataFromFile(@"W:\projects\TheOneMaybe\Anthera\DbInitailizer\data\religions.csv");//need to add more
            public static readonly string[] educationLevel = new string[] { EducationLevel.HighSchool, EducationLevel.Diploma, EducationLevel.Bachelors, EducationLevel.Masters, EducationLevel.Doctors, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] personality = new string[] { Personality.Extrovert, Personality.Introvert, Personality.SomewhereInBetween, PREFER_NOT_TO_SAY_DFAULT };
            public static readonly string[] role = new string[] { Role.ANTHER_USER, Role.ANTHERA_ADMIN };

            public static class Personality
            {
                public static readonly string Extrovert = "Extrovert";
                public static readonly string Introvert = "Introvert";
                public static readonly string SomewhereInBetween = "Somewhere in between";
            }
            public static class EducationLevel
            {
                public static readonly string Doctors = "Doctors";
                public static readonly string Masters = "Masters";
                public static readonly string Bachelors = "Bachelors";
                public static readonly string Diploma = "Diploma";
                public static readonly string HighSchool = "High school";
            }
            public static class Religion
            {
                public static readonly string Both = "Both";
                public static readonly string Male = "Male";
                public static readonly string Female = "Female";
            }
            public static class PreferenceSex
            {
                public static readonly string Both = "Both";
                public static readonly string Male = "Male";
                public static readonly string Female = "Female";
            }
            public static class Smoking
            {
                public static readonly string HeavySmoker = "I'm a heavy smoker";
                public static readonly string HateSmoking = "I hate smoking";
                public static readonly string SmokeOccasionally = "I smoke occasionally";
                public static readonly string IdontSmoke = "I don't smoke";
            }
            public static class Sexuality
            {
                public static readonly string ImBisexual = "I'm bisexual";
                public static readonly string ImGay = "I'm gay";
                public static readonly string AskMe = "Ask me";
                public static readonly string ImStraight = "I'm straight";
            }
            public static class Relationship
            {
                public static readonly string ImTaken = "I'm taken";
                public static readonly string ItsComplicated = "It's complicated";
                public static readonly string ImSingle = "I'm single";
            }
            public static class Children
            {
                public static readonly string GrownUp = "Grown up";
                public static readonly string AlreadyHave = "Already have";
                public static readonly string NoNever = "No, never";
                public static readonly string Someday = "Someday";
            }
            public static class Drinking
            {
                public static readonly string DrinkSocialy = "I drink socialy";
                public static readonly string Never = "Never";
                public static readonly string DrinkOften = "I drink often";
                public static readonly string NoImSober = "No, I'm sober";
            }
            public static class EyeColour
            {
                public static readonly string Blue = "Blue";
                public static readonly string Brown = "Brown";
                public static readonly string Green = "Green";
                public static readonly string Hazel = "Hazel";
                public static readonly string Amber = "Amber";
                public static readonly string CosmeticIris = "Cosmetic Iris";
            }
            public static class HairColour
            {
                public static readonly string Black = "Black";
                public static readonly string Brown = "Brown";
                public static readonly string Blonde = "Blonde";
                public static readonly string Red = "Red";
                public static readonly string Dyed = "Dyed";
                public static readonly string Shaved = "Shaved";
                public static readonly string Bald = "Bald";
            }
            public static class HereTo
            {
                public static readonly string Chat = "I'm here to chat";
                public static readonly string Date = "I'm Here to date";
                public static readonly string Relationship = "I'm here for a relationship";
            }
            public static class JobTitle
            {
                public static readonly string Developer = "Female";
                public static readonly string Male = "Male";
                public static readonly string TransWoman = "TransWoman";
                public static readonly string TransMan = "TransMan";
            }
            public static class Gender
            {
                public static readonly string Female = "Female";
                public static readonly string Male = "Male";
                public static readonly string TransWoman = "TransWoman";
                public static readonly string TransMan = "TransMan";
            }
            public static class Role
            {
                public static readonly string ANTHER_USER = "ANTHERA_USER";
                public static readonly string ANTHERA_ADMIN = "ANTHERA_ADMIN";
            }
        }

        

        public static byte DefaultValue(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(Values.PREFER_NOT_TO_SAY_DFAULT))
                {
                    return (byte)(i + 1);
                }
            }
            return 1;
        }

        public static byte ConstantStringToIndexByte(string value, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value.ToLower().Equals(array[i].ToLower()))
                {
                    return (byte)(i+1);
                }
            }
            return 1;
        }

        public static int ConstantStringToIndex(string value, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value.ToLower().Equals(array[i].ToLower()))
                {
                    return i + 1;
                }
            }
            return 1;
        }

        public static string ConstantIndexToString(byte value, string[] array)
        {
            return array[value-1];
        }

        public static string ConstantIndexToString(int value, string[] array)
        {
            return array[value - 1];
        }

        private static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        private static void Unscape(List<string[]> arrays)
        {
            foreach (var item in arrays)
            {
                for(int i = 0; i < item.Length; i++)
                {
                    item[i] = item[i].Replace("''", "'");
                }
            }
        }
    }
}