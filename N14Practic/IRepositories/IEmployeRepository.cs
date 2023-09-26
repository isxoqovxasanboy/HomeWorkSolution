using N14Practic.Models;

namespace N14Practic.IRepositories;

public interface IEmployeRepository
{
    Employee? GetInfoByEmail(string email);

    IEnumerable<Employee> GetAll();

    bool Update(Employee employee);
    bool Delete(int employeeId);
}
