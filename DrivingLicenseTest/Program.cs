//Driving License Test

//ALGORITHM

// 1.1 Start.
// 1.2 The user's name is asked.
// 1.3 The user is prompted to enter their name.
// 1.4 The user's age is asked.
// 1.5 User is prompted to enter age.
// 1.6 the user's education status is asked.
// 1.7 The user is prompted to enter the educational status.
// 1.8 the user's health status is asked.
// 1.9 user is prompted to enter health status.
// 2   if age 18 or older (age >= 18) and education is high school or higher and health is not colorblind.
// 2.1 the user is informed that she/he can get a driver's license along with her name.
// 2.2 if the user does not comply with point 2.
// 2.3 It is stated to the user that she/he cannot obtain a driver's license along with her name.


//Ehliyet Sınavı

//ALGORİTMA

// 1.1 Başla.
// 1.2 Kullanıcının adı sorulur.
// 1.3 kullanıcıdan adını girilmesi istenir.
// 1.4 kullanıcının yaşı sorulur ve kullanıcıdan yaş girilmesi istenir.
// 1.5 kullanıcıdan yaş girilmesi istenir.
// 1.6 kullanıcının eğitim durumu sorulur.
// 1.7 kullanıcıdan eğitim durumunun girilmesi istenir.
// 1.8 kullanıcının sağlık durunu sorulur.
// 1.9 kullanıcıdan sağlık durumu girilmesi istenir.
// 2  eğer yaş 18 veya daha büyükse (yas >= 18) ve eğitim durumu lise ve üstü ise  ve sağlık durumu renk körü değilse.
// 2.1 kullanıcıya adı ile birlikte ehliyet alabileceği belirtilir.
// 2.2 10. madde değilse.
// 2.3 kullanıcıya adı ile birlikte ehliyet alamayacağı belirtilir.



Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Education status (primary school: p, middle School: m, high school: h, university: u): ");
string education = Console.ReadLine();
Console.Write("Are you color blind (Yes: Y, No: N): ");
string colorBlind = Console.ReadLine();

if (age >= 18 && (education != "p") && colorBlind == "N")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Dear " + name + ", you can get a driver's license.");
    Console.ResetColor();
}
else // yas < 18 || (egitim != "l" && egitim != "ü") || renkKoruMu != "h"
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Dear " + name + ", you cannot get a driver's license.");
    Console.ResetColor();
}

Console.ReadLine();