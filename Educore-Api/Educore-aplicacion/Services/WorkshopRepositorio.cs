using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

public class WorkshopClassroomService
{
    private readonly UnitOfWork unitOfWork;

    public WorkshopClassroomService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<workshopClassroom>> GetAllAsync()
    {
        return await unitOfWork.WorkshopClassrooms.GetAllAsync();
    }

    public async Task<workshopClassroom> GetByIdAsync(int id)
    {
        return await unitOfWork.WorkshopClassrooms.GetByIdAsync(id);
    }

    public async Task AddAsync(workshopClassroom entity)
    {
        await unitOfWork.WorkshopClassrooms.AddAsync(entity);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(workshopClassroom entity)
    {
        await unitOfWork.WorkshopClassrooms.UpdateAsync(entity);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.WorkshopClassrooms.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}