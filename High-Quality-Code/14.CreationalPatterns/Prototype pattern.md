# Prototype pattern

Прототопният модел представлява създаване на обекти по шаблонен обект(прототип) вместо използването на конструктор.

## Основания за използването му

> Основоно този модел се използва, когато искаме да пестим ресурс от създаване на нов обект чрез неговия конструктор.
> Понякога създаването на нов обект изисква много ресурси (процесорно време, памет и т.н.) или време (при заявки към бази данни или интенет).
> В някои ситуации може да се спестят ресурсозаемащите операции, като просто клонираме вече съществуващ обект.
> Шаблонният обект, може да е съществуващ и изпоолзван обект, а може и да е отделен обект с някакви стандартни стойности (както във Factory метода).

## Как се реализира

* Определяме вида обект, който ще създаваме, като си набелязваме вече налична негова инстанция.
* Създаваме нов обект, като клонираме негова инстанция.

## Реализация

![Prototype pattern][Prototype_pattern]

[Prototype_pattern]: http://www.oodesign.com/images/stories/prototype%20implementation%20-%20uml%20class%20diagram.gif "Prototype pattern"


#### - C#

```cs
public interface Prototype 
{
	public abstract Object clone ( );
}

public class ConcretePrototype implements Prototype 
{
	public Object clone() 
	{
		return super.clone();
	}
}

public class Client 
{
	public static void main( String arg[] ) 
	{
		ConcretePrototype obj1 = new ConcretePrototype();
		ConcretePrototype obj2 = (ConcretePrototype)obj1.clone();
	}
}
```

- В .Net съществува интерфейсът ICloneable, чрез който можем да имплементираме клониране на обект. Той работи с Object и трябва да се поглрижим да сменим типът на резултата (както е в примера).

#### - JavaScript

```javascript
var base = {
	talk: function() {
		console.log('I am the main base.');
	}
}

var firstBase = {
	talk: function() {
		console.log('I am the first base.');
	}
}
firstBase.prototype = base;

var secondBase =  {};
secondBase.prototype = base;

base.talk(); // logs: I am the main base.
firstBase.talk(); // logs: I am the first base.
secondBase.talk(); // logs: I am the main base.

```
- JavaScript е прототипен език и в него съществува прототипната верига (prototype chain). Тя позволява при липса на пропърти в наследника, той да извика пропъртито на родителя си.
