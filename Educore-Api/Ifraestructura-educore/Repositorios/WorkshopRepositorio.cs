using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class WorkshopRepositorio
{
    private readonly Educore_Context context;

    public WorkshopRepositorio(Educore_Context context)
    {
        this.context = context;
    }

    // GET ALL
    public async Task<List<Workshop>> GetAllAsync()
    {
        return await context.Set<Workshop>().ToListAsync();
    }

    // GET BY ID
    public async Task<Workshop> GetByIdAsync(int id)
    {
        return await context.Set<Workshop>().FindAsync(id);
    }

    // ADD
    public async Task AddAsync(Workshop workshop)
    {
        await context.Set<Workshop>().AddAsync(workshop);
        await context.SaveChangesAsync();
    }

    // UPDATE
    public async Task UpdateAsync(Workshop workshop)
    {
        context.Set<Workshop>().Update(workshop);
        await context.SaveChangesAsync();
    }

    // DELETE
    public async Task DeleteAsync(int id)
    {
        var workshop = await context.Set<Workshop>().FindAsync(id);

        if (workshop != null)
        {
            context.Set<Workshop>().Remove(workshop);
            await context.SaveChangesAsync();
        }
    }
}