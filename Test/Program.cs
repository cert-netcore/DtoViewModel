using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using DtoViewModel.AttributeUtils;

namespace Test
{
    [DtoClass("testC")]
    class Program
    { 
        [DtoField("test")]
        public string a { get; set; }
        public static void Change<T1, T2>()
        {
            Console.WriteLine(typeof(T1));



        }

        static void Main(string[] args)
        {
            Program b = new Program();
            Type t = typeof(Program);
            object[] attrs = b.GetType().GetCustomAttributes(true);
            foreach (var attr in t.GetProperties())
            {
                var temp = attr.GetCustomAttributes(true);
            }
            var a = typeof(Program).GetCustomAttribute(typeof(DtoClassAttribute));
            var tm = a as DtoClassAttribute;

            Assembly asm = Assembly.GetAssembly(typeof(Program));
            Type[] types = asm.GetExportedTypes();

            Func<Attribute[], bool> IsMyAttribute = o =>
            {
                foreach (Attribute an in o)
                {
                    if (an is DtoClassAttribute)
                        return true;
                }
                return false;
            };
            Type[] cosType = types.Where(o => IsMyAttribute(Attribute.GetCustomAttributes(o, true))).ToArray();

            Change<Program,Program>();
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
