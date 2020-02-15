using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Common.ExpressionCommon
{
    public class StaticT_ClassCopy<TIn,TOut>
    {
        private static Func<TIn, TOut> _func = null;

        static StaticT_ClassCopy()
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(TIn), "p");
            List<MemberBinding> memberBindings = new List<MemberBinding>();
            foreach (var item in typeof(TOut).GetProperties())
            {
                var prop = Expression.Property(parameterExpression, typeof(TIn).GetProperty(item.Name));
                MemberBinding memberBinding = Expression.Bind(item, prop);
                memberBindings.Add(memberBinding);
            }
            foreach (var item in typeof(TOut).GetFields())
            {
                var Field = Expression.Field(parameterExpression, typeof(TIn).GetField(item.Name));
                MemberBinding memberBinding = Expression.Bind(item, Field);
                memberBindings.Add(memberBinding);
            }
            MemberInitExpression memberInitExpression = Expression.MemberInit(Expression.New(typeof(TOut)), memberBindings.ToArray());
            Expression<Func<TIn, TOut>> expression = Expression.Lambda<Func<TIn, TOut>>(memberInitExpression, new ParameterExpression[] { parameterExpression });
            _func = expression.Compile();
        }

        public static TOut Trans(TIn tIn)
        {
            return _func(tIn);
        }
    }
}
