using System;

namespace DependencyInveresion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bağımlılıklar -tersine çevrilebilir- bir biçimde tasarlanmalı.
             * Büyük sistemler küçüklere DEĞİL küçük sistemler büyüklere bağlı olmalı!
             *  Elektrik                        lamba 
             */

            MailSender mailSender = new MailSender();
            ReportGenerator reportGenerator = new ReportGenerator(mailSender);
            ReportGenerator wsReport = new ReportGenerator(new WhatsappSender());

            
            reportGenerator.Send();
            wsReport.Send();
        }


    }

    public class ReportGenerator
    {
        ISender sender;
        public ReportGenerator(ISender mailSender)
        {
            this.sender = mailSender;
        }

        public void Send()
        {
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi....");
        }
    }

    public class WhatsappSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");
        }
    }





}
