# C# Coding Style

## 1.  Блоки кода.
Блоки кода оформляются в стиле Олмана ([Allman style](http://en.wikipedia.org/wiki/Indent_style#Allman_style)). Каждая скобка располагается на новой строке.
``` cs
if (condition)
{
    // ... body
}
```

## 2.  Внедренные инструкции.
Все внедренные инструкции оформляются в виде блока кода. Даже однострочные внедренные инструкции заключаются в скобки `{ }`.
``` cs
if (condition1)
{
    // ... body
}
else if(condition2)
{
    // ... body
}
else
{
    // ... body
}
```
``` cs
while (condition)
{
    // ... body
}
```
``` cs
using (var foo = new Foo())
{
    // ... body
}
```
Ключевое слово `using` может быть использовано без скобок, если в его тело передан ещё один блок `using`. Все последующие блоки `using` идут без табуляции.
``` cs
using (var foo = new Foo())
using (var bar = new Bar())
{
    // ... body
}
```

## 3.  Модификаторы доступа.
Указание модификаторов доступа обязательно для всех типов и членов.

## 4.  Именование.
Наименование проектов, пространств имен, перечислений, типов делегатов, структур, классов, констант, статических членов, публичных полей, свойств, методов, происходит в `PascalCase`.
``` cs 
namespace Program
{
    public enum FooBar
    {
        Foo,
        Bar
    }
}
``` 
``` cs 
namespace Program
{
    public delegate int FooBar(int foo, int bar);
}
```
``` cs 
namespace Program
{
    public struct Foo
    {
        public int Bar { get; set; }
    }
}
```
``` cs 
namespace Program
{
    public class FooBar
    {
        private static readonly string StaticFoo = "static foo";
        private const string ConstFoo = "const foo";
        public string Foo;
        public int Bar { get; set; }

        public FooBar()
        {
            // ... body
        }

        private void Baz()
        {
            // ... body
        }
    }
}
```
Для приватных полей используется `_camelCase`, начиная с символа нижнего подчеркивания `_`. Если поле определяется единожды при объявлении или в конструкторе, то используется модификатор `readonly`.
``` cs
internal class FooBar
{
    private readonly string _foo = "foo";
    private readonly string _bar;
    private int _baz;

    public Foo()
    {
        _bar = "bar";
    }
}
```
Все локальные переменные, а также аргументы именуются в стиле `camelCase`.
``` cs
public void Foo(int fooBar)
{
    var baz = fooBar + 1;
}
```
Наименование интерфейсов производиться в `PascalCase`. Используется префикс `I`.
``` cs
public interface IFooBar
{
    void Foo();
}
```

## 5.  Порядок элементов класса. 
Элементы располагаются в следующем порядке: 
-   типы,
-   константы,
-   статические поля, конструкторы и методы,
-   поля,
-   события,
-   свойства,
-   конструкторы,
-   деструкторы,
-   методы.

Все элементы класса располагаются в порядке уменьшения уровня доступности:
-   `public`,
-   `protected`,
-   `private`.

``` cs
public class FooBar
{
    public delegate void Delegate();
    protected enum Enum
    {
        // ...
    }
    private interface IInterface
    {
        // ...
    }

    public const string PublicConst = "public const";
    protected const string ProtectedConst = "protected const";
    private const string PrivateConst = "private const";

    public static string PublicStaticField;
    protected static string ProtectedStaticField;
    private static string PrivateStaticField;
    static FooBar()
    {
        // ... body
    }
    public static void PublicStaticMethod()
    {
        // ... body
    }
    protected static void ProtectedStaticMethod()
    {
        // ... body
    }
    private static void PrivateStaticMethod()
    {
        // ... body
    }

    public string PublicField;
    protected string _protectedField;
    private string _privateField;

    public event Delegate PublicEvent
    {
        add => PrivateEvent += value;
        remove => PrivateEvent -= value;
    }
    protected event Delegate ProtectedEvent;
    private event Delegate PrivateEvent;

    public string PublicProperty { get; set; }
    protected string ProtectedProperty { get; set; }
    private string PrivateProperty { get; set; }

    public FooBar() : this(default, default)
    {
        // ... body
    }
    protected FooBar(string foo) : this(foo, default)
    {
        // ... body
    }
    private FooBar(string foo, int bar)
    {
        // ... body
    }

    ~FooBar()
    {
        // ... body
    }

    public void PublicMethod()
    {
        // ... body
    }
    protected void ProtectedMethod()
    {
        // ... body
    }
    private void PrivateMethod()
    {
        // ... body
    }
}
```

## 6. Размещение компонентов.
Каждый компонент располагается в своем отдельном файле, где имя файла полностью совпадает с именем компонента.
``` cs
// FooBar.cs

namespace Foo
{
    public class FooBar
    {
        public void Bar()
        {
            // ... body
        }
    }
}
```

## 7. Обращение к собственным членам.
Не используется ключевое слово `this`, если нет необходимости.

## 8. Обращение к статическим и константным членам.
Обращение осуществляется через класс в котором они определены, а не через потомков.
``` cs
public class FooBar
{
    public const string Foo = "foo";
    // ...
}

public class Bar : FooBar
{
    // ...
}

public static void Main()
{
    // ...
    var foo = FooBar.Foo; // вместо Bar.Foo
}
```

## 9. Кортежи.
Кортежи не используются в публичном API. Предпочитаются именованные кортежи (доступны с C# 7.0). Имена элементов задаются в стиле `camelCase`.
``` cs
var tuple = (fooBar: "fooBar", foo: "foo");
```

## 10. Вложенные типы.
Вложенные типы не используются в публичном API.

## 11. Анонимные типы.
Явная типизация предпочтительней анонимных типов.

## 12. Объявление и определение локальных переменных.
Вместо явного указания типов предпочитается ключевое слово `var` для объявления локальных переменных, где тип переменной понятен из определения.
``` cs
var foo = "foo";
```
Для значений по умолчанию предпочитается ключевое слово `default`, когда требуется явно определить переменную.
``` cs
int i = default; // до C# 7.1 default(int); 
```

## 13. Интерполяция строк.
Предпочитается интерполяция строк вместо конкатенации.
``` cs
var foo = 3.1416;
var bar = DateTime.Now;
var fooBar = $"{foo:0.000}, {bar:yyyy.MM.dd HH:mm:ss}";
```

## 14. Квалификация идентификатора.
Предпочитаются директивы `using`, чтобы упростить квалификацию идентификатора.
``` cs
using System.Threading.Tasks;

public static void Main()
{
    var task = new Task(() => { /* ... body */ });
    // вместо
    // var task = new System.Threading.Tasks.Task(() => { /* ... body */ });
}
```

## 15. Инициализаторы объектов и коллекций.
Предпочитаются инициализаторы для определения экземпляров классов или коллекций.
``` cs
public class FooBar
{
    public int Foo { get; set; }
    public int Bar { get; set; }
}

public static void Main()
{
    var fooBar = new FooBar
    {
        Foo = 1,
        Bar = 2
    };
    // вместо 
    // var fooBar = new FooBar();
    // fooBar.Foo = 1;
    // fooBar.Bar = 2;
}
```
``` cs
public static void Main()
{
    var fooBar = new List<int>
    {
        1,
        2
    };
    // вместо 
    // var fooBar = new List<int>();
    // fooBar.Add(1);
    // fooBar.Add(2);
}
```
