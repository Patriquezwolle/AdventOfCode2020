using System;
using System.Collections.Generic;
using System.Text;

namespace AventOfCode2020
{
    class Day1
    {
        public static List<int> GetnumbersAssignment1()
        {
            List<int> result = new List<int>();

            result.Add(1645);
            result.Add(1995);
            result.Add(1658);
            result.Add(1062);
            result.Add(1472);
            result.Add(1710);
            result.Add(1424);
            result.Add(1823);
            result.Add(1518);
            result.Add(1656);
            result.Add(1811);
            result.Add(1511);
            result.Add(1320);
            result.Add(1521);
            result.Add(1395);
            result.Add(1996);
            result.Add(1724);
            result.Add(1666);
            result.Add(1637);
            result.Add(1504);
            result.Add(1766);
            result.Add(534);
            result.Add(1738);
            result.Add(1791);
            result.Add(1372);
            result.Add(1225);
            result.Add(1690);
            result.Add(1949);
            result.Add(1495);
            result.Add(1436);
            result.Add(1166);
            result.Add(1686);
            result.Add(1861);
            result.Add(1889);
            result.Add(1887);
            result.Add(997);
            result.Add(1202);
            result.Add(1478);
            result.Add(833);
            result.Add(1497);
            result.Add(1459);
            result.Add(1717);
            result.Add(1272);
            result.Add(1047);
            result.Add(1751);
            result.Add(1549);
            result.Add(1204);
            result.Add(1230);
            result.Add(1260);
            result.Add(1611);
            result.Add(1506);
            result.Add(1648);
            result.Add(1354);
            result.Add(1415);
            result.Add(1615);
            result.Add(1327);
            result.Add(1622);
            result.Add(1592);
            result.Add(1807);
            result.Add(1601);
            result.Add(1026);
            result.Add(1757);
            result.Add(1376);
            result.Add(1707);
            result.Add(1514);
            result.Add(1905);
            result.Add(1660);
            result.Add(1578);
            result.Add(1963);
            result.Add(1292);
            result.Add(390);
            result.Add(1898);
            result.Add(1019);
            result.Add(1580);
            result.Add(1499);
            result.Add(1830);
            result.Add(1801);
            result.Add(1881);
            result.Add(1764);
            result.Add(1442);
            result.Add(1838);
            result.Add(1088);
            result.Add(1087);
            result.Add(1040);
            result.Add(1349);
            result.Add(1644);
            result.Add(1908);
            result.Add(1697);
            result.Add(1115);
            result.Add(1178);
            result.Add(1224);
            result.Add(1810);
            result.Add(1445);
            result.Add(1594);
            result.Add(1894);
            result.Add(1287);
            result.Add(1676);
            result.Add(1435);
            result.Add(1294);
            result.Add(1796);
            result.Add(1350);
            result.Add(1685);
            result.Add(1118);
            result.Add(1488);
            result.Add(1726);
            result.Add(1696);
            result.Add(1190);
            result.Add(1538);
            result.Add(1780);
            result.Add(1806);
            result.Add(1207);
            result.Add(1346);
            result.Add(1705);
            result.Add(983);
            result.Add(1249);
            result.Add(1455);
            result.Add(2002);
            result.Add(1466);
            result.Add(1723);
            result.Add(1227);
            result.Add(1390);
            result.Add(1281);
            result.Add(1715);
            result.Add(1603);
            result.Add(1862);
            result.Add(1744);
            result.Add(1774);
            result.Add(1385);
            result.Add(1312);
            result.Add(1654);
            result.Add(1872);
            result.Add(1142);
            result.Add(1273);
            result.Add(1508);
            result.Add(1639);
            result.Add(1827);
            result.Add(1461);
            result.Add(1795);
            result.Add(1533);
            result.Add(1304);
            result.Add(1417);
            result.Add(1984);
            result.Add(28);
            result.Add(1693);
            result.Add(1951);
            result.Add(1391);
            result.Add(1931);
            result.Add(1179);
            result.Add(1278);
            result.Add(1400);
            result.Add(1361);
            result.Add(1369);
            result.Add(1343);
            result.Add(1416);
            result.Add(1426);
            result.Add(314);
            result.Add(1510);
            result.Add(1933);
            result.Add(1239);
            result.Add(1218);
            result.Add(1918);
            result.Add(1797);
            result.Add(1255);
            result.Add(1399);
            result.Add(1229);
            result.Add(723);
            result.Add(1992);
            result.Add(1595);
            result.Add(1191);
            result.Add(1916);
            result.Add(1525);
            result.Add(1605);
            result.Add(1524);
            result.Add(1869);
            result.Add(1652);
            result.Add(1874);
            result.Add(1756);
            result.Add(1246);
            result.Add(1310);
            result.Add(1219);
            result.Add(1482);
            result.Add(1429);
            result.Add(1244);
            result.Add(1554);
            result.Add(1575);
            result.Add(1123);
            result.Add(1194);
            result.Add(1408);
            result.Add(1917);
            result.Add(1613);
            result.Add(1773);
            result.Add(1809);
            result.Add(1987);
            result.Add(1733);
            result.Add(1844);
            result.Add(1423);
            result.Add(1718);
            result.Add(1714);
            result.Add(1923);
            result.Add(1503);

            return result;
        }

        public static int CalculateNumbers2(List<int> numbers)
        {
            foreach (var number1 in numbers)
            {
                foreach (var number2 in numbers)
                {
                    foreach (var number3 in numbers)
                    {
                        if (number1 + number2 + number3 == 2020)
                        {
                            Console.WriteLine($"Nummer1 = {number1}");
                            Console.WriteLine($"Nummer2 = {number2}");
                            Console.WriteLine($"Nummer3 = {number3}");
                            var result = number1 * number2 * number3;
                            Console.WriteLine($"Resultaat = {result}");
                            return result;
                        }
                    }
                }

            }
            return 0;
        }


        public static int CalculateNumbers(List<int> numbers)
        {
            foreach (var number1 in numbers)
            {
                foreach (var number2 in numbers)
                {
                    if (number1 + number2 == 2020)
                    {
                        Console.WriteLine($"Nummer1 = {number1}");
                        Console.WriteLine($"Nummer2 = {number2}");
                        var result = number1 * number2;
                        Console.WriteLine($"Resultaat = {result}");
                        return result;
                    }
                    
                }
                
            }
            return 0;
        }


        public static void GetResultAssignment1()
        {
            var list = GetnumbersAssignment1();
            var result = CalculateNumbers(list);
            Console.WriteLine($"Totaal resultaat = {result}");
        }

        public static void GetResultAssingment2()
        {
            var list = GetnumbersAssignment1();
            var result = CalculateNumbers2(list);
            Console.WriteLine($"Totaal resultaat = {result}");
        }

    }
}

