using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data;

namespace ToDoList.Services
{
    public class ToDoServices
    {
        protected readonly ApplicationDbContext _dbContext;
        public ToDoServices(ApplicationDbContext _db)
        {
            _dbContext = _db;
        }
        public List<TodoItem> GetAll() 
        {
            return _dbContext.TodoTable.ToList();
        }
        public bool AddToDo(TodoItem todoItem)
        {
            _dbContext.TodoTable.Add(todoItem);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
