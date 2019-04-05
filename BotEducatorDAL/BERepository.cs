using BotEducatorDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BotEducatorDAL
{
    public class BERepository
    {
        private readonly BotEducatorContext _context;
        public BERepository()
        {
            _context = new BotEducatorContext();
        }

        public BERepository(BotEducatorContext context)
        {
            _context = context;
        }

        public Users GetUser(string email)
        {
            var user = (from u in _context.Users where u.EmailId == email select u).FirstOrDefault();
            return user;
        }

        public bool AddUser(string uname, string emId, string pwd)
        {
            bool status = false;
            Users user = new Users();
            user.UserName = uname;
            user.EmailId = emId;
            user.Password = pwd;
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
    }
}
