using System;

namespace ConsoleApp8
{
    class recipe
    {
        private int numIngredients;
        private string[] ingredientName;
        private int[] ingredientQuantities;
        private string[] ingredientUnits;
        private int numSteps;
        private string[] steps;

     public recipe() { 
        numIngredients = 0;
        numSteps= 0;
        
        }
        public void EnterIngredients() {
            Console.WriteLine("Enter the number of ingredients: ");
            numIngredients = int.Parse(Console.ReadLine());

            ingredientName = new string[numIngredients];
            ingredientQuantities= new int[numIngredients];   
            ingredientUnits = new string[numIngredients];

            for(int i= 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter the of ingredient" +(i + 1) +":");
                ingredientName[i] = Console.ReadLine();

                Console.WriteLine($"Enter the quantity of " + ingredientName[i] +":");
                ingredientQuantities[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the unit of measurement for" + ingredientName[i] +":");
                ingredientUnits[i] = Console.ReadLine() + ":";
            }
        }
        public void EnterSteps() {
            Console.WriteLine($"Enter the number of steps: ");
            numSteps= int.Parse(Console.ReadLine());

            steps = new string[numSteps];

            for(int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Enter step " +(i+1)+":");
                steps[i] = Console.ReadLine();
            }
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            for(int  i= 0; i< numIngredients; i++)
            {
                Console.WriteLine("-" + ingredientQuantities[i] + "" + ingredientUnits[i] + "of" + ingredientName[i]);
            }
            Console.WriteLine("Steps");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine((i + 1) + "." + steps[i]);
            }
        }
        public void ScaleRecipe(double factor)
        {
            for(int i=0; i< ingredientQuantities.Length; i++)
            {
                ingredientQuantities[i] = (int) Math.Round(ingredientQuantities[i] * factor);

            }
        }
        public void ResetQuantities() {

            for (int i = 0; i < numIngredients; i++)
            {
                //Assume original quantities are all 1
                ingredientQuantities[i] = ingredientQuantities[i];
            }
        }
        public void ClearRecipe()
        {
            numIngredients= 0;
            numSteps = 0;
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
           recipe recipe = new recipe();
                

            while(true)
            {
                Console.WriteLine(" Choose an option");
                Console.WriteLine("1. Enter ingredients");
                Console.WriteLine("2. Enter steps");
                Console.WriteLine("3. Display recipe");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset quantities");
                Console.WriteLine("6. Clear recipe");
                Console.WriteLine("7. Exit");

                Console.WriteLine("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipe.EnterIngredients();
                        break;
                    case 2:
                        recipe.EnterSteps();
                        break;
                    case 3:
                        recipe.DisplayRecipe();
                        break;
                    case 4:
                        Console.WriteLine("Enter the scaling factor (0.5, 2, or 3):");
                        double factor = double.Parse(Console.ReadLine());   
                        recipe.ScaleRecipe(factor);
                        break;
                    case 5:
                        recipe.ResetQuantities();
                        break;
                    case 6:
                        recipe.ClearRecipe();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }

}
