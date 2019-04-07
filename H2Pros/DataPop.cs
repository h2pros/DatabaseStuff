using H2Pros.Data;
using H2Pros.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H2Pros
{
    public class DataPop
    {
        public static void main(String[] args) {

            UserContext uc = new UserContext();
            
            User users = new User{cpr = 1234, name = "shsh", age = 12};

            uc.Add(users);
            uc.SaveChanges();
        }
        
    }
}
