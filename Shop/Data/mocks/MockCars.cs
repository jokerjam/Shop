using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {

            get {
                return new List<Car> {
                    new Car 
                    {  
                        name="Tesla Model S", 
                        shortDesc="Быстрый автомобиль", 
                        longDesc="Красивый быстрый современный автомобиль", 
                        img="https://politeka.net/images/2015/09/24/dCaTTqpmeU8zh6aPouQyF9pzqGoh7Wtu.jpg", 
                        price=45000, 
                        isFavorite=true, 
                        available=true, 
                        Category= _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name="Ford Fiesta",
                        shortDesc="Тихий и спокойный",
                        longDesc="Удобный автомобиль для городских дорог",
                        img="http://neo-drive.com/images/2011-ford-fiesta-12.jpg",
                        price=31000,
                        isFavorite=true,
                        available=true,
                        Category= _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="Reno Kaptur",
                        shortDesc="Активный городской",
                        longDesc="Быстрый, стремительный стильный автомобиль",
                        img="https://static.av.by/public_images/big/020/01/66/public_20016601_b_5dd6d00.jpeg",
                        price=36000,
                        isFavorite=true,
                        available=true,
                        Category= _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="Volkswagen Golf VI",
                        shortDesc="Городской комфорт",
                        longDesc="Комфортная семейная классика для городской жизни",
                        img="https://static.av.by/public_images/big/016/68/07/public_16680753_b_8f5eddf.jpeg",
                        price=36000,
                        isFavorite=false,
                        available=true,
                        Category= _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="Toyota Camry",
                        shortDesc="Хороший выбор",
                        longDesc="Лучший выбор ткущего года",
                        img="https://d8a6a33f-3369-444b-9b5f-793c13ff0708.selcdn.net/media/common/car_slider_item_original/tradeins.space/uploads/photo/1603749/5fb5384ca262ca855db7a52f727eb612.png?v94",
                        price=36000,
                        isFavorite=false,
                        available=true,
                        Category= _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
