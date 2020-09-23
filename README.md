# PhilsStoreSln
Student Demo Peoject based on Adam Freeman's ASP.Net Core 3
## Create Solution and Projects 

     dotnet new globaljson --sdk-version 3.1.101 --output PhilsStoreSln/OutbackProducts
     dotnet new web --no-https --output PhilsStoreSln/OutbackProducts --framework netcoreapp3.1
     dotnet new sln -o PhilsStoreSln
     dotnet sln PhilsStoreSln add PhilsStoreSln/OutbackProducts 
     dotnet new xunit -o PhilsStoreSln/OutbackProducts.Tests --framework netcoreapp3.1
     dotnet sln PhilsStoreSln add PhilsStoreSln/OutbackProducts.Tests 
     dotnet add PhilsStoreSln/OutbackProducts.Tests reference PhilsStoreSln/OutbackProducts





![alt text](https://github.com/PhilipKoller/PhilsStoreSln/blob/master/Screenshots/_Outback.PNG?raw=true)


![alt text](https://github.com/PhilipKoller/PhilsStoreSln/blob/master/Screenshots/_Cart.PNG?raw=true)


![alt text](https://github.com/PhilipKoller/PhilsStoreSln/blob/master/Screenshots/_Tests.PNG?raw=true)

#                                      Chapter 9
![alt text](https://github.com/PhilipKoller/PhilsStoreSln/blob/master/_Checkout.PNG?raw=true)


![alt text](https://github.com/PhilipKoller/PhilsStoreSln/blob/master/_Checkout_Validation.PNG?raw=true)


![alt text](https://github.com/PhilipKoller/PhilsStoreSln/blob/master/_TestCases.PNG?raw=true)

