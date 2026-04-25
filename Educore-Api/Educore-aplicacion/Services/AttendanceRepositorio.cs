using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;

public class AttedanceService
{
    private readonly UnitOfWork unitOfWork;

    public AttedanceService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<attedance>> GetAllAsync()
    {
        return await unitOfWork.Attendances.GetAllAsync();
    }

    public async Task<attedance> GetByIdAsync(int id)
    {
        return await unitOfWork.Attendances.GetByIdAsync(id);
    }

    public async Task AddAsync(attedance attedance)
    {
        await unitOfWork.Attendances.AddAsync(attedance);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(attedance attedance)
    {
        await unitOfWork.Attendances.UpdateAsync(attedance);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Attendances.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}