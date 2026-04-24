using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;

namespace Ifraestructura_educore.Repositorios
{
    public class WorkshopClassroomRepositorio
    {
        private readonly Educore_Context context;

        public WorkshopClassroomRepositorio(Educore_Context context)
        {
            this.context = context;
        }

        public async Task<List<workshopClassroom>> GetAllAsync()
        {
            return await context.Set<workshopClassroom>().ToListAsync();
        }

        public async Task AddAsync(workshopClassroom wc)
        {
            context.Set<workshopClassroom>().Add(wc);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(workshopClassroom wc)
        {
            context.Set<workshopClassroom>().Update(wc);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var wc = await context.Set<workshopClassroom>().FindAsync(id);

            if (wc != null)
            {
                context.Set<workshopClassroom>().Remove(wc);
                await context.SaveChangesAsync();
            }
        }
    }
}