using System.Collections.Generic;
using System.Text;
using Business.ValidationRules.FluentValidation;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using FluentValidation;


namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetById(int id);

        IDataResult<List<Brand>> GetAll();

        IResult Add(Brand brand);

        IResult Update(Brand brand);

        IResult Delete(Brand brand);
    }
}