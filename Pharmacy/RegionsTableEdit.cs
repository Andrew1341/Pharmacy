using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Model;

namespace Pharmacy
{
    public class RegionsTableEdit : TableEditWindow<Regions>
    {
        public RegionsTableEdit(PharmContext pharmContext, DbSet<Regions> dbset, ErrorsWindow errorsWindow) :
            base(pharmContext, dbset, errorsWindow, 3, new List<EntryType>() {
                EntryType.IncrementedId,
                EntryType.String
            }, new List<string>()
            {
                "",
                "Назва регіону"
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
                        entity.Region_Name
                    });
                }
            }
        }

        protected override void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var entities = pharmContext.Region.ToList();
                pharmContext.Region.RemoveRange(entities);
                foreach (var row in table.entryRows)
                {
                    var regions = new Regions()
                    {
                        ID = int.Parse(row[0].Text),
                        Region_Name = row[1].Text
                    };
                    pharmContext.Region.Add(regions);
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