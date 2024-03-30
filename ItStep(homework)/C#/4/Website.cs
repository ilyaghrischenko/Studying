using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//task 4

namespace _4
{
    internal class Website
    {
        private string name;
        private string url;
        private string description;
        private string ip;

        public Website()
        {
            name = new string("NoName");
            url = new string("NoUrl");
            description = new string("NoDescription");
            ip = new string("NoIp");
        }
        public Website(string name, string url, string description, string ip)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ip = ip;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetUrl()
        {
            return url;
        }
        public void SetUrl(string url)
        {
            this.url = url;
        }

        public string GetDescription()
        {
            return description;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetIp()
        {
            return ip;
        }
        public void SetIp(string ip)
        {
            this.ip = ip;
        }

        public void input()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Url: ");
            url = Console.ReadLine();

            Console.Write("Description: ");
            description = Console.ReadLine();

            Console.Write("Ip: ");
            ip = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine($"\nName: {name} || Url: {url} || Description: {description} || Ip: {ip}\n");
        }
    }
}
