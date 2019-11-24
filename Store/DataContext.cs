using japan_dashboard_api.Models;
using Microsoft.EntityFrameworkCore;

namespace japan_dashboard_api.Store
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Prefecture> Prefectures { get; }
    public DbSet<PrefecturePopulation> prefecturePopulations { get; }

  }
}