﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day11And12JSONInventoryDataManagement
{
    class FetchJsonForRice
    {
        public Rice Read(string Path)
        {

            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }

            }
        }
    }
}
