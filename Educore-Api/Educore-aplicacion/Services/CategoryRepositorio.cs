using Domain_educore.Entidades;
using Ifraestructura_educore.UnitOfWork;

public class CategoryService
{
    private readonly UnitOfWork unitOfWork;

    public CategoryService(UnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await unitOfWork.Categories.GetAllAsync();
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        return await unitOfWork.Categories.GetByIdAsync(id);
    }

    public async Task AddAsync(Category category)
    {
        await unitOfWork.Categories.AddAsync(category);
        await unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(Category category)
    {
        await unitOfWork.Categories.UpdateAsync(category);
        await unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await unitOfWork.Categories.DeleteAsync(id);
        await unitOfWork.SaveAsync();
    }
}