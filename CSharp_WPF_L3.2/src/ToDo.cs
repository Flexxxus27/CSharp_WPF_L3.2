using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_WPF_L3._2.src
{
    public class ToDo
    {
        private string Title {  get; set; }
        private DateTime Date { get; set; }
        private string Description { get; set; }
        public bool Done { get; set; }
        public ToDo() { }

        public ToDo(string title, string description,DateTime date) 
        {
            this.Title = title;
            this.Date = date;
            this.Description = description;
        }
    }
}
