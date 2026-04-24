using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;

public class AdministrationRepositorio
{
    private readonly Educore_Context context;

    public AdministrationRepositorio(Educore_Context context)
    {
        this.context = context;
    }

    public async Task<List<administration>> GetAllAsync()
    {
        return await context.Set<administration>().ToListAsync<administration>();
    }

    public async Task AddAsync(administration admin)
    {
        context.Set<administration>().Add(admin);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(administration admin)
    {
        context.Set<administration>().Update(admin);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var admin = await context.Set<administration>().FindAsync(id);

        if (admin != null)
        {
            context.Set<administration>().Remove(admin);
            await context.SaveChangesAsync();
        }
    }
}