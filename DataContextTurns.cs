using clinic.Entities;

namespace clinic
{
    public class DataContextTurns : IDataContextTurns
    {
        public List<Turn> Turns { get; set ; }

        public DataContextTurns()
        {
            Turns = new List<Turn> { new Turn { Code=1,DrId=2,PId=1,Date=DateTime.Now},
                                                                 new Turn { Code=2,DrId=3,PId=2,Date=DateTime.Now},
                                                                 new Turn { Code=3,DrId=1,PId=3,Date=DateTime.Now}};


        }

    }
}
