namespace PairsMaker.Models
{
    public class Pair
    {
        public Pair()
        {
            Initializing();
        }

        public Member FirstMember { get; set; }

        public Member SecondMember { get; set; }

        private void Initializing()
        {
            FirstMember = new Member();
            SecondMember = new Member();
        }
    }
}