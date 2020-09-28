using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*______________________"Вектор"_____________
2в.Визначити клас Вектор На Площині(Vector2D), що містить координати вектора(х, у).
Визначити у класі
    необхідні конструктор(и)

    перевизначити(override) метод ToString()

    властивіть обчислення довжини вектора(корінь квадратний(х* х + у* у)


Оператори
	 //+ додавання двох векторів(результатом є вектор : (x1 + x2, y1 + y2))
	 //- віднімання двох векторів(результатом є вектор : (x1 - x2, y1 - y2))

     //* множення  вектора на скаляр(дробове число) (результатом є вектор : (x1* num, y1* num))

     //* множення  вектора на вектор(результатом є дробове число x1* y1 + x2* y2)
	 // ==,  != операції порівняння двох векторів(попередньо перевизначити Equals(), GetHashCode(), використати Equals())

     приведення типів

       // явне перетворення до типу double (повертати довжину  вектора)
		//неявне перетворення  від типу double до типу Вектор(дробове число - х координата, 0 - у координата)
	// ++, --  збільшувати(зменшувати) обидві координати на 1
// 	- унарний(змінювати знак обох координат вектора)

    // оператори true, false ( false - вектор(0;0), true - хоч одна координата не нуль)
	- одновимірний індексатор, який за індексом 0 повертає х -координату, за індексом  1 - у координату


Перевірити роботу операцій, включно з +=, -=, *=*/


namespace VectorHomeWork
{
    class Vector
    {
        double x;
        double y;

        public double X { get=>x; set=>x=value; }
        public double Y { get=>y; set=>y=value; }

        public Vector(double x =0 ,double y=0)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"X  {x}  :   Y  {y}";
        }

        public double lengthVector()
        {
            double lengthVector = (Math.Sqrt(x * x + y * y));

             Console.WriteLine($"{lengthVector:f}");
            return lengthVector;
        }
        public static Vector operator -(Vector a)
        {
            return new Vector {

                X = -a.x,
                Y=  -a.y
                
            };

        }
        public static explicit operator double(Vector a)
        {
            return a.lengthVector();
        }
        public static implicit operator Vector(double a)
        {
            return new Vector {
                X = a,
                Y = 0
            };

        }
        /*  public static Fraction operator +(Fraction a, Fraction b)
          {
              return new Fraction
              {
                  Num = a.num * b.denom + a.denom * b.num,
                  Denom = a.denom * b.denom
              };

          }*/
        public override bool Equals(object obj)
        {

            if (obj == null || !(obj is Vector))
                return false;
            Vector fr = (Vector)obj;

            return this.x == fr.x && this.y == fr.y;
        }


        public override int GetHashCode()
        {
            return base.ToString().GetHashCode();
        }
        public static Vector operator +(Vector a,Vector b)
        {
            return new Vector {
                X = a.x + b.x,
                Y = a.y + b.y
               
            };

        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector
            {
                X = a.x - b.x,
                Y = a.y - b.y

            };

        }
       

        
        public static Vector operator *(Vector a,double num)
        {
            return new Vector {

                X = a.x * num,
                Y = a.y * num
            };

        }

        //* множення вектора на вектор(результатом є дробове число x1* y1 + x2* y2)


        public static double operator *(Vector a,Vector b)
        {

            return a.x * b.x + a.y * b.y;
        }

        public static Vector operator ++(Vector a)
        {
            return new Vector {

                X = a.x + 1,
                Y = a.y + 1
               
            };


            
        }
        public static Vector operator --(Vector a)
        {
            return new Vector
            {

                X = a.x - 1,
                Y = a.y - 1

            };

        }
        public static bool operator !=(Vector a, Vector b)
        {
            return a.Equals(b);
        }
        public static bool operator ==(Vector a, Vector b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if ((object)a == null)
                return false;
            return a.Equals(b);
            
        }
         

        public static bool operator true (Vector a)
        {
            return a.x != 0||a.y!=0;
        }
        public static bool operator false(Vector a)
        {
            return a.x == 0 && a.y == 0;
        }

        public Vector this[int index] {

            get
            {
                if (index==0)
                {
                    return x;
                }
                else if(index == 1)
                {
                    return y;
                }
                return 0;
                
            }
            
            
        }

    }
}
