using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

            public void Atualiza(int id, Serie objeto)
            {
                listaSerie[id] = objeto;
            }
            public void Exclui (int id)
            {
                listaSerie[id]. Excluir();
            }
            public void Insere (Serie objeto)
            {
                listaSerie.Add (objeto);
            }
            public Lista<Série> Lista()
            {
                return listaSerie;
            }
            public int ProximoId()
            {
                return listaSerie.Count;
            }
            public Serie RetornaId(int id)
            {
                return listaSerie[id];
            }
    }
}