using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAPPGenderEmploy.Data
{
    public class EmployeService
    {
        private readonly Contexto _contexto;

        public  EmployeService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<EmployeInfo>GetEmployes()
        {
            var lista = _contexto.employeInfos.ToList();
            return lista;
        }

        public string Create(EmployeInfo employeInfo)
        {
            _contexto.employeInfos.Add(employeInfo);
            _contexto.SaveChanges();
            return "Save good";
        }

        public EmployeInfo GetEmployeId(int id)
        {
            EmployeInfo employeInfo = _contexto.employeInfos.FirstOrDefault(s => s.EmployeId == id);
            return employeInfo;
        }

        public string UpdateEmployee(EmployeInfo employe)
        {
            _contexto.employeInfos.Update(employe);
            _contexto.SaveChanges();
            return "Update Succes";
        }

        public string DeleteEmployee(EmployeInfo employe)
        {
            _contexto.employeInfos.Remove(employe);
            _contexto.SaveChanges();
            return "Delete Success";
        }







    }
}
