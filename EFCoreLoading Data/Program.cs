
using EFCoreLoading_Data.DataBaseContext;
using EFCoreLoading_Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace EFCoreLoading_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AirLineContext context = new AirLineContext();

            #region Last Task
            //a 
            //var airline = new AirLine
            //{
            //    Name = "EgyptAir",
            //    Address = "Cairo",
            //    Cont_Person = 0,
            //};

            //context.AirLines.Add(airline);
            //context.SaveChanges();

            ////b

            //var model01 = new AirCraft
            //{
            //    Model = "Model01",
            //    Capacity = 180,
            //    AirLineId = airline.AirLineId
            //};

            //context.AirCrafts.Add(model01);
            //context.SaveChanges();
            ////c

            //var tr = new Transaction
            //{
            //    Amount = 50000,
            //    Description = "Tickets",
            //    Date = DateTime.Now,
            //    AirLineId = airline.AirLineId
            //};

            //context.Transactions.Add(tr);
            //context.SaveChanges();

            ////d
            //var employees = context.Employees
            //           .Where(e => e.AirLineId == airline.AirLineId)
            //           .ToList();
            ////e
            //var trs = context.Transactions
            //     .Where(t => t.AirLineId == airline.AirLineId)
            //     .Select(t => new { t.TranactionId, t.Description, t.Amount })
            //     .ToList();
            ////f
            //var totals = context.Employees
            //        .GroupBy(e => e.AirLineId)
            //        .Select(g => new
            //        {
            //            AirLineId = g.Key,
            //            Count = g.Count()
            //        })
            //        .ToList();
            ////g
            //var model01AC = context.AirCrafts
            //           .First(a => a.Model == "Model01");

            //model01AC.Capacity = 200;

            //context.SaveChanges();
            ////h
            //var old = context.Transactions
            //      .Where(t => t.Date.Year < 2020)
            //      .ToList();

            //context.Transactions.RemoveRange(old);
            //context.SaveChanges();
            ////i

            //var route = new Route
            //{
            //    Origin = "Cairo",
            //    Destination = 1,
            //    Classification = "International",
            //    Distance = 2400
            //};

            //context.Routes.Add(route);
            //context.SaveChanges();

            ////j
            ///

            #endregion  //Add Data to DataBase


            #region Section A : Loading Related Data 

            #region Q1
            /*. Load "EgyptAir" With all its aircrafts and their routes */

            //var result = context.AirLines.Where(a => a.Name == "EgyptAir")
            //       .Include(a => a.airCrafts)
            //           .ThenInclude(ac => ac.ArouteAircraft)
            //       .FirstOrDefault();
            //if (result is not null)
            //{
            //    Console.WriteLine(result.AirLineId);
            //    Console.WriteLine(result.Name);
            //    foreach (var ac in result.airCrafts)
            //    {
            //        Console.WriteLine($"\tAircraft Model: {ac.Model}");
            //        foreach (var route in ac.ArouteAircraft)
            //        {
            //            Console.WriteLine($"\t\tRoute Duraction: {route.Duration}, Departure: {route.Departure}");
            //        }
            //    }

            //} 
            #endregion




            #region Q2
            /*Retrieve all airlines with their employees, and for each employee load their qualifications. */

            //var result = context.AirLines
            //       .Include(a => a.employees)

            //       .ToList();

            //foreach (var airline in result)
            //{
            //    Console.WriteLine($"Airline: {airline.Name}, Employees: {airline.employees.Count}");

            //    foreach (var emp in airline.employees)
            //    {
            //        Console.WriteLine($"   Employee: {emp.Name}");
            //    }
            //} 
            #endregion


            #region Q3
            /*Load all airlines with their transactions, but only include transactions where Amount > 10000 */
            //var result = context.AirLines.Include(T => T.transactions.Where(t => t.Amount > 10000)).ToList();

            //foreach (var airline in result)
            //{
            //    Console.WriteLine($"Airline: {airline.Name}, Transactions Count: {airline.transactions.Count}");
            //    foreach (var tr in airline.transactions)
            //    {
            //        Console.WriteLine($"   Transaction: {tr.Description}, Amount: {tr.Amount}");
            //    }
            //}

            #endregion



            #region Q4


            //var result = context.Routes
            //       .Include(r => r.RrouteAircraft)

            //       .ToList();


            //var result = context.Routes
            //       .Include(r => r.RrouteAircraft)
            //           .ThenInclude(ra => ra.NAirCraft)
            //           .ThenInclude(ac => ac.AirLine)
            //       .ToList();

            //  Console.WriteLine(result);





            //foreach (var route in result)
            //{
            //    Console.WriteLine(route.RouteId);

            //    foreach (var ra in route.RrouteAircraft)
            //    {
            //        Console.WriteLine($"\tDuration: {ra.Duration}, Departure: {ra.Departure}");

            //        Console.WriteLine();
            //    }   
            //}



            /*Select all routes along with the model of aircrafts assigned to them */

            //var result = context.Routes
            //       .Include(r => r.RrouteAircraft)
            //           .ThenInclude(ra => ra.NAirCraft)
            //       .ToList();

            //foreach (var route in result)
            //{
            //    Console.WriteLine(route.RouteId);

            //    foreach (var ra in route.RrouteAircraft)
            //    {
            //        Console.WriteLine($"\tDuration: {ra.Duration}, Departure: {ra.Departure}");

            //        Console.WriteLine("Model"+ra.NAirCraft.Model);
            //    }
            //}

            #endregion


            #region Q5

            /* Retrieve all aircrafts with their airline and the airline’s phones.*/

            //var result = context.AirCrafts.Include(A => A.AirLine).ToList();
            //foreach (var ac in result)
            //{
            //    Console.WriteLine($"Contact_ person : {ac.AirLine.Cont_Person}, Airline: {ac.AirLine.Name}");// i did not add phones property to Airline class

            #endregion


            #endregion



            #region Q1

            /*List all employees with their airline name. */

            //var result = context.Set<Employee>()
            //    .Join(
            //    context.AirLines,
            //    E => E.EmpId,
            //    A => A.AirLineId, (E, A) => new
            //    {
            //       AirlineName= A.Name,
            //        EmployeeName= E.Name,    
            //    });

            //foreach (var e in result) {
            //    Console.WriteLine(e);


            //}


            //Query

            //var result = from e in context.Employees
            //             join a in context.AirLines
            //             on e.AirLineId equals a.AirLineId
            //             select new
            //             {
            //                 EmployeeName = e.Name,
            //                 AirlineName = a.Name
            //             };
            //foreach (var e in result)
            //{
            //    Console.WriteLine(e);
            //} 
            #endregion


            #region Q2


            /*Show all routes with the aircraft model assigned and the airline name that owns the aircraft. */

            //var result = from r in context.Routes
            //             join ra in context.Set<RouteAircraft>()
            //             on r.RouteId equals ra.RouteId
            //             join ac in context.AirCrafts
            //             on ra.AirCraftId equals ac.AirCraftId
            //             join al in context.AirLines
            //             on ac.AirLineId equals al.AirLineId
            //             select new
            //             {
            //                 RouteId = r.RouteId,
            //                 AircraftModel = ac.Model,
            //                 AirlineName = al.Name
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.RouteId);
            //    Console.WriteLine(item.AircraftModel);
            //    Console.WriteLine(item.AirlineName);


            //} 
            #endregion

            #region Q3

            /*. For each airline, list its aircraft models. */

            //var result = context.Set<AirLine>().Join(
            //    context.AirCrafts,
            //    AL=>AL.AirLineId,
            //    AC=>AC.AirCraftId,
            //    (AL,AC) => new
            //    {
            //        AirlineName = AL.Name,
            //        AircraftModel = AC.Model
            //    }

            //    );

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.AirlineName);
            //    Console.WriteLine(item.AircraftModel);
            //} 
            #endregion


            #region Q4
            /*Show all transactions (id, amount, description) along with the airline name, but only where Amount > 20000.*/


            //var result = context.Set<AirLine>().Join(
            //    context.Transactions,
            //    AL => AL.AirLineId,
            //    AC => AC.TranactionId,
            //    (AL, AC) => new
            //    {
            //        TransactionName = AL.Name,
            //        TranactionId = AC.TranactionId,
            //        TranactionDescription = AC.Description,
            //        TransactionAmount = AC.Amount

            //    }
            //    );

            //foreach (var item in result)
            //{
            //    if (item.TransactionAmount > 20000)
            //    {
            //        Console.WriteLine(item.TransactionName);
            //        Console.WriteLine(item.TranactionId);
            //        Console.WriteLine(item.TranactionDescription);
            //        Console.WriteLine(item.TransactionAmount);
            //    }
            //} 
            #endregion







        }
    }
    }

