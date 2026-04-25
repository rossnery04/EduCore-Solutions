using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;

namespace Ifraestructura_educore.Repositorios
{
    public class ClassroomsRepositorio
    {
        private readonly Educore_Context context;

        public ClassroomsRepositorio(Educore_Context context)
        {
            this.context = context;
        }

        public async Task<List<Classrooms>> GetAllAsync()
        {
            return await context.Set<Classrooms>().ToListAsync();
        }

        public async Task<Classrooms> GetByIdAsync(int id)
        {
            return await context.Set<Classrooms>().FindAsync(id);
        }

        public async Task AddAsync(Classrooms classroom)
        {
            context.Set<Classrooms>().Add(classroom);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Classrooms classroom)
        {
            context.Set<Classrooms>().Update(classroom);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var classroom = await context.Set<Classrooms>().FindAsync(id);

            if (classroom != null)
            {
                context.Set<Classrooms>().Remove(classroom);
                await context.SaveChangesAsync();
            }
        }
    }
}