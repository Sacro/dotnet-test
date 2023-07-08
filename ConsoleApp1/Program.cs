var actions = new List<Func<int>>();

var variable = 0;
while (variable < 5)
{
    actions.Add(() => variable * 2);
    ++ variable;
}

foreach (var act in actions)
{
    Console.WriteLine(act.Invoke());
}
