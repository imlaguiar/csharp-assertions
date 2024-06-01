using System.Collections;

namespace Assertions;

public static class Assertion
{
	public static bool AssertNotNull(this object obj) => obj != null;
	public static bool AssertNotEmpty(this object obj)
	{
		if(!AssertNotNull(obj)) return false;

		var objType = obj.GetType();

		if(objType == typeof(string)) return (string)obj != string.Empty;
		if(typeof(IEnumerable).IsAssignableFrom(objType)) return true;
		return false;
	}
	
	public static bool AssertEqualTypes(this object obj, Type type) => AssertNotNull(obj) && obj.GetType() == type;

	public static bool AssertIntGreaterThan(this int value, int compareValue) => AssertNotNull(value) && AssertNotNull(compareValue) && value > compareValue;
	public static bool AssertIntGreaterOrEqualTo(this int value, int compareValue) => AssertNotNull(value) && AssertNotNull(compareValue) && value >= compareValue;

	public static bool AssertDoubleGreaterThan(this double value, double compareValue) => AssertNotNull(value) && AssertNotNull(compareValue) && value > compareValue;
	public static bool AssertDoubleGreaterOrEqualTo(this double value, double compareValue) => AssertNotNull(value) && AssertNotNull(compareValue) && value >= compareValue;

	public static bool AssertDecimalGreaterThan(this decimal value, decimal compareValue) => AssertNotNull(value) && AssertNotNull(compareValue) && value > compareValue;
	public static bool AssertDecimalGreaterOrEqualTo(this decimal value, decimal compareValue) => AssertNotNull(value) && AssertNotNull(compareValue) && value >= compareValue;

	public static bool AssertFloatGreaterThan(this float value, float compareValue) => AssertNotNull(value) && AssertNotNull(compareValue) && value > compareValue;
	public static bool AssertFloatGreaterOrEqualTo(this float value, float compareValue) => AssertNotNull(value) && AssertNotNull(compareValue) && value >= compareValue;
}
