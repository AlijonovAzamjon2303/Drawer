string triangle = @"
                        *    
                       * *       
                      *   *  
                     *     * 
                    * * * * *";
string square = @"
                  * * * * * *
                  *         *
                  *         *
                  *         *
                  * * * * * *";
string cube = @"
                  * * * * * *
                  *         * *
                  *         *  *
                  *         *  *
                  * * * * * *  *
                   *         * *
                    * * * * * *";
string select;
do
{
    Console.WriteLine("1. Triengle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Cube");
    Console.WriteLine("4. Finish");
    select = Console.ReadLine();
    string shape = select switch
    {
        "1" => triangle,
        "2" => square,
        "3" => cube,
        "4" => "The program is over"
    };
    Console.Clear();
    Console.WriteLine(shape);
}while(select != "4");