using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;
using WebApplication1.Services.Interfaces;
using System.Collections.Generic;

namespace WebApplication1.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public List<Tarefa> GetAll()
        {
            return _tarefaRepository.GetAll();
        }

        public Tarefa GetById(int id)
        {
            return _tarefaRepository.GetById(id);
        }

        public void Add(Tarefa tarefa)
        {
            _tarefaRepository.Add(tarefa);
        }

        public void Update(Tarefa tarefa)
        {
            _tarefaRepository.Update(tarefa);
        }

        public void Delete(int id)
        {
            _tarefaRepository.Delete(id);
        }
    }
}
