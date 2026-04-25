using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;
public class InstructorsRepositorio
{
    private readonly Educore_Context context;

    public InstructorsRepositorio(Educore_Context context)
    {
        this.context = context;
    }

    public async Task<List<instructors>> GetAllAsync()
    {
        return await context.Instructors
            .Include(i => i.Workshops)
            .ToListAsync();
    }
    public async Task<instructors> GetByIdAsync(int id)
    {
        return await context.Set<instructors>().FindAsync(id);
    }
    public async Task AddAsync(instructors instructor)
    {
        context.Instructors.Add(instructor);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(instructors instructor)
    {
        context.Instructors.Update(instructor);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var instructor = await context.Instructors.FindAsync(id);

        if (instructor != null)
        {
            context.Instructors.Remove(instructor);
            await context.SaveChangesAsync();
        }
    }
}