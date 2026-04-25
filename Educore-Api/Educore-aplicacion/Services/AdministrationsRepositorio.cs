using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AdministrationService
{
    private readonly UnitOfWork unitOfWork;

    public AdministrationService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<administration>> GetAllAsync()
    {
        return await unitOfWork.Administrations.GetAllAsync();
    }

    public async Task<administration> GetByIdAsync(int id)
    {
        return await unitOfWork.Administrations.GetByIdAsync(id);
    }

    public async Task AddAsync(administration admin)
    {
        await unitOfWork.Administrations.AddAsync(admin);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(administration admin)
    {
        await unitOfWork.Administrations.UpdateAsync(admin);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Administrations.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}