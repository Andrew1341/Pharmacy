using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Model;

namespace Pharmacy
{
    public class CitiesTableEdit : TableEditWindow<Cities>
    {
        public CitiesTableEdit(PharmContext pharmContext, DbSet<Cities> dbset, ErrorsWindow errorsWindow) :
            base(pharmContext, dbset, errorsWindow, 3, new List<EntryType>() {
                EntryType.IncrementedId,
                EntryType.String
            }, new List<string>()
            {
                "",
                "Назва города"
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
                        entity.City_Name
                    });
                }
            }
        }

        protected override void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var entities = pharmContext.City.ToList();
                pharmContext.City.RemoveRange(entities);
                foreach (var row in table.entryRows)
                {
                    var cities = new Cities()
                    {
                        ID = int.Parse(row[0].Text),
                        City_Name = row[1].Text
                    };
                    pharmContext.City.Add(cities);
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
