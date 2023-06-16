using Packt.Shared;

Person harry = new(){
    Name = "Harry", 
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};

harry.WriteToConsole();

//non-generic lookup collection
System.Collections.Hashtable lookUpObject = new();
lookUpObject.Add(key: 1, value: "Alpha");
lookUpObject.Add(key: 2, value: "Beta");
lookUpObject.Add(key: 3, value: "Gamma");
lookUpObject.Add(key: harry, value: "Delta");

int key = 2;

WriteLine(format: "Key {0} has value: {1}.",
    arg0: key,
    arg1: lookUpObject[key]            
);      

WriteLine(format: "Key {0} has value: {1}.",
    arg0: harry,
    arg1: lookUpObject[harry]            
);      

WriteLine();

//generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;

WriteLine(format: "Key {0} has value: {1}.",
    arg0: key,
    arg1: lookupIntString[key]            
);
WriteLine();

harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout2;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

Person?[] people = {
    null,
    new() { Name = "Simon"},
    new() { Name = "Jenny"},
    new() { Name = "Adam"},
    new() { Name = null},
    new() { Name = "Richard"},
};

OutputPeopleNames(people, "Initial list of people:");

Array.Sort(people);

OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");

Array.Sort(people, new PersonComparer());

OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation:");
WriteLine();

int a = 3;
int b = 3;

WriteLine($"a: {a}, b: {b}");
WriteLine($"a == b: {(a == b)}");

Person p1 = new() { Name = "Kevin" };
Person p2 = new() { Name = "Kevin" };
WriteLine();

WriteLine($"p1: {p1}, p2: {p2}");
WriteLine($"p1 == p2: {(p1 == p2)}");
WriteLine();

WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1.Name == p2.Name: {(p1.Name == p2.Name)}");
WriteLine();

Person p3 = p1;

WriteLine($"p3: {p3}");
WriteLine($"p1 == p3: {(p1 == p3)}");

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;
WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");
WriteLine();

DisplacementVector dv4 = new();
WriteLine($"({dv4.X}, {dv4.Y})");
WriteLine();

Employee john = new(){
    Name = "John Jones",
    DateOfBirth = new(year:1990, month: 7, day: 28)
};
john.WriteToConsole();
