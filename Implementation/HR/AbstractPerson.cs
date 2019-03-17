using System;
using Practice.Common;
using Practice.HR.Events;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson : IPerson
    {
        // [Изменение исходников]: 
        // Свойство Name, имеющееся в оригинале не позволяет реализовать интерфейс IPerson со свойством public IName Name
        // Свойство Department расходится со смыслом "Абстрактного человека", как общего состояния для
        // и клиентов и работников (тем более Employee реализует собственное свойство Department)
        //internal Organization.Department Department
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //}
        //internal Common.Name Name
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //}
        
        private IName _name;
        public IName Name {
            get => _name;
            set
            {
                var old_name = _name;
                _name = value;
                NameChange.Invoke(this, new ValueChangeEventArgs<IName>(old_name));
            }
        }

        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */

        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;
    }
}
