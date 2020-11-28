using System.Collections.Generic;
using System.Collections.ObjectModel;
using PairsMaker.Models;

namespace PairsMaker.ViewModels
{
    public class PairsWindowViewModel
    {
        public PairsWindowViewModel(IList<Pair> pairs)
        {
            Initializing();

            FillMembersCollections(pairs);
        }

        public ObservableCollection<Member> FirstMembers { get; set; }

        public ObservableCollection<Member> SecondMembers { get; set; }

        private void Initializing()
        {
            FirstMembers = new ObservableCollection<Member>();
            SecondMembers = new ObservableCollection<Member>();
        }

        private void FillMembersCollections(IList<Pair> pairs)
        {
            foreach (var pair in pairs)
            {
                var firstMember = new Member()
                {
                    Name = pair.FirstMember.Name
                };

                FirstMembers.Add(firstMember);

                var secondMember = new Member()
                {
                    Name = pair.SecondMember.Name
                };

                SecondMembers.Add(secondMember);
            }
        }
    }
}