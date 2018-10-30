﻿using PresidentsService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresidentsService.Data
{
    public static class PresidentsData
    {
        public static ICollection<President> GetList()
        {
            var list = new List<President>();
            var presidentString = @"George Washington	1732-2-22	Westmoreland Co., Va.	1799-12-14	Mount Vernon, Va.|
            John Adams	1735-10-30	Quincy, Mass.	1826-7-4	Quincy, Mass.|
            Thomas Jefferson	1743-4-13	Albemarle Co., Va.	1826-7-4	Albemarle Co., Va.|
            James Madison	1751-3-16	Port Conway, Va.	1836-6-28	Orange Co., Va.|
            James Monroe	1758-4-28	Westmoreland Co., Va.	1831-7-4	New York, New York|
            John Quincy Adams	1767-7-11	Quincy, Mass.	1848-2-23	Washington, D.C.|
            Andrew Jackson	1767-3-15	Waxhaws, No./So. Carolina	1845-6-8	Nashville, Tennessee|
            Martin Van Buren	1782-12-5	Kinderhook, New York	1862-7-24	Kinderhook, New York|
            William Henry Harrison	1773-2-9	Charles City Co., Va.	1841-4-4	Washington, D.C.|
            John Tyler	1790-3-29	Charles City Co., Va.	1862-1-18	Richmond, Va.|
            James K. Polk	1795-11-2	Mecklenburg Co., N.C.	1849-6-15	Nashville, Tennessee|
            Zachary Taylor	1784-11-24	Orange County, Va.	1850-7-9	Washington, D.C|
            Millard Fillmore	1800-1-7	Cayuga Co., New York	1874-3-8	Buffalo, New York|
            Franklin Pierce	1804-11-23	Hillsborough, N.H.	1869-10-8	Concord, New Hamp.|
            James Buchanan	1791-4-23	Cove Gap, Pa.	1868-6-1	Lancaster, Pa.|
            Abraham Lincoln	1809-2-12	LaRue Co., Kentucky	1865-4-15	Washington, D.C.|
            Andrew Johnson	1808-12-29	Raleigh, North Carolina	1875-7-31	Elizabethton, Tenn.|
            Ulysses S. Grant	1822-4-27	Point Pleasant, Ohio	1885-7-23	Wilton, New York|
            Rutherford B. Hayes	1822-10-4	Delaware, Ohio	1893-1-17	Fremont, Ohio|
            James A. Garfield	1831-11-19	Cuyahoga Co., Ohio	1881-9-19	Elberon, New Jersey|
            Chester Arthur	1829-10-5	Fairfield, Vermont	1886-11-18	New York, New York|
            Grover Cleveland	1837-3-18	Caldwell, New Jersey	1908-6-24	Princeton, New Jersey|
            Benjamin Harrison	1833-8-20	North Bend, Ohio	1901-3-13	Indianapolis, Indiana|
            William McKinley	1843-1-29	Niles, Ohio	1901-9-14	Buffalo, New York|
            Theodore Roosevelt	1858-10-27	New York, New York	1919-1-6	Oyster Bay, New York|
            William Howard Taft	1857-9-15	Cincinnati, Ohio	1930-3-8	Washington, D.C.|
            Woodrow Wilson	1856-12-28	Staunton, Virginia	1924-2-3	Washington, D.C.|
            Warren G. Harding	1865-11-2	Morrow County, Ohio	1923-8-2	San Francisco, Cal.|
            Calvin Coolidge	1872-7-4	Plymouth, Vermont	1933-1-5	Northampton, Mass.|
            Herbert Hoover	1874-8-10	West Branch, Iowa	1964-10-20	New York, New York|
            Franklin Roosevelt	1882-1-30	Hyde Park, New York	1945-4-12	Warm Springs, Georgia|
            Harry S. Truman	1884-5-8	Lamar, Missouri	1972-12-26	Kansas City, Missouri|
            Dwight Eisenhower	1890-10-14	Denison, Texas	1969-3-28	Washington, D.C.|
            John F. Kennedy	1917-5-29	Brookline, Mass.	1963-11-22	Dallas, Texas|
            Lyndon B. Johnson	1908-8-27	Gillespie Co., Texas	1973-1-22	Gillespie Co., Texas|
            Richard Nixon	1913-1-9	Yorba Linda, Cal.	1994-4-22	New York, New York|
            Gerald Ford	1913-7-14	Omaha, Nebraska	2006-12-26	Rancho Mirage, Cal.|
            Jimmy Carter	1924-10-1	Plains, Georgia		|
            Ronald Reagan	1911-2-6	Tampico, Illinois	2004-6-5	Los Angeles, Cal.|
            George Bush	1924-6-12	Milton, Mass.		|
            Bill Clinton	1946-8-19	Hope, Arkansas		|
            George W. Bush	1646-7-6	New Haven, Conn.		|
            Barack Obama	1961-8-4	Honolulu, Hawaii		|
            Donald Trump	1946-6-14	New York, New York		";
            string[] row;
            foreach (var item in presidentString.Split("|"))
            {
                row = item.Split("\t");
                list.Add(new President
                {
                    Name = row[0].Trim(),
                    Birthday = row[1].Trim(),
                    Birthplace = row[2].Trim(),
                    Deathday = row[3].Trim(),
                    Deathplace = row[4].Trim()
                });
            }
            return list;
        }
    }
}
