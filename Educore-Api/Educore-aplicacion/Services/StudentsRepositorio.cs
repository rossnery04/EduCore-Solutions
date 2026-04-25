using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;

public class StudentsService
{
    private readonly UnitOfWork unitOfWork;

    public StudentsService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<Students>> GetAllAsync()
    {
        return await unitOfWork.Students.GetAllAsync();
    }

    public async Task<Students> GetByIdAsync(int id)
    {
        return await unitOfWork.Students.GetByIdAsync(id);
    }

    public async Task AddAsync(Students student)
    {
        await unitOfWork.Students.AddAsync(student);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(Students student)
    {
        await unitOfWork.Students.UpdateAsync(student);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Students.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}