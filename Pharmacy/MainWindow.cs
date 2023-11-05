using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtk;
using Pharmacy.Model;

namespace Pharmacy
{
    public class MainWindow : Window
    {
        public TableEditWindow<Cities> cityTableWindow;
        public ErrorsWindow errorsWindow;

        public MainWindow() : base("Лабораторна2")
        {
            SetupTabs();

            // Connect the Destroy event to close the application
            DeleteEvent += (o, args) => Application.Quit();
        }

        public void SetupTabs()
        {
            var db = new PharmContext();
            if (db.IsEmpty())
            {
                db.Database.Delete();
            }
            // Create a notebook to hold the tabs
            Notebook notebook = new Notebook();

            // Create and add tabs to the notebook
            Label tabLabel1 = new Label("Employees");
            Label tabLabel2 = new Label("Cities");
            Label tabLabel3 = new Label("Regions");
            Label tabLabel4 = new Label("Supplier");
            Label errorsWindowTabLabel = new Label("Системні Повідомлення");

            this.errorsWindow = new ErrorsWindow(this);

            // Add widgets or content to the tabs
            var employeesTableWindow = new EmployeesTableEdit(db, db.Employee, this.errorsWindow);
            employeesTableWindow.table.OnTableModified += (row, column) => { tabLabel1.Text = tabLabel1.Text.Replace("*", "") + "*"; };
            employeesTableWindow.OnTableSaved += () => { tabLabel1.Text = tabLabel1.Text.Replace("*", ""); };

            var citiesTableWindow = new CitiesTableEdit(db, db.City, this.errorsWindow);
            citiesTableWindow.table.OnTableModified += (row, column) => { tabLabel2.Text = tabLabel2.Text.Replace("*", "") + "*"; };
            citiesTableWindow.OnTableSaved += () => { tabLabel2.Text = tabLabel2.Text.Replace("*", ""); };

            var regionsTableWindow = new RegionsTableEdit(db, db.Region, this.errorsWindow);
            regionsTableWindow.table.OnTableModified += (row, column) => { tabLabel3.Text = tabLabel3.Text.Replace("*", "") + "*"; };
            regionsTableWindow.OnTableSaved += () => { tabLabel3.Text = tabLabel3.Text.Replace("*", ""); };

            var suppliersTableWindow = new SuppliersTableEdit(db, db.Supplier, this.errorsWindow);
            suppliersTableWindow.table.OnTableModified += (row, column) => { tabLabel4.Text = tabLabel4.Text.Replace("*", "") + "*"; };
            suppliersTableWindow.OnTableSaved += () => { tabLabel4.Text = tabLabel4.Text.Replace("*", ""); };

            // Append tabs to the notebook
            notebook.AppendPage(employeesTableWindow, tabLabel1);
            notebook.AppendPage(citiesTableWindow, tabLabel2);
            notebook.AppendPage(regionsTableWindow, tabLabel3);
            notebook.AppendPage(suppliersTableWindow, tabLabel4);
            notebook.AppendPage(errorsWindow, errorsWindowTabLabel);

            // Add the notebook to the window
            Add(notebook);

            Resize(600, 600);
        }
    }
}
