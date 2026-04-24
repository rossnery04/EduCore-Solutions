using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;
public class RegistrationsRepositorio
{
    private readonly Educore_Context context;

    public RegistrationsRepositorio(Educore_Context context)
    {
        this.context = context;
    }

    public async Task<List<Resgistrations>> GetAllAsync()
    {
        return await context.resgistrations
            .Include(r => r.Students)
            .Include(r => r.Workshop)
            .Include(r => r.Attedances)
            .Include(r => r.payments)
            .ToListAsync();
    }

    public async Task AddAsync(Resgistrations reg)
    {
        context.resgistrations.Add(reg);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Resgistrations reg)
    {
        context.resgistrations.Update(reg);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var reg = await context.resgistrations.FindAsync(id);

        if (reg != null)
        {
            context.resgistrations.Remove(reg);
            await context.SaveChangesAsync();
        }
    }
}