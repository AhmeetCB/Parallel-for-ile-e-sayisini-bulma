#
# Taylor Serisi kullanarak e^x sayısına yaklaşma
#
# Bu problemde parallel-for kullanmak çok da anlamlı değil. Threadleri kullanarak aynı anda birden fazla iterasyonu hesaplayabiliyoruz ama her iterasyonda ayrı ayrı faktöriyel hesaplama işlemi programı çok fazla yavaşlatıyor.
# Bunun yerine problemi sequential olarak kodlarsak. Bir önceki iterasyonun faktöriyelinin üzerinden ilgili iterasyonun faktöriyel değerini hesaplayabiliriz. Bu da bize çok fazla zaman kazandırır.
