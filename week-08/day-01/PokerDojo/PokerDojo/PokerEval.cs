using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerDojo
{
    public class PokerEval
    {
        public enum Rank : int { T = 10, J, Q, K, A  };
        public string Evaluate(string[] black, string[] white)
        {
            if ( (GroupByRank(black, 5) != 0) || (GroupByRank(white, 5) != 0))
                return "Hiba";
            if (HasDuplicates(black, white))
                return "Hiba";
            return "";
        }

        int GroupByRank(string[] hand, int count)
        {
            return hand.GroupBy(c => c[0]).Count(g => g.Count() == count);
        }

        int GroupBySuit(string[] hand, int count)
        {
            return hand.GroupBy(c => c[1]).Count(g=>g.Count() == count);
        }

        bool HasDuplicates(string[] hand1, string[] hand2)
        {
            foreach (var card in hand1)
            {
                if (hand2.Contains(card))
                    return true;
            }
            return false;
        }

    }
}
