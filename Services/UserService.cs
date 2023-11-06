using LoginBlazor.Data;
using LoginBlazor.models;
using Microsoft.EntityFrameworkCore;

namespace LoginBlazor.Services
{
    public class UserService
    {
        private readonly MyDbContext _myDbContext;
        public UserService(MyDbContext MyDbContext)
        {
            _myDbContext = MyDbContext;
        }
        //add user
        public async Task<bool> AddUser(User User)
        {
            await _myDbContext.Users.AddAsync(User);
            await _myDbContext.SaveChangesAsync();
            return true;
        }
        //update user
        public async Task<bool>UpdateUser(User User)
        {
            _myDbContext.Users.Update(User);
            await _myDbContext.SaveChangesAsync();
            return true;
        }
        //delete user
        public async Task<bool>DeleteUser(User User)
        {
            _myDbContext.Users.Remove(User);
            await _myDbContext.SaveChangesAsync();
            return true;
        }
        //show users
        public async Task<List<User>> AllUsers()
        {
            return await _myDbContext.Users.ToListAsync();
        }
        public async Task<bool> AuthenticateUser(UserLogin Login)
        {
            var user = await _myDbContext.Users.FirstOrDefaultAsync(u => u.Login == Login.Login && u.Password == Login.Password);

            return user != null;
        }
    }
}
