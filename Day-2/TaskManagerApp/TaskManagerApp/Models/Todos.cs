using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManagerApp.Models
{
    public class Todos : IEnumerable<Todo>, IEnumerator<Todo>
    {
        private ArrayList list = new ArrayList();

        public void Add(string todoName)
        {
            var newId = this.Any() ? this.Max(t => t.Id) + 1 : 1;
            var newTodo = new Todo
                {
                    Id = newId,
                    Name = todoName,
                    CreatedOn = DateTime.Now,
                    IsCompleted = false
                };
            this.list.Add(newTodo);
        }

        public void Remove(int id)
        {
            var todoToRemove = this.First(t => t.Id == id);
            if (todoToRemove != null)
                list.Remove(todoToRemove);
        }

        public static Todos GetCurrent
        {
            get { return (Todos) HttpContext.Current.Session["todos"]; }
        }
        
        public IEnumerator<Todo> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private int index = -1;
        public bool MoveNext()
        {
            index++;
            if (index >= list.Count)
            {
                Reset();
                return false;
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public Todo Current { get { return (Todo) list[index]; } }

        object IEnumerator.Current
        {
            get { return GetCurrent; }
        }
    }
}