using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace WebApp.App
{
    public class Question5
    {
        public IEnumerable<Visit> GetVisits()
        {
            var sql = "select p.PharmacyName, max(v.PatientName) as PatientName, ";
            sql += "count(v.PrescriptionId) as VisitsWithFilledPrescription ";
            sql += "from Pharmacies p ";
            sql += "inner join Prescriptions v on v.PharmacyId = p.PharmacyId ";
            sql += "where v.Filled = 1 group by p.PharmacyName ";

            using (var cn = new SqlConnection("the-sql-connection-string"))
            {
                return cn.Query<Visit>(sql);
            }
        }

        public class Visit
        {
            public string PharmacyName { get; set; }

            public string PatientName { get; set; }

            public int VisitsWithFilledPrescription { get; set; }
        }
    }
}
