using PhonebookCrud.Services;

namespace PhonebookCrud
{
        internal class Program
        {
            static void Main()
            {
                Menu();
            }
            static void Menu()
            {
                SystemService service = new SystemService();
                System system = new System();

                Menu2();
                void Menu2()
                {
                    Console.WriteLine(" 1.Registratsiya:\n 2.Id orqali ko'rish:\n 3.Hammasini ko'rish:\n 4.Id orqali o'chirish:\n 5.Hammasini o'chirish ");

                 int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Ism kiriting - ");
                            system.Name = Console.ReadLine();
                            Console.Write("PhoneNumber - ");
                            system.PhoneNumber = Console.ReadLine();
                            service.Registr(system);
                            Menu2();
                            break;

                        case 2:
                            Console.Write("Id kiriting - ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            service.ViewById(id);
                            Menu2();
                            break;

                        case 3:
                            service.ViewAll();
                            Menu2();
                            break;

                        case 4:
                            Console.Write("Id kiriting - ");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            service.DeleteById(id2, system);
                            Menu2();
                            break;

                        case 5:
                            service.DeleteAll();
                            Menu2();
                            break;
                    }
                }
            }
        }
   } 





