namespace CSharpLib
{
    public static class Extension1 { public static string A(this string _) => "string specific"; }
    public static class Extension2 { public static string A<T>(this T _) => $"generic({typeof(T)})"; }
}
