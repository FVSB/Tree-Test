

Tree<int> first = new Tree<int>(1, new List<Tree<int>>() { });
Tree<int> firs = new Tree<int>(2, new List<Tree<int>>() { });
Tree<int> fir = new Tree<int>(3, new List<Tree<int>>() { });
Tree<int> fi = new Tree<int>(4, new List<Tree<int>>() { });
Tree<int> f = new Tree<int>(5, new List<Tree<int>>() { });
Tree<int> irst = new Tree<int>(6, new List<Tree<int>>() { });
Tree<int> rst = new Tree<int>(7, new List<Tree<int>>() { });
Tree<int> st = new Tree<int>(8, new List<Tree<int>>() { });
Tree<int> t = new Tree<int>(9, new List<Tree<int>>() { });
first.AddChildren(firs);
firs.AddChildren(fir);
firs.AddChildren(fi);
firs.AddChildren(f);
fir.AddChildren(irst);
fir.AddChildren(st);
fir.AddChildren(rst);
first.AddChildren(t);

System.Console.WriteLine(first.SearchBfS(7));

System.Console.WriteLine(first.Dfs(7));
System.Console.WriteLine(first.DFS(7));


