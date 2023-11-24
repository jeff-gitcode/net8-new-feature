public interface IService
{
    Distance GetDistance();
}

// 1. PrimaryConstructor
public class PrimaryConstructor(IService service) : ControllerBase
{
    [HttpGet]
    public ActionResult<Distance> Get()
    {
        return service.GetDistance();
    }

    // 2. CollectionExpressions
    public int[] CollectionExpressions(int[] row0, int[] row1, int[] row2)
    {
        int[] single = [.. row0, .. row1, .. row2];

        return single;
    }

    // 2.1 TargetTypedNewExpressions
    public void TargetTypedNewExpressions()
    {
        var person = new Person("Bill", "Wagner");
    }

    // 2.2 TargetTypedConditionalExpressions
    public void TargetTypedConditionalExpressions()
    {
        var person = person2 is not null ? person2 : person;
    }

    // 2.3 TargetTypedLambdaExpressions
    public void TargetTypedLambdaExpressions()
    {
        Func<int, int, int> add = (int x, int y) => x + y;
    }

    // 2.4 TargetTypedBinaryOperatorExpressions
    public void TargetTypedBinaryOperatorExpressions()
    {
        int x = 1;
        int y = 2;
        Console.WriteLine(x + y);
    }

    // 2.5 TargetTypedUnaryOperatorExpressions
    public void TargetTypedUnaryOperatorExpressions()
    {
        int x = 1;
        Console.WriteLine(+x);
    }

    // 2.6 TargetTypedConditionalExpressions
    public void TargetTypedConditionalExpressions()
    {
        int x = 1;
        int y = 2;
        Console.WriteLine(x > y ? x : y);
    }

    // 3. Optional parameters in lambda expressions
    public void OptionalParametersInLambdaExpressions()
    {
        Func<int, int, int> add = (int x, int y = 1) => x + y;
        Console.WriteLine(add(1, 2));
        Console.WriteLine(add(1));
    }

    // 4. ref readonly parameters
    public void RefReadonlyParameters()
    {
        int[] arr = { 1, 2, 3 };
        ref readonly int x = ref arr[0];
        Console.WriteLine(x);
    }

    // 5. Alias any type
    public void AliasAnyType()
    {
        using MyInt = System.Int32;
        MyInt x = 1;
        Console.WriteLine(x);
    }

    // 5.1 Using directives
    public void UsingDirectives()
    {
        using System;
        Console.WriteLine("Using directives");
    }

    // 5.2 Global using directives
    public void GlobalUsingDirectives()
    {
        Console.WriteLine("Global using directives");
    }

    // 6. Experimental attribute
    [Experimental]
    public void ExperimentalAttribute()
    {
        Console.WriteLine("Experimental");
    }

    // 7. Interceptors 
    public void Interceptors()
    {
        Console.WriteLine("Interceptors");

    }

    // 8. Record types
    public record Person(string FirstName, string LastName);
    var person = new Person("Bill", "Wagner");

    // 9. Target-typed new expressions
    var person2 = new Person(FirstName: "Bill", LastName: "Wagner");

    // 10. Target-typed conditional expressions
    var person3 = person2 is not null ? person2 : person;

    // 11. Covariant return types
    public class Base { }
    public class Derived : Base { }
    public class BaseFactory
    {
        public virtual Base Create() => new Base();
    }
    public class DerivedFactory : BaseFactory
    {
        public override Derived Create() => new Derived();
    }

    // 12. Pattern matching enhancements
    public void PatternMatchingEnhancements()
    {
        object o = "Hello";
        if (o is string s)
        {
            Console.WriteLine(s);
        }
    }

    // 13. Static local functions
    public void StaticLocalFunctions()
    {
        int x = 1;
        int y = 2;
        Console.WriteLine(Add(x, y));

        static int Add(int left, int right) => left + right;
    }

    // 14. Target-typed ?? operator
    public void TargetTypedNullCoalescingOperator()
    {
        int? x = null;
        int y = 2;
        Console.WriteLine(x ?? y);
    }

    // 15. Lambda discard parameters
    public void LambdaDiscardParameters()
    {
        Func<int, int, int> add = (_, _) => 1;
        Console.WriteLine(add(1, 2));
    }

