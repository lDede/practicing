using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E20
    {
        public static SortedList ConcatenaSortedList(SortedList SL1, SortedList SL2)
        {
            SortedList SL3 = new SortedList();
            foreach (DictionaryEntry de in SL1)
                SL3.Add(de.Key, de.Value);

            foreach (DictionaryEntry de in SL2)
                if (!SL3.ContainsKey(de.Key))
                    SL3.Add(de.Key, de.Value);

            return SL3;
        }
    }
}
