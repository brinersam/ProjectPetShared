using CSharpFunctionalExtensions;
using ProjectPet.SharedKernel.ErrorClasses;
using System.Linq.Expressions;

namespace ProjectPet.Core.Extensions;
public static class Extensions
{
    public static bool IsDelegateFailed<T>(out T result, out Error error, Result<T, Error> factoryRes)
    {
        if (factoryRes.IsFailure)
        {
            result = default!;
            error = factoryRes.Error;
            return true;
        }
        else
        {
            result = factoryRes.Value;
            error = null!;
            return false;
        }
    }

    public static IQueryable<TType> NullableWhere<TType, TParam>(
        this IQueryable<TType> query,
        TParam value,
        Expression<Func<TType, bool>> expression)
    {
        return value is null ? query : query.Where(expression);
    }
}
