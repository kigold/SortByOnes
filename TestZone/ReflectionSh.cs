using System;
using System.Reflection;
using System.Collections.Generic;

namespace TestZone
{
    public static class ReflectionSh
    {

        public static void GetClassProps<T>()
        {
            var mainObjproperties = typeof(T).GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);

            var mainObjInstance = Activator.CreateInstance<T>();

            foreach (var prop in mainObjproperties)
            {
                Console.WriteLine(prop.Name);
                Type listItemType = prop.PropertyType.GetGenericArguments()[0];
                var listItemProperties = listItemType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);


                //Instantiate the fields of the Object, that is instantiate the lists fields of the obj
                var listType = typeof(List<>);
                var constructedListType = listType.MakeGenericType(listItemType);
                var listInstance = Activator.CreateInstance(constructedListType);
                prop.SetValue(mainObjInstance, listInstance);

                foreach (var listItemProp in listItemProperties)
                {
                    Console.WriteLine(listItemProp.Name);
                }
            }
        }
    }

    public class MultipleReportModel
    {
        public List<TypeA> PropA { get; set; }
        public List<TypeB> PropB { get; set; }
    }

    public class TypeB
    {
        public int Id { get; set; }
        public string Zone { get; set; }
    }

    public class TypeA
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
