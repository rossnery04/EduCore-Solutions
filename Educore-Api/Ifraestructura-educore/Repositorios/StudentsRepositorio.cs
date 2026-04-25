using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;

public class StudentsRepositorio
{
    private readonly Educore_Context context;

    public StudentsRepositorio(Educore_Context context)
    {
        this.context = context;
    }

    public async Task<Students> GetByIdAsync(int id)
    {
        return await context.Set<Students>().FindAsync(id);
    }

    public async Task<List<Students>> GetAllAsync()
    {
        return await context.students
            .Include(s => s.Resgistrations)
            .ToListAsync();
    }

    public async Task AddAsync(Students student)
    {
        context.students.Add(student);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Students student)
    {
        context.students.Update(student);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var student = await context.students.FindAsync(id);

        if (student != null)
        {
            context.students.Remove(student);
            await context.SaveChangesAsync();
        }
    }
}