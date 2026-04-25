using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;

public class PaymentService
{
    private readonly UnitOfWork unitOfWork;

    public PaymentService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<payment>> GetAllAsync()
    {
        return await unitOfWork.Payments.GetAllAsync();
    }

    public async Task<payment> GetByIdAsync(int id)
    {
        return await unitOfWork.Payments.GetByIdAsync(id);
    }

    public async Task AddAsync(payment payment)
    {
        await unitOfWork.Payments.AddAsync(payment);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(payment payment)
    {
        await unitOfWork.Payments.UpdateAsync(payment);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Payments.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}