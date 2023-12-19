using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer (){ Code = 0002154, Model = "Acer PO3-630", CPU = "Core i7 ", Frequence = 4.9, RAM = 16, SSD = 3070, VRAM = 12,Price = 137000, NumberOfComputers = 2 },
                new Computer (){ Code = 0004355, Model = "Robotcomp  V2", CPU = "Core i5 ", Frequence = 3.9, RAM = 64, SSD = 1070, VRAM = 12,Price = 117000, NumberOfComputers =9 },
                new Computer (){ Code = 0003423, Model = "ASUS -A3400G058W", CPU = "Core i3 ", Frequence = 2.9, RAM = 8, SSD = 1080, VRAM = 8,Price = 112000, NumberOfComputers = 40 },
                new Computer (){ Code = 0002341, Model = "MSI MPG Trident A", CPU = "Core i9 ", Frequence = 5.9, RAM = 16, SSD = 1070, VRAM = 16,Price = 177000, NumberOfComputers = 1 },
                new Computer (){ Code = 0009081, Model = "ASUS G15DK-73700X050W", CPU = "Core i7 ", Frequence = 4.8, RAM = 32, SSD = 2070, VRAM = 12,Price = 133000, NumberOfComputers = 5 },
                new Computer (){ Code = 0004562, Model = "DELL  T3640 MT", CPU = "Core i7 ", Frequence = 4.7, RAM = 16, SSD =4070, VRAM = 12,Price = 122000, NumberOfComputers = 4 },
                new Computer (){ Code = 0009082, Model = "Acer PO3-630", CPU = "Core i5 ", Frequence = 4.6, RAM = 64, SSD = 1070, VRAM = 8,Price = 99000, NumberOfComputers = 31},
                new Computer (){ Code = 0007345, Model = "DELL  T3741 MT", CPU = "Ryzen 5 ", Frequence = 4.2, RAM = 32, SSD = 2048, VRAM = 16,Price = 148000, NumberOfComputers = 50 },
            };

            Console.WriteLine("Введите название процессора");
            string cpu = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.CPU == cpu).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.RAM  >= ram).ToList();
            Print(computers2);

            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.CPU);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer e in gr)
                {
                    Console.WriteLine($"{e.Code} {e.Model} {e.Price} {e.NumberOfComputers}");

                }
            }
            Computer computer5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer5.Code} {computer5.Model} {computer5.Price} {computer5.NumberOfComputers}");

            Computer computer6 = computers.OrderByDescending(y => y.Price).LastOrDefault();
            Console.WriteLine($"{computer6.Code} {computer6.Model} {computer6.Price} {computer6.NumberOfComputers}");

            Console.WriteLine(computers.Any(x => x.Price > 30));

            Console.ReadKey();
        }
        static void Print(List <Computer>computers )
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"{e.Code} {e.Model} {e.CPU } {e.Frequence} {e.RAM } {e.SSD} {e.VRAM} {e.Price } {e.NumberOfComputers}");
            }
            Console.WriteLine();
        }
    }
}

