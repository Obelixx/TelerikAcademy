namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BishopPathFinder
    {
        public static void Task3Main(string[] args)
        {
            StringBuilder tempString = new StringBuilder();
            tempString.Append(Console.ReadLine());

            // This names (r,c,n) are by task description!
            ushort r = ushort.Parse(tempString.ToString().Split(' ')[0].ToString());
            ushort c = ushort.Parse(tempString.ToString().Split(' ')[1].ToString());
            ushort n = ushort.Parse(Console.ReadLine());

            List<Tuple<ushort, ushort>> coords = new List<Tuple<ushort, ushort>>();
            coords.Add(new Tuple<ushort, ushort>((ushort)(r - 1), (ushort)0));
            int ii;
            int jj;
            int iiend;
            int jjend;
            for (int i = 0; i < n; i++)
            {
                tempString.Clear();
                tempString.Append(Console.ReadLine());

                switch (tempString.ToString().Split(' ')[0].ToString())
                {
                    // RU and UR mean UP-RIGHT
                    // LU and UL mean UP-LEFT
                    // DL and LD mean DOWN-LEFT
                    // DR and RD mean DOWN-RIGHT
                    case "RU":
                    case "UR":
                        ii = coords[coords.Count - 1].Item1;
                        jj = coords[coords.Count - 1].Item2;
                        iiend = coords[coords.Count - 1].Item1 - (int.Parse(tempString.ToString().Split(' ')[1].ToString()) - 1);
                        jjend = coords[coords.Count - 1].Item2 + (int.Parse(tempString.ToString().Split(' ')[1].ToString()) - 1);
                        while (ii >= iiend && jj <= jjend)
                        {
                            if (!(ii < 0 || jj < 0 || ii > r - 1 || jj > c - 1))
                            {
                                coords.Add(new Tuple<ushort, ushort>((ushort)ii, (ushort)jj));
                                ii--;
                                jj++;
                            }
                            else
                            {
                                ii++;
                                jj--;
                                break;
                            }
                        }

                        break;
                    case "LU":
                    case "UL":
                        ii = coords[coords.Count - 1].Item1;
                        jj = coords[coords.Count - 1].Item2;
                        iiend = coords[coords.Count - 1].Item1 - (int.Parse(tempString.ToString().Split(' ')[1].ToString()) - 1);
                        jjend = coords[coords.Count - 1].Item2 - (int.Parse(tempString.ToString().Split(' ')[1].ToString()) - 1);
                        while (ii >= iiend && jj >= jjend)
                        {
                            if (!(ii < 0 || jj < 0 || ii > r - 1 || jj > c - 1))
                            {
                                coords.Add(new Tuple<ushort, ushort>((ushort)ii, (ushort)jj));
                                ii--;
                                jj--;
                            }
                            else
                            {
                                ii++;
                                jj++;
                                break;
                            }
                        }

                        break;
                    case "DL":
                    case "LD":
                        ii = coords[coords.Count - 1].Item1;
                        jj = coords[coords.Count - 1].Item2;
                        iiend = coords[coords.Count - 1].Item1 + (int.Parse(tempString.ToString().Split(' ')[1].ToString()) - 1);
                        jjend = coords[coords.Count - 1].Item2 - (int.Parse(tempString.ToString().Split(' ')[1].ToString()) - 1);
                        while (ii <= iiend && jj >= jjend)
                        {
                            if (!(ii < 0 || jj < 0 || ii > r - 1 || jj > c - 1))
                            {
                                coords.Add(new Tuple<ushort, ushort>((ushort)ii, (ushort)jj));
                                ii++;
                                jj--;
                            }
                            else
                            {
                                ii--;
                                jj++;
                                break;
                            }
                        }

                        break;
                    case "DR":
                    case "RD":
                        ii = coords[coords.Count - 1].Item1;
                        jj = coords[coords.Count - 1].Item2;
                        iiend = coords[coords.Count - 1].Item1 + (int.Parse(tempString.ToString().Split(' ')[1].ToString()) - 1);
                        jjend = coords[coords.Count - 1].Item2 + (int.Parse(tempString.ToString().Split(' ')[1].ToString()) - 1);
                        while (ii <= iiend && jj <= jjend)
                        {
                            if (!(ii < 0 || jj < 0 || ii > r - 1 || jj > c - 1))
                            {
                                coords.Add(new Tuple<ushort, ushort>((ushort)ii, (ushort)jj));
                                ii++;
                                jj++;
                            }
                            else
                            {
                                ii--;
                                jj--;
                                break;
                            }
                        }

                        break;
                    default:
                        break;
                }
            }

            coords = coords.Distinct().ToList();
            ulong sum = 0;
            foreach (var item in coords)
            {
                sum += (ulong)(3 * (item.Item2 + (r - 1) - item.Item1));
            }

            Console.WriteLine(sum);
        }
    }
}
