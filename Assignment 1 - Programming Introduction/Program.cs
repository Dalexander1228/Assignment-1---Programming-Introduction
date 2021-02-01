    

using System;

namespace Assignment_1___Programming_Introduction
{

    class Program
    {

        static void Main(string[] args)
        {



            //QUESTION 1 SOLUTION:


            //Comment1: the variable 'int n' constrains the triangle to 5 rows
            //comment2: the for-loop makes sure that n is always equal or greater than n1, which is what helps give shape to the triangle. 

            int n = 5;
            int n1, n2, n3;
            for (n1 = 1; n1 <= n; n1++)

            {

                for (n2 = 1; n2 <= n1; n2++)
                {
                    Console.Write("");
                }

                for (n3 = 1; n3 <= n1; n3++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");

            }


            /*
            Self Reflection:
            
            It took about 3 hours to complete the first question, as well as get a better understanding behind the logic of the C# language, 
            I got a glimps into how to set restraints and parameters through language commands.
            */







            //QUESTION 2 SOLUTION:


            //Comment1: the 4 variables for pell set a base-case for the recursive funcion.   
            //comment2: the "pellminustwo + (2* pellminusone)" represents the pellseries logic of sequence growth.


            int pellseriesctr;
            int pellminusone = 0;
            int pellminustwo = 1;
            int pellnumber = 0;



            for (pellseriesctr = 1; pellseriesctr < 20; pellseriesctr++)

            {
                pellnumber = pellminustwo + (2 * pellminusone);
                pellminustwo = pellminusone;
                pellminusone = pellnumber;

                Console.WriteLine(pellseriesctr);
            }


            /*
            Self Reflection:
            
            It took about 3 hrs to complete this question, I got a bit better idea of how to set up a number growth series
            with C# language although not satisfactory because the numbers didnt grow the way i intended. 
            I would really like to get a better understanding or explaination of the internal dynamic 
            of how to set up this kind of solution for the future (for example, with the Fibonacci sequence).
            */









            //QUESTION 3 SOLUTION:


            //Comment1: variables a and b are assigned the values of integers to the 2nd power.    
            //comment2: since the sum of a and b equal 5, the boolian value of c is True.


            var a = Math.Pow(2, 2);
            var b = Math.Pow(1, 2);

            var c = a + b;

            Console.WriteLine(c == 5);


            /*
           Self Reflection:

           It took about 2.5 hrs to complete this question, this one helped furthur my understanding of how to set up value assignments
            to then express as variables that can give me a True or False statement. Although im still confused as to the process of how to
            use the power of C# to play around with different variables for a and b squared that would be True for C.  
           */








            //QUESTION 4 SOLUTION:


            //Comment1: Created an array of integers from which a sorting system can be made to create a count pair difference between the 6.      
            

                        
            // pairs with difference k

            int[] arr = { 3, 1, 4, 1, 5 };
            int n4 = arr.Length;
            int k = 3;
            Console.Write("Count of pairs with "
                            + "given diff is " +
                countPairsWithDiffK(arr, n4, k));



            //Returns count of pairs with
         
            static int countPairsWithDiffK(int[] arr,
                                    int n4, int k)
            {
                int count = 0;

                // Sort array elements
                Array.Sort(arr);

                int i = 0;
                int j = 0;
                while (j < n4)
                {
                    if (arr[j] - arr[i] == k)
                    {
                        count++;
                        i++;
                        j++;
                    }
                    else if (arr[j] - arr[i] > k)
                        i++;
                    else // arr[j] - arr[l] < sum
                        j++;
                }
                return count;
            }




            /*
          Self reflection:

             It took about 3.5 hrs to get through this question (though I wasnt able to correctly sove it). At first I didnt appreciate
            the essence of what the solution was asking for. Once i got a grasp of this, the real challenge was how to set up the solution 
            in a logical way in order for C# to compute how I was trying to organize and account for the paired numbers, I felt like I didnt
            have the power of verb to communicate this to the computer.
          */









            //QUESTION 5 SOLUTION:


            //Comment1: Created a string in order to create a list where i would place the emails to then have C# pick the valid ones
             //which would end up getting sent.



            System.Collections.Generic.List<string> emails = new System.Collections.Generic.List<string>();
            emails.Add("dis.email + bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail + david@us.f.com");



            static int (System.Collections.Generic.List<string> emails)
            {
                foreach (string email in emails)
                {
                    int i = email.IndexOf('@');
                    String local = email.Substring(0, i);
                    String domain = email.Substring(i);
                    if (local.Contains('+'))
                    {
                        local = local.Substring(0, local.IndexOf('+'));

                    }
                    if (local.Contains('.'))
                    {
                        local = local.Replace(".", "");
                    }

                }

                
            }

            Console.ReadLine();


            /*
            Self reflection:

            It took about 2.5 hrs to get through this question (though I wasnt able to correctly solve it). With this question, I got to 
            understand how C# reads an email relative to its domain name and its local name, and how they get sent to the reciever. 
            However, I ultimatly didnt know the command sequence or the logic needed to get C# to acknowledge and account for the valid emails. 
            */








            //QUESTION 6 SOLUTION:


            //Comment1: Created a string of variables for potential origin stations. 
            //comment2: Created a string of variables for potential distination stations.




            string[] origins = { "london", "new york", "tampa", "delhi" };     
            string [] distinations = { "london", "new york", "tampa", "delhi" };

            string dist1 = "london";
            string dist2 = "new york";
            string dist3 = "tampa";
            string dist4 = "delhi";

            Console.WriteLine("destination city is: " + dist3);



            /*
            Self reflection:

            It took about 2.5 hrs to get through this question (I wasnt able to correctly solve this one either ). I thought creating 
            2 arrays of variables, one representing origin and the the destination stations. I though this would be a step in the right  
            direction for C# to compute the different combinations between the stations and figure which is the most
            linear to arrive to. However, again, the language of how to comminucate this to C# alluded me.
            */







            Console.ReadLine();

        }

    }

}
