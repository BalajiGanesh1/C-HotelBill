using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenuApp
{
 
    class Item
    {
        
        public string item_name;
        public long price;
        public int no_of_plates;

        public void setInfo(string item_name,long price,int no_of_plates=0)
        {
           
            this.item_name = item_name;
            this.price = price;
            this.no_of_plates = no_of_plates;
          
        }

    }

  
   class Starters:Item
   {
        static List<Item> StartersMenu = new List<Item>();

        public void initialiseMenu()
        {
            Item starter = new Item();
            starter.setInfo("Gobi-65", 50);
            StartersMenu.Add(starter);

            starter.setInfo("Paneer-65", 100);
            StartersMenu.Add(starter);

            starter.setInfo("BabyCorn-65", 80);
            StartersMenu.Add(starter);

            starter.setInfo("Kadai Veg", 60);
            StartersMenu.Add(starter);

            starter.setInfo("Garlic Bread", 75);
            StartersMenu.Add(starter);


        }
        internal void display()
        {
            throw new NotImplementedException();
        }

        internal string getSelectedItem(int sno)
        {
            return StartersMenu[sno - 1].item_name;
        }

        internal void set_no_of_plates(int sno, int no_of_plates)
        {

            
        }


    }




    class MenuAndBillPrinter
    {   
        static void displayMainMenu()
        {
            Console.WriteLine("\t\t\t 1.Starters\n " +
                              "\t\t\t 2.Main Course\n" +
                              "\t\t\t 3.Deserts\n" +
                              "\t\t\t 4.Bill");
           
        }

        static void displayHeader()
        {
            Console.WriteLine("\t\t\t Welcome To Hotel TransylVania\n\n");
        }
        static void Main(string[] args)
        {
            int menuType;
            char dineAgain;

            Console.Clear();
            displayHeader();
        
                 do {
            
                     displayMainMenu();
                     Console.WriteLine("\n\n\t\tHelp us Show the Dishes available(Enter 1/2/3)");
                     menuType = Console.Read();    //menuType 1=Starters 2=Main course 3=Desert 4=Bill
            
                     switch(menuType)
                     {
                         case 1:
                             {
            
                                 Console.Clear();
                                 displayHeader();
                                 Starters starters = new Starters();
                                 starters.initialiseMenu();
                                 char moreStarters;
                                 do
                                 {
                                     int sno, no_of_plates;
                                     
                                     starters.display();
                                     Console.WriteLine("Enter S.no of Item you want\t:");
                                     sno = Console.Read();
            
                                     Console.WriteLine("How many plates of " + starters.getSelectedItem(sno) + " do you want?");
                                     no_of_plates = Console.Read();
                                     starters.set_no_of_plates(sno,no_of_plates);
            
                                     Console.WriteLine(starters.no_of_plates + " plates of" + starters.getSelectedItem(sno) + " ordered !\n");
                                     Console.WriteLine("Any more Starters?(Reply Y/N)\t\t:");
                                     moreStarters = (char)Console.Read();
            
                                 } while (moreStarters == 'y' || moreStarters == 'Y');
            
                                 break;
            
                             }
                            
            
                         case 2:
                             {
                                 MainCourse mc = new MainCourse();
                                 mc.display();
            
                             }
                             break;
            
                         case 3:
                             {
                                 Desert desert = new Desert();
                                 desert.display();
            
                             }
                             break;
            
                         case 4:
                             {
                                 Bill bill = new Bill();
                                 bill.display();
            
                             }
                             break;
                      
            
                     }
            
                 }while (dineAgain == 'y' || dineAgain == 'Y') ;
            
            
            Console.ReadLine();
        
       }

        private static void initialisemenu()
        {
            Item item = new Item();
            item.setInfo("ABC", 123, 1);
            item.setInfo("ABC", 123, 1);
            item.setInfo("ABC", 123, 1);
            item.setInfo("ABC", 123, 1);
            item.setInfo("ABC", 123, 1);
            item.setInfo("ABC", 123, 1);
            item.setInfo("ABC", 123, 1);
            item.setInfo("ABC", 123, 1);

            foreach( Item entry in Item.Menu){
                Console.WriteLine(entry.item_name);
                Console.WriteLine(entry.price);

            }
        }
    }
}
