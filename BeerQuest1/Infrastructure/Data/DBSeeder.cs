using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Infrastructure.Data
{
    public static class DBSeeder
    {
        public static void SeedDb(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            context.Businesses.Add(
               new Business { Name = "Milwaukee Ale House", Pin = 1111, Address = "233 N Water St", City = "Milwaukee", State = "WI", lat = 43.0334116, lng = -87.909373, CheckIns = 11, Premium = true });
            context.Businesses.Add(
             new Business { Name = "Cafe Benelux", Pin = 1111, Address = "346 N Broadway", City = "Milwaukee", State = "WI", lat = 43.0348922, lng = -87.9069337, Premium = true });
            context.Businesses.Add(
             new Business { Name = "My Office", Pin = 1111, Address = "763 N Milwaukee St", City = "Milwaukee", State = "WI", lat = 43.0403911, lng = -87.9070968, Premium = true });
            context.Businesses.Add(
             new Business { Name = "Swinging Door Exchange", Pin = 1111, Address = "219 E Michigan St", City = "Milwaukee", State = "WI", lat = 43.0373425, lng = -87.908272, CheckIns = 11, });
            context.Businesses.Add(
             new Business { Name = "The Outsider", Pin = 1111, Address = "310 E Chicago St", City = "Milwaukee", State = "WI", lat = 43.0329963, lng = -87.9068243 });
            context.Businesses.Add(
             new Business { Name = "Mos Irish Pub Downtown Milwaukee", Pin = 1111, Address = "142 W Wisconsin Ave", City = "Milwaukee", State = "WI", lat = 43.0389254, lng = -87.9115365 });
            context.Businesses.Add(
             new Business { Name = "Bugsys Back Alley Speakeasy", Pin = 1111, Address = "218 N Water St", City = "Milwaukee", State = "WI", lat = 43.0329044, lng = -87.9086043 });
            context.Businesses.Add(
             new Business { Name = "Taylors", Pin = 1111, Address = "795 N Jefferson St", City = "Milwaukee", State = "WI", lat = 43.0411026, lng = -87.9057456 });
            context.Businesses.Add(
             new Business { Name = "Camp Bar Third Ward", Pin = 1111, Address = "525 E Menomonee St", City = "Milwaukee", State = "WI", lat = 43.0315666, lng = -87.9035881 });
            context.Businesses.Add(
             new Business { Name = "Flannerys MKE", Pin = 1111, Address = "425 E Wells St", City = "Milwaukee", State = "WI", lat = 43.0410744, lng = -87.9059173 });
            context.Businesses.Add(
             new Business { Name = "Tre Rivali", Pin = 1111, Address = "200 N Broadway", City = "Milwaukee", State = "WI", lat = 43.0328086, lng = -87.9069583 }
            );

            context.SaveChanges();
        }
            public static void SeedMessage(ApplicationDbContext context)
        {
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("14/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("14/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("14/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("14/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("14/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("14/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("14/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("14/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank Hill", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office",  CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("17/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
            new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("15/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("16/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("18/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
               new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
               new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
               new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
               new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
               new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
               new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
               new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank Hill", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("19/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("20/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
             new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("21/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Spooderman", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Riddick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Hank", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Richard", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Patrick", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Brett", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Henry", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });
            context.Messages.Add(
                new Message { CurrentMember = "Shawn", CurrentBar = "My Office", CurrentDay = DateTime.ParseExact("22/06/2019 13:45:00", "dd/MM/yyyy HH:mm:ss", null), WasFree = false, CurrentRank = "Noob Drinker" });


            context.SaveChanges();
        }
        public static void RankSeeder(ApplicationDbContext context)
        {
            context.Ranks.Add(
    new Rank { Name = "Noob Drinker", Points = 0 });
            context.Ranks.Add(
    new Rank { Name = "Barely Buzzed", Points = 30 });
            context.Ranks.Add(
    new Rank { Name = "1 Shot Wonder", Points = 75 });
            context.Ranks.Add(
    new Rank { Name = "Adept Drunk", Points = 175 });
            context.Ranks.Add(
    new Rank { Name = "Bar Hopper", Points = 300 });
            context.Ranks.Add(
    new Rank { Name = "No Chasers", Points = 450 });
            context.Ranks.Add(
    new Rank { Name = "Beer Bong Pro", Points = 650 });
            context.Ranks.Add(
    new Rank { Name = "BlackOut Fiend", Points = 900 });
            context.Ranks.Add(
    new Rank { Name = "Alcoholic", Points = 1200 });
            context.Ranks.Add(
    new Rank { Name = "Drunken Master", Points = 1600 });
            context.SaveChanges();
        }
    }
}
