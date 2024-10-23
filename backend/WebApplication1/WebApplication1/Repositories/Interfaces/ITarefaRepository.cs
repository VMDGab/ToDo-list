using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Repositories.Interfaces
{
    public interface ITarefaRepository
    {
        List<Tarefa> GetAll(); // Lista todas as tarefas
        Tarefa GetById(int id); // Busca uma tarefa pelo ID
        void Add(Tarefa tarefa); // Adiciona uma nova tarefa
        void Update(Tarefa tarefa); // Atualiza uma tarefa existente
        void Delete(int id); // Deleta uma tarefa
    }
}
