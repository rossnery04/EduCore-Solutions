using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AdministrationRepositorio
{
    private readonly Educore_Context context;

    public AdministrationRepositorio(Educore_Context context)
    {
        this.context = context;
    }

    // GET ALL
    public async Task<List<administration>> GetAllAsync()
    {
        return await context.Set<administration>().ToListAsync();
    }

    // GET BY ID 
    public async Task<administration> GetByIdAsync(int id)
    {
        return await context.Set<administration>().FindAsync(id);
    }

    // ADD
    public async Task AddAsync(administration admin)
    {
        await context.Set<administration>().AddAsync(admin);
        await context.SaveChangesAsync();
    }

    // UPDATE
    public async Task UpdateAsync(administration admin)
    {
        context.Set<administration>().Update(admin);
        await context.SaveChangesAsync();
    }

    // DELETE
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