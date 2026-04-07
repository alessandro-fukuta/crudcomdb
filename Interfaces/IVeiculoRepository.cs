using crudcomdb.Models;

namespace crudcomdb.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<List<Veiculo>> Listar();
        Task<Veiculo?> BuscarPorId(int id);
        Task Salvar(Veiculo veiculo);
        Task Atualizar(Veiculo veiculo);
        Task Deletar(int id);
    }
}