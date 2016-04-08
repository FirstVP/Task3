using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Reflection;


namespace Task3
{
    public class MySONFormatter<T> : IFormatter where T : class
    {
        const byte sizeOfPair = 2;
        const char equalitySymbol = '=';
        readonly char delimiter;
        public MySONFormatter(char delimiter = ':')
        {
            this.delimiter = delimiter;

        }
        public ISurrogateSelector SurrogateSelector { get; set; }
        public SerializationBinder Binder { get; set; }
        public StreamingContext Context { get; set; }




        public object Deserialize(Stream serializationStream)
        {
            {
                IList list;
                string[] buffer;
                string line;
                using (var currentReader = new StreamReader(serializationStream))
                {
                    var listType = typeof(List<>);
                    var certainListType = listType.MakeGenericType(typeof(T));
                    list = (IList)Activator.CreateInstance(certainListType);
                    while (currentReader.Peek() >= 0)
                    {

                        line = currentReader.ReadLine();
                        buffer = line.Split(equalitySymbol);
                        var currentObject = FormatterServices.GetUninitializedObject(Type.GetType(GetNamespace() + "." + buffer[1]));
                        var members = FormatterServices.GetSerializableMembers(currentObject.GetType(), Context);
                        object[] data = new object[members.Length];
                        for (int i = 0; i < members.Length; ++i)
                        {
                            line = currentReader.ReadLine();
                            buffer = line.Split(delimiter);
                            FieldInfo info = ((FieldInfo)members[i]);
                            data[i] = Convert.ChangeType(buffer[1], info.FieldType);
                        }

                        list.Add((T)FormatterServices.PopulateObjectMembers(currentObject, members, data));
                        line = currentReader.ReadLine();
                    }
                }
                return list;
            }
        }

        public void Serialize(Stream serializationStream, object graph)
        {

            string name;

            IEnumerable<string> headers;

            IEnumerable<string> data;

            using (var stream = new StreamWriter(serializationStream))
            {

                foreach (var item in (IEnumerable)graph)
                {

                    name = item.GetType().Name;
                    headers = GetObjectHeaders(item);
                    data = GetObjectValues(item);

                    WriteObjectData(name, headers, data, stream);

                }
                stream.Flush();
            }
        }

        private string[] GetValuesFromField(char separator, string tokens)
        {

            string[] result = new string[sizeOfPair];
            int position = tokens.IndexOf(separator);
            if (position != -1)
            {
                result[0] = tokens.Substring(0, position);
                result[1] = tokens.Substring(position + 1);
            }
            return result;
        }

        private IEnumerable<string> GetObjectHeaders(object item)
        {
            PropertyInfo[] heads = item.GetType().GetProperties();
            IEnumerable<string> result = heads.Select(element => element.Name.ToString());

            return result;
        }

        private IEnumerable<string> GetObjectValues(object item)
        {
            MemberInfo[] members = FormatterServices.GetSerializableMembers(item.GetType(), Context);
            object[] objects = FormatterServices.GetObjectData(item, members);
            IEnumerable<string> result = objects.Select(element => element.ToString());

            return result;
        }

        private void WriteObjectData(string name, IEnumerable<string> headers, IEnumerable<string> values, StreamWriter currentStream)
        {
            currentStream.WriteLine("Class" + equalitySymbol + name);

            for (int i = 0; i < headers.Count(); i++)
            {
                currentStream.WriteLine(headers.ElementAt(i) + delimiter + values.ElementAt(i));
            }

            currentStream.WriteLine("<=>");
        }

        private string GetNamespace()
        {
            string result;
            Type currentType = typeof(MySONFormatter<T>);
            result = currentType.Namespace;

            return result;
        }






    }
}