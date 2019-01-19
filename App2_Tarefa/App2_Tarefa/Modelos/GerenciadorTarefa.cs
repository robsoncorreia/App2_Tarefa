using System;
using System.Collections.Generic;
using System.Text;

namespace App2_Tarefa.Modelos
{
    public class GerenciadorTarefa
    {
        public List<Tarefa> Lista { get; set; }


        public void Finalizar(int index, Tarefa tarefa)
        {
            Lista.RemoveAt(index);
            Lista.Add(tarefa);
            SalvarProperties(Lista);
        }
        public void Salvar(Tarefa tarefa)
        {
            Lista.Add(tarefa);

        }

        public void Remover(Tarefa tarefa)
        {
            Lista.Remove(tarefa);
            SalvarProperties(Lista);

        }
        public List<Tarefa> Listagem()
        {
            return null;
        }
        private void SalvarProperties(List<Tarefa> tarefas)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }
            App.Current.Properties.Add("Tarefas", Lista);
        }
        private List<Tarefa> ListagemProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                return (List<Tarefa>)App.Current.Properties["Tarefas"];
            }
            return new List<Tarefa>();
        }
    }
}
