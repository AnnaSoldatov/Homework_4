// void Func(int A, int B){
//     int result = 1;
//     int B1 = Math.Abs(B);
//     for(int i = 1; i <= B1; i++){
//         result = result * A;
//     }
    
//     Console.WriteLine($"The result is {result}");
// }

// Console.Write("Enter the numbers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// Func(num1, num2);


// void Sum(int num){
//     int a = 0;
//     int result = 0;

//     if(num == 0) Console.WriteLine("The sum is 0");
//     else{
//         int num1 = Math.Abs(num);
//         for (int curr = num1; curr != 0; curr /= 10){
//             result += curr % 10;
//             a++;
//         }
//         Console.WriteLine($"The sum is {result}");
//     }
// }

// Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Sum(number);


// int Num(){
//     int num = Convert.ToInt32(Console.ReadLine());  
//     return num;
// }


// int[] NewArray(int size){
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++){

//         array[i] = Convert.ToInt32(Console.ReadLine()); 
//     }
//     return array;
// }

// void PresentArray(int[] array){
//     Console.Write("[ ");
//     for(int i = 0; i<array.Length;i++){
//         Console.Write(array[i]+" ");
//     }
//     Console.Write("]");
// }

// Console.WriteLine("Enter the array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the numbers: ");
// PresentArray(NewArray(size));