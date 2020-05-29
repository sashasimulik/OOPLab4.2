using System;

namespace OOPLab4._2
{
    class Catalog
    {
        string[] Make = { "Abarth 500", "BMW 530d", "Chevy Corvette", "Fiat Linea", "Honda Accord", "Jaguar I-Pace",  "Nissan GT-R", "Opel Insignia", "Saab 9-7", "Volkswagen Golf" };
        string[] Color = { "Бiлий", "Чорний", "Зелений", "Жовтий", "Золотий", "Синiй", "Чорний", "Срiбний", "Бiлий", "Рожевий" };
        string[] Number = { "AO5521BB", "AO6665AM", "BC7814HH", "AA8997CH", "AO0100CK", "AO1555BB", "AO1001PP", "AH2002AA", "AO2001AM", "AO7668AM" };
        string[] Year = { "2011", "2012", "2009", "2018", "1999", "2020", "2004", "2010", "2012", "2002" };
        string[] OwnerData = { "Пiдгiрний В.В. 1997р.н.", "Драгула В.В. 2001р.н.", "Чопик О.С. 1992р.н.", "Фiлiмонов Р.Е. 2002р.н.", "Голперт А.М. 1999р.н.", "Симулик О.О. 2001р.н.", "Турiс I.I. 1997р.н.", "Цибар В.В. 2001р.н.", "Бзовий М.М. 2002р.н.", "Когутич В.М. 1990р.н." };       
        public Catalog()
        {

        }       
        public void print()
        {
            
            Console.WriteLine("Марка, модель: \tКолiр: \tНомер: \t Piк: \tIнформацiя про власника: ");           
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine("" + Make[i] + "\t" + Color[i] + "\t" + Number[i] + " " + Year[i] + "\t" + OwnerData[i]);               
            }                        
        }        
        public static void Main()
        {
            Catalog s1 = new Catalog();           
            s1.print();            
        }
    }
}
