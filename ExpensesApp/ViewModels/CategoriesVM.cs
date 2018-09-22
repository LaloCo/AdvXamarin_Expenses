using System;
using System.Collections.ObjectModel;
using ExpensesApp.Models;
using System.Linq;
using ExpensesApp.Interfaces;
using Xamarin.Forms;

namespace ExpensesApp.ViewModels
{
    public class CategoriesVM
    {
        public ObservableCollection<string> Categories
        {
            get;
            set;
        }

        public ObservableCollection<CategoryExpenses> CategoryExpensesCollection
        {
            get;
            set;
        }

        public CategoriesVM()
        {
            Categories = new ObservableCollection<string>();
            CategoryExpensesCollection = new ObservableCollection<CategoryExpenses>();

            GetCategories();
            GetExpensesPerCategory();
        }

        private void GetCategories()
        {
            Categories.Clear();
            Categories.Add("Housing");
            Categories.Add("Debt");
            Categories.Add("Health");
            Categories.Add("Food");
            Categories.Add("Personal");
            Categories.Add("Travel");
            Categories.Add("Other");
        }

        public void GetExpensesPerCategory()
        {
            CategoryExpensesCollection.Clear();
            float totalExpensesAmmount = Expense.TotalExpensesAmmount();
            foreach(string c in Categories)
            {
                var expenses = Expense.GetExpenses(c);
                float expensesAmmountInCategory = expenses.Sum(e => e.Ammount);

                CategoryExpenses ce = new CategoryExpenses()
                {
                    Category = c,
                    ExpensesPercentage = expensesAmmountInCategory / totalExpensesAmmount
                };

                CategoryExpensesCollection.Add(ce);
            }
        }

        public void ShareReport()
        {
            IShare shareDependency = DependencyService.Get<IShare>();
            shareDependency.Show("", "", "");
        }

        public class CategoryExpenses
        {
            public string Category
            {
                get;
                set;
            }

            public float ExpensesPercentage
            {
                get;
                set;
            }
        }
    }
}
