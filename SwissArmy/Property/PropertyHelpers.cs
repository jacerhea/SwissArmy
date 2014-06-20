using System;
using System.Linq.Expressions;

namespace SwissArmy.Property
{
    public static class PropertyHelpers
    {
        public static string MemberName<T, V>(this Expression<Func<T, V>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
                throw new InvalidOperationException("Expression must be a member expression");

            return memberExpression.Member.Name;
        }
    }
}
