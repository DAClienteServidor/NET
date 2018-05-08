using ClienteServ.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ClienteServ.Models
{
    public class UnitOfWork
    {
        public UnitOfWork()
        {
            this.context = new MyDbContext();
        }
        private readonly MyDbContext context;

        private GenericRepository<Users> UserRepository;
        public GenericRepository<Users> UsersRepository
        {
            get
            {
                if (this.UsersRepository == null)
                {
                    this.UserRepository = new GenericRepository<Users>(this.context);
                }
                return this.UsersRepository;
            }
        }

        private GenericRepository<Post> PostRepository;
        public GenericRepository<Post> PostsRepository
        {
            get
            {
                if (this.PostsRepository == null)
                {
                    this.PostRepository = new GenericRepository<Post>(this.context);
                }
                return this.PostsRepository;
            }
        }

        public async Task SaveChangesAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }

}