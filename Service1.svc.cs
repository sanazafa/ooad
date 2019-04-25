using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void registerUser(string userName, string password, string phoneNo)
        {
            
            User.userName.Add(userName);
            User.password.Add(password);
            User.phoneNo.Add(phoneNo);
            User.counter++;
        }
        public bool isValidUser(string userName, string password)
        {
            //User u2 = new User();
            for(int i = 0; i < User.counter; ++i)
            {
                if (User.userName[i] == userName && User.password[i] == password)
                {
                    return true;
                } 
        
            } return false;
        }
        //Roll

        public void addRoll(Roll roll)
        {
            User.addroll.Add(roll);
        }

        public List<Roll> getRolllist()
        {
            return User.addroll;
        }

        public Roll getRoll(int roll)
        {
            return User.addroll[roll];
        }


        //Goal
        public void addGoal(Goal goal)
        {
            User.addGoal.Add(goal);
        }
        public List<Goal> getGoallist()
        {
            return User.addGoal;
        }
        public Goal getGoal(int goal)
        {
            return User.addGoal[goal];
        }

        public void Deletegoal(int a)
        {
            User.addGoal.RemoveAt(a);
        }
        public void savegoal(Goal goal, int index)
        {
            User.addGoal.Insert(index, goal);
        }


        //delete
        public void Deleteroll(int a)
        {
            User.addroll.RemoveAt(a);
        }
        //savepost
        public void saveroll(Roll roll, int index)
        {
            //User.addroll.RemoveAt(index);
            User.addroll.Insert(index, roll);
        }

        //Todo
        public Todo getTodo(int todo)
        {
            return User.addtodo[todo];
        }
        public List<Todo> getTodolist()
        {
            return User.addtodo;

        }
        public void addTodo(Todo todo)
        {
            User.addtodo.Add(todo);
        }
        public void Deletetodo(int a)
        {
            User.addtodo.RemoveAt(a);
        }
        public void savetodo(Todo todo, int index)
        {
            User.addtodo.Insert(index, todo);
        }

        //reports


        public User getUser()
        {
            User user = new User();
            return user;
        }




        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Todo> GetDateTodo(string todo)
        {
            var todo_value = User.addtodo;
            List<Todo> items = new List<Todo>();

            foreach(var data in todo_value)
            {
                if(data.Date == todo)
                {
                    items.Add(data);
                }
            }

            return items;
        }
    }
}
