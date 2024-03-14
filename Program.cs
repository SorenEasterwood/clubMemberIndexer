namespace clubMemberIndexer
{
    internal class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++) 
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                MeetingDate = string.Empty;
                ClubLocation = string.Empty;
            }

            //indexer get and set methods
            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }
                    return tmp;
                }
                set
                {
                    if (index >= 0 && index <= Size -1)
                    {
                        Members[index] = value;
                    }
                }
}
        }
        static void Main(string[] args)
        {
            ClubMembers golf = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which Club member do you want to enter (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{Size}");
                }
                Console.WriteLine("Enter the name of the Club member");
                golf[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop == "q")
                    end = true;
            }

            Console.WriteLine("What kind of Club is it?");
            golf.ClubType = Console.ReadLine();
            Console.WriteLine("Where is the club located?");
            golf.ClubLocation = Console.ReadLine();
            Console.WriteLine("What date will they meet?");
            golf.MeetingDate = Console.ReadLine();

            Console.WriteLine("Here is the club information");
            Console.WriteLine("Members");
            for (int i = 0; i < Size; i++) 
            {
                if (golf[i] != string.Empty)
                    Console.WriteLine(golf[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Type: {golf.ClubType}");
            Console.WriteLine($"Location: {golf.ClubLocation}");
            Console.WriteLine($"Meeting Date: {golf.MeetingDate}");
        }
    }
}
