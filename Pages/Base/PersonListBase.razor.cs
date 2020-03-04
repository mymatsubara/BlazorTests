using BlazorTest.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace BlazorTest.Pages
{
    public class PersonListBase : ComponentBase
    {
        protected List<Person> _people = new List<Person>();
        protected bool _registerNewPerson = false;
        protected Person _newPerson;

        protected void CreateNewPerson()
        {
            _newPerson = new Person();
            _registerNewPerson = true;
        }

        protected void RegisterNewPerson()
        {
            _people.Add(_newPerson);
            _registerNewPerson = false;
        }

        protected void SortPeople()
        {
            _people = _people.OrderBy(p => p.Name).ToList();
        }
    }
}
