# ReCapProject - Rent A Car System

![bannerResim](https://i.ibb.co/JyvYYdJ/Ads-z-tasar-m.png)

## :pushpin:Proje Hakkında
N-Katmanlı Solid mimari yapısı ile hazırlanan, EntityFramework kullanılarak CRUD işlemlerinin yapıldığı, kayıt olma giriş yapabilme Jwt teknikleri ile token alarak güvenliği sağlanan, Wpf arayüzü ile çalışan, araç Kiralama iş yerlerine yönelik örnek bir projedir.Proje içerisinde data kaynakları kolayca değiştirilebilir, yeni nesneler eklenebilir, bütün iş istekleri değiştirilebilir.Yapılacak olanlar eski kodları bozmadan sürekli ekleme ile yapılabilir.Proje sürdürülebilirlik prensibini yerine getirmektedir.

## :books:Katmanlar
![entities](https://i.ibb.co/LJn8Y9X/Ads-z-tasar-m.jpg)
### Entities Katmanı
**Entities Katmanı**'nda **Dtos** ve **Concrete** olmak üzere iki adet klasör bulunmaktadır.Concrete klasörü veri tabanından gelen somut nesnelerin özelliklerini tutmak için oluşturulmuştur.Dtos klasörü ise veri tabanında birbiri ile ilişkili olan nesnelerin ilişkili özelliklerini birlikte kullanabilmek için oluşturulmuştur.
<br>:file_folder:`Dtos`  
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarDetailDto.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/DTOs/CarDetailDto.cs) 
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalDetailDto.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/DTOs/RentalDetailDto.cs) 
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForLoginDto.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/DTOs/UserForLoginDto.cs) 
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForRegisterDto.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/DTOs/UserForRegisterDto.cs) 
<br> <br> :file_folder:`Concrete`  
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImage.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/CarImage.cs) 
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Customer.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Customer.cs) 
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Rental.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Rental.cs) 
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Brand.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Brand.cs)  
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Car.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Car.cs)  
<br> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Color.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Color.cs)  
<br>
