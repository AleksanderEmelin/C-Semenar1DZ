


  

           void Task2()
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        {
            Console.WriteLine("Введите первое число:");
            int number_a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number_b = Convert.ToInt32(Console.ReadLine());

            if (number_a < number_b)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else
            {
                Console.WriteLine("первое число больше второго");
            }
        }




        void Task4()
        //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        {
            Console.WriteLine("Введите первое число:");
            int number_a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number_b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите третье число:");
            int number_c = Convert.ToInt32(Console.ReadLine());

            int max = number_a;

            if (number_a > max) max = number_a;

            if (number_b > max) max = number_b;

            if (number_c > max) max = number_c;


            Console.Write("max = ");
            Console.WriteLine(max);

        }




            void Task6()
        {
            // Напишит программу,которая на вход принимает число и выдает, является ли чисо четным 
            //(делится ли оно на 2 без остатка)

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            if ( num % 2 == 0 )
            {
                Console.WriteLine("Четное число");
            }
            else
            {
                Console.WriteLine("Нечетное число");

            }    
        }

           void Task8()
           {
            // Напишите программу, которая на вход принимает число (N), 
            //а на выходе показывает все четные числа от 1 до N

            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 1;

            while (counter <= number)
            {
                if (counter % 2 == 0 ) Console.WriteLine("Число четное:  " + counter); 
                counter++; 
            }
           }
             
        

       