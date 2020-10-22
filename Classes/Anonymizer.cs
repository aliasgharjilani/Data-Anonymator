using Anonymator.Enums;
using Medallion;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;

//using System.Threading;
//using System.Threading.Tasks;

namespace Anonymator.Classes
{
    class Anonymizer
    {
        public static void Anonymate(DataTable dataTable, MappingDetails mappingDetails)
        {
            List<string> pkValuesInt = new List<string>();
            List<string> pkValuesAlpha = new List<string>();
            List<string> pkValuesAlphaNum = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (Mapping mapping in mappingDetails.Mappings)
                {
                    if (mapping.Anonymiser == Anonymizers.Drop || mapping.Anonymiser == Anonymizers.NoAction)
                        continue;

                    if (row.IsNull(mapping.Column.Name))
                        continue;

                    string colValue = row[mapping.Column.Name].ToString();

                    int valLength = colValue.Length;

                    switch (mapping.Column.Type.ToLower())
                    {
                        case "varchar":
                            if (mapping.Anonymiser == Anonymizers.Alpha)
                            {
                                AlphaMapping alphaMapping = (AlphaMapping)mapping;

                                string newValAlpha;

                                if (mapping.Column.IsPK)
                                {
                                    while (true)
                                    {
                                        newValAlpha = GenerateAlpha(valLength, alphaMapping.SelectedOption);
                                        if (pkValuesAlpha.Contains(newValAlpha))
                                            continue;

                                        pkValuesAlpha.Add(newValAlpha);
                                        break;
                                    }
                                }
                                else
                                {
                                    newValAlpha = GenerateAlpha(valLength, alphaMapping.SelectedOption);
                                }

                                row[mapping.Column.Name] = newValAlpha;
                            }
                            else if (mapping.Anonymiser == Anonymizers.AlphaNumeric)
                            {
                                AlphaMapping alphaMapping = (AlphaMapping)mapping;

                                string newValAlphaNum;

                                if (mapping.Column.IsPK)
                                {
                                    while (true)
                                    {
                                        newValAlphaNum = GenerateAlphaNumeric(valLength, alphaMapping.SelectedOption);
                                        if (pkValuesAlphaNum.Contains(newValAlphaNum))
                                            continue;

                                        pkValuesAlphaNum.Add(newValAlphaNum);
                                        break;
                                    }
                                }
                                else
                                {
                                    newValAlphaNum = GenerateAlphaNumeric(valLength, alphaMapping.SelectedOption);
                                }

                                row[mapping.Column.Name] = newValAlphaNum;
                            }

                            break;

                        case "int":
                            if (mapping.Anonymiser == Anonymizers.Integer)
                            {
                                NumericMapping intMapping = (NumericMapping)mapping;

                                int newVal;

                                if (mapping.Column.IsPK)
                                {
                                    while (true)
                                    {
                                        newVal = GenerateNumeric(valLength, colValue, intMapping, true);
                                        if (pkValuesInt.Contains(newVal.ToString()))
                                            continue;

                                        pkValuesInt.Add(newVal.ToString());
                                        break;
                                    }
                                }
                                else
                                {
                                    newVal = GenerateNumeric(valLength, colValue, intMapping);
                                }

                                row[mapping.Column.Name] = newVal;
                            }
                            break;

                        case "bit":
                            if (mapping.Anonymiser == Anonymizers.Boolean)
                                row[mapping.Column.Name] = GenerateBoolean().ToString();
                            break;

                        case "char":
                            float length = mapping.Column.Size;
                            if (mapping.Anonymiser == Anonymizers.Character)
                            {
                                        AlphaMapping alphaMapping = (AlphaMapping)mapping;
                                        row[mapping.Column.Name] = GenerateAlphaNumeric(valLength, alphaMapping.SelectedOption);
                            }
                            break;

                        case "date":
                        case "datetime":
                            if (mapping.Anonymiser == Anonymizers.Date || mapping.Anonymiser == Anonymizers.DateTime)
                            {
                                DateMapping dateMapping = (DateMapping)mapping;
                                row[mapping.Column.Name] = GenerateDate(colValue, dateMapping);
                            }
                            break;

                        case "uniqueidentifier":
                            if (mapping.Anonymiser == Anonymizers.GUID)
                                row[mapping.Column.Name] = GenerateGUID();

                            break;
                        case "float":
                        case "double":
                            NumericMapping numericMapping = (NumericMapping)mapping;
                            string val = row[mapping.Column.Name].ToString();

                            if(mapping.Anonymiser == Anonymizers.Float || mapping.Anonymiser == Anonymizers.Double)
                                row[mapping.Column.Name] = GenerateDecimal(colValue, numericMapping);

                            break;
                    }
                }
            }
        }
        public static String GenerateAlpha(int length, AlphaOptions alphaOptions)
        {
            Random random = Rand.Create();
            string result = string.Empty;
            //Random random = new Random((int)DateTime.Now.Ticks);
            List<string> characters = new List<string>() { };
            for (int i = 65; i < 91; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 97; i < 123; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 0; i < length; i++)
            {
                result += characters[random.Next(0, characters.Count)];
                //Thread.Sleep(1);
            }


            if (alphaOptions == AlphaOptions.LowerCase)
                result = result.ToLower();
            else if (alphaOptions == AlphaOptions.UpperCase)
                result = result.ToUpper();
            else if (alphaOptions == AlphaOptions.InitCase)
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                result = textInfo.ToTitleCase(result);
            }
                
