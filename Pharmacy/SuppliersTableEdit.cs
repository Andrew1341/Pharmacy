using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Model;

namespace Pharmacy
{
    public class SuppliersTableEdit : TableEditWindow<Suppliers>
    {
        public SuppliersTableEdit(PharmContext pharmContext, DbSet<Suppliers> dbset, ErrorsWindow errorsWindow) :
            base(pharmContext, dbset, errorsWindow, 3, new List<EntryType>() {
                EntryType.IncrementedId,
                EntryType.String
            }, new List<string>()
            {
                "",
                "Імя постачальника",
                "Адреса",
                "Телефон",
                "Контактна персона"
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
                        entity.Supplier_Name,
                        entity.Address,
                        entity.Phone,
                        entity.Contact_Person
                    });
                }
            }
        }

        protected override void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var entities = pharmContext.Supplier.ToList();
                pharmContext.Supplier.RemoveRange(entities);
                foreach (var row in table.entryRows)
                {
                    var suppliers = new Suppliers()
                    {
                        ID = int.Parse(row[0].Text),
                        Supplier_Name = row[1].Text,
                        Address = row[2].Text,
                        Phone = row[3].Text,
                        Contact_Person = row[4].Text
                    };
                    pharmContext.Supplier.Add(suppliers);
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