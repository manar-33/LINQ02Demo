using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using static LINQ02Demo.ListGenerator;
namespace LINQ02Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filtration Operators[Where-OfType]
            //Differed
            //Fluent
            //var Result=ProductsList.Where(P=>P.UnitsInStock==0);
            //Query
            //Result=from P in ProductsList
            //       where P.UnitsInStock==0
            //       select P;

            // var Result = ProductsList.Where(P => P.Category == "Meat/Poultry" && P.UnitsInStock > 0);
            // Result = from P in ProductsList
            //          where P.Category == "Meat/Poultry" && P.UnitsInStock > 0
            //          select P;

            //Indexed Where Only Valid in Fluent Syntax

            //var Result = ProductsList.Where((P,I)=>P.UnitsInStock==0&&I<10);
            //OfType
            //ArrayList list = new ArrayList() { "Manar", 1, 2.5, "Ali" };
            //var Result = list.OfType<string>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Transformation Operators [Select-SelectMany]
            // var Result = ProductsList.Select(P => P.UnitPrice);
            //var Result = ProductsList.Select(P => new { P.ProductID, P.ProductName });
            ////Query
            //Result = from P in ProductsList
            //         select new
            //         {
            //             P.ProductID,
            //             P.ProductName
            //         };

            //var Result = CustomersList.SelectMany(C => C.Orders);
            //Result = from c in CustomersList
            //         from o in c.Orders
            //         select o;

            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).Select(P =>
            //new
            //{
            //    P.ProductID,
            //    P.ProductName,
            //    NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //}
            //);

            // Indexed Select Valid Only In Fluent Syntax
            //var Result =ProductsList.Select((P, I) => new { I, P.ProductName });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ordering Operators
            //var Result = ProductsList.OrderBy(P => P.UnitPrice);
            // var Result = ProductsList.OrderByDescending(P => P.UnitPrice);

            //var Result = from P in ProductsList
            //             orderby P.UnitPrice descending
            //             select P;

            // var Result = ProductsList.Select(P => new { P.ProductName, P.UnitsInStock, P.UnitPrice }).OrderBy(P => P.UnitsInStock).ThenBy(P=>P.UnitPrice);

            //var Result = ProductsList.Reverse<Product>();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Element Operators
            //var Result = ProductsList.First();
            //Console.WriteLine(Result);
            //List<int> list = new List<int>();
            //var Result = list.First();
            //var Result = list.Last();
            //Console.WriteLine(Result);//May Throw Exception
            //Sequence contains no elements

            //ProductsList = new List<Product>();

            //var Result = ProductsList.FirstOrDefault();
            //var Result = ProductsList.LastOrDefault();
            //Return Default Value

            //var Result = ProductsList.First(P=>P.UnitsInStock==0);
            // Console.WriteLine(Result);

            //var Result= ProductsList.ElementAt(100);//May Throw Exception [ Index was out of range.]
            //var Result = ProductsList.ElementAtOrDefault(100);

            // var Result= ProductsList.Single();//May Throw Exception[Sequence contains more than one element]
            //var Result = ProductsList.SingleOrDefault();
            // Console.WriteLine(Result);
            //var Result = ProductsList.DefaultIfEmpty();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Aggregation Operators
            //var Result = ProductsList.Count(p=> p.UnitsInStock==0);
            //var Result = ProductsList.Sum(P=>P.UnitPrice);
            //var Result = ProductsList.Average(P => P.UnitPrice);
            //var Result = ProductsList.Max(P => P.UnitPrice);
            //var Result = ProductsList.Min(P => P.UnitPrice);
            // var Result = ProductsList.MaxBy(P => P.UnitPrice);
            //Console.WriteLine(Result);

            // List<string> Names = new List<string>() { "Manar", "Mahmoud","Elsayed"};
            //var Result =Names.Aggregate((str01,str02)=>$"{str01} {str02}");
            // Console.WriteLine(Result);
            #endregion
            #region Casting Operators
            //List<Product> Result = ProductsList.Where(P=>P.UnitsInStock==0).ToList();
            // Product[] Result = ProductsList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long,Product> Result = ProductsList.Where(P => P.UnitsInStock == 0).ToDictionary(P=>P.ProductID);
            // HashSet<Product> Result = ProductsList.Where(P => P.UnitsInStock == 0).ToHashSet();
            // ILookup<long,Product> Result = ProductsList.Where(P => P.UnitsInStock == 0).ToLookup(P=>P.ProductID);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Generation Operators
            //var Result= Enumerable.Range(10,100);
            //var Result = Enumerable.Repeat(new Product() { ProductName="Repeated Name"},100);
            //var Result = Enumerable.Empty<Product>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item+" ");
            //}
            #endregion
            #region Set Operators - Union Family
            var Seq01 = Enumerable.Range(0,100);
            var Seq02 = Enumerable.Range(50, 100);
            ////var Result =Seq01.Union(Seq02);
            ////var Result = Seq01.Concat(Seq02);
            var Result = Seq01.Intersect(Seq02);
            ////var Result = Seq01.Except(Seq02);
            foreach (var item in Result)
            {
                Console.Write(item+" ");
            }
            #endregion
            #region Quantifier Operators
            //var Result = ProductsList.Any(P=>P.UnitsInStock==0);
            //var Result = ProductsList.All(P => P.UnitsInStock == 0);
            //var Seq01 = Enumerable.Range(0, 100);
            ////var Seq02 = Enumerable.Range(50, 100);
            ////var Result = Seq01.SequenceEqual(Seq02);
            //var Result = Seq01.Contains(50);
            //Console.WriteLine(Result);

            #endregion
            #region Zipping Operator
            //List<string> list = new List<string>() { "ten", "Twenty", "Thirty", "Fourty" };
            //List<int> list2 = new List<int>() { 10, 20, 30, 40, 50, 60 };
            ////var Result = list.Zip(list2);
            //var Result = list.Zip(list2,(W,N)=>$"{W} => {N}");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Grouping Operators
            //var Result = ProductsList.GroupBy(P=>P.Category);
            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($"......{ Product}");
            //    }
            //}
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select new { CategoryName=Category.Key,CountOfCategory= Category.Count() };
            //foreach (var Item in Result) 
            //{

            //    Console.WriteLine(Item);
            //}
            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($"......{ Product}");
            //    }
            //}
            #endregion
            #region Partitioning Operators
            //var Result = ProductsList.Where(P=>P.UnitsInStock==0).Take(3);
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0).TakeLast(3);
            //var Result = ProductsList.Skip(10).Take(5);
            //var Result = ProductsList.SkipLast(5);
            //int[] Numbers = { 9,6,4, 1, 2, 3, 4, 5 };
            ////var Result = Numbers.TakeWhile((N) => N % 3 == 0);
            //var Result = Numbers.SkipWhile((N) => N % 3 == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Let and Into
            //List<string> Names = new List<string>() { "Manar", "Hanya", "Rana", "Ali"};
            ////var Result = from Name in Names
            ////             select Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)
            ////             into NewNames
            ////             where NewNames.Length > 2
            ////             select NewNames;
            //var Result = from Name in Names
            //             let NewNames=Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)

            //             where NewNames.Length > 2
            //             select NewNames;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            //var Result=Regex.Replace("Manar","[aeoiuAEOIU]",string.Empty);
            //Console.WriteLine(Result);
            #endregion
            #region LINQ - Restriction Operators
            //1. Find all products that are out of stock.
            //var Result = ProductsList.Where(P=>P.UnitsInStock==0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0&& P.UnitPrice>3.00M);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result=Arr.Where((Num,I)=>Num.Length<I);
            //foreach (var Num in Result)
            //{
            //    Console.WriteLine(Num);
            //}
            #endregion
            #region LINQ - Element Operators
            //1. Get first Product out of Stock 
            //var Result = ProductsList.FirstOrDefault(P=>P.UnitsInStock==0);
            //Console.WriteLine(Result);
            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductsList.FirstOrDefault(P=>P.UnitPrice>1000);
            //Console.WriteLine(Result);
            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(N => N > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(Result);
            #endregion
            #region LINQ - Aggregate Operators
            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(N => N % 2 != 0);
            //Console.WriteLine(Result);
            //2. Return a list of customers and how many orders each has.
            //var customerOrderCounts = from c in CustomersList
            //                          group c by c.CustomerName
            //                         into order
            //                          select new { CustomerName = order.Key, OrderCount = order.Count() };

            //foreach (var item in customerOrderCounts)
            //{
            //    Console.WriteLine(item);
            //}
            //3. Return a list of categories and how many products each has
            //var CategoriesCounts = from p in ProductsList
            //                       group p by p.Category
            //                       into C
            //                       select new { CategoryName = C.Key, CategoryCount = C.Count() };
            //foreach (var item in CategoriesCounts)
            //{
            //    Console.WriteLine(item);
            //}
            // 4.Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count();
            //Console.WriteLine(Result);
            //5.Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string filePath = "dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);

            //int totalCharacters = words.Sum(word => word.Length);

            //Console.WriteLine("Total number of characters: " + totalCharacters);
            //6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);

            //int shortestWordLength = words.Min(word => word.Length);

            //Console.WriteLine("Length of the shortest word: " + shortestWordLength);
            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);

            //int longestWordLength = words.Max(word => word.Length);

            //Console.WriteLine("Length of the longest word: " + longestWordLength);
            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);

            //double averageWordLength = words.Average(word => word.Length);

            //Console.WriteLine("Average word length: " + averageWordLength);

            #endregion
        }
    }
}
