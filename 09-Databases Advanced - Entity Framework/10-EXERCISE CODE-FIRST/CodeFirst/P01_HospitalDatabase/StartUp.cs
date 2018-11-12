﻿using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Initializer;

namespace P01_HospitalDatabase
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (HospitalContext context = new HospitalContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                DatabaseInitializer.InitialSeed(context);
            }
        }
    }
}
