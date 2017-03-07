using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNFA
{
    enum NfaStateType
    {
        Normal = 1, TrailingHead = 2, Trailing = 3
    };
    class Nfa
    {

    }
    class NfaState
    {
        public int Index { get; private set; }
        public int SymbolIndex { get; set; }
        public NfaStateType StateType { get; set; }
        public ISet<int> CharClassTransition { get { return CharClassTransition; } }
        public IList<NfaState>
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
