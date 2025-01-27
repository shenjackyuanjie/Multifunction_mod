﻿using System.Collections.Generic;
using UnityEngine;

namespace Multfunction_mod
{
    public class Constant
    {
        public static List<Vector3> nodepos = new List<Vector3>();
        public static double[,] posxz = new double[10, 2]{
            {0,1 },
            { 0.1563, -0.9877},
            { 0.3089,-0.9511 },
            { 0.4539, -0.8911 },
            { 0.5877, -0.8091 },
            { 0.7071, -0.7071 },
            { 0.8091, -0.5877 },
            { 0.8910, -0.4540 },
            { 0.9511, -0.3089 },
            { 0.9877, -0.1564 },
        };
        public static double[,] dysonposxyz1 = new double[7, 2]
        {
            {7431.4, 6691.3},
            {8090.2, 5877.9},
            {8660.3, 5000.0},
            {9135.5, 4067.4},
            {9510.6, 3090.2},
            {9781.5, 2079.1},
            {9945.2, 1045.3},
        };
        public static double[,] dysonposxyz2 = new double[14, 3]
        {
            {-1045.3, 0.0, 9945.2},
            {-2079.1, 0.0, 9781.5},
            {-3090.2, 0.0, 9510.6},
            {-4067.4, 0.0, 9135.4},
            {-5000.0, 0.0, 8660.2},
            {-5877.9, 0.0, 8090.2},
            {-6691.3, 0.0, 7431.4},
            {-7431.5, 0.0, 6691.3},
            {-8090.2, 0.0, 5877.9},
            {-8660.3, 0.0, 5000.0},
            {-9135.5, 0.0, 4067.4},
            {-9510.6, 0.0, 3090.2},
            {-9781.5, 0.0, 2079.1},
            {-9945.2, 0.0, 1045.3},
        };
        public static double[,] dysonposxyz3 = new double[98, 3]
        {
            {1143.5, 1149.8, 10879.8},
            {1124.7, 2287.0, 10700.7},
            {1093.5, 3399.2, 10404.3},
            {1050.4, 4474.1, 9994.0},
            {995.8, 5500.0, 9474.1},
            {930.2, 6465.6, 8850.4},
            {854.5, 7360.4, 8129.8},
            {1699.6, 7360.4, 7996.0},
            {1850.2, 6465.6, 8704.7},
            {1980.6, 5500.0, 9318.1},
            {2089.3, 4474.1, 9829.4},
            {2175.1, 3399.2, 10233.0},
            {2237.0, 2287.0, 10524.5},
            {2274.5, 1149.8, 10700.7},
            {3380.6, 1149.8, 10404.3},
            {3324.9, 2287.0, 10233.0},
            {3232.8, 3399.2, 9949.6},
            {3105.3, 4474.1, 9557.2},
            {2943.8, 5500.0, 9060.0},
            {2750.0, 6465.6, 8463.6},
            {2526.1, 7360.4, 7774.5},
            {3324.9, 7360.4, 7467.9},
            {3619.6, 6465.6, 8129.8},
            {3874.7, 5500.0, 8702.7},
            {4087.3, 4474.1, 9180.2},
            {4255.1, 3399.2, 9557.2},
            {4376.3, 2287.0, 9829.4},
            {4449.6, 1149.8, 9993.9},
            {5469.9, 1149.8, 9474.1},
            {5379.8, 2287.0, 9318.1},
            {5230.8, 3399.2, 9060.0},
            {5024.5, 4474.1, 8702.7},
            {4763.1, 5500.0, 8250.0},
            {4449.6, 6465.6, 7706.9},
            {4087.3, 7360.4, 7079.4},
            {4804.9, 7360.4, 6613.4},
            {5230.8, 6465.6, 7199.6},
            {5599.4, 5500.0, 7706.9},
            {5906.7, 4474.1, 8129.8},
            {6149.2, 3399.2, 8463.6},
            {6324.4, 2287.0, 8704.7},
            {6430.2, 1149.8, 8850.4},
            {7320.1, 1149.8, 8129.8},
            {7199.6, 2287.0, 7995.9},
            {7000.2, 3399.2, 7774.5},
            {6724.1, 4474.1, 7467.9},
            {6374.3, 5500.0, 7079.4},
            {5954.7, 6465.6, 6613.4},
            {5469.9, 7360.4, 6074.9},
            {6074.9, 7360.4, 5469.9},
            {6613.4, 6465.6, 5954.7},
            {7079.4, 5500.0, 6374.3},
            {7467.9, 4474.1, 6724.1},
            {7774.5, 3399.2, 7000.2},
            {7996.0, 2287.0, 7199.6},
            {8129.8, 1149.8, 7320.1},
            {8850.4, 1149.8, 6430.2},
            {8704.7, 2287.0, 6324.3},
            {8463.6, 3399.2, 6149.2},
            {8129.8, 4474.1, 5906.6},
            {7706.9, 5500.0, 5599.4},
            {7199.6, 6465.6, 5230.8},
            {6613.4, 7360.4, 4804.9},
            {7079.4, 7360.4, 4087.3},
            {7706.9, 6465.6, 4449.6},
            {8250.0, 5500.0, 4763.1},
            {8702.7, 4474.1, 5024.5},
            {9060.0, 3399.2, 5230.8},
            {9318.1, 2287.0, 5379.8},
            {9474.1, 1149.8, 5469.9},
            {9994.0, 1149.8, 4449.6},
            {9829.4, 2287.0, 4376.3},
            {9557.2, 3399.2, 4255.1},
            {9180.2, 4474.1, 4087.3},
            {8702.7, 5500.0, 3874.7},
            {8129.8, 6465.6, 3619.6},
            {7467.9, 7360.4, 3324.9},
            {7774.5, 7360.4, 2526.1},
            {8463.6, 6465.6, 2750.0},
            {9060.0, 5500.0, 2943.8},
            {9557.2, 4474.1, 3105.3},
            {9949.6, 3399.2, 3232.8},
            {10233.0, 2287.0, 3324.9},
            {10404.3, 1149.8, 3380.6},
            {10700.7, 1149.8, 2274.5},
            {10524.5, 2287.0, 2237.0},
            {10233.0, 3399.2, 2175.1},
            {9829.4, 4474.1, 2089.3},
            {9318.1, 5500.0, 1980.6},
            {8704.7, 6465.6, 1850.2},
            {7996.0, 7360.4, 1699.6},
            {8129.8, 7360.4, 854.5},
            {8850.4, 6465.6, 930.2},
            {9474.1, 5500.0, 995.8},
            {9994.0, 4474.1, 1050.4},
            {10404.3, 3399.2, 1093.5},
            {10700.7, 2287.0, 1124.7},
            {10879.8, 1149.8, 1143.5},
        };
        public static double[,] dysonposxyz4 = new double[244, 3]
        {
            {0.0, 9659.3, 2588.2},
            {-943.9, 8910.1, -4440.7},
            {-1846.5, 8910.1, -4147.4},
            {-2668.5, 8910.1, -3672.9},
            {-3373.8, 8910.1, -3037.8},
            {-3931.7, 8910.1, -2270.0},
            {-4317.7, 8910.1, -1402.9},
            {-4515.0, 8910.1, -474.6},
            {-4515.0, 8910.1, 474.5},
            {-4317.7, 8910.1, 1402.9},
            {-3931.7, 8910.1, 2269.9},
            {-3373.8, 8910.1, 3037.8},
            {-2668.5, 8910.1, 3672.9},
            {-1846.6, 8910.1, 4147.4},
            {-943.9, 8910.1, 4440.7},
            {2588.2, 9659.3, 0.0},
            {0.0, 10000.0, 0.0},
            {2461.5, 9659.3, 799.8},
            {-745.1, 9335.8, 3505.4},
            {-1457.6, 9335.8, 3273.9},
            {-2106.4, 9335.8, 2899.3},
            {-2663.2, 9335.8, 2397.9},
            {-3103.6, 9335.8, 1791.8},
            {-3408.3, 9335.8, 1107.4},
            {-3564.1, 9335.8, 374.6},
            {-3564.0, 9335.8, -374.6},
            {-3408.3, 9335.8, -1107.4},
            {-3103.5, 9335.8, -1791.9},
            {-2663.2, 9335.8, -2398.0},
            {-2106.4, 9335.8, -2899.3},
            {-1457.6, 9335.8, -3273.9},
            {-745.1, 9335.8, -3505.4},
            {799.8, 9659.3, 2461.5},
            {1521.3, 9659.3, 2093.9},
            {-799.8, 9659.3, -2461.5},
            {-1521.3, 9659.3, -2093.9},
            {-2093.9, 9659.3, -1521.3},
            {-2461.5, 9659.3, -799.8},
            {-2588.2, 9659.3, 0.0},
            {-2461.5, 9659.3, 799.8},
            {-2093.9, 9659.3, 1521.3},
            {-1521.3, 9659.3, 2093.9},
            {-799.8, 9659.3, 2461.5},
            {2093.9, 9659.3, 1521.3},
            {163.5, 9876.9, -1555.8},
            {-636.3, 9876.9, 1429.1},
            {-1215.7, 9876.9, 984.5},
            {-1530.2, 9876.9, 325.2},
            {-1511.0, 9876.9, -404.9},
            {-1162.5, 9876.9, -1046.8},
            {-560.6, 9876.9, -1460.4},
            {852.0, 9876.9, -1312.0},
            {1354.8, 9876.9, -782.2},
            {1562.2, 9876.9, -81.9},
            {1429.1, 9876.9, 636.3},
            {984.5, 9876.9, 1215.7},
            {325.2, 9876.9, 1530.2},
            {2461.5, 9659.3, -799.8},
            {2093.9, 9659.3, -1521.3},
            {1521.3, 9659.3, -2093.9},
            {799.8, 9659.3, -2461.5},
            {0.0, 9659.3, -2588.2},
            {0.0, 9335.8, -3583.7},
            {0.0, 8910.1, -4539.9},
            {943.9, 8910.1, -4440.7},
            {745.1, 9335.8, -3505.4},
            {1457.6, 9335.8, -3273.9},
            {1846.5, 8910.1, -4147.4},
            {2668.5, 8910.1, -3672.9},
            {2106.4, 9335.8, -2899.3},
            {2663.2, 9335.8, -2397.9},
            {3373.8, 8910.1, -3037.8},
            {3103.6, 9335.8, -1791.8},
            {3931.7, 8910.1, -2270.0},
            {3408.3, 9335.8, -1107.4},
            {4317.7, 8910.1, -1402.9},
            {3564.0, 9335.8, -374.6},
            {4515.0, 8910.1, -474.6},
            {3564.0, 9335.8, 374.6},
            {4515.0, 8910.1, 474.5},
            {3408.3, 9335.8, 1107.4},
            {4317.7, 8910.1, 1402.9},
            {3103.6, 9335.8, 1791.8},
            {3931.7, 8910.1, 2269.9},
            {2663.2, 9335.8, 2397.9},
            {3373.8, 8910.1, 3037.8},
            {2106.4, 9335.8, 2899.3},
            {2668.5, 8910.1, 3672.9},
            {1457.6, 9335.8, 3273.9},
            {1846.5, 8910.1, 4147.4},
            {745.1, 9335.8, 3505.4},
            {943.9, 8910.1, 4440.7},
            {0.0, 9335.8, 3583.7},
            {0.0, 8910.1, 4539.9},
            {-522.6, 8660.3, 4972.6},
            {522.6, 8660.3, 4972.6},
            {0.0, 8386.7, 5446.4},
            {614.4, 8090.2, 5845.7},
            {-1545.1, 8660.3, 4755.3},
            {-2500.0, 8660.3, 4330.1},
            {-3345.7, 8660.3, 3715.7},
            {-4045.1, 8660.3, 2938.9},
            {-4567.7, 8660.3, 2033.7},
            {-4890.7, 8660.3, 1039.5},
            {-5000.0, 8660.3, 0.0},
            {-4890.7, 8660.3, -1039.6},
            {-4567.7, 8660.3, -2033.7},
            {-4045.1, 8660.3, -2939.0},
            {-3345.6, 8660.3, -3715.8},
            {-2500.0, 8660.3, -4330.2},
            {-1545.0, 8660.3, -4755.3},
            {-522.6, 8660.3, -4972.6},
            {522.6, 8660.3, -4972.6},
            {1545.1, 8660.3, -4755.3},
            {2500.0, 8660.3, -4330.1},
            {3345.7, 8660.3, -3715.7},
            {4045.1, 8660.3, -2938.9},
            {4567.7, 8660.3, -2033.7},
            {4890.7, 8660.3, -1039.6},
            {5000.0, 8660.3, 0.0},
            {4890.7, 8660.3, 1039.6},
            {4567.7, 8660.3, 2033.7},
            {4045.1, 8660.3, 2938.9},
            {3345.7, 8660.3, 3715.7},
            {2500.0, 8660.3, 4330.1},
            {1545.1, 8660.3, 4755.3},
            {1132.4, 8386.7, 5327.4},
            {1816.4, 8090.2, 5590.2},
            {2215.2, 8386.7, 4975.5},
            {3201.3, 8386.7, 4406.2},
            {2938.9, 8090.2, 5090.4},
            {2559.7, 7771.5, 5749.1},
            {1308.4, 7771.5, 6155.7},
            {0.0, 7771.5, 6293.2},
            {-614.4, 8090.2, 5845.7},
            {-1132.4, 8386.7, 5327.4},
            {-1816.4, 8090.2, 5590.2},
            {-1308.4, 7771.5, 6155.7},
            {-699.4, 7431.4, 6654.7},
            {-2067.7, 7431.4, 6363.8},
            {-2559.7, 7771.5, 5749.1},
            {-2215.3, 8386.7, 4975.5},
            {-3345.7, 7431.4, 5794.8},
            {-2938.9, 8090.2, 5090.4},
            {-3201.3, 8386.7, 4406.2},
            {-3699.1, 7771.5, 5091.3},
            {-4477.4, 7431.4, 4972.6},
            {-3933.1, 8090.2, 4368.1},
            {-4047.5, 8386.7, 3644.3},
            {-4676.8, 7771.5, 4211.0},
            {-5413.4, 7431.4, 3933.0},
            {-4755.3, 8090.2, 3454.9},
            {-4716.7, 8386.7, 2723.2},
            {-5450.1, 7771.5, 3146.6},
            {-6112.8, 7431.4, 2721.6},
            {-5369.7, 8090.2, 2390.7},
            {-5179.8, 8386.7, 1683.0},
            {-5985.2, 7771.5, 1944.7},
            {-6545.1, 7431.4, 1391.2},
            {-5749.4, 8090.2, 1222.0},
            {-5416.6, 8386.7, 569.3},
            {-6258.7, 7771.5, 657.8},
            {-6691.3, 7431.4, 0.0},
            {-5877.9, 8090.2, 0.0},
            {-5416.6, 8386.7, -569.3},
            {-6258.7, 7771.5, -657.9},
            {-6545.1, 7431.4, -1391.2},
            {-5749.4, 8090.2, -1222.1},
            {-5179.8, 8386.7, -1683.1},
            {-5985.2, 7771.5, -1944.8},
            {-6112.8, 7431.4, -2721.6},
            {-5369.7, 8090.2, -2390.8},
            {-4716.7, 8386.7, -2723.2},
            {-5450.0, 7771.5, -3146.6},
            {-5413.3, 7431.4, -3933.1},
            {-4755.3, 8090.2, -3455.0},
            {-4047.4, 8386.7, -3644.4},
            {-4676.7, 7771.5, -4211.0},
            {-4477.3, 7431.4, -4972.7},
            {-3933.0, 8090.2, -4368.1},
            {-3201.3, 8386.7, -4406.3},
            {-3699.0, 7771.5, -5091.3},
            {-3345.6, 7431.4, -5794.9},
            {-2938.9, 8090.2, -5090.4},
            {-2215.2, 8386.7, -4975.5},
            {-2559.6, 7771.5, -5749.2},
            {-2067.7, 7431.4, -6363.8},
            {-1816.3, 8090.2, -5590.2},
            {-1132.3, 8386.7, -5327.4},
            {-1308.4, 7771.5, -6155.7},
            {-699.4, 7431.4, -6654.7},
            {-614.3, 8090.2, -5845.7},
            {0.0, 8386.7, -5446.4},
            {0.0, 7771.5, -6293.2},
            {699.4, 7431.4, -6654.7},
            {614.4, 8090.2, -5845.7},
            {1132.4, 8386.7, -5327.4},
            {1308.4, 7771.5, -6155.7},
            {2067.7, 7431.4, -6363.8},
            {1816.4, 8090.2, -5590.2},
            {2215.2, 8386.7, -4975.5},
            {2559.7, 7771.5, -5749.1},
            {3345.7, 7431.4, -5794.8},
            {2938.9, 8090.2, -5090.4},
            {3201.3, 8386.7, -4406.2},
            {3699.1, 7771.5, -5091.3},
            {4477.4, 7431.4, -4972.6},
            {3933.1, 8090.2, -4368.1},
            {4047.5, 8386.7, -3644.3},
            {4676.8, 7771.5, -4211.0},
            {5413.4, 7431.4, -3933.1},
            {4755.3, 8090.2, -3454.9},
            {4716.7, 8386.7, -2723.2},
            {5450.1, 7771.5, -3146.6},
            {6112.8, 7431.4, -2721.6},
            {5369.7, 8090.2, -2390.7},
            {5179.8, 8386.7, -1683.0},
            {5985.2, 7771.5, -1944.7},
            {6545.1, 7431.4, -1391.2},
            {5749.4, 8090.2, -1222.1},
            {5416.6, 8386.7, -569.3},
            {6258.7, 7771.5, -657.8},
            {6691.3, 7431.4, 0.0},
            {5877.9, 8090.2, 0.0},
            {5416.6, 8386.7, 569.3},
            {6258.7, 7771.5, 657.8},
            {6545.1, 7431.4, 1391.2},
            {5749.4, 8090.2, 1222.1},
            {5179.8, 8386.7, 1683.0},
            {5985.2, 7771.5, 1944.7},
            {6112.8, 7431.4, 2721.6},
            {5369.7, 8090.2, 2390.7},
            {4716.7, 8386.7, 2723.2},
            {5450.1, 7771.5, 3146.6},
            {5413.4, 7431.4, 3933.0},
            {4755.3, 8090.2, 3454.9},
            {4047.5, 8386.7, 3644.3},
            {4676.8, 7771.5, 4211.0},
            {4477.4, 7431.4, 4972.6},
            {3933.1, 8090.2, 4368.1},
            {3699.1, 7771.5, 5091.3},
            {3345.7, 7431.4, 5794.8},
            {2067.7, 7431.4, 6363.8},
            {699.4, 7431.4, 6654.7},
        };
        public static void preparedraw()
        {
            nodepos.Add(new Vector3(0, 0, 1));
            nodepos.Add(new Vector3(0, 0, -1));
            nodepos.Add(new Vector3(1, 0, 0));
            nodepos.Add(new Vector3(-1, 0, 0));
            for (int j = 0; j < 7; j++)
            {
                Vector3 pos1 = new Vector3((float)dysonposxyz1[j, 0], (float)dysonposxyz1[j, 1], 0) / 10000;
                Vector3 pos3 = new Vector3((float)dysonposxyz1[j, 0], -(float)dysonposxyz1[j, 1], 0) / 10000;
                Vector3 pos2 = new Vector3(-(float)dysonposxyz1[j, 0], (float)dysonposxyz1[j, 1], 0) / 10000;
                Vector3 pos4 = new Vector3(-(float)dysonposxyz1[j, 0], -(float)dysonposxyz1[j, 1], 0) / 10000;
                nodepos.Add(pos1);
                nodepos.Add(pos2);
                nodepos.Add(pos3);
                nodepos.Add(pos4);
            }
            for (int j = 0; j < 7; j++)
            {
                Vector3 pos1 = new Vector3(0, (float)dysonposxyz1[j, 1], (float)dysonposxyz1[j, 0]) / 10000;
                Vector3 pos2 = new Vector3(0, (float)dysonposxyz1[j, 1], -(float)dysonposxyz1[j, 0]) / 10000;
                Vector3 pos3 = new Vector3(0, -(float)dysonposxyz1[j, 1], (float)dysonposxyz1[j, 0]) / 10000;
                Vector3 pos4 = new Vector3(0, -(float)dysonposxyz1[j, 1], -(float)dysonposxyz1[j, 0]) / 10000;
                nodepos.Add(pos1);
                nodepos.Add(pos2);
                nodepos.Add(pos3);
                nodepos.Add(pos4);
            }
            for (int j = 0; j < 14; j++)
            {
                Vector3 pos1 = new Vector3((float)dysonposxyz2[j, 0], (float)dysonposxyz2[j, 1], (float)dysonposxyz2[j, 2]) / 10000;
                Vector3 pos2 = new Vector3(-(float)dysonposxyz2[j, 0], (float)dysonposxyz2[j, 1], (float)dysonposxyz2[j, 2]) / 10000;
                nodepos.Add(pos1);
                nodepos.Add(pos2);
            }
            for (int j = 0; j < 14; j++)
            {
                Vector3 pos1 = new Vector3(-(float)dysonposxyz2[j, 0], (float)dysonposxyz2[j, 1], -(float)dysonposxyz2[j, 2]) / 10000;
                Vector3 pos2 = new Vector3((float)dysonposxyz2[j, 0], (float)dysonposxyz2[j, 1], -(float)dysonposxyz2[j, 2]) / 10000;
                nodepos.Add(pos1);
                nodepos.Add(pos2);
            }
            int[,] temp = new int[8, 3] { { 1, 1, 1 }, { 1, 1, -1 }, { 1, -1, 1 }, { 1, -1, -1 }, { -1, 1, 1 }, { -1, 1, -1 }, { -1, -1, 1 }, { -1, -1, -1 } };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 98; j++)
                {
                    Vector3 pos = new Vector3((float)dysonposxyz3[j, 0] * temp[i, 0], (float)dysonposxyz3[j, 1] * temp[i, 1], (float)dysonposxyz3[j, 2] * temp[i, 2]) / 11000;

                    nodepos.Add(pos);
                }
            }
            for (int j = 0; j < 244; j++)
            {
                Vector3 pos1 = new Vector3((float)dysonposxyz4[j, 0], (float)dysonposxyz4[j, 1], (float)dysonposxyz4[j, 2]) / 10000;
                Vector3 pos2 = new Vector3((float)dysonposxyz4[j, 0], -(float)dysonposxyz4[j, 1], (float)dysonposxyz4[j, 2]) / 10000;
                nodepos.Add(pos1);
                nodepos.Add(pos2);
            }


        }

    }
}
