﻿namespace ProjectPet.SharedKernel.ErrorClasses;

public static class Errors
{
    public static class General
    {
        public static Error ValueIsEmptyOrNull<T>(T? value, string valueName)
        {
            string emptyOrNull = value == null ? "null" : "empty";

            return Error.Validation("value.is.invalid", $"Value {valueName} of type {typeof(T).Name} cannot be {emptyOrNull}!");
        }

        public static Error ValueIsInvalid<T>(T value, string valueName) =>
            Error.Validation
            ("value.is.invalid", $"Value {valueName} of type {typeof(T).Name} is invalid!");

        public static Error NotFound(Type type, Guid? id = null) =>
            Error.NotFound
            ("record.not.found", $"Record with id {id} of type {type.Name} was not found!");

        public static Error ValueLengthMoreThan<T>(T? value, string valueName, int len)
            => ValueLength(value, "more", valueName, len);
        public static Error ValueLengthLessThan<T>(T? value, string valueName, int len)
            => ValueLength(value, "less", valueName, len);

        private static Error ValueLength<T>(T? value, string lessmore, string valueName, int len)
            => Error.Validation
                ("value.is.invalid", $"Value {valueName} of type {typeof(T).Name} cannot be {lessmore} than {len} elements long");

    }
}
