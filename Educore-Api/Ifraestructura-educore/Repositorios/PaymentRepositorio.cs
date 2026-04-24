using Domain_educore.Entidades;
using Ifraestructura_educore.Data;
using Microsoft.EntityFrameworkCore;
public class PaymentRepositorio
{
    private readonly Educore_Context context;

    public PaymentRepositorio(Educore_Context context)
    {
        this.context = context;
    }

    public async Task<List<payment>> GetAllAsync()
    {
        return await context.Set<payment>()
            .Include(p => p.Resgistrations)
            .ToListAsync();
    }

    public async Task AddAsync(payment pay)
    {
        context.Set<payment>().Add(pay);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(payment pay)
    {
        context.Set<payment>().Update(pay);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var pay = await context.Set<payment>().FindAsync(id);

        if (pay != null)
        {
            context.Set<payment>().Remove(pay);
            await context.SaveChangesAsync();
        }
    }
}