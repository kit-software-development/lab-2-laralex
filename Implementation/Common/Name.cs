namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */
        public Name(string firstname, string surname, string patronymic) {
            this.FirstName = firstname;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.FullName = GetFullName(firstname, surname, patronymic);
            this.ShortName = GetShortName(firstname, surname, patronymic);
        }

        public Name(IName other_name)
        {
            this.FullName = other_name.FullName;
            this.ShortName = other_name.ShortName;
            {
                SplitFullName(this.FullName, out string firstname, out string surname, out string patronymic);
                this.FirstName = firstname;
                this.Surname = surname;
                this.Patronymic = patronymic;
            }
            
        }

        public string FullName { get; }

        public string ShortName { get; }

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }
        
        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }
        
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }

        private static string GetFullName(string firstname, string surname, string patronymic)
        {
            return surname + ' ' + firstname + ' ' + patronymic;
        }

        private static string GetShortName(string firstname, string surname, string patronymic)
        {
            return firstname.ToUpper().Substring(0, 1) + '.' + patronymic.ToUpper().Substring(0, 1) + '.' + surname;
        }

        private static void SplitFullName(string fullname, out string firstname, out string surname, out string patronymic)
        {
            var split = fullname.Split(' ');
            firstname = split[1];
            surname = split[0];
            patronymic = split[2];
        }
    }
}
