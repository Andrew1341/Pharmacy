using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Model;

namespace Pharmacy
{
    public class EmployeesTableEdit : TableEditWindow<Employees>
    {
        public EmployeesTableEdit(PharmContext pharmContext, DbSet<Employees> dbset, ErrorsWindow errorsWindow) :
            base(pharmContext, dbset, errorsWindow, 3, new List<EntryType>() {
                EntryType.IncrementedId,
                EntryType.NonIncrementedId,
                EntryType.NonIncrementedId,
                EntryType.NonIncrementedId
            }, new List<string>()
            {
                "",
                "Last_Name",
                "First_Name",
                "Middle_Name",
                "",
                "",
                "Position",
                "Login",
                "Password"
            }
                )
        {
            if (pharmContext.IsEmpty())
            {
                AddRow(this, null);
            }
            else
            {
                foreach (var entity in dbset.ToList())
                {
                    table.AddRow(new List<string>() {
                        entity.ID.ToString(),
                        entity.Last_Name,
                        entity.First_Name,
                        entity.Middle_Name,
                        entity.Date_of_Birth.ToString("yyyy-MM-dd"),
                        entity.Pharmacy_ID.ToString(),
                        entity.Position,
                        entity.Login,
                        entity.Password
                    });
                }
            }
        }

        protected override void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var entities = pharmContext.Employee.ToList();
                pharmContext.Employee.RemoveRange(entities);
                foreach (var row in table.entryRows)
                {
                    var employees = new Employees()
                    {
                        ID = int.Parse(row[0].Text),
                        Last_Name = row[1].Text,
                        First_Name = row[2].Text,
                        Middle_Name = row[3].Text,
                        Date_of_Birth = DateTime.ParseExact(row[4].Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                        Pharmacy_ID = int.Parse(row[5].Text),
                        Position = row[6].Text,
                        Login = row[7].Text,
                        Password = row[8].Text
                    };
                    pharmContext.Employee.Add(employees);
                    Console.Write(".");
                }
                base.OnSaveButtonClicked(sender, e);
            }
            catch (Exception ex)
            {
                errorsWindow.Report(ex.ToString());
            }
        }
    }
}