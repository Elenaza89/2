
bool GetNumber()
{
  Console.WriteLine("Введите число, обозначающее день недели");

  Int32.TryParse(Console.ReadLine(), out int number);
   bool pr = false;
  if(number > 7 || number < 1)
  {
    Console.WriteLine("Число должно быть От 1 до 7 !!!");
    pr = GetNumber();
  }
  pr = (number == 6 || number == 7) ? true:false;
  return pr;
} 

bool pr = GetNumber();



switch( pr )
{
    case true:
    {    
      Console.WriteLine("ДА, ВЫХОДНОЙ");
      break;  
    }
    case false:
    {
       Console.WriteLine("НЕТ, не ВЫХОДНОЙ");
        break;    
    }
}
