using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;

public class ResgistrationsService
{
    private readonly UnitOfWork unitOfWork;

    public ResgistrationsService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<Resgistrations>> GetAllAsync()
    {
        return await unitOfWork.Registrations.GetAllAsync();
    }

    public async Task<Resgistrations> GetByIdAsync(int id)
    {
        return await unitOfWork.Registrations.GetByIdAsync(id);
    }

    public async Task AddAsync(Resgistrations reg)
    {
        await unitOfWork.Registrations.AddAsync(reg);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(Resgistrations reg)
    {
        await unitOfWork.Registrations.UpdateAsync(reg);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Registrations.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}