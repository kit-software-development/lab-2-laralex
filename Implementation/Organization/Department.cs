namespace Practice.Organization
{
    /// <summary>
    ///     Скрытая реализация представления об отделе предприятия.
    /// </summary>
    internal struct Department : IDepartment
    {

        /*
         * TODO #2: Реализуйте интерфейс IDepartment для структуры Department
         */
        public Department(string dep_name)
        {
            this.Name = dep_name;
        }

        public string Name { get; }
    }
}
