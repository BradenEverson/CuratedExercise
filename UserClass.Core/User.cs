using ExerciseCuration.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserClass.Core
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public gender gender { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public difficulty difficulty { get; set; }
    }
    public enum gender
    {
        male,
        female,
        other
    }
}