            return result;
        }
        public static String GenerateAlphaNumeric(int length, AlphaOptions alphaOptions)
        {
            Random random = Rand.Create();
            string result = string.Empty;
            List<string> characters = new List<string>() { };
            for (int i = 48; i < 58; i++)
            {
                characters.Add(((char)i).ToString());
            }

            if (alphaOptions != AlphaOptions.IntegerOnly)
            {
                for (int i = 65; i < 91; i++)
                {
                    characters.Add(((char)i).ToString());
                }
                for (int i = 97; i < 123; i++)
                {
                    characters.Add(((char)i).ToString());
                }
            }

            for (int i = 0; i < length; i++)
            {
                result += characters[random.Next(0, characters.Count)];
            }

            if (alphaOptions == AlphaOptions.LowerCase)
                result = result.ToLower();
            else if (alphaOptions == AlphaOptions.UpperCase)
                result = result.ToUpper();
            else if(alphaOptions == AlphaOptions.InitCase)
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                result = textInfo.ToTitleCase(result);
            }


            return result;
        }

        public static bool GenerateBoolean()
        {
            Random random = Rand.Create();
            bool result = random.Next(1,100) < 50;
            return result;
        }

        public static DateTime GenerateDate(string colValue, DateMapping dateMapping)
        {
            Random random = Rand.Create();

            DateTime currentDateValue = DateTime.Parse(colValue);
            
            int offsetUnit = dateMapping.OffsetUnit == DateOffsetUnit.Months ? 30 : 365;

            int range = dateMapping.Offset * offsetUnit;
            int minRange = 0, maxRange = 0;

            if (dateMapping.IsFuture && dateMapping.IsPast)
            {
                minRange = range * -1;
                maxRange = range;
            }
            else if (dateMapping.IsFuture && dateMapping.IsPast == false)
            {
                minRange = 1;
                maxRange = range;
            }
            else if (dateMapping.IsFuture == false && dateMapping.IsPast)
            {
                minRange = range * -1;
                maxRange = -1;
            }

            DateTime randomDate = currentDateValue.AddDays(random.Next(minRange, maxRange));

            if (dateMapping.IsDateTime)
                return new DateTime(randomDate.Year, randomDate.Month, randomDate.Day, random.Next(0, 23), random.Next(0, 59), random.Next(0, 59), random.Next(0, 999));
            else
                return new DateTime(randomDate.Year, randomDate.Month, randomDate.Day);
        }

        public static double GenerateDecimal(string colValue, NumericMapping numericMapping)
        {
            string[] valParts = colValue.Split('.');
            int intLen = valParts[0].Length;
            int decimalPlaces = 0;
            if (valParts.Length > 1)
                decimalPlaces = valParts[1].Length;

            int intVal = GenerateNumeric(intLen, valParts[0], numericMapping);

            if (decimalPlaces > 0)
            {
                int decimalVal = GenerateNumeric(decimalPlaces, valParts[1], numericMapping);
                decimalVal = decimalVal < 0 ? decimalVal * -1 : decimalVal;

                return double.Parse($"{intVal}.{decimalVal}");
            }
            else
                return double.Parse($"{intVal}");
        }

        public static int GenerateNumeric(int length, string colValue, NumericMapping numericMapping, bool isPK = false)
        {
            Random random = Rand.Create();

            if (isPK)
            {
                return random.Next(1, int.MaxValue);
            }
            else if (numericMapping.MatchSize == false && numericMapping.IsPercentage == false)
            {
                return random.Next(numericMapping.MinRange, numericMapping.MaxRange);
            }
            else if (numericMapping.IsPercentage)
            {
                int ColumnValue = Convert.ToInt32(colValue);
                float percentage = (ColumnValue / (float)numericMapping.PercentageValue);
                int min = (int)Math.Floor(ColumnValue - percentage);
                int max = (int)Math.Ceiling(ColumnValue + percentage); 
                return random.Next(min, max);
            }

            string result = string.Empty;

            List<string> characters = new List<string>() { };
            for (int i = 49; i < 58; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 0; i < length; i++)
            {
                result += characters[random.Next(0, characters.Count-1)];

                if (i == 0)
                    characters.Add("0");
            }
            //Console.WriteLine($"Value: {colValue} -> {result}");
            return int.Parse(result);
        }
        public static Guid GenerateGUID() 
        {
            Guid result = Guid.NewGuid();
            return result;
        }

    }
}