    // 16. Attributes on local functions
    public void AttributesOnLocalFunctions()
    {
        [Obsolete]
        void LocalFunction()
        {
            Console.WriteLine("LocalFunction");
        }

        LocalFunction();
    }

    // 17. More expression-bodied members
    public void MoreExpressionBodiedMembers()
    {
        int x = 1;
        int y = 2;
        Console.WriteLine(Add(x, y));

        static int Add(int left, int right) => left + right;
    }

    // 18. Static anonymous functions
    public void StaticAnonymousFunctions()
    {
        Func<int, int, int> add = static (int x, int y) => x + y;
        Console.WriteLine(add(1, 2));
    }

    // 19. Using declarations
    public void UsingDeclarations()
    {
        using var reader = new StreamReader("file.txt");
        Console.WriteLine(reader.ReadToEnd());
    }

    // 20. Null-coalescing assignment
    public void NullCoalescingAssignment()
    {
        int? x = null;
        int y = 2;
        Console.WriteLine(x ??= y);
    }

    // 21. Asynchronous streams
    public async IAsyncEnumerable<int> AsynchronousStreams()
    {
        for (int i = 0; i < 10; i++)
        {
            await Task.Delay(100);
            yield return i;
        }
    }

    // 22. Indices and ranges
    public void IndicesAndRanges()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(arr[^1]);
        Console.WriteLine(arr[1..^1]);
    }

    // 23. Default interface methods
    public interface IInterface
    {
        void Method()
        {
            Console.WriteLine("Method");
        }
    }

    // 24. Static abstract members
    public abstract class Base
    {
        public static abstract void Method();
    }

    // 25. Readonly members
    public class ReadonlyMembers
    {
        public readonly int x = 1;
    }

    // 26. Null-coalescing operator
    public void NullCoalescingOperator()
    {
        int? x = null;
        int y = 2;
        Console.WriteLine(x ?? y);
    }

    // 27. Unmanaged constructed types
    public void UnmanagedConstructedTypes()
    {
        Span<int> span = stackalloc int[10];
        Console.WriteLine(span.Length);
    }

    // 28. Stackalloc in nested expressions
    public void StackallocInNestedExpressions()
    {
        Span<int> span = stackalloc[] { 1, 2, 3 };
        Console.WriteLine(span.Length);
    }

    // 29. Enhancement of interpolated verbatim strings
    public void EnhancementOfInterpolatedVerbatimStrings()
    {
        string name = "Bill";
        Console.WriteLine($@"Hello, {name}");
    }

    // 30. Enhancement of interpolated string handlers
    public void EnhancementOfInterpolatedStringHandlers()
    {
        string name = "Bill";
        Console.WriteLine($"Hello, {name}");
    }

    // 31. Params parameter in lamba functions
    public void ParamsParameterInLambaFunctions()
    {
        Func<int, int, int> add = (params int[] args) => args.Sum();
        Console.WriteLine(add(1, 2));
    }

    // 32. Extension GetEnumerator support for foreach loops
    public void ExtensionGetEnumeratorSupportForForeachLoops()
    {
        foreach (var item in new MyEnumerable())
        {
            Console.WriteLine(item);
        }
    }

    // 33. Extension GetEnumerator support for await foreach loops
    public async Task ExtensionGetEnumeratorSupportForAwaitForeachLoops()
    {
        await foreach (var item in new MyAsyncEnumerable())
        {
            Console.WriteLine(item);
        }
    }

    // 34. Extension GetEnumerator support for LINQ queries
    public void ExtensionGetEnumeratorSupportForLINQQueries()
    {
        var query = from item in new MyEnumerable()
                    select item;
    }

    // 35. Interceptors
    static class Program
    {
        public static void Main()
        {
            HelloWord helloWord = new HelloWord();
            helloWord.HelloWorld();
            Console.ReadLine();
        }
    }

    class HelloWord
    {
        public void HelloWorld() => Console.WriteLine("Hello World");
    }

    using System.Runtime.CompilerServices;

    static class Interceptor
{
    [InterceptsLocation("C:\\Personal\\demonet8\\ConsoleApp1\\Program.cs", line: 15, character: 17)]
    public static void InterceptorMethod(this HelloWord c)
    {
        c.HelloWorld();
        Console.WriteLine("Hi!");
    }
}
}