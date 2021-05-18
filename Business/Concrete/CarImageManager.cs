using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helper;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
   
        public class CarImageManager : ICarImageService
        {
               ICarImageDal _carImageDAL;
               IFileHelper _fileHelper;

            public CarImageManager(ICarImageDal carImageDAL,IFileHelper fileHelper)
            {
                _carImageDAL = carImageDAL;
                _fileHelper = fileHelper;
            }

            public IResult Add(IFormFile file, CarImage carImage)
            {
                var imageCount = _carImageDAL.GetAll(c => c.CarId == carImage.CarId).Count;

                if (imageCount >= 5)
                {
                    return new ErrorResult("One car must have 5 or less images");
                }

                var imageResult = _fileHelper.Upload(file);

                if (!imageResult.Success)
                {
                    return new ErrorResult(imageResult.Message);
                }
                carImage.ImagePath = imageResult.Message;
                _carImageDAL.Add(carImage);
                return new SuccessResult(Messages.CarImageAdded);
            }
           
            public IDataResult<CarImage> Get(int id)
            {
                return new SuccessDataResult<CarImage>(_carImageDAL.Get(c => c.CarImageId == id));
            }
            
            public IDataResult<List<CarImage>> GetAll()
            {
                return new SuccessDataResult<List<CarImage>>(_carImageDAL.GetAll());
            }
            
            
            public IDataResult<List<CarImage>> GetImagesByCarId(int id)
            {
                IResult result = BusinessRules.Run(CheckIfCarImageNull(id));

                if (result != null)
                {
                    return new ErrorDataResult<List<CarImage>>(result.Message);
                }

                return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(id).Data);
            }

        public IResult Delete(CarImage carImage)
        {
            var image = _carImageDAL.Get(c => c.CarImageId == carImage.CarImageId);
            if (image == null)
            {
                return new ErrorResult("Image not found");
            }
            _fileHelper.Delete(image.ImagePath);
            _carImageDAL.Delete(carImage);
            return new SuccessResult("Image was deleted successfully");
        }
        public IResult Update(IFormFile file, CarImage carImage)
        {
            var isImage = _carImageDAL.Get(c => c.CarImageId == carImage.CarImageId);
            if (isImage == null)
            {
                return new ErrorResult("Image not found");
            }

            var updatedFile = _fileHelper.Update(file, isImage.ImagePath);
            if (!updatedFile.Success)
            {
                return new ErrorResult(updatedFile.Message);
            }
            carImage.ImagePath = updatedFile.Message;
            _carImageDAL.Update(carImage);
            return new SuccessResult("Car image updated");
        }


            private IDataResult<List<CarImage>> CheckIfCarImageNull(int carId)
            {
                try
                {
                    string path = @"\images\logo.jpg";
                    var result = _carImageDAL.GetAll(c => c.CarId == carId).Any();
                    if (!result)
                    {
                        List<CarImage> carimage = new List<CarImage>();
                        carimage.Add(new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now });
                        return new SuccessDataResult<List<CarImage>>(carimage);
                    }
                }
                catch (Exception exception)
                {

                    return new ErrorDataResult<List<CarImage>>(exception.Message);
                }

                return new SuccessDataResult<List<CarImage>>(_carImageDAL.GetAll(c => c.CarId == carId).ToList());
            }
           
        }
    }
