using Anthera_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Anthera_API.Data
{
    public class DbInitializer
    {
        public void AddData(ModelBuilder modelBuilder)
        {
            var Personalities = createRows(typeof(DbConstant.Personality), (int i, string s) =>
            {
                return new Personality
                {
                    Id = (byte)i,
                    PersonalityName = s,
                };
            });
            modelBuilder.Entity<Personality>().HasData(Personalities);

            var EducationLevels = createRows(typeof(DbConstant.EducationLevel), (int i, string s) =>
            {
                return new EducationLevel
                {
                    Id = (byte)i,
                    EducationLevelName = s,
                };
            });
            modelBuilder.Entity<EducationLevel>().HasData(EducationLevels);


            var Religions = new List<Religion>();
            for (int i = 0; i < DbConstant.Religion.Religions.Length; i++)
            {
                Religions.Add(new Religion
                {
                    Id = i + 1,
                    ReligionName = DbConstant.Religion.Religions[i]
                });
            }

            modelBuilder.Entity<Religion>().HasData(Religions);

            var PreferenceSexes = createRows(typeof(DbConstant.PreferenceSex), (int i, string s) =>
            {
                return new PreferenceSex
                {
                    Id = (byte)i,
                    Sex = s,
                };
            });
            modelBuilder.Entity<PreferenceSex>().HasData(PreferenceSexes);

            var SmokingTypes = createRows(typeof(DbConstant.Smoking), (int i, string s) =>
            {
                return new Smoking
                {
                    Id = (byte)i,
                    SmokingType = s,
                };
            });
            modelBuilder.Entity<Smoking>().HasData(SmokingTypes);

            var SexualityTypes = createRows(typeof(DbConstant.Sexuality), (int i, string s) =>
            {
                return new Sexuality
                {
                    Id = (byte)i,
                    SexualityType = s,
                };
            });
            modelBuilder.Entity<Sexuality>().HasData(SexualityTypes);

            var RelationshipTypes = createRows(typeof(DbConstant.Relationship), (int i, string s) =>
            {
                return new Relationship
                {
                    Id = (byte)i,
                    RelationshipType = s,
                };
            });
            modelBuilder.Entity<Relationship>().HasData(RelationshipTypes);

            var ChildrenTypes = createRows(typeof(DbConstant.Children), (int i, string s) =>
            {
                return new Children
                {
                    Id = (byte)i,
                    ChildrenType = s,
                };
            });
            modelBuilder.Entity<Children>().HasData(ChildrenTypes);


            var DrinkingTypes = createRows(typeof(DbConstant.Drinking), (int i, string s) =>
            {
                return new Drinking
                {
                    Id = (byte)i,
                    DrinkingType = s,
                };
            });
            modelBuilder.Entity<Drinking>().HasData(DrinkingTypes);


            var EyeColours = createRows(typeof(DbConstant.EyeColour), (int i, string s) =>
            {
                return new EyeColour
                {
                    Id = (byte)i,
                    Colour = s,
                };
            });
            modelBuilder.Entity<EyeColour>().HasData(EyeColours);

            var HairColours = createRows(typeof(DbConstant.HairColour), (int i, string s) =>
            {
                return new HairColour
                {
                    Id = (byte)i,
                    Colour = s,
                };
            });
            modelBuilder.Entity<HairColour>().HasData(HairColours);

            var HereTotypes = createRows(typeof(DbConstant.HereTo), (int i, string s) =>
            {
                return new HereTo
                {
                    Id = (byte)i,
                    HereToType = s,
                };
            });
            modelBuilder.Entity<HereTo>().HasData(HereTotypes);

      
            var Jobtitles = new List<JobTitle>();
            for(int i =0;i<DbConstant.JobTitle.JobTitiles.Length;i++)
            {
                Jobtitles.Add(new JobTitle
                {
                    Id = i+1,
                    Title = DbConstant.JobTitle.JobTitiles[i]
                });
            }

            modelBuilder.Entity<JobTitle>().HasData(Jobtitles);

            var Genders = createRows(typeof(DbConstant.Gender), (int i, string s) =>
            {
                return new Gender
                {
                    Id = (byte)i,
                    GenderName = s,
                };
            });
            modelBuilder.Entity<Gender>().HasData(Genders);

            var Roles = createRows(typeof(DbConstant.Role), (int i, string s) =>
            {
                return new Role
                {
                    Id = (byte)i,
                    RoleName = s,
                };
            });
            modelBuilder.Entity<Role>().HasData(Roles);
        }



        public object[] createRows(Type t, Func<int, string, object> function)
        {
            FieldInfo[] fields = t.GetFields(BindingFlags.Static | BindingFlags.Public);
            List<object> list = new List<object>();

            for(int i = 0; i < fields.Length; i++)
            {
                if (i != fields.Length - 1)
                {
                    list.Add(function(i+1,fields[i].GetValue(null) as string));
                }
            }

            return list.ToArray();
        }

    }
}
