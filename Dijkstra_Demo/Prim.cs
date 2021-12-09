using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Dijkstra_Demo
{
    internal class Prim
    {
        public void PrimSimple(string[] pesude, ListView lv, ListView lvtable, int n, int s, int e, out bool isPath, List<Point> pt, List<Form1.Segment> segment, List<Form1.Segment> tmp, List<int> _segment, List<List<Form1.Segment>> Segment_Review)
        {
            tmp.Clear();

            lvtable.Clear();
            Segment_Review.Clear();
            _segment.Clear();


            ListViewItem it = new ListViewItem("(oo, -)");

            for (int i = 1; i < n; ++i) lvtable.Columns.Add(i.ToString(), 80);

            for (int i = 1; i < n; ++i) it.SubItems.Add("(oo, -)");

            it.SubItems[s].Text = "(0, " + (s + 1).ToString() + ")*";

            lvtable.Items.Add(it);

            int oo = 99999999;
            List<int> length = new List<int>();
            List<int> last = new List<int>();
            List<int> roads = new List<int>();
            List<bool> visited = new List<bool>();
            isPath = true;

            for (int i = 0; i < n; ++i)
            {
                length.Add(oo);
                last.Add(-1);
                visited.Add(true);
            }

            length[s] = 0;
            visited[s] = false;
            last[s] = s;
            int b = 1;

            int v = s;
            //Bắt đầu chạy
            while (visited[e])
            {
                _segment.Add(v);
                int dem = 0;

                ListViewItem item = new ListViewItem("(oo, -)");
                for (int iv = 1; iv < n; ++iv) item.SubItems.Add("(oo, -)");

                item.SubItems[v].Text = "-";

                List<Form1.Segment> segment_load = new List<Form1.Segment>();

                for (int i = 0; i < n - 1; ++i)
                {
                    int num = int.Parse(lv.Items[v].SubItems[i + 1].Text);
                    int temp = length[i];

                    if (lv.Items[v].SubItems[i + 1].Text == "0") ++dem;

                    if (!visited[i]) item.SubItems[i].Text = "-";
                    else if (length[i] == temp && b != 1) item.SubItems[i].Text = lvtable.Items[b - 1].SubItems[i].Text;

                    if (lv.Items[v].SubItems[i + 1].Text != "0" && visited[i] && (length[i] == oo || length[i] >= length[v] + num))
                    {
                        length[i] = length[v] + num;
                        last[i] = v;
                        item.SubItems[i].Text = "(" + length[i].ToString() + ", " + (last[i] + 1).ToString() + ")";
                    }
                }

                //if (dem == n - 1) { txb.Text = "No Path!"; isPath = false; break; }

                int Mins = oo;

                for (int i = 0; i < n; ++i)
                {
                    if (visited[i] && length[i] != oo)
                    {
                        if (Mins > length[i])
                        {
                            v = i;
                            Mins = length[i];
                            Console.WriteLine(pesude[1]);
                        }
                    }
                }

                Segment_Review.Add(segment_load);

                item.SubItems[v].Text += "*";
                lvtable.Items.Add(item);

                visited[v] = false;

                ++b;
            }

            if (isPath)
            {
                _segment.Add(e);

                int k = e;
                //Truy vết
                while (k != s)
                {
                    roads.Add(k);
                    k = last[k];
                    Console.WriteLine(pesude[2]);
                }

                roads.Add(s);

                //txb.Text += "Shortest Path [" + (s + 1).ToString() + "->" + (e + 1).ToString() + "] : ";
                for (int i = roads.Count - 1; i > 0; --i)
                {
                    tmp.Add(new Form1.Segment(roads[i], roads[i - 1], checkIndexWidth(segment, roads[i], roads[i - 1])));
                    //txb.Text += (roads[i] + 1).ToString() + " --> ";
                }

                //txb.Text += (roads[0] + 1).ToString() + "\n Length: " + length[e].ToString();
            }
        }

        //Hàm dijkstra chạy từ 1 đểm đến tất cả
        public List<Form1.Segment> PrimAll(ListView lv, ListView lvtable, int n, int s, out bool isPath, List<Point> pt, List<Form1.Segment> segment, List<Form1.Segment> tmp)
        {
            tmp.Clear();

            lvtable.Clear();

            List<Form1.Segment> tree = new List<Form1.Segment>();

            int oo = 99999999;
            List<int> length = new List<int>();
            List<int> last = new List<int>();
            List<bool> visited = new List<bool>();
            isPath = true;

            last.Add(s);
           
            //Bắt đàu chạy
            while (last.Count < pt.Count)
            {
                var edges = segment.Where(p => (last.Contains(p.S) && !last.Contains(p.E)) || (last.Contains(p.E) && !last.Contains(p.S)));
                var minw = edges.Min(p => Int32.Parse(p.W));
                var minEdge = edges.Where(p => p.W == minw.ToString()).First();
                tree.Add(minEdge);
                segment.Remove(minEdge);
                if (!last.Contains(minEdge.S))
                {
                    last.Add(minEdge.S);
                }
                if (!last.Contains(minEdge.E))
                {
                    last.Add(minEdge.E);
                }
            }

            return tree;
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
