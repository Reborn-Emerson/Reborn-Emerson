 
using System;
using System.Collections.Generic;
using appSeries.Interfaces;


namespace appSeries

{
    public class SerieRepositorio : Interfaces.IRepositorio<Serie>

    {
        private List<Serie> listaSerie = new List<Serie>();

        public SerieRepositorio()
        {
        }

        public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}