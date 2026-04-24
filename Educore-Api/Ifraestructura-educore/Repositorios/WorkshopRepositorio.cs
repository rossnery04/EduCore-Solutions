using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;

namespace Ifraestructura_educore.Repositorios
{
    public class WorkshopRepositorio
    {
        private readonly Educore_Context context;

        public WorkshopRepositorio(Educore_Context context) {

            this.context = context;
        }

        public async Task<List<Workshop>> GetAllWorkshopsAsync()
        {
            return await context.workshops
                .Include(w => w.Resgistrations)                // Relation with Enrollments
                    .ThenInclude(e => e.Students)        // Relat ion with Participant
                .Include(w => w.Resgistrations)
                .ToListAsync();
        }
        public async Task AddWorkshopAsync(Workshop workshop)
        {
            context.workshops.Add(workshop);
            await context.SaveChangesAsync();
        }
        public async Task UpdateWorkshopAsync(Workshop workshop)
        {
            context.workshops.Add(workshop);
            await context.SaveChangesAsync();
        }
        public async Task DeleteWorkshopAsync(int id)
        {
            var workshop = await context.workshops.FindAsync(id);

            if (workshop != null)
            {
                context.workshops.Remove(workshop);
                await context.SaveChangesAsync();
            }
        }

    }

}
