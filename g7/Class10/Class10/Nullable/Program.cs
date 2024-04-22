using Nullable;

Person person = new Person();
Console.WriteLine(person.id);
Console.WriteLine(person.Score);

//person.id = null; //it will throw error since its not nullable type, in the class it doesnt have ? after the type
person.Score = null;

Console.WriteLine(person.IsEmployed); // false by default;
Console.WriteLine(person.HasPet); // is null

//person.IsEmployed = null; //it will throw error since its not nullable type, in the class it doesnt have ? after the type
person.HasPet = null;
Console.ReadLine();

#region MoreExamples for students to try with chaging the properties od the person and user model
// // uncomment and try the code bellow to see where will be error and try to fix them
//var user = new User();

//if (user.FullName == null)
//{
//    // code ...
//}

//long emb = 0;
//if (user.EMB.HasValue)
//{
//    emb = user.EMB.Value;
//}

//int? age = user.Age;
//Nullable<int> age1 = user.Age;

//int ageValue = user.Age.Value;

//// null coalescing

//long emb1 = 0;
//if (user.EMB.HasValue)
//{
//    emb1 = user.EMB.Value;
//}

//long emb2 = user.EMB ?? 0;

//List<int?> listOfNullableIntegers = new List<int?>() { 1, 2, 3, null, null, 3, null, null };


#endregion