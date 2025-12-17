namespace _03Day_Notepad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SpellCheckerFactory factory = new SpellCheckerFactory();
            ISpellChecker somechecker = factory.GetSomeSpellChcker("");
            NotePad notepad = new NotePad(somechecker);
            notepad.Cut();
            notepad.Paste();
            notepad.SpellCheck();

            //HindiSpellChecker hindi = new HindiSpellChecker();
            //NotePad notePadforHINDI= new NotePad(hindi);
            //notePadforHINDI.Cut();
            //hindi.DoSpellCheck();


        }
    }

    public class NotePad
    {
        private ISpellChecker _checker;

        public NotePad(ISpellChecker checker)
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            if (checker == null)
            {
                _checker = factory.GetSomeSpellChcker("en");
            }
            else
            {
                _checker = checker;
            }
        }
        public void Cut()
        {
            Console.WriteLine("Text Cut functionality done");
        }
        public void Copy()
        {
            Console.WriteLine("Text Copy functionality done");
        }
        public void Paste()
        {
            Console.WriteLine("Text Paste functionality done");
        }

        public void SpellCheck()
        {
            _checker.DoSpellCheck();
        }



    }

    public class SpellCheckerFactory
    {
        private ISpellChecker _someChecker;

        public ISpellChecker GetSomeSpellChcker(String lang)
        {
            switch (lang)
            {
                case "en":
                    _someChecker = new EnglishSpellChecker();
                    break;
                case "gr":
                    _someChecker = new GermanSpellChecker();
                    break;
                case "sp":
                    _someChecker = new SpanishSpellChecker();
                    break;
                default:
                    _someChecker = new EnglishSpellChecker();
                    break;

            }
            return _someChecker;
        }


    }

    public interface ISpellChecker
    {
        void DoSpellCheck();
    }

    public class EnglishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            // Large functionality-- lots of code
            // Min-project
            Console.WriteLine("Speck Check done for English Text");
        }
    }
    public class GermanSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            // Large functionality-- lots of code
            // Min-project
            Console.WriteLine("Speck Check done for German Text");
        }
    }
    public class SpanishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            // Large functionality-- lots of code
            // Min-project
            Console.WriteLine("Speck Check done for Spanish Text");
        }
    }

    //public class HindiSpellChecker : ISpellChecker
    //{
    //    public void DoSpellCheck()
    //    {
    //        Console.WriteLine("Spell Check Done for Hindi Text");
    //    }
    //}

}