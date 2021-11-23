using System;

namespace usingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            DataWriter dataWriter = new DataWriter();
            dataWriter.WriteDataToSource("", new APIDataSource());
        }
    }

    public abstract class DataSource
    {

        public abstract void ReadData(string path);

        public void Transfer(string from, string to)
        {
            Console.WriteLine("Transfer edildi");
        }
    }

    public interface IWritableResouce
    {
        void WriteData(string data);
    }

    public class XmlDataSource : DataSource
    {
        public override void ReadData(string path)
        {
            throw new NotImplementedException();
        }


    }

    public class APIDataSource : DataSource, IWritableResouce
    {
        public override void ReadData(string path)
        {
            throw new NotImplementedException();
        }

        public void WriteData(string data)
        {
            throw new NotImplementedException();
        }
    }

  
    public class DbDataSource : DataSource, IWritableResouce
    {
        public override void ReadData(string path)
        {
            throw new NotImplementedException();
        }

        public void WriteData(string data)
        {
            throw new NotImplementedException();
        }
    }

    public class DataWriter
    {
        public void WriteDataToSource(string data, IWritableResouce dataSource)
        {
            dataSource.WriteData(data);
        }
    }
}
