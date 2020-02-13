using System;
using System.Linq.Expressions;
using ClassLibrary;
using System.Reflection;

namespace TestCSharpLanguage.Linq
{
    public class LinqToSql
    {
        public LinqToSql()
        {
            {
                Func<int, int, int> fun = (m, n) => m * n + 2;
                Expression<Func<int, int, int>> expression = (m, n) => m * n + 2;
                var r1 = fun.Invoke(2, 3);
                var r2 = expression.Compile().Invoke(2, 3);
                Console.WriteLine(fun.Invoke(2, 3) + "  " + expression.Compile().Invoke(2, 3));
            }

            {
                //拼装表达式目录树
                Console.WriteLine("*************拼装表达式目录树*************");
                Expression<Func<int>> expression = () => 123 + 234;
                int result = expression.Compile().Invoke();

                ConstantExpression right = Expression.Constant(123);
                ConstantExpression left = Expression.Constant(234);
                BinaryExpression plus = Expression.Add(left, right);
                Expression<Func<int>> lambda = Expression.Lambda<Func<int>>(plus, new ParameterExpression[] { });
                int result2 = lambda.Compile().Invoke();

                Console.WriteLine(result + ";" + result2);

            }
            {
                Console.WriteLine("*************拼装表达式目录树(复杂)*************");
                Expression<Func<People, bool>> expression0 = p => p.Id.ToString().Equals("5");

                ParameterExpression people = Expression.Parameter(typeof(People), "p");
                ConstantExpression constant = Expression.Constant("5");
                PropertyInfo[] field = typeof(People).GetProperties();//.GetField("Id");
                var FieldExp = Expression.Property(people, field[0]);
                var toString = typeof(int).GetMethod("ToString", new Type[] { });
                var toStringExp = Expression.Call(FieldExp, toString, new Expression[] { });
                var equals = typeof(string).GetMethod("Equals", new Type[] { typeof(string) });
                var equalsExp = Expression.Call(toStringExp, equals, new Expression[] { constant });
                Expression<Func<People, bool>> expression = Expression.Lambda<Func<People, bool>>(equalsExp, new ParameterExpression[] { people });

                bool result = expression.Compile()(new People
                {
                    Id = 5,
                    Name = "hj",
                    Age = 5
                });
                Console.WriteLine(result);
            }
        }
    }
}
