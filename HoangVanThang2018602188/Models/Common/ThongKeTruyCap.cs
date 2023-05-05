﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HoangVanThang2018602188.Models.Common
{
    public class ThongKeTruyCap
    {
        public static string strConnect = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
   
        public static ThongKeViewModel ThongKe()
        {
            using(var connect=new SqlConnection(strConnect))
            {
                var item = connect.QueryFirstOrDefault<ThongKeViewModel>("sp_ThongKe", commandType: CommandType.StoredProcedure);
                return item;
            }
        }
    }
}