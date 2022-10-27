using System;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E32
    {
        public static Dictionary<Object, Object> ConcatenaArrayList(Dictionary<Object, Object> Dic1, Dictionary<Object, Object> Dic2)
        {
            Dictionary<Object, Object> Dic3 = new Dictionary<Object, Object>();

            foreach (KeyValuePair<Object, Object> de in Dic1)
                Dic3.Add(de.Key, de.Value);

            foreach (KeyValuePair<Object, Object> de in Dic2)
                if (!Dic3.ContainsKey(de.Key))
                    Dic3.Add(de.Key, de.Value);
            return Dic3;
        }
    }
}
