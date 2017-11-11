using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SwissArmy.Attributes
{
    public static class AttributeExtractor
    {
        public static T GetAttributeFromProp<T, TObject>(this TObject obj, Expression<Func<TObject, object>> propertyRefExpr) where T : Attribute
        {
            var body = propertyRefExpr.Body;
            var memberExpr = body as MemberExpression;
            if (memberExpr == null)
            {
                var unaryExpr = body as UnaryExpression;
                if (unaryExpr != null && unaryExpr.NodeType == ExpressionType.Convert)
                    memberExpr = unaryExpr.Operand as MemberExpression;
            }

            if (memberExpr == null || memberExpr.Member.MemberType != MemberTypes.Property)
            {
                throw new InvalidOperationException();
            }

            var attributes = memberExpr.Member.GetCustomAttributes(typeof(T), true);
            return attributes.Length > 0 ? attributes[0] as T : null;
        }

        public static TValue GetAttributeValueOrDefault<TAttribute, TValue>(this Type type, Func<TAttribute, TValue> valueSelector) where TAttribute : Attribute
        {
            var att = type.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;
            if (att != null)
            {
                return valueSelector(att);
            }
            return default(TValue);
        }
    }
}
