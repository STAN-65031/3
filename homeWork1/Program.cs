// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

 int number = Convert.ToInt32(Console.ReadLine());

 string result = polydromeCheck(number);
Console.WriteLine(result);

string polydromeCheck(int nums)
{
      if (nums < 100000 && nums >= 10000)
    {
        char[] nums1 = nums.ToString().ToCharArray();
            Array.Reverse(nums1);
            String nums12 = new String(nums1);
            int number1= Convert.ToInt32(nums12);
                Console.WriteLine(number1);
    if(number1 == nums)
    {
      return "да"; 
    } 
    else 
    {
        return "нет";
    }
    }
      throw new Exception("Вы ввели не пятизначное число");
}
