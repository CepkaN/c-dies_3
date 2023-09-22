
namespace c_dies_3

{ 
    internal class Program
    {
        private class AAA
        {
            int _a;
            public int a
            {
                get { return _a; }   // геттеры и сеттеры
                set { _a = value; }
            }
            
            internal int sum;
            public static int bb;
            public int age;
            public AAA(int sum,int age) {
                a = sum;
                this.age = age;
                this.sum = 10;
                Console.WriteLine(this);
            }
            static AAA() { bb = 9; }  // без модификаторов доступа для статических переменных
            //public ~AAA() { }  // этого тут неть(((  ( Т ~ T )
            public int SUMMA(ref int a,ref int b)
            {
                int ans = a + b;
                return ans;
            }
            public void OP(ref int ans,out int ab)
            {
                ab = ans * 6;
            }
        }
        class PROSTO
        {
            public int sum(ref int x,ref int y)
            {
                return x + y;
            }
            public void Vot(AAA ah)
            {
                ah.age = ah.age * 67;
                Console.WriteLine(ah.age);
            }
            public void Vot(ref AAA ah)
            {
                ah.age = ah.age * 100;
                Console.WriteLine(ah.age);

            }
        }
        class Sotrudnik
        {
            private string _fIO;
            private string _date;
            private string _tel;
            private string _email;
            private string _obt;
            string FIO { get { return _fIO; }
                set { _fIO = value; }
            }
            string date
            {
                get { return _date; }
                set { _date = value; }
            }
             string tel
            {
                get { return _tel; }
                set { _tel = value; }
            }
             string email
            {
                get { return _email; }
                set { _email = value; }
            }
             string obt
            {
                get { return _obt; }
                set { _obt = value; }
            }
            public Sotrudnik() {   }

            public Sotrudnik(string fIO, string date, string tel, string email, string obt)
            {
                _fIO = fIO;
                this._date = date;
                this._tel = tel;
                this._email = email;
                this._obt = obt;
            }
            public void Sotk() {
                Console.WriteLine("ФИО " + FIO);
                Console.WriteLine("дата " + date);
                Console.WriteLine("телефон " + tel);
                Console.WriteLine("email " + email);
                Console.WriteLine("обязанности " + obt);
            }
        }
        class Figura
        {
            public int cub(int a)
            {
                int S = 6 * a ^ 2;
                return S;
            }
            public int cub(int a,int b,int c)
            {
                int S = 2 * (a * b + a * c + b * c);
                return S;
            }

        }
        class Dveperem
        {
            int _x;
            int _y;
            public int x
            {
                get { return _x; }
                set { _x = value; }
            }
            public int y
            {
                get { return _y; }
                set { _y = value; }
            }
            public void Vivod()
            {
                Console.WriteLine(_y + " " + _x);
            }
            public Dveperem(int x, int y)
            {
                _y = y;
                _x = x;
            }
            public Dveperem() { }
            public void Izmen()
            {
                _x = _x * 10;
                _y = _y * 1000;
            }
            public int Max()
            {
                int max = _y > _x ? max = _y : max = _x;
                return max;
            }
        }
        static void Main(string[] args)
        {
                /*AAA FF = new AAA(9,77);
                FF.a = 7;
                Console.WriteLine(FF.sum + " " + FF.age + " " + FF.a );
                Console.WriteLine(FF.SUMMA(ref FF.age, ref FF.sum));
                int numero, nor = 7;
                FF.OP(ref nor, out numero);
                Console.WriteLine(" число равно " + numero);
                FF.a = Convert.ToInt32(Console.ReadLine());

                PROSTO prosto = new ();
                int xx = Convert.ToInt32(Console.ReadLine());
                int yy = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" сумма чисел равна " + prosto.sum(ref xx, ref yy));
                prosto.Vot(FF);
                prosto.Vot(ref FF);*/

                /*string? fIO = Convert.ToString(Console.ReadLine());
                string? date = Convert.ToString(Console.ReadLine());
                string? tel = Convert.ToString(Console.ReadLine());
                string? email = Convert.ToString(Console.ReadLine());
                string? obt = Convert.ToString(Console.ReadLine());

                Sotrudnik sotr = new Sotrudnik(fIO,date,tel,email,obt);
                sotr.Sotk();*/

                /*Figura fig = new Figura();
                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                int v = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Площадь " + fig.cub(n));
                Console.WriteLine("Площадь " + fig.cub(n, m, v));
                Console.WriteLine("Площадь " + fig.cub(1));
                Console.WriteLine("Площадь " + fig.cub(1, 2, 3));*/

                Dveperem dve = new Dveperem(4,77);
                dve.Vivod();
                dve.Izmen();
                dve.Vivod();
                Console.WriteLine("Большее число " + dve.Max());
        }
    }
}