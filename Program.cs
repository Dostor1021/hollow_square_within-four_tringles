using System.Transactions;

class staric
{
    public void starics(int Size)
    {
        int i_size = Size;
        string x = "+";
        string y = " ";
        int j_size = i_size;
        int half_size = i_size / 2;
        int left_of_half = i_size / 4;
        int right_of_half = (3 * i_size) / 4;
        for (int i = 0; i <= j_size; i++)  //rows
        {
            for (int j = 0; j < j_size; j++)  //column
            {
                if (i < left_of_half)
                {    //upper 
                    if (j >= half_size - i && j <= half_size + i)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(y);
                    }
                }//upper_middle
                //middle
                if (i >= left_of_half && i <= half_size)
                {
                    int n = i - left_of_half;

                    if (j >= left_of_half - n && j <= left_of_half)

                    { Console.Write(x); }
                    else if (j > right_of_half - 1 && j <= right_of_half + n)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(y);
                    }
                    //lowe_middle
                }
                if (i > half_size && i < right_of_half)
                {
                    int n = i - half_size;
                    if (j > n && j <= left_of_half)

                    { Console.Write(x); }
                    else if (j > right_of_half - 1 && j >= right_of_half && j < j_size - n)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(y);
                    }
                }
                //bottem
                if (i >= right_of_half && i <= i_size)
                {
                    int n = i - right_of_half;
                    if (j > left_of_half + n && j < right_of_half - n)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(y);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main()
    {
        int i_size = 0;
        Console.WriteLine("enter 1 to continue or press any key to top the program ");

        int u = Convert.ToInt32(Console.ReadLine());
        while (u == 1)
        {

            Console.WriteLine("enter the size between 20 to 40");
            i_size = Convert.ToInt32(Console.ReadLine());
            if (i_size < 20 || i_size > 40)
            {
                Console.WriteLine("wrong input kindly reinter with valid size between 20 to 40");
            }
            else
            {
                staric Staric = new staric();
                Staric.starics(i_size);
            }

        }
    }
}
