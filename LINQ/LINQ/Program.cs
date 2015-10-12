using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace LINQ
{
    internal class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */

        private static void Main()
        {
            //PrintOutOfStock();                //1. 
            //InStockMoreThan3();               //2.
            //WashingtonCustomers();            //3.           
            //ProductNames();                   //4.
            //Products25Increase();             //5.
            //ProductNamesUppercase();          //6.
            //ProductsEvenUnits();              //7.
            //NewPriceProducts();               //8.
            //NumbersBC();                      //9.
            //TotalLessThan500();               //10.
            //First3FromNumbersA();             //11.
            //First3Washington();               //12.
            //SkipFirst3();                     //13.
            //CustWAAllButFirst2();             //14.
            //NumbersGreaterThan6();            //15.
            //NumberLessThanTheLast();          //16.
            //NumbersDivisibleBy3();            //17.
            //ProductsorderedAlphabetically();  //18.
            //ProductByUnitInStock();           //19.
            //ProductsByCatAndHighPrice();      //20.
            //NumbersCReversed();               //21.
            //NumbersCRemainder();              //22.
            //ProductsByCat();                  //23.
            //CustomerOrderYear();              //24. 
            //UniqueCategories();               //25.
            //NumbersAandB();                   //26.
            //NumbersIntersect();               //27.
            //NumbAandBNotShared();             //28.
            //ProductID12();                    //29.
            //Does789Exist();                   //30.
            //CatWithOutOfStockProducts();      //31.
            //NumbersBLessThan9();              //32.
            //AllProductsInCategoryInStock();   //33.
            //OddNumbsInA();                    //34.
            //OrdersCount();                    //35.
            //CategoriesCount();                //36.
            //CatTotalUnits();                  //37.
            //LowestPricedProd();               //38.
            //HighestPriceProd();               //39.
            //AveragePrice();                   //40.


            Console.ReadLine();

        }


        //1. Find all products that are out of stock.
        private static void PrintOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            //products.Where(x => x.UnitsInStock == 0)
            //    .Take(3);
            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                where p.UnitsInStock == 0
                select p;

            foreach (var p in results)
            {
                Console.WriteLine(p.ProductName);
            }
        }


        //2. Find all products that are in stock and cost more than 3.00 per unit.
        private static void InStockMoreThan3()
        {
            var products = DataLoader.LoadProducts();


            //var results = products.Where(p => p.UnitInStock > 0 && p.UnitPrice > 3);
            var results = from p in products
                where p.UnitsInStock > 0 && p.UnitPrice > 3
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0} has {1} in stock with unit price {2}", product.ProductName, product.UnitsInStock,
                    product.UnitPrice);
            }
        }

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
        private static void WashingtonCustomers()
        {
            var customers = DataLoader.LoadCustomers();


            var results = from customer in customers
                where customer.Region == "WA"
                select customer;


            foreach (var customer in results)
            {
                Console.WriteLine("{0} {1} is a Washington customer", customer.CustomerID, customer.CompanyName);

                foreach (var order in customer.Orders)
                {
                    Order currentOrder = (Order) order;
                    Console.WriteLine("Order ID: {0} Date: {1} ", currentOrder.OrderID, currentOrder.OrderDate);
                }
            }
        }

        //4. Create a new sequence with just the names of the products.
        private static void ProductNames()
        {
            var products = DataLoader.LoadProducts();
            {
                var results = from p in products
                    select p;

                foreach (var p in results)
                {
                    Console.WriteLine("{0}", p.ProductName);
                }

            }
        }

        //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
        private static void Products25Increase()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                select p;

            foreach (var p in results)
            {
                p.UnitPrice = p.UnitPrice*(decimal) 1.25;
                Console.WriteLine("{0} {1, 5:C}", p.ProductName, p.UnitPrice);
            }


        }

        //6. Create a new sequence of just product names in all upper case.
        private static void ProductNamesUppercase()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                select p;
            foreach (var p in results)
            {
                p.ProductName = p.ProductName.ToUpper();
                Console.WriteLine("{0}", p.ProductName);
            }
        }

        //7. Create a new sequence with products with even numbers of units in stock.
        private static void ProductsEvenUnits()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                where p.UnitsInStock%2 == 0
                select p;

            foreach (var p in results)
            {
                Console.WriteLine("Product: {0} Units: {1}", p.ProductName, p.UnitsInStock);
            }
        }

        //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
        private static void NewPriceProducts()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                select new {p.ProductName, p.Category, Price = p.UnitPrice};

            foreach (var p in results)
            {
                Console.WriteLine("Product: {0} Category: {1} Price: {2, 5:C}", p.ProductName, p.Category, p.Price);
            }
        }

        //9. Make a query that returns all pairs of numbers from both arrays such that the number from numbersB is less than the number from numbersC.
        private static void NumbersBC()
        {
            var numB = DataLoader.NumbersB;
            var numC = DataLoader.NumbersC;

            //Method Syntax
            var result = numB.Select((numbers, index) => new {b = numbers, c = numC[index]}).Where((x => x.b < x.c));

            foreach (var num in result)
            {
                Console.WriteLine(num.b + " " + num.c);
            }
        }

        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
        private static void TotalLessThan500()
        {
            var customers = DataLoader.LoadCustomers();

            var result = from c in customers
                select c;

            foreach (var cust in result)
            {
                foreach (var order in cust.Orders)
                {
                    Order currentOrder = (Order) order;
                    if (currentOrder.Total < 500)
                    {
                        Console.WriteLine("Customer ID: {0} Order Total: {1} Order ID:  {2}", cust.CustomerID,
                            currentOrder.Total, currentOrder.OrderID);
                    }
                }
            }
        }

        //11. Write a query to take only the first 3 elements from NumbersA.
        private static void First3FromNumbersA()
        {
            var numbersA = DataLoader.NumbersA;

            var result = from a in numbersA
                where a < numbersA.ElementAt(3)
                select a;

            foreach (var numb in result)
            {
                Console.WriteLine("{0}", numb);
            }
        }

        //12. Get only the first 3 orders from customers in Washington.
        private static void First3Washington()
        {

            var customers = DataLoader.LoadCustomers();

            var result = from c in customers
                from o in c.Orders
                where c.Region == "WA"
                select new {customer = c.CompanyName, orderID = o.OrderID};

            foreach (var order in result.Take(3))
            { 
                    Console.WriteLine("Name: {0} Order ID: {1}", order.customer, order.orderID);
            }
        }

        //13. Skip the first 3 elements of NumbersA.
        private static void SkipFirst3()
        {
            var numbersa = DataLoader.NumbersA;

            var result = from n in numbersa.Skip(3)
                select n;

            foreach (var numb in result)
            {
                Console.WriteLine(numb);
            }

        }

        //14. Get all except the first two orders from customers in Washington.
        private static void CustWAAllButFirst2()
        {
            var customers = DataLoader.LoadCustomers();

            var result = from c in customers
                from o in c.Orders
                where c.Region == "WA"
                select new
                {
                    c.CustomerID,
                    o.OrderID
                };
            Console.WriteLine("All but the first two orders from Washington.");
            foreach (var order in result.Skip(2))
            {
                Console.WriteLine("Customer ID: {0} Order ID: {1}", order.CustomerID, order.OrderID);
            }
        }

        //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        private static void NumbersGreaterThan6()
        {
            var numbersC = DataLoader.NumbersC;

            var result = from n in numbersC
                select n;

            Console.WriteLine("All elements in NumbersC until an element is greater or equal to 6");
            foreach (var numb in result.TakeWhile(n => n < 6))
            {
                Console.WriteLine(numb);
            }
        }

        //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
        private static void NumberLessThanTheLast()
        {
            var numbersC = DataLoader.NumbersC;

            var result = from n in numbersC
                select n;


            foreach (var numb in result.TakeWhile((n, index) => n >= index))
            {
                Console.WriteLine(numb);
            }
        }

        //17. Return elements from NumbersC starting from the first element divisible by 3.
        private static void NumbersDivisibleBy3()
        {
            var numbersC = DataLoader.NumbersC;

            var result = from n in numbersC
                where n%3 == 0
                select n;

            foreach (var numb in result)
            {
                Console.WriteLine(numb);
            }
        }

        //18. Order products alphabetically by name.
        private static void ProductsorderedAlphabetically()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                select p;

            var results = result.OrderBy(p => p.ProductName);

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //19. Order products by UnitsInStock descending.
        private static void ProductByUnitInStock()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                select p;

            var results = result.OrderByDescending(p => p.UnitsInStock);

            foreach (var product in results)
            {
                Console.WriteLine("Name: {0} Units in stock: {1}", product.ProductName, product.UnitsInStock);
            }
        }

        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
        private static void ProductsByCatAndHighPrice()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                orderby p.Category, p.UnitPrice descending
                select p;

            foreach (var product in result)
            {
                Console.WriteLine("NAME: {0} CATEGORY: {1} PRICE: {2}", product.ProductName,
                    product.Category, product.UnitPrice);
            }
        }

        //21. Reverse NumbersC.
        private static void NumbersCReversed()
        {
            var numbersC = DataLoader.NumbersC;

            var result = from n in numbersC
                select n;

            var results = result.Reverse();

            foreach (var numb in results)
            {
                Console.WriteLine(numb);
            }
        }

        //22. Display the elements of NumbersC grouped by their remainder when divided by 5.
        private static void NumbersCRemainder()
        {
            var numbersC = DataLoader.NumbersC;

            var result = from n in numbersC
                group n by n%5
                into i
                select new {remainder = i.Key, numbs = i};

            foreach (var r in result)
            {
                Console.WriteLine("Remainder: {0}", r.remainder);
                foreach (var s in r.numbs)
                {
                    Console.WriteLine("  {0}",s);
                }
            }
        }

        //23. Display products by Category.
        private static void ProductsByCat()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                orderby p.Category
                select p;

            foreach (var product in result)
            {
                Console.WriteLine("{0} CATEGORY {1}", product.ProductName, product.Category);
            }
        }

        //24. Group customer orders by year, then by month.
        private static void CustomerOrderYear()
        {
            var customers = DataLoader.LoadCustomers();

            var customerOrderGroups =
                from c in customers
                select
                    new
                    {
                        Company = c.CompanyName,
                        YearGroups = from o in c.Orders
                            group o by o.OrderDate.Year
                            into yg
                            select new
                            {
                                Year = yg.Key,
                                MonthGroups = from o in yg
                                    group o by o.OrderDate.Month
                                    into mg
                                    select new
                                    {
                                        Month = mg.Key,
                                        Orders = mg
                                    }
                            }
                    };
            foreach (var result in customerOrderGroups)
            {
                Console.WriteLine("Customer: {0}", result.Company);
                foreach (var n in result.YearGroups)
                {
                    Console.WriteLine("\t" + n.Year);
                    foreach (var month in n.MonthGroups)
                    {
                        Console.WriteLine("\t\t" + month.Month);
                        foreach (var order in month.Orders)
                        {
                            Console.WriteLine("\t\t\t" + order.OrderID);
                        }
                    }
                }
            }
        }

        //25. Create a list of unique product category names.
        private static void UniqueCategories()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                select p.Category;

            var results = result.Distinct();

            foreach (var product in results)
            {
                Console.WriteLine(product);
            }
        }

        //26. Get a list of unique values from NumbersA and NumbersB.
        private static void NumbersAandB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var result = from n in numbersA
                select n;

            var results = result.Union(numbersB);

            foreach (var numb in results)
            {
                Console.WriteLine(numb);
            }
        }

        //27. Get a list of the shared values from NumbersA and NumbersB.
        private static void NumbersIntersect()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var result = from n in numbersA
                select n;

            var results = result.Intersect(numbersB);

            foreach (var numb in results)
            {
                Console.WriteLine(numb);
            }
        }

        //28. Get a list of values in NumbersA that are not also in NumbersB.
        private static void NumbAandBNotShared()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var result = from n in numbersA
                select n;

            var results = result.Except(numbersB);

            foreach (var numb in results)
            {
                Console.WriteLine(numb);
            }
        }

        //29. Select only the first product with ProductID = 12(not a list).
        private static void ProductID12()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                where p.ProductID == 12
                select p;
            var results = result.First();

            Console.WriteLine("Name: {0} ID: {1}", results.ProductName, results.ProductID);
        }

        //30. Write code to check if ProductID 789 exists.
        private static void Does789Exist()
        {
            var products = DataLoader.LoadProducts();

            var result = products.FirstOrDefault(p => p.ProductID == 789);
            Console.WriteLine("Product 789 exists: {0}", result != null);

            //{
            //    Console.WriteLine("Product 789 doesn't exist.");
            //}

        }

        //31. Get a list of categories that have at least one product out of stock.
        private static void CatWithOutOfStockProducts()
        {
            var products = DataLoader.LoadProducts();


            var result = from p in products
                group p by p.Category
                into pcats
                where pcats.Any(p => p.UnitsInStock == 0)
                select new {Category = pcats.Key, Product = pcats};

            foreach (var cat in result)
            {
                Console.WriteLine(cat);
            }


        }

        //32. Determine if NumbersB contains only numbers less than 9.
        private static void NumbersBLessThan9()
        {
            var numbersB = DataLoader.NumbersB;

            var result = numbersB.All(n => n < 9);

            if (result == false)
            {
                Console.WriteLine("All numbers less than 9 in NumbersB");
            }
            Console.Write("Not all numbers < 9 in NumbersB");
        }

        //33. Get a grouped a list of products only for categories that have all of their products in stock.
        private static void AllProductsInCategoryInStock()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                group p by p.Category
                into pCats
                select new {pCats.Key, coll = pCats};

            foreach (var cat in results)
            {
                Console.WriteLine("{0}", cat.Key);
                foreach (var product in cat.coll)
                {
                    Console.WriteLine("\t{0} - {1}", product.UnitsInStock, product.ProductName);
                }
            }
        }

        //34. Count the number of odds in NumbersA.
        private static void OddNumbsInA()
        {
            var numbersA = DataLoader.NumbersA;

            var result = from n in numbersA
                where n%2 != 0
                select n;

            int count = 0;

            foreach (var numb in result)
            {
                count++;
                Console.WriteLine(numb);
            }
            Console.WriteLine("Amount of Odd numbers in A: {0}", count);
        }

        //35. Display a list of CustomerIDs and only the count of their orders.
        private static void OrdersCount()
        {
            var customers = DataLoader.LoadCustomers();

            var result = from c in customers
                from o in c.Orders
                select new {customer = c.CustomerID, count = c.Orders.Count()};

            var results = result.Distinct();

            foreach (var custOrder in results)
            {
                Console.WriteLine("Customer: {0} Number of Orders: {1}", custOrder.customer, custOrder.count);
            }
        }

        //36. Display a list of categories and the count of their products.
        private static void CategoriesCount()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                from c in p.Category
                select new {category = p.Category, product = p.ProductID};

            var results = result.Distinct();

            foreach (var pcat in results)
            {
                Console.WriteLine("{0}, {1}", pcat.product, pcat.category);
            }
        }

        //37. Display the total units in stock for each category.
        private static void CatTotalUnits()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                group p by p.Category
                into g
                select new {category = g.Key, units = g.Sum(n => n.UnitsInStock)};



            foreach (var catamounts in result)
            {
                Console.WriteLine("{0} {1}", catamounts.category, catamounts.units);
            }
        }

        //38. Display the lowest priced product in each category.
        private static void LowestPricedProd()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                group p by p.Category
                into g
                select new {category = g.Key, LowPrice = g.Min(d => d.UnitPrice),};


            foreach (var LowestPrice in result)
            {
                Console.WriteLine("Category: {0} Lowest Price: {1:c}", LowestPrice.category,
                    LowestPrice.LowPrice);
            }
        }

        //39. Display the highest priced product in each category.
        private static void HighestPriceProd()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                group p by p.Category
                into g
                select new {category = g.Key, HighPrice = g.Max(n => n.UnitPrice)};

            foreach (var HighestPrice in result)
            {
                Console.WriteLine("Category: {0} Highest Price in Category : {1:c}", HighestPrice.category,
                    HighestPrice.HighPrice);
            }
        }

        //40. Show the average price of product for each category.
        private static void AveragePrice()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                group p by p.Category
                into g
                select new {category = g.Key, avg = g.Average(n => n.UnitPrice)};



            foreach (var AveragePrice in result)
            {
                Console.WriteLine("{0} {1:c}", AveragePrice.category, AveragePrice.avg);
            }
        }
    }
}
