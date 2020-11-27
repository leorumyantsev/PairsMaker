using System;
using System.Collections.Generic;

namespace PairsMaker.Models
{
    public class PairsCreator
    {
        public IList<Pair> CreatePairs(IList<Member> defaultMembers)
        {
            var members = new List<Member>(defaultMembers);

            var random = new Random();

            var pairs = new List<Pair>();

            while (true)
            {
                var pair = new Pair();
                if (members.Count > 0)
                {
                    var firstMemberIndex = random.Next(members.Count);
                    pair.FirstMemberIndex = firstMemberIndex;
                    pair.FirstMember.Name = members[firstMemberIndex].Name;
                    members.RemoveAt(firstMemberIndex);

                    if (members.Count > 0)
                    {
                        var secondMemberIndex = random.Next(members.Count);
                        pair.SecondMemberIndex = secondMemberIndex;
                        pair.SecondMember.Name = members[secondMemberIndex].Name;
                        members.RemoveAt(secondMemberIndex);
                    }

                    pairs.Add(pair);
                }
                else
                {
                    break;
                }
            }

            return pairs;
        }
    }
}