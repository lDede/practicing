using System;

namespace AED_LetsMakeAnAED
{
    #region Classe CCelula - representa a célula utilizada pelas classes CLista, CFila e CPilha
    /// <summary>
    /// Classe utilizada pelas classes CLista, CFila e CPilha
    /// </summary>
    class CCelula
    {
        public Object Item;  // O Item armazenado pela célula
        public CCelula Prox; // Referencia a próxima célula (do mesmo tipo)

        /// <summary>
        /// Instância da classe CCelula
        /// </summary>
        public CCelula()
        {
            Item = null;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma instância de CCelula atribuindo um valor para o Item.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula.</param>
        public CCelula (object ValorItem)
        {
            Item = ValorItem;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma instância de CCelula atribuindo um valor para o Item e referenciando a próxima célula
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula.</param>
        /// <param name="ProxCelula">Referência para a próxima célula.</param>
        public CCelula(object ValorItem, CCelula ProxCelula)
        {
            Item = ValorItem;
            Prox = ProxCelula;
        }
    }
    #endregion

}
