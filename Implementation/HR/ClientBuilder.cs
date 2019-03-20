using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Common;

namespace Practice.HR
{
    class ClientBuilder : IClientBuilder
    {
        protected Client ClientToBuild { get; set; }

        public IClient Build()
        {
            var ClientRef = ClientToBuild;
            ClientToBuild = null;
            return ClientRef;
        }

        public IClientBuilder Discount(float discount)
        {
            CheckNewClient();
            ClientToBuild.Discount = discount;
            return this;
        }

        public IClientBuilder Name(IName name)
        {
            CheckNewClient();
            ClientToBuild.Name = new Common.Name(name); 
            return this;
        }

        public IClientBuilder Name(string name, string surname, string patronymic)
        {
            CheckNewClient();
            ClientToBuild.Name = new Common.Name(name, surname, patronymic);
            return this;
        }

        private void CheckNewClient()
        {
            if (ClientToBuild is null)
            {
                ClientToBuild = new Client();
            }
        }
    }
}
