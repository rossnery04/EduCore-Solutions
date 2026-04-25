using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;
public class AttendanceRepositorio
{
    private readonly Educore_Context context;

    public AttendanceRepositorio(Educore_Context context)
    {
        this.context = context;
    }
    public async Task<attedance> GetByIdAsync(int id)
    {
        return await context.Set<attedance>().FindAsync(id);
    }
    public async Task<List<attedance>> GetAllAsync()
    {
        return await context.attendances
            .Include(a => a.Resgistrations)
            .ToListAsync();
    }

    public async Task AddAsync(attedance att)
    {
        context.attendances.Add(att);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(attedance att)
    {
        context.attendances.Update(att);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var att = await context.attendances.FindAsync(id);

        if (att != null)
        {
            context.attendances.Remove(att);
            await context.SaveChangesAsync();
        }

    }
}