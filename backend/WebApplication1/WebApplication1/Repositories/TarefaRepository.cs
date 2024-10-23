using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private List<Tarefa> _tarefas = new List<Tarefa>();

        public List<Tarefa> GetAll()
        {
            return _tarefas;
        }

        public Tarefa GetById(int id)
        {
            return _tarefas.FirstOrDefault(t => t.Id == id);
        }

        public void Add(Tarefa tarefa)
        {
            tarefa.Id = _tarefas.Count + 1; // Gera um novo ID
            _tarefas.Add(tarefa);
        }

        public void Update(Tarefa tarefa)
        {
            var tarefaExistente = GetById(tarefa.Id);
            if (tarefaExistente != null)
            {
                tarefaExistente.Titulo = tarefa.Titulo;
                tarefaExistente.Descricao = tarefa.Descricao;
            }
        }

        public void Delete(int id)
        {
            var tarefa = GetById(id);
            if (tarefa != null)
            {
                _tarefas.Remove(tarefa);
            }
        }
    }
}
