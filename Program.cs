using System;
using System.Xml;

namespace csharp_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load("../../Users.xml");
                var userList = document.SelectSingleNode("UserList");
                for (int i = 0; i < userList.ChildNodes.Count; i++)
                {
                    var user = userList.ChildNodes[i];
                    Console.WriteLine("User Found :");
                    for (int j = 0; j < user.ChildNodes.Count; j++)
                    {
                        var tag = user.ChildNodes[j];
                        Console.WriteLine(String.Format("\t{0} : {1}", tag.Name, tag.InnerText));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
