namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMyLogin : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[myLogins] ON
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (1, 73, N'chem73')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (2, 12, N'chem12')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (3, 19, N'chem19')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (4, 1491, N'chem1491')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (5, 54, N'chem54')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (6, 78, N'chem78')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (7, 1544, N'chem1544')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (8, 1543, N'chem1543')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (9, 1965, N'chem1965')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (10, 2002, N'chem2002')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (11, 188, N'chem188')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (12, 1299, N'chem1299')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (13, 89, N'chem89')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (14, 519, N'chem519')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (15, 512, N'chem512')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (16, 97, N'chem97')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (17, 2011, N'chem2011')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (18, 2070, N'chem2070')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (19, 2080, N'chem2080')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (20, 1509, N'chem1509')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (21, 1547, N'chem1547')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (22, 509, N'chem509')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (23, 1703, N'chem1703')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (24, 2040, N'chem2040')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (25, 2061, N'chem2061')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (26, 2176, N'chem2176')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (27, 101, N'chem101')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (28, 106, N'chem106')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (29, 2108, N'chem2108')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (30, 2141, N'chem2141')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (31, 2146, N'chem2146')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (32, 2162, N'chem2162')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (33, 2178, N'chem2178')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (34, 2204, N'chem2204')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (35, 2212, N'chem2212')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (36, 2216, N'chem2216')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (37, 2217, N'chem2217')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (38, 2218, N'chem2218')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (39, 2219, N'chem2219')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (40, 2220, N'chem2220')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (41, 2221, N'chem2221')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (42, 1311, N'chem1311')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (43, 313, N'chem313')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (44, 112, N'chem112')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (45, 316, N'chem316')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (46, 407, N'chem407')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (47, 644, N'chem644')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (48, 675, N'chem675')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (49, 1623, N'chem1623')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (50, 690, N'chem690')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (51, 1533, N'chem1533')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (52, 1039, N'chem1039')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (53, 2170, N'chem2170')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (54, 2171, N'chem2171')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (55, 2172, N'chem2172')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (56, 2173, N'chem2173')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (57, 2175, N'chem2175')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (58, 2177, N'chem2177')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (59, 2071, N'chem2071')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (60, 2073, N'chem2073')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (61, 2074, N'chem2074')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (62, 2210, N'chem2210')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (63, 2076, N'chem2076')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (64, 2077, N'chem2077')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (65, 2078, N'chem2078')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (66, 1955, N'chem1955')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (67, 1969, N'chem1969')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (68, 1970, N'chem1970')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (69, 1971, N'chem1971')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (70, 1972, N'chem1972')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (71, 1974, N'chem1974')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (72, 1975, N'chem1975')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (73, 1976, N'chem1976')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (74, 1978, N'chem1978')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (75, 1979, N'chem1979')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (76, 1980, N'chem1980')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (77, 1981, N'chem1981')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (78, 1982, N'chem1982')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (79, 1984, N'chem1984')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (80, 1985, N'chem1985')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (81, 1986, N'chem1986')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (82, 1987, N'chem1987')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (83, 1990, N'chem1990')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (84, 1991, N'chem1991')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (85, 1992, N'chem1992')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (86, 1993, N'chem1993')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (87, 1994, N'chem1994')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (88, 1996, N'chem1996')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (89, 1997, N'chem1997')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (90, 1999, N'chem1999')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (91, 2000, N'chem2000')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (92, 2003, N'chem2003')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (93, 2005, N'chem2005')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (94, 2081, N'chem2081')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (95, 1941, N'chem1941')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (96, 1934, N'chem1934')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (97, 1935, N'chem1935')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (98, 1936, N'chem1936')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (99, 1930, N'chem1930')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (100, 1916, N'chem1916')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (101, 1917, N'chem1917')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (102, 1920, N'chem1920')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (103, 1904, N'chem1904')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (104, 1907, N'chem1907')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (105, 1911, N'chem1911')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (106, 1756, N'chem1756')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (107, 1376, N'chem1376')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (108, 1857, N'chem1857')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (109, 1398, N'chem1398')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (110, 1404, N'chem1404')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (111, 1873, N'chem1873')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (112, 1875, N'chem1875')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (113, 1879, N'chem1879')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (114, 1858, N'chem1858')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (115, 1392, N'chem1392')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (116, 1413, N'chem1413')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (117, 1859, N'chem1859')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (118, 1415, N'chem1415')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (119, 1420, N'chem1420')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (120, 1896, N'chem1896')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (121, 1897, N'chem1897')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (122, 1898, N'chem1898')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (123, 1902, N'chem1902')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (124, 1869, N'chem1869')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (125, 1483, N'chem1483')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (126, 1292, N'chem1292')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (127, 1861, N'chem1861')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (128, 1877, N'chem1877')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (129, 1583, N'chem1583')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (130, 1854, N'chem1854')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (131, 1647, N'chem1647')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (132, 1478, N'chem1478')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (133, 1862, N'chem1862')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (134, 1841, N'chem1841')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (135, 1842, N'chem1842')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (136, 1871, N'chem1871')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (137, 1456, N'chem1456')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (138, 1864, N'chem1864')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (139, 1455, N'chem1455')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (140, 1849, N'chem1849')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (141, 1693, N'chem1693')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (142, 1694, N'chem1694')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (143, 1000, N'chem1000')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (144, 1003, N'chem1003')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (145, 1695, N'chem1695')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (146, 981, N'chem981')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (147, 1033, N'chem1033')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (148, 1872, N'chem1872')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (149, 1585, N'chem1585')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (150, 1668, N'chem1668')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (151, 1700, N'chem1700')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (152, 1765, N'chem1765')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (153, 1004, N'chem1004')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (154, 1006, N'chem1006')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (155, 1702, N'chem1702')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (156, 1362, N'chem1362')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (157, 1454, N'chem1454')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (158, 1041, N'chem1041')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (159, 1560, N'chem1560')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (160, 1646, N'chem1646')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (161, 1245, N'chem1245')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (162, 1705, N'chem1705')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (163, 1763, N'chem1763')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (164, 1113, N'chem1113')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (165, 1482, N'chem1482')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (166, 1832, N'chem1832')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (167, 911, N'chem911')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (168, 1070, N'chem1070')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (169, 1672, N'chem1672')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (170, 1074, N'chem1074')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (171, 1505, N'chem1505')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (172, 1506, N'chem1506')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (173, 968, N'chem968')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (174, 1554, N'chem1554')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (175, 980, N'chem980')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (176, 1684, N'chem1684')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (177, 1685, N'chem1685')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (178, 1686, N'chem1686')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (179, 1512, N'chem1512')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (180, 920, N'chem920')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (181, 1513, N'chem1513')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (182, 1688, N'chem1688')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (183, 1689, N'chem1689')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (184, 1451, N'chem1451')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (185, 965, N'chem965')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (186, 969, N'chem969')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (187, 921, N'chem921')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (188, 922, N'chem922')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (189, 1005, N'chem1005')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (190, 1691, N'chem1691')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (191, 1282, N'chem1282')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (192, 1333, N'chem1333')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (193, 1338, N'chem1338')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (194, 1347, N'chem1347')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (195, 1348, N'chem1348')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (196, 1226, N'chem1226')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (197, 1356, N'chem1356')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (198, 1397, N'chem1397')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (199, 1400, N'chem1400')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (200, 1418, N'chem1418')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (201, 1419, N'chem1419')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (202, 1227, N'chem1227')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (203, 1229, N'chem1229')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (204, 1230, N'chem1230')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (205, 1606, N'chem1606')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (206, 1609, N'chem1609')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (207, 1797, N'chem1797')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (208, 1798, N'chem1798')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (209, 1883, N'chem1883')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (210, 1808, N'chem1808')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (211, 1966, N'chem1966')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (212, 1613, N'chem1613')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (213, 886, N'chem886')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (214, 887, N'chem887')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (215, 888, N'chem888')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (216, 1563, N'chem1563')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (217, 1066, N'chem1066')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (218, 1078, N'chem1078')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (219, 890, N'chem890')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (220, 907, N'chem907')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (221, 909, N'chem909')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (222, 1625, N'chem1625')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (223, 2097, N'chem2097')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (224, 1762, N'chem1762')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (225, 1770, N'chem1770')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (226, 2154, N'chem2154')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (227, 1784, N'chem1784')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (228, 1790, N'chem1790')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (229, 1794, N'chem1794')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (230, 857, N'chem857')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (231, 861, N'chem861')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (232, 1325, N'chem1325')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (233, 1967, N'chem1967')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (234, 1329, N'chem1329')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (235, 1551, N'chem1551')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (236, 1054, N'chem1054')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (237, 1591, N'chem1591')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (238, 2041, N'chem2041')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (239, 1590, N'chem1590')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (240, 1592, N'chem1592')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (241, 1208, N'chem1208')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (242, 1212, N'chem1212')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (243, 2096, N'chem2096')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (244, 2098, N'chem2098')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (245, 2099, N'chem2099')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (246, 2100, N'chem2100')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (247, 1269, N'chem1269')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (248, 1270, N'chem1270')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (249, 1271, N'chem1271')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (250, 1272, N'chem1272')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (251, 841, N'chem841')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (252, 56, N'chem56')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (253, 1945, N'chem1945')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (254, 7, N'chem7')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (255, 812, N'chem812')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (256, 1421, N'chem1421')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (257, 1962, N'chem1962')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (258, 1423, N'chem1423')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (259, 1428, N'chem1428')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (260, 1968, N'chem1968')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (261, 2136, N'chem2136')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (262, 2135, N'chem2135')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (263, 2139, N'chem2139')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (264, 1450, N'chem1450')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (265, 1863, N'chem1863')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (266, 1457, N'chem1457')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (267, 1459, N'chem1459')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (268, 1963, N'chem1963')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (269, 2133, N'chem2133')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (270, 2134, N'chem2134')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (271, 1757, N'chem1757')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (272, 1758, N'chem1758')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (273, 2009, N'chem2009')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (274, 2068, N'chem2068')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (275, 2021, N'chem2021')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (276, 2023, N'chem2023')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (277, 2024, N'chem2024')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (278, 2025, N'chem2025')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (279, 2027, N'chem2027')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (280, 2029, N'chem2029')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (281, 2033, N'chem2033')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (282, 2035, N'chem2035')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (283, 2037, N'chem2037')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (284, 2047, N'chem2047')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (285, 2048, N'chem2048')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (286, 2049, N'chem2049')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (287, 2050, N'chem2050')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (288, 2140, N'chem2140')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (289, 2102, N'chem2102')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (290, 2104, N'chem2104')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (291, 2105, N'chem2105')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (292, 2110, N'chem2110')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (293, 2111, N'chem2111')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (294, 2131, N'chem2131')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (295, 2112, N'chem2112')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (296, 2113, N'chem2113')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (297, 2114, N'chem2114')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (298, 2115, N'chem2115')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (299, 2116, N'chem2116')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (300, 2117, N'chem2117')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (301, 2118, N'chem2118')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (302, 2119, N'chem2119')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (303, 2120, N'chem2120')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (304, 2121, N'chem2121')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (305, 2137, N'chem2137')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (306, 2122, N'chem2122')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (307, 2123, N'chem2123')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (308, 2124, N'chem2124')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (309, 2125, N'chem2125')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (310, 2126, N'chem2126')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (311, 2127, N'chem2127')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (312, 2128, N'chem2128')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (313, 2129, N'chem2129')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (314, 2132, N'chem2132')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (315, 2138, N'chem2138')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (316, 2142, N'chem2142')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (317, 2143, N'chem2143')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (318, 2145, N'chem2145')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (319, 2155, N'chem2155')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (320, 2157, N'chem2157')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (321, 2158, N'chem2158')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (322, 2159, N'chem2159')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (323, 2160, N'chem2160')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (324, 2161, N'chem2161')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (325, 2163, N'chem2163')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (326, 2164, N'chem2164')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (327, 2165, N'chem2165')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (328, 2166, N'chem2166')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (329, 2168, N'chem2168')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (330, 2196, N'chem2196')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (331, 2197, N'chem2197')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (332, 2198, N'chem2198')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (333, 2199, N'chem2199')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (334, 2200, N'chem2200')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (335, 2203, N'chem2203')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (336, 2179, N'chem2179')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (337, 2180, N'chem2180')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (338, 2181, N'chem2181')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (339, 2182, N'chem2182')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (340, 2184, N'chem2184')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (341, 2185, N'chem2185')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (342, 2186, N'chem2186')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (343, 2187, N'chem2187')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (344, 2188, N'chem2188')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (345, 2189, N'chem2189')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (346, 2190, N'chem2190')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (347, 2191, N'chem2191')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (348, 2192, N'chem2192')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (349, 2193, N'chem2193')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (350, 2194, N'chem2194')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (351, 2195, N'chem2195')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (352, 2206, N'chem2206')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (353, 2207, N'chem2207')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (354, 2208, N'chem2208')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (355, 2209, N'chem2209')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (356, 2211, N'chem2211')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (357, 2213, N'chem2213')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (358, 2214, N'chem2214')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (359, 2215, N'chem2215')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (360, 2222, N'chem2222')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (361, 2223, N'chem2223')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (362, 2226, N'chem2226')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (363, 2227, N'chem2227')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (364, 2228, N'chem2228')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (365, 2229, N'chem2229')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (366, 2230, N'chem2230')
INSERT INTO [dbo].[myLogins] ([Id], [EmployeeDetailsId], [Password]) VALUES (367, 2231, N'chem2231')
SET IDENTITY_INSERT [dbo].[myLogins] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}