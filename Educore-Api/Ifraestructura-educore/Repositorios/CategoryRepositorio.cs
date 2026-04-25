using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;
public class CategoryRepositorio
{
    private readonly Educore_Context context;

    public CategoryRepositorio(Educore_Context context)
    {
        this.context = context;
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        return await context.Set<Category>().FindAsync(id);
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await context.Set<Category>()
            .Include(c => c.Workshops)
            .ToListAsync();
    }

    public async Task AddAsync(Category cat)
    {
        context.Set<Category>().Add(cat);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Category cat)
    {
        context.Set<Category>().Update(cat);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var cat = await context.Set<Category>().FindAsync(id);

        if (cat != null)
        {
            context.Set<Category>().Remove(cat);
            await context.SaveChangesAsync();
        }
    }
}