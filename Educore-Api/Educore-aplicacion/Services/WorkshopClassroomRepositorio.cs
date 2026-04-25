using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;

public class WorkshopService
{
    private readonly UnitOfWork unitOfWork;

    public WorkshopService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<Workshop>> GetAllAsync()
    {
        return await unitOfWork.Workshops.GetAllAsync();
    }

    public async Task<Workshop> GetByIdAsync(int id)
    {
        return await unitOfWork.Workshops.GetByIdAsync(id);
    }

    public async Task AddAsync(Workshop workshop)
    {
        await unitOfWork.Workshops.AddAsync(workshop);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(Workshop workshop)
    {
        await unitOfWork.Workshops.UpdateAsync(workshop);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Workshops.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}