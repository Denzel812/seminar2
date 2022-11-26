// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер четверти");
int duarter = Convert.ToInt32(Console.ReadLine());

if (duarter==1){
    Console.WriteLine("X>0 & Y>0");
}
else if (duarter==2){
    Console.WriteLine("X>0 &  Y<0");
}
else if (duarter==3){
    Console.WriteLine("X<0 & Y<0");
}
else if (duarter==4){
    Console.WriteLine("X<0 & Y>0");
}
else
{
    Console.WriteLine("Такой четверти не существует");
}

    
