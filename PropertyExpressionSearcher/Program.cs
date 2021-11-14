using System.Linq.Expressions;
using PropertyExpressionSearcher;

var fred = new Customer("Fred", 25);

PrintResult<Customer, string>(x => x.Order.Id);


void PrintResult<TSource, TProperty>(Expression<Func<TSource, TProperty>> propertyLambda)
{
    var property = propertyLambda.GetPropertyInfo();
    Console.WriteLine(property.Name);
}