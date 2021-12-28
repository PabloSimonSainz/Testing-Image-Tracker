using Assets.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Rol{
        LIBRARIAN = 0,
        USER = 1
    }

    public class User
    {
        private int id;
        private String name;
        private String email;
        private String password;
        private String salt;
        private List<Rol> roles;
        private List<Book> rodeBooks;
        private List<Book> foundBooks;
        private List<Achievement> achievements;

        private String hash() // TODO
        {
            throw new NotImplementedException();
        }

        public bool checkPassword(String password)
        {
            throw new NotImplementedException();
        }
    }
}
