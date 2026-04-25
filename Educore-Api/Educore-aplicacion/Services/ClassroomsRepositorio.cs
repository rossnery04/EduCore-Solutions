using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;

public class ClassroomsService
{
    private readonly UnitOfWork unitOfWork;

    public ClassroomsService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<Classrooms>> GetAllAsync()
    {
        return await unitOfWork.Classrooms.GetAllAsync();
    }

    public async Task<Classrooms> GetByIdAsync(int id)
    {
        return await unitOfWork.Classrooms.GetByIdAsync(id);
    }

    public async Task AddAsync(Classrooms classroom)
    {
        await unitOfWork.Classrooms.AddAsync(classroom);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(Classrooms classroom)
    {
        await unitOfWork.Classrooms.UpdateAsync(classroom);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Classrooms.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}