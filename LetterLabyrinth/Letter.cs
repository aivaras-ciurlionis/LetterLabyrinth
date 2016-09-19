namespace LetterLabyrinth
{
    public class Letter
    {
        private readonly string _letterName;
        private readonly int _letterPoints;

        public Letter(string letterName, int letterPoints)
        {
            _letterName = letterName;
            _letterPoints = letterPoints;
        }

        public int GetPoints()
        {
            return _letterPoints;
        }

        public string GetName()
        {
            return _letterName;
        }

        public static Letter Empty()
        {
            return new Letter("*", 0);
        }

    }
}