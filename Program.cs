using System.Globalization;

namespace OperadoresLogicos
{
    class program
    {
        static void Main(string[] args)
        {

            // para o retorno ser true ambas as operações deve ser verdadeiras, pois o operador logico(&&) exige isso. Sendo assim o retorno da operação e false.

            bool c1 = 2 > 3 && 4 != 5;

            Console.WriteLine(c1);

            // O operador logico || exige que pelo menos uma das operações sejam verdadeiras, para que o retorno seja true.
            bool c2 = 2 > 3 || 4 != 5;

            Console.WriteLine(c2);


            // precedência do ! (Não) > ela e maior do que a precendência do &&(E) e maior que a precedência do || (ou).

            // pode usar parenteses a vontade


            // nessa operação o operador ! está dizendo que o 2 não e maior que 3, sendo assim o retorno deve ser true.

            bool c3 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c3);



        }
    }
}