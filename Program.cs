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

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

