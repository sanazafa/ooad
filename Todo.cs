using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Todo
    {
        private string date;
        private string todoentry;
        private string goalentry;
        private string name;
        private string type;
        public string Goalentry { get => goalentry; set => goalentry = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Todoentry { get => todoentry; set => todoentry = value; }
        public string Date { get => date; set => date = value; }
    }
}