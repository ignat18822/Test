using Figure.Interfaces;
using System.Reflection;

namespace Figure.ChackingErrors
{
    public static class CheckingValues
    {
        public static void CheckingForNegativeValue(this ICalculation calculation)
        {
            Type type = calculation.GetType();

            var listNames = new List<string>();

            foreach (FieldInfo field in type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
            {

                if (field.GetValue(calculation).GetType() == typeof(List<double>))
                {
                    var values = (List<double>)field.GetValue(calculation);
                    foreach (var val in values)
                    {
                        if (val <= 0) throw new Exception($"Число не может быть меньше нуля. Тип {type}");
                    }
                }
                else
                {
                    var value = (double)field.GetValue(calculation);

                    if (value <= 0)
                    {
                        if (value <= 0) throw new Exception($"Число не может быть меньше нуля. Тип {type}");
                    }
                }
            }
        }

    }
}
