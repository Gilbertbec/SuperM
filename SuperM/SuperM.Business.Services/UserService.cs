namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserService
    {
        private SuperMContext _context;

        public UserService()
        {
            _context = new SuperMContext();
        }

        public List<User> GetUserList()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User GetUserById(int userId)
        {
            User user = _context.Users.FirstOrDefault(x => x.UserId == userId);
            return user;
        }

        public List<User> GetUserByName(string name)
        {
            List<User> user = _context.Users.Where(x => x.Name.Contains(name)).Select(x => x).ToList();
            return user;
        }

        public User GetUserByNameForLogin(string name)
        {
            User user = _context.Users.First(x => x.Name == name);
            return user;
        }

        public bool IsNameExisted(string name)
        {
            //bool isNameExisted = false;
            //isNameExisted = (_context.Users.Any(x => x.Name == name) > 0);
            return _context.Users.Any(x => x.Name.Equals(name, StringComparison.Ordinal));
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUserById(int userId)
        {
            User user = GetUserById(userId);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void UpdateUserByUser(User user)
        {
            var User = GetUserById(user.UserId);
            if (User != null)
            {
                User.UserId = user.UserId;
                User.Name = user.Name;
                User.Password = user.Password;
            }
            _context.SaveChanges();
        }
    }
}
