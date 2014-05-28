namespace Microsoft.AspNet.Builder
{
    /// <summary>
    /// Extension methods for the StaticFileMiddleware
    /// </summary>
    public static class TypeScriptExtensions
    {
        /// <summary>
        /// Enables building typescript on the file
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IBuilder BuildTypeScript(this IBuilder builder)
        {
            return builder;
        }
    }
}
