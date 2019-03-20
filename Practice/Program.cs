using Practice.HR;

namespace Practice
{
    /// <summary>
    ///     Цели работы:
    ///     1. на практике познакомиться с механизмом наследования;
    ///     2. научиться использовать полиморфизм;
    ///     3. научиться разделять контексты;
    ///     4. научиться использовать инкапсуляцию на уровне библиотеки;
    ///     5. научиться использовать абстрактные типы данных.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // [Изменение исходников]: Порядок передачи аргументов должен быть (Имя, Фамилия, Отчество), как в интерфейсе
            IClient client = Builders.ClientBuilder()
                .Name("Иван", "Иванов", "Иванович") 
                .Discount(.1f)
                .Build();

            IEmployee employee = Builders.EmployeeBuilder()
                .Name("Григорий", "Сидоров", "Петрович")
                .Department("Бухгалтерия")
                .Build();

            /*
             * TODO #8: Собрать приложение. 
             */

            /*
             * TODO #9: При помощи отладчика проверить типы и структуру объектов, адресованных переменными client и employee.
             */

            /* Структура объектов
             client {Type = Practice.HR.Client}:
                    Discount = 0.1,
                    Name {Type = Practice.Common.Name}:
                        Surname = "Иванов"
                        FirstName = "Иван"
                        Patronymic = "Иванович"
                        FullName = "Иванов Иван Иванович"
                        ShortName = "И.И.Иванов"

             employee {Type = Practice.HR.Employee}:
                    Department {Type = Practice.Organization.Department}:
                        Name = "Бухгалтерия"
                    Name {Type = Practice.Common.Name}:
                        Surname = "Сидоров"
                        FirstName = "Григорий"
                        Patronymic = "Петрович"
                        FullName = "Сидоров Григорий Петрович"
                        ShortName = "Г.П.Сидоров" 
             */
        }
    }
}
