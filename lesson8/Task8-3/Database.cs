using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task8_3
{
    class DataBase
    {
        string fileName;
        List<Question> list;
        public string FileName { set => fileName = value; }

        public int Count { get => list.Count; }

        public Question this[int index] { get => list[index]; }

        public DataBase()
        {
            list = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            bool canDelete = (list != null && index < list.Count && index >= 0);

            if ( canDelete )
            {
                list.RemoveAt(index);
            }
        }

        public void Save( string fileName )
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load( string fileName )
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
    }
}
