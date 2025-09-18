using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3408 : IProblem
    {
        public bool Test()
        {
            var tasks = new List<IList<int>>{ new List<int> { 1, 101, 1  }, new List<int> { 2, 102, 20  }, new List<int> { 3, 103, 15 } };
            var taskManager = new TaskManager(tasks);
            taskManager.Add(4, 104, 5);
            taskManager.Edit(102, 0);
            if (taskManager.ExecTop() != 3)
                return false;
            taskManager.Rmv(101);
            taskManager.Add(5, 105, 15);
            if (taskManager.ExecTop() != 5)
                return false;

            return true;
        }

        public class TaskManager
        {
            private readonly Dictionary<int, (int UserId, int Priority)> _priorities;
            private readonly PriorityQueue<int, (int Priority, int TaskId)> _tasks;

            public TaskManager(IList<IList<int>> tasks)
            {
                _priorities = new();
                _tasks = new();
                foreach (var task in tasks)
                {
                    _priorities[task[1]] = (task[0], task[2]);
                    _tasks.Enqueue(task[0], (-task[2], -task[1]));
                }
            }

            public void Add(int userId, int taskId, int priority)
            {
                _priorities[taskId] = (userId, priority);
                _tasks.Enqueue(userId, (-priority, -taskId));
            }

            public void Edit(int taskId, int newPriority)
            {
                var userId = _priorities[taskId].UserId;
                _priorities[taskId] = (userId, newPriority);
                _tasks.Enqueue(userId, (-newPriority, -taskId));
            }

            public void Rmv(int taskId)
            {
                _priorities.Remove(taskId);
            }

            public int ExecTop()
            {
                while (_tasks.TryPeek(out _, out var p) && (!_priorities.ContainsKey(-p.TaskId) || _priorities[-p.TaskId].Priority != -p.Priority))
                    _tasks.Dequeue();
                if (_tasks.TryPeek(out var userId, out var prio))
                {
                    Rmv(-prio.TaskId);
                    return userId;
                }

                return -1;
            }
        }
    }
}
