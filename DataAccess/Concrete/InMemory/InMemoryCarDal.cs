using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=600, ModelYear=2019, Description="Otomobil" },
            new Car{CarId=2, BrandId=1, ColorId=2, DailyPrice=700, ModelYear=2020, Description="Otomobil" },
            new Car{CarId=3, BrandId=2, ColorId=1, DailyPrice=1000, ModelYear=2018, Description="SUV" },
            new Car{CarId=4, BrandId=3, ColorId=2, DailyPrice=900, ModelYear=2019, Description="Otomobil" },
            new Car{CarId=5, BrandId=3, ColorId=3, DailyPrice=1200, ModelYear=2018, Description="SUV" },

            };
            _brands = new List<Brand>
            {
                new Brand{BrandId=1, BrandName="Toyota"},
                new Brand{BrandId=2, BrandName="Ford"},
                new Brand{BrandId=3, BrandName="Audi"},
                new Brand{BrandId=4, BrandName="Volkswagen"},

            };
            _colors = new List<Color>
            {
               new Color{ColorId=1, ColorName="Siyah"},
               new Color{ColorId=2, ColorName="Beyaz"},
               new Color{ColorId=3, ColorName="Gri"},

            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }
       

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
