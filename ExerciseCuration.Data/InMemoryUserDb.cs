using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserClass.Core;

namespace ExerciseCuration.Data
{
    public class InMemoryUserDb : IUserData
    {
        readonly List<User> users;
        public InMemoryUserDb()
        {
            users = new List<User>()
            {
                new User{id=0}
            };
        }
        public User add(User user)
        {
            user.id = users.Max(r => r.id) + 1;
            users.Add(user);
            return user;
        }

        public int commit()
        {
            return 0;
        }

        public User delete(int id)
        {
            User user = users.FirstOrDefault(r => r.id == id);
            if(user != null)
            {
                users.Remove(user);
            }
            return user;
        }

        public User getById(int id)
        {
            User user = users.FirstOrDefault(r => r.id == id);
            if(user == null)
            {
                return null;
            }
            else
            {
                return user;
            }
        }

        public User update(User updatedUser)
        {
            User user = users.FirstOrDefault(r => r.id == updatedUser.id);
            if(user != null)
            {
                user.email = updatedUser.email;
                user.password = updatedUser.password;
                user.userName = updatedUser.userName;
                user.difficulty = updatedUser.difficulty;
            }
            return user;
        }
    }
}
