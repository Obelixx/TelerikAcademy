# Object pool

"Басейнът" от обекти представлява набор от инициализирани и готови за употреба обекти. Когато програмата има нужда от даден вид обект, той се взима от басейнът. Когато обектът вече не е нужен, той не се унищожава, а се връща обратно в басейна.

## Основания за използването му

> Когато работим с голям брой от обекти, които са трудни и ресурсоемки за създаване и ни трябват за малко време.
> В такива ситуации използването на този метод може да подобри драстично производителността на програмата.

## Как се реализира

* Чрез скриване на конструктора на обект в Get метода на негово пропърти.
* Или чрез използването на клас Lazy<Т>.

## Реализация

![Object pool][Object_pool]

[Object_pool]: http://patterns.instantinterfaces.nl/current/document_files/image237.png "Object pool"


#### - C#
1 - SharedPools
```cs
// Example 1 - In a using statement, so the object gets freed at the end.
using (PooledObject<Foo> pooledObject = SharedPools.Default<List<Foo>>().GetPooledObject())
{
    // Do something with pooledObject.Object
}

// Example 2 - No using statement so you need to be sure no exceptions are not thrown.
List<Foo> list = SharedPools.Default<List<Foo>>().AllocateAndClear();
// Do something with list
SharedPools.Default<List<Foo>>().Free(list);

// Example 3 - I have also seen this variation of the above pattern, which ends up the same as Example 1, except Example 1 seems to create a new instance of the IDisposable [PooledObject<T>][4] object. This is probably the preferred option if you want fewer GC's.
List<Foo> list = SharedPools.Default<List<Foo>>().AllocateAndClear();
try
{
    // Do something with list
}
finally
{
    SharedPools.Default<List<Foo>>().Free(list);
}
```

2 - ListPool and StringBuilderPool
```cs
// Example 1 - No using statement so you need to be sure no exceptions are thrown.
StringBuilder stringBuilder= StringBuilderPool.Allocate();
// Do something with stringBuilder
StringBuilderPool.Free(stringBuilder);

// Example 2 - Safer version of Example 1.
StringBuilder stringBuilder= StringBuilderPool.Allocate();
try
{
    // Do something with stringBuilder
}
finally
{
    StringBuilderPool.Free(stringBuilder);
}
```

3 - PooledDictionary and PooledHashSet
```cs
// Example 1
PooledHashSet<Foo> hashSet = PooledHashSet<Foo>.GetInstance()
// Do something with hashSet.
hashSet.Free();

// Example 2 - Safer version of Example 1.
PooledHashSet<Foo> hashSet = PooledHashSet<Foo>.GetInstance()
try
{
    // Do something with hashSet.
}
finally
{
    hashSet.Free();
}
```
