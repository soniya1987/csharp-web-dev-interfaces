using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

        // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
        //  field.
      //  FlavorComparer comparer = new FlavorComparer();

            Console.WriteLine("Flavors Before:"+ "\n");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }
          //  availableFlavors.Sort(comparer);
          availableFlavors.Sort(new FlavorComparer());


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            Console.WriteLine("\nCones Before:" + "\n");
            foreach (Cone cones in availableCones)
            {
                Console.WriteLine(cones.Name +": " +cones.Cost);
            }
            availableCones.Sort(new ConeComparer());

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            Console.WriteLine("\nFlavors After:" + "\n");


            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }

            Console.WriteLine("\nCones After:" + "\n");
            foreach (Cone cones in availableCones)
            {
                Console.WriteLine(cones.Name + ": " + cones.Cost);
            }

        }
    }
}
