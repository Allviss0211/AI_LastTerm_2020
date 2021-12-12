using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Dijkstra_Demo
{
    internal class Prim
    {
        public void PrimSimple(ListView lv, ListView lvtable, int n, int s, out bool isPath, List<Point> pt, List<Form1.Segment> segment, List<Form1.Segment> tmp, List<Form1.Segment> segment_prim, List<int> segment_review)
        {
            tmp.Clear();
            segment_review.Clear();

            lvtable.Clear();

            List<Form1.Segment> tree = new List<Form1.Segment>();

            if (tree.Count == 0)
            {
                tree = segment.Select(x => x).ToList();
            }

            int oo = 99999999;
            List<int> last = new List<int>();
            List<bool> visited = new List<bool>();
            isPath = true;

            if(!segment_review.Contains(s))
                segment_review.Add(s);

            for (int i = 0; i < n; ++i)
            {
                //length.Add(oo);
                //last.Add(-1);
                visited.Add(false);
            }

            //Bắt đàu chạy

            while (segment_review.Count < pt.Count)
            {
                var edges = segment.Where(p => (segment_review.Contains(p.S) && !segment_review.Contains(p.E)) || (segment_review.Contains(p.E) && !segment_review.Contains(p.S)));
                var minw = edges.Min(p => Int32.Parse(p.W));
                var minEdge = edges.Where(p => p.W == minw.ToString()).First();
                segment_prim.Add(minEdge);

                tree.Remove(minEdge);

                if (!segment_review.Contains(minEdge.S))
                {
                    segment_review.Add(minEdge.S);
                    visited[minEdge.S] = true;
                }
                if (!segment_review.Contains(minEdge.E))
                {
                    segment_review.Add(minEdge.E);
                    visited[minEdge.E] = true;
                }
            }

        }

        //Hàm dijkstra chạy từ 1 đểm đến tất cả
        public void PrimAll(ListView lv, ListView lvtable, int n, int s, out bool isPath, List<Point> pt, List<Form1.Segment> segment, List<Form1.Segment> tmp)
        {
            tmp.Clear();

            lvtable.Clear();

            int oo = 99999999;
            List<Form1.Segment> segment_tmp = new List<Form1.Segment>();
            if (segment_tmp.Count == 0)
            {
                segment_tmp = segment.Select(x => x).ToList();
            }
            List<int> last = new List<int>();
            List<bool> visited = new List<bool>();
            isPath = true;

            last.Add(s);

            for (int i = 0; i < n; ++i)
            {
                //length.Add(oo);
                //last.Add(-1);
                visited.Add(false);
            }

            //Bắt đàu chạy
            while (last.Count < pt.Count)
            {
                var edges = segment_tmp.Where(p => (last.Contains(p.S) && !last.Contains(p.E)) || (last.Contains(p.E) && !last.Contains(p.S)));
                var minw = edges.Min(p => Int32.Parse(p.W));
                var minEdge = edges.Where(p => p.W == minw.ToString()).First();
                tmp.Add(minEdge);
       
                segment_tmp.Remove(minEdge);
                
                if (!last.Contains(minEdge.S))
                {
                    last.Add(minEdge.S);
                    visited[minEdge.S] = true;
                }
                if (!last.Contains(minEdge.E))
                {
                    last.Add(minEdge.E);
                    visited[minEdge.E] = true;
                }
            }
        }



        //Lấy giá trị trọng số của đường thẳng
        public string checkIndexWidth(List<Form1.Segment> segment, int s, int e)
        {
            //Nếu là độ thị vô hướng

            foreach (Form1.Segment i in segment)
                if ((i.S == s && i.E == e) || (i.E == s && i.S == e)) return i.W;

            return "0";
        }

    }
}
