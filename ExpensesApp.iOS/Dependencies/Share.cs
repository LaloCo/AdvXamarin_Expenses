using System;
using System.Threading.Tasks;
using ExpensesApp.Interfaces;
using ExpensesApp.iOS.Dependencies;
using Xamarin.Forms;

[assembly: Dependency(typeof(Share))]
namespace ExpensesApp.iOS.Dependencies
{
    public class Share : IShare
    {
        public async Task Show(string title, string message, string filePath)
        {

        }
    }
}
