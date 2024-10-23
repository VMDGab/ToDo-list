using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Services.Interfaces
{
    public interface ITarefaService
    {
        List<Tarefa> GetAll();
        Tarefa GetById(int id);
        void Add(Tarefa tarefa);
        void Update(Tarefa tarefa);
        void Delete(int id);
    }
}
