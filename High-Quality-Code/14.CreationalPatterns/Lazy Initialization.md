# Lazy Initialization

"Мързеливото" инициализиране представлява тактика за отлоагане във времето създаването на обект, изчисляването на стойност или на някакъв друг отнемащ ресурси процес, до момента в който не ни е нужен за първи път.

## Основания за използването му

> Основоно този модел се използва, когато искаме да пестим ресурс от създаване на обект преди той да е нужен.
> Понякога големи части от код не се изпълняват при текущо използване на дадена програма и тяхното инициализиране би забавило програмата.

## Как се реализира

* Чрез скриване на конструктора на обект в Get метода на негово пропърти.
* Или чрез използването на клас Lazy<Т>.

## Реализация

![Lazy Initialization][Lazy_Initialization]

[Lazy_Initialization]: http://www.foreui.com/wordpress/wp-content/uploads/2013/01/compare_lazy_loading.gif "Lazy Initialization"


#### - C#

from (old Lazy):
```cs
private MyClass _myProperty;
public MyClass MyProperty
{
    get
    {
        if (_myProperty == null)
        {
            _myProperty = new MyClass();
        }
        return _myProperty;
    }
}

```
- Това е остарелия метод.

to (new Lazy):
```cs
private Lazy<MyClass> _myProperty = new Lazy<MyClass>( () => new MyClass());

public MyClass MyProperty
{
    get
    {
        return _myProperty.Value;
    }
}
```
- След .Net4.0 и нагоре, може да се ползва клас Lazy<T>.

#### - JavaScript

from (not Lazy):
```javascript
	function getHttp() {
        if (typeof XMLHttpRequest != 'undefined') {
            return new XMLHttpRequest();
        } else if (typeof ActiveXObject != 'undefined') {
            return new ActiveXObject("MSXML2.XMLHttp");
        }
    }
    var http = getHttp();
	
```
to (Lazy):
```javascript
	function lazyHttp() {
        if (typeof XMLHttpRequest != 'undefined') {
            lazyHttp = function() { return new XMLHttpRequest(); }
        } else if (typeof ActiveXObject != 'undefined') {
            lazyHttp = function() { return new ActiveXObject("MSXML2.XMLHttp"); }
        }
        return lazyHttp();
    }
    var http = lazyHttp();
```
