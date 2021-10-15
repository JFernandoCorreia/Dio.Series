using System;

namespace Dio.Series
{
        public class Series : EntidadeBase
        {
            
                private Genero Genero { get; set; }

                private string Titulo { get; set; }

                private string Descricao { get; set; }

                private int Ano { get; set; }

                private bool Excluido { get;  set; }

        public Serie (int id, Genero genero, string titulo, string descricao, int ano)
            {
                this.Id = id;
                this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descriaoo;
                this.Ano = ano;
                this.Excluido = false;

            }
        public override string ToString()
            {
            string retorno = "";

                retorno += "Gênero: " + this.Genero + Environment.NewLine;
                retorno += "Título: " + this.Titulo + Environment.NewLine;
                retorno += "Descrição: " + this.Descricao + Environment.NewLine;
                retorno += "Ano de Início : " + this.Ano + Environment.NewLine;
                retorno += "Excluído: " + this.Excluido;

                return retorno;
            }
        public string retornaTitulo()
        {
                return this.Id;
        }
        public int retornaId()
        {
                return this.Id;
        }
        public bool retornaExcluido()
        {
                return this.Excluido;
        }
        public void Excluir()
        {
                this.Excluido = true;
        }
    }
}       