    //Yuxaridaki metodlar ucun delegate yaradin

    //Registration(Yuxaridaki metodlarin tipinde parametr qebul edir)
    //metodunda istifadeciden registrasiyadan kecmesi ucun melumatlar alinir

    //Return type-i bool olan yuxaridaki metodlar 1 string parametr qebul edir
    //eger her bir metod butun sertler odenerse User yaradilsin ve liste elave olunsun
namespace RegistrAccountBaseUser
{
    public delegate bool MethodHand(string value);
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

           MethodHand methodHand = account.CheckDigit;
           methodHand += account.CheckLower;
           methodHand += account.CheckUpper;

            account.Registration(methodHand);
           
            account.ShowUserInfo();

        }
    }
}