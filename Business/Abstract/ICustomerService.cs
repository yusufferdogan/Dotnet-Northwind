using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICustomerService
{
    IResult Add(Customer customer);
    IResult Update(Customer customer);
    IResult Delete(Customer customer);
    IDataResult<List<Customer>> GetAll();
    IDataResult<Customer> GetById(string customerId);
    
    //MUST BE CUSTOMER DTO ?
    IDataResult<List<Customer>> GetAllByCompanyName(string companyName);
    IDataResult<List<Customer>> GetAllByContactName(string contactName);
    IDataResult<List<Customer>> GetAllByCity(string city);
    IDataResult<List<Customer>> GetAllByCountry(string country);
    IDataResult<List<Customer>> GetAllByPostalCode(string postalCode);
    IDataResult<List<Customer>> GetAllByRegion(string region);
    IDataResult<List<Customer>> GetAllByAddress(string address);
    IDataResult<List<Customer>> GetAllByPhone(string phone);
    IDataResult<List<Customer>> GetAllByFax(string fax);
    IDataResult<List<Customer>> GetAllByContactTitle(string contactTitle);
    IDataResult<List<Customer>> GetAllByCustomerId(string customerId);
}