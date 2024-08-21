using static LinQ_Guide.ListGenerator;

namespace LinQ_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is (LinQ)?
            // ===> (LinQ) : Language Integrated Query

            // ====> Featurs:
            // 1- Unified Syntex
            // 2- Tybe Safety

            // +40 Extention Methods => Interface : IEnumerable
            // Linq Operators => 13 Categories
            // It works on aganist any data (Stored in Sequence), Ragardless database provider (sql, postgre, MySql)

            // Local Sequence ==> L2O, L2XML
            // Remote Sequence ==> L2EF

            #endregion

            #region LinQ Syntax
            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            // LinQ Syntax:
            // 1- Fluent Syntax (Method Syntax)
            // 2- Query Syntax

            #region 1- Fluent Syntax (Method Syntax)
            //// 1- Calll "LinQ Operator" as static Method through "Enumerable" class
            //var oddNumbers = Enumerable.Where(numbers, x => x % 2 == 1);

            //// 2- Call "LinQ Operator" as Extention Method
            //var oddNumbers = numbers.Where(x => x % 2 == 1);


            //foreach (int number in oddNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region 2- Query Syntax
            // ==> Query Expression => Like SQL Query

            // Sequence of write:
            // 1- Start with "from"
            // 2- Introduce range variable (x) => represent each element in the sequence
            // 3- End with "select" or "groub by"

            //var oddNumbers = from number in numbers
            //                 where number%2 != 0
            //                 select number;

            //foreach (var number in oddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #endregion

            #region LinQ Execution Ways
            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            //LinQ Execution Ways:
            // 1- Differed Execution ==> All LinQ Category except three Category.
            // 2- Immediate Execution ==> LinQ Categorys : 1) Element Operators 2) Casting Operators 4) Aggregate Operators

            #region 1- Differed Execution
            // ==> LinQ Query Execute in last version of Data when we Call it.

            //var oddNumbers = numbers.Where(x => x % 2 == 1);

            //numbers.AddRange([10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20]);

            //foreach (int number in oddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 2- Immediate Execution
            // ==> LinQ Query Execute Immediately.
            //1) Element Operators 2) Casting Operators 4) Aggregate Operators

            //var oddNumbers = numbers.Where(x => x % 2 == 1).ToList(); // ==> (ToList()) Casting Operators

            //numbers.AddRange([10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20]);

            //foreach (int number in oddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #endregion

            #region Filteration (Restrictions) Operators [Where - OfTybe]
            //////// ======> Where:

            //// ===> Ex1:
            //// Fluent Syntax:
            //var outOfStockProducts = ProductList.Where(product => product.UnitsInStock == 0);

            //// Query Syntax:
            //var outOfStockProducts = from product in ProductList
            //                         where product.UnitsInStock == 0
            //                         select product;

            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine(product);
            //}


            //// ===> Ex2:
            //// Fluent Syntax:
            //var outOfStockProductsWithCategoryMeatPoultry = ProductList.Where(product => product.UnitsInStock == 0 && product.Category == "Meat/Poultry");

            //// Query Syntax:
            //var outOfStockProductsWithCategoryMeatPoultry = from product in ProductList
            //                         where product.UnitsInStock == 0 && product.Category == "Meat/Poultry"
            //                         select product;

            //foreach (var product in outOfStockProductsWithCategoryMeatPoultry)
            //{
            //    Console.WriteLine(product);
            //}

            //// ## Indexed Where ## ===> Valid only on Fluent Syntax, can`t write it in Query Syntax.


            //// ===> Ex3:
            //var outOfStockProductsInFirst20 = ProductList.Where((product, index) => index < 20 && product.UnitsInStock == 0);

            //foreach (var product in outOfStockProductsInFirst20)
            //{
            //    Console.WriteLine(product);
            //}


            //////// ======> OfTybe:

            //// ===> Ex4:
            //ArrayList maxedList = [ 1, "Adham", 4, 3, "Elagaty", 7, 2];

            //var numbers = maxedList.OfType<int>();

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Transformation (Projection) OPerators [Select - SelectMany]
            //////// ======> Select:

            //// ===> Ex1:
            //// Fluent Syntax:
            //var productsName = ProductList.Select(product => product.ProductName);

            //// Query Syntax:
            //var productsName = from product in ProductList
            //                   select product.ProductName;

            //foreach (var product in productsName)
            //{
            //    Console.WriteLine(product);
            //}

            //// ## Indexed Select ## ===> Valid only on Fluent Syntax, can`t write it in Query Syntax.

            //// ===> Ex2:
            //var productsNameOutOfStock = ProductList.Where(product => product.UnitsInStock == 0).Select((product, index) => $"{index} : {product.ProductName}");

            //foreach (var product in productsNameOutOfStock)
            //{
            //    Console.WriteLine(product);
            //}

            //// ## Multi Select ## ===> By using anonymous object.

            //// ===> Ex3:
            /////// Fluent Syntax:
            //var products = ProductList.Select(product => new { id = product.ProductID, name = product.ProductName, price = product.UnitPrice});

            //// Query Syntax:
            //var products = from product in ProductList
            //               select new { id = product.ProductID, name = product.ProductName, price = product.UnitPrice };

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            //////// ======> SelectMany: ===> Select Data and Flattens it.

            //// ===> Ex4:
            //// Fluent Syntax:
            //var customersOrder = CustomerList.SelectMany(customer => customer.Orders);

            //// Query Syntax:
            //var customersOrder = from customer in CustomerList
            //                     from order in customer.Orders
            //                     select order;

            //foreach (var order in customersOrder)
            //{
            //    Console.WriteLine(order);
            //}

            //// ===> Ex5:
            //var students = new[] {
            //    new {Name = "Adham", Grades = new[] {85, 90, 70 }},
            //    new {Name = "Saif", Grades = new[] {80, 40, 75 }},
            //    new {Name = "Ahmed", Grades = new[] {95, 60, 66 }},
            //};

            //// Fluent Syntax:
            //var studentsWithGrade = students.SelectMany(student => student.Grades, (student, grade) => new {Name = student.Name, grade = grade});

            //// Query Syntax:
            //var studentsWithGrade = from student in students
            //                        from grade in student.Grades
            //                        select new { Name = student.Name, grade = grade };

            //foreach (var student in studentsWithGrade)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            #region Ordering Operators
            //// ===> Ex1:
            //// Fluent Syntax:
            //var productsInAscendingOrder = ProductList.OrderBy(product => product.UnitPrice);

            //// Query Syntax:
            //var productsInAscendingOrder = from product in ProductList
            //                               orderby product.UnitPrice
            //                               select product;

            //foreach (var product in productsInAscendingOrder)
            //{
            //    Console.WriteLine(product);
            //}


            //// ===> Ex2:
            //// Fluent Syntax:
            //var productsInDecscendingOrder = ProductList.OrderByDescending(product => product.UnitPrice);

            //// Query Syntax:
            //var productsInDecscendingOrder = from product in ProductList
            //                                 orderby product.UnitPrice descending
            //                                 select product;

            //foreach (var product in productsInDecscendingOrder)
            //{
            //    Console.WriteLine(product);
            //}


            //// ===> Ex3:
            //// Fluent Syntax:
            //var productsPriceInAscendingOrderAndStockDecscendingOrder = ProductList.OrderBy(product => product.UnitPrice).ThenByDescending(product => product.UnitsInStock);

            //// Query Syntax:
            //var productsPriceInAscendingOrderAndStockDecscendingOrder = from product in ProductList
            //                                                            orderby product.UnitPrice, product.UnitsInStock descending
            //                                                            select product;

            //foreach (var product in productsPriceInAscendingOrderAndStockDecscendingOrder)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Element Operators - Immediate Exection
            //// ## (Element Operators) ===> Valid only on Fluent Syntax.
            //List<Product> products = new List<Product>();

            //////// ======> First (Throw Exception if is Empty), FirstOrDefault (If is empty get Defult value):
            //// ===> Ex1:
            //var product = products.First();
            //var product = ProductList.First(product => product.UnitsInStock == 0);
            //var product = products.FirstOrDefault();
            //var product = products.FirstOrDefault(new Product{ProductName = "Chai", UnitPrice = 18m });

            //Console.WriteLine(product);

            //////// ======> Last (Throw Exception if is Empty), LastOrDefault (If is empty get Defult value):
            //// ===> Ex2:
            //var product = products.Last();
            //var product = ProductList.Last(product => product.UnitsInStock == 0);
            //var product = products.LastOrDefault();
            //var product = products.LastOrDefault(new Product{ProductName = "Chai", UnitPrice = 18m });

            //Console.WriteLine(product);

            //////// ======> ElementAt (Throw Exception when Element not Found), ElementAtOrDefault (If Element not Found get Defult value):
            //// ===> Ex3:
            //var product = ProductList.ElementAt(5);
            //var product = ProductList.ElementAt(new Index(5, true)); // to get from last
            //var product = ProductList.ElementAtOrDefault(new Index(500));

            //Console.WriteLine(product);

            //////// ======> Single (Throw Exception when Collection is Empty or has more than one elment), SingleOrDefault(Throw Exception when Collection has more than one elment and if Collection is empty):
            //// ===> Ex4:
            //var product = ProductList.Single();
            //var product = ProductList.SingleOrDefault();
            //var product = ProductList.SingleOrDefault(product => product.UnitsInStock == 0);

            //Console.WriteLine(product);


            //var product = (from prod in ProductList
            //               where prod.UnitsInStock == 0
            //               select prod).Where(product => product.Category == "Meat/Poultry");
            //Console.WriteLine(product);
            #endregion

            #region Aggregate Operators - Immediate Execution
            //// ## (Aggregate Operators) ===> Valid only on Fluent Syntax.

            //// ===> Ex1:
            //var result = ProductList.Count;
            //Console.WriteLine(result);

            //// ===> Ex2:
            //var result = ProductList.Count(product => product.UnitsInStock == 0);
            //Console.WriteLine(result);

            //// ===> Ex3:
            //var result = ProductList.Max(product => product.UnitsInStock); // return value
            //Console.WriteLine(result);

            //// ===> Ex4:
            //var result = ProductList.MaxBy(product => product.UnitsInStock); // return object
            //Console.WriteLine(result);

            //// ===> Ex5:
            //var result = ProductList.Min(product => product.UnitsInStock); // return value
            //Console.WriteLine(result);

            //// ===> Ex6:
            //var result = ProductList.MinBy(product => product.UnitsInStock); // return object
            //Console.WriteLine(result);

            //// ===> Ex7:
            //var result = ProductList.OrderByDescending(product => product.UnitsInStock).FirstOrDefault();
            //Console.WriteLine(result);

            //// ===> Ex8:
            //var result = ProductList.Sum(product => product.UnitPrice);
            //Console.WriteLine(result);

            //// ===> Ex9:
            //var result = ProductList.Average(product => product.UnitPrice);
            //Console.WriteLine(result);

            //// ===> Ex10:
            //List<int> num = [8, 9, 2, 4, 1, 6, 5];
            //var result = num.Aggregate((x,y) => x + y);
            //var result = num.Aggregate((x,y) => x - y);
            //var result = num.Aggregate((x, y) => x * y);
            //var result = num.Aggregate((x, y) => x / y);
            //Console.WriteLine(result);

            #endregion

            #region Casting Operators - Immediate Execution
            //// ## (Casting Operators) ===> Valid only on Fluent Syntax.

            //// ===> Ex1:
            //List<Product> product = ProductList.Where(product => product.UnitsInStock == 0).ToList();
            //Console.WriteLine(product);

            //// ===> Ex2:
            //Product[] product = ProductList.Where(product => product.UnitsInStock == 0).ToArray();
            //Console.WriteLine(product);

            //// ===> Ex3:
            //Dictionary<long,Product> product = ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID);
            //Console.WriteLine(product);

            //// ===> Ex4:
            //Dictionary<long, string> product = ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID, product => product.ProductName);
            //Console.WriteLine(product);
            #endregion

            #region Generation Method
            //// The only way to work with Generation Operators is by using Enumerable Class and Call it as static method.

            //// ===> Ex1:
            //var result = Enumerable.Range(1, 100);
            //foreach (var res in result)
            //{
            //    Console.WriteLine(res);
            //}

            //// ===> Ex2:
            //var result = Enumerable.Repeat("Adham",100);
            //foreach (var res in result)
            //{
            //    Console.WriteLine(res);
            //}

            //// ===> Ex3:
            //var result = Enumerable.Empty<int>().ToList();
            //foreach (var res in result)
            //{
            //    Console.WriteLine(res);
            //}
            #endregion

            #region Set Operators - Union Family
            //var sequence01 = Enumerable.Range(0, 100);  // 0 - 99
            //var sequence02 = Enumerable.Range(50, 100); // 50 - 149

            //// ===> Ex1:
            //var result = sequence01.Union(sequence02);
            //foreach (var res in result)
            //    Console.WriteLine(res);

            //// ===> Ex2:
            //var result = sequence01.Concat(sequence02);
            //foreach (var res in result)
            //    Console.WriteLine(res);

            //// ===> Ex3:
            //var result = sequence01.Union(sequence02);
            //foreach (var res in result)
            //    Console.WriteLine(res);

            //// ===> Ex4:
            //var result = sequence01.Intersect(sequence02);
            //foreach (var res in result)
            //    Console.WriteLine(res);

            //// ===> Ex5:
            //var result = sequence01.Except(sequence02);
            //foreach (var res in result)
            //    Console.WriteLine(res);

            //// ===> Ex6:
            //var list1 = new List<Product>()
            //{
            //    ProductList[0],            // Chai
            //    ProductList[1],            // Chang
            //    ProductList[2],            // Aniseed Syrup
            //    ProductList[3],            // Chef Anton's Cajun Seasoning
            //    ProductList[4]             // Chef Anton's Gumbo Mix
            //};

            //var list2 = new List<Product>()
            //{
            //    ProductList[5] ,           // Grandma's Boysenberry Spread
            //    ProductList[6] ,           // Uncle Bob's Organic Dried Pears
            //    ProductList[7] ,           // Northwoods Cranberry Sauce
            //    ProductList[8] ,           // Mishi kobe Niku
            //    ProductList[9]             // Ikura
            //};

            //var result = list1.Union(list2);
            //foreach (var res in result)
            //    Console.WriteLine(res);
            #endregion

            #region Quantifier Operators
            // This operators return value tybe true.
            //var sequence01 = Enumerable.Range(0, 100);  // 0 - 99
            //var sequence02 = Enumerable.Range(50, 100); // 50 - 149

            //// ===> Ex1:
            //bool flag = ProductList.Any();
            //Console.WriteLine(flag);

            //// ===> Ex2:
            //bool flag = ProductList.Any(x => x.UnitsInStock == 0);
            //Console.WriteLine(flag);

            //// ===> Ex3:
            //bool flag = ProductList.Any(x => x.UnitsInStock == 200);
            //Console.WriteLine(flag);

            //// ===> Ex4:
            //List<Product> products = new List<Product>();
            //bool flag = products.Any();
            //Console.WriteLine(flag);

            //// ===> Ex5:
            //bool flag = ProductList.All(x => x.UnitsInStock == 0);
            //Console.WriteLine(flag);
            #endregion

            #region Transformation Operators (Projection) - zip Operator
            //// ===> Ex:
            //List<string> names = ["Ahmed", "Ali", "Osama", "Hossam", "Aya"];

            //List<int> number = Enumerable.Range(1, 10).ToList();

            //var result = number.Zip(names, new List<int> { 10, 20, 30 });

            //foreach(var res in result)
            //    Console.WriteLine(res);
            #endregion

            #region Grouping Operator - GroupBy
            //// ===> Ex1:

            //// Fluent Syntax:
            //var productGroups = ProductList.GroupBy(product => product.Category);

            //// Query Syntax:
            //var productGroups = from product in ProductList
            //                    group product by product.Category;

            //foreach (var group in productGroups)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var product in group)
            //        Console.WriteLine(product);
            //    Console.WriteLine("================================");
            //}

            //// ===> Ex2:

            //// Fluent Syntax:
            //var productGroups = ProductList.Where(product => product.UnitsInStock > 0)
            //                                .GroupBy(product => product.Category)
            //                                .Where(group => group.Count() > 10)
            //                                .Select(productGroups => new { Category = productGroups.Key, Count = productGroups.Count()});

            //// Query Syntax:
            //var productGroups = from product in ProductList
            //                    where product.UnitsInStock > 0
            //                    group product by product.Category
            //                    into productGroup
            //                    where productGroup.Count() > 10
            //                    select new { Category = productGroup.Key, Count = productGroup.Count() };

            //foreach (var product in productGroups)
            //    Console.WriteLine(product);
            #endregion

            #region Partitionining Operators

            //////// ======> Take():
            //// ===> Ex1:
            //var result = ProductList.Where(product => product.Category == "Seafood").Take(5);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //////// ======> TakeLast():
            //// ===> Ex2:
            //var result = ProductList.Where(product => product.Category == "Seafood").TakeLast(5);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //////// ======> Skip():
            //// ===> Ex1:
            //var result = ProductList.Where(product => product.Category == "Seafood").Skip(5);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //////// ======> SkipLast():
            //// ===> Ex4:
            //var result = ProductList.Where(product => product.Category == "Seafood").SkipLast(5);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //// ### "Pagination" ===> How it`s Work:
            //// ===> Ex5:
            //int PageIndex = 0, PageSize = 10;

            //var result = ProductList.Skip((PageIndex-1) * PageSize).Take(PageSize);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            //////// ======> TakeWhile():
            //// ===> Ex6:
            //List<int> numbers = [5, 7, 8, 1, 2, 3, 6, 4];
            //var result = numbers.TakeWhile((numbers, Index) => numbers > Index);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //////// ======> SkipWhile():
            //// ===> Ex7:
            //List<int> numbers = [5, 7, 8, 1, 2, 3, 6, 4];
            //var result = numbers.SkipWhile(number => number % 3 != 0);
            //foreach (var product in result)
            //    Console.WriteLine(product);
            #endregion

            #region Let / into
            //List<string> names = ["Adham", "Ahmed", "Hassan", "Moamen", "Nadia", "Kareem", "Ali"];

            //////// ======> into:
            //// ===> Ex1:

            //var result = from name in names
            //             select Regex.Replace(name, "[aeiouAEIOU]", string.Empty)
            //             into newName
            //             where newName.Length >= 3
            //             select newName;

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}


            //////// ======> let:
            //// ===> Ex2:
            //var result = from name in names
            //             let newName = Regex.Replace(name, "[aeiouAEIOU]", string.Empty)
            //             where newName.Length >= 3
            //             select newName;
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Chunk
            //// ===> Ex:
            //var chunkedProduct = ProductList.Chunk(5);
            //foreach (var product in chunkedProduct)
            //{
            //    foreach (var item in product)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("==========================================");
            //}
            #endregion

            #region Cast
            //// ===> Ex:
            //IEnumerable<object> objects = [1, 2, 3, 4, 5, 6, 7];
            //IEnumerable<int> numbers = objects.Cast<int>();

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine($"{number}");
            //}
            #endregion

            #region Contains
            //// ===> Ex:
            //bool isExist = ProductList.Select(x => x.Category).Contains("Produce");
            //Console.WriteLine(isExist);
            #endregion

            #region Append
            //// ===> Ex:
            //var pro = ProductList.Append(new Product
            //{
            //    ProductID = 10,
            //    Category = "dofkofsk",
            //    ProductName = "sssfmobosm",
            //    UnitPrice = 0,
            //    UnitsInStock = 0,
            //});

            //var pro2 = pro.Append(new Product
            //{
            //    ProductID = 11,
            //    Category = "dofkofsk",
            //    ProductName = "sssfmobosm",
            //    UnitPrice = 0,
            //    UnitsInStock = 0,
            //});

            //foreach (var pr in pro2)
            //{
            //    Console.WriteLine(pr);
            //}
            #endregion

            #region LongCount
            //// ===> Ex:
            //var count = ProductList.LongCount();
            //Console.WriteLine(count);
            #endregion

            #region Questions
            #region 1-LINQ - Restriction Operators
            ////=====> 1- Find all products that are out of stock.
            //var outOfStockProducts = from product in ProductList
            //                         where product.UnitsInStock == 0
            //                         select product;

            //Console.WriteLine("Products that are out of stock:");
            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine(product);
            //}


            ////=====> 2- Find all products that are in stock and cost more than 3.00 per unit.
            //var inStockAndCostlyProducts = from product in ProductList
            //                               where product.UnitsInStock > 0 && product.UnitPrice > 3.00M
            //                               select product;

            //Console.WriteLine("Products that are in stock and cost more than 3.00 per unit:");
            //foreach (var product in inStockAndCostlyProducts)
            //{
            //    Console.WriteLine(product);
            //}


            ////=====> 3- Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shorterThanValue = from digit in Arr
            //                       where digit.Length < Array.IndexOf(Arr, digit)
            //                       select digit;

            //Console.WriteLine("Digits whose name is shorter than their value:");
            //foreach (var digit in shorterThanValue)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #region 2-LINQ - Ordering Operators
            ////=====> 1- Sort a list of products by name.
            //var sortedProductsByName = ProductList.OrderBy(p => p.ProductName);
            //Console.WriteLine("Products sorted by name:");
            //foreach (var product in sortedProductsByName)
            //{
            //    Console.WriteLine(product);
            //}

            ////=====> 2- Use a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = words.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine("Words sorted case-insensitively:");
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}


            ////=====> 3- Sort a list of products by units in stock from highest to lowest.
            //var sortedProductsByStock = ProductList.OrderByDescending(p => p.UnitsInStock);
            //Console.WriteLine("\nProducts sorted by units in stock (highest to lowest):");
            //foreach (var product in sortedProductsByStock)
            //{
            //    Console.WriteLine(product);
            //}


            ////=====> 4- Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var sortedDigits = digits.OrderBy(digit => digit.Length).ThenBy(digit => digit);
            //Console.WriteLine("\nDigits sorted by length and then alphabetically:");
            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #region 3-LINQ – Transformation Operators
            ////=====> 1- Return a sequence of just the names of a list of products.
            //var productNames = ProductList.Select(p => p.ProductName);
            //Console.WriteLine("Product names:");
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            ////=====> 2- Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var wordCases = words.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });
            //Console.WriteLine("Uppercase and lowercase versions of words:");
            //foreach (var word in wordCases)
            //{
            //    Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            //}

            ////=====> 3- Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var productDetails = ProductList.Select(p => new
            //{
            //    p.ProductName,
            //    Price = p.UnitPrice,
            //    p.UnitsInStock
            //});
            //Console.WriteLine("Product details with renamed UnitPrice to Price:");
            //foreach (var product in productDetails)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.Price}, Units in Stock: {product.UnitsInStock}");
            //}
            #endregion

            #region 4- LINQ - Element Operators
            ////=====> 1- Get the first product out of stock.
            //var firstOutOfStockProduct = ListGenerator.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine("First product out of stock:");
            //if (firstOutOfStockProduct != null)
            //{
            //    Console.WriteLine(firstOutOfStockProduct);
            //}
            //else
            //{
            //    Console.WriteLine("No product is out of stock.");
            //}

            ////=====> 2- Return the first product whose price > 1000, unless there is no match, in which case null is returned.
            //var expensiveProduct = ListGenerator.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine("First product with price > 1000:");
            //if (expensiveProduct != null)
            //{
            //    Console.WriteLine(expensiveProduct);
            //}
            //else
            //{
            //    Console.WriteLine("No product found with price > 1000.");
            //}

            ////=====> 3- Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumberGreaterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine("Second number greater than 5:");
            //Console.WriteLine(secondNumberGreaterThan5);
            #endregion

            #region 5- LINQ - Aggregate Operators
            //string[] words = File.ReadAllLines("../../../dictionary_english.txt");

            ////=====> 1- Count the number of odd numbers in the array
            //int[] arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int oddCount = arr1.Count(n => n % 2 != 0);
            //Console.WriteLine($"Number of odd numbers: {oddCount}");

            ////=====> 2- Return a list of customers and how many orders each has
            //var customers = ListGenerator.CustomerList
            //    .Select(c => new { Customer = c.CustomerName, OrderCount = c.Orders.Length })
            //    .ToList();
            //customers.ForEach(c => Console.WriteLine($"Customer: {c.Customer}, Orders: {c.OrderCount}"));

            ////=====> 3- Return a list of categories and how many products each has
            //var categoriesProductCount = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, ProductCount = g.Count() })
            //    .ToList();
            //categoriesProductCount.ForEach(c => Console.WriteLine($"Category: {c.Category}, Products: {c.ProductCount}"));

            ////=====> 4- Get the total of the numbers in an array
            //int[] arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int totalSum = arr2.Sum();
            //Console.WriteLine($"Total sum of the numbers: {totalSum}");

            ////=====> 5- Get the total number of characters of all words in dictionary_english.txt
            //int totalChars = words.Sum(w => w.Length);
            //Console.WriteLine($"Total number of characters: {totalChars}");

            ////=====> 6- Get the length of the shortest word in dictionary_english.txt
            //int shortestWordLength = words.Min(w => w.Length);
            //Console.WriteLine($"Length of the shortest word: {shortestWordLength}");

            ////=====> 7- Get the length of the longest word in dictionary_english.txt
            //int longestWordLength = words.Max(w => w.Length);
            //Console.WriteLine($"Length of the longest word: {longestWordLength}");

            ////=====> 8- Get the average length of the words in dictionary_english.txt
            //double averageWordLength = words.Average(w => w.Length);
            //Console.WriteLine($"Average length of the words: {averageWordLength}");

            ////=====> 9- Get the total units in stock for each product category
            //var categoryUnitsInStock = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) })
            //    .ToList();
            //categoryUnitsInStock.ForEach(c => Console.WriteLine($"Category: {c.Category}, Total Units in Stock: {c.TotalUnitsInStock}"));
            #endregion

            #region 6- LINQ - Set Operators
            //var productFirstLetters = ListGenerator.ProductList.Select(p => p.ProductName[0]).Distinct();
            //var customerFirstLetters = ListGenerator.CustomerList.Select(c => c.CustomerName[0]).Distinct();


            ////=====> 1- Find the unique Category names from Product List
            //var uniqueCategories = ListGenerator.ProductList.Select(p => p.Category).Distinct().ToList();
            //uniqueCategories.ForEach(c => Console.WriteLine($"Unique Category: {c}"));

            ////=====> 2 - Produce a Sequence containing the unique first letter from both product and customer names
            //var uniqueFirstLetters = productFirstLetters.Union(customerFirstLetters).ToList();
            //uniqueFirstLetters.ForEach(letter => Console.WriteLine($"Unique First Letter: {letter}"));

            ////=====> 3- Create one sequence that contains the common first letter from both product and customer names
            //var commonFirstLetters = productFirstLetters.Intersect(customerFirstLetters).ToList();
            //commonFirstLetters.ForEach(letter => Console.WriteLine($"Common First Letter: {letter}"));

            ////=====> 4- Create one sequence that contains the first letters of product names that are not also first letters of customer names
            //var productExclusiveFirstLetters = productFirstLetters.Except(customerFirstLetters).ToList();
            //productExclusiveFirstLetters.ForEach(letter => Console.WriteLine($"Product Exclusive First Letter: {letter}"));

            ////=====> 5- Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var productLastThreeChars = ListGenerator.ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName).ToList();

            //var customerLastThreeChars = ListGenerator.CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName).ToList();

            //var allLastThreeChars = productLastThreeChars.Union(customerLastThreeChars).ToList();
            //allLastThreeChars.ForEach(chars => Console.WriteLine($"Last Three Characters: {chars}"));
            #endregion

            #region 7- LINQ - Quantifiers
            ////=====> 1- Determine if any of the words in dictionary_english.txt contain the substring 'ei'
            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            //bool containsEi = dictionaryWords.Any(word => word.Contains("ei"));
            //Console.WriteLine($"Any word contains 'ei': {containsEi}");

            ////=====> 2- Return a grouped list of products only for categories that have at least one product that is out of stock
            //var groupedProductsOutOfStock = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0))
            //    .ToList();

            //Console.WriteLine("Categories with at least one product out of stock:");
            //foreach (var group in groupedProductsOutOfStock)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}

            ////=====> 3- Return a grouped list of products only for categories that have all of their products in stock
            //var groupedProductsAllInStock = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0))
            //    .ToList();

            //Console.WriteLine("Categories with all products in stock:");
            //foreach (var group in groupedProductsAllInStock)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}
            #endregion

            #region 8- LINQ – Grouping Operators
            ////=====> 1- Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groupedNumbers = from number in numbers
            //                     group number by number % 5 into g
            //                     orderby g.Key
            //                     select g;

            //foreach (var group in groupedNumbers)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Extra Questions
            ////=====> 1- Get the first 3 orders from customers in Washington.
            //var firstThreeOrdersFromWashington = CustomerList
            //    .Where(customer => customer.Region == "WA")
            //    .SelectMany(customer => customer.Orders)
            //    .Take(3);

            //foreach (var order in firstThreeOrdersFromWashington)
            //{
            //    Console.WriteLine(order);
            //}

            ////=====> 2- Get all but the first 2 orders from customers in Washington.
            //var allButFirstTwoOrdersFromWashington = CustomerList
            //    .Where(customer => customer.Region == "WA")
            //    .SelectMany(customer => customer.Orders)
            //    .Skip(2);

            //foreach (var order in allButFirstTwoOrdersFromWashington)
            //{
            //    Console.WriteLine(order);
            //}


            ////=====> 3- Return elements starting from the beginning of the array until a number is less than 100.
            //var ordersBelow100 = CustomerList
            //    .SelectMany(customer => customer.Orders)
            //    .TakeWhile(order => order.Total < 100);

            //foreach (var order in ordersBelow100)
            //{
            //    Console.WriteLine(order);
            //}


            ////=====> 4- Get the elements of the array starting from the first element divisible by a given number.
            //int divisor;
            //bool isValidInput = true;
            //do
            //{
            //    if (!isValidInput)
            //    {
            //        Console.Clear();
            //        Console.BackgroundColor = ConsoleColor.Black;
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Error! Please Enter a Valid Number :(");
            //        Console.ResetColor();
            //    }
            //    Console.WriteLine("Enter a divisor:");
            //    isValidInput = int.TryParse(Console.ReadLine(), out divisor);
            //} while (!isValidInput);

            //int[] numbersArray = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var numbersDivisibleByDivisor = numbersArray.SkipWhile(number => number % divisor != 0);

            //foreach (var number in numbersDivisibleByDivisor)
            //{
            //    Console.WriteLine(number);
            //}

            ////=====> 5- Get the elements of the array starting from the first element less than its position.
            //int[] numbersArray2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var elementsLessThanIndex = numbersArray2.SkipWhile((number, index) => number >= index);

            //foreach (var number in elementsLessThanIndex)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #endregion
        }
    }
}
