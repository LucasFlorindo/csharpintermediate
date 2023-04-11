using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using exenumsecomp.Entities.Enums;
using exenumsecomp.Entities;

namespace exenumsecomp.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Depois de declarar os objetos dessa classe, que é a principal, agora declaramos a COMPOSIÇÃO: classes derivadas dessa classe.

        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //Agora são criaremos os construtores

        public Worker()
        {

        }

        //Sempre que houver uma construção para muitos, no padrão de listas, o construtor não deve gerar. Nesse exemplo não foi gerado no construtor a variável 'Contracts' uma vez que essa é uma lista.
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
