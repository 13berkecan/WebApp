using Microsoft.EntityFrameworkCore;

namespace WebApp.Database;

public class MysqlDataContext : DbContext
{
    public MysqlDataContext(DbContextOptions<MysqlDataContext> options) : base(options) { }
}