﻿using Dapper;
using Leap.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Leap.Data

{
    public class LeaperRepository
    {
        const string ConnectionString = "Server = localhost; Database = Leap; Trusted_Connection = True;";

        public Leaperer AddLeaper(string firstName, string lastName, int targetLeap)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var newLeaper = db.QueryFirstOrDefault<Leaperer>(@"
                    Insert into Leaper (firstName,lastName,targetLeap) 
                    Output inserted.*
                    Values(@firstName,@lastName,@targetLeap)",
                    new { firstName, lastName, targetLeap }); // setting up the parameters required - property needs to match the values above

                if (newLeaper != null)
                {
                    return newLeaper;
                }
            }

            throw new Exception("No user created");
        }
    }
}
