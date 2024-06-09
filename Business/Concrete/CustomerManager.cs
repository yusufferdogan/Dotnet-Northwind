using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete;

public class CustomerManager : ICustomerService
{
    private readonly ICustomerDal _customerDal;
    
    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }
    
    public IResult Add(Customer customer)
    {
        _customerDal.Add(customer);
        return new SuccessResult(Messages.CustomerAdded);
    }

    public IResult Update(Customer customer)
    {
        _customerDal.Update(customer);
        return new SuccessResult(Messages.CustomerUpdated);
    }

    public IResult Delete(Customer customer)
    {
        _customerDal.Delete(customer);
        return new SuccessResult(Messages.CustomerDeleted);
    }

    public IDataResult<List<Customer>> GetAll()
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
    }

    public IDataResult<Customer> GetById(string customerId)
    {
        return new SuccessDataResult<Customer>(_customerDal.Get(p => customerId == p.CustomerId));
    }

    public IDataResult<List<Customer>> GetAllByCompanyName(string companyName)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => companyName == p.CompanyName));
    }

    public IDataResult<List<Customer>> GetAllByContactName(string contactName)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => contactName == p.ContactName));
    }

    public IDataResult<List<Customer>> GetAllByCity(string city)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => city == p.City));
    }

    public IDataResult<List<Customer>> GetAllByCountry(string country)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => country == p.Country));
    }

    public IDataResult<List<Customer>> GetAllByPostalCode(string postalCode)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => postalCode == p.PostalCode));
    }

    public IDataResult<List<Customer>> GetAllByRegion(string region)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => region == p.Region));
    }

    public IDataResult<List<Customer>> GetAllByAddress(string address)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => address == p.Address));
    }

    public IDataResult<List<Customer>> GetAllByPhone(string phone)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => phone == p.Phone));
    }

    public IDataResult<List<Customer>> GetAllByFax(string fax)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => fax == p.Fax));
    }

    public IDataResult<List<Customer>> GetAllByContactTitle(string contactTitle)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => contactTitle == p.ContactTitle));
    }

    public IDataResult<List<Customer>> GetAllByCustomerId(string customerId)
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => customerId == p.CustomerId));
    }
}