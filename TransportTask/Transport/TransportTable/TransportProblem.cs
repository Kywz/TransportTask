﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TransportTask.Transport.TransportTable
{
    public class TransportProblem
    {
        class InvalidInpFormat : ApplicationException
        {
            public InvalidInpFormat() : base() { }
            public InvalidInpFormat(string str) : base(str) { }
            public override string ToString()
            {
                return Message;
            }
        }

        public float[] mA;
        public float[] mB;
        public float[,] mC;
        public int ASize;
        public int BSize;
        private Point[] cycle;

        public TransportProblem(float[] nA, float[] nB, float[,] nC)
        {
            if ((nA.Length != nC.GetLength(0)) || (nB.Length != nC.GetLength(1)))
                throw new InvalidInpFormat("Розміри масиву витрат не відповідають розмірам масиву потреб та запасів");
            this.mA = nA; this.mB = nB; this.mC = nC;
            this.ASize = nA.Length; this.BSize = nB.Length;
        }
        

        bool isEmpty(float[] arr)
        {
            return Array.TrueForAll(arr, delegate (float x) { return x == 0; });
        }

        private void NanToEmpty(float[,] outArr)
        {
            int i = 0, j = 0;
            for (i = 0; i < ASize; i++)
                for (j = 0; j < BSize; j++)
                    if (outArr[i, j] == 0) outArr[i, j] = float.NaN;
        }


        // Метод північно-західного кута
        public float[,] NordWest()
        {
            float[] Ahelp = mA;
            float[] Bhelp = mB;
            int i = 0, j = 0;
            float[,] outArr = new float[ASize, BSize];
            NanToEmpty(outArr);
            while (!(isEmpty(Ahelp) && isEmpty(Bhelp)))
            {
                float Dif = Math.Min(Ahelp[i], Bhelp[j]);
                outArr[i, j] = Dif;
                Ahelp[i] -= Dif; Bhelp[j] -= Dif;
                if ((Ahelp[i] == 0) && (Bhelp[j] == 0) && (j + 1 < BSize)) outArr[i, j + 1] = 0;
                if (Ahelp[i] == 0) i++;
                if (Bhelp[j] == 0) j++;
            }
            return outArr;
        }

        class FindWay
        {
            FindWay Father;
            Point Root;
            FindWay[] Childrens;
            Point[] mAllowed;
            Point Begining;
            bool flag;
            public FindWay(int x, int y, bool _flag, Point[] _mAllowed, Point _Beg, FindWay _Father)
            {
                Begining = _Beg;
                flag = _flag;
                Root = new Point(x, y);
                mAllowed = _mAllowed;
                Father = _Father;
            }
            public Boolean BuildTree()
            {
                Point[] ps = new Point[mAllowed.Length];
                int Count = 0;
                for (int i = 0; i < mAllowed.Length; i++)
                    if (flag)
                    {
                        if (Root.Y == mAllowed[i].Y)
                        {
                            Count++;
                            ps[Count - 1] = mAllowed[i];
                        }

                    }
                    else
                        if (Root.X == mAllowed[i].X)
                    {
                        Count++;
                        ps[Count - 1] = mAllowed[i];
                    }

                FindWay fwu = this;
                Childrens = new FindWay[Count];
                int k = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (ps[i] == Root) continue;
                    if (ps[i] == Begining)
                    {
                        while (fwu != null)
                        {
                            mAllowed[k] = fwu.Root;
                            fwu = fwu.Father;
                            k++;
                        };
                        for (; k < mAllowed.Length; k++) mAllowed[k] = new Point(-1, -1);
                        return true;
                    }

                    if (!Array.TrueForAll<Point>(ps, p => ((p.X == 0) && (p.Y == 0))))
                    {
                        Childrens[i] = new FindWay(ps[i].X, ps[i].Y, !flag, mAllowed, Begining, this);
                        Boolean result = Childrens[i].BuildTree();
                        if (result) return true;
                    }
                }
                return false;
            }

        }


        private void FindUV(float[] U, float[] V, float[,] HelpMatr)
        {
            bool[] U1 = new bool[ASize];
            bool[] U2 = new bool[ASize];
            bool[] V1 = new bool[BSize];
            bool[] V2 = new bool[BSize];
          
            while (!(AllTrue(V1) && AllTrue(U1)))
            {
                int i = -1;
                int j = -1;
                for (int i1 = BSize - 1; i1 >= 0; i1--)
                    if (V1[i1] && !V2[i1]) i = i1;
                for (int j1 = ASize - 1; j1 >= 0; j1--)
                    if (U1[j1] && !U2[j1]) j = j1;

                if ((j == -1) && (i == -1))
                    for (int i1 = BSize - 1; i1 >= 0; i1--)
                        if (!V1[i1] && !V2[i1])
                        {
                            i = i1;
                            V[i] = 0;
                            V1[i] = true;
                            break;
                        }
                if ((j == -1) && (i == -1))
                    for (int j1 = ASize - 1; j1 >= 0; j1--)
                        if (!U1[j1] && !U2[j1])
                        {
                            j = j1;
                            U[j] = 0;
                            U1[j] = true;
                            break;
                        }

                if (i != -1)
                {
                    for (int j1 = 0; j1 < ASize; j1++)
                    {
                        if (!U1[j1]) U[j1] = HelpMatr[j1, i] - V[i];
                        if (U[j1] == U[j1]) U1[j1] = true;
                    }
                    V2[i] = true;
                }

                if (j != -1)
                {
                    for (int i1 = 0; i1 < BSize; i1++)
                    {
                        if (!V1[i1]) V[i1] = HelpMatr[j, i1] - U[j];
                        if (V[i1] == V[i1]) V1[i1] = true;
                    }
                    U2[j] = true;
                }

            }
            int rt = 0;
        }

        private Boolean AllPositive(float[,] m)
        {
            Boolean p = true;
            for (int i = 0; (i < ASize) && p; i++)
                for (int j = 0; (j < BSize) && p; j++)
                    if (m[i, j] < 0) p = false;
            return p;
        }

        private bool AllTrue(bool[] arr)
        {
            return Array.TrueForAll(arr, delegate (bool x) { return x; });
        }

        private float[,] MakeSMatr(float[,] M, float[] U, float[] V)
        {

            float[,] HM = new float[ASize, BSize];
            for (int i = 0; i < ASize; i++)
                for (int j = 0; j < BSize; j++)
                {
                    HM[i, j] = M[i, j];
                    if (HM[i, j] != HM[i, j])
                        HM[i, j] = mC[i, j] - (U[i] + V[j]);
                }
            return HM;
        }

        private Point[] Allowed;

        public int[] arra = new int[5];

        private Point[] GetCycle(int x, int y)
        {
            Point Beg = new Point(x, y);
            FindWay fw = new FindWay(x, y, true, Allowed, Beg, null);
            fw.BuildTree();
            Point[] Way = Array.FindAll<Point>(Allowed, delegate (Point p) { return (p.X != -1) && (p.Y != -1); });
            return Way;
        }

        private void Roll(float[,] m, float[,] sm)
        {
            Point minInd = new Point();
            float min = float.MaxValue;
            int k = 0;
            Allowed = new Point[ASize + BSize];
            for (int i = 0; i < ASize; i++)
                for (int j = 0; j < BSize; j++)
                {
                    if (m[i, j] == m[i, j])
                    {
                        Allowed[k].X = i;
                        Allowed[k].Y = j;
                        k++;
                    }
                    if (sm[i, j] < min)
                    {
                        min = sm[i, j];
                        minInd.X = i;
                        minInd.Y = j;
                    }
                }
            Allowed[Allowed.Length - 1] = minInd;
            Point[] Cycle = GetCycle(minInd.X, minInd.Y);
            float[] Cycles = new float[Cycle.Length];
            Boolean[] bCycles = new Boolean[Cycle.Length];
            for (int i = 0; i < bCycles.Length; i++)
                bCycles[i] = i == bCycles.Length - 1 ? false : true;
            min = float.MaxValue;
            for (int i = 0; i < Cycle.Length; i++)
            {
                Cycles[i] = m[Cycle[i].X, Cycle[i].Y];
                if ((i % 2 == 0) && (Cycles[i] == Cycles[i]) && (Cycles[i] < min))
                {
                    min = Cycles[i];
                    minInd = Cycle[i];
                }
                if (Cycles[i] != Cycles[i]) Cycles[i] = 0;
            }
            int point1 = 0;
            for (int i = 0; i < Cycle.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Cycles[i] -= min;
                    m[Cycle[i].X, Cycle[i].Y] -= min;
                }
                else
                {
                    Cycles[i] += min;
                    if (m[Cycle[i].X, Cycle[i].Y] != m[Cycle[i].X, Cycle[i].Y]) m[Cycle[i].X, Cycle[i].Y] = 0;
                    m[Cycle[i].X, Cycle[i].Y] += min;
                }
            }
            m[minInd.X, minInd.Y] = float.NaN;
        }

        public float[,] PotenMeth(float[,] SupArr)
        {
            int i = 0, j = 0;
            float[,] HelpMatr = new float[ASize, BSize];
            for (i = 0; i < ASize; i++)
                for (j = 0; j < BSize; j++)
                    if (SupArr[i, j] == SupArr[i, j]) HelpMatr[i, j] = mC[i, j];
                    else HelpMatr[i, j] = float.NaN;

            float[] U = new float[ASize];
            float[] V = new float[BSize];
            FindUV(U, V, HelpMatr);
            float[,] SMatr = MakeSMatr(HelpMatr, U, V);
            while (!AllPositive(SMatr))
            {
                Roll(SupArr, SMatr);
                for (i = 0; i < ASize; i++)
                    for (j = 0; j < BSize; j++)
                    {
                        if (SupArr[i, j] == float.PositiveInfinity)
                        {
                            HelpMatr[i, j] = mC[i, j];
                            SupArr[i, j] = 0;
                            continue;
                        }
                        if (SupArr[i, j] == SupArr[i, j]) HelpMatr[i, j] = mC[i, j];
                        else HelpMatr[i, j] = float.NaN;
                    }
                FindUV(U, V, HelpMatr);
                SMatr = MakeSMatr(HelpMatr, U, V);
            }

            return SupArr;
        }

    }
}
