namespace _03Day_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
            Console.WriteLine("1-> PDF 2-> DOCX 3-> EXCEL 4-> XML");
            int ch = Convert.ToInt32(Console.ReadLine ());

            ReportFactory factory = new ReportFactory();
            Report report = factory.GetSomeReport(ch);
            report.GenerateReport();

            Console.WriteLine("Do you want to continue? 'y/n'");
            string ynChoice = Console.ReadLine();

            if (ynChoice == "n")
            {
                break;
            }
            }
        }
    }
    public class ReportFactory
    {
        public Report GetSomeReport(int choice)
        {
            Report someReport = null;
            switch (choice)
            {
                case 1:
                    someReport = new Pdf();
                    break;
                case 2:
                    someReport = new Docx();
                    break;
                case 3:
                    someReport = new Excel();
                    break;
                case 4:
                    someReport = new XML();
                    break;
                default:
                    someReport = null;
                    break;
            }
            return someReport;
        }
    }
    public abstract class Report
    {
        public abstract void parse();
        public abstract void validate();
        public abstract void save();

        public virtual void GenerateReport()
        {
            parse();
            validate();
            save();
            Console.WriteLine("Report Generated");
        }

    }

    public abstract class specialReport :Report
    {
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            parse();
            validate();
            save();
            ReValidate();
            Console.WriteLine("Special Report Generated");
        }
    }

    public class XML : specialReport
    {
        public override void parse()
        {
            Console.WriteLine("XML PARSED");
        }

        public override void validate()
        {
            Console.WriteLine("XML VALIDATED");
        }

        public override void save()
        {
            Console.WriteLine("XML SAVE");
        }

        
            protected override void ReValidate()
        {
            // Some code to parse PDF
            Console.WriteLine("XML Re-Validated.");
        
    }

    }

    public class Pdf:Report
    {
        public override void parse()
        {
            Console.WriteLine("PDF PARSED");       
        }

        public override void validate()
        {
            Console.WriteLine("PDF VALIDATED");
        }

        public override void save()
        {
            Console.WriteLine("PDF SAVE");
        }

    }

    public class Docx : Report
    {
        public override void parse()
        {
            Console.WriteLine("Docx PARSED");
        }

        public override void save()
        {
            Console.WriteLine("Docx Save");
        }

        public override void validate()
        {
            Console.WriteLine("Docx validate");
        }
    }
    public class Excel : Report
    {
        public override void parse()
        {
            Console.WriteLine("Excel PARSED");
        }

        public override void save()
        {
            Console.WriteLine("Excel Save");
        }

        public override void validate()
        {
            Console.WriteLine("Excel validate");
        
        }
    }
}