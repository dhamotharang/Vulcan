using System;

namespace DAL.Vulcan.Mongo.Core.UnitConversions.Exceptions
{
    public class UnknownUnitOfMeasureException : Exception
    {
        public override string Message => "Unknown UnitOfMeasure";
    }
}