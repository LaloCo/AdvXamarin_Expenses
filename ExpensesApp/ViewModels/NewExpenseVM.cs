using System;
using System.ComponentModel;
using ExpensesApp.Models;

namespace ExpensesApp.ViewModels
{
    public class NewExpenseVM : INotifyPropertyChanged
    {
        private string expenseName;
        public string ExpenseName
        {
            get { return expenseName; }
            set
            {
                expenseName = value;
                OnPropertyChanged("ExpenseName");
            }
        }

        private string expenseDescription;
        public string ExpenseDescription
        {
            get { return expenseDescription; }
            set
            {
                expenseDescription = value;
                OnPropertyChanged("ExpenseDescription");
            }
        }

        private float expenseAmmount;
        public float ExpenseAmmount
        {
            get { return expenseAmmount; }
            set
            {
                expenseAmmount = value;
                OnPropertyChanged("ExpenseAmmount");
            }
        }

        private DateTime expenseDate;
        public DateTime ExpenseDate
        {
            get { return expenseDate; }
            set
            {
                expenseDate = value;
                OnPropertyChanged("ExpenseDate");
            }
        }

        private string expenseCategory;
        public string ExpenseCategory
        {
            get { return expenseCategory; }
            set
            {
                expenseCategory = value;
                OnPropertyChanged("ExpenseCategory");
            }
        }

        public NewExpenseVM()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void InsertExpense()
        {
            Expense expense = new Expense()
            {
                Name = ExpenseName,
                Ammount = ExpenseAmmount,
                Category = ExpenseCategory,
                Date = ExpenseDate,
                Description = ExpenseDescription
            };

            Expense.InsertExpense(expense);
        }
    }
}
