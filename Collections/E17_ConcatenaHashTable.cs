using System;
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E17
    {
        public static Hashtable ConcatenaHashtable(Hashtable HT1, Hashtable HT2)
        {
            Hashtable HT3 = new Hashtable();
            foreach (DictionaryEntry element in HT1)
                HT3.Add(element.Key, element.Value);
            foreach (DictionaryEntry element in HT2)
                HT3.Add(element.Key, element.Value);
            return HT3;
        }
    }
}
