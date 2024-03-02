using System;

namespace PhonebookCrud.Services
{
    internal class SystemService
    {
        System[] systems;

        int arrayCount = 10;
        public SystemService()
        {
            systems = new System[arrayCount];
        }

        public void Registr(System system)
        {

            for (int i = 0; i < systems.Length; i++)
            {
                if (systems[i] is null)
                {
                    systems[i] = system;
                    system.Id = system.Id + 1;
                    break;
                }
            }
        }
        public void View(int id, System system)
        {
            if (id == system.Id)
            {
                for (int i = 0; i < systems.Length; i++)
                {
                    Console.WriteLine($" Id - {system.Id} \n Name - {system.Name} \n Number - {system.PhoneNumber} ");
                    break;
                }
            }
        }

        public void ViewAll()
        {
            for (int i = 0; i < systems.Length; i++)
            {
                if (systems[i] is not null)
                {
                    Console.WriteLine($"{systems[i].Name} {systems[i].Id} {systems[i].PhoneNumber}");
                }
                break;
            }
        }
        public void ViewById(int id)
        {
            for (int i = 0; i < systems.Length; i++)
            {
                if (systems[i] is not null)
                {
                    if (systems[i].Id == id)
                    {
                        Console.WriteLine($"{systems[i].Name} {systems[i].PhoneNumber}");
                    }
                }
            }
        }
        public void DeleteById(int id, System system)
        {
            if (id == system.Id)
            {
                for (int i = 0; i < systems.Length; i++)
                {
                    if (systems[i] is not null)
                    {
                        systems[i] = null;
                    }
                }
            }
        }
        public void DeleteAll()
        {
            for (int i = 0; i < systems.Length; i++)
            {
                systems[i] = null;
            }
        }
    }
}



    

