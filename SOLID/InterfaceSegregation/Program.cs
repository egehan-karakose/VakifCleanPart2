using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir uygulamadaki her işlev, kendi sınırları içinde kullanılmalı ve erişilir olmalı.
             * 
             * Bir sınıf, bir interface'i implemente ediyor fakat implemente edilen metotlardan sadece birkaçı nesne tarafından kullanılıyor.
             */
        }

        public interface IMessage
        {
             string From { get; set; }
             string To { get; set; }
             string Subject { get; set; }
            
           
        }

        public interface IVideoMessage : IMessage
        {
            int VideoDuration { get; set; }
            string VideoFormat { get; set; }
        }

        public interface IImageMessage: IMessage
        {
            int ImageSize { get; set; }
        }

        public class TextMessage : IMessage
        {
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        public class VideoMessage : IVideoMessage
        {
            public int VideoDuration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string VideoFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
    }
}
