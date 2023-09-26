using N14Practic.IRepositories;
using N14Practic.Models;

namespace N14Practic.Repositories;

public class BaseRepository : IEmployeRepository
{
    List<Employee> employees = new List<Employee>();

    public bool Create(Employee employee)
    {
        if (employee is null)
        {
            return false;
        }
        else
        {
            employees.Add(employee);
            return true;
        }
    }

    public bool Delete(int employeeId)
    {
        if (employeeId > employees.Count)
        {
            return false;
        }
        else
        {
            employees.RemoveAt(employeeId);
            return true;
        }
    }

    public IEnumerable<Employee> GetAll()
    {
        return employees;
    }

    public Employee? GetInfoByEmail(string email)
    {
        if (email == null)
        {
            return null;
        }
        else
        {
            var searEmploye = employees.Find(searchWithEmail => searchWithEmail.Email.Equals(email));
            if (searEmploye is not null)
            {
                return searEmploye;

            }
            else
            {
                return null;
            }
        }
    }

    public bool Update(Employee employee)
    {
        if (employee is null)
        {
            return false;
        }
        else
        {
            var foundEmployee = employees.Find(item => item.Id.Equals(employee.Id));

            if (foundEmployee is not null)
            {
                employees.Remove(foundEmployee);
                foundEmployee.FirstName = employee.FirstName;
                foundEmployee.LastName = employee.LastName;
                foundEmployee.Email = employee.Email;
                foundEmployee.AddressEmployee = employee.AddressEmployee;
                employees.Add(foundEmployee);
                foundEmployee = null;
                return true;
            }
            else
            {
                return false;
            }
        }


    }


}
