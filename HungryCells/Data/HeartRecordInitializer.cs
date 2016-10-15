﻿using System;
using System.Collections.Generic;
using HungryCells.Models;

namespace HungryCells.Data
{
    public class HeartRecordInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HeartRecordContext>
    {
        protected override void Seed(HeartRecordContext context)
        {
            var patients = new List<Patient>
            {
                new Patient{PatientID = 123456, FirstName="Carson",LastName="Alexander",BirthDate=DateTime.Parse("1955-12-01"),ReferralDate=DateTime.Parse("2016-10-13"), DVA=true},
                new Patient{PatientID = 123457, FirstName="Meredith",LastName="Alonso",BirthDate=DateTime.Parse("1982-09-19"),ReferralDate=DateTime.Parse("2016-03-12"), DVA=true},
                new Patient{PatientID = 123458, FirstName="Arturo",LastName="Anand",BirthDate=DateTime.Parse("1947-10-15"),ReferralDate=DateTime.Parse("2016-08-16"), DVA=false},
                new Patient{PatientID = 123459, FirstName="Gytis",LastName="Barzdukas",BirthDate=DateTime.Parse("1945-02-22"),ReferralDate=DateTime.Parse("2016-02-02"), DVA=false},
                new Patient{PatientID = 123450, FirstName="Yan",LastName="Li",BirthDate=DateTime.Parse("1929-04-04"),ReferralDate=DateTime.Parse("2016-10-13"), DVA=false},
                new Patient{PatientID = 123451, FirstName="Peggy",LastName="Justice",BirthDate=DateTime.Parse("1963-05-10"),ReferralDate=DateTime.Parse("2016-07-04"), DVA=true},
                new Patient{PatientID = 123452, FirstName="Laura",LastName="Norman",BirthDate=DateTime.Parse("1942-07-19"),ReferralDate=DateTime.Parse("2016-06-10"), DVA=false},
                new Patient{PatientID = 123453, FirstName="Nino",LastName="Olivetto",BirthDate=DateTime.Parse("1956-03-30"),ReferralDate=DateTime.Parse("2016-02-20"), DVA=false}
            };

            patients.ForEach(s => context.Patients.Add(s));
            context.SaveChanges();

            var tests = new List<Test>
            {
                new Test{TestName="Surgeon Review"},
                new Test{TestName="PBAV"},
                new Test{TestName="Echo"},
                new Test{TestName="RFTs"},
                new Test{TestName="Angio"},
                new Test{TestName="CT Tavi"},
                new Test{TestName="3 Mensio"},
                new Test{TestName="Carotid"},
                new Test{TestName="Dental Clearance"},
                new Test{TestName="Prof Walters r/v"}
            };
            tests.ForEach(s => context.Tests.Add(s));
            context.SaveChanges();
        }
    }
}