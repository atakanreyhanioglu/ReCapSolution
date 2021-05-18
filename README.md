# ReCapProject - Rent A Car System

![bannerResim](https://i.ibb.co/JyvYYdJ/Ads-z-tasar-m.png)

## :pushpin:Proje Hakkında
N-Katmanlı Solid mimari yapısı ile hazırlanan, EntityFramework kullanılarak CRUD işlemlerinin yapıldığı, kayıt olma giriş yapabilme Jwt teknikleri ile token alarak güvenliği sağlanan, Caching, Validation, Transaction,Performance işlemlerini Autofac paketi ile oluşturulan Aspectleri kullanarak gerçekleştiren, Wpf arayüzü ile çalışan, araç Kiralama iş yerlerine yönelik örnek bir projedir.Proje içerisinde data kaynakları kolayca değiştirilebilir, yeni nesneler eklenebilir, bütün iş istekleri değiştirilebilir.Yapılacak olanlar eski kodları bozmadan sürekli ekleme ile yapılabilir.Proje sürdürülebilirlik prensibini yerine getirmektedir.

### Backend Tecnologies
MsSql, Asp.Net Core for Restful api,EntityFramework Core,Autofac,FluentValidation
MsSql, Asp.Net Core for Restful api, EntityFramework, Core, Autofac, FluentValidation
### Layered Architecture Design Pattern
IOC,AOP,Aspects,JWT
IOC, AOP, Aspects, JWT

## :books:Katmanlar
![entities](https://i.ibb.co/LJn8Y9X/Ads-z-tasar-m.jpg)

### Entities Katmanı
**Entities Katmanı**'nda **Dtos** ve **Concrete** olmak üzere iki adet klasör bulunmaktadır.Concrete klasörü veri tabanından gelen somut nesnelerin özelliklerini tutmak için oluşturulmuştur.Dtos klasörü ise veri tabanında birbiri ile ilişkili olan nesnelerin ilişkili özelliklerini birlikte kullanabilmek için oluşturulmuştur.
<br><br>:file_folder:`Dtos`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarDetailDto.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/DTOs/CarDetailDto.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalDetailDto.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/DTOs/RentalDetailDto.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForLoginDto.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/DTOs/UserForLoginDto.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForRegisterDto.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/DTOs/UserForRegisterDto.cs) 
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImage.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/CarImage.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Customer.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Customer.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Rental.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Rental.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Brand.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Brand.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Car.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Car.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Color.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Entities/Concrete/Color.cs)  

![corekatmani](https://i.ibb.co/0npPtyq/Ads-z-tasar-m-1.jpg)
###  Core Katmanı
**Core Katmanı** evrensel bir katmandır. Geliştirilecek her projede kullanılabilir, isimlendirme kuralları ve oluşturulma düzeni sebebi ile oldukça kullanışlıdır. **Core Katmanı**'nda **DataAccess**, **Entities**, **Utilities**, **Aspects**, **CrossCuttingConcerns**, **DependencyResolvers** ve **Extensions** klasörleri bulunmaktadır.
**Aspects** kasörü Caching, Validation, Transaction,Performance işlemlerinin Autofac attribute altyapısını hazırlar.**CrossCuttingConcerns** klasöründe Validation ve Cache yönetimi proje içerisinde, dikey katmanda dinamik çalışabilmesi için (generics)genelleştirildi.**DependencyResolvers** klasöründe servis konfigrasyonları yapıldı.**DataAccess** klasöründe bütün CRUD operasyonları ve DataBaseler generic olarak yapılandırıldı.**Extensions** içerisinde Jwt için yönetimi kolaylaştıran genişlemeler yapıldı.**Utilities** içerisinde iş metodu kurallarının yönetimi kolaylaştırıldı, belge ekleme işlemleri kodlandı,Aspectlerin araya girebilmesi için alt yapı hazırlandı ve ezilmeyi bekliyor, Results yapısı kurularak hata yönetimi yapılandırıldı, Jwt ve hashing teknikleriyle güvenlik yapılandırıldı.
<br> <br> :file_folder:`Core`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Autofac](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/Core/Aspects/Autofac) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CrossCuttingConcerns](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/Core/CrossCuttingConcerns) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [DataAccess](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/Core/DataAccess) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [DependencyResolvers](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/Core/DependencyResolvers)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Entities](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/Core/Entities)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Extensions](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/Core/Extensions)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Utilities](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/Core/Utilities)  

![dataaccesskatmani](https://i.ibb.co/BgJVzpy/Data-Access.jpg)
###  Data Access Katmanı
**Data Access Katmanı**'nda **Abstract** interfaceleri barındıran ve **Concrete** classları barındıran klasörler bulunmaktadır.Crud operasyonlarını core katmanından miras alarak gerçekleştirmektedir.Gelebilecek iş kodları için altyapı burada hazırlanır.Objelerin data transferleri için kullanacağı data baseler ve varlıkların bağlantıları **Data Access Katmanı**'nda yapılandırıldı.
<br> <br> :file_folder:`DataAccess` 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Abstract](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/DataAccess/Abstract)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EntityFramework](https://github.com/atakanreyhanioglu/ReCapSolution/tree/master/DataAccess/Concrete/EntityFramework)  

![business](https://i.ibb.co/nmb6m8y/Data-Access.png)
###  Business Katmanı
**Business Katmanı**'nda altyapısı hazır olan bütün serviserin yönetimleri yazıldı.Sürekli değişebilen iş kodlarımızı altyapıyı değiştirmeden ekleyebildiğimiz katmandır.Sürekliliğin korunduğu ReCap projemde birçok değişikliğin sadece burada yapılıyor olması yönetimi, sürekli gelişimi çok kolaylaştırmaktadır.
<br> <br> :file_folder:`Concrete`
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [AuthManager.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Business/Concrete/AuthManager.cs)
<br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [BrandManager.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Business/Concrete/BrandManager.cs)
<br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImageManager.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Business/Concrete/CarImageManager.cs)
<br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarManager.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Business/Concrete/CarManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ColorManager.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Business/Concrete/ColorManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CustomerManager.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Business/Concrete/CustomerManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalManager.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Business/Concrete/RentalManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserManager.cs](https://github.com/atakanreyhanioglu/ReCapSolution/blob/master/Business/Concrete/UserManager.cs)

* * *

###  Projeden görüntüler [ReCap Frontend](https://github.com/atakanreyhanioglu/ReCapFrontend) 

![image0](https://raw.githubusercontent.com/atakanreyhanioglu/ReCapFrontend/master/gifs/addcar.gif)

* * *

![image1](https://raw.githubusercontent.com/atakanreyhanioglu/ReCapFrontend/master/gifs/admin.gif)

* * *

![image2](https://raw.githubusercontent.com/atakanreyhanioglu/ReCapFrontend/master/gifs/delete.gif)

* * *

![image3](https://raw.githubusercontent.com/atakanreyhanioglu/ReCapFrontend/master/gifs/filtergif.gif)

* * *

![image4](https://raw.githubusercontent.com/atakanreyhanioglu/ReCapFrontend/master/gifs/login.gif)

* * *

![image5](https://raw.githubusercontent.com/atakanreyhanioglu/ReCapFrontend/master/gifs/payment.gif)

* * *

![image6](https://raw.githubusercontent.com/atakanreyhanioglu/ReCapFrontend/master/gifs/rentdate.gif)



