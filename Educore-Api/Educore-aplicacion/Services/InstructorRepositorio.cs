using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;

public class InstructorsService
{
    private readonly UnitOfWork unitOfWork;

    public InstructorsService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<instructors>> GetAllAsync()
    {
        return await unitOfWork.Instructors.GetAllAsync();
    }

    public async Task<instructors> GetByIdAsync(int id)
    {
        return await unitOfWork.Instructors.GetByIdAsync(id);
    }

    public async Task AddAsync(instructors instructor)
    {
        await unitOfWork.Instructors.AddAsync(instructor);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(instructors instructor)
    {
        await unitOfWork.Instructors.UpdateAsync(instructor);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Instructors.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}