using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Common.ExpressionCommon
{
    public class StaticDic_ClassCopy
    {
        public static Dictionary<string, object> _dic_ClassCopy = new Dictionary<string, object>();

        public static TOut Trans<TOut, TIn>(TIn tIn)
        {
            string key = string.Format("key_{0}_{0}", typeof(TIn).FullName, typeof(TOut).FullName);
            if (!_dic_ClassCopy.ContainsKey(key))
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
                Func<TIn, TOut> func = expression.Compile();
                _dic_ClassCopy[key] = func;
            }
            return ((Func<TIn, TOut>)_dic_ClassCopy[key]).Invoke(tIn);
        }
    }
}
