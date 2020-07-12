using ExerciseCuration.Core;
using System;
using System.Collections.Generic;
using System.Text;
using UserClass.Core;

namespace ExerciseCuration.Data
{
    public interface IUserData
    {
        public User add(User user);
        public User delete(int id);
        public User getByEmail(string email);
        public User getById(int id);
        public User update(User updatedUser);
        public int commit();
    }
}